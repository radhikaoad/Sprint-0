using System;
using System.Windows.Forms;

namespace Calendar
{
     public partial class Form4 : Form
     {
          public Form4()
          {
               InitializeComponent();
          }

          private void buttonContinue_Click(object sender, EventArgs e)
          {
               // Handle button click to continue
               string task = textBoxTask.Text.Trim();

               // Check if the task is "add appointment"
               if (task.ToLower() == "add appointment")
               {
                    MessageBox.Show("Navigating to add appointment form.", "Task Accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Navigate to Form1
                    Form1 form1 = new Form1();
                    form1.Show();

                    // Optionally hide Form4
                    this.Hide();
               }
               else
               {
                    // Example: Display the task in a message box
                    MessageBox.Show($"Task: {task}", "Task Added");

                    // Clear the task text box for the next entry
                    textBoxTask.Text = "";
               }
          }
     }
}
