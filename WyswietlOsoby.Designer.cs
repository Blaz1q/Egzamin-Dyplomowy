namespace egzamin_dyplomowy
{
    partial class WyswietlOsoby
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>

    
        private Button editButton;

        private void InitializeComponent()
        {
            nameLabel = new Label();
            editButton = new Button();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(10, 10);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(0, 15);
            nameLabel.TabIndex = 0;
            // 
            // editButton
            // 
            editButton.Location = new Point(288, 6);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 1;
            editButton.Text = "Edytuj";
            // 
            // WyswietlOsoby
            // 
            Controls.Add(nameLabel);
            Controls.Add(editButton);
            Name = "WyswietlOsoby";
            Size = new Size(626, 37);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Label nameLabel;
        //private Button btnEdit;

    }
}
