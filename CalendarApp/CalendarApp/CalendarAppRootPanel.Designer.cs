using System;
using System.Collections.Generic;

namespace CalendarApp
{
    partial class CalendarAppRootPanel
    {
        /// <summary>
        /// A reference to the controller
        /// </summary>
        private CalendarController controller;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarAppRootPanel));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.add_event_button = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.event_name_label = new System.Windows.Forms.Label();
            this.start_time_label = new System.Windows.Forms.Label();
            this.end_time_label = new System.Windows.Forms.Label();
            this.priority_label = new System.Windows.Forms.Label();
            this.event_type_label = new System.Windows.Forms.Label();
            this.every_label = new System.Windows.Forms.Label();
            this.event_name_text_box = new System.Windows.Forms.TextBox();
            this.start_time_date_picker = new System.Windows.Forms.DateTimePicker();
            this.end_time_date_picker = new System.Windows.Forms.DateTimePicker();
            this.priority_combo_box = new System.Windows.Forms.ComboBox();
            this.event_type_combo_box = new System.Windows.Forms.ComboBox();
            this.every_combo_box = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.calendarEventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.calendarView1 = new CalendarApp.custom_ui.CalendarView();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calendarEventBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 22);
            this.toolStripButton1.Text = "File";
            // 
            // add_event_button
            // 
            this.add_event_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_event_button.Location = new System.Drawing.Point(75, 175);
            this.add_event_button.Name = "add_event_button";
            this.add_event_button.Size = new System.Drawing.Size(121, 33);
            this.add_event_button.TabIndex = 2;
            this.add_event_button.Tag = "";
            this.add_event_button.Text = "Add Event";
            this.add_event_button.UseVisualStyleBackColor = true;
            this.add_event_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // event_name_label
            // 
            this.event_name_label.AutoSize = true;
            this.event_name_label.Location = new System.Drawing.Point(7, 18);
            this.event_name_label.Name = "event_name_label";
            this.event_name_label.Size = new System.Drawing.Size(66, 13);
            this.event_name_label.TabIndex = 4;
            this.event_name_label.Text = "Event Name";
            // 
            // start_time_label
            // 
            this.start_time_label.AutoSize = true;
            this.start_time_label.Location = new System.Drawing.Point(7, 46);
            this.start_time_label.Name = "start_time_label";
            this.start_time_label.Size = new System.Drawing.Size(55, 13);
            this.start_time_label.TabIndex = 5;
            this.start_time_label.Text = "Start Time";
            // 
            // end_time_label
            // 
            this.end_time_label.AutoSize = true;
            this.end_time_label.Location = new System.Drawing.Point(6, 72);
            this.end_time_label.Name = "end_time_label";
            this.end_time_label.Size = new System.Drawing.Size(52, 13);
            this.end_time_label.TabIndex = 6;
            this.end_time_label.Text = "End Time";
            // 
            // priority_label
            // 
            this.priority_label.AutoSize = true;
            this.priority_label.Location = new System.Drawing.Point(7, 98);
            this.priority_label.Name = "priority_label";
            this.priority_label.Size = new System.Drawing.Size(38, 13);
            this.priority_label.TabIndex = 7;
            this.priority_label.Text = "Priority";
            // 
            // event_type_label
            // 
            this.event_type_label.AutoSize = true;
            this.event_type_label.Location = new System.Drawing.Point(7, 125);
            this.event_type_label.Name = "event_type_label";
            this.event_type_label.Size = new System.Drawing.Size(62, 13);
            this.event_type_label.TabIndex = 8;
            this.event_type_label.Text = "Event Type";
            // 
            // every_label
            // 
            this.every_label.AutoSize = true;
            this.every_label.Location = new System.Drawing.Point(7, 151);
            this.every_label.Name = "every_label";
            this.every_label.Size = new System.Drawing.Size(34, 13);
            this.every_label.TabIndex = 9;
            this.every_label.Text = "Every";
            // 
            // event_name_text_box
            // 
            this.event_name_text_box.Location = new System.Drawing.Point(75, 11);
            this.event_name_text_box.Name = "event_name_text_box";
            this.event_name_text_box.Size = new System.Drawing.Size(138, 20);
            this.event_name_text_box.TabIndex = 10;
            this.event_name_text_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // start_time_date_picker
            // 
            this.start_time_date_picker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.start_time_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_time_date_picker.Location = new System.Drawing.Point(75, 39);
            this.start_time_date_picker.Name = "start_time_date_picker";
            this.start_time_date_picker.ShowUpDown = true;
            this.start_time_date_picker.Size = new System.Drawing.Size(138, 20);
            this.start_time_date_picker.TabIndex = 11;
            this.start_time_date_picker.Value = new System.DateTime(2020, 7, 29, 11, 7, 27, 0);
            this.start_time_date_picker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // end_time_date_picker
            // 
            this.end_time_date_picker.CustomFormat = "dd/MM/yyyy HH:mm";
            this.end_time_date_picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.end_time_date_picker.Location = new System.Drawing.Point(75, 65);
            this.end_time_date_picker.Name = "end_time_date_picker";
            this.end_time_date_picker.ShowUpDown = true;
            this.end_time_date_picker.Size = new System.Drawing.Size(138, 20);
            this.end_time_date_picker.TabIndex = 12;
            this.end_time_date_picker.Value = new System.DateTime(2020, 7, 28, 13, 11, 26, 0);
            this.end_time_date_picker.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // priority_combo_box
            // 
            this.priority_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.priority_combo_box.FormattingEnabled = true;
            this.priority_combo_box.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.priority_combo_box.Location = new System.Drawing.Point(75, 95);
            this.priority_combo_box.Name = "priority_combo_box";
            this.priority_combo_box.Size = new System.Drawing.Size(121, 21);
            this.priority_combo_box.TabIndex = 13;
            this.priority_combo_box.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // event_type_combo_box
            // 
            this.event_type_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.event_type_combo_box.FormattingEnabled = true;
            this.event_type_combo_box.Items.AddRange(new object[] {
            "Birthday",
            "Business",
            "Study"});
            this.event_type_combo_box.Location = new System.Drawing.Point(75, 122);
            this.event_type_combo_box.Name = "event_type_combo_box";
            this.event_type_combo_box.Size = new System.Drawing.Size(121, 21);
            this.event_type_combo_box.TabIndex = 14;
            this.event_type_combo_box.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // every_combo_box
            // 
            this.every_combo_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.every_combo_box.FormattingEnabled = true;
            this.every_combo_box.Items.AddRange(new object[] {
            "Once",
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.every_combo_box.Location = new System.Drawing.Point(75, 148);
            this.every_combo_box.Name = "every_combo_box";
            this.every_combo_box.Size = new System.Drawing.Size(121, 21);
            this.every_combo_box.TabIndex = 15;
            this.every_combo_box.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.start_time_label);
            this.panel1.Controls.Add(this.add_event_button);
            this.panel1.Controls.Add(this.every_combo_box);
            this.panel1.Controls.Add(this.event_name_label);
            this.panel1.Controls.Add(this.event_type_combo_box);
            this.panel1.Controls.Add(this.end_time_label);
            this.panel1.Controls.Add(this.priority_combo_box);
            this.panel1.Controls.Add(this.priority_label);
            this.panel1.Controls.Add(this.end_time_date_picker);
            this.panel1.Controls.Add(this.event_type_label);
            this.panel1.Controls.Add(this.start_time_date_picker);
            this.panel1.Controls.Add(this.every_label);
            this.panel1.Controls.Add(this.event_name_text_box);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 218);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.calendarView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(765, 396);
            this.splitContainer1.SplitterDistance = 506;
            this.splitContainer1.TabIndex = 18;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // calendarView1
            // 
            this.calendarView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarView1.DateTimeValue = new System.DateTime(2020, 7, 30, 23, 7, 13, 430);
            this.calendarView1.Location = new System.Drawing.Point(3, 3);
            this.calendarView1.Name = "calendarView1";
            this.calendarView1.Size = new System.Drawing.Size(500, 382);
            this.calendarView1.TabIndex = 0;
            // 
            // CalendarAppRootPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "CalendarAppRootPanel";
            this.Text = "Form1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calendarEventBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public void SetController(CalendarController calendarController) {
            this.controller = calendarController;
        }

       

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repeatDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource calendarEventBindingSource;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button add_event_button;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label event_name_label;
        private System.Windows.Forms.Label start_time_label;
        private System.Windows.Forms.Label end_time_label;
        private System.Windows.Forms.Label priority_label;
        private System.Windows.Forms.Label event_type_label;
        private System.Windows.Forms.Label every_label;
        private System.Windows.Forms.TextBox event_name_text_box;
        private System.Windows.Forms.ComboBox priority_combo_box;
        private System.Windows.Forms.ComboBox event_type_combo_box;
        private System.Windows.Forms.ComboBox every_combo_box;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker start_time_date_picker;
        private System.Windows.Forms.DateTimePicker end_time_date_picker;
        private custom_ui.CalendarView calendarView1;
    }
}

