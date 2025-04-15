
namespace egzamin_dyplomowy;

public class Pytanie
{
    private string tresc;
    public int Id { get; set; }
    public string Kierunek { get; set; }
<<<<<<< Updated upstream
    public string Wykladowca { get; set; }

    public Pytanie(int id, string tresc, string kierunek, string wykladowca)
=======
    public List<Wykladowca> Wykladowcy { get; set; }
    public string Kategoria { get; set; }
    public string Poziom { get; set; } // Inżynierskie lub Magisterskie

    public Pytanie(int id, string tresc, string kierunek, List<Wykladowca> wykladowcy, string kategoria, string poziom)
>>>>>>> Stashed changes
    {
        this.Id = id;
        this.tresc = tresc;
        this.Kierunek = kierunek;
<<<<<<< Updated upstream
        this.Wykladowca = wykladowca;
=======
        this.Wykladowcy = wykladowcy;
        this.Kategoria = kategoria;
        this.Poziom = poziom;
>>>>>>> Stashed changes
    }

    public string GetTresc()
    {
        return tresc;
    }

    public void SetTresc(string nowaTresc)
    {
        tresc = nowaTresc;
    }
<<<<<<< Updated upstream

    public String Wypisz()
    {
        return $"ID: {Id}, Treść: {tresc}, Kierunek: {Kierunek}, Wykładowca: {Wykladowca}";
=======
    public void DodajWykladowce(Wykladowca wykladowca) { 
        if(!this.Wykladowcy.Contains(wykladowca))
            this.Wykladowcy.Add(wykladowca);
    }
    public void UsunWykladowce(int index) { 
        if(index<this.Wykladowcy.Count&&index>=0)
            this.Wykladowcy.RemoveAt(index);
    }   
    public void UsunWykladowce(Wykladowca wykladowca) {
        if (this.Wykladowcy.Contains(wykladowca))
            this.Wykladowcy.Remove(wykladowca);
    }
    public void WypiszPytanie()
    {
        Console.WriteLine($"ID: {Id}, Treść: {tresc}, Kierunek: {Kierunek}, Liczba Wykladowców: {Wykladowcy.Count}, Kategoria: {Kategoria}, Poziom: {Poziom}");
>>>>>>> Stashed changes
    }
}
