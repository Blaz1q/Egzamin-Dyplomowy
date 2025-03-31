namespace egzamin_dyplomowy
{
    partial class rejestracja
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
            Zarejestruj_button = new Button();
            LoginBox = new TextBox();
            hasloBox = new TextBox();
            nazwiskoBox = new TextBox();
            imieBox = new TextBox();
            Label1 = new Label();
            label2 = new Label();
            Label3 = new Label();
            label4 = new Label();
            aktywuj_konto = new Button();
            SuspendLayout();
            // 
            // Zarejestruj_button
            // 
            Zarejestruj_button.Location = new Point(27, 266);
            Zarejestruj_button.Name = "Zarejestruj_button";
            Zarejestruj_button.Size = new Size(94, 29);
            Zarejestruj_button.TabIndex = 0;
            Zarejestruj_button.Text = "zarejestruj";
            Zarejestruj_button.UseVisualStyleBackColor = true;
            Zarejestruj_button.Click += Zarejestruj_button_Click;
            // 
            // LoginBox
            // 
            LoginBox.Location = new Point(27, 51);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(125, 27);
            LoginBox.TabIndex = 1;
            // 
            // hasloBox
            // 
            hasloBox.Location = new Point(27, 104);
            hasloBox.Name = "hasloBox";
            hasloBox.Size = new Size(125, 27);
            hasloBox.TabIndex = 2;
            // 
            // nazwiskoBox
            // 
            nazwiskoBox.Location = new Point(27, 210);
            nazwiskoBox.Name = "nazwiskoBox";
            nazwiskoBox.Size = new Size(125, 27);
            nazwiskoBox.TabIndex = 3;
            // 
            // imieBox
            // 
            imieBox.Location = new Point(27, 157);
            imieBox.Name = "imieBox";
            imieBox.Size = new Size(125, 27);
            imieBox.TabIndex = 4;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(27, 28);
            Label1.Name = "Label1";
            Label1.Size = new Size(46, 20);
            Label1.TabIndex = 5;
            Label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 81);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 6;
            label2.Text = "Hasło";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(27, 134);
            Label3.Name = "Label3";
            Label3.Size = new Size(38, 20);
            Label3.TabIndex = 7;
            Label3.Text = "Imie";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 187);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "Nazwisko";
            // 
            // aktywuj_konto
            // 
            aktywuj_konto.Location = new Point(144, 266);
            aktywuj_konto.Name = "aktywuj_konto";
            aktywuj_konto.Size = new Size(120, 29);
            aktywuj_konto.TabIndex = 9;
            aktywuj_konto.Text = "aktywuj konto";
            aktywuj_konto.UseVisualStyleBackColor = true;
            aktywuj_konto.Click += aktywuj_konto_Click_1;
            // 
            // rejestracja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(aktywuj_konto);
            Controls.Add(label4);
            Controls.Add(Label3);
            Controls.Add(label2);
            Controls.Add(Label1);
            Controls.Add(imieBox);
            Controls.Add(nazwiskoBox);
            Controls.Add(hasloBox);
            Controls.Add(LoginBox);
            Controls.Add(Zarejestruj_button);
            Name = "rejestracja";
            Size = new Size(408, 354);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Zarejestruj_button;
        private TextBox LoginBox;
        private TextBox hasloBox;
        private TextBox nazwiskoBox;
        private TextBox imieBox;
        private Label Label1;
        private Label label2;
        private Label Label3;
        private Label label4;
        private Button aktywuj_konto;
    }
}
