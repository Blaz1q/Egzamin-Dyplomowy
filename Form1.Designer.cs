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
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // JSON_label
            // 
            JSON_label.Dock = DockStyle.Right;
            JSON_label.Location = new Point(899, 0);
            JSON_label.Multiline = true;
            JSON_label.Name = "JSON_label";
            JSON_label.Size = new Size(235, 817);
            JSON_label.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(JSON_label);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1134, 817);
            panel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1134, 817);
            Controls.Add(panel1);
            MaximizeBox = false;
            MaximumSize = new Size(1152, 864);
            MinimumSize = new Size(1152, 864);
            Name = "Form1";
            Text = "Egzamin Dyplomowy";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox JSON_label;
        private Panel panel1;
    }
}
