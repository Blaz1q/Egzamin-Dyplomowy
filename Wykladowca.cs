using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace egzamin_dyplomowy
{
    public class Wykladowca : Osoba
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public Wykladowca(int id, string imie, string nazwisko, string status) : base(imie,nazwisko)
        {
            Id = id;
            Status = status;
        }
        public string ImieNazwisko => $"{Imie} {Nazwisko}";

        //wypisz jednego wykładowce

        public void Wypisz()
        {
            Console.WriteLine($"ID: {Id}, Imię: {Imie}, Nazwisko: {Nazwisko}, Status: {Status}");
        }
        public override string ToString()
        {
            return $"ID: {Id}, Imię: {Imie}, Nazwisko: {Nazwisko}, Status: {Status}";
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
         // NOWA METODA!!!!!!! (freaky)
        public void DodajWykladowce(Wykladowca wykladowca)
         {
             wykladowcy.Add(wykladowca);
         }
        public Wykladowca? GetWykladowca(int id)
        {
            foreach (var wykladowca in wykladowcy)
                if (wykladowca.Id == id) {
                    return wykladowca;
                }
            return null;
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
                wykladowcy[index].SetImie(noweImie);
                wykladowcy[index].SetNazwisko(noweNazwisko);
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
                //Debug.WriteLine(wykladowca.GetType());
            }
        }
        public List<Wykladowca> getLista() {
            return wykladowcy;
        }
        public static void Testing() //testowanie
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
                Console.WriteLine(zarzadzanie.GetWykladowca(2));
                
            
        }
    } 
}
