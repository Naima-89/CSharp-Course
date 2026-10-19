namespace Homework
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
            txtName = new TextBox();
            label1 = new Label();
            lblGuest = new Label();
            lblAge = new Label();
            lblNight = new Label();
            lblGuests = new Label();
            txtGuests = new TextBox();
            txtNight = new TextBox();
            txtAge = new TextBox();
            lblRoom = new Label();
            rdoStandard = new RadioButton();
            rdoNormal = new RadioButton();
            rdoHight = new RadioButton();
            lblOption = new Label();
            ckBreakFast = new CheckBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExist = new Button();
            BookingAproved = new ListBox();
            panel1 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(183, 101);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 31);
            txtName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(7, 65);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 0;
            label1.Text = "Personal Information";
            // 
            // lblGuest
            // 
            lblGuest.AutoSize = true;
            lblGuest.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuest.Location = new Point(42, 107);
            lblGuest.Name = "lblGuest";
            lblGuest.Size = new Size(116, 25);
            lblGuest.TabIndex = 1;
            lblGuest.Text = "Guest Name";
            lblGuest.Click += lblGuest_Click;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(42, 147);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(100, 25);
            lblAge.TabIndex = 3;
            lblAge.Text = "Guest Age";
            // 
            // lblNight
            // 
            lblNight.AutoSize = true;
            lblNight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNight.Location = new Point(8, 189);
            lblNight.Name = "lblNight";
            lblNight.Size = new Size(168, 25);
            lblNight.TabIndex = 5;
            lblNight.Text = "Numbers Of Night";
            lblNight.Click += lblnumNight_Click;
            // 
            // lblGuests
            // 
            lblGuests.AutoSize = true;
            lblGuests.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuests.Location = new Point(8, 227);
            lblGuests.Name = "lblGuests";
            lblGuests.Size = new Size(169, 25);
            lblGuests.TabIndex = 7;
            lblGuests.Text = "Numbers Of Guest";
            // 
            // txtGuests
            // 
            txtGuests.BorderStyle = BorderStyle.FixedSingle;
            txtGuests.Location = new Point(183, 227);
            txtGuests.Multiline = true;
            txtGuests.Name = "txtGuests";
            txtGuests.Size = new Size(231, 31);
            txtGuests.TabIndex = 8;
            // 
            // txtNight
            // 
            txtNight.BorderStyle = BorderStyle.FixedSingle;
            txtNight.Location = new Point(182, 183);
            txtNight.Multiline = true;
            txtNight.Name = "txtNight";
            txtNight.Size = new Size(231, 31);
            txtNight.TabIndex = 6;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(183, 141);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(231, 31);
            txtAge.TabIndex = 4;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoom.Location = new Point(2, 266);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(108, 25);
            lblRoom.TabIndex = 9;
            lblRoom.Text = "Room Type";
            // 
            // rdoStandard
            // 
            rdoStandard.AutoSize = true;
            rdoStandard.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoStandard.Location = new Point(70, 303);
            rdoStandard.Name = "rdoStandard";
            rdoStandard.Size = new Size(111, 29);
            rdoStandard.TabIndex = 10;
            rdoStandard.TabStop = true;
            rdoStandard.Text = "Standard";
            rdoStandard.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            rdoNormal.AutoSize = true;
            rdoNormal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoNormal.Location = new Point(232, 303);
            rdoNormal.Name = "rdoNormal";
            rdoNormal.Size = new Size(99, 29);
            rdoNormal.TabIndex = 11;
            rdoNormal.TabStop = true;
            rdoNormal.Text = "Normal";
            rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoHight
            // 
            rdoHight.AutoSize = true;
            rdoHight.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoHight.Location = new Point(398, 303);
            rdoHight.Name = "rdoHight";
            rdoHight.Size = new Size(83, 29);
            rdoHight.TabIndex = 12;
            rdoHight.TabStop = true;
            rdoHight.Text = "Hight";
            rdoHight.UseVisualStyleBackColor = true;
            // 
            // lblOption
            // 
            lblOption.AutoSize = true;
            lblOption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption.Location = new Point(2, 346);
            lblOption.Name = "lblOption";
            lblOption.Size = new Size(162, 25);
            lblOption.TabIndex = 13;
            lblOption.Text = "Aditional Options";
            // 
            // ckBreakFast
            // 
            ckBreakFast.AutoSize = true;
            ckBreakFast.Location = new Point(70, 392);
            ckBreakFast.Name = "ckBreakFast";
            ckBreakFast.Size = new Size(317, 29);
            ckBreakFast.TabIndex = 14;
            ckBreakFast.Text = "BreakFast(10 per Guest per Night)\r\n";
            ckBreakFast.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(69, 455);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(269, 455);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExist
            // 
            btnExist.Location = new Point(475, 455);
            btnExist.Name = "btnExist";
            btnExist.Size = new Size(112, 34);
            btnExist.TabIndex = 17;
            btnExist.Text = "Exit";
            btnExist.UseVisualStyleBackColor = true;
            btnExist.Click += btnExist_Click;
            // 
            // BookingAproved
            // 
            BookingAproved.FormattingEnabled = true;
            BookingAproved.ItemHeight = 25;
            BookingAproved.Location = new Point(506, 86);
            BookingAproved.Name = "BookingAproved";
            BookingAproved.Size = new Size(345, 354);
            BookingAproved.TabIndex = 18;
            BookingAproved.SelectedIndexChanged += listBook_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(880, 42);
            panel1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(209, 0);
            label2.Name = "label2";
            label2.Size = new Size(414, 37);
            label2.TabIndex = 0;
            label2.Text = "Hotel Room Booking System";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(872, 528);
            Controls.Add(panel1);
            Controls.Add(BookingAproved);
            Controls.Add(btnExist);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(ckBreakFast);
            Controls.Add(lblOption);
            Controls.Add(rdoHight);
            Controls.Add(rdoNormal);
            Controls.Add(rdoStandard);
            Controls.Add(lblRoom);
            Controls.Add(txtAge);
            Controls.Add(txtNight);
            Controls.Add(txtGuests);
            Controls.Add(lblGuests);
            Controls.Add(lblNight);
            Controls.Add(lblAge);
            Controls.Add(lblGuest);
            Controls.Add(label1);
            Controls.Add(txtName);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "Form2";
            Text = "form2";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private Label label1;
        private Label lblGuest;
        private Label lblAge;
        private Label lblNight;
        private Label lblGuests;
        private TextBox txtGuests;
        private TextBox txtNight;
        private TextBox txtAge;
        private Label lblRoom;
        private RadioButton rdoStandard;
        private RadioButton rdoNormal;
        private RadioButton rdoHight;
        private Label lblOption;
        private CheckBox ckBreakFast;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExist;
        private ListBox BookingAproved;
        private Panel panel1;
        private Label label2;
    }
}