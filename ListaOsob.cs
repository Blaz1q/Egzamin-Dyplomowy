using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    //DodajOsobeForm.cs
    //EditStudentForm.cs
    //EditWykladowcaForm.cs
    //WyswietlOsoby.cs
    public partial class ListaOsob : UserControl
    {
        private ZarzadzanieStudent studentManager = Dane.Studenci;
        private ZarzadzanieWykladowcami wykladowcaManager = Dane.Wykladowcy;
        private List<Osoba> wszyscy = new List<Osoba>();
        
        //
        //Filtrowanie
        //
        public enum FilterType
        {
            All,
            studenci,
            wykladowcy
        }
        private void BtnWszyscy_Click(object sender, EventArgs e)
        {
            RefreshList(FilterType.All);
        }

        private void BtnStudenci_Click(object sender, EventArgs e)
        {
            RefreshList(FilterType.studenci);
        }

        private void BtnWykladowcy_Click(object sender, EventArgs e)
        {
            RefreshList(FilterType.wykladowcy);
        }

        public ListaOsob()
        {
            InitializeComponent();
            LoadData();
            CreateFilterButtons();
        }
        // Na razie lokalnie, z przykładową bazą osób
        private void LoadData()
        {
            studentManager.DodajStudent(1, "Anna", "Nowak", 4.2, true, 1);
            studentManager.DodajStudent(2, "Jan", "Kowalski", 3.5, false, 2);
            wykladowcaManager.DodajWykladowce(1, "Marek", "Nowicki", "Profesor");
            wykladowcaManager.DodajWykladowce(2, "Agnieszka", "Zielińska", "Adiunkt");

            wszyscy.Clear();
            wszyscy.AddRange(studentManager.getLista());
            wszyscy.AddRange(wykladowcaManager.getLista());

            RefreshList(FilterType.All);
        }

        //
        // Odświerza liste gdy wybrany jest filtr
        //
        public void RefreshList(FilterType filter)
        {
            flowLayoutPanel1.Controls.Clear();

            if (filter == FilterType.All || filter == FilterType.studenci)
            {
                List<Student> studenci = studentManager.getLista();
                for (int i = 0; i < studenci.Count; i++)
                {
                    var student = studenci[i];
                    var control = new WyswietlOsoby(student, i, studentManager, this);
                    flowLayoutPanel1.Controls.Add(control);
                }
            }

            if (filter == FilterType.All || filter == FilterType.wykladowcy)
            {
                List<Wykladowca> wykladowcy = wykladowcaManager.getLista();
                for (int i = 0; i < wykladowcy.Count; i++)
                {
                    var wykladowca = wykladowcy[i];
                    var control = new WyswietlOsoby(wykladowca, i, wykladowcaManager, this);
                    flowLayoutPanel1.Controls.Add(control);
                }
            }
        }
        
        //
        // Funkcjonalność przycisków filtru
        //
        private void CreateFilterButtons()
        {
        
            Button btnAll = new Button();
            Button btnstudenci = new Button();
            Button btnwykladowcy = new Button();

            btnAll.Click += (s, e) => RefreshList(FilterType.All);
            btnstudenci.Click += (s, e) => RefreshList(FilterType.studenci);
            btnwykladowcy.Click += (s, e) => RefreshList(FilterType.wykladowcy);

        }

        //
        // Funkcjonalność przycisku dodawania
        //
        private void btnDodajOsobe_Click(object sender, EventArgs e)
        {
            using (var form = new DodajOsobeForm(studentManager, wykladowcaManager))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    RefreshList(FilterType.All);
                }
            }
        }

    }
}