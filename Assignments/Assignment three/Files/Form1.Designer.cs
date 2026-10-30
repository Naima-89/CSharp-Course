
namespace Files
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
            LsDisplay = new ListBox();
            btnCreate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // LsDisplay
            // 
            LsDisplay.FormattingEnabled = true;
            LsDisplay.ItemHeight = 25;
            LsDisplay.Location = new Point(748, 12);
            LsDisplay.Name = "LsDisplay";
            LsDisplay.Size = new Size(257, 429);
            LsDisplay.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(191, 189);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(178, 76);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(12, 271);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(178, 76);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 450);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(LsDisplay);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
                //throw new NotImplementedException();
        }

        #endregion

        private ListBox LsDisplay;
        private Button btnCreate;
        private Button btnDelete;
    }
}
