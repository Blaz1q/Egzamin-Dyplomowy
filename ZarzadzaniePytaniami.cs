namespace egzamin_dyplomowy;

public class ZarzadzaniePytaniami
{
    private List<Pytanie> pytania = new List<Pytanie>();
    private int nextId = 1;

    public void DodajPytanie(string tresc, string kierunek, List<Wykladowca> wykladowcy, string kategoria, string poziom)
    {
        pytania.Add(new Pytanie(nextId++, tresc, kierunek, wykladowcy, kategoria, poziom));
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

    public void EdytujPytanie(int id, string nowaTresc, string nowyKierunek, List<Wykladowca> nowiWykladowcy, string nowaKategoria, string nowyPoziom)
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

    public void EdytujWykladowcow(int id, List<Wykladowca> lista)
    {
        var pytanie = pytania.FirstOrDefault(p => p.Id == id);
        if (pytanie != null)
            pytanie.Wykladowcy = lista;
    }

    public void DodajWykladowce(int id, Wykladowca wykladowca)
    {
        var pytanie = pytania.FirstOrDefault(p => p.Id == id);
        pytanie?.DodajWykladowce(wykladowca);
    }

    public void WypiszPytania()
    {
        foreach (var pytanie in pytania)
        {
            pytanie.WypiszPytanie();
        }
    }

    public List<int> LosujPytaniaDlaKierunku(string kierunek, int liczba = 3)
    {
        Random rand = new Random();
        return pytania.Where(p => p.Kierunek == kierunek)
                      .Select(p => p.Id)
                      .OrderBy(x => rand.Next())
                      .Take(liczba)
                      .ToList();
    }

    public List<int> LosujPytaniaDlaWykladowcy(Wykladowca wykladowca, int liczba = 3)
    {
        Random rand = new Random();
        return pytania.Where(p => p.Wykladowcy.Contains(wykladowca))
                      .Select(p => p.Id)
                      .OrderBy(x => rand.Next())
                      .Take(liczba)
                      .ToList();
    }
    public List<Pytanie> getPytania() {
        return this.pytania;
    }

}
