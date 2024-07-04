namespace Calendar
{
     public partial class CalndarGridItem
     {
          private System.ComponentModel.IContainer components = null;

          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Component Designer generated code

          private void InitializeComponent()
          {
               this.backImage = new System.Windows.Forms.PictureBox();
               this.text = new System.Windows.Forms.Label();
               this.bottomLine = new System.Windows.Forms.Panel();
               ((System.ComponentModel.ISupportInitialize)(this.backImage)).BeginInit();
               this.SuspendLayout();

               // backImage
               this.backImage.Dock = System.Windows.Forms.DockStyle.Fill;
               this.backImage.Image = global::Calendar.Properties.Resources.circle;
               this.backImage.Location = new System.Drawing.Point(0, 0);
               this.backImage.Margin = new System.Windows.Forms.Padding(15);
               this.backImage.Name = "backImage";
               this.backImage.Padding = new System.Windows.Forms.Padding(5);
               this.backImage.Size = new System.Drawing.Size(50, 50);
               this.backImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
               this.backImage.TabIndex = 1;
               this.backImage.TabStop = false;
               this.backImage.Visible = false;
               this.backImage.Click += new System.EventHandler(this.backImage_Click);

               // text
               this.text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(28)))), ((int)(((byte)(35)))));
               this.text.Cursor = System.Windows.Forms.Cursors.Default;
               this.text.Dock = System.Windows.Forms.DockStyle.Fill;
               this.text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.text.ForeColor = System.Drawing.Color.White;
               this.text.Location = new System.Drawing.Point(0, 0);
               this.text.Name = "text";
               this.text.Size = new System.Drawing.Size(50, 50);
               this.text.TabIndex = 2;
               this.text.Text = "12";
               this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
               this.text.Click += new System.EventHandler(this.text_Click);

               // bottomLine
               this.bottomLine.Location = new System.Drawing.Point(15, 37);
               this.bottomLine.Name = "bottomLine";
               this.bottomLine.Size = new System.Drawing.Size(20, 3);
               this.bottomLine.TabIndex = 3;

               // CalndarGridItem
               this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.Controls.Add(this.bottomLine);
               this.Controls.Add(this.text);
               this.Controls.Add(this.backImage);
               this.Name = "CalndarGridItem";
               this.Size = new System.Drawing.Size(50, 50);
               ((System.ComponentModel.ISupportInitialize)(this.backImage)).EndInit();
               this.ResumeLayout(false);
          }

          #endregion

          private System.Windows.Forms.PictureBox backImage;
          private System.Windows.Forms.Label text;
          private System.Windows.Forms.Panel bottomLine;
     }
}
