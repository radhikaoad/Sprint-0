using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Calendar
{
    public partial class CalendarGridItem : UserControl
    {
        private IContainer components = null;

        public CalendarGridItem()
        {
            InitializeComponent();
        }

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
            this.backImage = new PictureBox();
            this.text = new Label();
            this.bottomLine = new Panel();
            ((ISupportInitialize)(this.backImage)).BeginInit();
            this.SuspendLayout();

            // backImage
            this.backImage.Dock = DockStyle.Fill;
            this.backImage.Image = global::Calendar.Properties.Resources.circle;
            this.backImage.Location = new Point(0, 0);
            this.backImage.Margin = new Padding(15);
            this.backImage.Name = "backImage";
            this.backImage.Padding = new Padding(5);
            this.backImage.Size = new Size(50, 50);
            this.backImage.SizeMode = PictureBoxSizeMode.StretchImage;
            this.backImage.TabIndex = 1;
            this.backImage.TabStop = false;
            this.backImage.Visible = false;
            this.backImage.Click += new EventHandler(this.backImage_Click);

            // text
            this.text.BackColor = Color.FromArgb(26, 28, 35);
            this.text.Cursor = Cursors.Default;
            this.text.Dock = DockStyle.Fill;
            this.text.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = Color.White;
            this.text.Location = new Point(0, 0);
            this.text.Name = "text";
            this.text.Size = new Size(50, 50);
            this.text.TabIndex = 2;
            this.text.Text = "12";
            this.text.TextAlign = ContentAlignment.MiddleCenter;
            this.text.Click += new EventHandler(this.text_Click);

            // bottomLine
            this.bottomLine.BackColor = Color.Gray;
            this.bottomLine.Location = new Point(15, 37);
            this.bottomLine.Name = "bottomLine";
            this.bottomLine.Size = new Size(20, 3);
            this.bottomLine.TabIndex = 3;

            // CalendarGridItem
            this.AutoScaleDimensions = new SizeF(6F, 13F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.Controls.Add(this.bottomLine);
            this.Controls.Add(this.text);
            this.Controls.Add(this.backImage);
            this.Name = "CalendarGridItem";
            this.Size = new Size(50, 50);
            this.MouseEnter += new EventHandler(this.CalendarGridItem_MouseEnter);
            this.MouseLeave += new EventHandler(this.CalendarGridItem_MouseLeave);
            ((ISupportInitialize)(this.backImage)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private PictureBox backImage;
        private Label text;
        private Panel bottomLine;

        private void backImage_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Image clicked");
        }

        private void text_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text clicked");
        }

        private void CalendarGridItem_MouseEnter(object sender, EventArgs e)
        {
            this.text.BackColor = Color.DarkGray;
        }

        private void CalendarGridItem_MouseLeave(object sender, EventArgs e)
        {
            this.text.BackColor = Color.FromArgb(26, 28, 35);
        }
    }
}
