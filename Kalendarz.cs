using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace egzamin_dyplomowy
{
    public partial class Kalendarz : UserControl
    {
        public static int _Month, _Year;
        public int _selectedDay = 0;
        public int _selectedMonth = 0;
        public int _selectedYear = 0;
        public Kalendarz()
        {
            InitializeComponent();
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
        private void showDays(int month, int year)
        {
            _Year = year;
            _Month = month;

            DateTime start = new DateTime(year, month, 1);
            int daysInMonth = DateTime.DaysInMonth(year, month);
            int startDay = (int)start.DayOfWeek;
            startDay = (startDay == 0) ? 6 : startDay - 1; // Convert so Monday = 0

            label8.Text = start.ToString("MMMM", CultureInfo.InvariantCulture) + " " + _Year;

            DateTime prevMonthStart = start.AddMonths(-1);
            int daysInPrevMonth = DateTime.DaysInMonth(prevMonthStart.Year, prevMonthStart.Month);

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.Controls.Add(addLabel("pn"), 0, 0);
            tableLayoutPanel1.Controls.Add(addLabel("wt"), 1, 0);
            tableLayoutPanel1.Controls.Add(addLabel("sr"), 2, 0);
            tableLayoutPanel1.Controls.Add(addLabel("czw"), 3, 0);
            tableLayoutPanel1.Controls.Add(addLabel("pt"), 4, 0);
            tableLayoutPanel1.Controls.Add(addLabel("sb"), 5, 0);
            tableLayoutPanel1.Controls.Add(addLabel("nd"), 6, 0);

            tableLayoutPanel1.RowCount += 1;
            int counter = 0;

            // Fill in previous month's tail days (faded)
            for (int i = 0; i < startDay; i++)
            {
                int dayNumber = daysInPrevMonth - startDay + i + 1;
                DateOnly date = new DateOnly(prevMonthStart.Year, prevMonthStart.Month, dayNumber);
                var dzien = new KalendarzDzien(date, faded: true);
                dzien.Dock = DockStyle.Fill;
                dzien.OnDateClicked += HandleDayClick; // optional if you need to handle clicks
                tableLayoutPanel1.Controls.Add(dzien, i, tableLayoutPanel1.RowCount - 1);
                counter++;
            }

            // Fill in current month days
            for (int i = 1; i <= daysInMonth; i++)
            {
                if (counter == 7)
                {
                    counter = 0;
                    tableLayoutPanel1.RowCount += 1;
                }

                DateOnly date = new DateOnly(year, month, i);
                var dzien = new KalendarzDzien(date);
                dzien.Dock = DockStyle.Fill;
                dzien.OnDateClicked += HandleDayClick;
                tableLayoutPanel1.Controls.Add(dzien, counter, tableLayoutPanel1.RowCount - 1);
                counter++;
            }

            // Fill in next month's leading days (faded)
            int nextMonth = (month == 12) ? 1 : month + 1;
            int nextYear = (month == 12) ? year + 1 : year;
            int nextDay = 1;

            while (counter != 0 && counter < 7)
            {
                DateOnly date = new DateOnly(nextYear, nextMonth, nextDay++);
                var dzien = new KalendarzDzien(date, faded: true);
                dzien.Dock = DockStyle.Fill;
                dzien.OnDateClicked += HandleDayClick;
                tableLayoutPanel1.Controls.Add(dzien, counter, tableLayoutPanel1.RowCount - 1);
                counter++;
            }

            // Adjust row heights (optional but nice)
            for (int i = 0; i < tableLayoutPanel1.RowCount; i++)
            {
                if (i >= tableLayoutPanel1.RowStyles.Count)
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
                else
                    tableLayoutPanel1.RowStyles[i] = new RowStyle(SizeType.Percent, 100);
            }

            Debug.WriteLine("rows:" + tableLayoutPanel1.RowCount);
            Debug.WriteLine("cols:" + tableLayoutPanel1.ColumnCount);
        }



        private void Kalendarz2_Load(object sender, EventArgs e)
        {
            Debug.WriteLine("month:" + DateTime.Now.Month);
            Debug.WriteLine("year:" + DateTime.Now.Year);
            showDays(DateTime.Now.Month, DateTime.Now.Year);
            DateTime current = DateTime.Now;
            _selectedDay = current.Day;
            _selectedMonth = current.Month;
            _selectedYear = current.Year;
            selectDayControl();

        }
        public void selectDayControl()
        {
            KalendarzDzien dzien = GetDayControlByDate(new DateOnly(_selectedYear, _selectedMonth, _selectedDay));
            dzien.Select();
        }
        private KalendarzDzien GetDayControlByDate(DateOnly date)
        {
            DateOnly firstOfMonth = new DateOnly(_Year, _Month, 1);
            int startDay = (int)firstOfMonth.DayOfWeek;
            startDay = (startDay == 0) ? 6 : startDay - 1;

            // Days from previous month shown in current calendar
            int offset = startDay;

            // Calculate index of date being searched
            int dayIndex = (date.Day + offset - 1); // zero-based index
            int row = 1 + (dayIndex / 7); // +1 because row 0 is header
            int col = (dayIndex % 7);

            Control control = tableLayoutPanel1.GetControlFromPosition(col, row);
            return control as KalendarzDzien;
        }
        public event Action<DateOnly> OnDateClicked;
        public void selectDate(DateOnly date)
        {
            if (_selectedDay != 0)
            {
                DateOnly prevSelectedDate = new DateOnly(_Year, _Month, _selectedDay);
                var prevControl = GetDayControlByDate(prevSelectedDate);
                prevControl?.ResetSelection();
            }
            _selectedDay = date.Day;
            _selectedMonth = date.Month;
            _selectedYear = date.Year;
        }
        private void HandleDayClick(DateOnly clickedDate)
        {
            selectDate(clickedDate);
            OnDateClicked?.Invoke(clickedDate);
            //terminarzControl.SetWeek(clickedDate); // for example
        }
        public void incrementMonth()
        {
            _Month++;
            if (_Month > 12)
            {
                _Month = 1;
                _Year++;
            }
            showDays(_Month, _Year);
            if (_selectedMonth == _Month && _selectedYear == _Year)
            {
                selectDayControl();
            }
        }
        public void decrementMonth()
        {
            _Month--;
            if (_Month < 1)
            {
                _Month = 12;
                _Year--;
            }
            showDays(_Month, _Year);
            if (_selectedMonth == _Month && _selectedYear == _Year)
            {
                selectDayControl();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            incrementMonth();  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            decrementMonth();
        }
    }
}
