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
    public partial class CalendarMonthViewDayCell : UserControl
    {
        public CalendarMonthViewDayCell()
        {
            InitializeComponent();
        }

        public DateTime cellDateTime;
        public DateTime CellDateTime {
            get { return this.cellDateTime; }
            set { this.cellDateTime = value; }
        }
        public string DayLabel {
            set {
                this.day_label.Text = value;
            }
            get {
                return this.day_label.Text;
            }
        }
    }
}
