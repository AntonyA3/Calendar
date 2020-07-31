using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Controls;
using Button = System.Windows.Forms.Button;
using System.Diagnostics;

namespace CalendarApp.custom_ui
{
    public partial class CalendarMonthView : System.Windows.Forms.UserControl
    {
        public CalendarMonthView()
        {
            InitializeComponent();
            this.dayCells = new List<CalendarMonthViewDayCell>();
            this.dayCells.Add(day_cell_1);
            this.dayCells.Add(day_cell_2);
            this.dayCells.Add(day_cell_3);
            this.dayCells.Add(day_cell_4);
            this.dayCells.Add(day_cell_5);
            this.dayCells.Add(day_cell_6);
            this.dayCells.Add(day_cell_7);
            this.dayCells.Add(day_cell_8);
            this.dayCells.Add(day_cell_9);
            this.dayCells.Add(day_cell_10);
            this.dayCells.Add(day_cell_11);
            this.dayCells.Add(day_cell_12);
            this.dayCells.Add(day_cell_13);
            this.dayCells.Add(day_cell_14);
            this.dayCells.Add(day_cell_15);
            this.dayCells.Add(day_cell_16);
            this.dayCells.Add(day_cell_17);
            this.dayCells.Add(day_cell_18);
            this.dayCells.Add(day_cell_19);
            this.dayCells.Add(day_cell_20);
            this.dayCells.Add(day_cell_21);
            this.dayCells.Add(day_cell_22);
            this.dayCells.Add(day_cell_23);
            this.dayCells.Add(day_cell_24);
            this.dayCells.Add(day_cell_25);
            this.dayCells.Add(day_cell_26);
            this.dayCells.Add(day_cell_27);
            this.dayCells.Add(day_cell_28);
            this.dayCells.Add(day_cell_29);
            this.dayCells.Add(day_cell_30);
            this.dayCells.Add(day_cell_31);
            this.dayCells.Add(day_cell_32);
            this.dayCells.Add(day_cell_33);
            this.dayCells.Add(day_cell_34);
            this.dayCells.Add(day_cell_35);

        
        }

        public System.Windows.Forms.Button ToYearViewButton {get{ return this.to_year_view_button; } }
        public Button ToPreviousMonthButton { get { return this.previous_month_button; } }
        public Button ToNextMonthButton { get { return this.next_month_button; } }
        public List<CalendarMonthViewDayCell> dayCells;
        public List<CalendarMonthViewDayCell> DayCells { get { return this.dayCells; } }

        public void SetMonthViewByDate(DateTime date)
        {
            var month_start_day_of_week = new DateTime(date.Year, date.Month, 1).DayOfWeek;
            if (date.Year > 1 || date.Month > 1) {
               
                var day_number = (int)month_start_day_of_week;
                if (month_start_day_of_week == DayOfWeek.Sunday) {
                    day_number = 7;
                } 
                
                var month_view_start_date = new DateTime(date.Year, date.Month, 1).AddDays(-day_number + 1);
                var view_day = month_view_start_date;

                this.dayCells.ForEach(d =>
                {
                    d.DayLabel = view_day.Day.ToString();
                    d.cellDateTime = view_day;
                    view_day = view_day.AddDays(1);
                });
            }
            
        }

        private void calendarMonthViewDayCell2_Load(object sender, EventArgs e)
        {

        }
    }
}
