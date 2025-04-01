using System;
using System.Collections.Generic;
using System.Linq;

namespace PytaniaBiblioteka;

public class Pytanie
{
    private string tresc;
    public int Id { get; set; }
    public string Kierunek { get; set; }
    public string Wykladowca { get; set; }
    public string Kategoria { get; set; }
    public string Poziom { get; set; } // Inżynierskie lub Magisterskie

    public Pytanie(int id, string tresc, string kierunek, string wykladowca, string kategoria, string poziom)
    {
        this.Id = id;
        this.tresc = tresc;
        this.Kierunek = kierunek;
        this.Wykladowca = wykladowca;
        this.Kategoria = kategoria;
        this.Poziom = poziom;
    }

    public string GetTresc()
    {
        return tresc;
    }

    public void SetTresc(string nowaTresc)
    {
        tresc = nowaTresc;
    }

    public void WypiszPytanie()
    {
        Console.WriteLine($"ID: {Id}, Treść: {tresc}, Kierunek: {Kierunek}, Wykładowca: {Wykladowca}, Kategoria: {Kategoria}, Poziom: {Poziom}");
    }
}