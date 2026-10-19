namespace Homework
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            panel1 = new Panel();
            txtAge = new TextBox();
            lblexperience = new Label();
            label1 = new Label();
            txtexperience = new TextBox();
            lblAge = new Label();
            txtdays = new TextBox();
            txtName = new TextBox();
            lblName = new Label();
            lbldays = new Label();
            panel2 = new Panel();
            label3 = new Label();
            lblCar = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            rdoLuxury = new RadioButton();
            rdoSUV = new RadioButton();
            rdoEconomy = new RadioButton();
            lbltype = new Label();
            panel4 = new Panel();
            chkInsurance = new CheckBox();
            lblOption = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            lsrental = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSteelBlue;
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(lblexperience);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtexperience);
            panel1.Controls.Add(lblAge);
            panel1.Controls.Add(txtdays);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lbldays);
            panel1.Location = new Point(12, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(541, 207);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(271, 86);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(231, 31);
            txtAge.TabIndex = 12;
            // 
            // lblexperience
            // 
            lblexperience.AutoSize = true;
            lblexperience.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblexperience.ForeColor = SystemColors.ActiveCaptionText;
            lblexperience.Location = new Point(9, 165);
            lblexperience.Name = "lblexperience";
            lblexperience.Size = new Size(247, 50);
            lblexperience.TabIndex = 15;
            lblexperience.Text = "Years Of Driving Expereince\r\n\r\n";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(41, 11);
            label1.Name = "label1";
            label1.Size = new Size(229, 28);
            label1.TabIndex = 1;
            label1.Text = "Customer Information";
            // 
            // txtexperience
            // 
            txtexperience.BorderStyle = BorderStyle.FixedSingle;
            txtexperience.Location = new Point(271, 165);
            txtexperience.Multiline = true;
            txtexperience.Name = "txtexperience";
            txtexperience.Size = new Size(231, 31);
            txtexperience.TabIndex = 16;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.ForeColor = SystemColors.ActiveCaptionText;
            lblAge.Location = new Point(84, 92);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(132, 25);
            lblAge.TabIndex = 11;
            lblAge.Text = "Customer Age";
            // 
            // txtdays
            // 
            txtdays.BorderStyle = BorderStyle.FixedSingle;
            txtdays.Location = new Point(271, 128);
            txtdays.Multiline = true;
            txtdays.Name = "txtdays";
            txtdays.Size = new Size(231, 31);
            txtdays.TabIndex = 14;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(271, 46);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 31);
            txtName.TabIndex = 10;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.ForeColor = SystemColors.ActiveCaptionText;
            lblName.Location = new Point(84, 52);
            lblName.Name = "lblName";
            lblName.Size = new Size(148, 25);
            lblName.TabIndex = 9;
            lblName.Text = "Customer Name";
            // 
            // lbldays
            // 
            lbldays.AutoSize = true;
            lbldays.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbldays.ForeColor = SystemColors.ActiveCaptionText;
            lbldays.Location = new Point(12, 134);
            lbldays.Name = "lbldays";
            lbldays.Size = new Size(221, 25);
            lbldays.TabIndex = 13;
            lbldays.Text = "Numbers Of Rental Days";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(label3);
            panel2.Controls.Add(lblCar);
            panel2.Location = new Point(-16, -21);
            panel2.Name = "panel2";
            panel2.Size = new Size(1045, 69);
            panel2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(235, 24);
            label3.Name = "label3";
            label3.Size = new Size(478, 49);
            label3.TabIndex = 3;
            label3.Text = "Vehicle Rental Management";
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Font = new Font("Showcard Gothic", 26F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCar.ForeColor = SystemColors.ButtonHighlight;
            lblCar.Location = new Point(168, 5);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(93, 65);
            lblCar.TabIndex = 2;
            lblCar.Text = "🚘";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightSteelBlue;
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(rdoLuxury);
            panel3.Controls.Add(rdoSUV);
            panel3.Controls.Add(rdoEconomy);
            panel3.Controls.Add(lbltype);
            panel3.Location = new Point(12, 281);
            panel3.Name = "panel3";
            panel3.Size = new Size(541, 188);
            panel3.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(353, 77);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 103);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(24, 77);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 103);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(207, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(132, 103);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // rdoLuxury
            // 
            rdoLuxury.AutoSize = true;
            rdoLuxury.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoLuxury.ForeColor = SystemColors.ActiveCaptionText;
            rdoLuxury.Location = new Point(382, 42);
            rdoLuxury.Name = "rdoLuxury";
            rdoLuxury.Size = new Size(102, 29);
            rdoLuxury.TabIndex = 16;
            rdoLuxury.TabStop = true;
            rdoLuxury.Text = "Luxuray";
            rdoLuxury.UseVisualStyleBackColor = true;
            // 
            // rdoSUV
            // 
            rdoSUV.AutoSize = true;
            rdoSUV.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoSUV.ForeColor = SystemColors.ActiveCaptionText;
            rdoSUV.Location = new Point(216, 42);
            rdoSUV.Name = "rdoSUV";
            rdoSUV.Size = new Size(72, 29);
            rdoSUV.TabIndex = 15;
            rdoSUV.TabStop = true;
            rdoSUV.Text = "SUV";
            rdoSUV.UseVisualStyleBackColor = true;
            // 
            // rdoEconomy
            // 
            rdoEconomy.AutoSize = true;
            rdoEconomy.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoEconomy.ForeColor = SystemColors.ActiveCaptionText;
            rdoEconomy.Location = new Point(54, 42);
            rdoEconomy.Name = "rdoEconomy";
            rdoEconomy.Size = new Size(101, 29);
            rdoEconomy.TabIndex = 14;
            rdoEconomy.TabStop = true;
            rdoEconomy.Text = "Econmy";
            rdoEconomy.UseVisualStyleBackColor = true;
            // 
            // lbltype
            // 
            lbltype.AutoSize = true;
            lbltype.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltype.ForeColor = Color.Navy;
            lbltype.Location = new Point(9, 11);
            lbltype.Name = "lbltype";
            lbltype.Size = new Size(119, 25);
            lbltype.TabIndex = 13;
            lbltype.Text = "Vehicle Type";
            // 
            // panel4
            // 
            panel4.Controls.Add(chkInsurance);
            panel4.Controls.Add(lblOption);
            panel4.Location = new Point(12, 485);
            panel4.Name = "panel4";
            panel4.Size = new Size(541, 71);
            panel4.TabIndex = 3;
            // 
            // chkInsurance
            // 
            chkInsurance.AutoSize = true;
            chkInsurance.ForeColor = SystemColors.ActiveCaptionText;
            chkInsurance.Location = new Point(77, 40);
            chkInsurance.Name = "chkInsurance";
            chkInsurance.Size = new Size(262, 29);
            chkInsurance.TabIndex = 16;
            chkInsurance.Text = "Add Insurance ($15 per day)";
            chkInsurance.UseVisualStyleBackColor = true;
            // 
            // lblOption
            // 
            lblOption.AutoSize = true;
            lblOption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption.ForeColor = Color.Navy;
            lblOption.Location = new Point(9, 12);
            lblOption.Name = "lblOption";
            lblOption.Size = new Size(159, 25);
            lblOption.TabIndex = 15;
            lblOption.Text = "Insurance Option";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = SystemColors.GradientActiveCaption;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.ForeColor = Color.Navy;
            btnCalculate.Location = new Point(86, 578);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(142, 42);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "\U0001f9eeCalculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.GradientActiveCaption;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(323, 578);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(142, 42);
            btnClear.TabIndex = 7;
            btnClear.Text = "\U0001f9f9Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.GradientActiveCaption;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(555, 578);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(142, 42);
            btnExit.TabIndex = 8;
            btnExit.Text = "🚪Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lsrental
            // 
            lsrental.FormattingEnabled = true;
            lsrental.ItemHeight = 25;
            lsrental.Location = new Point(629, 89);
            lsrental.Name = "lsrental";
            lsrental.Size = new Size(348, 479);
            lsrental.TabIndex = 9;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(1001, 623);
            Controls.Add(lsrental);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ButtonFace;
            Name = "Form3";
            Text = "form3";
            Load += Form3_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtAge;
        private TextBox txtdays;
        private Label lblAge;
        private Label lbldays;
        private TextBox txtexperience;
        private Label lblName;
        private TextBox txtName;
        private Label lblexperience;
        private Label label1;
        private Panel panel2;
        private Label lblCar;
        private Label label3;
        private Panel panel3;
        private RadioButton rdoLuxury;
        private RadioButton rdoSUV;
        private RadioButton rdoEconomy;
        private Label lbltype;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panel4;
        private CheckBox chkInsurance;
        private Label lblOption;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private ListBox lsrental;
    }
}