using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace UMinh
{
    public partial class frmOrdersDetail : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public frmOrdersDetail()
        {
            InitializeComponent();
            // Tao connection
            con = new SqlConnection();
            con.ConnectionString = @"server=.;database=TSQLFundamentals2008;User ID=sa;Password=123456";

            // Lay du lieu bang Data Reader
            dataGridView.AutoGenerateColumns = true;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.ReadOnly = true;
            dataGridView.AllowUserToDeleteRows = false;

            // Gan ten cot 
            dataGridView.Columns.Add("orderid",         "Order ID");
            dataGridView.Columns.Add("customerid",      "Customer ID");
            dataGridView.Columns.Add("employeeid",      "Employee ID");
            dataGridView.Columns.Add("orderdate",       "Order date");
            dataGridView.Columns.Add("requieddate",     "Requied date");
            dataGridView.Columns.Add("shippeddate",     "Shipped date");
            dataGridView.Columns.Add("shipperid",       "Shipper ID");
            dataGridView.Columns.Add("freight",          "Freight");
            dataGridView.Columns.Add("shipname",        "Ship name");
            dataGridView.Columns.Add("shipaddress",     "Ship address");
            dataGridView.Columns.Add("shipcity",        "Ship city");
            dataGridView.Columns.Add("shipregion",      "Ship region");
            dataGridView.Columns.Add("shippostalcode",  "Ship postal code");
            dataGridView.Columns.Add("shipcountry",     "Ship country");

            // Lay du lieu
            loadData();
        }

        #region Data Access Methods
        private void loadData()
        {
            // Mo connection
            con.Open();

            // Tao Command
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LoadOrders";

            // Tao Data Reader
            SqlDataReader dr = null;
            try
            {
                if ((dr = cmd.ExecuteReader())!= null)
                {
                    using (dr)
                    {
                        while(dr.Read())
                        {
                            dataGridView.Rows.Add(
                                dr[0], dr[1], dr[2],
                                dr[3], dr[4], dr[5],
                                dr[6], dr[7], dr[8],
                                dr[9], dr[10], dr[11], 
                                dr[12], dr[13]);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error occurs.");
            } finally
            {
                con.Close();
            }
        }

        private void delete(int orderID)
        {
            // Mo connection
            con.Open();

            // Tao Command
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteOrder";

            // Delete & Reload
            try
            {
                cmd.Parameters.Add(new SqlParameter("@orderid", orderID));
                cmd.ExecuteNonQuery();
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs: " + ex);
            }
            finally
            {
                con.Close();
            }
        }
        #endregion

        #region Event Handling Methods
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmOrdersInput inputForm = new frmOrdersInput();
            using (inputForm)
            {
                inputForm.Owner = this;
                inputForm.isAddNew = true;
                inputForm.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }

            var selectedRow = dataGridView.SelectedRows[0];

            frmOrdersInput inputForm = new frmOrdersInput();
            using (inputForm)
            {
                inputForm.Owner = this;
                inputForm.isAddNew = false;
                inputForm.orderid = -1; // 


                inputForm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }
            try {
                // Confirm dialog
                MessageBox.Show("Are you sure you want to delete this order?", "Confirm Dialog", MessageBoxButtons.YesNo);
                // Execute
                var orderID = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                delete(orderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs: " + ex);
            }
        }
        #endregion

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
