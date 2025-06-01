
namespace egzamin_dyplomowy
{
    public class Osoba
    {
        protected string Imie { get; set; }
        protected string Nazwisko { get; set; }

        public Osoba(string imie,string nazwisko)
        {
            this.Imie = imie;
            this.Nazwisko = nazwisko;
        }

        public string GetImie() { 
            return this.Imie; 
        }
        public string GetNazwisko()
        {
            return this.Nazwisko;
        }
        public void SetImie(string value) { 
            this.Imie = value;
        }
        public void SetNazwisko (string value){ 
            this.Nazwisko = value;
        }
    }
}
