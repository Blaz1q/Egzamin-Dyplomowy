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
        private OperacjeNaTerminach _operacje = new OperacjeNaTerminach();
        DateOnly _selectedDate;
        public KalendarzControl()
        {
            InitializeComponent();
            kalendarz2.Dock = DockStyle.Fill;
            kalendarz2.OnDateClicked += setWeek;
            panel1.Controls.Add(kalendarz2);
            //Kalendarz kalendarz = new Kalendarz();
            terminarz.Dock = DockStyle.Fill;
            panel3.Controls.Add(terminarz);
            Debug.WriteLine("POZIOM DOSTEPU:" + Dane.User.getPoziom_dostepu());
          }
        public void setPermisions() {
            roundedButton1.Visible = (Dane.User.getPoziom_dostepu() > 4-1);
            roundedButton2.Visible = (Dane.User.getPoziom_dostepu() > 2);
            roundedButton3.Visible = (Dane.User.getPoziom_dostepu() > 4-1);
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
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            // Jeśli kalendarz nigdy nie wywołał setWeek, użyj dzisiejszej daty
            if (_selectedDate == default)
                _selectedDate = DateOnly.FromDateTime(DateTime.Today);

            using var dlg = new DodajTermin(_selectedDate, _operacje, terminarz);
            if (dlg.ShowDialog(this) == DialogResult.OK)
                terminarz.setWeek(_selectedDate);
        }


        private void roundedButton2_Click_1(object sender, EventArgs e)
        {

            // Button for "Zaklep Termin" (Student/User facing)
            if (_selectedDate == default)
                _selectedDate = DateOnly.FromDateTime(DateTime.Today);

            using var dlg = new ZaklepTermin(_selectedDate, _operacje, terminarz);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                terminarz.setWeek(_selectedDate); // Refresh the calendar for the selected week
            }
        }

        public void RefreshTerminarzDisplay()
        {
            // Ensure _selectedDate is set before using it to refresh
            if (_selectedDate == default)
                _selectedDate = DateOnly.FromDateTime(DateTime.Today);

            terminarz.setWeek(_selectedDate);
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            // Button for "Zatwierdź Terminy" (Prodziekan/Admin facing)
            // This button should likely only be visible to users with appropriate access level (e.g., Prodziekan)
            //if (Dane.User.getPoziom_dostepu() <= 1) // Example: assuming 1 is dean access level
            // {
            using (var zatwierdzForm = new ZatwierdzTermin(terminarz))
            {
                zatwierdzForm.ShowDialog(this);
                // No need to setWeek here unless you want to jump to a specific date after approval
                // The ZatwierdzTermin form itself refreshes the TerminarzControl
            }
            //}
            //else
            // {
            //  MessageBox.Show("Nie masz uprawnień do zatwierdzania terminów.", "Brak dostępu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
