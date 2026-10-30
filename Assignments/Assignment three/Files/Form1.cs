using System;
using System.IO;
using System.Windows.Forms;

namespace Files
{
    public partial class Form1 : Form
    {
        string filePath = "students.txt";

        public Form1()
        {
            InitializeComponent();

            btnCreate.Click += btnCreate_Click;
            btnDelete.Click += btnDelete_Click;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            File.Create(filePath).Close();

            LsDisplay.Items.Add("File created successfully!");
        }

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
    }
}