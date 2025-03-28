
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

    public Termin() { }

    public Termin(DateTime data, TimeSpan godzina, string status, Egzamin egzamin)
    {
        Data = data;
        Godzina = godzina;
        Status = status;
        Egzamin = egzamin;
    }
    public void WyswietlSzczegoly()
    {
        Console.WriteLine($"Data: {Data.ToShortDateString()}, Godzina: {Godzina}, Status: {Status}, Egzamin: {Egzamin.Nazwa}, Punkty: {Egzamin.Punkty}");
    }
}
