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
    public partial class frmFuelLevel : Form
    {
        public frmFuelLevel()
        {
            InitializeComponent();
        }

        private void frmFuelLevel_Load(object sender, EventArgs e)
        {
            lblFuelLevel.Text = clsGlobal.aCar.fuel.ToString();
        }
    }
}
