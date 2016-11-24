namespace UMinh
{
    partial class frmOrdersDetail
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
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
            this.rdOrderDate = new System.Windows.Forms.RadioButton();
            this.rdRequiredDate = new System.Windows.Forms.RadioButton();
            this.rdShippedDate = new System.Windows.Forms.RadioButton();
            this.rdCustName = new System.Windows.Forms.RadioButton();
            this.rdTotalPrice = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 226);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(779, 221);
            this.dataGridView.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(174, 453);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(93, 453);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 21;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(12, 453);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 20;
            this.btnAddNew.Text = "Add New";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
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
            this.groupBox1.Size = new System.Drawing.Size(779, 195);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(686, 159);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 63;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(605, 159);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(519, 42);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(237, 20);
            this.txtCustomerName.TabIndex = 60;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtMaxTotalPrice
            // 
            this.txtMaxTotalPrice.Location = new System.Drawing.Point(661, 102);
            this.txtMaxTotalPrice.Name = "txtMaxTotalPrice";
            this.txtMaxTotalPrice.Size = new System.Drawing.Size(95, 20);
            this.txtMaxTotalPrice.TabIndex = 58;
            // 
            // txtMinTotalPrice
            // 
            this.txtMinTotalPrice.Location = new System.Drawing.Point(553, 102);
            this.txtMinTotalPrice.Name = "txtMinTotalPrice";
            this.txtMinTotalPrice.Size = new System.Drawing.Size(80, 20);
            this.txtMinTotalPrice.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(516, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 56;
            this.label7.Text = "From";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(639, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 13);
            this.label8.TabIndex = 55;
            this.label8.Text = "to";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 51;
            this.label5.Text = "From";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "to";
            // 
            // dtMaxShippedDate
            // 
            this.dtMaxShippedDate.Location = new System.Drawing.Point(278, 163);
            this.dtMaxShippedDate.Name = "dtMaxShippedDate";
            this.dtMaxShippedDate.Size = new System.Drawing.Size(200, 20);
            this.dtMaxShippedDate.TabIndex = 49;
            // 
            // dtMinShippedDate
            // 
            this.dtMinShippedDate.Location = new System.Drawing.Point(50, 163);
            this.dtMinShippedDate.Name = "dtMinShippedDate";
            this.dtMinShippedDate.Size = new System.Drawing.Size(200, 20);
            this.dtMinShippedDate.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 46;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(256, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "to";
            // 
            // dtMaxRequiredDate
            // 
            this.dtMaxRequiredDate.Location = new System.Drawing.Point(278, 103);
            this.dtMaxRequiredDate.Name = "dtMaxRequiredDate";
            this.dtMaxRequiredDate.Size = new System.Drawing.Size(200, 20);
            this.dtMaxRequiredDate.TabIndex = 44;
            // 
            // dtMinRequiredDate
            // 
            this.dtMinRequiredDate.Location = new System.Drawing.Point(50, 103);
            this.dtMinRequiredDate.Name = "dtMinRequiredDate";
            this.dtMinRequiredDate.Size = new System.Drawing.Size(200, 20);
            this.dtMinRequiredDate.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "to";
            // 
            // dtMaxOrderDate
            // 
            this.dtMaxOrderDate.Location = new System.Drawing.Point(278, 42);
            this.dtMaxOrderDate.Name = "dtMaxOrderDate";
            this.dtMaxOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtMaxOrderDate.TabIndex = 39;
            // 
            // dtMinOrderDate
            // 
            this.dtMinOrderDate.Location = new System.Drawing.Point(50, 42);
            this.dtMinOrderDate.Name = "dtMinOrderDate";
            this.dtMinOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtMinOrderDate.TabIndex = 38;
            // 
            // rdOrderDate
            // 
            this.rdOrderDate.AutoSize = true;
            this.rdOrderDate.Location = new System.Drawing.Point(14, 19);
            this.rdOrderDate.Name = "rdOrderDate";
            this.rdOrderDate.Size = new System.Drawing.Size(124, 17);
            this.rdOrderDate.TabIndex = 64;
            this.rdOrderDate.TabStop = true;
            this.rdOrderDate.Text = "Search by order date";
            this.rdOrderDate.UseVisualStyleBackColor = true;
            // 
            // rdRequiredDate
            // 
            this.rdRequiredDate.AutoSize = true;
            this.rdRequiredDate.Location = new System.Drawing.Point(14, 80);
            this.rdRequiredDate.Name = "rdRequiredDate";
            this.rdRequiredDate.Size = new System.Drawing.Size(138, 17);
            this.rdRequiredDate.TabIndex = 65;
            this.rdRequiredDate.TabStop = true;
            this.rdRequiredDate.Text = "Search by required date";
            this.rdRequiredDate.UseVisualStyleBackColor = true;
            // 
            // rdShippedDate
            // 
            this.rdShippedDate.AutoSize = true;
            this.rdShippedDate.Location = new System.Drawing.Point(14, 140);
            this.rdShippedDate.Name = "rdShippedDate";
            this.rdShippedDate.Size = new System.Drawing.Size(137, 17);
            this.rdShippedDate.TabIndex = 66;
            this.rdShippedDate.TabStop = true;
            this.rdShippedDate.Text = "Search by shipped date";
            this.rdShippedDate.UseVisualStyleBackColor = true;
            // 
            // rdCustName
            // 
            this.rdCustName.AutoSize = true;
            this.rdCustName.Location = new System.Drawing.Point(519, 19);
            this.rdCustName.Name = "rdCustName";
            this.rdCustName.Size = new System.Drawing.Size(148, 17);
            this.rdCustName.TabIndex = 67;
            this.rdCustName.TabStop = true;
            this.rdCustName.Text = "Search by customer name";
            this.rdCustName.UseVisualStyleBackColor = true;
            // 
            // rdTotalPrice
            // 
            this.rdTotalPrice.AutoSize = true;
            this.rdTotalPrice.Location = new System.Drawing.Point(519, 80);
            this.rdTotalPrice.Name = "rdTotalPrice";
            this.rdTotalPrice.Size = new System.Drawing.Size(156, 17);
            this.rdTotalPrice.TabIndex = 68;
            this.rdTotalPrice.TabStop = true;
            this.rdTotalPrice.Text = "Search by order\'s total price";
            this.rdTotalPrice.UseVisualStyleBackColor = true;
            // 
            // frmOrdersDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 490);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.dataGridView);
            this.Name = "frmOrdersDetail";
            this.Text = "frmOrdersDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.TextBox txtMaxTotalPrice;
        private System.Windows.Forms.TextBox txtMinTotalPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton rdTotalPrice;
        private System.Windows.Forms.RadioButton rdCustName;
        private System.Windows.Forms.RadioButton rdShippedDate;
        private System.Windows.Forms.RadioButton rdRequiredDate;
        private System.Windows.Forms.RadioButton rdOrderDate;
    }
}