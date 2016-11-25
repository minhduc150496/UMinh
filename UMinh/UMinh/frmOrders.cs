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
    public partial class frmOrders : Form
    {
        private string connectionString = @"server=.;database=TSQLFundamentals2008;User ID=sa;Password=123456";

        public frmOrders()
        {
            InitializeComponent();

            // Tuy chinh dgOrders
            dgOrders.AutoGenerateColumns = true;
            dgOrders.AllowUserToAddRows = false;
            dgOrders.ReadOnly = true;
            dgOrders.AllowUserToDeleteRows = false;
            dgOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Gan ten cot cho dgOrders
            dgOrders.Columns.Add("orderid",         "Order ID");
            dgOrders.Columns.Add("customerid",      "Customer ID");
            dgOrders.Columns.Add("employeeid",      "Employee ID");
            dgOrders.Columns.Add("orderdate",       "Order date");
            dgOrders.Columns.Add("requieddate",     "Requied date");
            dgOrders.Columns.Add("shippeddate",     "Shipped date");
            dgOrders.Columns.Add("shipperid",       "Shipper ID");
            dgOrders.Columns.Add("freight",          "Freight");
            dgOrders.Columns.Add("shipname",        "Ship name");
            dgOrders.Columns.Add("shipaddress",     "Ship address");
            dgOrders.Columns.Add("shipcity",        "Ship city");
            dgOrders.Columns.Add("shipregion",      "Ship region");
            dgOrders.Columns.Add("shippostalcode",  "Ship postal code");
            dgOrders.Columns.Add("shipcountry",     "Ship country");

            // Tuy chinh dgOrderDetails
            dgOrderDetails.AutoGenerateColumns = true;
            dgOrderDetails.AllowUserToAddRows = false;
            dgOrderDetails.ReadOnly = true;
            dgOrderDetails.AllowUserToDeleteRows = false;
            dgOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Gan ten cot cho dgOrderDetails
            dgOrderDetails.Columns.Add("productid", "Product ID");
            dgOrderDetails.Columns.Add("unitprice", "Unit Price");
            dgOrderDetails.Columns.Add("qty", "Quantity");
            dgOrderDetails.Columns.Add("discount", "Discount");

            // Lay du lieu
            LoadOrders();
        }

        #region Data Access Methods
        private void LoadOrders()
        {
            // Mo connection
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            // Tao Command
            SqlCommand cmd = new SqlCommand();
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
                        dgOrders.Rows.Clear();
                        while(dr.Read())
                        {
                            dgOrders.Rows.Add(
                                dr[0], dr[1], dr[2],
                                dr[3], dr[4], dr[5],
                                dr[6], dr[7], dr[8],
                                dr[9], dr[10], dr[11], 
                                dr[12], dr[13]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs when loading orders: " + ex);
            } finally
            {
                if (con!=null)
                {
                    con.Close();
                }
            }
        }

        private void LoadOrderDetailsByOrderID(int orderID)
        {
            // Mo connection
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            // Tao Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "LoadOrderDetailsByOrderID";

            cmd.Parameters.Add(new SqlParameter("@orderid", orderID));

            // Tao Data Reader
            SqlDataReader dr = null;
            try
            {
                if ((dr = cmd.ExecuteReader()) != null)
                {
                    using (dr)
                    {
                        dgOrderDetails.Rows.Clear();
                        while (dr.Read())
                        {
                            dgOrderDetails.Rows.Add(
                                dr[1], dr[2],
                                dr[3], dr[4]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs when loading order details:\n" + ex.Message);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void DeleteOrder(int orderID)
        {
            // Mo connection
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            // Tao Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteOrder";

            cmd.Parameters.Add(new SqlParameter("@orderid", orderID));
            // Delete & Reload
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs: " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        private void DeleteItem(int orderID, int productID)
        {
            // Mo connection
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            // Tao Command
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteOrderDetails";

            // Delete & Reload
            try
            {
                cmd.Parameters.Add(new SqlParameter("@orderid", orderID));
                cmd.Parameters.Add(new SqlParameter("@productid", productID));
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs: " + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
        }

        public void SearchOrders(frmOrderSearch childForm)
        {
            // Mo connection
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            // Tao Command
            SqlCommand cmd = new SqlCommand("SearchOrders", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@searchByOrderDate", SqlDbType.Bit).Value
                = childForm.chkOrderDate.Checked;
            cmd.Parameters.Add("@minOrderDate", SqlDbType.DateTime).Value
                = childForm.dtMinOrderDate.Value;
            cmd.Parameters.Add("@maxOrderDate", SqlDbType.DateTime).Value
                = childForm.dtMaxOrderDate.Value;

            cmd.Parameters.Add("@searchByRequiredDate", SqlDbType.Bit).Value
                = childForm.chkRequiredDate.Checked;
            cmd.Parameters.Add("@minRequiredDate", SqlDbType.DateTime).Value
                = childForm.dtMinRequiredDate.Value;
            cmd.Parameters.Add("@maxRequiredDate", SqlDbType.DateTime).Value
                = childForm.dtMaxRequiredDate.Value;

            cmd.Parameters.Add("@searchByShippedDate", SqlDbType.Bit).Value
                = childForm.chkShippedDate.Checked;
            cmd.Parameters.Add("@minShippedDate", SqlDbType.DateTime).Value
                = childForm.dtMinShippedDate.Value;
            cmd.Parameters.Add("@maxShippedDate", SqlDbType.DateTime).Value
                = childForm.dtMaxShippedDate.Value;

            cmd.Parameters.Add("@searchByCustName", SqlDbType.Bit).Value
                = childForm.chkCustomerName.Checked;
            cmd.Parameters.Add("@custName", SqlDbType.NVarChar).Value
                = childForm.txtCustomerName.Text;

            cmd.Parameters.Add("@searchByOrderTotalPrice", SqlDbType.Bit).Value
                = childForm.chkTotalPrice.Checked;
            if (childForm.chkTotalPrice.Checked)
            {
                cmd.Parameters.Add("@minTotalPrice", SqlDbType.Money).Value
                    = decimal.Parse(childForm.txtMinTotalPrice.Text);
                cmd.Parameters.Add("@maxTotalPrice", SqlDbType.Money).Value
                    = decimal.Parse(childForm.txtMaxTotalPrice.Text);
            }

            try
            {
                SqlDataReader dr = null;
                if ((dr = cmd.ExecuteReader()) != null)
                {
                    using (dr)
                    {
                        dgOrders.Rows.Clear();
                        while (dr.Read())
                        {
                            dgOrders.Rows.Add(
                                dr[0], dr[1], dr[2],
                                dr[3], dr[4], dr[5],
                                dr[6], dr[7], dr[8],
                                dr[9], dr[10], dr[11],
                                dr[12], dr[13]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs when searching: \n" + ex);
            }
            finally
            {
                con.Close();
            }

        }
        #endregion

        #region Event Handling Methods
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }

            var selectedRow = dgOrders.SelectedRows[0];

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
            // bo di nhak
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

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            frmOrdersInput inputForm = new frmOrdersInput();
            using (inputForm)
            {
                inputForm.Owner = this;
                inputForm.isAddNew = true;
                inputForm.ShowDialog();
            }
        }

        private void btnSearchOrder_Click(object sender, EventArgs e)
        {
            frmOrderSearch childForm = new frmOrderSearch();
            using (childForm)
            {
                childForm.Owner = this;
                childForm.ShowDialog();
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            frmOrderDetailsInput inputForm = new frmOrderDetailsInput();
            using (inputForm)
            {
                inputForm.Owner = this;
                inputForm.ShowDialog();
            }
        }

        private void btnSearchItem_Click(object sender, EventArgs e)
        {

        }

        private void dgOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgOrders.SelectedRows.Count == 0)
            {
                return;
            }
            var orderID = int.Parse(dgOrders.SelectedRows[0].Cells[0].Value.ToString());
            LoadOrderDetailsByOrderID(orderID);
        }

        private void btnEditItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgOrderDetails.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }
            try
            {
                // Confirm dialog
                MessageBox.Show("Are you sure you want to delete this order?", "Confirm Dialog", MessageBoxButtons.YesNo);
                // Execute
                var orderID = int.Parse(dgOrders.SelectedRows[0].Cells[0].Value.ToString());
                var productID = int.Parse(dgOrderDetails.SelectedRows[0].Cells[0].Value.ToString());
                DeleteItem(orderID, productID);
                LoadOrderDetailsByOrderID(orderID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs: " + ex);
            }
        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (dgOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }
            try
            {
                // Confirm dialog
                var result = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Dialog", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes) { 
                    // Execute
                    var orderID = int.Parse(dgOrders.SelectedRows[0].Cells[0].Value.ToString());
                    DeleteOrder(orderID);
                    LoadOrders();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs: " + ex);
            }
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            if (dgOrders.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }
            frmOrdersInput childForm = new frmOrdersInput();
            using (childForm)
            {
                childForm.Owner = this;
                childForm.isAddNew = false;
                childForm.orderid = int.Parse(dgOrders.SelectedRows[0].Cells[0].ToString());
                
                childForm.ShowDialog();
            }
        }

        private void frmOrders_Deactivate(object sender, EventArgs e)
        {
        }
    }
}
