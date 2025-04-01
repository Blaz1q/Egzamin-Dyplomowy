using Microsoft.VisualBasic.Logging;

namespace Rejestracja
{
    public partial class Form1 : Form
    {
        private Walidacja walidacja = new Walidacja();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonreg_Click(object sender, EventArgs e)
        {
            if (!walidacja.Email(textrejestracja.Text) || !walidacja.Haslo(texthaslo.Text) || texthaslo.Text != textpowtorz.Text)
            {
                MessageBox.Show("Niepoprawne dane rejestracyjne. SprawdŸ email i has³o.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                MessageBox.Show("Rejestracja zakoñczona sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }


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
            Application.Exit();
        }

        private void buttonclear_Click(object sender, EventArgs e)
        {
            textrejestracja.Text = "";
            texthaslo.Text = "";
            textpowtorz.Text = "";
        }
    }
}
