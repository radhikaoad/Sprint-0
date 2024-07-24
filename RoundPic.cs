using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Calendar
{
    class RoundPic : Button
    {
        public RoundPic()
        {
            this.BackColor = Color.Transparent;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath rgPath = new GraphicsPath();
            rgPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new Region(rgPath);

            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.DarkGray, Color.LightGray, 45F))
            {
                e.Graphics.FillEllipse(brush, 0, 0, this.ClientSize.Width, this.ClientSize.Height);
            }

            using (Pen pen = new Pen(Color.Black, 2))
            {
                e.Graphics.DrawEllipse(pen, 0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
            }

            base.OnPaint(e);
        }
    }
}
