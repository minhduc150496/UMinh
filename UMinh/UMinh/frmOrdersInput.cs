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
    public partial class frmOrdersInput : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;
        public bool isAddNew = false;
        public int orderid = -1;

        public frmOrdersInput()
        {
            InitializeComponent();
            // Tao connection
            con = new SqlConnection();
            con.ConnectionString = @"server=.;database=TSQLFundamentals2008;User ID=sa;Password=123456";

            // Init combobox
            cbCountry.DataSource = new List<string> {
                "Select a country",
                "USA",
                "France",
                "China",
                "Vietnam"
            };
        }

        private bool validate()
        {
            return true;
        }

        #region Data Access Methods
        private void save(
            int custid
           , int empid
           , DateTime orderdate
           , DateTime requireddate
           , DateTime shippeddate

           , int shipperid
           , Decimal freight
           , string shipname
           , string shipaddress
           , string shipcity

           , string shipregion
           , string shippostalcode
           , string shipcountry
            )
        {
            try
            {
                // Mo connection
                con.Open();

                // Tao Command
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = isAddNew ? "InsertOrder" : "UpdateOrder";

                // Execute
                if (isAddNew == false)
                {
                    cmd.Parameters.Add("@orderid", SqlDbType.Int).Value = orderid;
                }
                cmd.Parameters.Add("@custid", SqlDbType.Int).Value = custid;
                cmd.Parameters.Add("@empid", SqlDbType.Int).Value = empid;
                cmd.Parameters.Add("@orderdate", SqlDbType.DateTime).Value = orderdate;
                cmd.Parameters.Add("@requireddate", SqlDbType.DateTime).Value = requireddate;
                cmd.Parameters.Add("@shippeddate", SqlDbType.DateTime).Value = shippeddate;

                cmd.Parameters.Add("@shipperid", SqlDbType.Int).Value = shipperid;
                cmd.Parameters.Add("@freight", SqlDbType.Money).Value = freight;
                cmd.Parameters.Add("@shipname", SqlDbType.NVarChar).Value = shipname;
                cmd.Parameters.Add("@shipaddress", SqlDbType.NVarChar).Value = shipaddress;
                cmd.Parameters.Add("@shipcity", SqlDbType.NVarChar).Value = shipcity;

                cmd.Parameters.Add("@shipregion", SqlDbType.NVarChar).Value = shipregion;
                cmd.Parameters.Add("@shippostalcode", SqlDbType.NVarChar).Value = shippostalcode;
                cmd.Parameters.Add("@shipcountry", SqlDbType.NVarChar).Value = shipcountry;

                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurs: " + ex);
            }
            finally
            {
                if (con!=null)
                {
                    con.Close();
                }
            }
        }

        private void update()
        {

        }
        #endregion

        #region Event Handling Methods
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validate() == false)
            {
                return;
            }
            save(
                int.Parse(txtCustomerID.Text)
                , int.Parse(txtEmployeeID.Text)
                , dtOrder.Value
                , dtRequired.Value
                , dtShipped.Value
                , int.Parse(txtShipperID.Text)
                , Decimal.Parse(txtFreight.Text)
                , txtShipName.Text
                , txtShipAddress.Text
                , txtShipCity.Text
                , txtRegion.Text
                , txtShipPostalCode.Text
                , cbCountry.SelectedItem.ToString()
                );
        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtEmployeeID.Clear();
            txtFreight.Clear();
            txtRegion.Clear();
            txtShipAddress.Clear();
            txtShipCity.Clear();
            txtShipName.Clear();
            txtShipperID.Clear();
            txtShipPostalCode.Clear();

            dtOrder.ResetText();
            dtRequired.ResetText();
            dtShipped.ResetText();

            cbCountry.ResetText();
        }
    }
}
