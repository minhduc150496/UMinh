﻿using System;
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
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeDetail frmEmpDetail = new frmEmployeeDetail();
            frmEmpDetail.MdiParent = this;
            frmEmpDetail.Show();
        }
    }
}
