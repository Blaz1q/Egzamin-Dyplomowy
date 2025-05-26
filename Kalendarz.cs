using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{


    public partial class Kalendarz : UserControl
    {
        private TableLayoutPanel scheduler;
        private readonly TimeSpan[] TimeSlots = Enumerable.Range(0, (21 - 6) * 2 + 1)
    .Select(i => new TimeSpan(6, 0, 0).Add(TimeSpan.FromMinutes(30 * i)))
    .ToArray();
        public Kalendarz()
        {
            InitializeScheduler();
        }

        private void InitializeScheduler()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint, true);
            this.UpdateStyles();
            this.BackColor = Color.White;
            this.Dock = DockStyle.Fill;

            // 👇 Scrollable container panel
            var scrollPanel = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true
            };

            scheduler = new TableLayoutPanel
            {
                RowCount = 1,
                ColumnCount = 3, // Time + 2 days
                AutoSize = true, // Needed for scroll container
                CellBorderStyle = TableLayoutPanelCellBorderStyle.Single
            };

            // Set column styles
            scheduler.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60)); // Time
            scheduler.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));  // Day 1
            scheduler.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));  // Day 2
            // Set row styles
            scheduler.RowStyles.Add(new RowStyle(SizeType.Absolute, 30)); // Header row

            // Add header labels
            scheduler.Controls.Add(CreateHeaderLabel(""), 0, 0);
            scheduler.Controls.Add(CreateHeaderLabel("April, Mon 27"), 1, 0);
            scheduler.Controls.Add(CreateHeaderLabel("April, Tue 28"), 2, 0);

            // Time column + empty event slots
            for (int i = 0; i < TimeSlots.Length; i++)
            {
                scheduler.RowCount++;
                scheduler.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                scheduler.Controls.Add(CreateTimeLabel(TimeSlots[i]), 0, scheduler.RowCount - 1);
            }

            scrollPanel.Controls.Add(scheduler);
            this.Controls.Add(scrollPanel);
        }

        private Label CreateHeaderLabel(string text)
        {
            return new Label
            {
                Text = text,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                BackColor = Color.LightGray
            };
        }

        private Label CreateTimeLabel(TimeSpan time)
        {
            return new Label
            {
                Text = time.ToString(@"hh\:mm"),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleRight,
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                Padding = new Padding(0, 0, 5, 0),
                BackColor = Color.WhiteSmoke
            };
        }

        public void AddEvent(int dayColumn, TimeSpan time, string text, Color color)
        {
            int rowIndex = Array.FindIndex(TimeSlots, t => t == time);

            if (rowIndex == -1 || dayColumn < 1 || dayColumn >= scheduler.ColumnCount)
                throw new ArgumentException("Invalid time or dayColumn.");

            rowIndex += 1; // Adjust for header row

            var eventPanel = new Panel
            {
                BackColor = color,
                Dock = DockStyle.Fill,
                Margin = new Padding(1)
            };

            eventPanel.Controls.Add(new Label
            {
                Text = time.ToString() + "\n" + text,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 8, FontStyle.Bold)
            });

            scheduler.Controls.Add(eventPanel, dayColumn, rowIndex);
        }
    }
}