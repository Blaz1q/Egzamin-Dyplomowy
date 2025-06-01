using System;
using System.Windows.Forms;
namespace egzamin_dyplomowy
{
    partial class EditWykladowcaForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label labelImie;
        private Label labelNazwisko;
        private Label labelStatus;

        private TextBox txtImie;
        private TextBox txtNazwisko;
        private TextBox txtStatus;

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
            this.labelStatus = new Label();

            this.txtImie = new TextBox();
            this.txtNazwisko = new TextBox();
            this.txtStatus = new TextBox();

            this.btnOK = new Button();
            this.btnCancel = new Button();

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
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(12, 85);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(42, 15);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(100, 82);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(200, 23);
            this.txtStatus.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(100, 120);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(225, 120);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Anuluj";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // EditWykladowcaForm
            // 
            this.ClientSize = new System.Drawing.Size(320, 160);
            this.Controls.Add(this.labelImie);
            this.Controls.Add(this.txtImie);
            this.Controls.Add(this.labelNazwisko);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EditWykladowcaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edytuj wykładowcę";

            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
