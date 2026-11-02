using System;
using System.IO;
using System.Windows.Forms;

namespace Files
{
    public partial class Form1 : Form
    {
        string filePath = "student.txt";

        public Form1()
        {
            InitializeComponent();

            btnCreate.Click += btnCreate_Click;
            btnDelete.Click += btnDelete_Click;
            btnWrite.Click += btnWrite_Click;
        }

        // CREATE FILE
        private void btnCreate_Click(object sender, EventArgs e)
        {
            StreamWriter writing_file = File.CreateText(filePath);

            writing_file.Close();

            LsDisplay.Items.Add("File created successfully!");
        }

        // DELETE FILE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
                LsDisplay.Items.Add("File deleted successfully!");
            }
            else
            {
                LsDisplay.Items.Add("File does not exist!");
            }
        }

        // WRITE FILE
        private void btnWrite_Click(object sender, EventArgs e)
        {
            StreamWriter writing_file = File.AppendText(filePath);

            writing_file.WriteLine("Hello Nimca!");

            writing_file.Close();

            LsDisplay.Items.Add("Data written successfully!");
        }
    }
}