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
    public partial class TestForm : Form
    {
        public TestForm()
        {
           // InitializeComponent();
            List<Wykladowca> wykladowcy = new List<Wykladowca>();
            wykladowcy.Add(new Wykladowca(0, "Imie", "Nazwisko", "status"));
            wykladowcy.Add(new Wykladowca(1, "naJ", "lewap", "ziwi"));
            wykladowcy.Add(new Wykladowca(2, "tomasz", "jaskółka", "ktsda"));
            wykladowcy.Add(new Wykladowca(2, "tomasz", "biedronka", "kasd"));
            wykladowcy.Add(new Wykladowca(3, "blalala", "pieer", "sadas"));
            wykladowcy.Add(new Wykladowca(4, "tymek", "dol", "Lorem"));
            wykladowcy.Add(new Wykladowca(5, "Ania", "erde", "Ipsum"));
           // var control = new edytuj_pytania(new Pytanie(1, "Lorem Ipsum", "Informatyka", wykladowcy, "kategoria?", "Inżynier"), wykladowcy);
            //control.Dock = DockStyle.Fill; // żeby ładnie się wpasował w cały formularz
           // this.Controls.Add(control);
        }
    }
}
