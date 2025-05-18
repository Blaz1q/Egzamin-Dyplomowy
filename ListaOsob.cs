using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class ListaOsob : Form
    {
        private ZarzadzanieStudent studentManager = new ZarzadzanieStudent();
        private ZarzadzanieWykladowcami wykladowcaManager = new ZarzadzanieWykladowcami();
        private List<Osoba> wszyscy = new List<Osoba>();

        public enum FilterType
        {
            All,
            Students,
            Lecturers
        }
        private void BtnWszyscy_Click(object sender, EventArgs e)
        {
            RefreshList(FilterType.All);
        }

        private void BtnStudenci_Click(object sender, EventArgs e)
        {
            RefreshList(FilterType.Students);
        }

        private void BtnWykladowcy_Click(object sender, EventArgs e)
        {
            RefreshList(FilterType.Lecturers);
        }

        public ListaOsob()
        {
            InitializeComponent();
            LoadData();
            CreateFilterButtons();
        }

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

        public void RefreshList(FilterType filter)
        {
            flowLayoutPanel1.Controls.Clear();

            if (filter == FilterType.All || filter == FilterType.Students)
            {
                List<Student> students = studentManager.getLista();
                for (int i = 0; i < students.Count; i++)
                {
                    var student = students[i];
                    var control = new WyswietlOsoby(student, i, studentManager, this);
                    flowLayoutPanel1.Controls.Add(control);
                }
            }

            if (filter == FilterType.All || filter == FilterType.Lecturers)
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

        private void CreateFilterButtons()
        {
            Button btnAll = new Button() { Text = "Wszyscy", Location = new Point(10, 10) };
            Button btnStudents = new Button() { Text = "Studenci", Location = new Point(100, 10) };
            Button btnLecturers = new Button() { Text = "Wykładowcy", Location = new Point(200, 10) };

            btnAll.Click += (s, e) => RefreshList(FilterType.All);
            btnStudents.Click += (s, e) => RefreshList(FilterType.Students);
            btnLecturers.Click += (s, e) => RefreshList(FilterType.Lecturers);

            this.Controls.Add(btnAll);
            this.Controls.Add(btnStudents);
            this.Controls.Add(btnLecturers);
        }
    }
}