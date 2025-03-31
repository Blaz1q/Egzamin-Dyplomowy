namespace egzamin_dyplomowy
{
    partial class aktywuj_konto
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
            kod_aktywacyjnyBox = new TextBox();
            aktywuj_button = new Button();
            zaloguj = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 27);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Kod aktywacyjny";
            // 
            // kod_aktywacyjnyBox
            // 
            kod_aktywacyjnyBox.Location = new Point(18, 50);
            kod_aktywacyjnyBox.Name = "kod_aktywacyjnyBox";
            kod_aktywacyjnyBox.Size = new Size(125, 27);
            kod_aktywacyjnyBox.TabIndex = 1;
            // 
            // aktywuj_button
            // 
            aktywuj_button.Location = new Point(149, 50);
            aktywuj_button.Name = "aktywuj_button";
            aktywuj_button.Size = new Size(94, 29);
            aktywuj_button.TabIndex = 2;
            aktywuj_button.Text = "aktywuj";
            aktywuj_button.UseVisualStyleBackColor = true;
            aktywuj_button.Click += aktywuj_button_Click;
            // 
            // zaloguj
            // 
            zaloguj.Location = new Point(35, 135);
            zaloguj.Name = "zaloguj";
            zaloguj.Size = new Size(184, 29);
            zaloguj.TabIndex = 3;
            zaloguj.Text = "przejdź do logowania";
            zaloguj.UseVisualStyleBackColor = true;
            zaloguj.Click += this.zaloguj_Click;
            // 
            // aktywuj_konto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(zaloguj);
            Controls.Add(aktywuj_button);
            Controls.Add(kod_aktywacyjnyBox);
            Controls.Add(label1);
            Name = "aktywuj_konto";
            Size = new Size(253, 238);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox kod_aktywacyjnyBox;
        private Button aktywuj_button;
        private Button zaloguj;
    }
}
