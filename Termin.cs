using System;
using System.Collections.Generic;
using System.Diagnostics;
namespace egzamin_dyplomowy
{
    public class Termin
    {
        public DateOnly Data { get; set; }
        public TimeOnly Godzina { get; set; }
        public TimeSpan CzasTrwania { get; set; }
        public string Status { get; set; }
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
            foreach (var istniejącyTermin in terminy)
            {
                if (CzyTerminKoliduje(termin, istniejącyTermin))
                {
                    Debug.WriteLine("Termin koliduje..");
                    if (CzyKomisjaSięPowtarza(termin, istniejącyTermin))
                    {

                        Debug.WriteLine("Nie można dodać terminu: Członkowie komisji się powtarzają.");
                        return;
                    }
                }
            }
            terminy.Add(termin);
            Debug.WriteLine("Termin dodany pomyślnie.");
        }

        private bool CzyTerminKoliduje(Termin nowyTermin, Termin istniejącyTermin)
        {
            var nowyStart = nowyTermin.GetStartTime();
            var nowyEnd = nowyTermin.GetEndTime();

            if (nowyStart < istniejącyTermin.GetEndTime() && nowyEnd > istniejącyTermin.GetStartTime())
            {
                if (nowyStart < istniejącyTermin.GetStartTime().AddMinutes(15) || nowyEnd > istniejącyTermin.GetEndTime().AddMinutes(-15))
                {
                    return true;
                }
            }

            return false;
        }

        private bool CzyKomisjaSięPowtarza(Termin nowyTermin, Termin istniejącyTermin)
        {
            var komisjaNowa = new List<Wykladowca>
            {
                nowyTermin.Egzamin.getPromotor(),
                nowyTermin.Egzamin.getRecenzent(),
                nowyTermin.Egzamin.getProdziekan()
            };

            var komisjaIstniejaca = new List<Wykladowca>
            {
                istniejącyTermin.Egzamin.getPromotor(),
                istniejącyTermin.Egzamin.getRecenzent(),
                istniejącyTermin.Egzamin.getProdziekan()
            };

            return komisjaNowa.Any(osoba => komisjaIstniejaca.Contains(osoba));
        }

        public void EdytujTermin(Termin termin, DateOnly data, TimeOnly godzina, string status, Egzamin egzamin)
        {
            var nowyTermin = new Termin(data, godzina, termin.CzasTrwania, status, egzamin);

            foreach (var istniejącyTermin in terminy)
            {
                if (istniejącyTermin == termin) continue;

                if (CzyTerminKoliduje(nowyTermin, istniejącyTermin))
                {
                    Debug.WriteLine("Termin koliduje..");
                    if (CzyKomisjaSięPowtarza(nowyTermin, istniejącyTermin))
                    {
                        Debug.WriteLine("Nie można edytować terminu: Członkowie komisji się powtarzają.");
                        return;
                    }
                }


            }

            termin.Data = data;
            termin.Godzina = godzina;
            termin.Status = status;
            termin.Egzamin = egzamin;

            Console.WriteLine("Termin edytowany pomyślnie.");
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
    }
}
