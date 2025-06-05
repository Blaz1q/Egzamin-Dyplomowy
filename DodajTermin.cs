using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Linq;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class DodajTermin : Form
    {
        private readonly bool _hasExistingExam;
        private readonly OperacjeNaTerminach _operacje;
        private readonly TerminarzControl _terminarz;

        public DodajTermin(DateOnly selectedDate,
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

            // ComboBox egzamin  
            cmbEgzamin.Items.Add(new ComboBoxItem("Dodaj egzamin", !_hasExistingExam));
            cmbEgzamin.Items.Add(new ComboBoxItem("Zmień egzamin", _hasExistingExam));
            cmbEgzamin.Items.Add(new ComboBoxItem("Szczegóły egzaminu", _hasExistingExam));
            cmbEgzamin.DisplayMember = nameof(ComboBoxItem.Text);

            btnSubmit.Text = "Dodaj termin";
            LoadOccupiedHours(selectedDate);

            cmbEgzamin.SelectedIndexChanged += CmbEgzamin_SelectedIndexChanged;
            btnSubmit.Click += BtnSubmit_Click;
        }

        private void LoadOccupiedHours(DateOnly date)
        {
            flpOccupied.Controls.Clear();
            // TODO: wczytaj tu terminy z operacjeNaTerminach
            foreach (var t in _operacje.getTerminy().Where(x => x.Data == date))
            {
                var lbl = new Label
                {
                    Text = t.Godzina.ToString("HH:mm"),
                    AutoSize = true,
                    Margin = new Padding(5)
                };
                flpOccupied.Controls.Add(lbl);
            }
        }

        private void CmbEgzamin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEgzamin.SelectedItem is ComboBoxItem item && !item.Enabled)
            {
                MessageBox.Show("Opcja niedostępna.", "Uwaga", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            // Zbieramy dane
            var date = DateOnly.FromDateTime(datePicker.Value);
            var time = TimeOnly.FromDateTime(timePicker.Value);


            bool conflict = _operacje.getTerminy()
                .Any(t =>
                    t.Data == date &&
                    // czy przedział [time, time+1h) nakłada się na [t.Godzina, t.Godzina + t.CzasTrwania)
                    time < t.Godzina.Add(t.CzasTrwania) &&
                    t.Godzina < time.Add(TimeSpan.FromHours(1))
                );
            if (conflict)
            {
                MessageBox.Show("Wybrany termin jest już zajęty.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;    // przerwij, nie dodawaj
            }

            // TODO: Pobierz konkretny obiekt Egzamin według wybranej opcji
            Egzamin egz = null;

            // Tworzymy i dodajemy termin
            var nowyTermin = new Termin(date, time, TimeSpan.FromHours(1), "Nowy", egz);
            _operacje.DodajTermin(nowyTermin);
            _terminarz.addEvent(nowyTermin);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void lblSelectedDate_Click(object sender, EventArgs e)
        {

        }

        private void panelTime_Click(object sender, EventArgs e)
        {

        }
    }

    public class ComboBoxItem
    {
        public string Text { get; }
        public bool Enabled { get; }
        public ComboBoxItem(string text, bool enabled)
        {
            Text = text;
            Enabled = enabled;
        }
        public override string ToString() => Text;
    }
}
