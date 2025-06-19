using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq; // Make sure this is included for .FirstOrDefault()

namespace egzamin_dyplomowy
{
    public class Termin
    {
        public DateOnly Data { get; set; }
        public TimeOnly Godzina { get; set; }
        public TimeSpan CzasTrwania { get; set; }
        public string Status { get; set; } // Your existing string status
        public Egzamin Egzamin { get; set; }

        public Termin() { }

        public Termin(DateOnly data, TimeOnly godzina, TimeSpan czasTrwania, string status, Egzamin egzamin)
        {
            this.Data = data;
            this.Godzina = godzina;
            this.CzasTrwania = czasTrwania;
            this.Status = status;
            this.Egzamin = egzamin;
        }

        public void WyswietlSzczegoly()
        {
            Console.WriteLine($"Data: {Data.ToShortDateString()}, Godzina: {Godzina}, Czas trwania: {CzasTrwania}, Status: {Status}");
            //Egzamin.WypiszEgzamin(); sorry, nie ma jeszcze takiej funkcji bo krzysiek tego nie zrobił bo nie wymagałem (chyba) - Belzebebe
        }

        public TimeOnly GetStartTime() => Godzina;
        public TimeOnly GetEndTime() => GetStartTime().Add(CzasTrwania);
    }

    public class OperacjeNaTerminach
    {
        private List<Termin> terminy = new List<Termin>();

        public void DodajTermin(Termin termin)
        {
            // The collision check will now also consider the status of terms
            foreach (var istniejącyTermin in terminy)
            {
                if (CzyTerminKoliduje(termin, istniejącyTermin))
                {
                    Debug.WriteLine($"Termin {termin.Data} {termin.Godzina} koliduje z {istniejącyTermin.Data} {istniejącyTermin.Godzina}.");
                    // Only check committee if an exam is present for both terms
                    if (termin.Egzamin != null && istniejącyTermin.Egzamin != null && CzyKomisjaSięPowtarza(termin, istniejącyTermin))
                    {
                        Debug.WriteLine("Nie można dodać terminu: Członkowie komisji się powtarzają.");
                        // You might want to throw an exception or return a specific error/flag here
                        return;
                    }
                }
            }
            terminy.Add(termin);
            Debug.WriteLine($"Termin {termin.Data} {termin.Godzina} dodany pomyślnie ze statusem: {termin.Status}.");
        }

        private bool CzyTerminKoliduje(Termin nowyTermin, Termin istniejącyTermin)
        {
            if (nowyTermin.Data != istniejącyTermin.Data) return false;

            // A term marked as "Odrzucony" does not cause a conflict
            if (nowyTermin.Status == "Odrzucony" || istniejącyTermin.Status == "Odrzucony")
            {
                return false;
            }

            var nowyStart = nowyTermin.GetStartTime();
            var nowyEnd = nowyTermin.GetEndTime();

            // Check for overlap [start1, end1) and [start2, end2)
            // Overlap occurs if (start1 < end2) AND (start2 < end1)
            bool overlaps = (nowyStart < istniejącyTermin.GetEndTime() && nowyEnd > istniejącyTermin.GetStartTime());

            if (overlaps)
            {
                // Apply your 15-minute buffer logic for actual collision within the overlap
                if (nowyStart < istniejącyTermin.GetStartTime().AddMinutes(15) || nowyEnd > istniejącyTermin.GetEndTime().AddMinutes(-15))
                {
                    return true;
                }
            }
            return false;
        }

