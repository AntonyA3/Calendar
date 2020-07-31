namespace CalendarApp.custom_ui
{
    partial class CalendarView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.calendarDayView1 = new CalendarApp.custom_ui.CalendarDayView();
            this.calendarMonthView1 = new CalendarApp.custom_ui.CalendarMonthView();
            this.calendarYearView1 = new CalendarApp.custom_ui.CalendarYearView();
            this.SuspendLayout();
            // 
            // calendarDayView1
            // 
            this.calendarDayView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarDayView1.Location = new System.Drawing.Point(3, 3);
            this.calendarDayView1.Name = "calendarDayView1";
            this.calendarDayView1.Size = new System.Drawing.Size(753, 355);
            this.calendarDayView1.TabIndex = 2;
            this.calendarDayView1.Load += new System.EventHandler(this.calendarDayView1_Load);
            // 
            // calendarMonthView1
            // 
            this.calendarMonthView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarMonthView1.Location = new System.Drawing.Point(3, 3);
            this.calendarMonthView1.Name = "calendarMonthView1";
            this.calendarMonthView1.Size = new System.Drawing.Size(753, 355);
            this.calendarMonthView1.TabIndex = 1;
            this.calendarMonthView1.Load += new System.EventHandler(this.calendarMonthView1_Load);
            // 
            // calendarYearView1
            // 
            this.calendarYearView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarYearView1.Date = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            this.calendarYearView1.Location = new System.Drawing.Point(3, 3);
            this.calendarYearView1.Name = "calendarYearView1";
            this.calendarYearView1.Size = new System.Drawing.Size(753, 355);
            this.calendarYearView1.TabIndex = 0;
            this.calendarYearView1.Load += new System.EventHandler(this.calendarYearView1_Load_2);
            // 
            // CalendarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.calendarDayView1);
            this.Controls.Add(this.calendarMonthView1);
            this.Controls.Add(this.calendarYearView1);
            this.Name = "CalendarView";
            this.Size = new System.Drawing.Size(759, 361);
            this.ResumeLayout(false);

        }

        #endregion

        private CalendarYearView calendarYearView1;
        private CalendarMonthView calendarMonthView1;
        private CalendarDayView calendarDayView1;
    }
}
