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
            this.chkOrderDate = new System.Windows.Forms.CheckBox();
            this.chkRequiredDate = new System.Windows.Forms.CheckBox();
            this.chkShippedDate = new System.Windows.Forms.CheckBox();
            this.chkCustomerName = new System.Windows.Forms.CheckBox();
            this.chkTotalPrice = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkTotalPrice);
            this.groupBox1.Controls.Add(this.chkCustomerName);
            this.groupBox1.Controls.Add(this.chkShippedDate);
            this.groupBox1.Controls.Add(this.chkRequiredDate);
            this.groupBox1.Controls.Add(this.chkOrderDate);
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
            this.groupBox1.Size = new System.Drawing.Size(523, 366);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(257, 318);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 23);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(168, 318);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(83, 23);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(12, 222);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(253, 20);
            this.txtCustomerName.TabIndex = 60;
            // 
            // txtMaxTotalPrice
            // 
            this.txtMaxTotalPrice.Location = new System.Drawing.Point(162, 271);
            this.txtMaxTotalPrice.Name = "txtMaxTotalPrice";
            this.txtMaxTotalPrice.Size = new System.Drawing.Size(103, 20);
            this.txtMaxTotalPrice.TabIndex = 58;
            // 
            // txtMinTotalPrice
            // 
            this.txtMinTotalPrice.Location = new System.Drawing.Point(46, 271);
            this.txtMinTotalPrice.Name = "txtMinTotalPrice";
            this.txtMinTotalPrice.Size = new System.Drawing.Size(88, 20);
            this.txtMinTotalPrice.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 274);
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
            // chkOrderDate
            // 
            this.chkOrderDate.AutoSize = true;
            this.chkOrderDate.Location = new System.Drawing.Point(12, 20);
            this.chkOrderDate.Name = "chkOrderDate";
            this.chkOrderDate.Size = new System.Drawing.Size(125, 17);
            this.chkOrderDate.TabIndex = 64;
            this.chkOrderDate.Text = "Search by order date";
            this.chkOrderDate.UseVisualStyleBackColor = true;
            // 
            // chkRequiredDate
            // 
            this.chkRequiredDate.AutoSize = true;
            this.chkRequiredDate.Location = new System.Drawing.Point(12, 80);
            this.chkRequiredDate.Name = "chkRequiredDate";
            this.chkRequiredDate.Size = new System.Drawing.Size(139, 17);
            this.chkRequiredDate.TabIndex = 65;
            this.chkRequiredDate.Text = "Search by required date";
            this.chkRequiredDate.UseVisualStyleBackColor = true;
            // 
            // chkShippedDate
            // 
            this.chkShippedDate.AutoSize = true;
            this.chkShippedDate.Location = new System.Drawing.Point(12, 140);
            this.chkShippedDate.Name = "chkShippedDate";
            this.chkShippedDate.Size = new System.Drawing.Size(138, 17);
            this.chkShippedDate.TabIndex = 66;
            this.chkShippedDate.Text = "Search by shipped date";
            this.chkShippedDate.UseVisualStyleBackColor = true;
            // 
            // chkCustomerName
            // 
            this.chkCustomerName.AutoSize = true;
            this.chkCustomerName.Location = new System.Drawing.Point(12, 199);
            this.chkCustomerName.Name = "chkCustomerName";
            this.chkCustomerName.Size = new System.Drawing.Size(149, 17);
            this.chkCustomerName.TabIndex = 67;
            this.chkCustomerName.Text = "Search by customer name";
            this.chkCustomerName.UseVisualStyleBackColor = true;
            // 
            // chkTotalPrice
            // 
            this.chkTotalPrice.AutoSize = true;
            this.chkTotalPrice.Location = new System.Drawing.Point(12, 248);
            this.chkTotalPrice.Name = "chkTotalPrice";
            this.chkTotalPrice.Size = new System.Drawing.Size(123, 17);
            this.chkTotalPrice.TabIndex = 68;
            this.chkTotalPrice.Text = "Search by total price";
            this.chkTotalPrice.UseVisualStyleBackColor = true;
            // 
            // frmOrderSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 390);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmOrderSearch";
            this.Text = "frmOrderSearch";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCustomerName;
        public System.Windows.Forms.TextBox txtMaxTotalPrice;
        public System.Windows.Forms.TextBox txtMinTotalPrice;
        public System.Windows.Forms.DateTimePicker dtMaxShippedDate;
        public System.Windows.Forms.DateTimePicker dtMinShippedDate;
        public System.Windows.Forms.DateTimePicker dtMaxRequiredDate;
        public System.Windows.Forms.DateTimePicker dtMinRequiredDate;
        public System.Windows.Forms.DateTimePicker dtMaxOrderDate;
        public System.Windows.Forms.DateTimePicker dtMinOrderDate;
        public System.Windows.Forms.CheckBox chkTotalPrice;
        public System.Windows.Forms.CheckBox chkCustomerName;
        public System.Windows.Forms.CheckBox chkShippedDate;
        public System.Windows.Forms.CheckBox chkRequiredDate;
        public System.Windows.Forms.CheckBox chkOrderDate;
    }
}