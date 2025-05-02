using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class logowanie : UserControl
    {
        public string token = Form1.token;
        public event EventHandler<string> ValueChanged;
        public event EventHandler<string> GetMessage;
        public logowanie()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string haslo = textBox2.Text;
            string url = "https://egzamin-dyplomowy.7m.pl/login.php";
            HTTPConnection conn = new HTTPConnection(url);
            string json = await conn.LogIn(login, haslo);
            var response = new API(json);
            if (!response.Success) {
                GetMessage?.Invoke(this, response.Message);
                return;
            }

            token = response.Data["token"].ToObject<string>();
            string databaseConn = "https://egzamin-dyplomowy.7m.pl/validate.php";
            conn = new HTTPConnection(databaseConn);
            string validate = await conn.SendToken(token);
            var validateToken = new API(validate);
            if (validateToken.Success)
            {
                if (this.ParentForm is Form1 mainForm)
                {
                    mainForm.Hide();
                    main_panel main_Panel = new main_panel(token);
                    main_Panel.Owner = mainForm;
                    main_Panel.Show();
                }
            }
            GetMessage?.Invoke(this, response.Message + " token:" + token);
            //JSON_label.Text = token;
        }

        private void rejestracja_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 mainForm)
            {
                RejestracjaControl rej = new RejestracjaControl();
                rej.ValueChanged += mainForm.getToken;
                mainForm.ChangeUserControl(rej); // Przełączenie na UserControl2
            }
        }
    }
}
