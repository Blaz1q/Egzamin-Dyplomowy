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
    public partial class ZaklepTermin : Form
    {
        private readonly bool _hasExistingExam;
        private readonly OperacjeNaTerminach _operacje;
        private readonly TerminarzControl _terminarz;

        public ZaklepTermin(DateOnly selectedDate,
                            OperacjeNaTerminach operacje,
                            TerminarzControl terminarz)
        {
            InitializeComponent();

            _operacje = operacje;
            _terminarz = terminarz;

            // Obliczamy, czy już istnieje termin danego dnia
            _hasExistingExam = _operacje
                .getTerminy()
                .Any(t => t.Data == selectedDate);

            // Inicjalizacja kontrolek
            datePicker.Value = selectedDate.ToDateTime(TimeOnly.MinValue);
            datePicker.Enabled = false;
            timePicker.Value = DateTime.Today.AddHours(8);

            LoadOccupiedHours(selectedDate);
            btnSubmit.Click += BtnSubmit_Click; // Ensure event handler is hooked up
        }

        private void LoadOccupiedHours(DateOnly date)
        {
            flpOccupied.Controls.Clear();
            foreach (var t in _operacje.getTerminy().Where(x => x.Data == date))
            {
                var lbl = new Label
                {
                    // Display current time and indicate if it's pending approval
                    Text = t.Godzina.ToString("HH:mm") + (t.Status == "OczekujeNaZatwierdzenie" ? " (Oczekuje)" : ""),
                    AutoSize = true,
                    Margin = new Padding(5)
                };
                flpOccupied.Controls.Add(lbl);
            }
        }


        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Zbieramy dane
            var date = DateOnly.FromDateTime(datePicker.Value);
            var time = TimeOnly.FromDateTime(timePicker.Value);

            // Check for conflicts, ignoring rejected terms for new bookings
            bool conflict = _operacje.getTerminy()
                .Any(t =>
                    t.Data == date &&
                    // Check for time overlap
                    time < t.Godzina.Add(t.CzasTrwania) &&
                    t.Godzina < time.Add(TimeSpan.FromHours(1)) &&
                    // Do not conflict with terms that have been rejected
                    t.Status != "Odrzucony"
                );

            if (conflict)
            {
                MessageBox.Show("Wybrany termin jest już zajęty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Stop if there's a conflict
            }

            // TODO: Pobierz konkretny obiekt Egzamin według wybranej opcji
            // For now, Egzamin is null as in your original code. You'd integrate exam selection here.
            Egzamin egz = new Egzamin();

            // Create and add the new term with "OczekujeNaZatwierdzenie" status
            var nowyTermin = new Termin(date, time, TimeSpan.FromHours(1), "OczekujeNaZatwierdzenie", egz);
            Dane.Terminy.DodajTermin(nowyTermin);
            //_terminarz.addEvent(nowyTermin); // Add the new event to your calendar display

            MessageBox.Show("Termin został zaklepany i oczekuje na zatwierdzenie przez Prodziekana.⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣭⣉⣉⠉⠉⠉⢹⡏⢹⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣾⣇⢸⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠰⠶⣤⣤⣴⣶⣾⣿⣿⣿⣿⣽⣻⣿⣿⣿⣿⣿⣒⣾⡿⠟⠿⢿⣿⣿⣿⣿⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠙⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⣤⣄⣈⡙⣉⡛⠩⡗⢲⠢⡤⢤⣄⣠⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢈⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠟⠋⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠸⣿⡇⡟⢿⣿⣿⣿⣿⣿⣿⠀⠁⣿⣿⣿⣿⡿⠊⢹⣻⡿⠛⠋⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢐⣿⣷⣷⡐⠉⡑⡀⣿⣿⡇⠀⠀⡈⠻⡉⠁⡠⠄⢸⣥⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢻⣿⣿⣿⡌⠀⢧⣿⣿⡀⠀⠠⢠⡀⠀⠀⠀⢀⡿⢣⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣽⣿⣿⣠⢚⡟⣿⠷⠔⠒⠀⠻⡆⠀⠀⢸⣴⡿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⣿⣿⣿⣷⣺⣿⣥⣀⣡⡀⠀⠀⠑⠀⠀⢸⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⣿⣯⣡⣿⣿⣻⡿⠷⠿⡿⠓⠀⠀⢀⡎⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣰⣿⣿⣿⣿⣽⣿⢹⠛⡋⠖⠀⠀⠀⢠⣎⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣴⣾⣿⣿⣿⢻⣿⣿⣿⣘⠆⡚⠀⢀⠤⠊⡽⣿⣷⣄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⠀⠀⠀⠀⢀⣀⣤⣤⣤⣤⣤⣤⣶⣾⣿⣿⣿⣿⣿⡏⢿⣆⢻⡏⢻⠋⠉⠉⠉⠁⢀⡜⠀⣿⣿⣿⣿⣷⣤⣀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⢀⣴⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⢠⡙⠙⢿⡈⡇⠀⠀⢀⡴⠋⠀⠀⣿⣿⣽⣿⣿⣿⣿⣿⣷⣶⣶⣦⣤⣄⣀⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡄⠱⡀⠀⠉⢳⣤⡖⠉⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⠀⠀⠀⠀⠀⠀⠀⠀⠀\r\n⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⣿⡘⣄⠑⠀⣤⣿⡇⢙⣄⠀⠀⠀⠀⢸⣿⣿⣿⡽⣿⣿⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣇⠀⠀⠀⠀⠀⠀⠀⠀\r\n⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢿⣧⠘⡇⠘⢾⣾⣿⣿⡗⡞⢻⣆⡀⠀⠀⠘⣿⣿⢻⣿⣿⣿⣿⣍⢿⣯⠛⣿⡙⣿⠿⢿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void lblSelectedDate_Click(object sender, EventArgs e) { }
        private void panelTime_Click(object sender, EventArgs e) { }
    }
}