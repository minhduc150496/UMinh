using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UMinh
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (true)
            {
                frmOrders form = new frmOrders();
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                //ActiveChildForm("FormEmployees");
            }
        }
    }
}
