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
            waliduj_token = new Button();
            panel1 = new Panel();
            Zmien_token = new Button();
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
            // waliduj_token
            // 
            waliduj_token.Location = new Point(672, 279);
            waliduj_token.Name = "waliduj_token";
            waliduj_token.Size = new Size(116, 29);
            waliduj_token.TabIndex = 6;
            waliduj_token.Text = "Waliduj token";
            waliduj_token.UseVisualStyleBackColor = true;
            waliduj_token.Click += waliduj_token_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(8, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 296);
            panel1.TabIndex = 7;
            // 
            // Zmien_token
            // 
            Zmien_token.Location = new Point(543, 279);
            Zmien_token.Name = "Zmien_token";
            Zmien_token.Size = new Size(102, 29);
            Zmien_token.TabIndex = 8;
            Zmien_token.Text = "Zmien token";
            Zmien_token.UseVisualStyleBackColor = true;
            Zmien_token.Click += Zmien_token_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Zmien_token);
            Controls.Add(panel1);
            Controls.Add(waliduj_token);
            Controls.Add(JSON_label);
            Name = "Form1";
            Text = "u";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox JSON_label;
        private Button waliduj_token;
        private Panel panel1;
        private Button Zmien_token;
    }
}
