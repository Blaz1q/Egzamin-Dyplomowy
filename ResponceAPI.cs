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
        public static void SetData(string json) { 

            /*
            ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠟⠛⢉⣉⣡⣌⡉⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
            ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⢉⣡⣤⣴⣶⣾⣿⣿⣿⣿⣿⣿⣷⣦⣄⡉⠙⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
            ⣿⣿⣿⣿⣿⣿⣿⠿⠛⢉⣁⣤⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⠈⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿
            ⣿⣿⣿⣿⠟⠋⣀⣴⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡈⠙⢿⣿⣿⣿⣿⣿⣿
            ⣿⠛⢁⣤⣶⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⡀⠻⣿⣿⣿⣿⣿
            ⣿⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣿⣿⣿⢿⣿⣿⣿⣿⣿⣿⣿⡄⠙⢿⣿⣿⣿
            ⡟⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⢻⣿⣿⠀⢸⣿⡿⠁⠀⢸⣿⣿⠀⣹⣿⡿⠀⣿⣿⣿⣿⣿⣿⣿⣿⣦⠈⠻⣿⣿
            ⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⠀⠀⢻⠇⢠⣿⠟⢀⣴⠀⢸⣿⠃⠀⠋⠉⠁⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⡀⠹⣿
            ⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⡟⠀⣶⡀⠀⢀⡿⠋⠀⠈⠁⠀⢸⠇⢀⣤⣶⠂⢀⣿⣿⠟⠛⣿⣿⣿⣿⣿⣿⣿⣿⡄⢸
            ⡇⢸⣿⣿⣿⣿⣿⣿⣿⣿⠀⣼⣿⣷⠀⣼⠁⣰⣾⣿⣇⠀⠈⠀⣾⣿⡇⠀⣿⡿⠋⢠⣾⣿⣿⣿⣿⣿⣿⣿⣿⡇⢸
            ⠃⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣿⣿⣿⣿⣷⣷⣾⣿⣿⣿⣿⣷⣦⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⢸
            ⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠿⠿⠿⣿⠟⠛⢻⣿⠛⢿⣿⡿⠛⢺⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⢸
            ⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣤⡄⢀⣴⣶⠋⢀⣴⡿⠁⠀⣾⡟⠁⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⣾
            ⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠀⣼⣿⣿⣶⣿⡿⠀⡀⠀⠋⢀⠀⢰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⣿
            ⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⠃⠐⠛⢻⣿⣿⡟⠁⣼⡇⠀⣴⡏⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⣿
            ⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣤⣤⣤⣤⣶⣾⣿⣿⣇⣼⣿⣷⣾⣿⣧⣤⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⣿
            ⠀⣿⣿⣿⣿⣿⣿⣿⡿⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⣿⣿⣿⣿⣿⠀⣿
            ⠀⣿⣿⣿⡿⠟⠉⣁⣀⣠⣼⣿⠁⣸⣿⡿⠋⠉⣀⣀⡀⠟⣿⣿⠏⠀⣹⣿⠏⠀⣸⣿⣿⠟⠀⠀⢸⣿⣿⣿⣿⠀⣿
            ⠀⣿⣿⠋⠀⠐⠛⠛⠛⠉⣿⠇⢰⡿⠃⢠⡶⠛⠉⠁⠀⢀⣿⠋⠀⠀⡿⠃⠀⢀⣿⡿⠋⢀⡆⠀⢸⣿⣿⣿⣿⠀⣿
            ⠀⣿⣿⣶⣶⣶⠶⠂⢀⣼⡟⢀⡿⠀⢰⣿⣦⣴⠞⠋⣠⣾⠏⢠⡆⠀⢀⡴⠀⢸⡟⠁⠀⠉⡀⠀⣼⣿⠿⢿⣿⠀⣿
            ⠀⣿⣿⠈⠀⣀⣤⣶⣿⣿⠀⣼⣷⡀⠀⠉⠀⣀⣤⣾⣿⡏⢠⣿⣧⣤⣿⣇⠀⠜⠀⣴⣿⣿⡇⢀⣿⡁⣠⣾⡟⠀⣿
            ⡄⢸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣿⣿⣿⣿⣿⣿⣿⣿⠋⢀⣾⣿
            ⣷⡀⠙⢿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠁⣰⣿⣿⣿
            ⣿⣿⣷⣤⣈⠙⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠟⢀⣾⣿⣿⣿⣿
            ⣿⣿⣿⣿⣿⣿⣷⣦⣄⡉⠛⠿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠋⣠⣿⣿⣿⣿⣿⣿
            ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⣤⣈⡙⠻⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠿⠟⠛⢁⣴⣿⣿⣿⣿⣿⣿⣿
            ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡏⢰⣿⣿⣿⣿⡿⠛⠛⠛⠛⠛⠛⣉⣀⣤⣤⣶⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
            ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠁⣾⣿⣿⡿⠋⣠⣴⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
            ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠇⢰⣿⡿⠋⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
            ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠛⢁⣤⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿
            */
        }
        public void SetDane() {  
            if (this.Has("Studenci"))
            {
                JArray Studenci = this.Data["Studenci"].ToObject<JArray>();
                foreach (var item in Studenci) {
                    int id = item["id"].ToObject<int>();
                    string imie = item["imie"].ToString();
                    string nazwisko = item["nazwisko"].ToString();
                    Dane.Studenci.DodajStudent(id,imie,nazwisko,0,false,0);
                }
            }
            if (this.Has("Wykladowcy")) { 
                JArray Wykladowcy = this.Data["Wykladowcy"].ToObject<JArray>();
                foreach (var item in Wykladowcy) {
                    int id = item["id"].ToObject<int>();
                    string imie = item["imie"].ToString();
                    string nazwisko = item["nazwisko"].ToString();
                    Dane.Wykladowcy.DodajWykladowce(id, imie, nazwisko, "skibidi");
                }
            }
            if (this.Has("Pytania") && this.Has("LaczeniaPytan")) { 
                JArray Pytania = this.Data["Pytania"].ToObject<JArray>();
                JArray LaczeniaPytan = this.Data["LaczeniaPytan"].ToObject<JArray>();
                foreach (var item in Pytania)
                {
                    int id = item["id"].ToObject<int>();
                    string tresc = item["tresc_pytania"].ToString();
                    string nazwa_specjalnosci = item["nazwa_specjalnosci"].ToString();
                    string nazwa_kierunku = item["nazwa_kierunku"].ToString();
                    string stopien = item["stopien"].ToString();
                    Dane.Pytania.DodajPytanie(tresc, nazwa_kierunku, new List<Wykladowca>(), nazwa_specjalnosci, stopien);
                    //   Dane.Wykladowcy.DodajWykladowce(id, imie, nazwisko, "skibidi");
                }
                
                foreach (var item in LaczeniaPytan) {
                    int id_pytania = item["id_pytania"].ToObject<int>();
                    int id_wykladowcy = item["id_osoby"].ToObject<int>();
                    Dane.Pytania.DodajWykladowce(id_pytania, Dane.Wykladowcy.GetWykladowca(id_wykladowcy));
                }
            }
        }
    }
}
