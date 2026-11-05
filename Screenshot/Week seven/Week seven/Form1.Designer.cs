
namespace Week_seven
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCreate = new Button();
            btnWrite = new Button();
            btnRead = new Button();
            btnDelete = new Button();
            listBox1 = new ListBox();
            btnAppend = new Button();
            btnSave = new Button();
            saveFileDialog1 = new SaveFileDialog();
            saveFileDialog2 = new SaveFileDialog();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(55, 70);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 0;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(55, 130);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(112, 34);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(55, 185);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(112, 34);
            btnRead.TabIndex = 2;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(55, 234);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(294, 52);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 279);
            listBox1.TabIndex = 4;
            // 
            // btnAppend
            // 
            btnAppend.Location = new Point(55, 283);
            btnAppend.Name = "btnAppend";
            btnAppend.Size = new Size(112, 34);
            btnAppend.TabIndex = 5;
            btnAppend.Text = "Append";
            btnAppend.UseVisualStyleBackColor = true;
            btnAppend.Click += btnAppend_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(55, 333);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(btnAppend);
            Controls.Add(listBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnRead);
            Controls.Add(btnWrite);
            Controls.Add(btnCreate);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button btnCreate;
        private Button btnWrite;
        private Button btnRead;
        private Button btnDelete;
        private ListBox listBox1;
        private Button btnAppend;
        private Button btnSave;
        private SaveFileDialog saveFileDialog1;
        private SaveFileDialog saveFileDialog2;
    }
}
