using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class logowanie : UserControl
    {
        public event EventHandler<string> ValueChanged;
        public logowanie()
        {
            InitializeComponent();
        }
        public string token = "";
        private async void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string haslo = textBox2.Text;
            string url = "https://egzamin-dyplomowy.7m.pl/login.php";
            HTTPConnection conn = new HTTPConnection(url);
            token = await conn.LogIn(login, haslo);
            ValueChanged?.Invoke(this, token);
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
