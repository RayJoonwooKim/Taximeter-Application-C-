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
    public partial class frmViewTrips : Form
    {
        public frmViewTrips()
        {
            InitializeComponent();
        }

        private void frmViewTrips_Load(object sender, EventArgs e)
        {

            lblTripCount.Text = clsGlobal.count.ToString();
        }
    }
}
