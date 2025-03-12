namespace egzamin_dyplomowy
{
    public class Student : Osoba
    {
        private int srednia;
        public Student(string imie_nazwisko, int srednia)
        {
            this.imie_nazwisko = imie_nazwisko;
            this.srednia = srednia;
        }

        public void getImieNazwisko(){return this.imie_nazwisko;}

        public void getSrednia() {return this.srednia;}
    }
}