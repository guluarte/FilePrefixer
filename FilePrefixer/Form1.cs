using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilePrefixer
{
    public partial class Form : System.Windows.Forms.Form
    {
   
        public Form()
        {
            InitializeComponent();
        }

        private void btnBroweser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();

            txtDir.Text = fbd.SelectedPath;
        }

        private void btnPrefix_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDir.Text))
            {
                return;
            }

            var files = new List<string>(Directory.GetFiles(txtDir.Text));

            files?.ForEach(f =>
            {
                var fileInfo = new FileInfo(f);
                var newFileName = string.Format("{0}\\{1}{2}", fileInfo.Directory, txtPrefix.Text, fileInfo.Name);

                Task.Run(() => { File.Move(f, newFileName); });

                Application.DoEvents();
            });

            MessageBox.Show("Renamed Completed.");
        }
    }
}
