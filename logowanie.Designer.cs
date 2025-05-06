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
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BackColor = SystemColors.ControlLightLight;
            roundedTextBox1.BorderColor = Color.Gray;
            roundedTextBox1.BorderFocusColor = Color.Blue;
            roundedTextBox1.BorderRadius = 7;
            roundedTextBox1.BorderSize = 2;
            roundedTextBox1.Font = new Font("Instrument Sans", 33.7499962F, FontStyle.Regular, GraphicsUnit.Point, 238);
            roundedTextBox1.ForeColor = Color.Black;
            roundedTextBox1.InvalidBorderColor = Color.Red;
            roundedTextBox1.InvalidBorderFocusColor = Color.Orange;
            roundedTextBox1.Location = new Point(52, 156);
            roundedTextBox1.Multiline = false;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.Padding = new Padding(7);
            roundedTextBox1.PasswordChar = false;
            roundedTextBox1.PlaceholderColor = Color.DarkGray;
            roundedTextBox1.PlaceholderText = "Twój email";
            roundedTextBox1.Size = new Size(409, 75);
            roundedTextBox1.TabIndex = 0;
            roundedTextBox1.Texts = "";
            roundedTextBox1.UnderlinedStyle = false;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BackColor = SystemColors.Window;
            roundedTextBox2.BorderColor = Color.Gray;
            roundedTextBox2.BorderFocusColor = Color.Blue;
            roundedTextBox2.BorderRadius = 7;
            roundedTextBox2.BorderSize = 2;
            roundedTextBox2.Font = new Font("Instrument Sans", 33.7499962F, FontStyle.Regular, GraphicsUnit.Point, 238);
            roundedTextBox2.ForeColor = Color.Black;
            roundedTextBox2.InvalidBorderColor = Color.Red;
            roundedTextBox2.InvalidBorderFocusColor = Color.Orange;
            roundedTextBox2.Location = new Point(52, 290);
            roundedTextBox2.Multiline = false;
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.Padding = new Padding(7);
            roundedTextBox2.PasswordChar = true;
            roundedTextBox2.PlaceholderColor = Color.DarkGray;
            roundedTextBox2.PlaceholderText = "Twoje hasło";
            roundedTextBox2.Size = new Size(409, 75);
            roundedTextBox2.TabIndex = 1;
            roundedTextBox2.Texts = "";
            roundedTextBox2.UnderlinedStyle = false;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.Black;
            roundedButton1.BackgroundColor = Color.Black;
            roundedButton1.BorderColor = Color.PaleVioletRed;
            roundedButton1.BorderRadius = 10;
            roundedButton1.BorderSize = 0;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Instrument Sans", 23.9999962F, FontStyle.Regular, GraphicsUnit.Point, 238);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.HoverColor = Color.Transparent;
            roundedButton1.Location = new Point(52, 403);
            roundedButton1.Margin = new Padding(3, 2, 3, 2);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(409, 70);
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
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Instrument Sans", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(52, 121);
            label1.Name = "label1";
            label1.Size = new Size(77, 32);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Instrument Sans", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(52, 255);
            label2.Name = "label2";
            label2.Size = new Size(78, 32);
            label2.TabIndex = 3;
            label2.Text = "Hasło";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Instrument Sans", 35.9999962F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(127, 30);
            label3.Name = "label3";
            label3.Size = new Size(270, 64);
            label3.TabIndex = 6;
            label3.Text = "Zaloguj się";
            // 
            // linkLabel1
            // 
            linkLabel1.ActiveLinkColor = Color.Black;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Instrument Sans Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 238);
            linkLabel1.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(52, 505);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(237, 32);
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
            linkLabel2.Font = new Font("Instrument Sans Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 238);
            linkLabel2.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(48, 554);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(171, 32);
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
            linkLabel3.Font = new Font("Instrument Sans Medium", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 238);
            linkLabel3.LinkBehavior = LinkBehavior.AlwaysUnderline;
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(48, 601);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(175, 32);
            linkLabel3.TabIndex = 7;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Aktywuj konto";
            linkLabel3.VisitedLinkColor = Color.Black;
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.Logowanie;
            pictureBox1.Location = new Point(208, -252);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1558, 1330);
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(520, 820);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // logowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label3);
            Controls.Add(roundedButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(roundedTextBox2);
            Controls.Add(roundedTextBox1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            Name = "logowanie";
            Size = new Size(1152, 820);
            Load += logowanie_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
