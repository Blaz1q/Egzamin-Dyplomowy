namespace egzamin_dyplomowy
{
    partial class ZatwierdzTermin
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
            lblTitle = new Label();
            flpPendingTerms = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.DimGray;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(12, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(325, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Terminy oczekujące na akceptację:";
            // 
            // flpPendingTerms
            // 
            flpPendingTerms.AutoScroll = true;
            flpPendingTerms.Location = new Point(12, 47);
            flpPendingTerms.Name = "flpPendingTerms";
            flpPendingTerms.Size = new Size(460, 390);
            flpPendingTerms.TabIndex = 1;
            // 
            // ZatwierdzTermin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(484, 450);
            Controls.Add(flpPendingTerms);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ZatwierdzTermin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Zatwierdź Terminy";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel flpPendingTerms;
    }
}