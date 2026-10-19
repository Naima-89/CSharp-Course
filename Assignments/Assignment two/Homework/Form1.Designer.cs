
namespace Homework
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
            panel1 = new Panel();
            txtAge = new TextBox();
            txtTicket = new TextBox();
            txtName = new TextBox();
            txtWeight = new TextBox();
            label1 = new Label();
            lblWeight = new Label();
            lblName = new Label();
            lblTicket = new Label();
            lblAge = new Label();
            BookingDetails = new ListBox();
            rdoBussines = new RadioButton();
            rdoNormal = new RadioButton();
            rdoFirst = new RadioButton();
            lblTravel = new Label();
            ckTravel = new CheckBox();
            lblOption = new Label();
            btnExist = new Button();
            btnClear = new Button();
            btnCalculate = new Button();
            panel2 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.PaleTurquoise;
            panel1.Controls.Add(txtAge);
            panel1.Controls.Add(txtTicket);
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtWeight);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblWeight);
            panel1.Controls.Add(lblName);
            panel1.Controls.Add(lblTicket);
            panel1.Controls.Add(lblAge);
            panel1.Location = new Point(12, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(436, 223);
            panel1.TabIndex = 0;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(192, 91);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(231, 31);
            txtAge.TabIndex = 4;
            // 
            // txtTicket
            // 
            txtTicket.BorderStyle = BorderStyle.FixedSingle;
            txtTicket.Location = new Point(191, 133);
            txtTicket.Multiline = true;
            txtTicket.Name = "txtTicket";
            txtTicket.Size = new Size(231, 31);
            txtTicket.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(192, 51);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(231, 31);
            txtName.TabIndex = 2;
            // 
            // txtWeight
            // 
            txtWeight.BorderStyle = BorderStyle.FixedSingle;
            txtWeight.Location = new Point(192, 177);
            txtWeight.Multiline = true;
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(231, 31);
            txtWeight.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(5, 15);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 0;
            label1.Text = "Personal Information";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWeight.Location = new Point(0, 177);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(191, 25);
            lblWeight.TabIndex = 7;
            lblWeight.Text = "Baggage Weight(Kg)\r\n";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(21, 51);
            lblName.Name = "lblName";
            lblName.Size = new Size(153, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Passenger Name";
            // 
            // lblTicket
            // 
            lblTicket.AutoSize = true;
            lblTicket.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTicket.Location = new Point(6, 139);
            lblTicket.Name = "lblTicket";
            lblTicket.Size = new Size(172, 75);
            lblTicket.TabIndex = 5;
            lblTicket.Text = "Numbers Of Ticket\r\n\r\n\r\n";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAge.Location = new Point(21, 93);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(137, 25);
            lblAge.TabIndex = 3;
            lblAge.Text = "Passenger Age";
            // 
            // BookingDetails
            // 
            BookingDetails.FormattingEnabled = true;
            BookingDetails.ItemHeight = 25;
            BookingDetails.Location = new Point(588, 66);
            BookingDetails.Name = "BookingDetails";
            BookingDetails.Size = new Size(339, 354);
            BookingDetails.TabIndex = 4;
            // 
            // rdoBussines
            // 
            rdoBussines.AutoSize = true;
            rdoBussines.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoBussines.Location = new Point(405, 328);
            rdoBussines.Name = "rdoBussines";
            rdoBussines.Size = new Size(163, 29);
            rdoBussines.TabIndex = 3;
            rdoBussines.TabStop = true;
            rdoBussines.Text = "Bussiness Class";
            rdoBussines.UseVisualStyleBackColor = true;
            // 
            // rdoNormal
            // 
            rdoNormal.AutoSize = true;
            rdoNormal.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoNormal.Location = new Point(239, 328);
            rdoNormal.Name = "rdoNormal";
            rdoNormal.Size = new Size(145, 29);
            rdoNormal.TabIndex = 2;
            rdoNormal.TabStop = true;
            rdoNormal.Text = "Normal Class";
            rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoFirst
            // 
            rdoFirst.AutoSize = true;
            rdoFirst.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rdoFirst.Location = new Point(77, 328);
            rdoFirst.Name = "rdoFirst";
            rdoFirst.Size = new Size(119, 29);
            rdoFirst.TabIndex = 1;
            rdoFirst.TabStop = true;
            rdoFirst.Text = "First Class";
            rdoFirst.UseVisualStyleBackColor = true;
            // 
            // lblTravel
            // 
            lblTravel.AutoSize = true;
            lblTravel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTravel.Location = new Point(9, 291);
            lblTravel.Name = "lblTravel";
            lblTravel.Size = new Size(111, 50);
            lblTravel.TabIndex = 0;
            lblTravel.Text = "Travel Class\r\n\r\n";
            // 
            // ckTravel
            // 
            ckTravel.AutoSize = true;
            ckTravel.Location = new Point(77, 414);
            ckTravel.Name = "ckTravel";
            ckTravel.Size = new Size(322, 29);
            ckTravel.TabIndex = 14;
            ckTravel.Text = "Add Travel Insurance($25 per Ticket)";
            ckTravel.UseVisualStyleBackColor = true;
            // 
            // lblOption
            // 
            lblOption.AutoSize = true;
            lblOption.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblOption.Location = new Point(9, 368);
            lblOption.Name = "lblOption";
            lblOption.Size = new Size(162, 25);
            lblOption.TabIndex = 13;
            lblOption.Text = "Aditional Options";
            // 
            // btnExist
            // 
            btnExist.Location = new Point(553, 484);
            btnExist.Name = "btnExist";
            btnExist.Size = new Size(112, 34);
            btnExist.TabIndex = 17;
            btnExist.Text = "Exit";
            btnExist.UseVisualStyleBackColor = true;
            btnExist.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(347, 484);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(147, 484);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(112, 34);
            btnCalculate.TabIndex = 15;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumBlue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-2, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 46);
            panel2.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Demi", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(206, 10);
            label2.Name = "label2";
            label2.Size = new Size(442, 37);
            label2.TabIndex = 0;
            label2.Text = "Airlane Ticket Booking System";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 534);
            Controls.Add(panel2);
            Controls.Add(btnExist);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(ckTravel);
            Controls.Add(lblOption);
            Controls.Add(rdoBussines);
            Controls.Add(rdoNormal);
            Controls.Add(rdoFirst);
            Controls.Add(lblTravel);
            Controls.Add(BookingDetails);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void rdoFirst_CheckedChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        #endregion

        private Panel panel1;
        private TextBox txtAge;
        private TextBox txtTicket;
        private TextBox txtName;
        private TextBox txtWeight;
        private Label label1;
        private Label lblWeight;
        private Label lblName;
        private Label lblTicket;
        private Label lblAge;
        private ListBox BookingDetails;
        private RadioButton rdoBussines;
        private RadioButton rdoNormal;
        private RadioButton rdoFirst;
        private Label lblTravel;
        private CheckBox ckTravel;
        private Label lblOption;
        private Button btnExist;
        private Button btnClear;
        private Button btnCalculate;
        private Panel panel2;
        private Label label2;
    }
}
