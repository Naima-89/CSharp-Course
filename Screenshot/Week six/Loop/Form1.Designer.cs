namespace Loop
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
            lsbox = new ListBox();
            btnShow = new Button();
            SuspendLayout();
            // 
            // lsbox
            // 
            lsbox.FormattingEnabled = true;
            lsbox.ItemHeight = 25;
            lsbox.Location = new Point(485, 25);
            lsbox.Name = "lsbox";
            lsbox.Size = new Size(224, 304);
            lsbox.TabIndex = 0;
            // 
            // btnShow
            // 
            btnShow.BackColor = SystemColors.AppWorkspace;
            btnShow.Location = new Point(529, 354);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(143, 68);
            btnShow.TabIndex = 1;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = false;
            btnShow.Click += btnShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnShow);
            Controls.Add(lsbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lsbox;
        private Button btnShow;
    }
}
