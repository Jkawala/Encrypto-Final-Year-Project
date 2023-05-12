using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Encrypt
{
    public partial class FullScan : Form
    {
        private DateTime searchStartTime;
        private int totalFilesToSearch;

        public FullScan()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this will clear all the cookies created by the page.

            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }

        private void FullScan_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("File Name", 200);
            listView1.Columns.Add("File Path", 300);
            listView1.Columns.Add("Date Modified", 100);
            listView1.Columns.Add("Type", 150);
            listView1.Columns.Add("Size", 100);
            listView1.View = View.Details;

            //The export button doesnt work until search has been completed 
            btnExport.Enabled = false;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            //current time of the search label
            searchStartTime = DateTime.Now;

            //Disable the start search button
            btnSearch.Enabled = false;

            //Clear any existing items from the listView
            listView1.Items.Clear();

            //Search for the files on the computer 
            try
            {
                string downloadPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";
                IEnumerable<string> files = RecursiveFileSearch(downloadPath, "*.*");
                totalFilesToSearch = files.Count();
                int filesSearched = 0;
                //Add each matching file to the listview
                foreach (string file in files)
                {
                    ListViewItem item = new ListViewItem(Path.GetFileName(file));
                    item.SubItems.Add(file);
                    item.SubItems.Add(File.GetLastWriteTime(file).ToString("dd/MM/yyyy HH:mm:ss"));
                    item.SubItems.Add(new FileInfo(file).Extension);
                    ulong size = (ulong)new FileInfo(file).Length;

                    string[] sizes = { "B", "KB", "MB", "GB" };
                    int i = 0;
                    while (size >= 1024 && i < sizes.Length - 1)
                    {
                        size /= 1024;
                        i++;
                    }
                    string formattedSize = $"{size} {sizes[i]}";
                    item.SubItems.Add(formattedSize);
                    listView1.Items.Add(item);

                    filesSearched++;
                    progressBar1.Value = (int)(((double)filesSearched / totalFilesToSearch) * 100);
                    progressBar1.Refresh();
                    progressBar1.CreateGraphics().DrawString("Searching file " + filesSearched.ToString() + " of " + totalFilesToSearch.ToString(),
                        new Font("Arial", (float)10.0, FontStyle.Regular),
                        Brushes.Black,
                        new PointF(progressBar1.Width / 2 - 100, progressBar1.Height / 2 - 7));

                    //caculate the elapsed time and update the searchStartTime
                    TimeSpan elapsedTime = DateTime.Now - searchStartTime;
                    lblSearchTime.Text = $"Search time: {elapsedTime.TotalSeconds.ToString("0.00")} seconds";

                    string systemInfo = GetSystemInfo();
                    lblSystemInfo.Text = systemInfo;
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred while searching for files: {ex.Message}");
            }

            //Re-enable the export button 
            btnExport.Enabled = true;

            //Re-enable the start search button 
            btnSearch.Enabled = true;

          
        }

        private IEnumerable<string> RecursiveFileSearch(string path, string pattern, ICollection<string> filePathCollector = null)
        {
            try
            {
                filePathCollector = filePathCollector ?? new LinkedList<string>();

                var matchingFilePaths = Directory.GetFiles(path, pattern)
                                                  .Where(file => file.EndsWith(".txt") || file.EndsWith(".doc"));

                foreach (var matchingFile in matchingFilePaths)
                {
                    filePathCollector.Add(matchingFile);
                }

                var subDirectories = Directory.EnumerateDirectories(path);

                foreach (var subDirectory in subDirectories)
                {
                    RecursiveFileSearch(subDirectory, pattern, filePathCollector);
                }

                return filePathCollector;
            }
            catch (Exception error)
            {
                bool isIgnorableError = error is PathTooLongException || error is UnauthorizedAccessException;

                if (isIgnorableError)
                {
                    return Enumerable.Empty<string>();
                }

                throw error;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Export_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
                            item.SubItems[0].Text,
                            item.SubItems[1].Text,
                            item.SubItems[2].Text,
                            item.SubItems[3].Text,
                            item.SubItems[4].Text);
                    }
                }
            }

        }

        private string GetSystemInfo()
        {
            string osName = Environment.OSVersion.VersionString;
            string processor = Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER");
            int processorCount = Environment.ProcessorCount;
            ulong totalMemory = new Microsoft.VisualBasic.Devices.ComputerInfo().TotalPhysicalMemory;

            string info = $"OS: {osName}\n";
            info += $"Processor: {processor} (x{processorCount})\n";
            info += $"Memory: {totalMemory / (1024 * 1024)} MB\n";

            return info;
        }

        private void SystemInformation_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void exportCSVFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        writer.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}",
                            item.SubItems[0].Text,
                            item.SubItems[1].Text,
                            item.SubItems[2].Text,
                            item.SubItems[3].Text,
                            item.SubItems[4].Text);
                    }
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "A digital forensic tool that analyses different aspects of a systems.\n" +
            "If there is an error with the repository please visit the link below\n" +
            "GitHub: https://github.com/wholetthedogsoutside/ \n\n");
        }

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string feedback = Microsoft.VisualBasic.Interaction.InputBox("Please enter your feedback:", "Feedback", "");
            if (feedback != "")
            {
                MessageBox.Show("Thank you for your feedback!");
                // You can add code here to send the feedback to a database or an email address.
            }
            else
            {
                MessageBox.Show("Failed to get Feedback form", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
            "Created by James Kawala\n" +
            "A digital forensic tool that analyses different aspects of a systems.\n" +
            "GitHub: https://github.com/wholetthedogsoutside/ \n\n" +
            "This project was done through research and online resources.");
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}

