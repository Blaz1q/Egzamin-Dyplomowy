using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class kalkulator_control : Form
    {
        public kalkulator_control()
        {
            // Ustawienie kultury na polską (działa z przecinkiem)
            Thread.CurrentThread.CurrentCulture = new CultureInfo("pl-PL");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("pl-PL");

            InitializeComponent();

            // Dodaj obsługę KeyPress i Leave dla textboxów 2–7
            for (int i = 2; i <= 7; i++)
            {
                var controls = this.Controls.Find("textBox" + i, true);
                if (controls.Length > 0 && controls[0] is TextBox tb)
                {
                    tb.KeyPress += textBox_KeyPress;
                    tb.Leave += textBox_CheckRange;
                }
            }
            textBox1.Leave += textBox1_CheckRange;
        }

        private void kalkulator_control_Load(object sender, EventArgs e)
        {
            textBox8.ReadOnly = true;
            this.roundedButton1.Click += roundedButton1_Click;
        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            bool success = true;

            success &= double.TryParse(textBox1.Text, out double sredniaStudia);
            success &= double.TryParse(textBox2.Text, out double promotor);
            success &= double.TryParse(textBox3.Text, out double recenzent);
            success &= double.TryParse(textBox4.Text, out double prezentacja);
            success &= double.TryParse(textBox5.Text, out double pytanie1);
            success &= double.TryParse(textBox6.Text, out double pytanie2);
            success &= double.TryParse(textBox7.Text, out double pytanie3);

            if (!success)
            {
                MessageBox.Show("Upewnij się, że wszystkie pola zawierają poprawne liczby.");
                return;
            }

            double sredniaPraca = (promotor + recenzent) / 2.0;
            double sredniaEgzamin = (prezentacja + pytanie1 + pytanie2 + pytanie3) / 4.0;
            double sredniaKoncowa = 0.5 * sredniaStudia + 0.25 * sredniaPraca + 0.25 * sredniaEgzamin;

            textBox8.Text = OcenaZeSredniej(sredniaKoncowa);
        }

        private string OcenaZeSredniej(double srednia)
        {
            if (srednia >= 4.70)
                return "celująca (5,5)";
            else if (srednia >= 4.50)
                return "bardzo dobra (5,0)";
            else if (srednia >= 4.20)
                return "dobra plus (4,5)";
            else if (srednia >= 3.80)
                return "dobra (4,0)";
            else if (srednia >= 3.40)
                return "dostateczna plus (3,5)";
            else
                return "dostateczna (3,0)";
        }

        private void textBox_CheckRange(object sender, EventArgs e)
        {
            if (sender is not TextBox tb) return;

            string text = tb.Text.Trim();

            if (string.IsNullOrEmpty(text))
                return;

            if (double.TryParse(text, out double val))
            {
                if (val < 3 || val > 5)
                {
                    MessageBox.Show("Wartość musi być w zakresie od 3 do 5.");
                    tb.Focus();
                    tb.SelectAll();
                    return;
                }

                if (val % 1 != 0 && Math.Abs(val % 1 - 0.5) > 0.0001)
                {
                    MessageBox.Show("Dozwolone wartości to liczby całkowite lub z końcówką ,5 (np. 3, 3,5, 4, 4,5, 5).");
                    tb.Focus();
                    tb.SelectAll();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Wpisz poprawną liczbę.");
                tb.Focus();
                tb.SelectAll();
            }
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Pozwól tylko na cyfry, przecinek, kropkę i klawisze sterujące
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                e.KeyChar != ',' && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Jeśli użytkownik wpisze kropkę, zamień na przecinek
            if (e.KeyChar == '.')
            {
                e.KeyChar = ',';
            }
        }
        private void textBox1_CheckRange(object sender, EventArgs e)
        {
            if (sender is not TextBox tb) return;

            string text = tb.Text.Trim();

            if (string.IsNullOrEmpty(text))
                return;

            if (double.TryParse(text, out double val))
            {
                if (val < 3 || val > 5)
                {
                    MessageBox.Show("Średnia ze studiów musi być w zakresie od 3 do 5 (część po przecinku dowolna).");
                    tb.Focus();
                    tb.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Wpisz poprawną liczbę.");
                tb.Focus();
                tb.SelectAll();
            }
        }


        // Niepotrzebne, ale zachowane dla zgodności z sprojektantem
        private void label8_Click(object sender, EventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
