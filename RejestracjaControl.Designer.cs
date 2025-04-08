
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonreg = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)oko2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)oko).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(64, 253);
            label1.Name = "label1";
            label1.Size = new Size(93, 37);
            label1.TabIndex = 19;
            label1.Text = "E-mail";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F);
            label2.Location = new Point(64, 333);
            label2.Name = "label2";
            label2.Size = new Size(84, 37);
            label2.TabIndex = 16;
            label2.Text = "Hasło";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F);
            label3.Location = new Point(64, 413);
            label3.Name = "label3";
            label3.Size = new Size(187, 37);
            label3.TabIndex = 15;
            label3.Text = "Powtórz Hasło";
            // 
            // buttonreg
            // 
            buttonreg.Location = new Point(332, 552);
            buttonreg.Name = "buttonreg";
            buttonreg.Size = new Size(191, 92);
            buttonreg.TabIndex = 14;
            buttonreg.Text = "Zarejestruj";
            buttonreg.Click += buttonreg_Click;
            // 
            // pictureBox1
            // 
            //pictureBox1.Image = Properties.Resources.my_account_login;
            //pictureBox1.InitialImage = Properties.Resources.my_account_login;
            pictureBox1.Location = new Point(20, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(buttonclear);
            panel1.Controls.Add(oko2);
            panel1.Controls.Add(oko);
            panel1.Controls.Add(textpowtorz);
            panel1.Controls.Add(texthaslo);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(textrejestracja);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(buttonexit);
            panel1.Controls.Add(buttonreg);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 714);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonclear
            // 
            buttonclear.Location = new Point(222, 478);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(133, 23);
            buttonclear.TabIndex = 0;
            buttonclear.Text = "Wyczyść wszystko";
            buttonclear.Click += buttonclear_Click;
            // 
            // oko2
            // 
            //oko2.Image = Properties.Resources.eye_61;
            oko2.Location = new Point(513, 422);
            oko2.Name = "oko2";
            oko2.Size = new Size(31, 21);
            oko2.SizeMode = PictureBoxSizeMode.Zoom;
            oko2.TabIndex = 1;
            oko2.TabStop = false;
            oko2.Click += oko2_Click;
            // 
            // oko
            // 
            //oko.Image = Properties.Resources.eye_61;
            oko.Location = new Point(513, 342);
            oko.Name = "oko";
            oko.Size = new Size(31, 21);
            oko.SizeMode = PictureBoxSizeMode.Zoom;
            oko.TabIndex = 2;
            oko.TabStop = false;
            oko.Click += oko_Click;
            // 
            // textpowtorz
            // 
            textpowtorz.Location = new Point(211, 420);
            textpowtorz.Name = "textpowtorz";
            textpowtorz.Size = new Size(281, 27);
            textpowtorz.TabIndex = 3;
            textpowtorz.UseSystemPasswordChar = true;
            // 
            // texthaslo
            // 
            texthaslo.Location = new Point(211, 342);
            texthaslo.Name = "texthaslo";
            texthaslo.Size = new Size(281, 27);
            texthaslo.TabIndex = 4;
            texthaslo.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Location = new Point(20, 471);
            panel4.Name = "panel4";
            panel4.Size = new Size(524, 1);
            panel4.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Location = new Point(20, 390);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 1);
            panel3.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Location = new Point(20, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 1);
            panel2.TabIndex = 7;
            // 
            // textrejestracja
            // 
            textrejestracja.Location = new Point(211, 260);
            textrejestracja.Name = "textrejestracja";
            textrejestracja.Size = new Size(333, 27);
            textrejestracja.TabIndex = 8;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            //pictureBox4.Image = Properties.Resources.umg_zolty;
            pictureBox4.Location = new Point(194, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(184, 180);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            //pictureBox3.Image = Properties.Resources.password_76;
            pictureBox3.Location = new Point(20, 413);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            //pictureBox2.Image = Properties.Resources.password_76;
            pictureBox2.Location = new Point(20, 333);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // buttonexit
            // 
            buttonexit.Location = new Point(64, 552);
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
            label5.Location = new Point(211, 374);
            label5.Name = "label5";
            label5.Size = new Size(364, 19);
            label5.TabIndex = 17;
            label5.Text = "Hasło musi zawierać 8 znaków, jedną dużą literę oraz cyfrę";
            label5.Click += label1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 27.75F);
            label4.Location = new Point(180, 189);
            label4.Name = "label4";
            label4.Size = new Size(258, 54);
            label4.TabIndex = 18;
            label4.Text = "Rejestracja";
            label4.Click += label1_Click_1;
            // 
            // RejestracjaControl
            // 
            Controls.Add(panel1);
            Name = "RejestracjaControl";
            Size = new Size(570, 714);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1, panel2, panel3, panel4;
        private TextBox textrejestracja, texthaslo, textpowtorz;
    }
}
