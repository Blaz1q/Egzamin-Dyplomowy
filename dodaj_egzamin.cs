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
        public dodaj_egzamin()
        {
            var promotor = new Promotor(0, "Zbigniew", "Promotor", "XD");
            var recenzent = new Wykladowca(1, "Zbigniew", "Recenzent", "Recenzent");
            var prodziekan = new Wykladowca(2, "Zbigniew", "Prodziekan", "Prodziekan");


            // Dodajemy wykładowców do systemu
            Dane.Wykladowcy.DodajWykladowce(promotor);
            Dane.Wykladowcy.DodajWykladowce(recenzent);
            Dane.Wykladowcy.DodajWykladowce(prodziekan);

            var lista1 = new List<Wykladowca> { promotor };
            var lista2 = new List<Wykladowca> { recenzent };
            var lista3 = new List<Wykladowca> { prodziekan };
            var lista4 = new List<Wykladowca> { promotor };
            var lista5 = new List<Wykladowca> { recenzent, promotor };

            Dane.Pytania.DodajPytanie("Co to jest Skibidi?", "informatyka", lista1, "ogólne", "inżynierskie");
            Dane.Pytania.DodajPytanie("Wyjaśnij zjawisko powstania ziemi.", "informatyka", lista2, "specjalistyczne", "magisterskie");
            Dane.Pytania.DodajPytanie("Kim jesteś?", "informatyka", lista3, "rozszerzone", "inżynierskie");
            Dane.Pytania.DodajPytanie("jak wygonić smoka z kuchni?", "informatyka", lista4, "ogólne", "inżynierskie");
            Dane.Pytania.DodajPytanie("Do czego służy miernikmagnetoelektryczny?", "informatyka", lista5, "ogólne", "inżynierskie");
            //Dane.Wykladowcy.DodajWykladowce(0, "Zbigniew", "Recenzent", "Recenzent");
            //Dane.Wykladowcy.DodajWykladowce(1, "Zbigniew", "Otremba", "Promotor");
            //Dane.Wykladowcy.DodajWykladowce(new Promotor(1, "Zbigniew", "Promotor", "C122"));
            //Dane.Wykladowcy.DodajWykladowce(2, "Zbigniew", "Prodziekan", "Prodziekan");

            InitializeComponent();
            wstaw_wykladowcow(comboBox2, "Promotor");
            wstaw_wykladowcow(comboBox3, "Recenzent");
            wstaw_wykladowcow(comboBox4, "Prodziekan");

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
        private void wstaw_wykladowcow(ComboBox combobox, string type)
        {
            foreach (Wykladowca wykladowca in Dane.Wykladowcy.getLista())
            {
                if (wykladowca.Status == type)
                {
                    combobox.Items.Add(new ComboBoxItem
                    {
                        Text = $"{wykladowca.Imie} {wykladowca.Nazwisko}",
                        Value = wykladowca
                    });
                }
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

            var pytaniaPromotor = Dane.Pytania.GetPytanie(Dane.Pytania.LosujPytaniaDlaWykladowcy(promotor, 1)[0]);
            var pytaniaRecenzent = Dane.Pytania.GetPytanie(Dane.Pytania.LosujPytaniaDlaWykladowcy(recenzent, 1)[0]);
            var pytaniaProdziekan = Dane.Pytania.GetPytanie(Dane.Pytania.LosujPytaniaDlaWykladowcy(prodziekan, 1)[0]);
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
                    MessageBox.Show("Wszystkie pytania zostały wylosowane, możesz kontynuować.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
      
    }
}

