namespace egzamin_dyplomowy
{
    partial class KalendarzDzien
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            daylabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(daylabel);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(3);
            panel1.Size = new Size(56, 60);
            panel1.TabIndex = 0;
            panel1.Click += panel1_Click;
            panel1.MouseEnter += panel1_MouseEnter;
            panel1.MouseLeave += panel1_MouseLeave;
            // 
            // daylabel
            // 
            daylabel.Dock = DockStyle.Fill;
            daylabel.Location = new Point(3, 3);
            daylabel.Name = "daylabel";
            daylabel.Size = new Size(50, 54);
            daylabel.TabIndex = 0;
            daylabel.Text = "00";
            daylabel.TextAlign = ContentAlignment.MiddleCenter;
            daylabel.Click += daylabel_Click;
            daylabel.MouseEnter += daylabel_MouseEnter;
            daylabel.MouseLeave += daylabel_MouseLeave;
            // 
            // KalendarzDzien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(panel1);
            Name = "KalendarzDzien";
            Padding = new Padding(1);
            Size = new Size(58, 62);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label daylabel;
    }
}
