using System;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class EditStudentForm : Form
    {
        private ZarzadzanieStudent _studentManager;
        private int _index;
        private Student _student;

        public EditStudentForm(ZarzadzanieStudent studentManager, int index)
        {
            InitializeComponent();
            _studentManager = studentManager;
            _index = index;

            var studenci = _studentManager.getLista();
            if (index >= 0 && index < studenci.Count)
            {
                _student = studenci[index];
                LoadStudentData();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy Index Studenta.");
                Close();
            }
        }

        private void LoadStudentData()
        {
            txtImie.Text = _student.imie;
            txtNazwisko.Text = _student.nazwisko;
            if (_student.getSrednia() < 2) {
                _student.setSrednia(2);
            }
            numSrednia.Value = (decimal)_student.getSrednia();
            chkKolaNaukowe.Checked = _student.kola_naukowe;
            numKierunek.Value = _student.kierunek;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Edycja danych studenta
            _studentManager.EdytujStudent(_index, txtImie.Text, txtNazwisko.Text);
            _studentManager.EdytujKolaNaukowe(_index, chkKolaNaukowe.Checked);
            _studentManager.EdytujKierunek(_index, (int)numKierunek.Value);

      
            _student.setSrednia((double)numSrednia.Value); 

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
