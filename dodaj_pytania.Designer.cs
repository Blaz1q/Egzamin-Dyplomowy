using System.Windows.Forms;
using System.Drawing;
namespace egzamin_dyplomowy
{
    partial class dodaj_pytania
    {
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxTresc;
        private TextBox textBoxKierunek;
        private TextBox textBoxSpecjalnosc;
        private ComboBox comboBoxStopien;
        private ComboBox comboBoxWykladowcy;
        private FlowLayoutPanel flowLayoutPanelWykladowcy;
        private RoundedButton buttonDodaj;

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxTresc = new TextBox();
            textBoxKierunek = new TextBox();
            textBoxSpecjalnosc = new TextBox();
            comboBoxStopien = new ComboBox();
            comboBoxWykladowcy = new ComboBox();
            flowLayoutPanelWykladowcy = new FlowLayoutPanel();
            buttonDodaj = new RoundedButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.Location = new Point(214, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 46);
            label1.TabIndex = 12;
            label1.Text = "Dodaj Pytanie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(237, 46);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 11;
            label2.Text = "Treść";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(237, 90);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 9;
            label3.Text = "Kierunek";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(237, 134);
            label4.Name = "label4";
            label4.Size = new Size(69, 15);
            label4.TabIndex = 7;
            label4.Text = "Specjalność";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 178);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 5;
            label5.Text = "Stopień";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(237, 231);
            label6.Name = "label6";
            label6.Size = new Size(123, 15);
            label6.TabIndex = 2;
            label6.Text = "Dodaj egzaminatorów";
            // 
            // textBoxTresc
            // 
            textBoxTresc.Location = new Point(237, 64);
            textBoxTresc.Name = "textBoxTresc";
            textBoxTresc.Size = new Size(203, 23);
            textBoxTresc.TabIndex = 10;
            // 
            // textBoxKierunek
            // 
            textBoxKierunek.Location = new Point(237, 108);
            textBoxKierunek.Name = "textBoxKierunek";
            textBoxKierunek.Size = new Size(203, 23);
            textBoxKierunek.TabIndex = 8;
            // 
            // textBoxSpecjalnosc
            // 
            textBoxSpecjalnosc.Location = new Point(237, 152);
            textBoxSpecjalnosc.Name = "textBoxSpecjalnosc";
            textBoxSpecjalnosc.Size = new Size(203, 23);
            textBoxSpecjalnosc.TabIndex = 6;
            // 
            // comboBoxStopien
            // 
            comboBoxStopien.Location = new Point(237, 198);
            comboBoxStopien.Name = "comboBoxStopien";
            comboBoxStopien.Size = new Size(203, 23);
            comboBoxStopien.TabIndex = 4;
            // 
            // comboBoxWykladowcy
            // 
            comboBoxWykladowcy.Location = new Point(237, 249);
            comboBoxWykladowcy.Name = "comboBoxWykladowcy";
            comboBoxWykladowcy.Size = new Size(203, 23);
            comboBoxWykladowcy.TabIndex = 3;
            // 
            // flowLayoutPanelWykladowcy
            // 
            flowLayoutPanelWykladowcy.AutoScroll = true;
            flowLayoutPanelWykladowcy.Location = new Point(237, 278);
            flowLayoutPanelWykladowcy.Name = "flowLayoutPanelWykladowcy";
            flowLayoutPanelWykladowcy.Size = new Size(203, 168);
            flowLayoutPanelWykladowcy.TabIndex = 1;
            // 
            // buttonDodaj
            // 
            buttonDodaj.BackColor = Color.MediumSlateBlue;
            buttonDodaj.BackgroundColor = Color.MediumSlateBlue;
            buttonDodaj.BorderColor = Color.PaleVioletRed;
            buttonDodaj.BorderRadius = 10;
            buttonDodaj.BorderSize = 0;
            buttonDodaj.FlatAppearance.BorderSize = 0;
            buttonDodaj.FlatAppearance.MouseOverBackColor = Color.SlateBlue;
            buttonDodaj.FlatStyle = FlatStyle.Flat;
            buttonDodaj.ForeColor = Color.White;
            buttonDodaj.HoverColor = Color.Transparent;
            buttonDodaj.Location = new Point(253, 452);
            buttonDodaj.Name = "buttonDodaj";
            buttonDodaj.Size = new Size(164, 25);
            buttonDodaj.TabIndex = 0;
            buttonDodaj.Text = "Dodaj Pytanie";
            buttonDodaj.TextColor = Color.White;
            buttonDodaj.TooltipText = null;
            buttonDodaj.UseVisualStyleBackColor = false;
            buttonDodaj.Click += buttonDodaj_Click;
            // 
            // dodaj_pytania
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDodaj);
            Controls.Add(flowLayoutPanelWykladowcy);
            Controls.Add(label6);
            Controls.Add(comboBoxWykladowcy);
            Controls.Add(comboBoxStopien);
            Controls.Add(label5);
            Controls.Add(textBoxSpecjalnosc);
            Controls.Add(label4);
            Controls.Add(textBoxKierunek);
            Controls.Add(label3);
            Controls.Add(textBoxTresc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "dodaj_pytania";
            Size = new Size(670, 520);
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
