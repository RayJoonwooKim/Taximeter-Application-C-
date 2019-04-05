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
    public partial class frmNewTrip : Form
    {
        public frmNewTrip()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
            Trip aTrip = new Trip();
            if (txt_start_time.Text == "")
            {
                MessageBox.Show("Please enter start time of the trip!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txt_finish_time.Text == "")
            {
                MessageBox.Show("Please enter finish time of the trip!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtSpeed.Text == "")
            {
                MessageBox.Show("Please enter speed of the trip!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            aTrip.Start(txt_start_time.Text, txt_finish_time.Text, txtSpeed.Text, lblMileage.Text, lblEstimate.Text);
            btnStart.Enabled = false;
            lblFuel.Text = clsGlobal.aCar.fuel.ToString();
            txt_start_time.Clear();
            txt_finish_time.Clear();
            txtSpeed.Clear();
            lblEstimate.Text = "";
            lblMileage.Text = "";
            lblCost.Text = "";


        }

        private void frmNewTrip_Load(object sender, EventArgs e)
        {
            lblMileage.Text = "";
            lblFuel.Text = clsGlobal.aCar.fuel.ToString();
            btnStart.Enabled = false;
            lblEstimate.Text = "";
            lblCost.Text = "";
        }

        private void btnEstimate_Click(object sender, EventArgs e)
        {
            if (txt_start_time.Text == "")
            {
                MessageBox.Show("Please enter start time of the trip!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txt_finish_time.Text == "")
            {
                MessageBox.Show("Please enter finish time of the trip!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if (txtSpeed.Text == "")
            {
                MessageBox.Show("Please enter speed of the trip!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Trip aTrip = new Trip();

            lblCost.Text = aTrip.CalculateTripCost(txt_start_time.Text, txt_finish_time.Text).ToString();
            lblEstimate.Text = aTrip.FuelConsumption(txt_start_time.Text, txt_finish_time.Text, txtSpeed.Text).ToString();
            lblMileage.Text = aTrip.CalculateMileage(txt_start_time.Text, txt_finish_time.Text, txtSpeed.Text).ToString();
            
            btnStart.Enabled = true;

        }
    }
}
