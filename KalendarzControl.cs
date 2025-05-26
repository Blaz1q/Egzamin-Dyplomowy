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
            terminarz.addEvent("skibid", 0, new TimeOnly(6, 30));
            terminarz.addEvent("toilet", 1, new TimeOnly(9, 34));
            terminarz.addEvent("goni", 2, new TimeOnly(7, 14));
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
