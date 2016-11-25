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
    public partial class frmOrderSearch : Form
    {
        private string connectionString =
            @"server=.;database=TSQLFundamentals2008;User ID=sa;Password=123456";

        public frmOrderSearch()
        {
            InitializeComponent();
        }

        #region Data Access Methods
        private void LoadCustomerIDs()
        {

        }
        #endregion

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var parentForm = (frmOrders)this.Owner;
            parentForm.SearchOrders((frmOrderSearch)this);
        }
    }
}
