using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Download_Manager
{
    public partial class AddUrlForm : Form
    {
        public AddUrlForm()
        {
            InitializeComponent();
        }

        public string url { get; set; }
        private void okbtn_Click(object sender, EventArgs e)
        {
            url = urltext.Text;
        }

        private void urltext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
