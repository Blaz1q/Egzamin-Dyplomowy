using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class Rejestrowanie : UserControl
    {
        private RoundLabel komunikatLabel;
        public event EventHandler<string> ValueChanged;
        public Rejestrowanie()
        {
            InitializeComponent();
            InicjujKomunikatLabel();
        }

        private void InicjujKomunikatLabel()
        {
            komunikatLabel = new RoundLabel
            {
                AutoSize = false,
                Size = new Size(409, 100),
                Location = new Point(52, 535), // pod przyciskiem
                ForeColor = Color.White,
                _BackColor = Color.Red,
                BorderRadius = 10,
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Visible = false
            };
            Controls.Add(komunikatLabel);
            komunikatLabel.BringToFront();
        }

        private async void roundedButton1_Click(object sender, EventArgs e)
        {
            Walidacja walidacja = new Walidacja();

            string email = mailtext.Texts.Trim();
            string haslo = HasloText.Texts;
            string powtHaslo = PowtHasloText.Texts;

            List<string> bledy = new List<string>();

            if (!walidacja.Email(email))
                bledy.Add("Niepoprawna forma email.");

            if (haslo.Length < 8)
                bledy.Add("Has³o ma mieæ co najmniej 8 znaków.");

            if (!Regex.IsMatch(haslo, "[A-Z]"))
                bledy.Add("Has³o musi zawieraæ co najmniej jedn¹ wielk¹ literê.");

            if (!Regex.IsMatch(haslo, "\\d"))
                bledy.Add("Has³o musi mieæ co najmniej jedn¹ cyfrê.");

            if (haslo != powtHaslo)
                bledy.Add("Has³a nie s¹ takie same.");

            if (bledy.Count > 0)
            {
                komunikatLabel.Text = string.Join("\n", bledy);
                komunikatLabel.Visible = true;
            }
            else
            {
                komunikatLabel.Visible = false;
                MessageBox.Show("Rejestracja zakoñczona sukcesem!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string url = "https://egzamin-dyplomowy.7m.pl/rejestracja.php";
                HTTPConnection conn = new HTTPConnection(url);
                string responce = await conn.Register(email, haslo, "imie", "nazwisko");
                //string responce = await conn.Register(textrejestracja.Text.ToLower(), texthaslo.Text, textimie.Text, textnazwisko.Text);
                ValueChanged?.Invoke(this, responce);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ParentForm is Form1 mainForm)
            {
                aktywuj_konto aktywuj = new aktywuj_konto();
                aktywuj.ValueChanged += mainForm.getToken;
                aktywuj.userlogin = mailtext.Text;
                mainForm.ChangeUserControl(aktywuj);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void powrotlogowanielinl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ParentForm is Form1 mainForm)
            {
                logowanie aktywuj = new logowanie();
                aktywuj.ValueChanged += mainForm.getToken;
                mainForm.ChangeUserControl(aktywuj);
            }
        }
    }
}
