using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace egzamin_dyplomowy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getJSON();
        }
        public async void getJSON()
        {
            string url = "https://blaz1q.github.io/crocodingo/androidAPIVER2.json";
            HTTPConnection connection = new HTTPConnection(url);
            string json = await connection.GetDataAsync();
            Debug.WriteLine(json);
            JSON_label.Text = json;
        }
    }
}
