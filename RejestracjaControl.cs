using System;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class RejestracjaControl : UserControl
    {
        private Walidacja walidacja = new Walidacja();

        public RejestracjaControl()
        {
            InitializeComponent();
        }

        private void buttonreg_Click(object sender, EventArgs e)
        {
            if (!walidacja.Email(textrejestracja.Text) || !walidacja.Haslo(texthaslo.Text) || texthaslo.Text != textpowtorz.Text)
            {
                MessageBox.Show("Niepoprawne dane rejestracyjne. Sprawdź email i hasło.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                MessageBox.Show("Rejestracja zakończona sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            MessageBox.Show("Tu bedzie można podpiąć cofnięcie sie w aplkiacji ewentualnie bedzie mozna tu walnąć cos na zasadzie: masz juz konto? zaloguj sie etc", "jak co to wywale", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textrejestracja.Text = "";
            texthaslo.Text = "";
            textpowtorz.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
    }
}
