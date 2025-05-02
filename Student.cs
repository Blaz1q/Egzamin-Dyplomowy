namespace egzamin_dyplomowy
{
    public class Student : Osoba
    {
        private int srednia { get; set; }
        public string kierunek { get; set; }
        public string kola_naukowe { get; set; }

        public Student(string imieNazwisko, int srednia, bool kola_naukowe, int kierunek) : base(imieNazwisko)
        {
            this.imie_nazwisko = imieNazwisko;
            this.srednia = srednia;
            this.kola_naukowe = kola_naukowe;
            this.kierunek = kierunek;
        }

        public string getImieNazwisko() { return this.imie_nazwisko; }
        public int getSrednia() { return this.srednia; }
        public void Wypisz()
        {
            Console.WriteLine($"Imie i Nazwisko: {this.imie_nazwisko}, Średnia: {this.srednia}, Czy uczęszczał na koła naukowe?: {this.kola_naukowe}, Kierunek: {this.kierunek}");
        }
    }


    public class ZarzadzanieStudent
    {
        private List<Student> studenci = new List<Student>();

        //dodaj
        public void DodajStudent(string imieNazwisko, int srednia, bool kola_naukowe, int kierunek)
        {
            studenci.Add(new Student(imieNazwisko, srednia, kola_naukowe, kierunek));
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
        public void EdytujStudent(int index, string noweImieNazwisko)
        {
            if (index >= 0 && index < studenci.Count)
            {
                studenci[index].imie_nazwisko = noweImieNazwisko;
            }
            else { Console.WriteLine("Niepoprawny index!"); }
        }

        public void WypiszAll()
        { 
            foreach(var student in studenci) { Console.WriteLine(student.Wypisz()); } 
        }
            


    public static void Testowe()
        {
            ZarzadzanieStudent testZarz = new ZarzadzanieStudent();

            testZarz.DodajStudent("Glizzy Gobbler", 3.2, false, 2);
            testZarz.DodajStudent("Hawk Tuah", 5.0, true, 1);

            Console.WriteLine("lista po dodaniu:");
            testZarz.WypiszAll();

            testZarz.EdytujKolaNaukowe(0, true);
            testZarz.EdytujKierunek(1, 3);
            testZarz.EdytujStudent(0, "Waltuh White");

            Console.WriteLine("Lista po edycji:");
            testZarz.WypiszAll();

            testZarz.UsunStudent(0);

            Console.WriteLine("Lista po usunięciu:");
            testZarz.WypiszWszystkich();
        }
    }
}
