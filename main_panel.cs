using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{

    public partial class main_panel : Form
    {
        private String token = "";
        public main_panel(string token)
        {
            InitializeComponent();
            this.token = token;
            LoadDataBase();
            Kalendarz kalendarz = new Kalendarz();
            changeUserControl(kalendarz);
            kalendarz.AddEvent(1, new TimeSpan(9, 30, 0), "BankAtlan Center", Color.RoyalBlue);
            kalendarz.AddEvent(1, new TimeSpan(10, 30, 0), "Cynthia Woods\nMitchell Pavilion", Color.MediumSeaGreen);
            kalendarz.AddEvent(1, new TimeSpan(10, 0, 0), "Skibidi toilet\nGoni mnie", Color.MediumSeaGreen);
        }
        public void changeUserControl(UserControl newControl)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(newControl);
        }
        private async void LoadDataBase() {
            HTTPConnection getDataBase = new HTTPConnection("https://egzamin-dyplomowy.7m.pl/getDataBase.php");
            string json = await getDataBase.SendToken(token);
            API api = new API(json);
            Debug.WriteLine(api.Data);
            api.SetDane();
            Dane.Wykladowcy.WypiszWszystkich();
            Dane.Pytania.WypiszPytania();
            Dane.Studenci.WypiszAll();
        }

        private void main_panel_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Jeśli użytkownik nie kliknął przycisku wylogowania, kończ aplikację
            if (!isLoggingOut)
            {
                Application.Exit(); // bezpieczne i bez zapętlenia
            }
        }
        bool isLoggingOut = false;
        private void wylogujButton_Click(object sender, EventArgs e)
        {
            isLoggingOut = true;
            Form1 mainForm = this.Owner as Form1;
            if (mainForm != null && !mainForm.IsDisposed)
            {
                mainForm.resetInputs();
                mainForm.Show();
            }

            this.Close(); // nie wywoła Application.Exit(), bo isLoggingOut = true
        }
    }
}
