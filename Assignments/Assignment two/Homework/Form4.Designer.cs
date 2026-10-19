namespace Homework
{
    partial class Form5
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
            lblAmount = new Label();
            lblFee = new Label();
            lblDiscount = new Label();
            lbltransport = new Label();
            lblyear = new Label();
            lblNumber = new Label();
            lblStudentName = new Label();
            btnExist = new Button();
            btnClear = new Button();
            btnCalculate = new Button();
            txtid = new TextBox();
            txtcourses = new TextBox();
            txtName = new TextBox();
            txtlevel = new TextBox();
            lblWeight = new Label();
            lblName = new Label();
            lblTicket = new Label();
            lblID = new Label();
            textransport = new TextBox();
            lblTransportFee = new Label();
            label2 = new Label();
            panel1 = new Panel();
            lblStudentId = new Label();
            lblStudyYear = new Label();
            lblCourses = new Label();
            lblTution = new Label();
            lblFinalAmount = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.BorderStyle = BorderStyle.FixedSingle;
            lblAmount.ForeColor = Color.Green;
            lblAmount.Location = new Point(355, 736);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(124, 27);
            lblAmount.TabIndex = 57;
            lblAmount.Text = "Final Amount:";
            // 
            // lblFee
            // 
            lblFee.AutoSize = true;
            lblFee.BorderStyle = BorderStyle.FixedSingle;
            lblFee.ForeColor = Color.Green;
            lblFee.Location = new Point(350, 675);
            lblFee.Name = "lblFee";
            lblFee.Size = new Size(100, 27);
            lblFee.TabIndex = 56;
            lblFee.Text = "Tution Fee:";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.BorderStyle = BorderStyle.FixedSingle;
            lblDiscount.Font = new Font("Arial Rounded MT Bold", 9F);
            lblDiscount.ForeColor = Color.Green;
            lblDiscount.Location = new Point(368, 507);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(147, 23);
            lblDiscount.TabIndex = 19;
            lblDiscount.Text = "                           ";
            // 
            // lbltransport
            // 
            lbltransport.AutoSize = true;
            lbltransport.BorderStyle = BorderStyle.FixedSingle;
            lbltransport.Font = new Font("Arial Rounded MT Bold", 9F);
            lbltransport.ForeColor = Color.Green;
            lbltransport.Location = new Point(363, 467);
            lbltransport.Name = "lbltransport";
            lbltransport.Size = new Size(147, 23);
            lbltransport.TabIndex = 20;
            lbltransport.Text = "                           ";
            // 
            // lblyear
            // 
            lblyear.AutoSize = true;
            lblyear.BorderStyle = BorderStyle.FixedSingle;
            lblyear.ForeColor = Color.Green;
            lblyear.Location = new Point(30, 736);
            lblyear.Name = "lblyear";
            lblyear.Size = new Size(100, 27);
            lblyear.TabIndex = 53;
            lblyear.Text = "Study Year:";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BorderStyle = BorderStyle.FixedSingle;
            lblNumber.ForeColor = Color.Green;
            lblNumber.Location = new Point(25, 675);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(134, 27);
            lblNumber.TabIndex = 52;
            lblNumber.Text = "                        ";
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.BorderStyle = BorderStyle.FixedSingle;
            lblStudentName.Font = new Font("Arial Rounded MT Bold", 9F);
            lblStudentName.ForeColor = Color.Green;
            lblStudentName.Location = new Point(12, 467);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(132, 23);
            lblStudentName.TabIndex = 13;
            lblStudentName.Text = "                        ";
            // 
            // btnExist
            // 
            btnExist.BackColor = Color.Red;
            btnExist.Location = new Point(379, 347);
            btnExist.Name = "btnExist";
            btnExist.Size = new Size(112, 58);
            btnExist.TabIndex = 12;
            btnExist.Text = "Exit";
            btnExist.UseVisualStyleBackColor = false;
            btnExist.Click += btnExist_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Location = new Point(220, 347);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 58);
            btnClear.TabIndex = 11;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Green;
            btnCalculate.Location = new Point(68, 347);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 58);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtid
            // 
            txtid.BorderStyle = BorderStyle.FixedSingle;
            txtid.Location = new Point(290, 140);
            txtid.Multiline = true;
            txtid.Name = "txtid";
            txtid.Size = new Size(231, 31);
            txtid.TabIndex = 3;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // txtcourses
            // 
            txtcourses.BorderStyle = BorderStyle.FixedSingle;
            txtcourses.Location = new Point(290, 192);
            txtcourses.Multiline = true;
            txtcourses.Name = "txtcourses";
            txtcourses.Size = new Size(231, 31);
            txtcourses.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(290, 92);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 31);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtlevel
            // 
            txtlevel.BorderStyle = BorderStyle.FixedSingle;
            txtlevel.Location = new Point(291, 236);
            txtlevel.Multiline = true;
            txtlevel.Name = "txtlevel";
            txtlevel.Size = new Size(231, 31);
            txtlevel.TabIndex = 7;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeight.Location = new Point(25, 233);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(165, 25);
            lblWeight.TabIndex = 6;
            lblWeight.Text = "Enter S tudy Level\r\n";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(55, 101);
            lblName.Name = "lblName";
            lblName.Size = new Size(123, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Stuent Name";
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTicket.Location = new Point(25, 194);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(228, 50);
            lblTicket.TabIndex = 4;
            lblTicket.Text = "Enter Number Of Courses\r\n\r\n";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblID.Location = new Point(55, 150);
            lblID.Name = "lblID";
            lblID.Size = new Size(101, 25);
            lblID.TabIndex = 2;
            lblID.Text = "Student Id";
            // 
            // textransport
            // 
            textransport.BorderStyle = BorderStyle.FixedSingle;
            textransport.Location = new Point(291, 275);
            textransport.Multiline = true;
            textransport.Name = "textransport";
            textransport.Size = new Size(231, 31);
            textransport.TabIndex = 9;
            // 
            // lblTransportFee
            // 
            lblTransportFee.AutoSize = true;
            lblTransportFee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTransportFee.Location = new Point(49, 275);
            lblTransportFee.Name = "lblTransportFee";
            lblTransportFee.Size = new Size(129, 25);
            lblTransportFee.TabIndex = 8;
            lblTransportFee.Text = "Transport Fee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(36, 3);
            label2.Name = "label2";
            label2.Size = new Size(308, 32);
            label2.TabIndex = 0;
            label2.Text = "Registration Fees System";
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(121, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(365, 35);
            panel1.TabIndex = 21;
            // 
            // lblStudentId
            // 
            lblStudentId.AutoSize = true;
            lblStudentId.BorderStyle = BorderStyle.FixedSingle;
            lblStudentId.Font = new Font("Arial Rounded MT Bold", 9F);
            lblStudentId.ForeColor = Color.Green;
            lblStudentId.Location = new Point(12, 507);
            lblStudentId.Name = "lblStudentId";
            lblStudentId.Size = new Size(132, 23);
            lblStudentId.TabIndex = 14;
            lblStudentId.Text = "                        ";
            // 
            // lblStudyYear
            // 
            lblStudyYear.AutoSize = true;
            lblStudyYear.BorderStyle = BorderStyle.FixedSingle;
            lblStudyYear.Font = new Font("Arial Rounded MT Bold", 9F);
            lblStudyYear.ForeColor = Color.Green;
            lblStudyYear.Location = new Point(12, 597);
            lblStudyYear.Name = "lblStudyYear";
            lblStudyYear.Size = new Size(132, 23);
            lblStudyYear.TabIndex = 16;
            lblStudyYear.Text = "                        ";
            // 
            // lblCourses
            // 
            lblCourses.AutoSize = true;
            lblCourses.BorderStyle = BorderStyle.FixedSingle;
            lblCourses.Font = new Font("Arial Rounded MT Bold", 9F);
            lblCourses.ForeColor = Color.Green;
            lblCourses.Location = new Point(12, 552);
            lblCourses.Name = "lblCourses";
            lblCourses.Size = new Size(132, 23);
            lblCourses.TabIndex = 15;
            lblCourses.Text = "                        ";
            // 
            // lblTution
            // 
            lblTution.AutoSize = true;
            lblTution.BorderStyle = BorderStyle.FixedSingle;
            lblTution.Font = new Font("Arial Rounded MT Bold", 9F);
            lblTution.ForeColor = Color.Green;
            lblTution.Location = new Point(368, 552);
            lblTution.Name = "lblTution";
            lblTution.Size = new Size(147, 23);
            lblTution.TabIndex = 18;
            lblTution.Text = "                           ";
            // 
            // lblFinalAmount
            // 
            lblFinalAmount.AutoSize = true;
            lblFinalAmount.BorderStyle = BorderStyle.FixedSingle;
            lblFinalAmount.Font = new Font("Arial Rounded MT Bold", 9F);
            lblFinalAmount.ForeColor = Color.Green;
            lblFinalAmount.Location = new Point(373, 597);
            lblFinalAmount.Name = "lblFinalAmount";
            lblFinalAmount.Size = new Size(147, 23);
            lblFinalAmount.TabIndex = 17;
            lblFinalAmount.Text = "                           ";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 654);
            Controls.Add(lblFinalAmount);
            Controls.Add(lblTution);
            Controls.Add(lblCourses);
            Controls.Add(lblStudyYear);
            Controls.Add(lblStudentId);
            Controls.Add(panel1);
            Controls.Add(textransport);
            Controls.Add(lblTransportFee);
            Controls.Add(lblAmount);
            Controls.Add(lblFee);
            Controls.Add(lblDiscount);
            Controls.Add(lbltransport);
            Controls.Add(lblyear);
            Controls.Add(lblNumber);
            Controls.Add(lblStudentName);
            Controls.Add(btnExist);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtid);
            Controls.Add(txtcourses);
            Controls.Add(txtName);
            Controls.Add(txtlevel);
            Controls.Add(lblWeight);
            Controls.Add(lblName);
            Controls.Add(lblTicket);
            Controls.Add(lblID);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAmount;
        private Label lblFee;
        private Label lblDiscount;
        private Label lbltransport;
        private Label lblyear;
        private Label lblNumber;
        private Label lblStudentName;
        private Button btnExist;
        private Button btnClear;
        private Button btnCalculate;
        private TextBox txtid;
        private TextBox txtcourses;
        private TextBox txtName;
        private TextBox txtlevel;
        private Label lblWeight;
        private Label lblName;
        private Label lblTicket;
        private Label lblID;
        private TextBox textransport;
        private Label lblTransportFee;
        private Label label2;
        private Panel panel1;
        private Label lblStudentId;
        private Label lblStudyYear;
        private Label lblCourses;
        private Label lblTution;
        private Label lblFinalAmount;
    }
}