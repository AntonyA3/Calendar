using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp.custom_ui
{
    public partial class CalendarDayView : UserControl
    {
        public CalendarDayView()
        {
            InitializeComponent();
            
        }
        
        public Button ToMonthViewButton { get { return this.to_month_view_button; } }
        public Button ToPreviousDayButton { get { return this.to_previous_day_button; } }
        public Button ToNextDayButton { get { return this.to_next_day_button; } }
        public TableLayoutPanel EventTablePanel { get { return this.events_table_panel; } }
    }
}
