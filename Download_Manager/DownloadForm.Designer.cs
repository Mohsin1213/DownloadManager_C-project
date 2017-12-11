namespace Download_Manager
{
    partial class DownloadForm
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
            this.addresstext = new System.Windows.Forms.TextBox();
            this.pathtxt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.statuslbl = new System.Windows.Forms.Label();
            this.startbtn = new System.Windows.Forms.Button();
            this.stopbtn = new System.Windows.Forms.Button();
            this.browsebtn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Address:";
            // 
            // addresstext
            // 
            this.addresstext.Location = new System.Drawing.Point(69, 24);
            this.addresstext.Name = "addresstext";
            this.addresstext.ReadOnly = true;
            this.addresstext.Size = new System.Drawing.Size(501, 20);
            this.addresstext.TabIndex = 1;
            // 
            // pathtxt2
            // 
            this.pathtxt2.Location = new System.Drawing.Point(69, 59);
            this.pathtxt2.Name = "pathtxt2";
            this.pathtxt2.Size = new System.Drawing.Size(501, 20);
            this.pathtxt2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Path:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(69, 86);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(501, 23);
            this.progressBar.TabIndex = 4;
            // 
            // statuslbl
            // 
            this.statuslbl.AutoSize = true;
            this.statuslbl.Location = new System.Drawing.Point(267, 122);
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(87, 13);
            this.statuslbl.TabIndex = 5;
            this.statuslbl.Text = "Downloaded 0 %";
            // 
            // startbtn
            // 
            this.startbtn.Location = new System.Drawing.Point(414, 157);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(75, 23);
            this.startbtn.TabIndex = 6;
            this.startbtn.Text = "Start";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // stopbtn
            // 
            this.stopbtn.Location = new System.Drawing.Point(495, 157);
            this.stopbtn.Name = "stopbtn";
            this.stopbtn.Size = new System.Drawing.Size(75, 23);
            this.stopbtn.TabIndex = 7;
            this.stopbtn.Text = "Stop";
            this.stopbtn.UseVisualStyleBackColor = true;
            this.stopbtn.Click += new System.EventHandler(this.stopbtn_Click);
            // 
            // browsebtn2
            // 
            this.browsebtn2.Location = new System.Drawing.Point(576, 57);
            this.browsebtn2.Name = "browsebtn2";
            this.browsebtn2.Size = new System.Drawing.Size(43, 23);
            this.browsebtn2.TabIndex = 8;
            this.browsebtn2.Text = "...";
            this.browsebtn2.UseVisualStyleBackColor = true;
            this.browsebtn2.Click += new System.EventHandler(this.browsebtn2_Click);
            // 
            // DownloadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 189);
            this.Controls.Add(this.browsebtn2);
            this.Controls.Add(this.stopbtn);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.statuslbl);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.pathtxt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addresstext);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "DownloadForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DownloadForm";
            this.Load += new System.EventHandler(this.DownloadForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addresstext;
        private System.Windows.Forms.TextBox pathtxt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label statuslbl;
        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.Button stopbtn;
        private System.Windows.Forms.Button browsebtn2;
    }
}