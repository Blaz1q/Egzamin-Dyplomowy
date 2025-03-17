namespace egzamin_dyplomowy
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
            JSON_label = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // JSON_label
            // 
            JSON_label.Location = new Point(8, 324);
            JSON_label.Multiline = true;
            JSON_label.Name = "JSON_label";
            JSON_label.Size = new Size(780, 101);
            JSON_label.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 32);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(33, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(33, 142);
            textBox2.Name = "textBox2";
            textBox2.ShortcutsEnabled = false;
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 119);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 4;
            label2.Text = "Hasło";
            // 
            // button1
            // 
            button1.Location = new Point(33, 196);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Zaloguj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(JSON_label);
            Name = "Form1";
            Text = "Egzamin Dyplomowy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox JSON_label;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
    }
}
