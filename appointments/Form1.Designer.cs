namespace Calendar
{
     partial class Form1
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

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.currentYear = new System.Windows.Forms.Label();
               this.mainPanel = new System.Windows.Forms.Panel();
               this.closeApp = new System.Windows.Forms.PictureBox();
               this.prevMonthBtn = new Calendar.RoundedControlButton();
               this.nextMonthBtn = new Calendar.RoundedControlButton();
               this.gridView = new System.Windows.Forms.FlowLayoutPanel();
               this.currentMonth = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.appointmentsTextBox = new System.Windows.Forms.TextBox();
               this.addNoteToDay = new System.Windows.Forms.PictureBox();
               this.eventsScrollingView = new System.Windows.Forms.FlowLayoutPanel();
               this.weatherConditionText = new System.Windows.Forms.Label();
               this.weatherDegree = new System.Windows.Forms.Label();
               this.weatherIconPb = new System.Windows.Forms.PictureBox();
               this.currentDayOfWeek = new System.Windows.Forms.Label();
               this.currentDayOfMonth = new System.Windows.Forms.Label();
               this.mainPanel.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.closeApp)).BeginInit();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.addNoteToDay)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.weatherIconPb)).BeginInit();
               this.SuspendLayout();
               // 
               // currentYear
               // 
               this.currentYear.AutoSize = true;
               this.currentYear.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.currentYear.ForeColor = System.Drawing.Color.White;
               this.currentYear.Location = new System.Drawing.Point(256, 29);
               this.currentYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.currentYear.Name = "currentYear";
               this.currentYear.Size = new System.Drawing.Size(111, 54);
               this.currentYear.TabIndex = 0;
               this.currentYear.Text = "2018";
               // 
               // mainPanel
               // 
               this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
               this.mainPanel.Controls.Add(this.closeApp);
               this.mainPanel.Controls.Add(this.prevMonthBtn);
               this.mainPanel.Controls.Add(this.nextMonthBtn);
               this.mainPanel.Controls.Add(this.gridView);
               this.mainPanel.Controls.Add(this.currentMonth);
               this.mainPanel.Controls.Add(this.currentYear);
               this.mainPanel.Controls.Add(this.currentDayOfWeek);
               this.mainPanel.Controls.Add(this.currentDayOfMonth);
               this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
               this.mainPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
               this.mainPanel.Location = new System.Drawing.Point(0, 0);
               this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.mainPanel.Name = "mainPanel";
               this.mainPanel.Size = new System.Drawing.Size(704, 814);
               this.mainPanel.TabIndex = 2;
               // 
               // closeApp
               // 
               this.closeApp.Cursor = System.Windows.Forms.Cursors.Hand;
               this.closeApp.Image = global::Calendar.Properties.Resources.closeApp;
               this.closeApp.Location = new System.Drawing.Point(9, 6);
               this.closeApp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.closeApp.Name = "closeApp";
               this.closeApp.Size = new System.Drawing.Size(34, 35);
               this.closeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.closeApp.TabIndex = 5;
               this.closeApp.TabStop = false;
               // 
               // prevMonthBtn
               // 
               this.prevMonthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
               this.prevMonthBtn.Location = new System.Drawing.Point(183, 35);
               this.prevMonthBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
               this.prevMonthBtn.Name = "prevMonthBtn";
               this.prevMonthBtn.Size = new System.Drawing.Size(45, 46);
               this.prevMonthBtn.TabIndex = 4;
               // 
               // nextMonthBtn
               // 
               this.nextMonthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
               this.nextMonthBtn.Location = new System.Drawing.Point(396, 35);
               this.nextMonthBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
               this.nextMonthBtn.Name = "nextMonthBtn";
               this.nextMonthBtn.Size = new System.Drawing.Size(45, 46);
               this.nextMonthBtn.TabIndex = 3;
               // 
               // gridView
               // 
               this.gridView.Location = new System.Drawing.Point(38, 192);
               this.gridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.gridView.Name = "gridView";
               this.gridView.Size = new System.Drawing.Size(627, 606);
               this.gridView.TabIndex = 2;
               // 
               // currentMonth
               // 
               this.currentMonth.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.currentMonth.ForeColor = System.Drawing.Color.White;
               this.currentMonth.Location = new System.Drawing.Point(131, 98);
               this.currentMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.currentMonth.Name = "currentMonth";
               this.currentMonth.Size = new System.Drawing.Size(364, 40);
               this.currentMonth.TabIndex = 1;
               this.currentMonth.Text = "December";
               this.currentMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.currentMonth.Click += new System.EventHandler(this.currentMonth_Click);
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
               this.panel1.Controls.Add(this.appointmentsTextBox);
               this.panel1.Controls.Add(this.addNoteToDay);
               this.panel1.Controls.Add(this.eventsScrollingView);
               this.panel1.Controls.Add(this.weatherConditionText);
               this.panel1.Controls.Add(this.weatherDegree);
               this.panel1.Controls.Add(this.weatherIconPb);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
               this.panel1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.panel1.Location = new System.Drawing.Point(704, 0);
               this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(402, 814);
               this.panel1.TabIndex = 6;
               // 
               // appointmentsTextBox
               // 
               this.appointmentsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
               this.appointmentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.appointmentsTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.appointmentsTextBox.ForeColor = System.Drawing.Color.White;
               this.appointmentsTextBox.Location = new System.Drawing.Point(8, 3);
               this.appointmentsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.appointmentsTextBox.Name = "appointmentsTextBox";
               this.appointmentsTextBox.ReadOnly = true;
               this.appointmentsTextBox.Size = new System.Drawing.Size(324, 38);
               this.appointmentsTextBox.TabIndex = 7;
               this.appointmentsTextBox.Text = "APPOINTMENTS";
               this.appointmentsTextBox.TextChanged += new System.EventHandler(this.appointmentsTextBox_TextChanged);
               // 
               // addNoteToDay
               // 
               this.addNoteToDay.Cursor = System.Windows.Forms.Cursors.Hand;
               this.addNoteToDay.Image = global::Calendar.Properties.Resources.icon_add;
               this.addNoteToDay.Location = new System.Drawing.Point(10, 205);
               this.addNoteToDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.addNoteToDay.Name = "addNoteToDay";
               this.addNoteToDay.Size = new System.Drawing.Size(36, 37);
               this.addNoteToDay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.addNoteToDay.TabIndex = 6;
               this.addNoteToDay.TabStop = false;
               this.addNoteToDay.Click += new System.EventHandler(this.addNoteToDay_Click_1);
               // 
               // eventsScrollingView
               // 
               this.eventsScrollingView.Dock = System.Windows.Forms.DockStyle.Bottom;
               this.eventsScrollingView.Location = new System.Drawing.Point(0, 251);
               this.eventsScrollingView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.eventsScrollingView.Name = "eventsScrollingView";
               this.eventsScrollingView.Size = new System.Drawing.Size(402, 563);
               this.eventsScrollingView.TabIndex = 5;
               // 
               // weatherConditionText
               // 
               this.weatherConditionText.AutoSize = true;
               this.weatherConditionText.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.weatherConditionText.ForeColor = System.Drawing.Color.White;
               this.weatherConditionText.Location = new System.Drawing.Point(120, 111);
               this.weatherConditionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.weatherConditionText.Name = "weatherConditionText";
               this.weatherConditionText.Size = new System.Drawing.Size(0, 24);
               this.weatherConditionText.TabIndex = 4;
               // 
               // weatherDegree
               // 
               this.weatherDegree.Font = new System.Drawing.Font("Segoe UI Emoji", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.weatherDegree.ForeColor = System.Drawing.Color.White;
               this.weatherDegree.Location = new System.Drawing.Point(120, 75);
               this.weatherDegree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.weatherDegree.Name = "weatherDegree";
               this.weatherDegree.Size = new System.Drawing.Size(71, 44);
               this.weatherDegree.TabIndex = 8;
               // 
               // weatherIconPb
               // 
               this.weatherIconPb.Location = new System.Drawing.Point(17, 75);
               this.weatherIconPb.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.weatherIconPb.Name = "weatherIconPb";
               this.weatherIconPb.Size = new System.Drawing.Size(87, 68);
               this.weatherIconPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.weatherIconPb.TabIndex = 2;
               this.weatherIconPb.TabStop = false;
               // 
               // currentDayOfWeek
               // 
               this.currentDayOfWeek.AutoSize = true;
               this.currentDayOfWeek.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.currentDayOfWeek.ForeColor = System.Drawing.Color.White;
               this.currentDayOfWeek.Location = new System.Drawing.Point(531, 128);
               this.currentDayOfWeek.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.currentDayOfWeek.Name = "currentDayOfWeek";
               this.currentDayOfWeek.Size = new System.Drawing.Size(165, 38);
               this.currentDayOfWeek.TabIndex = 1;
               this.currentDayOfWeek.Text = "Wednesday";
               // 
               // currentDayOfMonth
               // 
               this.currentDayOfMonth.AutoSize = true;
               this.currentDayOfMonth.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.currentDayOfMonth.ForeColor = System.Drawing.Color.White;
               this.currentDayOfMonth.Location = new System.Drawing.Point(548, 0);
               this.currentDayOfMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.currentDayOfMonth.Name = "currentDayOfMonth";
               this.currentDayOfMonth.Size = new System.Drawing.Size(158, 128);
               this.currentDayOfMonth.TabIndex = 0;
               this.currentDayOfMonth.Text = "16";
               this.currentDayOfMonth.Click += new System.EventHandler(this.currentDayOfMonth_Click);
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.Black;
               this.ClientSize = new System.Drawing.Size(1106, 814);
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.mainPanel);
               this.ForeColor = System.Drawing.Color.White;
               this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.Name = "Form1";
               this.Text = "Form1";
               this.mainPanel.ResumeLayout(false);
               this.mainPanel.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.closeApp)).EndInit();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.addNoteToDay)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.weatherIconPb)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Label currentYear;
          private System.Windows.Forms.Panel mainPanel;
          private System.Windows.Forms.PictureBox closeApp;
          private RoundedControlButton prevMonthBtn;
          private RoundedControlButton nextMonthBtn;
          private System.Windows.Forms.FlowLayoutPanel gridView;
          private System.Windows.Forms.Label currentMonth;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.PictureBox addNoteToDay;
          private System.Windows.Forms.FlowLayoutPanel eventsScrollingView;
          private System.Windows.Forms.Label weatherConditionText;
          private System.Windows.Forms.Label weatherDegree;
          private System.Windows.Forms.PictureBox weatherIconPb;
          private System.Windows.Forms.Label currentDayOfWeek;
          private System.Windows.Forms.Label currentDayOfMonth;
          private System.Windows.Forms.TextBox appointmentsTextBox;
     }
}

