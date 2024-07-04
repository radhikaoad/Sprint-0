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
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.currentYear = new System.Windows.Forms.Label();
               this.mainPanel = new System.Windows.Forms.Panel();
               this.gridView = new System.Windows.Forms.FlowLayoutPanel();
               this.currentMonth = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.addNoteToDay = new System.Windows.Forms.PictureBox();
               this.eventsScrollingView = new System.Windows.Forms.FlowLayoutPanel();
               this.weatherConditionText = new System.Windows.Forms.Label();
               this.weatherDegree = new System.Windows.Forms.Label();
               this.prevMonthBtn = new Calendar.RoundedControlButton();
               this.nextMonthBtn = new Calendar.RoundedControlButton();
               this.mainPanel.SuspendLayout();
               this.panel1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.addNoteToDay)).BeginInit();
               this.SuspendLayout();
               // 
               // currentYear
               // 
               this.currentYear.AutoSize = true;
               this.currentYear.Font = new System.Drawing.Font("Segoe UI Emoji", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.currentYear.ForeColor = System.Drawing.Color.White;
               this.currentYear.Location = new System.Drawing.Point(70, 17);
               this.currentYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.currentYear.Name = "currentYear";
               this.currentYear.Size = new System.Drawing.Size(111, 54);
               this.currentYear.TabIndex = 0;
               this.currentYear.Text = "2018";
               // 
               // mainPanel
               // 
               this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
               this.mainPanel.Controls.Add(this.panel1);
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
               this.mainPanel.Size = new System.Drawing.Size(1110, 814);
               this.mainPanel.TabIndex = 2;
               // 
               // gridView
               // 
               this.gridView.Location = new System.Drawing.Point(483, 3);
               this.gridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.gridView.Name = "gridView";
               this.gridView.Size = new System.Drawing.Size(627, 413);
               this.gridView.TabIndex = 2;
               // 
               // currentMonth
               // 
               this.currentMonth.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.currentMonth.ForeColor = System.Drawing.Color.White;
               this.currentMonth.Location = new System.Drawing.Point(13, 80);
               this.currentMonth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.currentMonth.Name = "currentMonth";
               this.currentMonth.Size = new System.Drawing.Size(203, 40);
               this.currentMonth.TabIndex = 1;
               this.currentMonth.Text = "December";
               this.currentMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               // 
               // panel1
               // 
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
               this.panel1.Controls.Add(this.addNoteToDay);
               this.panel1.Controls.Add(this.eventsScrollingView);
               this.panel1.Controls.Add(this.weatherConditionText);
               this.panel1.Controls.Add(this.weatherDegree);
               this.panel1.Font = new System.Drawing.Font("Perpetua Titling MT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.panel1.Location = new System.Drawing.Point(4, 134);
               this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(402, 814);
               this.panel1.TabIndex = 6;
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
               this.weatherConditionText.Location = new System.Drawing.Point(296, 60);
               this.weatherConditionText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.weatherConditionText.Name = "weatherConditionText";
               this.weatherConditionText.Size = new System.Drawing.Size(0, 24);
               this.weatherConditionText.TabIndex = 4;
               // 
               // weatherDegree
               // 
               this.weatherDegree.AutoSize = true;
               this.weatherDegree.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.weatherDegree.ForeColor = System.Drawing.Color.White;
               this.weatherDegree.Location = new System.Drawing.Point(297, 35);
               this.weatherDegree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.weatherDegree.Name = "weatherDegree";
               this.weatherDegree.Size = new System.Drawing.Size(0, 24);
               this.weatherDegree.TabIndex = 3;
               // 
               // prevMonthBtn
               // 
               this.prevMonthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
               this.prevMonthBtn.Location = new System.Drawing.Point(15, 17);
               this.prevMonthBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
               this.prevMonthBtn.Name = "prevMonthBtn";
               this.prevMonthBtn.Size = new System.Drawing.Size(45, 46);
               this.prevMonthBtn.TabIndex = 4;
               // 
               // nextMonthBtn
               // 
               this.nextMonthBtn.Cursor = System.Windows.Forms.Cursors.Hand;
               this.nextMonthBtn.Location = new System.Drawing.Point(191, 17);
               this.nextMonthBtn.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
               this.nextMonthBtn.Name = "nextMonthBtn";
               this.nextMonthBtn.Size = new System.Drawing.Size(45, 46);
               this.nextMonthBtn.TabIndex = 3;
               // 
               // Form1
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.White;
               this.ClientSize = new System.Drawing.Size(1106, 814);
               this.Controls.Add(this.mainPanel);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.Name = "Form1";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Form1";
               this.mainPanel.ResumeLayout(false);
               this.mainPanel.PerformLayout();
               this.panel1.ResumeLayout(false);
               this.panel1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.addNoteToDay)).EndInit();
               this.ResumeLayout(false);

          }

          #endregion

          private System.Windows.Forms.Panel mainPanel;
          private System.Windows.Forms.Label currentYear;
          private System.Windows.Forms.FlowLayoutPanel gridView;
          private System.Windows.Forms.Label currentMonth;
          private RoundedControlButton nextMonthBtn;
          private RoundedControlButton prevMonthBtn;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.PictureBox addNoteToDay;
          private System.Windows.Forms.FlowLayoutPanel eventsScrollingView;
          private System.Windows.Forms.Label weatherConditionText;
          private System.Windows.Forms.Label weatherDegree;
     }
}