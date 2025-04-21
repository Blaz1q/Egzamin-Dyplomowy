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
    public partial class rejestracja : UserControl
    {
        public event EventHandler<string> ValueChanged;
        public event Action<UserControl> OnSwitchControl;
        public rejestracja()
        {
            InitializeComponent();
        }
        private async void Zarejestruj_button_Click(object sender, EventArgs e)
        {
            string url = "https://egzamin-dyplomowy.7m.pl/rejestracja.php";
            HTTPConnection conn = new HTTPConnection(url);
            string responce = await conn.Register(LoginBox.Text, hasloBox.Text, imieBox.Text, nazwiskoBox.Text);
            ValueChanged?.Invoke(this, responce);
        }
        private void aktywuj_konto_Click_1(object sender, EventArgs e)
        {
            
            if (this.ParentForm is Form1 mainForm)
            {
                aktywuj_konto aktywuj = new aktywuj_konto();
                aktywuj.ValueChanged += mainForm.getToken;
                aktywuj.userlogin = LoginBox.Text;
                mainForm.ChangeUserControl(aktywuj);
            }
        }
    }
}
