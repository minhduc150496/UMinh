using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UMinh
{
    public partial class frmOrderDetailsDetail : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public frmOrderDetailsDetail()
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
            dataGridView.Columns.Add("orderid", "Order ID");
            dataGridView.Columns.Add("productid", "Product ID");
            dataGridView.Columns.Add("unitprice", "Unit Price");
            dataGridView.Columns.Add("qty", "Quantity");
            dataGridView.Columns.Add("discount", "Discount");

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
            cmd.CommandText = "LoadOrderDetails";

            // Tao Data Reader
            SqlDataReader dr = null;
            try
            {
                if ((dr = cmd.ExecuteReader()) != null)
                {
                    using (dr)
                    {
                        while (dr.Read())
                        {
                            dataGridView.Rows.Add
                                (dr[0], dr[1], dr[2], dr[3], dr[4]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs :" + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void delete(int orderID, int productID)
        {
            // Mo connection
            con.Open();

            // Tao Command
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteOrderDetails";

            // Delete & Reload
            try
            {
                cmd.Parameters.Add(new SqlParameter("@orderid", orderID));
                cmd.Parameters.Add(new SqlParameter("@productid", productID));
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
                inputForm.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("No row selected.");
                return;
            }
            try
            {
                // Confirm dialog
                MessageBox.Show("Are you sure you want to delete this order?", "Confirm Dialog", MessageBoxButtons.YesNo);
                // Execute
                var orderID = int.Parse(dataGridView.SelectedRows[0].Cells[0].Value.ToString());
                var productID = int.Parse(dataGridView.SelectedRows[0].Cells[1].Value.ToString());
                delete(orderID, productID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs: " + ex);
            }
        }
        #endregion
    }
}
