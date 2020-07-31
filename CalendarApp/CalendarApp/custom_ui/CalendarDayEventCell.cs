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
    public partial class CalendarDayEventCell : UserControl
    {
        public CalendarDayEventCell()
        {
            InitializeComponent();
        }

        private void CalendarDayEventCell_Load(object sender, EventArgs e)
        {
            
        }

        public string EventNameLabel {
            get {
                return this.event_name_label.Text;
            }
            set {
                this.event_name_label.Text = value;
            }
        }

        public string EventTime
        {
            get
            {
                return this.event_date_label.Text;
            }
            set
            {

                this.event_date_label.Text = value;

            }
        }

        public Button EditButton { get { return this.edit_event_button; } }
        public Button DeleteButton { get { return this.delete_event_buton; } }

        private void event_date_label_Click(object sender, EventArgs e)
        {

        }
    }
}
