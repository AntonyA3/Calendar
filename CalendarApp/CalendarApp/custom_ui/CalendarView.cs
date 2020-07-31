using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace CalendarApp.custom_ui
{
    public partial class CalendarView : UserControl
    {
        public CalendarView()
        {
            InitializeComponent();
            this.calendarYearView1.MonthButtons.ForEach(b =>
            {
                b.Click += Month_Button_Click;
            });
            this.calendarYearView1.NextYearButton.Click += NextYearButton_Click;
            this.calendarYearView1.PreviousYearButton.Click += PreviousYearButton_Click;
            
            this.calendarMonthView1.Visible = false;
            this.calendarMonthView1.ToYearViewButton.Click += ToYearViewButton_Click;
            this.calendarMonthView1.ToNextMonthButton.Click += ToNextMonthButton_Click;
            this.calendarMonthView1.ToPreviousMonthButton.Click += ToPreviousMonthButton_Click;

            this.calendarMonthView1.dayCells.ForEach(d =>
            {
                d.Click += Date_Click;
            });
            this.DateTimeValue = DateTime.Now;

            this.calendarDayView1.ToMonthViewButton.Click += ToMonthViewButton_Click;
            this.calendarDayView1.ToPreviousDayButton.Click += ToPreviousDayButton_Click;
            this.calendarDayView1.ToNextDayButton.Click += ToNextDayButton_Click;

        

            this.calendarMonthView1.Visible = true;
            this.calendarDayView1.Visible = false;
            this.calendarYearView1.Visible = false;
            this.calendarMonthView1.ResumeLayout();
            this.calendarDayView1.SuspendLayout();
            this.calendarYearView1.SuspendLayout();
        }

        private void ToNextDayButton_Click(object sender, EventArgs e)
        {
            this.DateTimeValue = this.dateValue.AddDays(1);
        }

        private void ToPreviousDayButton_Click(object sender, EventArgs e)
        {
            this.DateTimeValue = this.dateValue.AddDays(-1);

        }

        private void ToMonthViewButton_Click(object sender, EventArgs e)
        {
            this.calendarMonthView1.Visible = true;
            this.calendarMonthView1.ResumeLayout();
            this.calendarDayView1.Visible = false;
            this.calendarDayView1.SuspendLayout();
        }

        private void Date_Click(object sender, EventArgs e)
        {
            var dateCell = (CalendarMonthViewDayCell)sender;
            this.DateTimeValue = dateCell.CellDateTime;
            this.calendarMonthView1.SuspendLayout();
            this.calendarMonthView1.Visible = false;
            this.calendarYearView1.SuspendLayout();
            this.calendarYearView1.Visible = false;
            this.calendarDayView1.ResumeLayout();
            this.calendarDayView1.Visible = true;
        }

        private void ToPreviousMonthButton_Click(object sender, EventArgs e)
        {
            if (this.DateTimeValue.Year > 1 || this.DateTimeValue.Month > 1) {
                this.DateTimeValue = this.DateTimeValue.AddMonths(-1);

            }

        }

        private void ToNextMonthButton_Click(object sender, EventArgs e)
        {
            if (this.DateTimeValue.Year < 9999 || this.DateTimeValue.Month < 12)
            {
                this.DateTimeValue = this.DateTimeValue.AddMonths(1);
            }
        }

        private void PreviousYearButton_Click(object sender, EventArgs e)
        {
            if (this.DateTimeValue.Year > 1) {
                this.DateTimeValue = this.DateTimeValue.AddYears(-1);
            }
        }

        private void NextYearButton_Click(object sender, EventArgs e)
        {
            if (this.DateTimeValue.Year < 9999)
            {
                this.DateTimeValue = this.DateTimeValue.AddYears(1);
            }
        }

        private void ToYearViewButton_Click(object sender, EventArgs e)
        {
            this.calendarMonthView1.SuspendLayout();
            this.calendarMonthView1.Visible = false;
            this.calendarDayView1.SuspendLayout();
            this.calendarDayView1.Visible = false;
            this.calendarYearView1.ResumeLayout();
            this.calendarYearView1.Visible = true;
        }

        /// <summary>
        ///     This method switches the view to the month view, sets the date to the month selected
        ///     
        /// 
        /// </summary>
        /// <param name="sender"> button that represents a month in the year</param>
        /// <param name="e">event arguments, this event has no event arguments</param>
        private void Month_Button_Click(object sender, EventArgs e)
        {

            this.calendarYearView1.SuspendLayout();
            this.calendarYearView1.Visible = false;
            this.calendarDayView1.SuspendLayout();
            this.calendarDayView1.Visible = false;
            this.calendarMonthView1.ResumeLayout();
            this.calendarMonthView1.Visible = true;
            var button = (Button)sender;
            var month = this.calendarYearView1.MonthButtons.FindIndex((b => {
                return button.Equals(b);
            })) + 1;
            
            var day = Math.Min(this.dateValue.Day, DateTime.DaysInMonth(this.dateValue.Year, month));
            this.DateTimeValue = new DateTime(this.dateValue.Year, month, day, this.dateValue.Hour, this.dateValue.Minute, this.dateValue.Second, this.dateValue.Millisecond);



        }


        private DateTime dateValue;
        public DateTime DateTimeValue {
            get {
                return dateValue;
            }
            set {
                this.calendarYearView1.YearLabel.Text = "Year" + " - " + value.Year.ToString();
                this.calendarMonthView1.ToYearViewButton.Text = value.Year + " - " + month_short_name(value.Month);
                this.calendarDayView1.ToMonthViewButton.Text = value.Year + " - " + month_short_name(value.Month) + " - " + value.Day;
                if (value.Month != this.dateValue.Month) {
                    this.calendarMonthView1.SetMonthViewByDate(value);
                }

                this.dateValue = value;
                update_calendar_events();

            }

        }
      
        private List<CalendarEvent> calendarEvents = new List<CalendarEvent>();
        public void SetCalendarEvents(List<CalendarEvent> calendarEvents) {
            this.calendarEvents = calendarEvents;

            update_calendar_events();

        }

        public void AddCalendarEvents(CalendarEvent calendarEvent) {
            this.calendarEvents.Add(calendarEvent);
           
            update_calendar_events();

        }

        private void update_calendar_events() {
            this.calendarEvents.Sort((e1, e2) =>
            {
                return e1.StartTime.CompareTo(e2.StartTime);
            });
            this.calendarMonthView1.DayCells.ForEach(cell =>
            {
                cell.BackColor = Color.White;
                calendarEvents.ForEach(ce =>
                {
                    if (ce.StartTime.Date == cell.CellDateTime.Date)
                    {
                        cell.BackColor = Color.Blue;
                    }
                });
            });

            var events_list_view = this.calendarDayView1.EventTablePanel;
            events_list_view.Controls.Clear();
            events_list_view.RowCount = 1;
            
            this.calendarEvents.ForEach(e =>
            {

            if (
            e.StartTime.Year == this.DateTimeValue.Year &&
            e.StartTime.Month == this.DateTimeValue.Month &&
            e.StartTime.Day == this.DateTimeValue.Day
                ) {
                    if (events_list_view.RowCount < 3)
                    {
                        var ev = new CalendarDayEventCell();
                        ev.EventNameLabel = e.EventName;
                        ev.EventTime = e.StartTime.ToShortTimeString() + " - " + e.EndTime.ToShortTimeString();
                        events_list_view.Controls.Add(ev, 0, 0);
                        events_list_view.RowCount += 1;
                    }
                    else {
                        events_list_view.RowStyles.Add(new RowStyle(
                        events_list_view.RowStyles[0].SizeType, 
                        events_list_view.RowStyles[0].Height));

                        var ev = new CalendarDayEventCell();
                        ev.EventNameLabel = e.EventName;
                        ev.EventTime = e.StartTime.ToShortTimeString() + " - " + e.EndTime.ToShortTimeString();

                        events_list_view.Controls.Add(ev, 0, events_list_view.RowCount - 1);
                        events_list_view.RowCount += 1;
                    }


                }
            });
        }
       

        private string month_short_name(int month)
        {
            switch (month) {
                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                case 4:
                    return "Apr";
                case 5:
                    return "May";
                case 6:
                    return "Jun";
                case 7:
                    return "Jul";
                case 8:
                    return "Aug";
                case 9:
                    return "Sept";
                case 10:
                    return "Oct";
                case 11:
                    return "Nov";
                case 12:
                    return "Dec";
                default:
                    return null;

            }
        }

        private void calendarYearView1_Load(object sender, EventArgs e)
        {

        }

        private void calendarYearView1_Load_1(object sender, EventArgs e)
        {
         
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calendarYearView1_Load_2(object sender, EventArgs e)
        {

        }

        private void calendarMonthView1_Load(object sender, EventArgs e)
        {

        }

        private void calendarDayView1_Load(object sender, EventArgs e)
        {

        }
    }
}
