using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class KalendarzControl : UserControl
    {
        public Kalendarz2 kalendarz2 = new Kalendarz2();
        public TerminarzControl terminarz = new TerminarzControl();
        public KalendarzControl()
        {
            InitializeComponent();
            kalendarz2.Dock = DockStyle.Fill;
            kalendarz2.OnDateClicked += setWeek;
            panel1.Controls.Add(kalendarz2);
            //Kalendarz kalendarz = new Kalendarz();
            terminarz.Dock = DockStyle.Fill;
            panel3.Controls.Add(terminarz);
            List<Pytanie> listaPytan = new List<Pytanie>();
            Promotor prom = new Promotor(1, "Mateusz", "Kardio", "C22");
            Wykladowca rec = new Wykladowca(2, "Krzysztof", "Pawlak", "Recenzent");
            Wykladowca prod = new Wykladowca(3, "Magdalena", "Gyattt", "Prodziekan");
            List<Wykladowca> listaWykladowcow = new List<Wykladowca>();
            listaWykladowcow.Add(rec);
            listaWykladowcow.Add(prom);
            listaWykladowcow.Add(prod);
            listaPytan.Add(new Pytanie(0,"Czy krzesło ma 4 nogi","informatykla",listaWykladowcow,"co to kategoria","INŻYNIER"));
            listaPytan.Add(new Pytanie(1,"Jak nazywa się mój pies","informatykla",listaWykladowcow,"co to kategoria","INŻYNIER"));
            listaPytan.Add(new Pytanie(2,"Wyjaśnij pojęcie WTF (World Touch Fortnite)","informatykla",listaWykladowcow,"co to kategoria","INŻYNIER"));
            
            terminarz.addEvent(new Termin(new DateOnly(2025, 5, 29), new TimeOnly(9, 45), new TimeSpan(1, 0, 0), "nie wiem co to status", new Egzamin(new Student(0, "Belze", "Bebe", 4.2, true, 1), prom, rec,prod,listaPytan)));
            terminarz.addEvent(new Termin(new DateOnly(2025, 5, 29), new TimeOnly(9, 50), new TimeSpan(1, 0, 0), "nie wiem co to status", new Egzamin(new Student(0, "Belze", "Bebe", 4.2, true, 1), prom, rec,prod,listaPytan)));
            terminarz.addEvent(new Termin(new DateOnly(2025, 5, 23), new TimeOnly(9, 23), new TimeSpan(1, 0, 0), "nie wiem co to status", new Egzamin(new Student(0, "Belze", "Bebe", 4.2, true, 1), prom, rec,prod,listaPytan)));
            //kalendarz.AddEvent(1, new TimeSpan(9, 30, 0), "BankAtlan Center", Color.RoyalBlue);
            //kalendarz.AddEvent(1, new TimeSpan(10, 30, 0), "Cynthia Woods\nMitchell Pavilion", Color.MediumSeaGreen);
            //kalendarz.AddEvent(1, new TimeSpan(10, 0, 0), "Skibidi toilet\nGoni mnie", Color.MediumSeaGreen);
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
