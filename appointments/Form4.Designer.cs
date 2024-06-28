namespace Calendar
{
     partial class Form4
     {
          /// <summary>
          /// Required designer variable.
          /// </summary>
          private System.ComponentModel.IContainer components = null;

          /// <summary>
          /// Clean up any resources being used.
          /// </summary>
          /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          protected override void Dispose(bool disposing)
          {
               if (disposing && (components != null))
               {
                    components.Dispose();
               }
               base.Dispose(disposing);
          }

          #region Windows Form Designer generated code

          /// <summary>
          /// Required method for Designer support - do not modify
          /// the contents of this method with the code editor.
          /// </summary>
          private void InitializeComponent()
          {
               this.labelTask = new System.Windows.Forms.Label();
               this.textBoxTask = new System.Windows.Forms.TextBox();
               this.buttonContinue = new System.Windows.Forms.Button();
               this.SuspendLayout();
               // 
               // labelTask
               // 
               this.labelTask.AutoSize = true;
               this.labelTask.Location = new System.Drawing.Point(30, 30);
               this.labelTask.Name = "labelTask";
               this.labelTask.Size = new System.Drawing.Size(41, 17);
               this.labelTask.TabIndex = 0;
               this.labelTask.Text = "Task:";
               // 
               // textBoxTask
               // 
               this.textBoxTask.Location = new System.Drawing.Point(130, 27);
               this.textBoxTask.Name = "textBoxTask";
               this.textBoxTask.Size = new System.Drawing.Size(200, 22);
               this.textBoxTask.TabIndex = 1;
               // 
               // buttonContinue
               // 
               this.buttonContinue.Location = new System.Drawing.Point(130, 70);
               this.buttonContinue.Name = "buttonContinue";
               this.buttonContinue.Size = new System.Drawing.Size(100, 30);
               this.buttonContinue.TabIndex = 2;
               this.buttonContinue.Text = "Continue";
               this.buttonContinue.UseVisualStyleBackColor = true;
               this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
               // 
               // MainForm
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(370, 130);
               this.Controls.Add(this.buttonContinue);
               this.Controls.Add(this.textBoxTask);
               this.Controls.Add(this.labelTask);
               this.Name = "MainForm";
               this.Text = "Task Form";
               this.ResumeLayout(false);
               this.PerformLayout();
          }

          #endregion

          private System.Windows.Forms.Label labelTask;
          private System.Windows.Forms.TextBox textBoxTask;
          private System.Windows.Forms.Button buttonContinue;
     }
}

