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
        List<Tuple<DateTime, string>> openedApps = new List<Tuple<DateTime, string>>();

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

        private string[] getDirectoriesAndFiles(string path)
        {
            List<string> array = new List<string>();
            array.AddRange(Directory.GetDirectories(path));
            array.AddRange(Directory.GetFiles(path));

            return array.ToArray();
        }

        private string getFormatSize(long size)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = size;
            int order = 0;
            while (len >= 1024)
            {
                order++;
                len /= 1024;
            }
            return $"{len:0.##} {sizes[order]}";
        }

        private void saveOpened(string path)
        {
            openedApps.Add(new Tuple<DateTime, string>(DateTime.Now, path));
        }

        private void comboBoxDisk_SelectedIndexChanged(object sender, EventArgs e)
        {
            DriveInfo selectedDrive = drives[comboBoxDisk.SelectedIndex];

            listBoxCatalogs.Items.Clear();
            listBoxCatalogs.Items.AddRange(getDirectoriesAndFiles(selectedDrive.Name));

            DriveSpaceLabel.Text =
                $"Total Size: {getFormatSize(selectedDrive.TotalSize)}\n" +
                $"Available Free Space: {getFormatSize(selectedDrive.AvailableFreeSpace)}\n";
        }

        private void listBoxCatalogs_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dirName = listBoxCatalogs.Items[listBoxCatalogs.SelectedIndex].ToString();
            listBoxFiles.Items.Clear();
            listBoxFiles.Items.AddRange(getDirectoriesAndFiles(dirName));

            DirectoryInfo selectedDirectory = new DirectoryInfo(dirName);

            CatalogPropLable.Text =
                    $"Full name: {selectedDirectory.FullName}\n" +
                    $"Creation Time: {selectedDirectory.CreationTime}\n" +
                    $"Root: {selectedDirectory.Root}";
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dirName = listBoxFiles.Items[listBoxFiles.SelectedIndex].ToString();
            DirectoryInfo selectedDirectory = new DirectoryInfo(dirName);

            FilePropLable.Text =
                $"Full name: {selectedDirectory.FullName}\n" +
                $"Creation Time: {selectedDirectory.CreationTime}\n" +
                $"Root: {selectedDirectory.Root}";
        }

        private void listBoxCatalogs_DoubleClick(object sender, EventArgs e)
        {
            string dirName = listBoxCatalogs.Items[listBoxCatalogs.SelectedIndex].ToString();
            saveOpened(dirName);
            Process.Start(dirName);
        }

        private void listBoxFiles_DoubleClick(object sender, EventArgs e)
        {
            string dirName = listBoxFiles.Items[listBoxFiles.SelectedIndex].ToString();
            saveOpened(dirName);
            Process.Start(dirName);
        }
    }
}
