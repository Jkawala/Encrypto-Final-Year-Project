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


namespace Encrypt.Ui
{
    public partial class SearchSpecific : Form
    {
        private bool cancelSearch = false;

        public SearchSpecific()
        {
            InitializeComponent();
          
    }

        private void menToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //this will clear all the cookies created by the page.

            this.Hide(); // Hide the current form.

            Main f2 = new Main();

            f2.Show();
        }

        private void SearchSpecific_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchDirTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void selectSearchFirButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            dlg.SelectedPath = searchDirTextBox.Text;
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                searchDirTextBox.Text = dlg.SelectedPath;
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            //Clear the results list
            resultsList.Items.Clear();

            Searchbtn.Enabled = false;
            Stopbtn.Enabled = true;

            // Set the progress bar's maximum value to the number of files that will be searched
            

            //Get the parameters for the search thread:
            if (Directory.Exists(searchDirTextBox.Text))
            {
                string[] files = Directory.GetFiles(searchDirTextBox.Text, "*.*", SearchOption.TopDirectoryOnly);

                foreach(string file in files)
                {
                    if (cancelSearch)
                    {
                        break;
                    }

                    

                    string fileName = Path.GetFileName(file); //file name 
                    string filePath = Path.GetDirectoryName(file); // Path of the file
                    DateTime lastModified = File.GetLastWriteTime(file); //The last time the file was modified
                    ulong fileSize = (ulong)new FileInfo(file).Length; //Get the file size 
                    string fileType = Path.GetExtension(file); //File type
                    string hashValue = GetFileHash(file); // Get the file hash 

                    //Convert the size of the file to KB,MB and GB value 
                    string fileSizeINKBMBGB = GetFileSizeInKBMBGB(fileSize);

                     ListViewItem item = new ListViewItem(new string[] { fileName, filePath, lastModified.ToString(), fileSizeINKBMBGB, fileType, hashValue });
                    resultsList.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("The directory path entered does not exist. ");
            }

            Searchbtn.Enabled = true;
            Stopbtn.Enabled = false;           
        }

        //gets the size and converts it into a readable string
        private string GetFileSizeInKBMBGB(ulong fileSize)
        {
            if (fileSize < 1024)
            {
                return fileSize.ToString() + " bytes";
            }
            else if (fileSize < 1024 * 1024)
            {
                return (fileSize / 1024.0).ToString("0.00") + " KB";
            }
            else if (fileSize < 1024 * 1024 * 1024)
            {
                return (fileSize / (1024.0 * 1024.0)).ToString("0.00") + " MB";
            }
            else
            {
                return (fileSize / (1024.0 * 1024.0 * 1024.0)).ToString("0.00") + " GB";
            }
        }

        //gets the hash value of the files 
        private string GetFileHash(string filePath)
{
    using (var md5 = System.Security.Cryptography.MD5.Create())
    {
        using (var stream = File.OpenRead(filePath))
        {
            var hash = md5.ComputeHash(stream);
            return BitConverter.ToString(hash).Replace("-", "").ToLowerInvariant();
        }
    }
}


        private void Stopbtn_Click(object sender, EventArgs e)
        {
            cancelSearch = true;
            Searchbtn.Enabled = true;
            Stopbtn.Enabled = true;
          
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (resultsList.Items.Count > 0)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV Files|*.csv";
                saveFileDialog.Title = "Save search results to CSV file";
                saveFileDialog.FileName = "search_results.csv";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;
                    // call a method to export the search results to the selected file
                    ExportToCsv(filePath);
                }
            }
            else
            {
                MessageBox.Show("No search results to export.");
            }
        }
        private void ExportToCsv(string filePath)
        {
            // Open the selected file for writing
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write the column headers to the file
                writer.WriteLine("File Name,File Path,Last Modified,Size,Type,Hash Value");

                // Write each search result to the file
                foreach (ListViewItem item in resultsList.Items)
                {
                    writer.WriteLine(string.Join(",", item.SubItems.Cast<ListViewItem.ListViewSubItem>().Select(subitem => subitem.Text)));
                }
            }

            MessageBox.Show("Search results exported to CSV file successfully.");
        }

        private void pbSearchProgress_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        //Delete a file in the list view
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(resultsList.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete the selected file?", "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string filePath = resultsList.SelectedItems[0].SubItems[1].Text + "\\" + resultsList.SelectedItems[0].Text;
                    File.Delete(filePath);
                    resultsList.Items.Remove(resultsList.SelectedItems[0]);
                }
            }
        }

        //Rename a file in the list view 
        private void btnRename_Click(object sender, EventArgs e)
        {
            if (resultsList.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = resultsList.SelectedItems[0];
                string fileName = selectedItem.Text;
                string filePath = selectedItem.SubItems[1].Text;
                string newFileName = Microsoft.VisualBasic.Interaction.InputBox("Enter a new name for the file:", "Rename File", fileName);
                if (!string.IsNullOrEmpty(newFileName))
                {
                    string newFilePath = filePath + "\\" + newFileName;
                    File.Move(filePath + "\\" + fileName, newFilePath);
                    selectedItem.Text = newFileName;
                    selectedItem.SubItems[5].Text = GetFileHash(newFilePath); // Update the hash value
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
        }

        //Create a new file in the ListView
        private void btnNewFile_Click(object sender, EventArgs e)
        {
            if(resultsList.SelectedItems.Count > 0) {
                string fileName = Microsoft.VisualBasic.Interaction.InputBox("Enter a name for the new file:", "New File", "Untitled.txt"); //Let A microsoft windows page create the file
                if (!string.IsNullOrEmpty(fileName))
                {
                    string filePath = searchDirTextBox.Text + "\\" + fileName;
                    if (!File.Exists(filePath))
                    {
                        File.Create(filePath).Close();
                        ListViewItem newItem = new ListViewItem(new string[] { fileName, searchDirTextBox.Text, filePath });
                        resultsList.Items.Add(newItem);
                    }
                    else
                    {
                        MessageBox.Show("A file with that name already exists in the selected directory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please search the list view.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
         
        }

        //Clear the results list
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (resultsList.SelectedItems.Count > 0)
            {
                resultsList.Items.Clear();

            }
            else
            {
                MessageBox.Show("Result Page cant be cleared.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
    }
}
