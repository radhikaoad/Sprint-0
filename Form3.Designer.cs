namespace Calendar
{
     partial class Form3
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

          #region Windows Form Designer generated code

          private void InitializeComponent()
          {
               this.labelUsername = new System.Windows.Forms.Label();
               this.labelPassword = new System.Windows.Forms.Label();
               this.textBoxUsername = new System.Windows.Forms.TextBox();
               this.textBoxPassword = new System.Windows.Forms.TextBox();
               this.buttonLogin = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // labelUsername
               // 
               this.labelUsername.AutoSize = true;
               this.labelUsername.Location = new System.Drawing.Point(30, 30);
               this.labelUsername.Name = "labelUsername";
               this.labelUsername.Size = new System.Drawing.Size(73, 17);
               this.labelUsername.TabIndex = 0;
               this.labelUsername.Text = "Username:";
               // 
               // labelPassword
               // 
               this.labelPassword.AutoSize = true;
               this.labelPassword.Location = new System.Drawing.Point(30, 70);
               this.labelPassword.Name = "labelPassword";
               this.labelPassword.Size = new System.Drawing.Size(73, 17);
               this.labelPassword.TabIndex = 1;
               this.labelPassword.Text = "Password:";
               // 
               // textBoxUsername
               // 
               this.textBoxUsername.Location = new System.Drawing.Point(110, 27);
               this.textBoxUsername.Name = "textBoxUsername";
               this.textBoxUsername.Size = new System.Drawing.Size(150, 22);
               this.textBoxUsername.TabIndex = 2;
               // 
               // textBoxPassword
               // 
               this.textBoxPassword.Location = new System.Drawing.Point(110, 67);
               this.textBoxPassword.Name = "textBoxPassword";
               this.textBoxPassword.PasswordChar = '*';
               this.textBoxPassword.Size = new System.Drawing.Size(150, 22);
               this.textBoxPassword.TabIndex = 3;
               // 
               // buttonLogin
               // 
               this.buttonLogin.Location = new System.Drawing.Point(110, 110);
               this.buttonLogin.Name = "buttonLogin";
               this.buttonLogin.Size = new System.Drawing.Size(75, 23);
               this.buttonLogin.TabIndex = 4;
               this.buttonLogin.Text = "Login";
               this.buttonLogin.UseVisualStyleBackColor = true;
               this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
               // 
               // Form3
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(282, 253);
               this.Controls.Add(this.buttonLogin);
               this.Controls.Add(this.textBoxPassword);
               this.Controls.Add(this.textBoxUsername);
               this.Controls.Add(this.labelPassword);
               this.Controls.Add(this.labelUsername);
               this.Name = "Form3";
               this.Text = "Login";
               this.ResumeLayout(false);
               this.PerformLayout();
          }

          #endregion

          private System.Windows.Forms.Label labelUsername;
          private System.Windows.Forms.Label labelPassword;
          private System.Windows.Forms.TextBox textBoxUsername;
          private System.Windows.Forms.TextBox textBoxPassword;
          private System.Windows.Forms.Button buttonLogin;
     }
}

