namespace egzamin_dyplomowy
{
    partial class Pytania
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKierunki;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

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
            comboKierunki = new ComboBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(309, 18);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 0;
            label1.Text = "Lista Pytań";
            label1.Click += label1_Click;
            // 
            // comboKierunki
            // 
            comboKierunki.DropDownStyle = ComboBoxStyle.DropDownList;
            comboKierunki.FormattingEnabled = true;
            comboKierunki.Location = new Point(279, 128);
            comboKierunki.Name = "comboKierunki";
            comboKierunki.Size = new Size(200, 23);
            comboKierunki.TabIndex = 1;
            comboKierunki.SelectedIndexChanged += comboKierunki_SelectedIndexChanged_1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(124, 157);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(432, 400);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // Pytania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(comboKierunki);
            Controls.Add(label1);
            Name = "Pytania";
            Size = new Size(692, 582);
            Load += Pytania_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
