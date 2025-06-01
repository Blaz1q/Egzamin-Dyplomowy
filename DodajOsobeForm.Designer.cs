using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    partial class DodajOsobeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtId = new TextBox();
            this.txtImie = new TextBox();
            this.txtNazwisko = new TextBox();
            this.txtSrednia = new TextBox();
            this.txtKierunek = new TextBox();
            this.txtStatus = new TextBox();
            this.checkKola = new CheckBox();
            this.comboBoxType = new ComboBox();
            this.btnSave = new Button();
            this.labelId = new Label();
            this.labelImie = new Label();
            this.labelNazwisko = new Label();
            this.labelSrednia = new Label();
            this.labelKierunek = new Label();
            this.labelStatus = new Label();
            this.labelKola = new Label();
            this.SuspendLayout();


            this.SuspendLayout();

            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new Point(20, 20);
            this.labelId.Name = "labelId";
            this.labelId.Size = new Size(20, 13);
            this.labelId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Location = new Point(120, 17);
            this.txtId.Name = "txtId";
            this.txtId.Size = new Size(150, 20);
            // 
            // labelImie
            // 
            this.labelImie.AutoSize = true;
            this.labelImie.Location = new Point(20, 50);
            this.labelImie.Name = "labelImie";
            this.labelImie.Size = new Size(30, 13);
            this.labelImie.Text = "Imię:";
            // 
            // txtImie
            // 
            this.txtImie.Location = new Point(120, 47);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new Size(150, 20);
            // 
            // labelNazwisko
            // 
            this.labelNazwisko.AutoSize = true;
            this.labelNazwisko.Location = new Point(20, 80);
            this.labelNazwisko.Name = "labelNazwisko";
            this.labelNazwisko.Size = new Size(55, 13);
            this.labelNazwisko.Text = "Nazwisko:";
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new Point(120, 77);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new Size(150, 20);
            // 
            // labelSrednia
            // 
            this.labelSrednia.AutoSize = true;
            this.labelSrednia.Location = new Point(20, 110);
            this.labelSrednia.Name = "labelSrednia";
            this.labelSrednia.Size = new Size(45, 13);
            this.labelSrednia.Text = "Średnia:";
            // 
            // txtSrednia
            // 
            this.txtSrednia.Location = new Point(120, 107);
            this.txtSrednia.Name = "txtSrednia";
            this.txtSrednia.Size = new Size(150, 20);
            // 
            // labelKierunek
            // 
            this.labelKierunek.AutoSize = true;
            this.labelKierunek.Location = new Point(20, 140);
            this.labelKierunek.Name = "labelKierunek";
            this.labelKierunek.Size = new Size(53, 13);
            this.labelKierunek.Text = "Kierunek:";
            // 
            // txtKierunek
            // 
            this.txtKierunek.Location = new Point(120, 137);
            this.txtKierunek.Name = "txtKierunek";
            this.txtKierunek.Size = new Size(150, 20);
            // 
            // labelKola
            // 
            this.labelKola.AutoSize = true;
            this.labelKola.Location = new Point(20, 170);
            this.labelKola.Name = "labelKola";
            this.labelKola.Size = new Size(75, 13);
            this.labelKola.Text = "Koła naukowe:";
            // 
            // checkKola
            // 
            this.checkKola.Location = new Point(120, 165);
            this.checkKola.Name = "checkKola";
            this.checkKola.Size = new Size(15, 14);
            this.checkKola.Text = "";
            this.checkKola.UseVisualStyleBackColor = true;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new Point(20, 200);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new Size(40, 13);
            this.labelStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new Point(120, 197);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new Size(150, 20);
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBoxType.Location = new Point(20, 230);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new Size(250, 21);
            // 
            // btnSave
            // 
            this.btnSave.Location = new Point(20, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new Size(250, 30);
            this.btnSave.Text = "Zapisz";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new EventHandler(this.btnSave_Click);
            // 
            // AddUserForm
            // 
            this.ClientSize = new Size(300, 320);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.labelSrednia);
            this.Controls.Add(this.txtSrednia);
            this.Controls.Add(this.labelKierunek);
            this.Controls.Add(this.txtKierunek);
            this.Controls.Add(this.labelKola);
            this.Controls.Add(this.checkKola);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.Name = "DodajOsobeForm";
            this.Text = "Dodaj nowego użytkownika";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private TextBox txtId;
        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtSrednia;
        private TextBox txtKierunek;
        private TextBox txtStatus;
        private CheckBox checkKola;
        private ComboBox comboBoxType;
        private Button btnSave;
        private Label labelId;
        private Label labelImie;
        private Label labelNazwisko;
        private Label labelSrednia;
        private Label labelKierunek;
        private Label labelStatus;
        private Label labelKola;

        #endregion
    }
}