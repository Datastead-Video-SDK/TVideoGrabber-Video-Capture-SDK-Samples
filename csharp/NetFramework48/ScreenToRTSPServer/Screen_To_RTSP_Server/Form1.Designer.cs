namespace Screen_To_RTSP_Server
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
            this.btnPushToRTSPServer = new System.Windows.Forms.Button();
            this.panelPush = new System.Windows.Forms.Panel();
            this.chkShowPreview = new System.Windows.Forms.CheckBox();
            this.panelReceive = new System.Windows.Forms.Panel();
            this.btnPlayFromRTSPServer = new System.Windows.Forms.Button();
            this.URL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPushToRTSPServer
            // 
            this.btnPushToRTSPServer.Location = new System.Drawing.Point(201, 44);
            this.btnPushToRTSPServer.Name = "btnPushToRTSPServer";
            this.btnPushToRTSPServer.Size = new System.Drawing.Size(219, 40);
            this.btnPushToRTSPServer.TabIndex = 0;
            this.btnPushToRTSPServer.Text = "A) -> push screen to RTSP server";
            this.btnPushToRTSPServer.UseVisualStyleBackColor = true;
            this.btnPushToRTSPServer.Click += new System.EventHandler(this.btnPushToRTSPServer_Click);
            // 
            // panelPush
            // 
            this.panelPush.Location = new System.Drawing.Point(201, 99);
            this.panelPush.Name = "panelPush";
            this.panelPush.Size = new System.Drawing.Size(642, 442);
            this.panelPush.TabIndex = 1;
            // 
            // chkShowPreview
            // 
            this.chkShowPreview.AutoSize = true;
            this.chkShowPreview.Location = new System.Drawing.Point(437, 55);
            this.chkShowPreview.Name = "chkShowPreview";
            this.chkShowPreview.Size = new System.Drawing.Size(110, 20);
            this.chkShowPreview.TabIndex = 2;
            this.chkShowPreview.Text = "show preview";
            this.chkShowPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.chkShowPreview.UseVisualStyleBackColor = true;
            // 
            // panelReceive
            // 
            this.panelReceive.Location = new System.Drawing.Point(1087, 99);
            this.panelReceive.Name = "panelReceive";
            this.panelReceive.Size = new System.Drawing.Size(642, 442);
            this.panelReceive.TabIndex = 4;
            // 
            // btnPlayFromRTSPServer
            // 
            this.btnPlayFromRTSPServer.Location = new System.Drawing.Point(1087, 44);
            this.btnPlayFromRTSPServer.Name = "btnPlayFromRTSPServer";
            this.btnPlayFromRTSPServer.Size = new System.Drawing.Size(219, 40);
            this.btnPlayFromRTSPServer.TabIndex = 3;
            this.btnPlayFromRTSPServer.Text = "B) -> play A from RTSP server";
            this.btnPlayFromRTSPServer.UseVisualStyleBackColor = true;
            this.btnPlayFromRTSPServer.Click += new System.EventHandler(this.btnPlayFromRTSPServer_Click);
            // 
            // URL
            // 
            this.URL.Location = new System.Drawing.Point(244, 9);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(599, 22);
            this.URL.TabIndex = 5;
            this.URL.Text = "rtsp://127.0.0.1:8554/test_screen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1094, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(626, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "To quick test use the mediamtx RTSP server from https://github.com/bluenviron/med" +
    "iamtx/";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 99);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(173, 442);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(898, 99);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(173, 442);
            this.textBox2.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1759, 808);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.URL);
            this.Controls.Add(this.panelReceive);
            this.Controls.Add(this.btnPlayFromRTSPServer);
            this.Controls.Add(this.chkShowPreview);
            this.Controls.Add(this.panelPush);
            this.Controls.Add(this.btnPushToRTSPServer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPushToRTSPServer;
        private System.Windows.Forms.Panel panelPush;
        private System.Windows.Forms.CheckBox chkShowPreview;
        private System.Windows.Forms.Panel panelReceive;
        private System.Windows.Forms.Button btnPlayFromRTSPServer;
        private System.Windows.Forms.TextBox URL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

