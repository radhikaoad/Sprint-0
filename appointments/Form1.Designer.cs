using System;

namespace Calendar
{
     partial class Form1
     {
          
          private System.ComponentModel.IContainer components = null;

          
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

          
          private void InitializeComponent()
          {
               this.mainPanel = new System.Windows.Forms.Panel();
               this.gridView = new System.Windows.Forms.FlowLayoutPanel();
               this.currentMonth = new System.Windows.Forms.Label();
               this.currentYear = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.appointmentsTextBox = new System.Windows.Forms.TextBox();
               this.addNoteToDay = new System.Windows.Forms.PictureBox();
               this.eventsScrollingView = new System.Windows.Forms.FlowLayoutPanel();
               this.prevMonthBtn = new Calendar.RoundedControlButton();
               this.nextMonthBtn = new Calendar.RoundedControlButton();
               this.mainPanel.SuspendLayout();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.addNoteToDay)).BeginInit();
               this.SuspendLayout();
               // 
               // mainPanel
               // 
               this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
               this.mainPanel.Controls.Add(this.prevMonthBtn);
               this.mainPanel.Controls.Add(this.nextMonthBtn);
               this.mainPanel.Controls.Add(this.gridView);
               this.mainPanel.Controls.Add(this.currentMonth);
               this.mainPanel.Controls.Add(this.currentYear);
               this.mainPanel.Dock = System.Windows.Forms.DockStyle.Left;
               this.mainPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
               this.mainPanel.Location = new System.Drawing.Point(0, 0);
               this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.mainPanel.Name = "mainPanel";
               this.mainPanel.Size = new System.Drawing.Size(704, 814);
               this.mainPanel.TabIndex = 2;
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
               this.currentMonth.Text = "May";
               this.currentMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // currentYear
               // 
               this.currentYear.AutoSize = true;
               this.currentYear.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.currentYear.ForeColor = System.Drawing.Color.White;
               this.currentYear.Location = new System.Drawing.Point(257, 28);
               this.currentYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.currentYear.Name = "currentYear";
               this.currentYear.Size = new System.Drawing.Size(110, 53);
               this.currentYear.TabIndex = 0;
               this.currentYear.Text = "2024";
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
               this.panel1.Controls.Add(this.appointmentsTextBox);
               this.panel1.Controls.Add(this.addNoteToDay);
               this.panel1.Controls.Add(this.eventsScrollingView);
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
               this.appointmentsTextBox.Location = new System.Drawing.Point(0, 14);
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
               this.addNoteToDay.Location = new System.Drawing.Point(0, 46);
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
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.addNoteToDay)).EndInit();
               this.ResumeLayout(false);

          }

          private void appointmentsTextBox_TextChanged(object sender, EventArgs e)
          {
               throw new NotImplementedException();
          }

          private void currentDayOfMonth_Click(object sender, EventArgs e)
          {
               throw new NotImplementedException();
          }

          #endregion
          private System.Windows.Forms.Panel mainPanel;
          private System.Windows.Forms.FlowLayoutPanel gridView;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.PictureBox addNoteToDay;
          private System.Windows.Forms.FlowLayoutPanel eventsScrollingView;
          private System.Windows.Forms.TextBox appointmentsTextBox;
          private RoundedControlButton prevMonthBtn;
          private RoundedControlButton nextMonthBtn;
          private System.Windows.Forms.Label currentMonth;
          private System.Windows.Forms.Label currentYear;
     }
}
