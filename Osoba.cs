
namespace egzamin_dyplomowy
{
    public class Osoba
    {
        protected string imie_nazwisko;

        public Osoba(string imieNazwisko)
        {
            imie_nazwisko = imieNazwisko;
        }

        public string GetImieNazwisko()
        {
            return imie_nazwisko;
        }
    }
}
