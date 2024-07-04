using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar
{
     partial class Form1 : Form
     {
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

          private void InitializeComponent()
          {
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
               this.mainPanel = new System.Windows.Forms.Panel();
               this.gridView = new System.Windows.Forms.FlowLayoutPanel();
               this.currentMonth = new System.Windows.Forms.Label();
               this.currentYear = new System.Windows.Forms.Label();
               this.prevMonthBtn = new Calendar.RoundedControlButton();
               this.nextMonthBtn = new Calendar.RoundedControlButton();
               this.panel1 = new System.Windows.Forms.Panel();
               this.addNoteToDay = new System.Windows.Forms.PictureBox();
               this.eventsScrollingView = new System.Windows.Forms.FlowLayoutPanel();
               this.appointmentsTextBox = new System.Windows.Forms.TextBox();
               this.panel2 = new System.Windows.Forms.Panel();
               this.pastAppointmentsTextBox = new System.Windows.Forms.TextBox();
               this.mainPanel.SuspendLayout();
               this.panel1.SuspendLayout();
               this.panel2.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.addNoteToDay)).BeginInit();
               this.SuspendLayout();
               // 
               // mainPanel
               // 
               this.mainPanel.BackColor = System.Drawing.Color.Black;
               this.mainPanel.Controls.Add(this.gridView);
               this.mainPanel.Controls.Add(this.currentMonth);
               this.mainPanel.Controls.Add(this.currentYear);
               this.mainPanel.Controls.Add(this.prevMonthBtn);
               this.mainPanel.Controls.Add(this.nextMonthBtn);
               this.mainPanel.Controls.Add(this.panel1);
               this.mainPanel.Controls.Add(this.panel2);
               this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
               this.mainPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
               this.mainPanel.Location = new System.Drawing.Point(0, 0);
               this.mainPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.mainPanel.Name = "mainPanel";
               this.mainPanel.Size = new System.Drawing.Size(1106, 814);
               this.mainPanel.TabIndex = 0;
               // 
               // gridView
               // 
               this.gridView.Location = new System.Drawing.Point(453, 0);
               this.gridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.gridView.Name = "gridView";
               this.gridView.Size = new System.Drawing.Size(649, 544);
               this.gridView.TabIndex = 6;
               // 
               // currentMonth
               // 
               this.currentMonth.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.currentMonth.ForeColor = System.Drawing.Color.White;
               this.currentMonth.Location = new System.Drawing.Point(36, 81);
               this.currentMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.currentMonth.Name = "currentMonth";
               this.currentMonth.Size = new System.Drawing.Size(153, 40);
               this.currentMonth.TabIndex = 5;
               this.currentMonth.Text = "May";
               this.currentMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // currentYear
               // 
               this.currentYear.AutoSize = true;
               this.currentYear.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.currentYear.ForeColor = System.Drawing.Color.White;
               this.currentYear.Location = new System.Drawing.Point(63, 27);
               this.currentYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.currentYear.Name = "currentYear";
               this.currentYear.Size = new System.Drawing.Size(111, 54);
               this.currentYear.TabIndex = 4;
               this.currentYear.Text = "2024";
               // 
               // prevMonthBtn
               // 
               this.prevMonthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
               this.prevMonthBtn.Location = new System.Drawing.Point(8, 28);
               this.prevMonthBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
               this.prevMonthBtn.Name = "prevMonthBtn";
               this.prevMonthBtn.Size = new System.Drawing.Size(45, 46);
               this.prevMonthBtn.TabIndex = 3;
               // 
               // nextMonthBtn
               // 
               this.nextMonthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
               this.nextMonthBtn.Location = new System.Drawing.Point(184, 35);
               this.nextMonthBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
               this.nextMonthBtn.Name = "nextMonthBtn";
               this.nextMonthBtn.Size = new System.Drawing.Size(45, 46);
               this.nextMonthBtn.TabIndex = 2;
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.White;
               this.panel1.Controls.Add(this.eventsScrollingView);
               this.panel1.Controls.Add(this.appointmentsTextBox);
               this.panel1.Controls.Add(this.addNoteToDay);
               this.panel1.Location = new System.Drawing.Point(13, 146);
               this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(402, 662);
               this.panel1.TabIndex = 0;
               // 
               // addNoteToDay
               // 
               this.addNoteToDay.Cursor = System.Windows.Forms.Cursors.Hand;
               this.addNoteToDay.Image = ((System.Drawing.Image)(resources.GetObject("addNoteToDay.Image")));
               this.addNoteToDay.Location = new System.Drawing.Point(4, 53);
               this.addNoteToDay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.addNoteToDay.Name = "addNoteToDay";
               this.addNoteToDay.Size = new System.Drawing.Size(36, 37);
               this.addNoteToDay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.addNoteToDay.TabIndex = 1;
               this.addNoteToDay.TabStop = false;
               this.addNoteToDay.Click += new System.EventHandler(this.addNoteToDay_Click);
               // 
               // eventsScrollingView
               // 
               this.eventsScrollingView.Location = new System.Drawing.Point(0, 164);
               this.eventsScrollingView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.eventsScrollingView.Name = "eventsScrollingView";
               this.eventsScrollingView.Size = new System.Drawing.Size(402, 496);
               this.eventsScrollingView.TabIndex = 0;
               // 
               // appointmentsTextBox
               // 
               this.appointmentsTextBox.BackColor = System.Drawing.Color.White;
               this.appointmentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.appointmentsTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.appointmentsTextBox.ForeColor = System.Drawing.Color.Black;
               this.appointmentsTextBox.Location = new System.Drawing.Point(4, 5);
               this.appointmentsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.appointmentsTextBox.Name = "appointmentsTextBox";
               this.appointmentsTextBox.ReadOnly = true;
               this.appointmentsTextBox.Size = new System.Drawing.Size(324, 38);
               this.appointmentsTextBox.TabIndex = 0;
               this.appointmentsTextBox.Text = "APPOINTMENTS";
               // 
               // panel2
               // 
               this.panel2.BackColor = System.Drawing.Color.White;
               this.panel2.Controls.Add(this.pastAppointmentsTextBox);
               this.panel2.Location = new System.Drawing.Point(453, 546);
               this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.panel2.Name = "panel2";
               this.panel2.Size = new System.Drawing.Size(640, 242);
               this.panel2.TabIndex = 1;
               // 
               // pastAppointmentsTextBox
               // 
               this.pastAppointmentsTextBox.BackColor = System.Drawing.Color.White;
               this.pastAppointmentsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
               this.pastAppointmentsTextBox.Font = new System.Drawing.Font("Segoe UI Emoji", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.pastAppointmentsTextBox.ForeColor = System.Drawing.Color.Black;
               this.pastAppointmentsTextBox.Location = new System.Drawing.Point(4, 5);
               this.pastAppointmentsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.pastAppointmentsTextBox.Name = "pastAppointmentsTextBox";
               this.pastAppointmentsTextBox.ReadOnly = true;
               this.pastAppointmentsTextBox.Size = new System.Drawing.Size(324, 38);
               this.pastAppointmentsTextBox.TabIndex = 0;
               this.pastAppointmentsTextBox.Text = "PAST APPOINTMENTS:";
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1106, 814);
               this.Controls.Add(this.mainPanel);
               this.ForeColor = System.Drawing.Color.White;
               this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.Name = "Form1";
               this.Text = "Calendar Application";
               this.mainPanel.ResumeLayout(false);
               this.mainPanel.PerformLayout();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               this.panel2.ResumeLayout(false);
               this.panel2.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.addNoteToDay)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel mainPanel;
          private System.Windows.Forms.FlowLayoutPanel gridView;
          private System.Windows.Forms.Label currentMonth;
          private System.Windows.Forms.Label currentYear;
          private Calendar.RoundedControlButton prevMonthBtn;
          private Calendar.RoundedControlButton nextMonthBtn;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.PictureBox addNoteToDay;
          private System.Windows.Forms.FlowLayoutPanel eventsScrollingView;
          private System.Windows.Forms.TextBox appointmentsTextBox;
          private System.Windows.Forms.Panel panel2;
          private System.Windows.Forms.TextBox pastAppointmentsTextBox;
     }
}
