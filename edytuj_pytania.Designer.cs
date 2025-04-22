using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    partial class edytuj_pytania
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
            label1 = new Label();
            label2 = new Label();
            textBoxTresc = new TextBox();
            label3 = new Label();
            roundedButton1 = new RoundedButton();
            roundedButton2 = new RoundedButton();
            comboBoxWykladowcy = new ComboBox();
            flowLayoutPanelWykladowcy = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(214, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 46);
            label1.TabIndex = 0;
            label1.Text = "Edytuj Pytanie";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 46);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 1;
            label2.Text = "Treść";
            label2.Click += label2_Click;
            // 
            // textBoxTresc
            // 
            textBoxTresc.Location = new Point(237, 64);
            textBoxTresc.Margin = new Padding(3, 2, 3, 2);
            textBoxTresc.Name = "textBoxTresc";
            textBoxTresc.Size = new Size(203, 23);
            textBoxTresc.TabIndex = 2;
            textBoxTresc.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 99);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 3;
            label3.Text = "Dodaj egzaminatorów";
            // 
            // przejdz_do_aplikacji
            // 
            roundedButton1.BackColor = Color.MediumSlateBlue;
            roundedButton1.BackgroundColor = Color.MediumSlateBlue;
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 10;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.HoverColor = Color.Transparent;
            roundedButton1.Location = new Point(256, 319);
            roundedButton1.Margin = new Padding(3, 2, 3, 2);
            roundedButton1.Name = "przejdz_do_aplikacji";
            roundedButton1.Size = new Size(164, 25);
            roundedButton1.TabIndex = 10;
            roundedButton1.Text = "Usuń Pytanie";
            roundedButton1.TextColor = Color.White;
            roundedButton1.TooltipText = null;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += UsunPytanie_Click;
            // 
            // roundedButton2
            // 
            roundedButton2.BackColor = Color.MediumSlateBlue;
            roundedButton2.BackgroundColor = Color.MediumSlateBlue;
            roundedButton2.BorderColor = Color.PaleVioletRed;
            roundedButton2.BorderRadius = 10;
            roundedButton2.BorderSize = 0;
            roundedButton2.FlatAppearance.BorderSize = 0;
            roundedButton2.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            roundedButton2.FlatStyle = FlatStyle.Flat;
            roundedButton2.ForeColor = Color.White;
            roundedButton2.HoverColor = Color.Transparent;
            roundedButton2.Location = new Point(256, 348);
            roundedButton2.Margin = new Padding(3, 2, 3, 2);
            roundedButton2.Name = "roundedButton2";
            roundedButton2.Size = new Size(164, 25);
            roundedButton2.TabIndex = 12;
            roundedButton2.Text = "Edytuj Pytanie";
            roundedButton2.TextColor = Color.White;
            roundedButton2.TooltipText = null;
            roundedButton2.UseVisualStyleBackColor = false;
            roundedButton2.Click += EdytujPytanie_Click;

            // 
            // comboBoxWykladowcy
            // 
            comboBoxWykladowcy.FormattingEnabled = true;
            comboBoxWykladowcy.Location = new Point(237, 117);
            comboBoxWykladowcy.Name = "comboBoxWykladowcy";
            comboBoxWykladowcy.Size = new Size(203, 23);
            comboBoxWykladowcy.TabIndex = 13;
            // 
            // flowLayoutPanelWykladowcy
            // 
            flowLayoutPanelWykladowcy.Location = new Point(237, 146);
            flowLayoutPanelWykladowcy.Name = "flowLayoutPanelWykladowcy";
            flowLayoutPanelWykladowcy.Size = new Size(203, 168);
            flowLayoutPanelWykladowcy.TabIndex = 14;
            flowLayoutPanelWykladowcy.Paint += flowLayoutPanel1_Paint;
            flowLayoutPanelWykladowcy.WrapContents = true;
            flowLayoutPanelWykladowcy.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanelWykladowcy.AutoScroll = true;

            // 
            // edytuj_pytania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanelWykladowcy);
            Controls.Add(comboBoxWykladowcy);
            Controls.Add(roundedButton2);
            Controls.Add(roundedButton1);
            Controls.Add(label3);
            Controls.Add(textBoxTresc);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "edytuj_pytania";
            Size = new Size(670, 386);
            ResumeLayout(false);
            PerformLayout();


        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxTresc;
        private ComboBox comboBoxWykladowcy;
        private RoundedButton roundedButton1;
        private RoundedButton roundedButton2;
        private FlowLayoutPanel flowLayoutPanelWykladowcy;
    }
}
