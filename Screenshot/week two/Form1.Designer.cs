namespace week2
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
            lblFirName = new Label();
            lblSecName = new Label();
            TextSecondName = new TextBox();
            TextFirstName = new TextBox();
            Btn = new Button();
            Btnclear = new Button();
            lblouput = new Label();
            lblLastName = new Label();
            TextLastName = new TextBox();
            SuspendLayout();
            // 
            // lblFirName
            // 
            lblFirName.AutoSize = true;
            lblFirName.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFirName.Location = new Point(25, 39);
            lblFirName.Name = "lblFirName";
            lblFirName.Size = new Size(216, 25);
            lblFirName.TabIndex = 0;
            lblFirName.Text = "Enter Your First Name :\r\n";
            // 
            // lblSecName
            // 
            lblSecName.AutoSize = true;
            lblSecName.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSecName.Location = new Point(12, 89);
            lblSecName.Name = "lblSecName";
            lblSecName.Size = new Size(243, 50);
            lblSecName.TabIndex = 1;
            lblSecName.Text = "Enter Your Second Name :\r\n\r\n";
            lblSecName.Click += label2_Click;
            // 
            // TextSecondName
            // 
            TextSecondName.BorderStyle = BorderStyle.FixedSingle;
            TextSecondName.Location = new Point(259, 87);
            TextSecondName.Name = "TextSecondName";
            TextSecondName.Size = new Size(257, 31);
            TextSecondName.TabIndex = 2;
            // 
            // TextFirstName
            // 
            TextFirstName.BorderStyle = BorderStyle.FixedSingle;
            TextFirstName.Location = new Point(259, 37);
            TextFirstName.Multiline = true;
            TextFirstName.Name = "TextFirstName";
            TextFirstName.Size = new Size(257, 31);
            TextFirstName.TabIndex = 3;
            // 
            // Btn
            // 
            Btn.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btn.Location = new Point(80, 255);
            Btn.Name = "Btn";
            Btn.Size = new Size(108, 66);
            Btn.TabIndex = 4;
            Btn.Text = "Concat";
            Btn.UseVisualStyleBackColor = true;
            Btn.Click += Btn_Click;
            // 
            // Btnclear
            // 
            Btnclear.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Btnclear.Location = new Point(440, 255);
            Btnclear.Name = "Btnclear";
            Btnclear.Size = new Size(108, 66);
            Btnclear.TabIndex = 5;
            Btnclear.Text = "Clear";
            Btnclear.UseVisualStyleBackColor = true;
            Btnclear.Click += Btnclear_Click;
            // 
            // lblouput
            // 
            lblouput.BorderStyle = BorderStyle.FixedSingle;
            lblouput.Location = new Point(25, 189);
            lblouput.Name = "lblouput";
            lblouput.Size = new Size(510, 53);
            lblouput.TabIndex = 6;
            lblouput.TextAlign = ContentAlignment.MiddleCenter;
            lblouput.Click += lblouput_Click;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Historic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLastName.Location = new Point(25, 139);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(213, 50);
            lblLastName.TabIndex = 7;
            lblLastName.Text = "Enter Your Last Name :\r\n\r\n";
            // 
            // TextLastName
            // 
            TextLastName.BorderStyle = BorderStyle.FixedSingle;
            TextLastName.Location = new Point(259, 139);
            TextLastName.Name = "TextLastName";
            TextLastName.Size = new Size(257, 31);
            TextLastName.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextLastName);
            Controls.Add(lblLastName);
            Controls.Add(lblouput);
            Controls.Add(Btnclear);
            Controls.Add(Btn);
            Controls.Add(TextFirstName);
            Controls.Add(TextSecondName);
            Controls.Add(lblSecName);
            Controls.Add(lblFirName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFirName;
        private Label lblSecName;
        private TextBox TextSecondName;
        private TextBox TextFirstName;
        private Button Btn;
        private Button Btnclear;
        private Label lblouput;
        private Label lblLastName;
        private TextBox TextLastName;
    }
}
