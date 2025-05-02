using System;
using System.Collections.Generic;

namespace egzamin_dyplomowy
{
    public class Wykladowca : Osoba
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public Wykladowca(int id, string imie, string nazwisko, string status) : base(imie + " " + nazwisko)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Status = status;
        }

        //wypisz jednego wykładowce

        public void Wypisz()
        {
            Console.WriteLine($"ID: {Id}, Imię: {Imie}, Nazwisko: {Nazwisko}, Status: {Status}");
        }
    }

    //zarządzanie

    public class ZarzadzanieWykladowcami
    {
        private List<Wykladowca> wykladowcy = new List<Wykladowca>();
        //dodawanie
        public void DodajWykladowce(int id, string imie, string nazwisko, string status)
        {
            wykladowcy.Add(new Wykladowca(id, imie, nazwisko, status));
        }
        //usuwanie
        public void UsunWykladowce(int index)
        {
            if (index >= 0 && index < wykladowcy.Count)
                wykladowcy.RemoveAt(index);
            else
                Console.WriteLine("Błedny indeks");
        }
        //edytowanie
        public void EdytujStatus(int index, string nowyStatus)
        {
            if (index >= 0 && index < wykladowcy.Count)
                wykladowcy[index].Status = nowyStatus;
            else
                Console.WriteLine("Błedny indeks");
        }

        public void EdytujWykladowce(int index, string noweImie, string noweNazwisko)
        {
            if (index >= 0 && index < wykladowcy.Count)
            {
                wykladowcy[index].Imie = noweImie;
                wykladowcy[index].Nazwisko = noweNazwisko;
            }
            else
                Console.WriteLine("Błedny indeks");
        }
        //wypisywanie całej listy
        public void WypiszWszystkich()
        {
            foreach (var wykladowca in wykladowcy)
            {
                wykladowca.Wypisz();
            }
        }
        public List<Wykladowca> getLista() {
            return wykladowcy;
        }
        public static void Testing() //testowanie
        {
            //testowanie
            static void Testing()
            {
                ZarzadzanieWykladowcami zarzadzanie = new ZarzadzanieWykladowcami();

                zarzadzanie.DodajWykladowce(1, "Sam", "Sung", "Promotor");
                zarzadzanie.DodajWykladowce(2, "Steve", "Jobs", "Recenzent");

                Console.WriteLine("lista po dodaniu:");
                zarzadzanie.WypiszWszystkich();

                zarzadzanie.EdytujStatus(0, "Prodziekan");
                zarzadzanie.EdytujWykladowce(1, "Melon", "Muzg");

                Console.WriteLine("Lista po edycji:");
                zarzadzanie.WypiszWszystkich();

                zarzadzanie.UsunWykladowce(0);

                Console.WriteLine("Lista po usunięciu:");
                zarzadzanie.WypiszWszystkich();
            }
        }
    } 
}