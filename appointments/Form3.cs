using System;
using System.Windows.Forms;

namespace Calendar
{
     public partial class Form3 : Form
     {
          public Form3()
          {
               InitializeComponent();
          }

          private void buttonLogin_Click(object sender, EventArgs e)
          {
               string username = textBoxUsername.Text;
               string password = textBoxPassword.Text;

               // Example validation (replace with your actual validation logic)
               if (username == "admin" && password == "password123")
               {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Navigate to another form or perform other actions
                    // For example, open Form1 (replace with your actual form name)
                    Form4 form4 = new Form4();
                    form4.Show();
                    this.Hide(); // Hide the login form if needed
               }
               else
               {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               }
          }
     }
}
