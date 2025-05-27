using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace egzamin_dyplomowy
{

    public partial class TerminarzControl : UserControl
    {
        bool isHoursReady = false;
        private TimeOnly startHour = new TimeOnly(6,0);
        private TimeOnly endHour = new TimeOnly(18,0);
        private TimeOnly iteration = new TimeOnly(0,30); // 30 min
        private List<Termin> terminy = Dane.Terminy.getTerminy();
        private DateOnly currentdate = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        private DateOnly[] dates;
        internal class TerminyLocation
        {
            public int x;
            public int y;
            public TerminyLocation(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        private List<TerminyLocation> terminyData = new List<TerminyLocation>();
        public TerminarzControl()
        {
            InitializeComponent();
            initLabelsRow();
            initTimeColumn();
            initTerminy();
        }
        private TimeOnly RoundTimeToIteration(TimeOnly time)
        {
            int totalMinutes = time.Hour * 60 + time.Minute;
            int iterationMinutes = iteration.Hour * 60 + iteration.Minute;
            int roundedMinutes = (totalMinutes / iterationMinutes) * iterationMinutes;
            return TimeOnly.FromTimeSpan(TimeSpan.FromMinutes(roundedMinutes));
        }
        private int GetRowIndex(TimeOnly time)
        {
            int totalMinutes = time.Hour * 60 + time.Minute;
            int startMinutes = startHour.Hour * 60 + startHour.Minute;
            int iterationMinutes = iteration.Hour * 60 + iteration.Minute;
            return 1 + (totalMinutes - startMinutes) / iterationMinutes;
        }
        private Label addLabel(string labeltext)
        {
            Label newLabel = new Label();
            newLabel.Dock = DockStyle.Fill;
            newLabel.Location = new Point(3, 0);
            newLabel.Name = labeltext;
            newLabel.Size = new Size(65, 200);
            newLabel.TabIndex = 0;
            newLabel.Text = labeltext;
            newLabel.TextAlign = ContentAlignment.MiddleCenter;
            newLabel.BackColor = Color.White;
            return newLabel;
        }
        private void initTimeColumn() {
            for (TimeOnly i = startHour; i <= endHour; i = i.AddMinutes(iteration.Minute))
            {
                tableLayoutPanel1.RowCount++;
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40));
                tableLayoutPanel1.Controls.Add(addLabel(i.ToString()), 0, tableLayoutPanel1.RowCount - 1);
            }
            isHoursReady = true;
        }
        private void initLabelsRow()
        {
            // Remove previous header labels from row 0 (columns 1-7)
            for (int col = 1; col <= 7; col++)
            {
                Control ctrl = tableLayoutPanel1.GetControlFromPosition(col, 0);
                if (ctrl != null)
                {
                    tableLayoutPanel1.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
            }

            // Continue with date logic
            DayOfWeek currentDayOfWeek = (DayOfWeek)(((int)currentdate.DayOfWeek + 6) % 7); // Monday = 0
            DateOnly monday = currentdate.AddDays(-(int)currentDayOfWeek);

            dates = new DateOnly[7];
            string[] dni = { "pn", "wt", "sr", "czw", "pt", "sb", "nd" };

            for (int i = 0; i < dni.Length; i++)
            {
                dates[i] = monday.AddDays(i);
                tableLayoutPanel1.Controls.Add(addLabel(dni[i] + "\n" + dates[i].ToString("dd.MM")), i + 1, 0);
            }
        }
        public void initTerminy() {
            foreach (Termin termin in terminy)
            {
                if (dates == null) return;

                for (int i = 0; i < dates.Length; i++)
                {
                    if (termin.Data == dates[i])
                    {
                        displayEvent(termin);
                        //addEvent(termin.Egzamin.getProdziekan().GetNazwisko(), i, termin.GetStartTime());
                        break;
                    }
                }
            }
        }

        public void addEvent(string newevent, int day, TimeOnly time)
        {
            if (time < startHour || time > endHour) return; // time out of range
            if (string.IsNullOrWhiteSpace(newevent)) return; // bad event
            if (day < 0 || day > 6) return; // bad day
            if (!isHoursReady) return; // not ready yet

            TimeOnly roundedTime = RoundTimeToIteration(time);
            int rowIndex = GetRowIndex(roundedTime);
            int columnIndex = day + 1; // because column 0 is the hour column

            Label eventLabel = addLabel(newevent+" "+time.ToString());
            eventLabel.BackColor = Color.LightBlue; // make it visually different
            tableLayoutPanel1.Controls.Add(eventLabel, columnIndex, rowIndex);
            this.terminyData.Add(new TerminyLocation(columnIndex, rowIndex));
        }
        public void displayEvent(Termin termin) {
            if (!isHoursReady) return;

            DateOnly weekStart = _currentWeekStart;
            DateOnly weekEnd = weekStart.AddDays(6);

            if (termin.Data < weekStart || termin.Data > weekEnd)
                return;



            // Figure out which day column to put it in
            int dayIndex = (int)(termin.Data.DayOfWeek + 6) % 7;
            int columnIndex = dayIndex + 1;

            TimeOnly roundedTime = RoundTimeToIteration(termin.Godzina);
            int rowIndex = GetRowIndex(roundedTime);

            Label eventLabel = addLabel(
                termin.Egzamin.getStudent().nazwisko + "\n" +
                termin.Egzamin.GetSala() + "\n" +
                termin.Godzina.ToShortTimeString()
            );
            eventLabel.BackColor = Color.LightBlue;
            tableLayoutPanel1.Controls.Add(eventLabel, columnIndex, rowIndex);
            terminyData.Add(new TerminyLocation(columnIndex, rowIndex));
        }
        public void addEvent(Termin termin)
        {
            if (termin.Godzina < startHour || termin.Godzina > endHour)
                return;
            // Always save the termin to the data source
            Dane.Terminy.DodajTermin(termin);
            displayEvent(termin);
            // Only display the event if the week matches
            
        }
        private void clearTerminy()
        {
            foreach (TerminyLocation location in terminyData)
            {
                Control ctrl = tableLayoutPanel1.GetControlFromPosition(location.x, location.y);
                if (ctrl != null)
                {
                    tableLayoutPanel1.Controls.Remove(ctrl);
                    ctrl.Dispose(); // optional: free resources
                }
            }
            terminyData.Clear(); // clear the list for next batch of events
        }
        public void incrementWeek() { 
            if (!isHoursReady) return;
            clearTerminy();
            currentdate = currentdate.AddDays(7); // move to next week
            initLabelsRow(); // refresh the day/date labels
            initTerminy();   // re-add events for new week
        }
        public void decrementWeek()
        {
            if (!isHoursReady) return;

            clearTerminy();
            currentdate = currentdate.AddDays(-7); // go to previous week
            initLabelsRow(); // refresh the headers
            initTerminy();   // re-add the right events
        }
        private DateOnly _currentWeekStart = default;
        public void setWeek(DateOnly date)
        {
            if (!isHoursReady) return;
            // Calculate Monday of the given week
            int offset = (int)date.DayOfWeek - 1;
            if (offset < 0) offset = 6; // Sunday adjustment
            DateOnly weekStart = date.AddDays(-offset);

            // If we're already showing this week, do nothing
            if (_currentWeekStart == weekStart)
                return;

            // Update state and refresh week
            _currentWeekStart = weekStart;

            clearTerminy(); // Remove current events
            currentdate = date; // Set the date you want to base the week on
            initLabelsRow(); // Refresh day labels and calculate week from new date
            initTerminy();   // Load events for this new week
        }
    }
}
