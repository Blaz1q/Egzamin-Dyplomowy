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
    public partial class edytuj_pytania : UserControl
    {
        public Pytanie Pytanie;
        public List<Wykladowca> wszyscyWykladowcy = new List<Wykladowca>();
        public edytuj_pytania(Pytanie pytanie, List<Wykladowca> wszyscyWykladowcy)
        {
            InitializeComponent();

            //pobranie tresci pytania
            this.Pytanie = pytanie;
            textBoxTresc.Text = Pytanie.GetTresc();

            this.wszyscyWykladowcy = wszyscyWykladowcy;

            comboBoxWykladowcy.DataSource = wszyscyWykladowcy;
            comboBoxWykladowcy.DisplayMember = "ImieNazwisko"; // Właściwość pomocnicza

            //dodaje wykladowcow jako tagbuttony, a po wcisnieciu ich znikaja
            foreach (var wykladowca in Pytanie.GetWykladowcy())
            {
                TagButton tag = new TagButton();
                tag.Text = wykladowca.Imie + " " + wykladowca.Nazwisko;
                tag.Tag = wykladowca;
                tag.Margin = new Padding(5);
                tag.Click += (s, e) =>
                {
                    // Kliknięcie w tag usuwa go z panelu
                    flowLayoutPanelWykladowcy.Controls.Remove((Control)s);
                };
                flowLayoutPanelWykladowcy.Controls.Add(tag);
            }

            comboBoxWykladowcy.SelectedIndexChanged += ComboBoxWykladowcy_SelectedIndexChanged;
        }
        private void ComboBoxWykladowcy_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedWykladowca = comboBoxWykladowcy.SelectedItem as Wykladowca;

            if (selectedWykladowca != null)
            {
                // Sprawdź czy już istnieje taki TagButton (żeby nie dublować)
                foreach (Control c in flowLayoutPanelWykladowcy.Controls)
                {
                    if (c is TagButton tag && tag.Tag is Wykladowca w && w.Id == selectedWykladowca.Id)
                    {
                        return; // już dodany
                    }
                }

                // Tworzymy TagButton
                TagButton tagButton = new TagButton();
                tagButton.Text = selectedWykladowca.Imie + " " + selectedWykladowca.Nazwisko;
                tagButton.Tag = selectedWykladowca;
                tagButton.Margin = new Padding(5);
                tagButton.Click += (s, eArgs) =>
                {
                    flowLayoutPanelWykladowcy.Controls.Remove((Control)s);
                };

                flowLayoutPanelWykladowcy.Controls.Add(tagButton);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void UsunPytanie_Click(object sender, EventArgs e)
        {
            // Potwierdzenie przed usunięciem
            var wynik = MessageBox.Show("Czy na pewno chcesz usunąć to pytanie?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (wynik == DialogResult.Yes)
            {
                ZarzadzaniePytaniami.UsunPytanie(Pytanie.Id);
                MessageBox.Show("Pytanie zostało usunięte.");

                this.Parent.Controls.Remove(this);
            }
        }
        private void EdytujPytanie_Click(object sender, EventArgs e)
        {
            // Pobierz nową treść pytania z textboxa
            string nowaTresc = textBoxTresc.Text;

            // Pobierz aktualną listę wykładowców z flowLayoutPanelWykladowcy
            List<Wykladowca> nowiWykladowcy = new List<Wykladowca>();
            foreach (Control control in flowLayoutPanelWykladowcy.Controls)
            {
                if (control is TagButton tagButton && tagButton.Tag is Wykladowca wykladowca)
                {
                    nowiWykladowcy.Add(wykladowca);
                }
            }

            // Weryfikacja
            if (string.IsNullOrWhiteSpace(nowaTresc))
            {
                MessageBox.Show("Treść pytania nie może być pusta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nowiWykladowcy.Count == 0)
            {
                MessageBox.Show("Dodaj przynajmniej jednego wykładowcę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Wywołanie metody edytującej
            ZarzadzaniePytaniami.EdytujPytanie(
                Pytanie.Id,
                nowaTresc,
                Pytanie.Kierunek,
                nowiWykladowcy,
                Pytanie.Kategoria,
                Pytanie.Poziom
            );

            MessageBox.Show("Pytanie zostało zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
