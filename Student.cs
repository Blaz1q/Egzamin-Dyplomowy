namespace egzamin_dyplomowy
{
    public class Student : Osoba
    {
        private int srednia;
        public Student(string imieNazwisko, int srednia) : base(imieNazwisko)
        { 
            this.srednia = srednia;
        }

        public string getImieNazwisko(){return this.imie_nazwisko;}

        public int getSrednia() {return this.srednia;}
    }
}