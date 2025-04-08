
namespace egzamin_dyplomowy;
public class Egzamin
{
    public string Nazwa { get; set; }
    public int Punkty { get; set; }
}

public class Termin
{
    public DateTime Data { get; set; } 
    public TimeSpan Godzina { get; set; } 
    public string Status { get; set; } 
    public Egzamin egzamin { get; set; }

    public Termin() {
        DateTime data;
        TimeSpan godzina;
        String status;
        Egzamin egzamin;
    }

    public Termin(DateTime data, TimeSpan godzina, string status, Egzamin egzamin)
    {
        this.Data = data;
        this.Godzina = godzina;
        this.Status = status;
        this.egzamin = egzamin; //czekamy na krzyœka :*
    }
    public void WyswietlSzczegoly()
    {
        Console.WriteLine($"Data: {Data.ToShortDateString()}, Godzina: {Godzina}, Status: {Status}, Egzamin: {egzamin.Nazwa}, Punkty: {egzamin.Punkty}");
    }
}
