namespace UMinh
{
    partial class frmOrdersInput
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
            this.lblCustID = new System.Windows.Forms.Label();
            this.lblEmpID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.cbShipper = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtShipCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtShipPostalCode = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtShipName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.dtOrder = new System.Windows.Forms.DateTimePicker();
            this.dtRequired = new System.Windows.Forms.DateTimePicker();
            this.dtShipped = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Location = new System.Drawing.Point(62, 19);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(51, 13);
            this.lblCustID.TabIndex = 1;
            this.lblCustID.Text = "Customer";
            this.lblCustID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEmpID
            // 
            this.lblEmpID.AutoSize = true;
            this.lblEmpID.Location = new System.Drawing.Point(60, 45);
            this.lblEmpID.Name = "lblEmpID";
            this.lblEmpID.Size = new System.Drawing.Size(53, 13);
            this.lblEmpID.TabIndex = 2;
            this.lblEmpID.Text = "Employee";
            this.lblEmpID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(159, 372);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(78, 372);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 31;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(123, 16);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(155, 21);
            this.cbCustomer.TabIndex = 2;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(123, 42);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(153, 21);
            this.cbEmployee.TabIndex = 3;
            // 
            // cbShipper
            // 
            this.cbShipper.FormattingEnabled = true;
            this.cbShipper.Location = new System.Drawing.Point(123, 146);
            this.cbShipper.Name = "cbShipper";
            this.cbShipper.Size = new System.Drawing.Size(200, 21);
            this.cbShipper.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Required date";
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(56, 75);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(57, 13);
            this.lblOrderDate.TabIndex = 32;
            this.lblOrderDate.Text = "Order date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Shipped date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Shipper";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Freight";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(123, 277);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(135, 20);
            this.txtRegion.TabIndex = 52;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 202);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Ship name";
            // 
            // txtShipCity
            // 
            this.txtShipCity.Location = new System.Drawing.Point(123, 251);
            this.txtShipCity.Name = "txtShipCity";
            this.txtShipCity.Size = new System.Drawing.Size(135, 20);
            this.txtShipCity.TabIndex = 51;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(47, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ship address";
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(123, 330);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(150, 21);
            this.cbCountry.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(68, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Ship city";
            // 
            // txtShipPostalCode
            // 
            this.txtShipPostalCode.Location = new System.Drawing.Point(123, 303);
            this.txtShipPostalCode.Name = "txtShipPostalCode";
            this.txtShipPostalCode.Size = new System.Drawing.Size(100, 20);
            this.txtShipPostalCode.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Ship region";
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(123, 225);
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(135, 20);
            this.txtShipAddress.TabIndex = 48;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 306);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Ship postal code";
            // 
            // txtShipName
            // 
            this.txtShipName.Location = new System.Drawing.Point(123, 199);
            this.txtShipName.Name = "txtShipName";
            this.txtShipName.Size = new System.Drawing.Size(135, 20);
            this.txtShipName.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 333);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Ship country";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(123, 173);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(135, 20);
            this.txtFreight.TabIndex = 46;
            // 
            // dtOrder
            // 
            this.dtOrder.Location = new System.Drawing.Point(123, 69);
            this.dtOrder.Name = "dtOrder";
            this.dtOrder.Size = new System.Drawing.Size(200, 20);
            this.dtOrder.TabIndex = 43;
            // 
            // dtRequired
            // 
            this.dtRequired.Location = new System.Drawing.Point(123, 95);
            this.dtRequired.Name = "dtRequired";
            this.dtRequired.Size = new System.Drawing.Size(200, 20);
            this.dtRequired.TabIndex = 44;
            // 
            // dtShipped
            // 
            this.dtShipped.Location = new System.Drawing.Point(123, 121);
            this.dtShipped.Name = "dtShipped";
            this.dtShipped.Size = new System.Drawing.Size(200, 20);
            this.dtShipped.TabIndex = 45;
            // 
            // frmOrdersInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 407);
            this.Controls.Add(this.cbShipper);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOrderDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtRegion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtShipCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtShipPostalCode);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtShipAddress);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtShipName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.dtOrder);
            this.Controls.Add(this.dtRequired);
            this.Controls.Add(this.dtShipped);
            this.Controls.Add(this.cbEmployee);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.lblEmpID);
            this.Controls.Add(this.lblCustID);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Name = "frmOrdersInput";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmOrdersInput";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.Label lblEmpID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cbCustomer;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.ComboBox cbShipper;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtShipCity;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.MaskedTextBox txtShipPostalCode;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtShipName;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtFreight;
        public System.Windows.Forms.DateTimePicker dtOrder;
        public System.Windows.Forms.DateTimePicker dtRequired;
        public System.Windows.Forms.DateTimePicker dtShipped;
    }
}