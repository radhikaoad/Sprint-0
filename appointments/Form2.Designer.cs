namespace Calendar
{
     partial class Form2
     {
          private System.ComponentModel.IContainer components = null;
          private System.Windows.Forms.Button add;
          private System.Windows.Forms.Button am_pm;
          private System.Windows.Forms.Label selectedDate;
          private System.Windows.Forms.PictureBox pictureBox3;
          private System.Windows.Forms.PictureBox pictureBox2;
          private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.PictureBox cancel;
          private System.Windows.Forms.TextBox hourTxt;
          private System.Windows.Forms.TextBox eventLocation;
          private System.Windows.Forms.TextBox eventTitle;
          private System.Windows.Forms.TextBox minuteTxt;

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
               this.add = new System.Windows.Forms.Button();
               this.am_pm = new System.Windows.Forms.Button();
               this.selectedDate = new System.Windows.Forms.Label();
               this.pictureBox3 = new System.Windows.Forms.PictureBox();
               this.pictureBox2 = new System.Windows.Forms.PictureBox();
               this.pictureBox1 = new System.Windows.Forms.PictureBox();
               this.cancel = new System.Windows.Forms.PictureBox();
               this.minuteTxt = new System.Windows.Forms.TextBox();
               this.hourTxt = new System.Windows.Forms.TextBox();
               this.eventLocation = new System.Windows.Forms.TextBox();
               this.eventTitle = new System.Windows.Forms.TextBox();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.cancel)).BeginInit();
               this.SuspendLayout();

               // add
               this.add.DialogResult = System.Windows.Forms.DialogResult.OK;
               this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.add.ForeColor = System.Drawing.Color.White;
               this.add.Location = new System.Drawing.Point(13, 285);
               this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.add.Name = "add";
               this.add.Size = new System.Drawing.Size(321, 45);
               this.add.TabIndex = 12;
               this.add.Text = "Add event";
               this.add.UseVisualStyleBackColor = true;
               this.add.Click += new System.EventHandler(this.add_Click);

               // am_pm
               this.am_pm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
               this.am_pm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
               this.am_pm.ForeColor = System.Drawing.Color.White;
               this.am_pm.Location = new System.Drawing.Point(151, 216);
               this.am_pm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.am_pm.Name = "am_pm";
               this.am_pm.Size = new System.Drawing.Size(68, 46);
               this.am_pm.TabIndex = 11;
               this.am_pm.Text = "AM";
               this.am_pm.UseVisualStyleBackColor = true;
               this.am_pm.Click += new System.EventHandler(this.am_pm_Click);

               // selectedDate
               this.selectedDate.AutoSize = true;
               this.selectedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
               this.selectedDate.Location = new System.Drawing.Point(13, 9);
               this.selectedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.selectedDate.Name = "selectedDate";
               this.selectedDate.Size = new System.Drawing.Size(141, 29);
               this.selectedDate.TabIndex = 15;
               this.selectedDate.Text = "18 Jan 2018";

               // pictureBox3
               this.pictureBox3.Image = global::Calendar.Properties.Resources.task;
               this.pictureBox3.Location = new System.Drawing.Point(301, 90);
               this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.pictureBox3.Name = "pictureBox3";
               this.pictureBox3.Size = new System.Drawing.Size(38, 38);
               this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox3.TabIndex = 18;
               this.pictureBox3.TabStop = false;

               // pictureBox2
               this.pictureBox2.Image = global::Calendar.Properties.Resources.clock;
               this.pictureBox2.Location = new System.Drawing.Point(301, 219);
               this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.pictureBox2.Name = "pictureBox2";
               this.pictureBox2.Size = new System.Drawing.Size(38, 38);
               this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox2.TabIndex = 17;
               this.pictureBox2.TabStop = false;
               this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);

               // pictureBox1
               this.pictureBox1.Image = global::Calendar.Properties.Resources.lettermark_one_line_diving_eagle_green_0;
               this.pictureBox1.Location = new System.Drawing.Point(301, 151);
               this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.pictureBox1.Name = "pictureBox1";
               this.pictureBox1.Size = new System.Drawing.Size(38, 38);
               this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.pictureBox1.TabIndex = 16;
               this.pictureBox1.TabStop = false;
               this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);

               // cancel
               this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
               this.cancel.Image = global::Calendar.Properties.Resources.icon_cancel;
               this.cancel.Location = new System.Drawing.Point(219, 14);
               this.cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.cancel.Name = "cancel";
               this.cancel.Size = new System.Drawing.Size(38, 38);
               this.cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.cancel.TabIndex = 13;
               this.cancel.TabStop = false;
               this.cancel.Click += new System.EventHandler(this.pictureBox1_Click);

               // minuteTxt
               this.minuteTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
               this.minuteTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
               this.minuteTxt.ForeColor = System.Drawing.Color.White;
               this.minuteTxt.Location = new System.Drawing.Point(82, 216);
               this.minuteTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.minuteTxt.MaxLength = 2;
               this.minuteTxt.Name = "minuteTxt";
               this.minuteTxt.Size = new System.Drawing.Size(61, 41);
               this.minuteTxt.TabIndex = 14;
               this.minuteTxt.Text = "00";
               this.minuteTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

               // hourTxt
               this.hourTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
               this.hourTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
               this.hourTxt.ForeColor = System.Drawing.Color.White;
               this.hourTxt.Location = new System.Drawing.Point(13, 216);
               this.hourTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.hourTxt.MaxLength = 2;
               this.hourTxt.Name = "hourTxt";
               this.hourTxt.Size = new System.Drawing.Size(61, 41);
               this.hourTxt.TabIndex = 9;
               this.hourTxt.Text = "12";
               this.hourTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

               // eventLocation
               this.eventLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
               this.eventLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
               this.eventLocation.ForeColor = System.Drawing.Color.White;
               this.eventLocation.Location = new System.Drawing.Point(13, 151);
               this.eventLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.eventLocation.Name = "eventLocation";
               this.eventLocation.Size = new System.Drawing.Size(280, 41);
               this.eventLocation.TabIndex = 8;

               // eventTitle
               this.eventTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
               this.eventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
               this.eventTitle.ForeColor = System.Drawing.Color.White;
               this.eventTitle.Location = new System.Drawing.Point(13, 90);
               this.eventTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.eventTitle.Multiline = true;
               this.eventTitle.Name = "eventTitle";
               this.eventTitle.Size = new System.Drawing.Size(280, 44);
               this.eventTitle.TabIndex = 7;

               // Form2
               this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(85)))));
               this.ClientSize = new System.Drawing.Size(362, 354);
               this.Controls.Add(this.pictureBox3);
               this.Controls.Add(this.pictureBox2);
               this.Controls.Add(this.pictureBox1);
               this.Controls.Add(this.selectedDate);
               this.Controls.Add(this.minuteTxt);
               this.Controls.Add(this.cancel);
               this.Controls.Add(this.add);
               this.Controls.Add(this.am_pm);
               this.Controls.Add(this.hourTxt);
               this.Controls.Add(this.eventLocation);
               this.Controls.Add(this.eventTitle);
               this.ForeColor = System.Drawing.Color.White;
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
               this.Name = "Form2";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
               this.Text = "Form2";
               this.Load += new System.EventHandler(this.Form2_Load);
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.cancel)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();
          }
     }
}
