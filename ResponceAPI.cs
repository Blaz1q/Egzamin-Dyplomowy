using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Runtime.CompilerServices;

namespace egzamin_dyplomowy
{
    public class API
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public JObject Data { get; set; } // Generic to handle different shapes of data
        public bool hasData = false;
        public static JObject deserialize(String json) {
            return JObject.Parse(json);
        }
        public bool Has(string key) {
            if (this.Data == null) return false;
            return this.Data.ContainsKey(key);
        }
        public API(string json) {
            if (json.Equals("")) return;
            var jsonObject = deserialize(json);
            if (jsonObject == null) return;
            this.Success = jsonObject["success"].ToObject<bool>();
            this.Message = jsonObject["message"].ToObject<string>();
            if (jsonObject.ContainsKey("data"))
            {
                this.Data = jsonObject["data"].ToObject<JObject>();
                this.hasData = true;
            }
        }
    }
}
