using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taximeter_Application
{
    public partial class frmNetIncome : Form
    {
        public frmNetIncome()
        {
            InitializeComponent();
        }

        private void frmNetIncome_Load(object sender, EventArgs e)
        {
            lblNetIncome.Text = clsGlobal.net_income.ToString();
        }
    }
}
