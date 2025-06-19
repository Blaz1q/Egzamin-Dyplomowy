using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class KalendarzControl : UserControl
    {
        public Kalendarz kalendarz2 = new Kalendarz();
        public TerminarzControl terminarz = new TerminarzControl();
<<<<<<< Updated upstream
=======
        private OperacjeNaTerminach _operacje = new OperacjeNaTerminach();
        DateOnly _selectedDate;
>>>>>>> Stashed changes
        public KalendarzControl()
        {
            InitializeComponent();
            kalendarz2.Dock = DockStyle.Fill;
            kalendarz2.OnDateClicked += setWeek;
            panel1.Controls.Add(kalendarz2);
            //Kalendarz kalendarz = new Kalendarz();
            terminarz.Dock = DockStyle.Fill;
            panel3.Controls.Add(terminarz);
<<<<<<< Updated upstream
            List<Pytanie> listaPytan = new List<Pytanie>();
            Promotor prom = new Promotor(1, "Mateusz", "Kardio", "C22");
            Wykladowca rec = new Wykladowca(2, "Krzysztof", "Pawlak", "Recenzent");
            Wykladowca prod = new Wykladowca(3, "Magdalena", "Gyattt", "Prodziekan");
            List<Wykladowca> listaWykladowcow = new List<Wykladowca>();
            List<Wykladowca> listaWykladowcow2 = new List<Wykladowca>();
            listaWykladowcow.Add(rec);
            listaWykladowcow.Add(prom);
            listaWykladowcow.Add(prod);
            Promotor prom2 = new Promotor(4, "Mateusz", "Kardio", "C22");
            Wykladowca rec2 = new Wykladowca(5, "Krzysztof", "Pawlak", "Recenzent");
            Wykladowca prod2 = new Wykladowca(6, "Magdalena", "Gyattt", "Prodziekan");
            listaWykladowcow2.Add(rec2);
            listaWykladowcow2.Add(prom2);
            listaWykladowcow2.Add(prod2);
            listaPytan.Add(new Pytanie(0,"Czy krzesło ma 4 nogi","informatykla",listaWykladowcow,"co to kategoria","INŻYNIER"));
            listaPytan.Add(new Pytanie(1,"Jak nazywa się mój pies","informatykla",listaWykladowcow,"co to kategoria","INŻYNIER"));
            listaPytan.Add(new Pytanie(2,"Wyjaśnij pojęcie WTF (World Touch Fortnite)","informatykla",listaWykladowcow,"co to kategoria","INŻYNIER"));
            //listaPytan.Add(new Pytanie(2,"Wyjaśnij pojęcie WTF (World Touch Fortnite)","informatykla",listaWykladowcow2,"co to kategoria","INŻYNIER"));
            
           // terminarz.addEvent(new Termin(new DateOnly(2025, 6, 6), new TimeOnly(9, 45), new TimeSpan(1, 0, 0), "nie wiem co to status", new Egzamin(new Student(0, "Belze", "Bebe", 4.2, true, 1), prom, rec,prod,listaPytan)));
            //terminarz.addEvent(new Termin(new DateOnly(2025, 6, 6), new TimeOnly(9, 50), new TimeSpan(1, 0, 0), "nie wiem co to status", new Egzamin(new Student(0, "Belze", "Bebe", 4.2, true, 1), prom, rec,prod,listaPytan)));
            terminarz.addEvent(new Termin(new DateOnly(2025, 6, 6), new TimeOnly(9, 23), new TimeSpan(1, 0, 0), "nie wiem co to status", new Egzamin(new Student(0, "Belze", "Bebe", 4.2, true, 1), prom, rec,prod,listaPytan)));
            terminarz.addEvent(new Termin(new DateOnly(2025, 6, 6), new TimeOnly(9, 23), new TimeSpan(1, 0, 0), "nie wiem co to status", new Egzamin(new Student(0, "Belze", "Bebe", 4.2, true, 1), prom2, rec2,prod2,listaPytan)));
            terminarz.addEvent(new Termin(new DateOnly(2025, 6, 5), new TimeOnly(9, 23), new TimeSpan(1, 0, 0), "nie wiem co to status", new Egzamin(new Student(0, "Belze", "Bebe", 4.2, true, 1), prom2, rec2,prod2,listaPytan)));
            //kalendarz.AddEvent(1, new TimeSpan(9, 30, 0), "BankAtlan Center", Color.RoyalBlue);
            //kalendarz.AddEvent(1, new TimeSpan(10, 30, 0), "Cynthia Woods\nMitchell Pavilion", Color.MediumSeaGreen);
            //kalendarz.AddEvent(1, new TimeSpan(10, 0, 0), "Skibidi toilet\nGoni mnie", Color.MediumSeaGreen);
=======
            Debug.WriteLine("POZIOM DOSTEPU:" + Dane.User.getPoziom_dostepu());
          }
        public void setPermisions() {
            roundedButton1.Visible = (Dane.User.getPoziom_dostepu() > 4-1);
            roundedButton2.Visible = (Dane.User.getPoziom_dostepu() > 2);
            roundedButton3.Visible = (Dane.User.getPoziom_dostepu() > 4-1);
>>>>>>> Stashed changes
        }
        public void setWeek(DateOnly weekdate) {
            terminarz.setWeek(weekdate);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            kalendarz2.decrementMonth();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kalendarz2.incrementMonth();
        }
    }
}
