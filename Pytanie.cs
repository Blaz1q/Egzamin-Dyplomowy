using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace egzamin_dyplomowy;

public class Pytanie
{
    private string tresc;
    public int Id { get; set; }
    public string Kierunek { get; set; }
    public List<Wykladowca> Wykladowcy { get; set; }
    public string Kategoria { get; set; }
    public string Poziom { get; set; } // Inżynierskie lub Magisterskie

    public Pytanie(int id, string tresc, string kierunek, List<Wykladowca> wykladowcy, string kategoria, string poziom)
    {
        this.Id = id;
        this.tresc = tresc;
        this.Kierunek = kierunek;
        this.Wykladowcy = wykladowcy;
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
        Debug.WriteLine($"ID: {Id}, Treść: {tresc}, Kierunek: {Kierunek}, Liczba Wykladowców: {Wykladowcy.Count}, Kategoria: {Kategoria}, Poziom: {Poziom}");
    }
}
