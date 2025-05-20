namespace egzamin_dyplomowy
{
    partial class ListaOsob
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnWszyscy;
        private Button btnStudenci;
        private Button btnWykladowcy;
        private Button btnDodajOsobe;

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
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnWszyscy = new Button();
            btnStudenci = new Button();
            btnWykladowcy = new Button();
            btnDodajOsobe = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(175, 117);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(372, 333);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnWszyscy
            // 
            btnWszyscy.Location = new Point(175, 88);
            btnWszyscy.Name = "btnWszyscy";
            btnWszyscy.Size = new Size(99, 23);
            btnWszyscy.TabIndex = 0;
            btnWszyscy.Text = "Wszyscy";
            btnWszyscy.Click += BtnWszyscy_Click;
            // 
            // btnStudenci
            // 
            btnStudenci.Location = new Point(310, 88);
            btnStudenci.Name = "btnStudenci";
            btnStudenci.Size = new Size(99, 23);
            btnStudenci.TabIndex = 1;
            btnStudenci.Text = "Studenci";
            btnStudenci.Click += BtnStudenci_Click;
            // 
            // btnWykladowcy
            // 
            btnWykladowcy.Location = new Point(448, 88);
            btnWykladowcy.Name = "btnWykladowcy";
            btnWykladowcy.Size = new Size(99, 23);
            btnWykladowcy.TabIndex = 2;
            btnWykladowcy.Text = "Wykładowcy";
            btnWykladowcy.Click += BtnWykladowcy_Click;
            // 
            // btnDodajOsobe
            // 
            btnDodajOsobe.Location = new Point(278, 456);
            btnDodajOsobe.Name = "btnDodajOsobe";
            btnDodajOsobe.Size = new Size(160, 30);
            btnDodajOsobe.TabIndex = 4;
            btnDodajOsobe.Text = "Dodaj Użytkownika";
            btnDodajOsobe.Click += btnDodajOsobe_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(278, 32);
            label1.Name = "label1";
            label1.Size = new Size(166, 37);
            label1.TabIndex = 5;
            label1.Text = "Użytkownicy";
            // 
            // ListaOsob
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(label1);
            Controls.Add(btnWszyscy);
            Controls.Add(btnStudenci);
            Controls.Add(btnWykladowcy);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(btnDodajOsobe);
            Name = "ListaOsob";
            Text = "Zarządzanie Użytkownikami";
            ResumeLayout(false);
            PerformLayout();

        }
        private Label label1;
    }
}