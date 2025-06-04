namespace egzamin_dyplomowy
{
    partial class KalendarzControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel3 = new Panel();
            roundedButton1 = new RoundedButton();
            roundedButton2 = new RoundedButton();
            roundedButton3 = new RoundedButton();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 400);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(3, 16);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 2;
            button1.Text = "< Prev Month";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(246, 16);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 3;
            button2.Text = "Next >";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(354, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(457, 400);
            panel3.TabIndex = 1;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.MediumSlateBlue;
            roundedButton1.BackgroundColor = Color.MediumSlateBlue;
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 0;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.HoverColor = Color.Transparent;
            roundedButton1.Location = new Point(3, 4);
            roundedButton1.Margin = new Padding(3, 4, 3, 4);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(137, 53);
            roundedButton1.TabIndex = 4;
            roundedButton1.Text = "Dodaj Termin";
            roundedButton1.TextColor = Color.White;
            roundedButton1.TooltipText = null;
            roundedButton1.UseVisualStyleBackColor = true;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.MediumSlateBlue;
            roundedButton2.BackgroundColor = Color.MediumSlateBlue;
            roundedButton2.BorderColor = Color.PaleVioletRed;
            roundedButton2.BorderRadius = 0;
            roundedButton2.BorderSize = 0;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.ForeColor = Color.White;
            roundedButton2.HoverColor = Color.Transparent;
            roundedButton2.Location = new Point(3, 65);
            roundedButton2.Margin = new Padding(3, 4, 3, 4);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(137, 53);
            roundedButton2.TabIndex = 5;
            roundedButton2.Text = "Zaklep Termin";
            roundedButton2.TextColor = Color.White;
            roundedButton2.TooltipText = null;
            roundedButton2.UseVisualStyleBackColor = true;
            roundedButton2.Click += roundedButton2_Click_1;
            // 
            // roundedButton3
            // 
            roundedButton3.BackColor = Color.MediumSlateBlue;
            roundedButton3.BackgroundColor = Color.MediumSlateBlue;
            roundedButton3.BorderColor = Color.PaleVioletRed;
            roundedButton3.BorderRadius = 0;
            roundedButton3.BorderSize = 0;
            roundedButton3.FlatStyle = FlatStyle.Flat;
            roundedButton3.ForeColor = Color.White;
            roundedButton3.HoverColor = Color.Transparent;
            roundedButton3.Location = new Point(3, 126);
            roundedButton3.Margin = new Padding(3, 4, 3, 4);
            roundedButton3.Name = "roundedButton3";
            roundedButton3.Size = new Size(206, 53);
            roundedButton3.TabIndex = 6;
            roundedButton3.Text = "Zatwierdź Terminy";
            roundedButton3.TextColor = Color.White;
            roundedButton3.TooltipText = null;
            roundedButton3.UseVisualStyleBackColor = true;
            roundedButton3.Click += roundedButton3_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(roundedButton1);
            flowLayoutPanel1.Controls.Add(roundedButton2);
            flowLayoutPanel1.Controls.Add(roundedButton3);
            flowLayoutPanel1.Location = new Point(38, 409);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 185);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // KalendarzControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "KalendarzControl";
            Size = new Size(914, 600);
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private RoundedButton roundedButton1; // Your existing button
        private RoundedButton roundedButton2; // NEW
        private RoundedButton roundedButton3; // NEW
        private FlowLayoutPanel flowLayoutPanel1;
    }
}