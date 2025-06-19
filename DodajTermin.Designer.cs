using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    partial class DodajTermin
    {
        private RoundedPanel panelDate;
        private Label lblSelectedDate;
        private DateTimePicker datePicker;
        private RoundedPanel panelTime;
        private Label lblSelectedTime;
        private DateTimePicker timePicker;
        private RoundedPanel panelOccupied;
        private Label lblOccupied;
        private FlowLayoutPanel flpOccupied;
        private Button btnSubmit;

        private void InitializeComponent()
        {
            panelDate = new RoundedPanel();
            lblSelectedDate = new Label();
            datePicker = new DateTimePicker();
            panelTime = new RoundedPanel();
            lblSelectedTime = new Label();
            timePicker = new DateTimePicker();
            panelOccupied = new RoundedPanel();
            lblOccupied = new Label();
            flpOccupied = new FlowLayoutPanel();
            btnSubmit = new Button();
            dodajEgz = new Button();
            cmbEgzamin = new RoundedComboBox();
            panelDate.SuspendLayout();
            panelTime.SuspendLayout();
            panelOccupied.SuspendLayout();
            SuspendLayout();
            // 
            // panelDate
            // 
            panelDate.BackColor = Color.LightGray;
            panelDate.Controls.Add(lblSelectedDate);
            panelDate.Controls.Add(datePicker);
            panelDate.CornerRadius = 40;
            panelDate.Location = new Point(116, 12);
            panelDate.Name = "panelDate";
            panelDate.Size = new Size(260, 50);
            panelDate.TabIndex = 0;
            // 
            // lblSelectedDate
            // 
            lblSelectedDate.AutoSize = true;
            lblSelectedDate.BackColor = Color.LightGray;
            lblSelectedDate.Location = new Point(5, 16);
            lblSelectedDate.Name = "lblSelectedDate";
            lblSelectedDate.Size = new Size(105, 20);
            lblSelectedDate.TabIndex = 0;
            lblSelectedDate.Text = "Wybrana data:";
            // 
            // datePicker
            // 
            datePicker.BackColor = Color.LightGray;
            datePicker.CalendarMonthBackground = Color.Transparent;
            datePicker.CustomFormat = "yyyy-MM-dd";
            datePicker.Enabled = false;
            datePicker.Font = new Font("Segoe UI", 9.75F);
            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.Location = new Point(130, 12);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(120, 29);
            datePicker.TabIndex = 1;
            // 
            // panelTime
            // 
            panelTime.BackColor = Color.LightGray;
            panelTime.Controls.Add(lblSelectedTime);
            panelTime.Controls.Add(timePicker);
            panelTime.CornerRadius = 40;
            panelTime.Location = new Point(116, 72);
            panelTime.Name = "panelTime";
            panelTime.Size = new Size(260, 50);
            panelTime.TabIndex = 1;
            // 
            // lblSelectedTime
            // 
            lblSelectedTime.AutoSize = true;
            lblSelectedTime.BackColor = Color.LightGray;
            lblSelectedTime.Location = new Point(5, 17);
            lblSelectedTime.Name = "lblSelectedTime";
            lblSelectedTime.Size = new Size(129, 20);
            lblSelectedTime.TabIndex = 0;
            lblSelectedTime.Text = "Wybrana godzina:";
            // 
            // timePicker
            // 
            timePicker.BackColor = Color.LightGray;
            timePicker.CalendarMonthBackground = Color.Transparent;
            timePicker.CalendarTitleBackColor = Color.Transparent;
            timePicker.CalendarTrailingForeColor = Color.Transparent;
            timePicker.CustomFormat = "HH:mm";
            timePicker.Font = new Font("Segoe UI", 9.75F);
            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.Location = new Point(140, 12);
            timePicker.Name = "timePicker";
            timePicker.ShowUpDown = true;
            timePicker.Size = new Size(110, 29);
            timePicker.TabIndex = 1;
            // 
            // panelOccupied
            // 
            panelOccupied.BackColor = Color.LightGray;
            panelOccupied.Controls.Add(lblOccupied);
            panelOccupied.Controls.Add(flpOccupied);
            panelOccupied.CornerRadius = 40;
            panelOccupied.Location = new Point(116, 182);
            panelOccupied.Name = "panelOccupied";
            panelOccupied.Size = new Size(260, 165);
            panelOccupied.TabIndex = 3;
            // 
            // lblOccupied
            // 
            lblOccupied.AutoSize = true;
            lblOccupied.BackColor = Color.LightGray;
            lblOccupied.Location = new Point(5, 8);
            lblOccupied.Name = "lblOccupied";
            lblOccupied.Size = new Size(179, 20);
            lblOccupied.TabIndex = 0;
            lblOccupied.Text = "Zajęte godziny tego dnia:";
            // 
            // flpOccupied
            // 
            flpOccupied.AutoScroll = true;
            flpOccupied.BackColor = Color.LightGray;
            flpOccupied.Location = new Point(5, 30);
            flpOccupied.Name = "flpOccupied";
            flpOccupied.Size = new Size(250, 125);
            flpOccupied.TabIndex = 1;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSubmit.ForeColor = Color.Black;
            btnSubmit.Location = new Point(116, 357);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(260, 30);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Zatwierdź";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // dodajEgz
            // 
            dodajEgz.BackColor = Color.Transparent;
            dodajEgz.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dodajEgz.ForeColor = Color.Black;
            dodajEgz.Location = new Point(116, 393);
            dodajEgz.Name = "dodajEgz";
            dodajEgz.Size = new Size(260, 30);
            dodajEgz.TabIndex = 5;
            dodajEgz.Text = "Dodaj Egzamin";
            dodajEgz.UseVisualStyleBackColor = false;
            dodajEgz.Click += dodajEgz_Click;
            // 
            // cmbEgzamin
            // 
            cmbEgzamin.ActiveBorderColor = Color.DodgerBlue;
            cmbEgzamin.ArrowColor = Color.FromArgb(100, 100, 100);
            cmbEgzamin.BorderColor = Color.FromArgb(220, 220, 220);
            cmbEgzamin.BorderThickness = 1;
            cmbEgzamin.CornerRadius = 8;
            cmbEgzamin.DrawMode = DrawMode.OwnerDrawFixed;
            cmbEgzamin.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEgzamin.FillColor = Color.LightGray;
            cmbEgzamin.Location = new Point(116, 142);
            cmbEgzamin.Name = "cmbEgzamin";
            cmbEgzamin.Placeholder = "Egzamin";
            cmbEgzamin.Size = new Size(260, 28);
            cmbEgzamin.TabIndex = 2;
            // 
            // DodajTermin
            // 
            BackColor = Color.Gray;
            ClientSize = new Size(499, 447);
            Controls.Add(dodajEgz);
            Controls.Add(panelDate);
            Controls.Add(panelTime);
            Controls.Add(cmbEgzamin);
            Controls.Add(panelOccupied);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DodajTermin";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Dodaj termin egzaminu";
            panelDate.ResumeLayout(false);
            panelDate.PerformLayout();
            panelTime.ResumeLayout(false);
            panelTime.PerformLayout();
            panelOccupied.ResumeLayout(false);
            panelOccupied.PerformLayout();
            ResumeLayout(false);
        }

        private Button dodajEgz;
        private RoundedComboBox cmbEgzamin;
    }
}