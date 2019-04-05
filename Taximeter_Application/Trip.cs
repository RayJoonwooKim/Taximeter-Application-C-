using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Taximeter_Application
{
    public class Trip
    {
        public double start_time { get; set; }
        public double finish_time { get; set; }
        public double speed { get; set; }
        public double cost { get; set; }
        public double fuel_consumption { get; set; }

        public void Start(string txt_st, string txt_ft, string txt_sp, string txt_mileage, string txt_fuel)
        {
            //00h00 - 08h00 = $30
            //08h00 - 14h00 = $20
            //14h00 - 00h00 = $25

            clsGlobal.listTrip = new List<Trip>();
            
            double st = Convert.ToDouble(txt_st);
            double ft = Convert.ToDouble(txt_ft);
            double sp = Convert.ToDouble(txt_sp);
            double mil = Convert.ToDouble(txt_mileage);
            double fuel = Convert.ToDouble(txt_fuel);
            double r1 = 30;
            double r2 = 20;
            double r3 = 25;

            if ( (ft - st) > 12 || (ft-st) < -12)
            {
                MessageBox.Show("A trip cannot be more than 12 hours!","Message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
            else if (fuel > clsGlobal.aCar.fuel)
            {
                if (MessageBox.Show("You do not seem to have enough fuel to start the trip. Do you still want to proceed?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (st >= 0 && st <= 8 && ft >= 0 && ft <= 8)
                    {
                        Trip aTrip = new Trip();

                        aTrip.start_time = st;
                        aTrip.finish_time = ft;
                        aTrip.speed = sp;
                        aTrip.cost = Math.Round((ft - st) * r1,2);

                        clsGlobal.net_income += aTrip.cost;
                        clsGlobal.mileage += mil;
                        clsGlobal.listTrip.Add(aTrip);
                        clsGlobal.count += 1;
                        clsGlobal.aCar.fuel -= fuel;
                        MessageBox.Show("Trip started successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (st >= 0 && st <= 8 && ft > 8 && ft <= 14)
                    {
                        Trip aTrip = new Trip();
                        double time_diff = ft - st;
                        aTrip = new Trip();
                        aTrip.start_time = st;
                        aTrip.finish_time = ft;
                        aTrip.speed = sp;
                        aTrip.cost = Math.Round((8 - st) * r1 + (ft - 8) * r2,2);

                        clsGlobal.net_income += aTrip.cost;
                        clsGlobal.mileage += mil;
                        clsGlobal.listTrip.Add(aTrip);
                        clsGlobal.count += 1;
                        clsGlobal.aCar.fuel -= fuel;
                        MessageBox.Show("Trip started successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (st > 8 && st <= 14 && ft > 8 && ft <= 14)
                    {
                        Trip aTrip = new Trip();
                        double time_diff = ft - st;
                        aTrip = new Trip();
                        aTrip.start_time = st;
                        aTrip.finish_time = ft;
                        aTrip.speed = sp;
                        aTrip.cost = Math.Round((ft - st) * r2,2);

                        clsGlobal.net_income += aTrip.cost;
                        clsGlobal.mileage += mil;
                        clsGlobal.listTrip.Add(aTrip);
                        clsGlobal.count += 1;
                        clsGlobal.aCar.fuel -= fuel;
                        MessageBox.Show("Trip started successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (st > 8 && st <= 14 && ft >= 14)
                    {
                        Trip aTrip = new Trip();
                        double time_diff = ft - st;
                        aTrip.start_time = st;
                        aTrip.finish_time = ft;
                        aTrip.speed = sp;
                        aTrip.cost = Math.Round((14 - st) * r2 + (ft - 14) * r3,2);

                        clsGlobal.net_income += aTrip.cost;
                        clsGlobal.mileage += mil;
                        clsGlobal.listTrip.Add(aTrip);
                        clsGlobal.count += 1;
                        clsGlobal.aCar.fuel -= fuel;
                        MessageBox.Show("Trip started successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (st > 14 && st <= 24 && ft > 14 && ft <= 24)
                    {
                        Trip aTrip = new Trip();
                        double time_diff = ft - st;
                        aTrip = new Trip();
                        aTrip.start_time = st;
                        aTrip.finish_time = ft;
                        aTrip.speed = sp;
                        aTrip.cost = Math.Round((ft - st) * r3,2);

                        clsGlobal.net_income += aTrip.cost;
                        clsGlobal.mileage += mil;
                        clsGlobal.listTrip.Add(aTrip);
                        clsGlobal.count += 1;
                        clsGlobal.aCar.fuel -= fuel;
                        MessageBox.Show("Trip started successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }


                }
            }
            else if (st >= 0 && st <= 8 && ft >= 0 && ft <= 8)
            {
                Trip aTrip = new Trip();

                aTrip.start_time = st;
                aTrip.finish_time = ft;
                aTrip.speed = sp;
                aTrip.cost = Math.Round((ft - st) * r1,2);

                clsGlobal.net_income += aTrip.cost;
                clsGlobal.mileage += mil;
                clsGlobal.listTrip.Add(aTrip);
                clsGlobal.count += 1;
                clsGlobal.aCar.fuel -= fuel;
                MessageBox.Show("Trip started successfully!","Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            else if (st >= 0 && st <= 8 && ft > 8 && ft <= 14)
            {
                Trip aTrip = new Trip();
                double time_diff = ft - st;
                aTrip = new Trip();
                aTrip.start_time = st;
                aTrip.finish_time = ft;
                aTrip.speed = sp;
                aTrip.cost = Math.Round((8 - st) * r1 + (ft - 8) * r2,2);

                clsGlobal.net_income += aTrip.cost;
                clsGlobal.mileage += mil;
                clsGlobal.listTrip.Add(aTrip);
                clsGlobal.count += 1;
                clsGlobal.aCar.fuel -= fuel;
                MessageBox.Show("Trip started successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (st > 8 && st <= 14 && ft > 8 && ft <= 14)
            {
                Trip aTrip = new Trip();
                double time_diff = ft - st;
                aTrip = new Trip();
                aTrip.start_time = st;
                aTrip.finish_time = ft;
                aTrip.speed = sp;
                aTrip.cost = Math.Round((ft - st) * r2,2);

                clsGlobal.net_income += aTrip.cost;
                clsGlobal.mileage += mil;
                clsGlobal.listTrip.Add(aTrip);
                clsGlobal.count += 1;
                clsGlobal.aCar.fuel -= fuel;
                MessageBox.Show("Trip started successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (st > 8 && st <= 14 && ft >= 14)
            {
                Trip aTrip = new Trip();
                double time_diff = ft - st;
                aTrip.start_time = st;
                aTrip.finish_time = ft;
                aTrip.speed = sp;
                aTrip.cost = Math.Round((14 - st) * r2 + (ft - 14) * r3,2);

                clsGlobal.net_income += aTrip.cost;
                clsGlobal.mileage += mil;
                clsGlobal.listTrip.Add(aTrip);
                clsGlobal.count += 1;
                clsGlobal.aCar.fuel -= fuel;
                MessageBox.Show("Trip started successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (st > 14 && st <= 24 && ft > 14 && ft <= 24)
            {
                Trip aTrip = new Trip();
                double time_diff = ft - st;
                aTrip = new Trip();
                aTrip.start_time = st;
                aTrip.finish_time = ft;
                aTrip.speed = sp;
                aTrip.cost = Math.Round((ft - st) * r3,2);

                clsGlobal.net_income += aTrip.cost;
                clsGlobal.mileage += mil;
                clsGlobal.listTrip.Add(aTrip);
                clsGlobal.count += 1;
                clsGlobal.aCar.fuel -= fuel;
                MessageBox.Show("Trip started successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            
        }
        
        public double CalculateTripCost(string txt_st, string txt_ft)
        {
            double st = Convert.ToDouble(txt_st);
            double ft = Convert.ToDouble(txt_ft);
            double cost = 0.0;

            double r1 = 30;
            double r2 = 20;
            double r3 = 25;

            if (st >= 0 && st <= 8 && ft >= 0 && ft <= 8)
            {
                cost = Math.Round((ft - st) * r1,2);
                
            }
            else if (st >= 0 && st <= 8 && ft > 8 && ft <= 14)
            {
                cost = Math.Round((8 - st) * r1 + (ft - 8) * r2,2);
                
            }
            else if (st > 8 && st <= 14 && ft > 8 && ft <= 14)
            {
                
                cost = Math.Round((ft - st) * r2,2);
                
            }
            else if (st > 8 && st <= 14 && ft >= 14)
            {
                
                cost = Math.Round((14 - st) * r2 + (ft - 14) * r3,2);
                
            }
            else if (st > 14 && st <= 24 && ft > 14 && ft <= 24)
            {
                cost = Math.Round((ft - st) * r3,2);
                
            }
            return cost;
        }
        public double CalculateCost(string gas_str)
        {
            Random rnd = new Random();
            double max = 1.45;
            double min = 1.15;
            double total = 0.0;
            double gas_cost = rnd.NextDouble() * (max - min) + min;
            Math.Round(gas_cost, 2);
            return total = Math.Round((Convert.ToDouble(gas_str) * gas_cost), 2);
        }
        public double FuelConsumption(string txt_st, string txt_ft, string txt_sp)
        {
            double st = Convert.ToDouble(txt_st);
            double ft = Convert.ToDouble(txt_ft);
            double sp = Convert.ToDouble(txt_sp);
            double time_diff = ft - st;
            double estimate = 0.0;
            estimate = Math.Round(((time_diff) * Math.Abs(Math.Tan(sp * time_diff)) + Math.Abs(Math.Cos(sp))), 2);

            return estimate;
        }
        
        public double CalculateMileage(string txt_st, string txt_ft, string txt_sp)
        {
            double time_diff = Convert.ToDouble(txt_ft) - Convert.ToDouble(txt_st);
            double sp = Convert.ToDouble(txt_sp);
            double mileage = 0.0;
            mileage += Math.Pow(sp, 2 * time_diff) - sp * time_diff;

            return Math.Round(mileage,2);
        }
    }
}
