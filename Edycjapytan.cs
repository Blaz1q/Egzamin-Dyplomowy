public class ZarzadzaniePytaniami
{
    private static List<Pytanie> pytania = new List<Pytanie>();
    private static int nextId = 1;

    public static void DodajPytanie(string tresc, string kierunek, string wykladowca)
    {
        pytania.Add(new Pytanie(nextId, tresc, kierunek, wykladowca));
        nextId++;
    }

    public static void UsunPytanie(int id)
    {
        var pytanie = pytania.FirstOrDefault(p => p.Id == id);
        if (pytanie != null)
        {
            pytania.Remove(pytanie);
            Console.WriteLine($"Pytanie {id}  usunięte.");
        }
        else
        {
            Console.WriteLine("Nie znaleziono pytania o podanym ID.");
        }
    }

    public static void EdytujPytanie(int id, string nowaTresc, string nowyKierunek, string nowyWykladowca)
    {
        var pytanie = pytania.FirstOrDefault(p => p.Id == id);
        if (pytanie != null)
        {
            pytanie.SetTresc(nowaTresc);
            pytanie.Kierunek = nowyKierunek;
            pytanie.Wykladowca = nowyWykladowca;
            Console.WriteLine("Pytanie z zaktualizowane.");
        }
        else
        {
            Console.WriteLine("Nie takiego ma pytania.");
        }
    }
}
