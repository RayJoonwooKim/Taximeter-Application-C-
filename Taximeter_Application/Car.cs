using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Taximeter_Application
{
    public class Car
    {
        public double fuel { get; set; }

        public void FillInitialFuel(string fuel_str)
        {
            double fuel = Convert.ToDouble(fuel_str);
            clsGlobal.aCar = new Car();
            clsGlobal.aCar.fuel = fuel;
        }
        public void FillUpGas(string gas_str)
        {

            double gas = Convert.ToDouble(gas_str);
            
            if (gas > clsGlobal.net_income)
            {
                MessageBox.Show("You do not have enough balance!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (clsGlobal.net_income > gas)
            {
                Random rnd = new Random();
                double max = 0.0;
                double min = 0.0;
                double gas_cost = rnd.NextDouble() * (max - min) + min; //Random number
                Math.Round(gas_cost, 2);
                double total = 0;
                total = gas * gas_cost;
                clsGlobal.net_income -= total;
                clsGlobal.aCar.fuel += gas;
                MessageBox.Show("Gas was filled successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }
        }
        
    }
}
