using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace MyMiniExplorer
{
    public partial class ExplorerForm : Form
    {

        private DriveInfo[] drives = DriveInfo.GetDrives();

        public ExplorerForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ExplorerForm_Load(object sender, EventArgs e)
        {
            comboBoxDisk.Items.AddRange(drives
            .Select(el => el.Name)
                .ToArray());
            comboBoxDisk.SelectedIndex = 0;
            listBoxFiles.Items.Add("Select catalog");
        }
    }
}
