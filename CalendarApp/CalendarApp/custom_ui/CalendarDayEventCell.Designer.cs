namespace CalendarApp.custom_ui
{
    partial class CalendarDayEventCell
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
            this.event_name_label = new System.Windows.Forms.Label();
            this.event_date_label = new System.Windows.Forms.Label();
            this.delete_event_buton = new System.Windows.Forms.Button();
            this.edit_event_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // event_name_label
            // 
            this.event_name_label.AutoSize = true;
            this.event_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_name_label.Location = new System.Drawing.Point(3, 0);
            this.event_name_label.Name = "event_name_label";
            this.event_name_label.Size = new System.Drawing.Size(214, 26);
            this.event_name_label.TabIndex = 0;
            this.event_name_label.Text = "Sample Event Name";
            // 
            // event_date_label
            // 
            this.event_date_label.AutoSize = true;
            this.event_date_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.event_date_label.Location = new System.Drawing.Point(5, 44);
            this.event_date_label.Name = "event_date_label";
            this.event_date_label.Size = new System.Drawing.Size(163, 20);
            this.event_date_label.TabIndex = 1;
            this.event_date_label.Text = "sample start end date";
            this.event_date_label.Click += new System.EventHandler(this.event_date_label_Click);
            // 
            // delete_event_buton
            // 
            this.delete_event_buton.Location = new System.Drawing.Point(265, 51);
            this.delete_event_buton.Name = "delete_event_buton";
            this.delete_event_buton.Size = new System.Drawing.Size(75, 23);
            this.delete_event_buton.TabIndex = 2;
            this.delete_event_buton.Text = "delete";
            this.delete_event_buton.UseVisualStyleBackColor = true;
            // 
            // edit_event_button
            // 
            this.edit_event_button.Location = new System.Drawing.Point(265, 22);
            this.edit_event_button.Name = "edit_event_button";
            this.edit_event_button.Size = new System.Drawing.Size(75, 23);
            this.edit_event_button.TabIndex = 3;
            this.edit_event_button.Text = "edit";
            this.edit_event_button.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.event_name_label);
            this.panel1.Controls.Add(this.edit_event_button);
            this.panel1.Controls.Add(this.event_date_label);
            this.panel1.Controls.Add(this.delete_event_buton);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 145);
            this.panel1.TabIndex = 4;
            // 
            // CalendarDayEventCell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Name = "CalendarDayEventCell";
            this.Size = new System.Drawing.Size(412, 151);
            this.Load += new System.EventHandler(this.CalendarDayEventCell_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label event_name_label;
        private System.Windows.Forms.Label event_date_label;
        private System.Windows.Forms.Button delete_event_buton;
        private System.Windows.Forms.Button edit_event_button;
        private System.Windows.Forms.Panel panel1;
    }
}
