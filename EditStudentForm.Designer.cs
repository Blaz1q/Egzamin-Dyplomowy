using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    partial class EditStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelImie;
        private Label labelNazwisko;
        private Label labelSrednia;
        private Label labelKolaNaukowe;
        private Label labelKierunek;

        private TextBox txtImie;
        private TextBox txtNazwisko;
        private NumericUpDown numSrednia;
        private CheckBox chkKolaNaukowe;
        private NumericUpDown numKierunek;

        private Button btnOK;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelImie = new Label();
            this.labelNazwisko = new Label();
            this.labelSrednia = new Label();
            this.labelKolaNaukowe = new Label();
            this.labelKierunek = new Label();

            this.txtImie = new TextBox();
            this.txtNazwisko = new TextBox();
            this.numSrednia = new NumericUpDown();
            this.chkKolaNaukowe = new CheckBox();
            this.numKierunek = new NumericUpDown();

            this.btnOK = new Button();
            this.btnCancel = new Button();

            ((System.ComponentModel.ISupportInitialize)(this.numSrednia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKierunek)).BeginInit();
            this.SuspendLayout();

            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new System.Drawing.Point(12, 15);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new System.Drawing.Size(32, 15);
            this.labelImie.TabIndex = 0;
            this.labelImie.Text = "Imię:";
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(100, 12);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(200, 23);
            this.txtImie.TabIndex = 1;
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new System.Drawing.Point(12, 50);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new System.Drawing.Size(61, 15);
            this.labelNazwisko.TabIndex = 2;
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(100, 47);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(200, 23);
            this.txtNazwisko.TabIndex = 3;
            // 
            // labelSrednia
            // 
            this.labelSrednia.AutoSize = true;
            this.labelSrednia.Location = new System.Drawing.Point(12, 85);
            this.labelSrednia.Name = "labelSrednia";
            this.labelSrednia.Size = new System.Drawing.Size(48, 15);
            this.labelSrednia.TabIndex = 4;
            this.labelSrednia.Text = "Średnia:";
            // 
            // numSrednia
            // 
            this.numSrednia.DecimalPlaces = 2;
            this.numSrednia.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            this.numSrednia.Location = new System.Drawing.Point(100, 83);
            this.numSrednia.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.numSrednia.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            this.numSrednia.Name = "numSrednia";
            this.numSrednia.Size = new System.Drawing.Size(60, 23);
            this.numSrednia.TabIndex = 5;
            this.numSrednia.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // labelKolaNaukowe
            // 
            this.labelKolaNaukowe.AutoSize = true;
            this.labelKolaNaukowe.Location = new System.Drawing.Point(12, 120);
            this.labelKolaNaukowe.Name = "labelKolaNaukowe";
            this.labelKolaNaukowe.Size = new System.Drawing.Size(84, 15);
            this.labelKolaNaukowe.TabIndex = 6;
            this.labelKolaNaukowe.Text = "Koła naukowe:";
            // 
            // chkKolaNaukowe
            // 
            this.chkKolaNaukowe.AutoSize = true;
            this.chkKolaNaukowe.Location = new System.Drawing.Point(100, 119);
            this.chkKolaNaukowe.Name = "chkKolaNaukowe";
            this.chkKolaNaukowe.Size = new System.Drawing.Size(15, 14);
            this.chkKolaNaukowe.TabIndex = 7;
            this.chkKolaNaukowe.UseVisualStyleBackColor = true;
            // 
            // labelKierunek
            // 
            this.labelKierunek.AutoSize = true;
            this.labelKierunek.Location = new System.Drawing.Point(12, 150);
            this.labelKierunek.Name = "labelKierunek";
            this.labelKierunek.Size = new System.Drawing.Size(58, 15);
            this.labelKierunek.TabIndex = 8;
            this.labelKierunek.Text = "Kierunek:";
            // 
            // numKierunek
            // 
            this.numKierunek.Location = new System.Drawing.Point(100, 148);
            this.numKierunek.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            this.numKierunek.Minimum = new decimal(new int[] { 0, 0, 0, 0 });
            this.numKierunek.Name = "numKierunek";
            this.numKierunek.Size = new System.Drawing.Size(60, 23);
            this.numKierunek.TabIndex = 9;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(100, 190);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditStudentForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 230);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.labelSrednia);
            this.Controls.Add(this.numSrednia);
            this.Controls.Add(this.labelKolaNaukowe);
            this.Controls.Add(this.chkKolaNaukowe);
            this.Controls.Add(this.labelKierunek);
            this.Controls.Add(this.numKierunek);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name = "EditStudentForm";
            this.StartPosition = FormStartPosition.CenterParent;
            this.Text = "Edytuj studenta";

            ((System.ComponentModel.ISupportInitialize)(this.numSrednia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKierunek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
