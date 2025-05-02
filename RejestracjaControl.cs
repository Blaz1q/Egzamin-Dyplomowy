using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace egzamin_dyplomowy
{
    public partial class RejestracjaControl : UserControl
    {
        private Walidacja walidacja = new Walidacja();
        public event EventHandler<string> ValueChanged;
        public event Action<UserControl> OnSwitchControl;
        public RejestracjaControl()
        {
            InitializeComponent();

        }

        private async void buttonreg_Click(object sender, EventArgs e)
        {
            if (!walidacja.Email(textrejestracja.Text) || !walidacja.Haslo(texthaslo.Text) || texthaslo.Text != textpowtorz.Text || !walidacja.imie(textimie.Text) || !walidacja.nazwisko(textnazwisko.Text))
            {
                if (!walidacja.Email(textrejestracja.Text))
                {
                    MessageBox.Show("Niepoprawny forma e-mail'u.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!walidacja.Haslo(texthaslo.Text))
                {
                    MessageBox.Show("Hasło nie spełnia wymagań.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (texthaslo.Text != textpowtorz.Text)
                {
                    MessageBox.Show("Hasła są różne.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!walidacja.imie(textimie.Text))
                {
                    MessageBox.Show("Niepoprawnie wpisane imię.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (!walidacja.nazwisko(textnazwisko.Text))
                {
                    MessageBox.Show("Niepoprawnie wpisane nazwisko.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            else
            {
                MessageBox.Show("Rejestracja zakończona sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string url = "https://egzamin-dyplomowy.7m.pl/rejestracja.php";
                HTTPConnection conn = new HTTPConnection(url);
                string responce = await conn.Register(textrejestracja.Text.ToLower(), texthaslo.Text, textimie.Text, textnazwisko.Text);
                ValueChanged?.Invoke(this, responce);
            }
        }
        private void RejestracjaControl_Load(object sender, EventArgs e)
        {

        }

        private void oko_Click(object sender, EventArgs e)
        {
            texthaslo.UseSystemPasswordChar = !texthaslo.UseSystemPasswordChar;
        }

        private void oko2_Click(object sender, EventArgs e)
        {
            textpowtorz.UseSystemPasswordChar = !textpowtorz.UseSystemPasswordChar;
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 mainForm)
            {
                aktywuj_konto aktywuj = new aktywuj_konto();
                aktywuj.ValueChanged += mainForm.getToken;
                aktywuj.userlogin = textrejestracja.Text;
                mainForm.ChangeUserControl(aktywuj);
            }
        }



        private void buttonclear_Click(object sender, EventArgs e)
        {
            textrejestracja.Text = "";
            texthaslo.Text = "";
            textpowtorz.Text = "";
            textimie.Text = "";
            textnazwisko.Text = "";
        }

        private void texthaslo_TextChanged(object sender, EventArgs e)
        {
            string haslo = texthaslo.Text; 

     
            string wynikWalidacji = walidacja.WalidujHaslo(haslo);

            if (!string.IsNullOrEmpty(wynikWalidacji))
            {
           
                hasloerr.Visible = true;
                toolTip1.SetToolTip(hasloerr, wynikWalidacji);
            }
            else
            {
          
                hasloerr.Visible = false;
                toolTip1.SetToolTip(hasloerr, "");
            }
        }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void pictureBox7_Click_1(object sender, EventArgs e)
        {

        }

    }
}
