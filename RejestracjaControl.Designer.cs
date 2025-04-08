
using System;
using System.Drawing;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    partial class RejestracjaControl
    {
        private System.ComponentModel.IContainer components = null;

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
           
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RejestracjaControl));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonreg = new Button();
            pictureBox1 = new PictureBox();
            pbHasloError = new Panel();
            hasloerr = new PictureBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textnazwisko = new TextBox();
            textimie = new TextBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            panel6 = new Panel();
            panel5 = new Panel();
            buttonclear = new Button();
            oko2 = new PictureBox();
            oko = new PictureBox();
            textpowtorz = new TextBox();
            texthaslo = new TextBox();
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            textrejestracja = new TextBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonexit = new Button();
            label5 = new Label();
            label4 = new Label();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pbHasloError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hasloerr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oko2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oko).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            this.texthaslo.TextChanged += new System.EventHandler(this.texthaslo_TextChanged);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(169, 415);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 19;
            label1.Text = "E-mail";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(169, 495);
            label2.Name = "label2";
            label2.Size = new Size(66, 30);
            label2.TabIndex = 16;
            label2.Text = "Hasło";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(169, 575);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 15;
            label3.Text = "Powtórz Hasło";
            // 
            // buttonreg
            // 
            buttonreg.Location = new Point(437, 714);
            buttonreg.Name = "buttonreg";
            buttonreg.Size = new Size(191, 92);
            buttonreg.TabIndex = 14;
            buttonreg.Text = "Zarejestruj";
            buttonreg.Click += buttonreg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 264);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // pbHasloError
            // 
            pbHasloError.BorderStyle = BorderStyle.FixedSingle;
            pbHasloError.Controls.Add(hasloerr);
            pbHasloError.Controls.Add(label9);
            pbHasloError.Controls.Add(label8);
            pbHasloError.Controls.Add(label7);
            pbHasloError.Controls.Add(label6);
            pbHasloError.Controls.Add(textnazwisko);
            pbHasloError.Controls.Add(textimie);
            pbHasloError.Controls.Add(pictureBox6);
            pbHasloError.Controls.Add(pictureBox5);
            pbHasloError.Controls.Add(panel6);
            pbHasloError.Controls.Add(panel5);
            pbHasloError.Controls.Add(buttonclear);
            pbHasloError.Controls.Add(oko2);
            pbHasloError.Controls.Add(oko);
            pbHasloError.Controls.Add(textpowtorz);
            pbHasloError.Controls.Add(texthaslo);
            pbHasloError.Controls.Add(panel4);
            pbHasloError.Controls.Add(panel3);
            pbHasloError.Controls.Add(panel2);
            pbHasloError.Controls.Add(textrejestracja);
            pbHasloError.Controls.Add(pictureBox4);
            pbHasloError.Controls.Add(pictureBox3);
            pbHasloError.Controls.Add(pictureBox2);
            pbHasloError.Controls.Add(pictureBox1);
            pbHasloError.Controls.Add(buttonexit);
            pbHasloError.Controls.Add(buttonreg);
            pbHasloError.Controls.Add(label3);
            pbHasloError.Controls.Add(label2);
            pbHasloError.Controls.Add(label5);
            pbHasloError.Controls.Add(label4);
            pbHasloError.Controls.Add(label1);
            pbHasloError.Location = new Point(0, 0);
            pbHasloError.Name = "pbHasloError";
            pbHasloError.Size = new Size(807, 860);
            pbHasloError.TabIndex = 0;
            pbHasloError.Paint += panel1_Paint;
            // 
            // hasloerr
            // 
            hasloerr.Image = Rejestracja.Properties.Resources.orange_error_icon_0;
            hasloerr.Location = new Point(672, 504);
            hasloerr.Name = "hasloerr";
            hasloerr.Size = new Size(31, 21);
            hasloerr.SizeMode = PictureBoxSizeMode.Zoom;
            hasloerr.TabIndex = 27;
            hasloerr.TabStop = false;
            hasloerr.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 8.25F);
            label9.Location = new Point(316, 380);
            label9.Name = "label9";
            label9.Size = new Size(241, 13);
            label9.TabIndex = 26;
            label9.Text = "Nazwisko powinno być zapisane z dużej litery";
            label9.Click += label8_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F);
            label8.Location = new Point(316, 307);
            label8.Name = "label8";
            label8.Size = new Size(213, 13);
            label8.TabIndex = 26;
            label8.Text = "Imię powinno być zapisane z dużej litery";
            label8.Click += label8_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15.75F);
            label7.Location = new Point(169, 343);
            label7.Name = "label7";
            label7.Size = new Size(101, 30);
            label7.TabIndex = 25;
            label7.Text = "Nazwisko";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F);
            label6.Location = new Point(169, 262);
            label6.Name = "label6";
            label6.Size = new Size(135, 30);
            label6.TabIndex = 24;
            label6.Text = "Imię (Imiona)";
            label6.Click += label6_Click;
            // 
            // textnazwisko
            // 
            textnazwisko.Location = new Point(316, 343);
            textnazwisko.Name = "textnazwisko";
            textnazwisko.Size = new Size(333, 23);
            textnazwisko.TabIndex = 23;
            // 
            // textimie
            // 
            textimie.Location = new Point(316, 271);
            textimie.Name = "textimie";
            textimie.Size = new Size(333, 23);
            textimie.TabIndex = 22;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Rejestracja.Properties.Resources._8056414;
            pictureBox6.Location = new Point(125, 415);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(38, 30);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Rejestracja.Properties.Resources._1828439;
            pictureBox5.Location = new Point(125, 343);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(38, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.DodgerBlue;
            panel6.Location = new Point(125, 323);
            panel6.Name = "panel6";
            panel6.Size = new Size(524, 1);
            panel6.TabIndex = 8;
            // 
            // panel5
            // 
            panel5.BackColor = Color.DodgerBlue;
            panel5.Location = new Point(125, 396);
            panel5.Name = "panel5";
            panel5.Size = new Size(524, 1);
            panel5.TabIndex = 8;
            // 
            // buttonclear
            // 
            buttonclear.Location = new Point(327, 640);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(133, 23);
            buttonclear.TabIndex = 0;
            buttonclear.Text = "Wyczyść wszystko";
            buttonclear.Click += buttonclear_Click;
            // 
            // oko2
            // 
            oko2.Image = (Image)resources.GetObject("oko2.Image");
            oko2.Location = new Point(618, 584);
            oko2.Name = "oko2";
            oko2.Size = new Size(31, 21);
            oko2.SizeMode = PictureBoxSizeMode.Zoom;
            oko2.TabIndex = 1;
            oko2.TabStop = false;
            oko2.Click += oko2_Click;
            // 
            // oko
            // 
            oko.Image = (Image)resources.GetObject("oko.Image");
            oko.Location = new Point(618, 504);
            oko.Name = "oko";
            oko.Size = new Size(31, 21);
            oko.SizeMode = PictureBoxSizeMode.Zoom;
            oko.TabIndex = 2;
            oko.TabStop = false;
            oko.Click += oko_Click;
            // 
            // textpowtorz
            // 
            textpowtorz.Location = new Point(316, 582);
            textpowtorz.Name = "textpowtorz";
            textpowtorz.Size = new Size(281, 23);
            textpowtorz.TabIndex = 3;
            textpowtorz.UseSystemPasswordChar = true;
            // 
            // texthaslo
            // 
            texthaslo.Location = new Point(316, 504);
            texthaslo.Name = "texthaslo";
            texthaslo.Size = new Size(281, 23);
            texthaslo.TabIndex = 4;
            texthaslo.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Location = new Point(125, 633);
            panel4.Name = "panel4";
            panel4.Size = new Size(524, 1);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Location = new Point(125, 552);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 1);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Location = new Point(125, 468);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 1);
            panel2.TabIndex = 7;
            // 
            // textrejestracja
            // 
            textrejestracja.Location = new Point(316, 422);
            textrejestracja.Name = "textrejestracja";
            textrejestracja.Size = new Size(333, 23);
            textrejestracja.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(284, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(184, 180);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(125, 575);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(125, 495);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // buttonexit
            // 
            buttonexit.Location = new Point(169, 714);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(182, 92);
            buttonexit.TabIndex = 13;
            buttonexit.Text = "Wyjście";
            buttonexit.Click += buttonexit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F);
            label5.Location = new Point(125, 536);
            label5.Name = "label5";
            label5.Size = new Size(306, 13);
            label5.TabIndex = 17;
            label5.Text = "Hasło musi zawierać 8 znaków, jedną dużą literę oraz cyfrę";
            label5.Click += label1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 27.75F);
            label4.Location = new Point(284, 186);
            label4.Name = "label4";
            label4.Size = new Size(210, 42);
            label4.TabIndex = 18;
            label4.Text = "Rejestracja";
            label4.Click += label1_Click_1;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup_1;
            // 
            // RejestracjaControl
            // 
            Controls.Add(pbHasloError);
            Name = "RejestracjaControl";
            Size = new Size(807, 860);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pbHasloError.ResumeLayout(false);
            pbHasloError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hasloerr).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)oko2).EndInit();
            ((System.ComponentModel.ISupportInitialize)oko).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);

        }

        private Label label1, label2, label3, label4, label5;
        private Button buttonreg, buttonexit, buttonclear;
        private PictureBox pictureBox1, pictureBox2, pictureBox3, pictureBox4, oko, oko2;
        private Panel pbHasloError, panel2, panel3, panel4;
        private TextBox textrejestracja, texthaslo, textpowtorz;
        private Panel panel6;
        private Panel panel5;
        private PictureBox pictureBox5;
        private Label label6;
        private TextBox textnazwisko;
        private TextBox textimie;
        private PictureBox pictureBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private PictureBox hasloerr;
        private ToolTip toolTip1;
    }

}

