﻿using egzamin_dyplomowy.Properties;
namespace egzamin_dyplomowy
{
    partial class main_panel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CalendarButton = new RoundedButton();
            pytaniaButton = new RoundedButton();
            uzytkownicyButton = new RoundedButton();
            settingsButton = new RoundedButton();
            wylogujButton = new RoundedButton();
            panel2 = new Panel();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(54, 54, 54);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Controls.Add(wylogujButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(82, 593);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(CalendarButton);
            flowLayoutPanel1.Controls.Add(pytaniaButton);
            flowLayoutPanel1.Controls.Add(uzytkownicyButton);
            flowLayoutPanel1.Controls.Add(settingsButton);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 22);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(82, 318);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // CalendarButton
            // 
            CalendarButton.BackColor = Color.FromArgb(175, 232, 203);
            CalendarButton.BackgroundColor = Color.FromArgb(175, 232, 203);
            CalendarButton.BorderColor = Color.Transparent;
            CalendarButton.BorderRadius = 10;
            CalendarButton.BorderSize = 0;
            CalendarButton.Cursor = Cursors.Hand;
            CalendarButton.FlatAppearance.BorderSize = 0;
            CalendarButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(168, 206, 187);
            CalendarButton.FlatStyle = FlatStyle.Flat;
            CalendarButton.ForeColor = Color.White;
            CalendarButton.HoverColor = Color.FromArgb(168, 206, 187);
            CalendarButton.Image = Resources.Calendar;
            CalendarButton.Location = new Point(12, 3);
            CalendarButton.Margin = new Padding(12, 3, 3, 15);
            CalendarButton.Name = "CalendarButton";
            CalendarButton.Size = new Size(55, 55);
            CalendarButton.TabIndex = 1;
            CalendarButton.TextColor = Color.White;
            CalendarButton.TooltipText = "Kalendarz";
            CalendarButton.UseVisualStyleBackColor = false;
            CalendarButton.Click += CalendarButton_Click;
            // 
            // pytaniaButton
            // 
            pytaniaButton.BackColor = Color.Linen;
            pytaniaButton.BackgroundColor = Color.Linen;
            pytaniaButton.BorderColor = Color.Transparent;
            pytaniaButton.BorderRadius = 10;
            pytaniaButton.BorderSize = 0;
            pytaniaButton.Cursor = Cursors.Hand;
            pytaniaButton.FlatAppearance.BorderSize = 0;
            pytaniaButton.FlatStyle = FlatStyle.Flat;
            pytaniaButton.ForeColor = Color.White;
            pytaniaButton.HoverColor = Color.Transparent;
            pytaniaButton.Image = Resources.Book;
            pytaniaButton.Location = new Point(12, 76);
            pytaniaButton.Margin = new Padding(12, 3, 3, 15);
            pytaniaButton.Name = "pytaniaButton";
            pytaniaButton.Size = new Size(55, 55);
            pytaniaButton.TabIndex = 3;
            pytaniaButton.TextColor = Color.White;
            pytaniaButton.TooltipText = "Pytania";
            pytaniaButton.UseVisualStyleBackColor = false;
            pytaniaButton.Click += pytaniaButton_Click;
            // 
            // uzytkownicyButton
            // 
            uzytkownicyButton.BackColor = Color.Linen;
            uzytkownicyButton.BackgroundColor = Color.Linen;
            uzytkownicyButton.BorderColor = Color.Transparent;
            uzytkownicyButton.BorderRadius = 10;
            uzytkownicyButton.BorderSize = 0;
            uzytkownicyButton.Cursor = Cursors.Hand;
            uzytkownicyButton.FlatAppearance.BorderSize = 0;
            uzytkownicyButton.FlatStyle = FlatStyle.Flat;
            uzytkownicyButton.ForeColor = Color.White;
            uzytkownicyButton.HoverColor = Color.Transparent;
            uzytkownicyButton.Image = Resources.Icon;
            uzytkownicyButton.Location = new Point(12, 149);
            uzytkownicyButton.Margin = new Padding(12, 3, 3, 15);
            uzytkownicyButton.Name = "uzytkownicyButton";
            uzytkownicyButton.Size = new Size(55, 55);
            uzytkownicyButton.TabIndex = 2;
            uzytkownicyButton.TextColor = Color.White;
            uzytkownicyButton.TooltipText = "Użytkownicy";
            uzytkownicyButton.UseVisualStyleBackColor = false;
            uzytkownicyButton.Click += uzytkownicyButton_Click;
            // 
            // settingsButton
            // 
            settingsButton.BackColor = Color.Linen;
            settingsButton.BackgroundColor = Color.Linen;
            settingsButton.BorderColor = Color.Transparent;
            settingsButton.BorderRadius = 10;
            settingsButton.BorderSize = 0;
            settingsButton.Cursor = Cursors.Hand;
            settingsButton.FlatAppearance.BorderSize = 0;
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.ForeColor = Color.White;
            settingsButton.HoverColor = Color.Transparent;
            settingsButton.Image = Resources.Settings;
            settingsButton.Location = new Point(12, 222);
            settingsButton.Margin = new Padding(12, 3, 3, 15);
            settingsButton.Name = "settingsButton";
            settingsButton.Size = new Size(55, 55);
            settingsButton.TabIndex = 4;
            settingsButton.TextColor = Color.White;
            settingsButton.TooltipText = "Ustawienia";
            settingsButton.UseVisualStyleBackColor = false;
            // 
            // wylogujButton
            // 
            wylogujButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wylogujButton.BackColor = Color.Linen;
            wylogujButton.BackgroundColor = Color.Linen;
            wylogujButton.BorderColor = Color.Transparent;
            wylogujButton.BorderRadius = 10;
            wylogujButton.BorderSize = 0;
            wylogujButton.FlatAppearance.BorderSize = 0;
            wylogujButton.FlatStyle = FlatStyle.Flat;
            wylogujButton.ForeColor = Color.White;
            wylogujButton.HoverColor = Color.Transparent;
            wylogujButton.Image = Resources.Log_out;
            wylogujButton.Location = new Point(12, 523);
            wylogujButton.Margin = new Padding(3, 3, 3, 15);
            wylogujButton.Name = "wylogujButton";
            wylogujButton.Size = new Size(55, 55);
            wylogujButton.TabIndex = 5;
            wylogujButton.TextColor = Color.White;
            wylogujButton.TooltipText = "Wyloguj się";
            wylogujButton.UseVisualStyleBackColor = false;
            wylogujButton.Click += wylogujButton_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(82, 0);
            panel2.MinimumSize = new Size(500, 400);
            panel2.Name = "panel2";
            panel2.Size = new Size(920, 593);
            panel2.TabIndex = 1;
            // 
            // main_panel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 593);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(1020, 640);
            Name = "main_panel";
            Text = "Egzamin Dyplomowy - Panel";
            Load += main_panel_Load;
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private RoundedButton uzytkownicyButton;
        private RoundedButton CalendarButton;
        private RoundedButton pytaniaButton;
        private RoundedButton settingsButton;
        private RoundedButton wylogujButton;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}