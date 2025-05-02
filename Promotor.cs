namespace egzamin_dyplomowy
{
    public class Promotor : Wykladowca
    {
        private string sala;

        public Promotor(int id, string imie, string nazwisko, string sala) 
            : base(id, imie, nazwisko, "Promotor")
        {
            this.sala = sala;
        }
        public string GetSala()
        {
            return sala;
        }
    }
}