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
        private KalendarzControl kalendarz = new KalendarzControl();
        public main_panel(string token)
        {
            InitializeComponent();
            this.token = token;
            initAsync();
            //Kalendarz2 kalendarz = new Kalendarz2();
            //Kalendarz kalendarz = new Kalendarz()
            //kalendarz.Dock = DockStyle.Fill;
            kalendarz.Dock = DockStyle.Fill;
            changeUserControl(kalendarz);
            // kalendarz.AddEvent(1, new TimeSpan(9, 30, 0), "BankAtlan Center", Color.RoyalBlue);
            //kalendarz.AddEvent(1, new TimeSpan(10, 30, 0), "Cynthia Woods\nMitchell Pavilion", Color.MediumSeaGreen);
            //kalendarz.AddEvent(1, new TimeSpan(10, 0, 0), "Skibidi toilet\nGoni mnie", Color.MediumSeaGreen);
        }
        public void changeUserControl(UserControl newControl)
        {
            panel2.Controls.Clear();
            panel2.Controls.Add(newControl);
        }
        private async void initAsync()
        {
            await Task.Run(() => LoadDataBase());
            if (Dane.User.getPoziom_dostepu() <= 1)
            {
                uzytkownicyButton.Visible = false;
            }
            else
            {
                uzytkownicyButton.Visible = true;
            }
        }
        private async void LoadDataBase()
        {
            HTTPConnection getDataBase = new HTTPConnection("https://egzamin-dyplomowy.7m.pl/getDataBase.php");
            string json = await getDataBase.SendToken(token);
            API api = new API(json);
            //Debug.WriteLine(api.Data);
            api.SetDane();
            //Dane.Wykladowcy.WypiszWszystkich();
            //Dane.Pytania.WypiszPytania();
            //Dane.Studenci.WypiszAll();
            kalendarz.terminarz.initTerminy();

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
        public void edytujPytania(Pytanie pytanie)
        {
            changeUserControl(new edytuj_pytania(pytanie));
        }
        private void pytaniaButton_Click(object sender, EventArgs e)
        {
            Pytania pytaniacontrol = new Pytania();
            pytaniacontrol.Dock = DockStyle.Fill;
            pytaniacontrol.OnEdytuj += edytujPytania;
            changeUserControl(pytaniacontrol);
        }

        private void CalendarButton_Click(object sender, EventArgs e)
        {
            changeUserControl(kalendarz);
        }

        private void uzytkownicyButton_Click(object sender, EventArgs e)
        {
            ListaOsob listaOsob = new ListaOsob();
            listaOsob.Dock= DockStyle.Fill;
            changeUserControl(listaOsob);
        }
    }
}
