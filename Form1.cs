using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Resources;
using System.Security.Policy;

namespace egzamin_dyplomowy
{
    public partial class Form1 : Form
    {
        public static string token;
        public Form1()
        {
            InitializeComponent();
            resetInputs(); 
            
            //getJSON();
        }
        public void resetInputs() {
            logowanie log = new logowanie();
            log.ValueChanged += getToken;
            log.MessageReceived += getMessage;
            ChangeUserControl(log);
            JSON_label.Text = "";
            token = "";
        }
        public void ChangeUserControl(UserControl newControl)
        {
            panel1.Controls.Clear();
            panel1.Controls.Add(newControl);
        }
        public async void sendData()
        {
            string url = "https://egzamin-dyplomowy.7m.pl/login.php";
            HTTPConnection conn = new HTTPConnection(url);
            JSON_label.Text = await conn.LogIn("bcz@gmail.com", "haslo123");
        }
        public void getToken(object sender, string value)
        {
            token = value;
        }
        public void getMessage(object sender, string value) {
            JSON_label.Text = value;
        }
        public async void getJSON()
        {
            string url = "https://blaz1q.github.io/crocodingo/androidAPIVER2.json";
            HTTPConnection connection = new HTTPConnection(url);
            string json = await connection.GetDataAsync();
            Debug.WriteLine(json);
            JSON_label.Text = json;
        }
        private async void waliduj_token_Click(object sender, EventArgs e)
        {
            string url = "https://egzamin-dyplomowy.7m.pl/getDataBase.php";
            HTTPConnection conn = new HTTPConnection(url);
            Debug.WriteLine("token: " + token);
            JSON_label.Text = await conn.SendToken(token);
        }

        private void Zmien_token_Click(object sender, EventArgs e)
        {
            token = JSON_label.Text;
        }

        private void przejdz_do_aplikacji_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_panel main_Panel = new main_panel(token);
            main_Panel.Owner = this;
            main_Panel.Show();
        }
    }
}
