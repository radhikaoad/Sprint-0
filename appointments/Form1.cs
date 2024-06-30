using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using System.Device.Location;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using System.Security.AccessControl;
using System.Security.Principal;

namespace Calendar
{
     public partial class Form1 : Form
     {
          public const int WM_NCLBUTTONDOWN = 0xA1;
          public const int HT_CAPTION = 0x2;

          [DllImport("user32.dll")]
          public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
          [DllImport("user32.dll")]
          public static extern bool ReleaseCapture();

          int currentMonthCounter = 0;
          DateTime TODAY;

          CalndarGridItem selectedGridItem;
          Label previouslySelected;

          Dictionary<int, List<Event>> mEvents = new Dictionary<int, List<Event>>();
          public static String eventFileName = "C:\\appoint\\events.bin";

          public Form1()
          {
               GrantAccess("C:\\appoint");
               InitializeComponent();
               initView();
          }

          private void initView()
          {
               mainPanel.MouseDown += dragger_MouseDown;


               TODAY = DateTime.Today;
               selectedGridItem = new CalndarGridItem();
               previouslySelected = selectedGridItem.getTextView();

               selectedGridItem.setText(TODAY.Day + "");
               selectedGridItem.setDateTime(TODAY);

               nextMonthBtn.RotateLeft();
               prevMonthBtn.RotateRight();

               prevMonthBtn.addOnButtonClickHandler(new EventHandler(prevMonthBtn_onClick));
               nextMonthBtn.addOnButtonClickHandler(new EventHandler(nextMonthBtn_onClick));

               createGrid(0);

               String currenDayOfMonthString = (int)DateTime.Today.Day + "";


          }

          private void createGrid(int addMonth)
          {
               if (File.Exists(eventFileName))
               {
                    SaveXML<Dictionary<int, List<Event>>> saver = new SaveXML<Dictionary<int, List<Event>>>();
                    mEvents = saver.GetData(mEvents, eventFileName);
               }

               gridView.Controls.Clear();

               String[] months = {
                "sun",
                "mon",
                "tue",
                "wed",
                "thu",
                "fri",
                "sat"
            };

               for (int i = 0; i < 7; i++)
               {
                    CalndarGridItem item = new CalndarGridItem();
                    item.setText(months[i]);
                    item.setTextColor(Color.FromArgb(50, 63, 86));
                    gridView.Controls.Add(item);
               }

               DateTime temp;
               DateTime today = DateTime.Today;

               if (addMonth != 0)
                    today = today.AddMonths(addMonth);

               DateTime nextMonth = today.AddMonths(1);
               DateTime prevMonth = today.AddMonths(-1);

               temp = new DateTime(today.Year, today.Month, 1);
               int dayOfWeek = (int)temp.DayOfWeek;
               int dayOfPrevMonth = System.DateTime.DaysInMonth(prevMonth.Year, prevMonth.Month);

               for (int i = dayOfWeek - 1; i >= 0; i--)
               {
                    CalndarGridItem item = new CalndarGridItem();
                    item.setText((dayOfPrevMonth - i) + "");
                    item.setTextColor(Color.FromArgb(50, 63, 86));
                    gridView.Controls.Add(item);
               }

               int daysOfCurrentMonth = System.DateTime.DaysInMonth(today.Year, today.Month);

               for (int i = 1; i <= daysOfCurrentMonth; i++)
               {
                    CalndarGridItem item = new CalndarGridItem();
                    item.setText(i + "");

                    if (addMonth == 0 && i == (int)DateTime.Today.Day)
                         item.makeToDay();

                    item.setDateTime(today);
                    item.getTextView().Cursor = Cursors.Hand;
                    item.setOnGridItemClickListener(new EventHandler(onGridItemClickListener));

                    String key = i + " " + today.ToString("MMMM").Substring(0, 3) + " " + today.Year;

                    if (mEvents.ContainsKey(key.GetHashCode()))
                    {
                         if (addMonth <= 0 && i < TODAY.Day)
                              item.hadNote();
                         else
                              item.hasNote();
                    }

                    gridView.Controls.Add(item);
               }

               int daysOfNextMonth = dayOfWeek - 1 + daysOfCurrentMonth;

               for (int i = 1; i < 35 - daysOfNextMonth; i++)
               {
                    CalndarGridItem item = new CalndarGridItem();
                    item.setText(i + "");
                    item.setTextColor(Color.FromArgb(50, 63, 86));
                    gridView.Controls.Add(item);
               }

               currentMonth.Text = today.ToString("MMMM");
               currentYear.Text = today.Year + "";
          }

