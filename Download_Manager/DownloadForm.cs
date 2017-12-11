using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Download_Manager
{
    public partial class DownloadForm : Form
    {
        public DownloadForm(MainForm form)
        {
            InitializeComponent();
            mf = form;
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            Uri uri = new Uri(this.Url);
            FileName = System.IO.Path.GetFileName(uri.AbsolutePath);
            client.DownloadFileAsync(uri, Properties.Settings.Default.Path + "/" + FileName);
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            client.CancelAsync();
        }

        private void browsebtn2_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select your path."})
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    pathtxt2.Text = fbd.SelectedPath;
                    Properties.Settings.Default.Path = pathtxt2.Text;
                    Properties.Settings.Default.Save();
                }
            }
        }

        WebClient client;
        public string Url { get; set; }
        public string FileName { get; set; }
        public double FileSize { get; set; }
        public double Percentage { get; set; }
        private MainForm mf;
        private void DownloadForm_Load(object sender, EventArgs e)
        {
            client = new WebClient();
            client.DownloadProgressChanged += Client_DownloadProgressChanged;
            client.DownloadFileCompleted += Client_DownloadFileCompleted;
            addresstext.Text = Url;
            pathtxt2.Text = Properties.Settings.Default.Path;
        }

        private void Client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            DataBase.FilesRow row = App.DB.Files.NewFilesRow();
            row.Url = Url;
            row.FileName = FileName;
            row.FileSize = (string.Format("{0:0.##} kb", FileSize/1024));
            row.DateTime = DateTime.Now;
            App.DB.Files.AddFilesRow(row);
            App.DB.AcceptChanges();
            App.DB.WriteXml(string.Format("{0}/data.dat", Application.StartupPath));
            ListViewItem list = new ListViewItem(row.ID.ToString());
            list.SubItems.Add(row.Url);
            list.SubItems.Add(row.FileName);
            list.SubItems.Add(row.FileSize);
            list.SubItems.Add(row.DateTime.ToLongDateString());
            mf.listView1.Items.Add(list);
            this.Close();
        }

        private void Client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            //progressBar.Minimum = 0;
            //double recieve = double.Parse(e.BytesReceived.ToString());
            //FileSize = double.Parse(e.TotalBytesToReceive.ToString());
            //Percentage = recieve / FileSize * 100;
            //statuslbl.Text = $"Donwloaded {string.Format("{0:0.##}", Percentage)}";
            //progressBar.Value = int.Parse(Math.Truncate(Percentage).ToString());
            //progressBar.Update();
           client.DownloadFileCompleted += new AsyncCompletedEventHandler(FileCompleteDownload);
            Uri imageUrl = new Uri(addresstext.Text);
            client.DownloadFileAsync(imageUrl, "MyDownloadImage.png");
        }
        private void FileCompleteDownload(object sender, AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Download Completed");
        }
    }
}
