using System;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class EditWykladowcaForm : Form
    {
        private ZarzadzanieWykladowcami _wykladowcaManager;
        private int _index;
        private Wykladowca _wykladowca;

        public EditWykladowcaForm(ZarzadzanieWykladowcami manager, int index)
        {
            InitializeComponent();
            _wykladowcaManager = manager;
            _index = index;

            var list = _wykladowcaManager.getLista();
            if (index >= 0 && index < list.Count)
            {
                _wykladowca = list[index];
                LoadWykladowcaData();
            }
            else
            {
                MessageBox.Show("Nieprawidłowy Index Wykładowcy.");
                Close();
            }
        }

        private void LoadWykladowcaData()
        {
            txtImie.Text = _wykladowca.GetImie();
            txtNazwisko.Text = _wykladowca.GetNazwisko();
            txtStatus.Text = _wykladowca.Status;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _wykladowcaManager.EdytujWykladowce(_index, txtImie.Text, txtNazwisko.Text);
            _wykladowcaManager.EdytujStatus(_index, txtStatus.Text);

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
