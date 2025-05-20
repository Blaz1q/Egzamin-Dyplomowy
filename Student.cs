using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzamin_dyplomowy
{
    public class Student : Osoba
    {
        private int id { get; set; }
        public double srednia { get; set; }
        public bool kola_naukowe { get; set; }
        public int kierunek;
        public string nazwisko
        {
            get => Nazwisko;
            set => Nazwisko = value;
        }

        public string imie
        {
            get => Imie;
            set => Imie = value;
        }

        public Student(int id, string imie, string nazwisko, double srednia, bool kola_naukowe, int kierunek) : base(imie, nazwisko)
        {
            this.id = id;
            this.srednia = srednia;
            this.kola_naukowe = kola_naukowe;
            this.kierunek = kierunek;
            this.imie = imie;
            this.nazwisko = nazwisko;
        }
        public double getSrednia() { return this.srednia; }
        public void Wypisz()
        {
            Debug.WriteLine($"Imie i Nazwisko: {this.Imie}, {this.Nazwisko}, Średnia: {this.srednia}, Czy uczęszczał na koła naukowe?: {this.kola_naukowe}, KierunekID: {this.kierunek}");
        }
        public void setSrednia(double newSrednia)
        {
            this.srednia = newSrednia;
        }
    }


    public class ZarzadzanieStudent
    {
        private List<Student> studenci = new List<Student>();

        //dodaj
        public void DodajStudent(Student student)
        {
            studenci.Add(student);
        }
        public void DodajStudent(int id, string imie, string nazwisko, double srednia, bool kola_naukowe, int kierunek)
        {
            studenci.Add(new Student(id, imie, nazwisko, srednia, kola_naukowe, kierunek));
        }

        //usun
        public void UsunStudent(int index)
        {
            if (index >= 0 && index < studenci.Count) { studenci.RemoveAt(index); }
            else { Console.WriteLine("Niepoprawny index!"); }
        }

        //edycje
        public void EdytujKolaNaukowe(int index, bool kola_naukowe)
        {
            if (index >= 0 && index < studenci.Count) { studenci[index].kola_naukowe = kola_naukowe; }
            else { Console.WriteLine("Niepoprawny index!"); }
        }
        public void EdytujKierunek(int index, int nowyKierunek)
        {
            if (index >= 0 && index < studenci.Count) { studenci[index].kierunek = nowyKierunek; }
            else { Console.WriteLine("Niepoprawny index!"); }
        }
        public void EdytujStudent(int index, string noweimie, string nowenazwisko)
        {
            if (index >= 0 && index < studenci.Count)
            {
                studenci[index].SetImie(noweimie);
                studenci[index].SetNazwisko(nowenazwisko);
            }
            else { Console.WriteLine("Niepoprawny index!"); }
        }

        public List<Student> getLista()
        {
            return studenci;
        }


        public void WypiszAll()
        {
            foreach (var student in studenci) { student.Wypisz(); }
        }



        public static ZarzadzanieStudent Testowe()
        {
            ZarzadzanieStudent testZarz = new ZarzadzanieStudent();

            testZarz.DodajStudent(1, "Glizzy", "Gobbler", 3.2, false, 0);
            testZarz.DodajStudent(2, "Hawk", "Tuah", 5.0, true, 0);

            return testZarz;

        }
    }
}
