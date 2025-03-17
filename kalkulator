using System;
namespace egzamin_dyplomowy
{
class Kalkulator
{
    private static void Main()
    {
        double ocenaStudia, ocenaPracaPromotora, ocenaPracaDyplomowa, ocenaZaPrezentacje, ocena1, ocena2, ocena3;

        Console.WriteLine("Studia");
        Console.Write("Średnia ze studiów: ");
        ocenaStudia = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Praca dyplomowa");
        Console.Write("Ocena promotora: ");
        ocenaPracaPromotora = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ocena recenzenta: ");
        ocenaPracaDyplomowa = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Egzamin");
        Console.Write("Ocena za prezentację: ");
        ocenaZaPrezentacje = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ocena za pytanie nr 1: ");
        ocena1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ocena za pytanie nr 2: ");
        ocena2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ocena za pytanie nr 3: ");
        ocena3 = Convert.ToDouble(Console.ReadLine());
        double sredniaPracaDyplomowa = obliczSredniaPracyDyplomowej(ocenaPracaPromotora, ocenaPracaDyplomowa);
        double sredniaEgzamin = obliczSredniaEgzaminu(ocenaZaPrezentacje, ocena1, ocena2, ocena3);

        double sredniaWazona = ObliczSredniaWazona(ocenaStudia, sredniaPracaDyplomowa, sredniaEgzamin);
        string ocena = PrzypiszOcene(sredniaWazona);

        Console.WriteLine($"Wynik studiów: {sredniaWazona:F2}");
        Console.WriteLine($"Przypisana ocena: {ocena}");

        Console.WriteLine("Uwagi");
        Console.WriteLine("Wynik studiów wynika ze średniej ważonej obliczonej na podstawie trzech ocen i przypisanych im wag:");
        Console.WriteLine("Średnia ważona = 0,5 * (średnia ze studiów) + 0,25 * (średnia za pracę dyplomową) + 0,25 * (średnia z egzaminu)");

        Console.WriteLine("Skala ocen:");
        Console.WriteLine("4,70 i więcej: celująca (5,5);");
        Console.WriteLine("4,50 - 4,69: bardzo dobra (5,0);");
        Console.WriteLine("4,20 - 4,49: dobra plus (4,5);");
        Console.WriteLine("3,80 - 4,19: dobra (4,0);");
        Console.WriteLine("3,40 - 3,79: dostateczna plus (3,5);");
        Console.WriteLine("do 3,39: dostateczna (3,0)");

        Console.WriteLine("Naciśnij dowolny klawisz, aby zakończyć.");
        Console.ReadKey();
    }

    public static double ObliczSredniaWazona(double ocenaStudia, double sredniaPracaDyplomowa, double sredniaEgzamin)
    {
        return 0.5 * ocenaStudia + 0.25 * sredniaPracaDyplomowa + 0.25 * sredniaEgzamin;
    }

    public static string PrzypiszOcene(double sredniaWazona)
    {
        if (sredniaWazona >= 4.70)
            return "celująca (5,5)";
        else if (sredniaWazona >= 4.50)
            return "bardzo dobra (5,0)";
        else if (sredniaWazona >= 4.20)
            return "dobra plus (4,5)";
        else if (sredniaWazona >= 3.80)
            return "dobra (4,0)";
        else if (sredniaWazona >= 3.40)
            return "dostateczna plus (3,5)";
        else if (sredniaWazona >= 3.0)
            return "dostateczna (3,0)";
        else
            return "niezaliczone (2,0)";
    }
    public static double obliczSredniaPracyDyplomowej(double ocenaPracaPromotora, double ocenaPracaDyplomowa)
    {
        return (ocenaPracaPromotora + ocenaPracaDyplomowa) / 2;
    }
    public static double obliczSredniaEgzaminu(double ocenaZaPrezentacje, double ocena1, double ocena2, double ocena3)
    {
        return (ocenaZaPrezentacje + ocena1 + ocena2 + ocena3) / 4;
    }
}
}
