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

namespace CalendarApp
{
    public partial class CalendarAppRootPanel : Form
    {
        public CalendarAppRootPanel()
        {
            InitializeComponent();
            this.start_time_date_picker.Value = DateTime.Now;
            this.startTime = DateTime.Now;
            this.end_time_date_picker.Value = DateTime.Now.AddHours(1);
            this.endTime = DateTime.Now.AddHours(1);


            input_validity();


        }

        private void MonthPlannerView1_DateChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.eventName = this.event_name_text_box.Text;
            this.startTime = this.start_time_date_picker.Value;
            this.endTime = this.end_time_date_picker.Value;
            this.eventPriority = this.priority_combo_box.Text;
            this.eventType = this.event_type_combo_box.Text;
            this.repettion = this.event_type_combo_box.Text;
            var success = controller.CreateEvent(eventName, startTime, endTime, eventType, eventPriority, repettion);
            if (success) {
                this.calendarView1.AddCalendarEvents(controller.GetRecentlyCreatedEvent);

            }
        }

 

        private string eventName;
        private string repettion;
        private string eventPriority;
        private string eventType;
        private DateTime startTime;
        private DateTime endTime;

        public void AddCalenderEvent(CalendarEvent ev) {
            this.calendarView1.AddCalendarEvents(ev);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            eventName = this.event_name_text_box.Text;

        }
        private void input_validity() {

            if (end_time_date_picker.Value > start_time_date_picker.Value)
            {
                this.add_event_button.Enabled = true;
            }
            else {
                this.add_event_button.Enabled = false;
            }
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
            this.startTime = start_time_date_picker.Value;
            input_validity();
            
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.endTime = end_time_date_picker.Value;
            input_validity();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.eventPriority = priority_combo_box.Text;
            input_validity();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.eventType = event_type_combo_box.Text;
            input_validity();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.repettion = every_combo_box.Text;
            input_validity();
        }

    
        private void dateTimePicker1_Enter(object sender, EventArgs e)
        {  
            
            this.startTime = start_time_date_picker.Value;

            input_validity();

        }

        private void dateTimePicker2_Enter(object sender, EventArgs e)
        {
            this.endTime = end_time_date_picker.Value;
            input_validity();
        }

        private void event_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void calendar_element_DateChanged(object sender, DateRangeEventArgs e)
        {
           


            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void monthPlannerView1_Load(object sender, EventArgs e)
        {

        }

        private void calendarView1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
