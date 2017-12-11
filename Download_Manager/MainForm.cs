using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Download_Manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tssetting_Click(object sender, EventArgs e)
        {
            using (SettingForm sf = new SettingForm())
            {
                sf.ShowDialog();
            }
        }

        private void tsaddurl_Click(object sender, EventArgs e)
        {
            using (AddUrlForm urlform = new AddUrlForm())
            {
                if (urlform.ShowDialog() == DialogResult.OK)
                {
                    DownloadForm downform = new DownloadForm(this);
                    downform.Url = urlform.url;
                    downform.Show();
                }
            }
        }

        private void tsremove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this record?","Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                for (int i = listView1.SelectedItems.Count; i > 0; i--)
                {
                    ListViewItem list = listView1.SelectedItems[i - 1];
                    App.DB.Files.Rows[list.Index].Delete();
                    listView1.Items[list.Index].Remove();
                }
                App.DB.AcceptChanges();
                App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string filename = string.Format("{0}/data.dat", Application.StartupPath);
            if (File.Exists(filename))
            {
                App.DB.ReadXml(filename);
            }
            foreach (DataBase.FilesRow row in App.DB.Files)
            {
                ListViewItem list = new ListViewItem(row.ID.ToString());
                list.SubItems.Add(row.Url);
                list.SubItems.Add(row.FileName);
                list.SubItems.Add(row.FileSize);
                list.SubItems.Add(row.DateTime.ToLongDateString());
                listView1.Items.Add(list);
            }
        }
    }
}
