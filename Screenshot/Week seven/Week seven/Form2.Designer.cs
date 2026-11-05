namespace Week_seven
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            btnAppend = new Button();
            listBox1 = new ListBox();
            btnDelete = new Button();
            btnRead = new Button();
            btnWrite = new Button();
            btnCreate = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(17, 345);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAppend
            // 
            btnAppend.Location = new Point(17, 295);
            btnAppend.Name = "btnAppend";
            btnAppend.Size = new Size(112, 34);
            btnAppend.TabIndex = 12;
            btnAppend.Text = "Append";
            btnAppend.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(256, 64);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 279);
            listBox1.TabIndex = 11;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(17, 246);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(17, 197);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(112, 34);
            btnRead.TabIndex = 9;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(17, 142);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(112, 34);
            btnWrite.TabIndex = 8;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(17, 82);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(112, 34);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // Form2
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
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Button btnAppend;
        private ListBox listBox1;
        private Button btnDelete;
        private Button btnRead;
        private Button btnWrite;
        private Button btnCreate;
    }
}