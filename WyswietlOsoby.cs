using System;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class WyswietlOsoby : UserControl
    {
        private Student _student;
        private Wykladowca _wykladowca;
        private ListaOsob _parentForm;
        private ZarzadzanieStudent _studentManager;
        private ZarzadzanieWykladowcami _wykladowcaManager;
        private int _index;

        // Constructor for Student
        public WyswietlOsoby(Student student, int index, ZarzadzanieStudent manager, ListaOsob parent)
        {
            InitializeComponent();
            _student = student;
            _index = index;
            _studentManager = manager;
            _parentForm = parent;
            nameLabel.Text = $"{student.imie} {student.nazwisko}";
            editButton.Click += BtnEdit_Click;
        }

        // Constructor for Wykladowca
        public WyswietlOsoby(Wykladowca wykladowca, int index, ZarzadzanieWykladowcami manager, ListaOsob parent)
        {
            InitializeComponent();
            _wykladowca = wykladowca;
            _index = index;
            _wykladowcaManager = manager;
            _parentForm = parent;
            nameLabel.Text = $"{wykladowca.Imie} {wykladowca.Nazwisko}";
            editButton.Click += BtnEdit_Click;
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (_student != null)
            {
                using (var editForm = new EditStudentForm(_studentManager, _index))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        _parentForm.RefreshList(ListaOsob.FilterType.Students);
                    }
                }
            }
            else if (_wykladowca != null)
            {
                using (var editForm = new EditWykladowcaForm(_wykladowcaManager, _index))
                {
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        _parentForm.RefreshList(ListaOsob.FilterType.Lecturers);
                    }
                }
            }
        }
    }
}
