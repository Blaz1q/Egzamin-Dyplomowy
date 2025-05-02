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
        public event EventHandler<string> ValueChanged;
        public event EventHandler<string> MessageReceived;
        private readonly Color NormalBorderColor = Color.MediumSlateBlue;
        private readonly Color NormalFocusColor = Color.HotPink;

        public logowanie()
        {
            InitializeComponent();
            roundedTextBox1._TextChanged += (_, __) => ResetField(roundedTextBox1);
            roundedTextBox2._TextChanged += (_, __) => ResetField(roundedTextBox2);
        }

        private async void roundedButton1_Click(object sender, EventArgs e)
        {
            ResetField(roundedTextBox1);
            ResetField(roundedTextBox2);

            string login = roundedTextBox1.Texts;
            string haslo = roundedTextBox2.Texts;
            string response = await new HTTPConnection("https://egzamin-dyplomowy.7m.pl/login.php")
                                     .LogIn(login, haslo);

            JObject json;
            try
            {
                json = JObject.Parse(response);
            }
            catch
            {
                MarkError(roundedTextBox1);
                MarkError(roundedTextBox2);
                MessageReceived?.Invoke(this, "błąd w serwerze");
                return;
            }

            bool success = json.Value<bool>("success");
            string msg = json.Value<string>("message");

            if (!success)
            {
                //błąd hasła lub maila
                MarkError(roundedTextBox1);
                MarkError(roundedTextBox2);
                MessageReceived?.Invoke(this, msg);
            }
            else
            {
                string token = json.Value<string>("token");
                ValueChanged?.Invoke(this, token);
            }
        }

        private void MarkError(RoundedTextBox box)
        {
            box.isValid = false;
            box.Invalidate();
        }

        private void ResetField(RoundedTextBox box)
        {
            box.isValid = true;
            box.BorderColor = NormalBorderColor;
            box.BorderFocusColor = NormalFocusColor;
            box.Invalidate();
        }
        private void rejestracja_Click(object sender, EventArgs e)
        {
            if (this.ParentForm is Form1 mainForm)
            {
                var rej = new RejestracjaControl();
                rej.ValueChanged += mainForm.getToken;
                mainForm.ChangeUserControl(rej);
            }
        }


        private void logowanie_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ParentForm is Form1 mainForm)
            {
                var ctl = new RejestracjaControl();  //forgot password POPRAWIĆ!!!
                mainForm.ChangeUserControl(ctl);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ParentForm is Form1 mainForm)
            {
                var ctl = new RejestracjaControl();  //Rejestracja
                mainForm.ChangeUserControl(ctl);
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.ParentForm is Form1 mainForm)
            {
                var ctl = new RejestracjaControl();  //activate account POPRAWIĆ!!!
                mainForm.ChangeUserControl(ctl);
            }
        }


    }
}