        private bool CzyKomisjaSięPowtarza(Termin nowyTermin, Termin istniejącyTermin)
        {
            // Ensure Egzamin objects are not null before trying to get committee members
            if (nowyTermin.Egzamin == null || istniejącyTermin.Egzamin == null)
            {
                return false; // No committee to compare if exam is missing
            }

            var komisjaNowa = new List<Wykladowca>();
            if (nowyTermin.Egzamin.getPromotor() != null) komisjaNowa.Add(nowyTermin.Egzamin.getPromotor());
            if (nowyTermin.Egzamin.getRecenzent() != null) komisjaNowa.Add(nowyTermin.Egzamin.getRecenzent());
            if (nowyTermin.Egzamin.getProdziekan() != null) komisjaNowa.Add(nowyTermin.Egzamin.getProdziekan());

            var komisjaIstniejaca = new List<Wykladowca>();
            if (istniejącyTermin.Egzamin.getPromotor() != null) komisjaIstniejaca.Add(istniejącyTermin.Egzamin.getPromotor());
            if (istniejącyTermin.Egzamin.getRecenzent() != null) komisjaIstniejaca.Add(istniejącyTermin.Egzamin.getRecenzent());
            if (istniejącyTermin.Egzamin.getProdziekan() != null) komisjaIstniejaca.Add(istniejącyTermin.Egzamin.getProdziekan());

            // A committee conflict only occurs if both terms are relevant (e.g., approved or pending)
            // You can adjust this logic: e.g., only approved terms cause committee conflicts
            bool areTermsRelevantForCommitteeCheck =
                (nowyTermin.Status == "Zatwierdzony" || nowyTermin.Status == "OczekujeNaZatwierdzenie") &&
                (istniejącyTermin.Status == "Zatwierdzony" || istniejącyTermin.Status == "OczekujeNaZatwierdzenie");

            if (areTermsRelevantForCommitteeCheck)
            {
                return komisjaNowa.Any(osoba => komisjaIstniejaca.Contains(osoba));
            }
            return false; // No conflict if statuses don't require checking
        }

        public void EdytujTermin(Termin termin, DateOnly data, TimeOnly godzina, string status, Egzamin egzamin)
        {
            var nowyTermin = new Termin(data, godzina, termin.CzasTrwania, status, egzamin);

            foreach (var istniejącyTermin in terminy)
            {
                if (istniejącyTermin == termin) continue; // Don't check against itself

                if (CzyTerminKoliduje(nowyTermin, istniejącyTermin))
                {
                    Debug.WriteLine("Termin koliduje podczas edycji..");
                    if (nowyTermin.Egzamin != null && istniejącyTermin.Egzamin != null && CzyKomisjaSięPowtarza(nowyTermin, istniejącyTermin))
                    {
                        Debug.WriteLine("Nie można edytować terminu: Członkowie komisji się powtarzają.");
                        return;
                    }
                }
            }

            // If no conflicts, update the term's properties
            termin.Data = data;
            termin.Godzina = godzina;
            termin.Status = status;
            termin.Egzamin = egzamin;

            Console.WriteLine("Termin edytowany pomyślnie.");
        }

        /// <summary>
        /// Updates only the status of an existing term in the list.
        /// </summary>
        /// <param name="terminToUpdate">The term object with the updated status.</param>
        public void ZaktualizujTerminStatus(Termin terminToUpdate)
        {
            // Find the term in your list based on its unique identifiers
            // You might need a more robust way to identify the term if you have unique IDs.
            var existingTermin = terminy.FirstOrDefault(t =>
                t.Data == terminToUpdate.Data &&
                t.Godzina == terminToUpdate.Godzina &&
                t.Egzamin == terminToUpdate.Egzamin); // Assuming Egzamin helps uniquely identify, or use a unique ID

            if (existingTermin != null)
            {
                existingTermin.Status = terminToUpdate.Status;
                Debug.WriteLine($"Status terminu na {existingTermin.Data.ToShortDateString()} {existingTermin.Godzina.ToString("HH:mm")} zmieniony na: {existingTermin.Status}");
            }
        }

        public void UsunTermin(Termin termin)
        {
            terminy.Remove(termin);
        }

        public void WypiszTerminy()
        {
            foreach (var termin in terminy)
            {
                termin.WyswietlSzczegoly();
            }
        }
        public List<Termin> getTerminy()
        {
            return this.terminy;
        }
    }


}