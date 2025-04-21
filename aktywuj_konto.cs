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
    public partial class aktywuj_konto : UserControl
    {
        public event EventHandler<string> ValueChanged;
        public string userlogin;
        public aktywuj_konto()
        {
            InitializeComponent();
        }
        private async void aktywuj_button_Click(object sender, EventArgs e) { 
            string url = "https://egzamin-dyplomowy.7m.pl/activate.php";
            HTTPConnection conn = new HTTPConnection(url);
            var values = new Dictionary<string, string>
            {
                {"ACTIVATETOKEN",kod_aktywacyjnyBox.Text},
                {"USERLOGIN",userlogin}
            };
            string result = await conn.InsertDataAsync(values);
            ValueChanged?.Invoke(this, result);
        }
        private void zaloguj_Click(object sender, EventArgs e) {
            if (this.ParentForm is Form1 mainForm)
            {
                logowanie log = new logowanie();
                log.ValueChanged += mainForm.getToken;
                mainForm.ChangeUserControl(log); // Przełączenie na UserControl2
            }
        }
    }
}
