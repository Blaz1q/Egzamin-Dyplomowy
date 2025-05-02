namespace egzamin_dyplomowy
{
    partial class logowanie
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedButton roundedButton1;
        private Label label2;
        private RoundedTextBox roundedTextBox2;
        private RoundedTextBox roundedTextBox1;
        private Label label1;
        private Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            roundedTextBox1 = new RoundedTextBox();
            roundedTextBox2 = new RoundedTextBox();
            roundedButton1 = new RoundedButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = SystemColors.ControlLightLight;
            roundedTextBox1.BorderColor = Color.Gray;
            roundedTextBox1.BorderFocusColor = Color.Blue;
            roundedTextBox1.BorderRadius = 5;
            roundedTextBox1.BorderSize = 2;
            roundedTextBox1.ForeColor = Color.Black;
            roundedTextBox1.InvalidBorderColor = Color.Red;
            roundedTextBox1.InvalidBorderFocusColor = Color.Orange;
            roundedTextBox1.Location = new Point(28, 84);
            roundedTextBox1.Multiline = false;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Padding = new Padding(7);
            roundedTextBox1.PasswordChar = false;
            roundedTextBox1.PlaceholderColor = Color.DarkGray;
            roundedTextBox1.PlaceholderText = "Twój email";
            roundedTextBox1.Size = new Size(200, 30);
            roundedTextBox1.TabIndex = 0;
            roundedTextBox1.Texts = "";
            roundedTextBox1.UnderlinedStyle = false;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = SystemColors.Window;
            roundedTextBox2.BorderColor = Color.Gray;
            roundedTextBox2.BorderFocusColor = Color.Blue;
            roundedTextBox2.BorderRadius = 5;
            roundedTextBox2.BorderSize = 2;
            roundedTextBox2.ForeColor = Color.Black;
            roundedTextBox2.InvalidBorderColor = Color.Red;
            roundedTextBox2.InvalidBorderFocusColor = Color.Orange;
            roundedTextBox2.Location = new Point(28, 144);
            roundedTextBox2.Multiline = false;
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.Padding = new Padding(7);
            roundedTextBox2.PasswordChar = true;
            roundedTextBox2.PlaceholderColor = Color.DarkGray;
            roundedTextBox2.PlaceholderText = "Twoje hasło";
            roundedTextBox2.Size = new Size(200, 30);
            roundedTextBox2.TabIndex = 1;
            roundedTextBox2.Texts = "";
            roundedTextBox2.UnderlinedStyle = false;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Black;
            roundedButton1.BackgroundColor = Color.Black;
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 5;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.ForeColor = Color.White;
            roundedButton1.HoverColor = Color.Transparent;
            roundedButton1.Location = new Point(28, 191);
            roundedButton1.Margin = new Padding(3, 2, 3, 2);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(200, 33);
            roundedButton1.TabIndex = 10;
            roundedButton1.Text = "Zaloguj się";
            roundedButton1.TextColor = Color.White;
            roundedButton1.TooltipText = null;
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label1.Location = new Point(28, 66);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            label2.Location = new Point(28, 127);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 3;
            label2.Text = "Hasło";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            label3.Location = new Point(64, 19);
            label3.Name = "label3";
            label3.Size = new Size(113, 24);
            label3.TabIndex = 6;
            label3.Text = "Zaloguj się";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 10F);
            linkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(28, 237);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(135, 17);
            linkLabel1.TabIndex = 7;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Zapomniałeś hasła?";
            linkLabel1.VisitedLinkColor = Color.Black;
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.ActiveLinkColor = Color.Black;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Microsoft Sans Serif", 10F);
            linkLabel2.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(28, 266);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(98, 17);
            linkLabel2.TabIndex = 7;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Zarejestruj się";
            linkLabel2.VisitedLinkColor = Color.Black;
            linkLabel2.LinkClicked += linkLabel3_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.ActiveLinkColor = Color.Black;
            linkLabel3.AutoSize = true;
            linkLabel3.Font = new Font("Microsoft Sans Serif", 10F);
            linkLabel3.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(28, 296);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(94, 17);
            linkLabel3.TabIndex = 7;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Aktywuj konto";
            linkLabel3.VisitedLinkColor = Color.Black;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(262, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(518, 408);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // logowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBox1);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(roundedButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roundedTextBox2);
            Controls.Add(roundedTextBox1);
            ForeColor = Color.Black;
            Name = "logowanie";
            Size = new Size(780, 408);
            Load += logowanie_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox1;
    }
}
