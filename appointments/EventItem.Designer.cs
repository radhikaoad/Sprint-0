namespace Calendar
{
     partial class EventItem
     {
          private System.ComponentModel.IContainer components = null;
          private System.Windows.Forms.Label location;
          private System.Windows.Forms.Label title;
          private System.Windows.Forms.Panel panel1;
          private System.Windows.Forms.Label time;
          private System.Windows.Forms.Panel brightPanel;

          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          private void InitializeComponent()
          {
               this.location = new System.Windows.Forms.Label();
               this.title = new System.Windows.Forms.Label();
               this.panel1 = new System.Windows.Forms.Panel();
               this.time = new System.Windows.Forms.Label();
               this.brightPanel = new System.Windows.Forms.Panel();
               this.panel1.SuspendLayout();
               this.brightPanel.SuspendLayout();
               this.SuspendLayout();

               // location
               this.location.AutoSize = true;
               this.location.Font = new System.Drawing.Font("Bahnschrift", 7.25F);
               this.location.ForeColor = System.Drawing.Color.White;
               this.location.Location = new System.Drawing.Point(87, 43);
               this.location.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.location.MaximumSize = new System.Drawing.Size(195, 0);
               this.location.Name = "location";
               this.location.Size = new System.Drawing.Size(95, 18);
               this.location.TabIndex = 13;
               this.location.Text = "10 may, UNT";
               this.location.Click += new System.EventHandler(this.location_Click);

               // title
               this.title.AutoSize = true;
               this.title.Font = new System.Drawing.Font("Bahnschrift", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.title.ForeColor = System.Drawing.Color.White;
               this.title.Location = new System.Drawing.Point(4, 18);
               this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.title.MaximumSize = new System.Drawing.Size(195, 20);
               this.title.Name = "title";
               this.title.Size = new System.Drawing.Size(182, 20);
               this.title.TabIndex = 12;
               this.title.Text = "Meeting with investors";
               this.title.Click += new System.EventHandler(this.title_Click);

               // panel1
               this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(58)))));
               this.panel1.Controls.Add(this.time);
               this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
               this.panel1.Location = new System.Drawing.Point(0, 0);
               this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.panel1.Name = "panel1";
               this.panel1.Size = new System.Drawing.Size(76, 95);
               this.panel1.TabIndex = 14;

               // time
               this.time.Dock = System.Windows.Forms.DockStyle.Top;
               this.time.Font = new System.Drawing.Font("Bahnschrift SemiLight", 9.25F);
               this.time.ForeColor = System.Drawing.Color.White;
               this.time.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
               this.time.Location = new System.Drawing.Point(0, 0);
               this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.time.Name = "time";
               this.time.Size = new System.Drawing.Size(76, 38);
               this.time.TabIndex = 13;
               this.time.Text = "12:00 AM";

               // brightPanel
               this.brightPanel.Controls.Add(this.title);
               this.brightPanel.Dock = System.Windows.Forms.DockStyle.Right;
               this.brightPanel.Location = new System.Drawing.Point(74, 0);
               this.brightPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.brightPanel.Name = "brightPanel";
               this.brightPanel.Size = new System.Drawing.Size(328, 95);
               this.brightPanel.TabIndex = 15;
               this.brightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.brightPanel_Paint);

               // EventItem
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
               this.Controls.Add(this.panel1);
               this.Controls.Add(this.location);
               this.Controls.Add(this.brightPanel);
               this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.Name = "EventItem";
               this.Size = new System.Drawing.Size(402, 95);
               this.panel1.ResumeLayout(false);
               this.brightPanel.ResumeLayout(false);
               this.brightPanel.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();
          }
     }
}
