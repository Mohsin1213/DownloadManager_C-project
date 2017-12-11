using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Download_Manager
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select Your Path" })
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    pathtxt.Text = fbd.SelectedPath;
                }
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(pathtxt.Text))
            {
                Properties.Settings.Default.Path = pathtxt.Text;
                Properties.Settings.Default.Save();
                this.Close();
            }
            else
            {
                MessageBox.Show("Enter a correct path.", "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
