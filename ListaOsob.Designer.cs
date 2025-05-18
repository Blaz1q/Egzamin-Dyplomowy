namespace egzamin_dyplomowy
{
    partial class ListaOsob
    {
        private System.ComponentModel.IContainer components = null;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnWszyscy;
        private Button btnStudenci;
        private Button btnWykladowcy;

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
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(10, 50);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(760, 400);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btnWszyscy
            // 
            btnWszyscy.Location = new Point(175, 12);
            btnWszyscy.Name = "btnWszyscy";
            btnWszyscy.Size = new Size(99, 23);
            btnWszyscy.TabIndex = 0;
            btnWszyscy.Text = "Wszyscy";
            btnWszyscy.Click += BtnWszyscy_Click;
            // 
            // btnStudenci
            // 
            btnStudenci.Location = new Point(309, 12);
            btnStudenci.Name = "btnStudenci";
            btnStudenci.Size = new Size(99, 23);
            btnStudenci.TabIndex = 1;
            btnStudenci.Text = "Studenci";
            btnStudenci.Click += BtnStudenci_Click;
            // 
            // btnWykladowcy
            // 
            btnWykladowcy.Location = new Point(448, 12);
            btnWykladowcy.Name = "btnWykladowcy";
            btnWykladowcy.Size = new Size(99, 23);
            btnWykladowcy.TabIndex = 2;
            btnWykladowcy.Text = "Wykładowcy";
            btnWykladowcy.Click += BtnWykladowcy_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(800, 500);
            Controls.Add(btnWszyscy);
            Controls.Add(btnStudenci);
            Controls.Add(btnWykladowcy);
            Controls.Add(flowLayoutPanel1);
            Name = "Form1";
            Text = "Zarządzanie Użytkownikami";
            ResumeLayout(false);
        }
    }
}