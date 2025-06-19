using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace egzamin_dyplomowy
{
    internal class Dane
    {
        public static OperacjeNaTerminach Terminy = new OperacjeNaTerminach();
        public static ZarzadzaniePytaniami Pytania = new ZarzadzaniePytaniami();
        public static ZarzadzanieWykladowcami Wykladowcy = new ZarzadzanieWykladowcami();
        public static ZarzadzanieStudent Studenci = new ZarzadzanieStudent();
        public static Uzytkownik User = new Uzytkownik();
        
        public static void ResetData() { 
            Terminy = new OperacjeNaTerminach();
            Pytania = new ZarzadzaniePytaniami();
            Wykladowcy = new ZarzadzanieWykladowcami();
            Studenci = new ZarzadzanieStudent();
            User = new Uzytkownik();
        }
    }
    public class Uzytkownik
    {
        private int id;
        private string imie;
        private string nazwisko;
        private string typ_konta;
        private int poziom_dostepu;
        public int getPoziom_dostepu()
        {
            return poziom_dostepu;
        }
        public Uzytkownik()
        {

        }
        public Uzytkownik(int id,string imie, string nazwisko, string typ_konta, int poziom_dostepu)
        {
            this.id = id;
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.typ_konta = typ_konta;
            this.poziom_dostepu = poziom_dostepu;
        }
        public Wykladowca getUserAsWykladowca() {
            switch (this.poziom_dostepu) {
                case 2: return new Wykladowca(this.id,this.imie,this.nazwisko,"Recenzent"); break;
                case 3: return new Wykladowca(this.id,this.imie,this.nazwisko,"Promotor"); break;
                case 4: return new Wykladowca(this.id,this.imie,this.nazwisko,"Prodziekan"); break;
                case 5: return new Wykladowca(this.id,this.imie,this.nazwisko,"Admin"); break;
            }
            return new Wykladowca(-1, "Er", "rorr", "Recenzent");
        }
    }
}
