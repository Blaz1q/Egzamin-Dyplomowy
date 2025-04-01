using System;
using System.Collections.Generic;
using System.Linq;

namespace PytaniaBiblioteka;

public class LosowaniePytan
{
    private static List<Pytanie> pytania = new List<Pytanie>();

    public static void DodajPytanie(string tresc, string kierunek, string wykladowca)
    {
        int noweId = pytania.Count > 0 ? pytania.Max(p => p.Id) + 1 : 1;
        pytania.Add(new Pytanie(noweId, tresc, kierunek, wykladowca));
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
