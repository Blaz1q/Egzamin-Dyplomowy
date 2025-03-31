
namespace egzamin_dyplomowy;

public class Pytanie
{
    private string tresc;
    public int Id { get; set; }
    public string Kierunek { get; set; }
    public string Wykladowca { get; set; }

    public Pytanie(int id, string tresc, string kierunek, string wykladowca)
    {
        this.Id = id;
        this.tresc = tresc;
        this.Kierunek = kierunek;
        this.Wykladowca = wykladowca;
    }

    public string GetTresc()
    {
        return tresc;
    }

    public void SetTresc(string nowaTresc)
    {
        tresc = nowaTresc;
    }

    public String Wypisz()
    {
        return $"ID: {Id}, Treść: {tresc}, Kierunek: {Kierunek}, Wykładowca: {Wykladowca}";
    }
}
