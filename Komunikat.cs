using System;
using System.Drawing;

namespace egzamin_dyplomowy;
public class Komunikat
{
    public enum MessageType
    {
        Error,
        Success,
        Warning
    }

    private string tekst;
    private MessageType stan;

    public Komunikat(string tekst, MessageType stan)
    {
        this.tekst = tekst;
        this.stan = stan;
    }

    public Color GetColor()
    {
        switch (stan)
        {
            case MessageType.Error:
                return Color.FromArgb(255,84,72); // kolor czerwony (z figmy RGB)
            case MessageType.Success:
                return Color.FromArgb(43,172,28);  // kolor zielony (z figmy RGB)
            case MessageType.Warning:
                return Color.FromArgb(255,211,0);  // kolor żółty (z figmy RGB)         
            default:
            throw new InvalidOperationException("Nieznany typ komunikatu.");  
        }
    }

    public string Tekst => tekst;
    public MessageType Stan => stan;
}
