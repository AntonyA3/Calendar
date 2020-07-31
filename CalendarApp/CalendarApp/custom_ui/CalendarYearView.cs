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
using System.Collections.ObjectModel;

namespace CalendarApp.custom_ui
{
    public partial class CalendarYearView : UserControl
    {
        private DateTime date;
        public DateTime Date {
            get {
                return this.date;

            } set {
                this.year_label.Text = "Year - " + value.Date.Year;
                this.date = value;
            }

        }

        public CalendarYearView()
        {
            InitializeComponent();
            var now = DateTime.Now;
            this.Date = new DateTime(now.Year, now.Month, 1, 0, 0, 0);

            this.month_buttons = new List<Button>();
            this.month_buttons.Add(january_button);
            this.month_buttons.Add(february_button);
            this.month_buttons.Add(march_button);
            this.month_buttons.Add(april_button);
            this.month_buttons.Add(may_button);
            this.month_buttons.Add(june_button);
            this.month_buttons.Add(july_button);
            this.month_buttons.Add(august_button);
            this.month_buttons.Add(september_button);
            this.month_buttons.Add(october_button);
            this.month_buttons.Add(november_button);
            this.month_buttons.Add(december_button);
           

        }
        private List<Button> month_buttons;
        public List<Button> MonthButtons{ get { return this.month_buttons; } }

        public Label YearLabel { get { return this.year_label; } }
        public Button NextYearButton { get { return this.next_year_button; } }
        public Button PreviousYearButton { get { return this.previous_year_button; } }
      
        
    }
}
