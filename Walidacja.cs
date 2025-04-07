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
}
