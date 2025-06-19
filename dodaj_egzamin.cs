using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace egzamin_dyplomowy
{
    public partial class dodaj_egzamin : Form
    {
        Egzamin egzamin;
        string kierunek;
        Wykladowca current_osoba;
        Pytanie[] pytania = new Pytanie[3];
        public event Action<Egzamin> egzamin_set;
        public dodaj_egzamin(Wykladowca wykladowca)
        {
            this.kierunek = "Informatyka";
            this.current_osoba = wykladowca;
            InitializeComponent();
            wstaw_wykladowcow(comboBox2, "Promotor");
            wstaw_wykladowcow(comboBox3, "Recenzent");
            wstaw_wykladowcow(comboBox4, "Prodziekan");
            wstaw_studentow(comboBox1);
            switch (current_osoba.Status)
            {
                case "Prodziekan":
                    UstawComboBoxNaWartosci(comboBox4, current_osoba);
                    comboBox4.Enabled = false;
                    break;
                case "Recenzent":
                    UstawComboBoxNaWartosci(comboBox3, current_osoba);
                    comboBox3.Enabled = false;
                    break;
                case "Promotor":
                    UstawComboBoxNaWartosci(comboBox2, current_osoba);
                    comboBox2.Enabled = false;
                    break;
            }
        }
        public class ComboBoxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public override string ToString()
            {
                return Text;
            }
        }
        private void UstawComboBoxNaWartosci(ComboBox comboBox, Wykladowca wykladowca)
        {
            foreach (ComboBoxItem item in comboBox.Items)
            {
                if (item.Value is Wykladowca w && w.Id == wykladowca.Id)
                {
                    comboBox.SelectedItem = item;
                    break;
                }
            }
        }
        private void wstaw_wykladowcow(ComboBox combobox, string type)
        {
            foreach (Wykladowca wykladowca in Dane.Wykladowcy.getLista())
            {
                if (wykladowca.Status == type)
                {
                    combobox.Items.Add(new ComboBoxItem
                    {
                        Text = $"{wykladowca.GetImie()} {wykladowca.GetNazwisko()}",
                        Value = wykladowca
                    });
                }
            }
        }
        private void wstaw_studentow(ComboBox combobox)
        {
            foreach (Student student in Dane.Studenci.getLista())
            {
                combobox.Items.Add(new ComboBoxItem
                {
                    Text = $"{student.GetImie()} {student.GetNazwisko()}",
                    Value = student
                });
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null ||
                comboBox3.SelectedItem == null ||
                comboBox4.SelectedItem == null ||
                comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Wybierz wszystkie osoby z komisji i studenta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random rand = new Random();
            // Dane.Pytania.LosujPytania()
            // Losuj pytania i przypisz do odpowiednich etykiet
            //  Dane.Pytania = Dane.Pytania[rand.Next(.Count)];
            // Dane.Pytania = Dane.Pytania[rand.Next(ListaPytan.Count)];
            //Dane.Pytania = Dane.Pytania[rand.Next(ListaPytan.Count)];
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        private object getItem(ComboBox combobox)
        {
            if (combobox.SelectedItem == null) return null;

            ComboBoxItem item = combobox.SelectedItem as ComboBoxItem;
            return item?.Value;
        }
        private void roundedButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null ||
        comboBox2.SelectedItem == null ||
        comboBox3.SelectedItem == null ||
        comboBox4.SelectedItem == null)
            {
                MessageBox.Show("Wybierz wszystkie osoby: studenta i całą komisję.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Promotor promotor = (Promotor)getItem(comboBox2);
            var recenzent = (Wykladowca)getItem(comboBox3);
            var prodziekan = (Wykladowca)getItem(comboBox4);

            var pytaniaPromotor = Dane.Pytania.GetPytanie(Dane.Pytania.LosujPytania(this.kierunek,promotor, 1)[0]);
            var pytaniaRecenzent = Dane.Pytania.GetPytanie(Dane.Pytania.LosujPytania(this.kierunek,recenzent, 1)[0]);
            var pytaniaProdziekan = Dane.Pytania.GetPytanie(Dane.Pytania.LosujPytania(this.kierunek, prodziekan, 1)[0]);
            textBox1.Text = pytaniaPromotor.GetTresc();
            textBox2.Text = pytaniaRecenzent.GetTresc();
            textBox3.Text = pytaniaProdziekan.GetTresc();

            //  if (pytaniaPromotor.Count == 0 || pytaniaRecenzent.Count == 0 || pytaniaProdziekan.Count == 0)

            //List<int> wylosowaneId = Dane.Pytania.LosujPytaniaDlaKierunku("informatyka", 3);
            /* {
                 MessageBox.Show("Brakuje pytań dla jednego z wykładowców.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 return;
             } */
            //if (wylosowaneId.Count >= 3)
            //{
            //    textBox1.Text = PobierzTrescPoId(wylosowaneId[0]);
            //    textBox2.Text = PobierzTrescPoId(wylosowaneId[1]);
            //    textBox3.Text = PobierzTrescPoId(wylosowaneId[2]);
            //}
            //else
            //{
            //    MessageBox.Show("Brak pytań dla wybranego kierunku.");
            //}
        }

        private string PobierzTrescPoId(int id)
        {
            var lista = Dane.Pytania.GetType()
                .GetField("pytania", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                .GetValue(Dane.Pytania) as List<Pytanie>;

            var pytanie = lista?.FirstOrDefault(p => p.Id == id);
            return pytanie != null ? pytanie.GetTresc() : "Nie znaleziono pytania.";
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dodaj_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton2_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text) ||
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Musisz najpierw wylosować wszystkie pytania.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<Pytanie> lista = pytania.ToList();
            egzamin = new Egzamin((Student)getItem(comboBox1), (Promotor)getItem(comboBox2), (Wykladowca)getItem(comboBox3), (Wykladowca)getItem(comboBox4), lista);
            egzamin_set.Invoke(egzamin);
            this.Close();
        }

        private void roundedButton3_Click(object sender, EventArgs e)
        {
            Promotor promotor = (Promotor)getItem(comboBox2);
            if (promotor == null)
            {
                MessageBox.Show("Wybierz promotora.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pytanie = Dane.Pytania.GetPytanie(Dane.Pytania.LosujPytania(this.kierunek, promotor, 1)[0]);
            pytania[0] = pytanie;
            textBox1.Text = pytanie.GetTresc();
        }


        private void roundedButton4_Click(object sender, EventArgs e)
        {
            Wykladowca recenzent = (Wykladowca)getItem(comboBox3);
            if (recenzent == null)
            {
                MessageBox.Show("Wybierz recenzenta.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pytanie = Dane.Pytania.GetPytanie(Dane.Pytania.LosujPytania(this.kierunek, recenzent, 1)[0]);
            pytania[1] = pytanie;
            textBox2.Text = pytanie.GetTresc();
        }

        
        private void roundedButton5_Click(object sender, EventArgs e)
        {
            Wykladowca prodziekan = (Wykladowca)getItem(comboBox4);
            if (prodziekan == null)
            {
                MessageBox.Show("Wybierz prodziekana.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var pytanie = Dane.Pytania.GetPytanie(Dane.Pytania.LosujPytania(this.kierunek, prodziekan, 1)[0]);
            pytania[2] = pytanie;
            textBox3.Text = pytanie.GetTresc();
        }

    }
}

