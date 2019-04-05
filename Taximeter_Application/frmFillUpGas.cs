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
    public partial class frmFillUpGas : Form
    {
        static double total;
        public frmFillUpGas()
        {
            InitializeComponent();
        }

        private void frmFillUpGas_Load(object sender, EventArgs e)
        {
            lblCost.Text = "";
            lblBalance.Text = clsGlobal.net_income.ToString();
            lblGas.Text = clsGlobal.aCar.fuel.ToString();
        }

        private void btnFill_Click(object sender, EventArgs e)
        {
            if (txtGas.Text == "")
            {
                MessageBox.Show("Please enter the amount of fuel!","Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                if (clsGlobal.net_income < Convert.ToDouble(lblCost.Text))
                {
                    clsGlobal.aCar.FillUpGas(txtGas.Text);
                    lblBalance.Text = clsGlobal.net_income.ToString();
                    lblGas.Text = clsGlobal.aCar.fuel.ToString();
                    lblCost.Text = "";
                    txtGas.Text = "";
                }
                else
                {
                    clsGlobal.aCar.FillUpGas(txtGas.Text);
                    clsGlobal.net_income -= Convert.ToDouble(lblCost.Text);
                    lblBalance.Text = clsGlobal.net_income.ToString();
                    lblGas.Text = clsGlobal.aCar.fuel.ToString();
                    lblCost.Text = "";
                    txtGas.Text = "";
                }
            }
            
            
            
            
        }

        private void txtGas_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtGas.Text == "")
            {
                MessageBox.Show("Please enter the amount of fuel!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Trip aTrip = new Trip();
            lblCost.Text = aTrip.CalculateCost(txtGas.Text).ToString();
        }
    }
}
