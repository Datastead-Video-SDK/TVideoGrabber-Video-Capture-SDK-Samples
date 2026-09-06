
namespace convert_avi_to_mp4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.mmoLog = new System.Windows.Forms.TextBox();
            this.btnStartProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "log:";
            // 
            // mmoLog
            // 
            this.mmoLog.Location = new System.Drawing.Point(11, 77);
            this.mmoLog.Multiline = true;
            this.mmoLog.Name = "mmoLog";
            this.mmoLog.Size = new System.Drawing.Size(793, 602);
            this.mmoLog.TabIndex = 7;
            // 
            // btnStartProcess
            // 
            this.btnStartProcess.Location = new System.Drawing.Point(12, 12);
            this.btnStartProcess.Name = "btnStartProcess";
            this.btnStartProcess.Size = new System.Drawing.Size(134, 28);
            this.btnStartProcess.TabIndex = 6;
            this.btnStartProcess.Text = "Start process";
            this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mmoLog);
            this.Controls.Add(this.btnStartProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mmoLog;
        private System.Windows.Forms.Button btnStartProcess;
    }
}

