using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class dodaj_pytania : UserControl
    {
        private List<Wykladowca> wszyscyWykladowcy = Dane.Wykladowcy.getLista();

        public dodaj_pytania()
        {
            InitializeComponent();

            // Inicjalizacja wykładowców
            comboBoxWykladowcy.DataSource = wszyscyWykladowcy;
            comboBoxWykladowcy.DisplayMember = "ImieNazwisko";
            comboBoxWykladowcy.SelectedIndexChanged += ComboBoxWykladowcy_SelectedIndexChanged;

            // Inicjalizacja stopnia
            comboBoxStopien.Items.AddRange(new object[] { "INŻYNIER", "MAGISTER" });
            comboBoxStopien.SelectedIndex = 0;
        }

        private void ComboBoxWykladowcy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = comboBoxWykladowcy.SelectedItem as Wykladowca;
            if (selected == null) return;

            // unikaj duplikatów
            if (flowLayoutPanelWykladowcy.Controls.OfType<TagButton>()
                .Any(t => (t.Tag as Wykladowca)?.Id == selected.Id))
                return;

            var tagBtn = new TagButton
            {
                Text = selected.GetImie() + " " + selected.GetNazwisko(),
                Tag = selected,
                Margin = new Padding(5)
            };
            tagBtn.Click += (s, args) => flowLayoutPanelWykladowcy.Controls.Remove((Control)s);
            flowLayoutPanelWykladowcy.Controls.Add(tagBtn);
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            string tresc = textBoxTresc.Text.Trim();
            string kierunek = textBoxKierunek.Text.Trim();
            string specjalnosc = textBoxSpecjalnosc.Text.Trim();
            string stopien = comboBoxStopien.SelectedItem?.ToString();

            var wykladowcy = flowLayoutPanelWykladowcy.Controls
                .OfType<TagButton>()
                .Select(t => t.Tag as Wykladowca)
                .Where(w => w != null)
                .ToList();

            // Walidacja
            if (string.IsNullOrEmpty(tresc))
            {
                MessageBox.Show("Treść pytania nie może być pusta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(kierunek))
            {
                MessageBox.Show("Wpisz kierunek.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(specjalnosc))
            {
                MessageBox.Show("Wpisz specjalność.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(stopien))
            {
                MessageBox.Show("Wybierz stopień.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!wykladowcy.Any())
            {
                MessageBox.Show("Dodaj przynajmniej jednego egzaminatora.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Dane.Pytania.DodajPytanie(tresc, kierunek, wykladowcy, specjalnosc, stopien);
            MessageBox.Show("Pytanie zostało dodane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Reset formularza
            textBoxTresc.Clear();
            textBoxKierunek.Clear();
            textBoxSpecjalnosc.Clear();
            comboBoxStopien.SelectedIndex = 0;
            flowLayoutPanelWykladowcy.Controls.Clear();
        }
    }
}