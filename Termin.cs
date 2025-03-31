using System;
using System.Collections.Generic;

namespace egzamin_dyplomowy
{
    public class Egzamin
    {
        public string Nazwa { get; set; }
        public int Punkty { get; set; }
    }

    public class Termin
    {
        public DateTime Data { get; set; } 
        public TimeSpan Godzina { get; set; } 
        public string Status { get; set; } 
        public Egzamin egzamin { get; set; }

        public Termin() { }

        public Termin(DateTime data, TimeSpan godzina, string status, Egzamin egzamin)
        {
            this.Data = data;
            this.Godzina = godzina;
            this.Status = status;
            this.egzamin = egzamin;
        }

        public void WyswietlSzczegoly()
        {
            Console.WriteLine($"Data: {Data.ToShortDateString()}, Godzina: {Godzina}, Status: {Status}, Egzamin: {egzamin.Nazwa}, Punkty: {egzamin.Punkty}");
        }

        public void Edytuj(DateTime data, TimeSpan godzina, string status, Egzamin egzamin)
        {
            this.Data = data;
            this.Godzina = godzina;
            this.Status = status;
            this.egzamin = egzamin;
        }
    }

    public class OperacjeNaTerminach
    {
        private List<Termin> terminy = new List<Termin>();

        public void DodajTermin(Termin termin)
        {
            terminy.Add(termin);
        }

        public void EdytujTermin(Termin termin, DateTime data, TimeSpan godzina, string status, Egzamin egzamin)
        {
            termin.Edytuj(data, godzina, status, egzamin);
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
// jebac to
