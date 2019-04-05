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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void newTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewTrip fnt = new frmNewTrip();
            fnt.Show();
        }

        private void mnuFillUp_Click(object sender, EventArgs e)
        {
            frmFillUpGas ffp = new frmFillUpGas();
            ffp.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmInitialFuel fif = new frmInitialFuel();
            fif.MdiParent = this;
            fif.Show();
        }

        private void mnuViewTrip_Click(object sender, EventArgs e)
        {
            if (clsGlobal.listTrip == null)
            {
                MessageBox.Show("There is no trip!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmViewTrips fvt = new frmViewTrips();
            fvt.MdiParent = this;
            fvt.Show();
        }

        private void mnuNetIncome_Click(object sender, EventArgs e)
        {
            if (clsGlobal.listTrip == null)
            {
                MessageBox.Show("You currently have $0 net income! Please start your trip!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmNetIncome fni = new frmNetIncome();
            fni.MdiParent = this;
            fni.Show();
        }

        private void mnuMileage_Click(object sender, EventArgs e)
        {
            if (clsGlobal.listTrip == null)
            {
                MessageBox.Show("You currently have no mileage! Please start your trip!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            frmMileage fm = new frmMileage();
            fm.MdiParent = this;
            fm.Show();
        }

        private void mnuFuelLevel_Click(object sender, EventArgs e)
        {
            frmFuelLevel ffl = new frmFuelLevel();
            ffl.MdiParent = this;
            ffl.Show();
        }
    }
}
