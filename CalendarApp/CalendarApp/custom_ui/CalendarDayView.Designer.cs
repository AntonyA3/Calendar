namespace CalendarApp.custom_ui
{
    partial class CalendarDayView
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.to_month_view_button = new System.Windows.Forms.Button();
            this.to_previous_day_button = new System.Windows.Forms.Button();
            this.to_next_day_button = new System.Windows.Forms.Button();
            this.events_table_panel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.to_month_view_button, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.to_previous_day_button, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.to_next_day_button, 2, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(479, 41);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // to_month_view_button
            // 
            this.to_month_view_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.to_month_view_button.Location = new System.Drawing.Point(122, 3);
            this.to_month_view_button.Name = "to_month_view_button";
            this.to_month_view_button.Size = new System.Drawing.Size(233, 35);
            this.to_month_view_button.TabIndex = 0;
            this.to_month_view_button.Text = "button1";
            this.to_month_view_button.UseVisualStyleBackColor = true;
            // 
            // to_previous_day_button
            // 
            this.to_previous_day_button.Location = new System.Drawing.Point(3, 3);
            this.to_previous_day_button.Name = "to_previous_day_button";
            this.to_previous_day_button.Size = new System.Drawing.Size(75, 23);
            this.to_previous_day_button.TabIndex = 1;
            this.to_previous_day_button.Text = "button2";
            this.to_previous_day_button.UseVisualStyleBackColor = true;
            // 
            // to_next_day_button
            // 
            this.to_next_day_button.Location = new System.Drawing.Point(361, 3);
            this.to_next_day_button.Name = "to_next_day_button";
            this.to_next_day_button.Size = new System.Drawing.Size(75, 23);
            this.to_next_day_button.TabIndex = 2;
            this.to_next_day_button.Text = "button3";
            this.to_next_day_button.UseVisualStyleBackColor = true;
            // 
            // events_table_panel
            // 
            this.events_table_panel.AutoScroll = true;
            this.events_table_panel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.events_table_panel.ColumnCount = 1;
            this.events_table_panel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.events_table_panel.Location = new System.Drawing.Point(6, 50);
            this.events_table_panel.Name = "events_table_panel";
            this.events_table_panel.RowCount = 3;
            this.events_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.events_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.events_table_panel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.events_table_panel.Size = new System.Drawing.Size(476, 318);
            this.events_table_panel.TabIndex = 1;
            // 
            // CalendarDayView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.events_table_panel);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Name = "CalendarDayView";
            this.Size = new System.Drawing.Size(485, 386);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button to_month_view_button;
        private System.Windows.Forms.Button to_previous_day_button;
        private System.Windows.Forms.Button to_next_day_button;
        private System.Windows.Forms.TableLayoutPanel events_table_panel;
    }
}
