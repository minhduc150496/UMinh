namespace UMinh
{
    partial class frmOrderSearch
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTotalPrice = new System.Windows.Forms.RadioButton();
            this.rdCustName = new System.Windows.Forms.RadioButton();
            this.rdShippedDate = new System.Windows.Forms.RadioButton();
            this.rdRequiredDate = new System.Windows.Forms.RadioButton();
            this.rdOrderDate = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtMaxTotalPrice = new System.Windows.Forms.TextBox();
            this.txtMinTotalPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtMaxShippedDate = new System.Windows.Forms.DateTimePicker();
            this.dtMinShippedDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtMaxRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dtMinRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtMaxOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dtMinOrderDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTotalPrice);
            this.groupBox1.Controls.Add(this.rdCustName);
            this.groupBox1.Controls.Add(this.rdShippedDate);
            this.groupBox1.Controls.Add(this.rdRequiredDate);
            this.groupBox1.Controls.Add(this.rdOrderDate);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnRefresh);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Controls.Add(this.txtMaxTotalPrice);
            this.groupBox1.Controls.Add(this.txtMinTotalPrice);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtMaxShippedDate);
            this.groupBox1.Controls.Add(this.dtMinShippedDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtMaxRequiredDate);
            this.groupBox1.Controls.Add(this.dtMinRequiredDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtMaxOrderDate);
            this.groupBox1.Controls.Add(this.dtMinOrderDate);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 380);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdTotalPrice
            // 
            this.rdTotalPrice.AutoSize = true;
            this.rdTotalPrice.Location = new System.Drawing.Point(12, 250);
            this.rdTotalPrice.Name = "rdTotalPrice";
            this.rdTotalPrice.Size = new System.Drawing.Size(156, 17);
            this.rdTotalPrice.TabIndex = 68;
            this.rdTotalPrice.TabStop = true;
            this.rdTotalPrice.Text = "Search by order\'s total price";
            this.rdTotalPrice.UseVisualStyleBackColor = true;
            // 
            // rdCustName
            // 
            this.rdCustName.AutoSize = true;
            this.rdCustName.Location = new System.Drawing.Point(12, 189);
            this.rdCustName.Name = "rdCustName";
            this.rdCustName.Size = new System.Drawing.Size(148, 17);
            this.rdCustName.TabIndex = 67;
            this.rdCustName.TabStop = true;
            this.rdCustName.Text = "Search by customer name";
            this.rdCustName.UseVisualStyleBackColor = true;
            // 
            // rdShippedDate
            // 
            this.rdShippedDate.AutoSize = true;
            this.rdShippedDate.Location = new System.Drawing.Point(12, 140);
            this.rdShippedDate.Name = "rdShippedDate";
            this.rdShippedDate.Size = new System.Drawing.Size(137, 17);
            this.rdShippedDate.TabIndex = 66;
            this.rdShippedDate.TabStop = true;
            this.rdShippedDate.Text = "Search by shipped date";
            this.rdShippedDate.UseVisualStyleBackColor = true;
            // 
            // rdRequiredDate
            // 
            this.rdRequiredDate.AutoSize = true;
            this.rdRequiredDate.Location = new System.Drawing.Point(12, 80);
            this.rdRequiredDate.Name = "rdRequiredDate";
            this.rdRequiredDate.Size = new System.Drawing.Size(138, 17);
            this.rdRequiredDate.TabIndex = 65;
            this.rdRequiredDate.TabStop = true;
            this.rdRequiredDate.Text = "Search by required date";
            this.rdRequiredDate.UseVisualStyleBackColor = true;
            // 
            // rdOrderDate
            // 
            this.rdOrderDate.AutoSize = true;
            this.rdOrderDate.Location = new System.Drawing.Point(12, 19);
            this.rdOrderDate.Name = "rdOrderDate";
            this.rdOrderDate.Size = new System.Drawing.Size(124, 17);
            this.rdOrderDate.TabIndex = 64;
            this.rdOrderDate.TabStop = true;
            this.rdOrderDate.Text = "Search by order date";
            this.rdOrderDate.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(257, 329);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 23);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(168, 329);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 23);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(12, 212);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(245, 20);
            this.txtCustomerName.TabIndex = 60;
            // 
            // txtMaxTotalPrice
            // 
            this.txtMaxTotalPrice.Location = new System.Drawing.Point(154, 272);
            this.txtMaxTotalPrice.Name = "txtMaxTotalPrice";
            this.txtMaxTotalPrice.Size = new System.Drawing.Size(103, 20);
            this.txtMaxTotalPrice.TabIndex = 58;
            // 
            // txtMinTotalPrice
            // 
            this.txtMinTotalPrice.Location = new System.Drawing.Point(46, 272);
            this.txtMinTotalPrice.Name = "txtMinTotalPrice";
            this.txtMinTotalPrice.Size = new System.Drawing.Size(88, 20);
            this.txtMinTotalPrice.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 275);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "to";
            // 
            // dtMaxShippedDate
            // 
            this.dtMaxShippedDate.Location = new System.Drawing.Point(276, 163);
            this.dtMaxShippedDate.Name = "dtMaxShippedDate";
            this.dtMaxShippedDate.Size = new System.Drawing.Size(208, 20);
            this.dtMaxShippedDate.TabIndex = 49;
            // 
            // dtMinShippedDate
            // 
            this.dtMinShippedDate.Location = new System.Drawing.Point(48, 163);
            this.dtMinShippedDate.Name = "dtMinShippedDate";
            this.dtMinShippedDate.Size = new System.Drawing.Size(208, 20);
            this.dtMinShippedDate.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "to";
            // 
            // dtMaxRequiredDate
            // 
            this.dtMaxRequiredDate.Location = new System.Drawing.Point(276, 103);
            this.dtMaxRequiredDate.Name = "dtMaxRequiredDate";
            this.dtMaxRequiredDate.Size = new System.Drawing.Size(208, 20);
            this.dtMaxRequiredDate.TabIndex = 44;
            // 
            // dtMinRequiredDate
            // 
            this.dtMinRequiredDate.Location = new System.Drawing.Point(48, 103);
            this.dtMinRequiredDate.Name = "dtMinRequiredDate";
            this.dtMinRequiredDate.Size = new System.Drawing.Size(208, 20);
            this.dtMinRequiredDate.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "to";
            // 
            // dtMaxOrderDate
            // 
            this.dtMaxOrderDate.Location = new System.Drawing.Point(276, 42);
            this.dtMaxOrderDate.Name = "dtMaxOrderDate";
            this.dtMaxOrderDate.Size = new System.Drawing.Size(208, 20);
            this.dtMaxOrderDate.TabIndex = 39;
            // 
            // dtMinOrderDate
            // 
            this.dtMinOrderDate.Location = new System.Drawing.Point(48, 42);
            this.dtMinOrderDate.Name = "dtMinOrderDate";
            this.dtMinOrderDate.Size = new System.Drawing.Size(208, 20);
            this.dtMinOrderDate.TabIndex = 38;
            // 
            // frmOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 404);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOrderSearch";
            this.Text = "frmOrderSearch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTotalPrice;
        private System.Windows.Forms.RadioButton rdCustName;
        private System.Windows.Forms.RadioButton rdShippedDate;
        private System.Windows.Forms.RadioButton rdRequiredDate;
        private System.Windows.Forms.RadioButton rdOrderDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtMaxTotalPrice;
        private System.Windows.Forms.TextBox txtMinTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtMaxShippedDate;
        private System.Windows.Forms.DateTimePicker dtMinShippedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtMaxRequiredDate;
        private System.Windows.Forms.DateTimePicker dtMinRequiredDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtMaxOrderDate;
        private System.Windows.Forms.DateTimePicker dtMinOrderDate;
    }
}