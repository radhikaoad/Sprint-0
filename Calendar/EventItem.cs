using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Calendar
{
     public partial class EventItem : UserControl
     {
          public EventItem()
          {
               InitializeComponent();
               RoundBorderForm(brightPanel);
          }

          private void panel1_Paint(object sender, PaintEventArgs e)
          {
               // Optional: Implement painting logic for panel1
          }

          public static void RoundBorderForm(Panel frm)
          {
               Rectangle bounds = new Rectangle(0, 0, frm.Width, frm.Height);
               int cornerRadius = 20;
               GraphicsPath path = new GraphicsPath();
               path.AddArc(bounds.X, bounds.Y, cornerRadius, cornerRadius, 180, 90);
               path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y, cornerRadius, cornerRadius, 270, 90);
               path.AddArc(bounds.X + bounds.Width - cornerRadius, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 0, 90);
               path.AddArc(bounds.X, bounds.Y + bounds.Height - cornerRadius, cornerRadius, cornerRadius, 90, 90);
               path.CloseAllFigures();

               frm.Region = new Region(path);
          }

          public Label getTime()
          {
               return time;
          }

          public Label getTitle()
          {
               return title;
          }

          public Label getLocation()
          {
               return location;
          }

          private void title_Click(object sender, EventArgs e)
          {
               // Optional: Handle click event for title label
          }

          private void brightPanel_Paint(object sender, PaintEventArgs e)
          {
               // Optional: Implement painting logic for brightPanel
          }

          private void location_Click(object sender, EventArgs e)
          {
               // Optional: Handle click event for location label
          }
     }
}

