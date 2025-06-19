namespace egzamin_dyplomowy
{
    partial class Rejestrowanie
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedButton zarejestrujbutton;
        private Label label2;
        private RoundedTextBox HasloText;
        private RoundedTextBox mailtext;
        private Label label1;
        private Label label3;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mailtext = new RoundedTextBox();
            HasloText = new RoundedTextBox();
            zarejestrujbutton = new RoundedButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            hasloresertlink = new LinkLabel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            powrotlogowanielinl = new LinkLabel();
            PowtHasloText = new RoundedTextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // mailtext
            // 
            mailtext.BackColor = SystemColors.ControlLightLight;
            mailtext.BorderColor = Color.Gray;
            mailtext.BorderFocusColor = Color.Blue;
            mailtext.BorderRadius = 7;
            mailtext.BorderSize = 2;
            mailtext.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            mailtext.ForeColor = Color.Black;
            mailtext.InvalidBorderColor = Color.Red;
            mailtext.InvalidBorderFocusColor = Color.Orange;
            mailtext.Location = new Point(52, 101);
            mailtext.Margin = new Padding(3, 3, 3, 22);
            mailtext.Multiline = false;
            mailtext.Name = "mailtext";
            mailtext.Padding = new Padding(18, 15, 18, 15);
            mailtext.PasswordChar = false;
            mailtext.PlaceholderColor = Color.DarkGray;
            mailtext.PlaceholderText = "Twój email";
            mailtext.Size = new Size(409, 57);
            mailtext.TabIndex = 0;
            mailtext.Texts = "";
            mailtext.UnderlinedStyle = false;
            // 
            // HasloText
            // 
            HasloText.BackColor = SystemColors.Window;
            HasloText.BorderColor = Color.Gray;
            HasloText.BorderFocusColor = Color.Blue;
            HasloText.BorderRadius = 7;
            HasloText.BorderSize = 2;
            HasloText.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            HasloText.ForeColor = Color.Black;
            HasloText.InvalidBorderColor = Color.Red;
            HasloText.InvalidBorderFocusColor = Color.Orange;
            HasloText.Location = new Point(52, 203);
            HasloText.Margin = new Padding(3, 3, 3, 34);
            HasloText.Multiline = false;
            HasloText.Name = "HasloText";
            HasloText.Padding = new Padding(18, 15, 18, 15);
            HasloText.PasswordChar = true;
            HasloText.PlaceholderColor = Color.DarkGray;
            HasloText.PlaceholderText = "Twoje hasło";
            HasloText.Size = new Size(409, 57);
            HasloText.TabIndex = 1;
            HasloText.Texts = "";
            HasloText.UnderlinedStyle = false;
            // 
            // zarejestrujbutton
            // 
            zarejestrujbutton.BackColor = Color.FromArgb(30, 30, 30);
            zarejestrujbutton.BackgroundColor = Color.FromArgb(30, 30, 30);
            zarejestrujbutton.BorderColor = Color.PaleVioletRed;
            zarejestrujbutton.BorderRadius = 10;
            zarejestrujbutton.BorderSize = 0;
            zarejestrujbutton.FlatAppearance.MouseOverBackColor = Color.FromArgb(25, 25, 25);
            zarejestrujbutton.FlatStyle = FlatStyle.Flat;
            zarejestrujbutton.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            zarejestrujbutton.ForeColor = Color.White;
            zarejestrujbutton.HoverColor = Color.FromArgb(25, 25, 25);
            zarejestrujbutton.Location = new Point(52, 418);
            zarejestrujbutton.Margin = new Padding(3, 2, 3, 22);
            zarejestrujbutton.Name = "zarejestrujbutton";
            zarejestrujbutton.Size = new Size(409, 55);
            zarejestrujbutton.TabIndex = 10;
            zarejestrujbutton.Text = "Zarejestruj się";
            zarejestrujbutton.TextColor = Color.White;
            zarejestrujbutton.TooltipText = null;
            zarejestrujbutton.UseVisualStyleBackColor = false;
            zarejestrujbutton.Click += roundedButton1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.Location = new Point(52, 69);
            label1.Name = "label1";
            label1.Size = new Size(79, 29);
            label1.TabIndex = 2;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label2.Location = new Point(52, 171);
            label2.Name = "label2";
            label2.Size = new Size(83, 29);
            label2.TabIndex = 3;
            label2.Text = "Hasło";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label3.Location = new Point(85, 14);
            label3.Name = "label3";
            label3.Size = new Size(339, 55);
            label3.TabIndex = 6;
            label3.Text = "Zarejestruj się";
            // 
            // hasloresertlink
            // 
            hasloresertlink.ActiveLinkColor = Color.Black;
            hasloresertlink.AutoSize = true;
            hasloresertlink.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            hasloresertlink.LinkBehavior = LinkBehavior.AlwaysUnderline;
            hasloresertlink.LinkColor = Color.Black;
            hasloresertlink.Location = new Point(52, 375);
            hasloresertlink.Margin = new Padding(3, 0, 3, 12);
            hasloresertlink.Name = "hasloresertlink";
            hasloresertlink.Size = new Size(251, 29);
            hasloresertlink.TabIndex = 7;
            hasloresertlink.TabStop = true;
            hasloresertlink.Text = "Zapomniałeś hasła?";
            hasloresertlink.VisitedLinkColor = Color.Black;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(520, 648);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // powrotlogowanielinl
            // 
            powrotlogowanielinl.ActiveLinkColor = Color.Black;
            powrotlogowanielinl.AutoSize = true;
            powrotlogowanielinl.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            powrotlogowanielinl.LinkBehavior = LinkBehavior.AlwaysUnderline;
            powrotlogowanielinl.LinkColor = Color.Black;
            powrotlogowanielinl.Location = new Point(52, 495);
            powrotlogowanielinl.Margin = new Padding(3, 0, 3, 12);
            powrotlogowanielinl.Name = "powrotlogowanielinl";
            powrotlogowanielinl.Size = new Size(259, 29);
            powrotlogowanielinl.TabIndex = 7;
            powrotlogowanielinl.TabStop = true;
            powrotlogowanielinl.Text = "Powrót do logowania";
            powrotlogowanielinl.VisitedLinkColor = Color.Black;
            // 
            // PowtHasloText
            // 
            PowtHasloText.BackColor = SystemColors.Window;
            PowtHasloText.BorderColor = Color.Gray;
            PowtHasloText.BorderFocusColor = Color.Blue;
            PowtHasloText.BorderRadius = 7;
            PowtHasloText.BorderSize = 2;
            PowtHasloText.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            PowtHasloText.ForeColor = Color.Black;
            PowtHasloText.InvalidBorderColor = Color.Red;
            PowtHasloText.InvalidBorderFocusColor = Color.Orange;
            PowtHasloText.Location = new Point(52, 306);
            PowtHasloText.Margin = new Padding(3, 3, 3, 34);
            PowtHasloText.Multiline = false;
            PowtHasloText.Name = "PowtHasloText";
            PowtHasloText.Padding = new Padding(18, 15, 18, 15);
            PowtHasloText.PasswordChar = true;
            PowtHasloText.PlaceholderColor = Color.DarkGray;
            PowtHasloText.PlaceholderText = "Twoje hasło";
            PowtHasloText.Size = new Size(409, 57);
            PowtHasloText.TabIndex = 13;
            PowtHasloText.Texts = "";
            PowtHasloText.UnderlinedStyle = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.Location = new Point(52, 274);
            label4.Name = "label4";
            label4.Size = new Size(184, 29);
            label4.TabIndex = 14;
            label4.Text = "Powtórz Hasło";
            // 
            // Rejestrowanie
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label4);
            Controls.Add(PowtHasloText);
            Controls.Add(powrotlogowanielinl);
            Controls.Add(hasloresertlink);
            Controls.Add(label3);
            Controls.Add(zarejestrujbutton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(HasloText);
            Controls.Add(mailtext);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            ForeColor = Color.Black;
            Name = "Rejestrowanie";
            Size = new Size(1012, 648);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private LinkLabel hasloresertlink;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private LinkLabel powrotlogowanielinl;
        private RoundedTextBox PowtHasloText;
        private Label label4;
    }
}