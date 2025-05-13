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
<<<<<<< Updated upstream
        public event EventHandler<string> GetMessage;
=======
        public event EventHandler<string> MessageReceived;
        private readonly Color NormalBorderColor = Color.MediumSlateBlue;
        private readonly Color NormalFocusColor = Color.HotPink;
>>>>>>> Stashed changes
        public logowanie()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            string login = textBox1.Text;
            string haslo = textBox2.Text;
=======
            ResetField(roundedTextBox1);
            ResetField(roundedTextBox2);

            string login = roundedTextBox1.Texts;
            string haslo = roundedTextBox2.Texts;
            //string response = await new HTTPConnection("https://egzamin-dyplomowy.7m.pl/login.php").LogIn(login, haslo);

>>>>>>> Stashed changes
            string url = "https://egzamin-dyplomowy.7m.pl/login.php";
            HTTPConnection conn = new HTTPConnection(url);
            string json = await conn.LogIn(login, haslo);
            var response = new API(json);
<<<<<<< Updated upstream
            if (!response.Success) {
                GetMessage?.Invoke(this, response.Message);
                return;
            }

            token = response.Data["token"].ToObject<string>();
=======
            if (!response.Success)
            {
                MarkError(roundedTextBox1);
                MarkError(roundedTextBox2);
                MessageReceived?.Invoke(this, response.Message);
                return;
            }

            string token = response.Data["token"].ToObject<string>();
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
            GetMessage?.Invoke(this, response.Message + " token:" + token);
            //JSON_label.Text = token;
=======
            MessageReceived?.Invoke(this, response.Message + " token:" + token);

            //JObject json;
            //try
            //{
            //    json = JObject.Parse(response);
            //}
            //catch
            //{
            //    MarkError(roundedTextBox1);
            //    MarkError(roundedTextBox2);
            //    MessageReceived?.Invoke(this, "błąd w serwerze");
            //    return;
            //}

            //bool success = json.Value<bool>("success");
            //string msg = json.Value<string>("message");

            //if (!success)
            //{
            //    //błąd hasła lub maila
            //    MarkError(roundedTextBox1);
            //    MarkError(roundedTextBox2);
            //    MessageReceived?.Invoke(this, msg);
            //}
            //else
            //{
            //    string token = json.Value<string>("token");
            //    ValueChanged?.Invoke(this, token);
            //    main_panel main_Panel = new main_panel(token);
            //    main_Panel.Owner = ;
            //}
>>>>>>> Stashed changes
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
