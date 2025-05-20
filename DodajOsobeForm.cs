using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace egzamin_dyplomowy
{
    internal partial class DodajOsobeForm : Form
    {
        private ZarzadzanieStudent _studenci;
        private ZarzadzanieWykladowcami _wykladowcy;

        //
        // Dodawanie osób (na razie ręczne id, bo i tak jest narazie nie podpięte do bazy)
        //
        public DodajOsobeForm(ZarzadzanieStudent studenci, ZarzadzanieWykladowcami wykladowcy)
        {
            InitializeComponent();
            _studenci = studenci;
            _wykladowcy = wykladowcy;

            comboBoxType.Items.Add("Student");
            comboBoxType.Items.Add("Wykładowca");
            comboBoxType.SelectedIndex = 0;

            comboBoxType.SelectedIndexChanged += ComboBoxType_SelectedIndexChanged;
            UpdateVisibility();
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateVisibility();
        }

        private void UpdateVisibility()
        {
            bool isStudent = comboBoxType.SelectedItem.ToString() == "Student";
            txtSrednia.Visible = labelSrednia.Visible = isStudent;
            txtKierunek.Visible = labelKierunek.Visible = isStudent;
            checkKola.Visible = labelKola.Visible = isStudent;
            txtStatus.Visible = labelStatus.Visible = !isStudent;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedItem.ToString() == "Student")
                {
                    _studenci.DodajStudent(
                        int.Parse(txtId.Text),
                        txtImie.Text,
                        txtNazwisko.Text,
                        double.Parse(txtSrednia.Text),
                        checkKola.Checked,
                        int.Parse(txtKierunek.Text)
                    );
                }
                else
                {
                    _wykladowcy.DodajWykladowce(
                        int.Parse(txtId.Text),
                        txtImie.Text,
                        txtNazwisko.Text,
                        txtStatus.Text
                    );
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Błąd danych: " + ex.Message);
            }
        }
    }
}
