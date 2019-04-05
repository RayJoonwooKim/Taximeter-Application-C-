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
    public partial class frmInitialFuel : Form
    {
        public frmInitialFuel()
        {
            InitializeComponent();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (txtFuelLevel.Text == "")
            {
                MessageBox.Show("You must fill in the initial fuel level!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            clsGlobal.aCar = new Car();
            clsGlobal.aCar.FillInitialFuel(txtFuelLevel.Text);
            this.Close();
        }
    }
}
