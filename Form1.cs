using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Security.Policy;

namespace egzamin_dyplomowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            //getJSON();
        }
        public async void sendData()
        {
            string url = "https://egzamin-dyplomowy.7m.pl/login.php";
            HTTPConnection conn = new HTTPConnection(url);
            JSON_label.Text = await conn.LogIn("bcz@gmail.com", "haslo123");
        }
        public async void getJSON()
        {
            string url = "https://blaz1q.github.io/crocodingo/androidAPIVER2.json";
            HTTPConnection connection = new HTTPConnection(url);
            string json = await connection.GetDataAsync();
            Debug.WriteLine(json);
            JSON_label.Text = json;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string haslo = textBox2.Text;
            string url = "https://egzamin-dyplomowy.7m.pl/login.php";
            HTTPConnection conn = new HTTPConnection(url);
            JSON_label.Text = await conn.LogIn(login, haslo);
        }
    }
}
