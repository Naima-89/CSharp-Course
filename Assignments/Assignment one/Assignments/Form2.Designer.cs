namespace Assignments
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
            txtvat = new TextBox();
            lbltipvat = new Label();
            txtNetAmount = new TextBox();
            txtTotalAmount = new TextBox();
            lblNet = new Label();
            lblTotal = new Label();
            txtTip = new TextBox();
            txtsales = new TextBox();
            lblTip = new Label();
            lblSales = new Label();
            btnClose = new Button();
            btnClear = new Button();
            btnCalculate = new Button();
            txtprice2 = new TextBox();
            txtprice1 = new TextBox();
            price2 = new Label();
            price1 = new Label();
            txtfood2 = new TextBox();
            txtfood1 = new TextBox();
            food2 = new Label();
            food1 = new Label();
            SuspendLayout();
            // 
            // txtvat
            // 
            txtvat.BorderStyle = BorderStyle.FixedSingle;
            txtvat.Location = new Point(176, 203);
            txtvat.Multiline = true;
            txtvat.Name = "txtvat";
            txtvat.Size = new Size(272, 35);
            txtvat.TabIndex = 43;
            // 
            // lbltipvat
            // 
            lbltipvat.AutoSize = true;
            lbltipvat.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltipvat.Location = new Point(1, 203);
            lbltipvat.Name = "lbltipvat";
            lbltipvat.Size = new Size(127, 25);
            lbltipvat.TabIndex = 42;
            lbltipvat.Text = "Enter Tip vat";
            // 
            // txtNetAmount
            // 
            txtNetAmount.BorderStyle = BorderStyle.FixedSingle;
            txtNetAmount.Location = new Point(160, 496);
            txtNetAmount.Multiline = true;
            txtNetAmount.Name = "txtNetAmount";
            txtNetAmount.Size = new Size(272, 35);
            txtNetAmount.TabIndex = 41;
            // 
            // txtTotalAmount
            // 
            txtTotalAmount.BorderStyle = BorderStyle.FixedSingle;
            txtTotalAmount.Location = new Point(160, 450);
            txtTotalAmount.Multiline = true;
            txtTotalAmount.Name = "txtTotalAmount";
            txtTotalAmount.Size = new Size(272, 35);
            txtTotalAmount.TabIndex = 40;
            // 
            // lblNet
            // 
            lblNet.AutoSize = true;
            lblNet.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNet.Location = new Point(14, 486);
            lblNet.Name = "lblNet";
            lblNet.Size = new Size(124, 25);
            lblNet.TabIndex = 39;
            lblNet.Text = "Net-Amount";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(14, 452);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(137, 25);
            lblTotal.TabIndex = 38;
            lblTotal.Text = "Total-Amount";
            // 
            // txtTip
            // 
            txtTip.BorderStyle = BorderStyle.FixedSingle;
            txtTip.Location = new Point(160, 407);
            txtTip.Multiline = true;
            txtTip.Name = "txtTip";
            txtTip.Size = new Size(272, 35);
            txtTip.TabIndex = 37;
            // 
            // txtsales
            // 
            txtsales.BorderStyle = BorderStyle.FixedSingle;
            txtsales.Location = new Point(160, 361);
            txtsales.Multiline = true;
            txtsales.Name = "txtsales";
            txtsales.Size = new Size(272, 35);
            txtsales.TabIndex = 36;
            // 
            // lblTip
            // 
            lblTip.AutoSize = true;
            lblTip.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTip.Location = new Point(20, 409);
            lblTip.Name = "lblTip";
            lblTip.Size = new Size(120, 25);
            lblTip.TabIndex = 35;
            lblTip.Text = "Tip-Amount";
            // 
            // lblSales
            // 
            lblSales.AutoSize = true;
            lblSales.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSales.Location = new Point(35, 363);
            lblSales.Name = "lblSales";
            lblSales.Size = new Size(96, 25);
            lblSales.TabIndex = 34;
            lblSales.Text = "Sales-Tax";
            // 
            // btnClose
            // 
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.Location = new Point(483, 269);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(113, 70);
            btnClose.TabIndex = 33;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(250, 269);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(113, 70);
            btnClear.TabIndex = 32;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(46, 269);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(113, 70);
            btnCalculate.TabIndex = 31;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtprice2
            // 
            txtprice2.BorderStyle = BorderStyle.FixedSingle;
            txtprice2.Location = new Point(176, 160);
            txtprice2.Multiline = true;
            txtprice2.Name = "txtprice2";
            txtprice2.Size = new Size(272, 35);
            txtprice2.TabIndex = 30;
            // 
            // txtprice1
            // 
            txtprice1.BorderStyle = BorderStyle.FixedSingle;
            txtprice1.Location = new Point(176, 114);
            txtprice1.Multiline = true;
            txtprice1.Name = "txtprice1";
            txtprice1.Size = new Size(272, 35);
            txtprice1.TabIndex = 29;
            // 
            // price2
            // 
            price2.AutoSize = true;
            price2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price2.Location = new Point(3, 163);
            price2.Name = "price2";
            price2.Size = new Size(169, 25);
            price2.TabIndex = 28;
            price2.Text = "Enter Food2 Price";
            // 
            // price1
            // 
            price1.AutoSize = true;
            price1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price1.Location = new Point(3, 117);
            price1.Name = "price1";
            price1.Size = new Size(167, 25);
            price1.TabIndex = 27;
            price1.Text = "Enter Food1 Price";
            // 
            // txtfood2
            // 
            txtfood2.BorderStyle = BorderStyle.FixedSingle;
            txtfood2.Location = new Point(176, 71);
            txtfood2.Multiline = true;
            txtfood2.Name = "txtfood2";
            txtfood2.Size = new Size(272, 35);
            txtfood2.TabIndex = 26;
            // 
            // txtfood1
            // 
            txtfood1.BorderStyle = BorderStyle.FixedSingle;
            txtfood1.Location = new Point(176, 25);
            txtfood1.Multiline = true;
            txtfood1.Name = "txtfood1";
            txtfood1.Size = new Size(272, 35);
            txtfood1.TabIndex = 25;
            // 
            // food2
            // 
            food2.AutoSize = true;
            food2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            food2.Location = new Point(12, 71);
            food2.Name = "food2";
            food2.Size = new Size(119, 25);
            food2.TabIndex = 24;
            food2.Text = "Enter Food2";
            // 
            // food1
            // 
            food1.AutoSize = true;
            food1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            food1.Location = new Point(14, 28);
            food1.Name = "food1";
            food1.Size = new Size(117, 25);
            food1.TabIndex = 23;
            food1.Text = "Enter Food1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 553);
            Controls.Add(txtvat);
            Controls.Add(lbltipvat);
            Controls.Add(txtNetAmount);
            Controls.Add(txtTotalAmount);
            Controls.Add(lblNet);
            Controls.Add(lblTotal);
            Controls.Add(txtTip);
            Controls.Add(txtsales);
            Controls.Add(lblTip);
            Controls.Add(lblSales);
            Controls.Add(btnClose);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtprice2);
            Controls.Add(txtprice1);
            Controls.Add(price2);
            Controls.Add(price1);
            Controls.Add(txtfood2);
            Controls.Add(txtfood1);
            Controls.Add(food2);
            Controls.Add(food1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtvat;
        private Label lbltipvat;
        private TextBox txtNetAmount;
        private TextBox txtTotalAmount;
        private Label lblNet;
        private Label lblTotal;
        private TextBox txtTip;
        private TextBox txtsales;
        private Label lblTip;
        private Label lblSales;
        private Button btnClose;
        private Button btnClear;
        private Button btnCalculate;
        private TextBox txtprice2;
        private TextBox txtprice1;
        private Label price2;
        private Label price1;
        private TextBox txtfood2;
        private TextBox txtfood1;
        private Label food2;
        private Label food1;
    }
}