namespace egzamin_dyplomowy
{
    partial class Kalendarz
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
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(panel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 87F));
            tableLayoutPanel2.Size = new Size(500, 400);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857113F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.2857151F));
            tableLayoutPanel1.Controls.Add(label7, 6, 0);
            tableLayoutPanel1.Controls.Add(label5, 4, 0);
            tableLayoutPanel1.Controls.Add(label4, 3, 0);
            tableLayoutPanel1.Controls.Add(label3, 2, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label6, 5, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 55);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(494, 342);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label7
            // 
            label7.Location = new Point(423, 0);
            label7.Name = "label7";
            label7.Size = new Size(12, 57);
            label7.TabIndex = 6;
            label7.Text = "Nd";
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(283, 0);
            label5.Name = "label5";
            label5.Size = new Size(64, 342);
            label5.TabIndex = 4;
            label5.Text = "Pt";
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(213, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 342);
            label4.TabIndex = 3;
            label4.Text = "Czw";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(143, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 342);
            label3.TabIndex = 2;
            label3.Text = "Śr";
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(73, 0);
            label2.Name = "label2";
            label2.Size = new Size(64, 342);
            label2.TabIndex = 1;
            label2.Text = "Wt";
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(64, 342);
            label1.TabIndex = 0;
            label1.Text = "Pn";
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(353, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 342);
            label6.TabIndex = 5;
            label6.Text = "Sb";
            // 
            // panel1
            // 
            panel1.Controls.Add(label8);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 46);
            panel1.TabIndex = 4;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(494, 46);
            label8.TabIndex = 2;
            label8.Text = "Month and Year";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Kalendarz2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel2);
            Name = "Kalendarz2";
            Size = new Size(500, 400);
            Load += Kalendarz2_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Panel panel1;
        private Label label8;
    }
}
