using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    partial class ZaklepTermin
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
            lblSelectedDate.Size = new Size(83, 15);
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
            datePicker.Size = new Size(120, 25);
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
            lblSelectedTime.Size = new Size(102, 15);
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
            timePicker.Size = new Size(110, 25);
            timePicker.TabIndex = 1;
            // 
            // panelOccupied
            // 
            panelOccupied.BackColor = Color.LightGray;
            panelOccupied.Controls.Add(lblOccupied);
            panelOccupied.Controls.Add(flpOccupied);
            panelOccupied.CornerRadius = 40;
            panelOccupied.Location = new Point(116, 142);
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
            lblOccupied.Size = new Size(140, 15);
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
            btnSubmit.Location = new Point(116, 322);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(260, 30);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Zarezerwuj Termin";
            btnSubmit.UseVisualStyleBackColor = false;
            // 
            // ZaklepTermin
            // 
            BackColor = Color.Gray;
            ClientSize = new Size(499, 447);
            Controls.Add(panelDate);
            Controls.Add(panelTime);
            Controls.Add(panelOccupied);
            Controls.Add(btnSubmit);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ZaklepTermin";
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
    }
}