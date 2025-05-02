namespace egzamin_dyplomowy;

public class ZarzadzaniePytaniami
{
    private static List<Pytanie> pytania = new List<Pytanie>();
    private static int nextId = 1;

    public void DodajPytanie(string tresc, string kierunek, List<Wykladowca> wykladowcy, string kategoria, string poziom)
    {
        pytania.Add(new Pytanie(nextId, tresc, kierunek, wykladowcy, kategoria, poziom));
        nextId++;
    }

    public void UsunPytanie(int id)
    {
        var pytanie = pytania.FirstOrDefault(p => p.Id == id);
        if (pytanie != null)
        {
            pytania.Remove(pytanie);
            Console.WriteLine($"Pytanie {id} usunięte.");
        }
        else
        {
            Console.WriteLine("Nie znaleziono pytania o podanym ID.");
        }
    }

    public static void EdytujPytanie(int id, string nowaTresc, string nowyKierunek, List<Wykladowca> nowiWykladowcy, string nowaKategoria, string nowyPoziom)
    {
        var pytanie = pytania.FirstOrDefault(p => p.Id == id);
        if (pytanie != null)
        {
            pytanie.SetTresc(nowaTresc);
            pytanie.Kierunek = nowyKierunek;
            pytanie.Wykladowcy = nowiWykladowcy;
            pytanie.Kategoria = nowaKategoria;
            pytanie.Poziom = nowyPoziom;
            Console.WriteLine("Pytanie zaktualizowane.");
        }
        else
        {
            Console.WriteLine("Nie znaleziono takiego pytania.");
        }
    }

    public static List<int> LosujPytania(string kierunek)
    {
        Random rand = new Random();
        return pytania.Where(p => p.Kierunek == kierunek)
                      .Select(p => p.Id)
                      .OrderBy(x => rand.Next())
                      .Take(3)
                      .ToList();
    }

    public static int WymienPytanie(List<int> wylosowaneId, string kierunek, int idDoWymiany)
    {
        if (!wylosowaneId.Contains(idDoWymiany)) return -1;

        List<int> dostepneId = pytania.Where(p => p.Kierunek == kierunek && !wylosowaneId.Contains(p.Id))
                                      .Select(p => p.Id)
                                      .ToList();

        if (dostepneId.Count == 0) return -1;

        int noweId = dostepneId[new Random().Next(dostepneId.Count)];
        int index = wylosowaneId.IndexOf(idDoWymiany);
        wylosowaneId[index] = noweId;

        return noweId;
    }
}