using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace egzamin_dyplomowy
{
    class HTTPConnection
    {
        private string url;
        public HTTPConnection(string connection_url) {
            this.url = connection_url;
        }
        public async Task<string> GetDataAsync()
        {
            List<string> jsonObjects = new List<string>();

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(this.url, HttpCompletionOption.ResponseHeadersRead))
                using (Stream stream = await response.Content.ReadAsStreamAsync())
                using (StreamReader reader = new StreamReader(stream))
                using (JsonTextReader jsonReader = new JsonTextReader(reader))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    while (jsonReader.Read())
                    {
                        if (jsonReader.TokenType == JsonToken.StartObject)
                        {
                            JObject obj = serializer.Deserialize<JObject>(jsonReader);
                            jsonObjects.Add(obj.ToString()); // Store JSON objects as strings
                        }
                    }
                }
            }
            //Debug.WriteLine("[" + string.Join(",", jsonObjects).Trim() + "]");
            return "[" + string.Join(",", jsonObjects).Trim() + "]"; // Return as a valid JSON array
        }
        public async Task<string> LogIn(string login, string password) {
            var values = new Dictionary<string, string> {
                {"USERLOGIN",login },
                {"USERPASSWORD",password }
            };
            return await this.InsertDataAsync(values);
        }
        public async Task<string> Register(string login, string password, string name, string surname) {
            var values = new Dictionary<string, string> {
                {"USERLOGIN",login },
                {"USERPASSWORD",password },
                {"USERNAME",name},
                {"USERSURNAME",surname}
            };
            return await this.InsertDataAsync(values);
        }
        public async Task<string> SendToken(string token) {
            var values = new Dictionary<string, string>
            {
                { "TOKEN",token}
            };
            return await this.InsertDataAsync(values);
        }
        public async Task<string> InsertDataAsync(Dictionary<string,string> values)
        {
            using (HttpClient client = new HttpClient())
            {
                var content = new FormUrlEncodedContent(values);

                HttpResponseMessage response = await client.PostAsync(this.url, content);
                string result = await response.Content.ReadAsStringAsync();
                Debug.WriteLine(result);
                return result;
                //MessageBox.Show(result);
            }
        }
    }
}
