namespace Download_Manager
{
    partial class MainForm
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tsaddurl = new System.Windows.Forms.ToolStripButton();
            this.tsremove = new System.Windows.Forms.ToolStripButton();
            this.tssetting = new System.Windows.Forms.ToolStripButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsaddurl,
            this.toolStripSeparator2,
            this.tsremove,
            this.toolStripSeparator3,
            this.tssetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(623, 80);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 80);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 80);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(623, 276);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tsaddurl
            // 
            this.tsaddurl.AutoSize = false;
            this.tsaddurl.Image = global::Download_Manager.Properties.Resources._1492747712_link;
            this.tsaddurl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsaddurl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsaddurl.Name = "tsaddurl";
            this.tsaddurl.Size = new System.Drawing.Size(75, 75);
            this.tsaddurl.Text = "Add URL";
            this.tsaddurl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsaddurl.Click += new System.EventHandler(this.tsaddurl_Click);
            // 
            // tsremove
            // 
            this.tsremove.AutoSize = false;
            this.tsremove.Image = global::Download_Manager.Properties.Resources._1492747837_delete;
            this.tsremove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsremove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsremove.Name = "tsremove";
            this.tsremove.Size = new System.Drawing.Size(75, 75);
            this.tsremove.Text = "Remove";
            this.tsremove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsremove.Click += new System.EventHandler(this.tsremove_Click);
            // 
            // tssetting
            // 
            this.tssetting.AutoSize = false;
            this.tssetting.Image = global::Download_Manager.Properties.Resources._1492747789_setting;
            this.tssetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tssetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tssetting.Name = "tssetting";
            this.tssetting.Size = new System.Drawing.Size(75, 75);
            this.tssetting.Text = "Setting";
            this.tssetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tssetting.Click += new System.EventHandler(this.tssetting_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "URL";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Name";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date Time";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 356);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsaddurl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsremove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tssetting;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

