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
    public partial class frmOrderDetailsInput : Form
    {
        private SqlConnection con;
        private SqlCommand cmd;

        public frmOrderDetailsInput()
        {
            InitializeComponent();
        }


        private bool validate()
        {
            return true;
        }

        #region Data Access Methods
        private void insert(
            int custid
           , int empid
           , string orderdate
           , string requireddate
           , string shippeddate

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
            // Mo connection
            con.Open();

            // Tao Command
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertOrderDetails";

            // Delete & Reload
            try
            {
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

        private void update()
        {

        }
        #endregion


        #region Event Handling Methods
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
