using System;
using System.IO;
using System.Windows.Forms;

namespace Week_seven
{
    public partial class Form1 : Form
    {
        string filePath = "students.txt";

        public Form1()
        {
            InitializeComponent();
        }

        // 1. CREATE FILE
        private void btnCreate_Click(object sender, EventArgs e)
        {
            StreamWriter writer = File.CreateText(filePath);
            writer.Close();

            listBox1.Items.Clear();

            MessageBox.Show("File created successfully!");
        }

        // 2. WRITE DATA
        private void btnWrite_Click(object sender, EventArgs e)
        {
            StreamWriter writer = File.CreateText(filePath);

            string name = "Nimca";
            string course = "Computer Application";
            int age = 21;
            double mark = 85.5;

            writer.WriteLine("Student Information");
            writer.WriteLine("-------------------");

            writer.Write("Name: ");
            writer.WriteLine(name);

            writer.Write("Course: ");
            writer.WriteLine(course);

            writer.Write("Age: ");
            writer.WriteLine(age);

            writer.Write("Mark: ");
            writer.WriteLine(mark);

            writer.Close();

            MessageBox.Show("Data written successfully!");
        }

        // 3. READ FILE
        private void btnRead_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            listBox1.Items.Add("Student Name: Nimca");
            listBox1.Items.Add("Course: Computer Application");
            listBox1.Items.Add("Age: 21");
            listBox1.Items.Add("Mark: 85.5");
        }

        // 4. DELETE FILE
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);

                listBox1.Items.Clear();

                MessageBox.Show("File deleted successfully!");
            }
            else
            {
                MessageBox.Show("File does not exist!");
            }
        }

        // 5. APPEND TEXT
        private void btnAppend_Click(object sender, EventArgs e)
        {
            if (File.Exists(filePath))
            {
                StreamWriter writer = File.AppendText(filePath);

                writer.WriteLine("Subject: C# Programming");
                writer.WriteLine("Topic: File Handling");

                writer.Close();

                MessageBox.Show("Text appended successfully!");
            }
            else
            {
                MessageBox.Show("Create the file first!");
            }
        }

        // 6. SAVE FILE DIALOG
        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog1.FileName = "students.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer =
                    File.CreateText(saveFileDialog1.FileName);

                foreach (string item in listBox1.Items)
                {
                    writer.WriteLine(item);
                }

                writer.Close();

                MessageBox.Show("File saved successfully!");
            }
        }
    }
}