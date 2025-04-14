using System;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class Walidacja
{
    public bool Haslo(string haslo)
    {
        return Regex.IsMatch(haslo, "^(?=.*[A-Z])(?=.*\\d).{8,}$");
    }

    public bool Email(string email)
    {
        return Regex.IsMatch(email, "^(?!.*\\.\\.)[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,}$");

    }
    public bool imie(string imie)
    {
        return Regex.IsMatch(imie, "^[A-ZŁŚĆŻŹĄĘÓŃ][a-ząćęłńóśźż]+(-[A-ZŁŚĆŻŹĄĘÓŃ][a-ząćęłńóśźż]+)?( [A-ZŁŚĆŻŹĄĘÓŃ][a-ząćęłńóśźż]+(-[A-ZŁŚĆŻŹĄĘÓŃ][a-ząćęłńóśźż]+)?)?$");
    }
    public bool nazwisko(string nazwisko)
    {
        return Regex.IsMatch(nazwisko, "^[A-ZŁŚĆŻŹĄĘÓŃ][a-ząćęłńóśźż]+(-[A-ZŁŚĆŻŹĄĘÓŃ][a-ząćęłńóśźż]+)?$");
    }
    public string WalidujHaslo(string haslo)
    {
        List<string> bledy = new List<string>();

        if (haslo.Length < 8)
            bledy.Add("Hasło musi mieć co najmniej 8 znaków.");
        if (!Regex.IsMatch(haslo, "[A-Z]"))
            bledy.Add("Hasło musi zawierać co najmniej jedną wielką literę.");
        if (!Regex.IsMatch(haslo, "\\d"))
            bledy.Add("Hasło musi zawierać co najmniej jedną cyfrę.");

        return string.Join("\n", bledy); 
    }

}