          private void prevMonthBtn_onClick(object sender, EventArgs e)
          {
               currentMonthCounter--;
               createGrid(currentMonthCounter);
          }

          private void nextMonthBtn_onClick(object sender, EventArgs e)
          {
               currentMonthCounter++;
               createGrid(currentMonthCounter);
          }


          private Bitmap changeColor(Bitmap sourceBitmap, float blueTint, float greenTint, float redTint)
          {
               BitmapData sourceData = sourceBitmap.LockBits(new Rectangle(0, 0,
                   sourceBitmap.Width, sourceBitmap.Height),
                   ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

               byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];
               Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
               sourceBitmap.UnlockBits(sourceData);

               float blue = 0;
               float green = 0;
               float red = 0;

               for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
               {
                    blue = pixelBuffer[k] + (255 - pixelBuffer[k]) * blueTint;
                    green = pixelBuffer[k + 1] + (255 - pixelBuffer[k + 1]) * greenTint;
                    red = pixelBuffer[k + 2] + (255 - pixelBuffer[k + 2]) * redTint;

                    if (blue > 255) { blue = 255; }
                    if (green > 255) { green = 255; }
                    if (red > 255) { red = 255; }

                    pixelBuffer[k] = (byte)blue;
                    pixelBuffer[k + 1] = (byte)green;
                    pixelBuffer[k + 2] = (byte)red;
               }

               Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
               BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                   resultBitmap.Width, resultBitmap.Height),
                   ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

               Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
               resultBitmap.UnlockBits(resultData);

               return resultBitmap;
          }

          private void initEventList()
          {
            
          }

          private void addNoteToDay_Click_1(object sender, EventArgs e)
          {
               Form2 dialog = new Form2();
               DateTime dt = TODAY;
               dt = dt.AddMonths(currentMonthCounter);
               dialog.getSelectedDayView().Text = previouslySelected.Text + " " + dt.ToString("MMMM").Substring(0, 3) + " " + dt.Year;

               DialogResult dr = dialog.ShowDialog();

               if (dr == DialogResult.OK)
               {
                    createGrid(currentMonthCounter);
                    startEventsList();
               }
          }

          private void onGridItemClickListener(object sender, EventArgs e)
          {
               previouslySelected.BorderStyle = BorderStyle.None;
               if (int.Parse(((Label)sender).Text.ToString()) != TODAY.Day)
                    ((Label)sender).BorderStyle = BorderStyle.Fixed3D;

               previouslySelected = ((Label)sender);
               startEventsList();
          }

          private void initEventsList(List<Event> events)
          {
               foreach (var evt in events)
               {
                    EventItem item = new EventItem();
                    item.getTime().Text = evt.getTime();
                    item.getLocation().Text = evt.getLocation();
                    item.getTitle().Text = evt.getTitle();
                    eventsScrollingView.Controls.Add(item);
               }
          }

          private void startEventsList()
          {
               DateTime temp = TODAY;
               temp = temp.AddMonths(currentMonthCounter);
               String key_temp = previouslySelected.Text + " " + temp.ToString("MMMM").Substring(0, 3) + " " + temp.Year;

               eventsScrollingView.Controls.Clear();

               if (mEvents.ContainsKey(key_temp.GetHashCode()))
                    initEventsList(mEvents[key_temp.GetHashCode()]);
               else
                    initEventsList(new List<Event>());
          }

          private void dragger_MouseDown(object sender, MouseEventArgs e)
          {
               if (e.Button == MouseButtons.Left)
               {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
               }
          }

          private void stopApp(object sender, EventArgs e)
          {
               Application.Exit();
          }

          private void GrantAccess(string fullPath)
          {
               if (!File.Exists(fullPath))
                    Directory.CreateDirectory(fullPath);

               DirectoryInfo dInfo = new DirectoryInfo(fullPath);
               DirectorySecurity dSecurity = dInfo.GetAccessControl();
               dSecurity.AddAccessRule(new FileSystemAccessRule("everyone", FileSystemRights.FullControl,
                   InheritanceFlags.ObjectInherit | InheritanceFlags.ContainerInherit,
                   PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
               dInfo.SetAccessControl(dSecurity);
          }

         
         
     }
}
