namespace Rejestracja
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonreg = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
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
            buttonclear = new Button();
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
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(64, 253);
            label1.Name = "label1";
            label1.Size = new Size(71, 30);
            label1.TabIndex = 0;
            label1.Text = "E-mail";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(64, 333);
            label2.Name = "label2";
            label2.Size = new Size(66, 30);
            label2.TabIndex = 1;
            label2.Text = "Hasło";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(64, 413);
            label3.Name = "label3";
            label3.Size = new Size(146, 30);
            label3.TabIndex = 2;
            label3.Text = "Powtórz Hasło";
            // 
            // buttonreg
            // 
            buttonreg.Location = new Point(332, 552);
            buttonreg.Name = "buttonreg";
            buttonreg.Size = new Size(191, 92);
            buttonreg.TabIndex = 3;
            buttonreg.Text = "Zarejestruj";
            buttonreg.UseVisualStyleBackColor = true;
            buttonreg.Click += buttonreg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.my_account_login;
            pictureBox1.Location = new Point(20, 253);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
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
            panel1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            panel1.Location = new Point(413, 41);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 714);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // oko2
            // 
            oko2.Image = Properties.Resources.eye_61;
            oko2.Location = new Point(513, 422);
            oko2.Name = "oko2";
            oko2.Size = new Size(31, 21);
            oko2.SizeMode = PictureBoxSizeMode.Zoom;
            oko2.TabIndex = 12;
            oko2.TabStop = false;
            oko2.Click += oko2_Click;
            // 
            // oko
            // 
            oko.Image = Properties.Resources.eye_61;
            oko.Location = new Point(513, 342);
            oko.Name = "oko";
            oko.Size = new Size(31, 21);
            oko.SizeMode = PictureBoxSizeMode.Zoom;
            oko.TabIndex = 12;
            oko.TabStop = false;
            oko.Click += oko_Click;
            // 
            // textpowtorz
            // 
            textpowtorz.Location = new Point(211, 420);
            textpowtorz.Name = "textpowtorz";
            textpowtorz.Size = new Size(281, 23);
            textpowtorz.TabIndex = 10;
            textpowtorz.UseSystemPasswordChar = true;
            // 
            // texthaslo
            // 
            texthaslo.Location = new Point(211, 342);
            texthaslo.Name = "texthaslo";
            texthaslo.Size = new Size(281, 23);
            texthaslo.TabIndex = 9;
            texthaslo.UseSystemPasswordChar = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DodgerBlue;
            panel4.Location = new Point(20, 471);
            panel4.Name = "panel4";
            panel4.Size = new Size(524, 1);
            panel4.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.Location = new Point(20, 390);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 1);
            panel3.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DodgerBlue;
            panel2.Location = new Point(20, 306);
            panel2.Name = "panel2";
            panel2.Size = new Size(524, 1);
            panel2.TabIndex = 8;
            // 
            // textrejestracja
            // 
            textrejestracja.Location = new Point(211, 260);
            textrejestracja.Name = "textrejestracja";
            textrejestracja.Size = new Size(333, 23);
            textrejestracja.TabIndex = 7;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.umg_zolty;
            pictureBox4.Location = new Point(194, 6);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(184, 180);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.password_76;
            pictureBox3.Location = new Point(20, 413);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.password_76;
            pictureBox2.Location = new Point(20, 333);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // buttonexit
            // 
            buttonexit.Location = new Point(64, 552);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(182, 92);
            buttonexit.TabIndex = 3;
            buttonexit.Text = "Wyjście";
            buttonexit.UseVisualStyleBackColor = true;
            buttonexit.Click += buttonexit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(211, 374);
            label5.Name = "label5";
            label5.Size = new Size(312, 13);
            label5.TabIndex = 0;
            label5.Text = "Hasło musi zawierać 8 znaków, jedną dużą lietere oraz cyfrę";
            label5.Click += label1_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bauhaus 93", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(180, 189);
            label4.Name = "label4";
            label4.Size = new Size(210, 42);
            label4.TabIndex = 0;
            label4.Text = "Rejestracja";
            label4.Click += label1_Click_1;
            // 
            // buttonclear
            // 
            buttonclear.Location = new Point(222, 478);
            buttonclear.Name = "buttonclear";
            buttonclear.Size = new Size(133, 23);
            buttonclear.TabIndex = 13;
            buttonclear.Text = "Wyczyść wszystko";
            buttonclear.UseVisualStyleBackColor = true;
            buttonclear.Click += buttonclear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.logo_umg_granat_poziom;
            ClientSize = new Size(1538, 914);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Rejestracja";
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

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonreg;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Panel panel2;
        private TextBox textrejestracja;
        private Panel panel4;
        private Panel panel3;
        private TextBox textpowtorz;
        private TextBox texthaslo;
        private Label label4;
        private Button buttonexit;
        private PictureBox oko;
        private PictureBox oko2;
        private Label label5;
        private Button buttonclear;
    }
}
