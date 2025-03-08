using System;
using System.Collections.Generic;

namespace KlasyWykl
{
    public class Wykladowca : Osoba
    {
        private string wydzial;
        private List<string> przedmioty;
        private string tytul;

        public Wykladowca(string imieNazwisko, string wydzial, List<string> przedmioty, string tytul) 
            : base(imieNazwisko)
        {
            this.wydzial = wydzial;
            this.przedmioty = przedmioty;
            this.tytul = tytul;
        }

        public string GetWydzial()
        {
            return wydzial;
        }

        public List<string> GetPrzedmioty()
        {
            return przedmioty;
        }

        public string GetTytul()
        {
            return tytul;
        }

        public void GetDaneWykl()
        {
            Console.WriteLine($"{tytul} {GetImieNazwisko()}");
            Console.WriteLine($"Wydział: {wydzial}");
            Console.WriteLine("Prowadzone przedmioty:");

            foreach (var przedmiot in przedmioty)
            {
                Console.WriteLine($"- {przedmiot}");
            }
        }
    }
}
