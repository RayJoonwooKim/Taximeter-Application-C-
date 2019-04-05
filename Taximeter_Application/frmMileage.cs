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
    public partial class frmMileage : Form
    {
        public frmMileage()
        {
            InitializeComponent();
        }

        private void frmMileage_Load(object sender, EventArgs e)
        {
            Trip aTrip = new Trip();
            lblMileage.Text = clsGlobal.mileage.ToString();
        }
    }
}
