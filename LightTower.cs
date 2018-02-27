using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SolarChart
{
    public partial class EnergyChart : Form
    {
        int yAxisDynamic = 10500;

        public EnergyChart()
        {
            InitializeComponent();

            chart1.ChartAreas[0].AxisX.Maximum = 365;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            chart1.ChartAreas[0].AxisY.Maximum = 10500;
            //if (radBtn300.Checked == true) chart1.ChartAreas[0].AxisY.Maximum = 16500;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.ChartAreas[0].AxisX.Interval = 90;
            chart1.ChartAreas[0].AxisY.Interval = 1500;

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            //chart1.ChartAreas["ChartArea1"].AxisY.ScaleView.Zoom(0, 20000);
            //chart1.ChartAreas["ChartArea1"].AxisX.ScaleView.Zoom(0, 20000);
            chart1.ChartAreas[0].AxisX.Maximum = 365;
            chart1.ChartAreas[0].AxisX.Minimum = 0;

            /* choose next appropriate y-axis scale. */
            if (yAxisDynamic < 10501) yAxisDynamic = 10500;
            else
            {
                if (yAxisDynamic < 20001) yAxisDynamic = 20000;
                else
                {
                    if (yAxisDynamic < 30001) yAxisDynamic = 30000;
                    else
                    {
                        if (yAxisDynamic < 40001) yAxisDynamic = 40000;
                        else yAxisDynamic = 50000;
                    }
                }
            }

            chart1.ChartAreas[0].AxisY.Maximum = yAxisDynamic;
            //if (radBtn300.Checked == true) chart1.ChartAreas[0].AxisY.Maximum = 16500;
            chart1.ChartAreas[0].AxisY.Minimum = 0;

            chart1.ChartAreas[0].AxisX.Interval = 90;
            chart1.ChartAreas[0].AxisY.Interval = 1500;

        }

        private void LoadChart_Click(object sender, EventArgs e)
        {
            numberCruncher();
        }

        private void numberCruncher()
        {
            decimal[] valNite = new decimal[365];
            decimal[] valSunHrs = new decimal[365];
            int daysYear = 365;
            int daysShift = 11;
            int lampWatts = 160;
            int lampQty = 4;
            int brightness = 100;
            int panelWatts = 250;   
            int panelQty = 3;
            int daysPerWeek = 0;
            int batteryQty = 12;

            int weight1Gallon = 3240;   // Weight of 1 gallon of diesel fuel in grams.
            int gramsKWh = 506;         // Fuel rate conversion, weight of diesel meeded per KiloWatt-hour.
            int gramsNeeded = 7650;     // Default grams of diesel required to fully charge the batteries.
            int fuelGallons = 24;       // Standard fuel tank capacity.
            int totalGrams = 80400;     // Total weight of fuel in the tank.
            int gramsRemain = 80400;    // Default weight of fuel remaining in the tank.
            int countRechargeRefuel = 0;

            decimal yNite;
            decimal ySunHrs;
            string inputLine = "";
            string eDemand = chart1.Series[0].Name;
            string eSupply = chart1.Series[1].Name;
            string batCharge = chart1.Series[2].Name;
            string[] columns;
            string rawDataFile = "";

            decimal runHrs;
            decimal ampHours = 630.01m, ampBattCapa, wattBattCapa, lightWHrs, panelWHrs;

            /* ++++++++++++++  Open up the file in this section. +++++++++++++ */
            rawDataFile = openFileDialog1.FileName;         // Get the file name that was selected by user.
            StreamReader nightHours;

            try
            {
                 nightHours = new StreamReader(
                              new   FileStream(@rawDataFile, FileMode.Open, FileAccess.Read));
                fileName.Text = openFileDialog1.SafeFileName;        // Display the raw data file name.
            }
            catch (FileNotFoundException)
            {
                fileName.Text = "92833 Fullerton.txt";        // Display the raw data file name.
                rawDataFile = "sunRiseSet\\92833 Fullerton.txt";
                    nightHours = new StreamReader(
                                 new   FileStream(@rawDataFile, FileMode.Open, FileAccess.Read));
            }

            /* --------------------------------------------------------------- */
            
            inputLine = nightHours.ReadLine();      /* first two lines of the file are not usable. */
            inputLine = nightHours.ReadLine();


            //textBox1.Text = inputLine;
            //textBox1.Text = columns[7];



            chart1.Series[eDemand].Points.Clear();
            chart1.Series[eSupply].Points.Clear();
            chart1.Series[batCharge].Points.Clear();

            /* Read the file and shift data 11 days to Dec 21. */
            for (int xDay = 0; xDay < daysYear; ++xDay)
            {
                inputLine = nightHours.ReadLine();
                inputLine = inputLine.Trim();
                columns = inputLine.Split('\t');
                yNite = System.Convert.ToDecimal(columns[7]);
                ySunHrs = System.Convert.ToDecimal(columns[8]);

                //chart1.Series["Series1"].Points.AddXY(xDay, yNite);
                if (xDay < (daysYear-daysShift))
                {
                    valNite[xDay + daysShift] = yNite;
                    //valSunHrs[xDay + daysShift] = ySunHrs;
                    valSunHrs[xDay] = ySunHrs;
                }
                else
                {
                    valNite[xDay - (daysYear-daysShift)] = yNite;
                    //valSunHrs[xDay - (daysYear - daysShift)] = ySunHrs;
                    valSunHrs[xDay] = ySunHrs;
                };
            }

            /* +++++++++  Select Lamp Wattage. ++++++++++ */
            lampWatts = 250;    // if for some reason no buttons are checked then default to 1000W.
            if (radBtn300.Checked == true) lampWatts = 300;
            if (radBtn160.Checked == true) lampWatts = 160;
            if (radBtn80.Checked == true) lampWatts = 80;
            if(radBtnOther.Checked == true)
            {
                if ( int.TryParse(textBox1.Text, out lampWatts) == true)
                {
                    // Input is in correct format
                    lampWatts = Convert.ToInt32(textBox1.Text);
                    if(lampWatts > 500)
                    {
                        MessageBox.Show("MAXIMUM LAMP WATTAGE: 500Watts");
                        textBox1.Text = "500";
                    }
                    if(lampWatts < 25)
                    {
                        MessageBox.Show("MINIMUM LAMP WATTAGE: 25Watts");
                        textBox1.Text = "25";
                    }
                }
                else
                {
                    // throw an exception
                    //throw new Exception("INCORRECT wattage value");
                    MessageBox.Show("INCORRECT WATTAGE FORMAT\n\nEnter a NUMBER!");
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
            }

            /* +++++++++++++  Select brightness mode, dimming factor. ++++++++++++ */
            if (radBtnBright.Checked == true) brightness = 100;
            if (radBtnNormal.Checked == true) brightness = 67;
            if (radBtnDim.Checked == true) brightness = 33;

            /* +++++++++++++++  Select the quantity of lamps. +++++++++++++++ */
            lampQty = 4;
            if (radBtn4Lamps.Checked == true) lampQty = 4;
            if (radBtn3Lamps.Checked == true) lampQty = 3;
            if (radBtn2Lamps.Checked == true) lampQty = 2;
            if (radBtnXLamps.Checked == true) lampQty = 1;
            if (radBtnXLamps.Checked == true)
            {
                if (int.TryParse(textBox2.Text, out lampQty) == true)
                {
                    // Input is in correct format
                    lampQty = Convert.ToInt32(textBox2.Text);
                    if (lampQty > 10)
                    {
                        MessageBox.Show("MAXIMUM NUMBER OF LAMPS: 10");
                        textBox2.Text = "10";
                    }
                    if (lampQty < 1)
                    {
                        MessageBox.Show("MINIMUM NUMBER OF LAMPS: 1");
                        textBox2.Text = "1";
                    }

                }
                else
                {
                    // thow an exception
                    //throw new Exception("INCORRECT wattage value");
                    MessageBox.Show("INCORRECT QUANTITY OF LAMPS FORMAT\n\nEnter a NUMBER!");
                    textBox2.Focus();
                    textBox2.SelectAll();
                }
            }

            /* ++++++++++++++++  Select the quantity of panels. +++++++++++++++++ */
            panelQty = 3;
            if (radBtn4Panels.Checked == true) panelQty = 4;
            if (radBtn3Panels.Checked == true) panelQty = 3;
            if (radBtn2Panels.Checked == true) panelQty = 2;
            if (radBtn1Panels.Checked == true) panelQty = 1;
            if (radBtnXPanels.Checked == true) panelQty = 1;
            if (radBtnXPanels.Checked == true)
            {
                if (int.TryParse(textBox4.Text, out panelQty) == true)
                {
                    // Input is in correct format
                    panelQty = Convert.ToInt32(textBox4.Text);
                    if (panelQty > 12)
                    {
                        MessageBox.Show("MAXIMUM NUMBER OF PANELS: 12");
                        textBox4.Text = "12";
                    }
                    if (panelQty < 1)
                    {
                        MessageBox.Show("MINIMUM NUMBER OF PANELS: 1");
                        textBox4.Text = "1";
                    }

                }
                else
                {
                    // throw an exception
                    //throw new Exception("INCORRECT panel qty value");
                    MessageBox.Show("INCORRECT QUANTITY OF PANELS FORMAT\n\nEnter a NUMBER!");
                    textBox4.Focus();
                    textBox4.SelectAll();
                }
            }

            /* ++++++++++  Determine how many days per week the tower is on. ++++++++ */
            daysPerWeek = 0;
            if (chkMon.Checked == true) ++daysPerWeek;
            if (chkTue.Checked == true) ++daysPerWeek;
            if (chkWed.Checked == true) ++daysPerWeek;
            if (chkThu.Checked == true) ++daysPerWeek;
            if (chkFri.Checked == true) ++daysPerWeek;
            if (chkSat.Checked == true) ++daysPerWeek;
            if (chkSun.Checked == true) ++daysPerWeek;

            /* Calculate starting Amp-Hrs, and other battery variables  */
            ampHours = 630m;
            if (radBtn12Batt.Checked == true) ampHours = 630;
            if (radBtn10Batt.Checked == true) ampHours = 525;
            if (radBtn8Batt.Checked == true) ampHours = 420;
            if (radBtnBattOther.Checked == true)
            {
                //ampHours = 630;
                batteryQty = 12;
                if (int.TryParse(textBox3.Text, out batteryQty) == true)
                {
                    // Input is in correct format
                    batteryQty = Convert.ToInt32(textBox3.Text);
                    if (batteryQty > 24)
                    {
                        MessageBox.Show("MAXIMUM NUMBER OF BATTERIES: 24");
                        textBox3.Text = "24";
                        batteryQty = 24;
                    }
                    if (batteryQty < 2)
                    {
                        MessageBox.Show("MINIMUM NUMBER OF BATTERIES: 2");
                        textBox3.Text = "2";
                        batteryQty = 2;
                    }

                    batteryQty /= 2;
                    ampHours = 105 * batteryQty;
                }
                else
                {
                    // throw an exception
                    //throw new Exception("INCORRECT number of batteries value");
                    MessageBox.Show("INCORRECT BATTERY FORMAT\n\nEnter a NUMBER!");
                    textBox3.Focus();
                    textBox3.SelectAll();
                }
            }

            ampBattCapa = ampHours;
            wattBattCapa = 24 * ampHours;   // This is battery capacity in Watt_Hours

            /* ++++++++++  Check for Solar or Hybrid Light Tower. ++++++++ */
            if(chkHybridLTyes.Checked == true)
            {
                // Select fuel capacity.
                if (radBtn24Gal.Checked == true) fuelGallons = 24;  // Fuel capacity is 24 gallons.
                if(radBtnFuelOther.Checked == true)
                {
                    if (int.TryParse(textBox6.Text, out fuelGallons) == true)
                    {
                        // input is in correct format
                        fuelGallons = Convert.ToInt32(textBox6.Text);
                        if(fuelGallons > 75)
                        {
                            MessageBox.Show("MAXIMUM FUEL TANK CAPACITY: 75 GALLONS");
                            textBox6.Text = "75";
                            fuelGallons = 75;
                        }

                        if (fuelGallons < 5)
                        {
                            MessageBox.Show("MINIMUM FUEL TANK CAPACITY: 5 GALLONS");
                            textBox6.Text = "5";
                            fuelGallons = 5;
                        }

                    }
                    else
                    {
                        // throw an exception
                        //throw new Exception("INCORRECT Fuel Ammount");
                        MessageBox.Show("INCORRECT FUEL AMOUNT\n\nEnter a NUMBER!");
                        textBox6.Focus();
                        textBox6.SelectAll();
                    }
                }

                totalGrams = weight1Gallon * fuelGallons;
                gramsRemain = totalGrams;

                gramsKWh = 506;       // Default value for grams of Diesel per kilowatt hour.

                if (radBtn506gKWh.Checked == true) gramsKWh = 506;  // Conversion rate is 506 grams per KWh

                if(radBtngKWhOther.Checked == true)
                {
                    if (int.TryParse(textBox5.Text,out gramsKWh) == true)
                    {
                        // Input is in correct format
                        gramsKWh = Convert.ToInt32(textBox5.Text);
                        if(gramsKWh > 2000)
                        {
                            MessageBox.Show("Maximum Conversion Rate is: 2000");
                            textBox5.Text = "2000";
                            gramsKWh = 2000;
                        }
                        if(gramsKWh < 100)
                        {
                            MessageBox.Show("Minimum Conversion Rate is: 100");
                            textBox5.Text = "100";
                            gramsKWh = 100;
                        }
                    }
                    else
                    {
                        // throw an exception
                        //throw new Exception("INCORRECT Conversion Rate");
                        MessageBox.Show("INCORRECT CONVERSION RATE\n\nEnter a NUMBER!");
                        textBox5.Focus();
                        textBox5.SelectAll();
                    }
                }
            }


            /* ++++++++++++++++++++++  Beggin plotting data. ++++++++++++++++++++ */

            yAxisDynamic = 10500;   // reset y-axis for next time.
            countRechargeRefuel = 1;    // Reset recharge or refuel counter, start with 1.

            /* Plot shifted data. */
            for (int xDay = 0; xDay < daysYear; ++xDay)
            {
                // Determine the number of run hours per night.
                runHrs = valNite[xDay];

                if (radBtnDDhrs.Checked == true)
                {
                    runHrs = valNite[xDay];
                }

                if (radBtn12hrs.Checked == true)
                {
                    if (valNite[xDay] > 12) runHrs = 12;
                    else runHrs = valNite[xDay];
                }

                if (radBtn9hrs.Checked == true)
                {
                    if (valNite[xDay] > 9) runHrs = 9;
                    else runHrs = valNite[xDay];
                }

                if (radBtn6hrs.Checked == true)
                {
                    if (valNite[xDay] > 6) runHrs = 6;
                    else runHrs = valNite[xDay];
                }

                if (radBtn3hrs.Checked == true)
                {
                    if (valNite[xDay] > 3) runHrs = 3;
                    else runHrs = valNite[xDay];
                }

                if ( chkHybridLTyes.Checked == false)
                {
                    panelWatts = 250;   // This is the original 250 panel for Solar LT.
                }
                else
                {
                    panelWatts = 192;   // This is used for the Hybrid LT.
                }

                lightWHrs = (lampWatts * lampQty * brightness * runHrs * daysPerWeek * 95 / (10000 * 7));
                panelWHrs = panelWatts * panelQty * valSunHrs[xDay];

                chart1.Series[eDemand].Points.AddXY(xDay, lightWHrs);
                chart1.Series[eSupply].Points.AddXY(xDay, panelWHrs);

                /* change the graph y-axis scale. */
                if (lightWHrs > yAxisDynamic) yAxisDynamic = (int) lightWHrs;
                if (panelWHrs > yAxisDynamic) yAxisDynamic = (int) panelWHrs;


                if(lightWHrs > panelWHrs)
                {
                    /* Negative energy production. */
                    wattBattCapa -= (lightWHrs - panelWHrs);
                    if(wattBattCapa < 0)
                    {   // time to recharge
                        if(chkHybridLTyes.Checked == false)
                        {
                            // Time to recharge. Solar Light Tower
                            ++countRechargeRefuel;              // Increment recharge count
                            wattBattCapa = 24 * ampHours;      // Recalculate wattBattCapa
                            // mark the recharch point on the graph
                            chart1.Series[batCharge].Points.AddXY(xDay - 1, lightWHrs);
                        }
                        else
                        {
                            // Determine if engine needs to run.
                            wattBattCapa = 24 * ampHours - wattBattCapa;

                            gramsNeeded = ( (int) wattBattCapa * gramsKWh)/1000  + 1;

                            wattBattCapa = 24 * ampHours;

                            if (gramsNeeded > gramsRemain)
                            {
                                // Refuel in here
                                ++countRechargeRefuel;              // Increment refuel count
                                gramsRemain = totalGrams - gramsNeeded;
                                // mark the refuel point on the graph
                                chart1.Series[batCharge].Points.AddXY(xDay - 1, lightWHrs);
                            }
                            else
                            {
                                // No refueling needed
                                gramsRemain -= gramsNeeded;
                            }

                        }
                    }
                }
                else
                {
                    /* Positive energy production. */
                    if (wattBattCapa < 24 * ampHours)
                    {
                        wattBattCapa += (panelWHrs - lightWHrs);
                        //if (wattBattCapa > 630) wattBattCapa = 630;
                    }
                    else
                    {
                        wattBattCapa = 24 * ampHours;
                    }
                }

            }  // End of 365 days loop 


            if (chkHybridLTyes.Checked == true)
            {
                chart1.Series[2].LegendText = "Refuelings: " + countRechargeRefuel;
            }
            else
            {
                chart1.Series[2].LegendText = "Battery Charges: " + countRechargeRefuel;
            }


            //chart1.Series[batCharge].Points.AddXY(45, 16500);
            //chart1.Series[batCharge].Points[0].Color = Color.Red;
            //chart1.Series[batCharge].Points.AddXY(45, 16500);
            //chart1.Series[batCharge].Points.AddXY(90, 16500);
            //chart1.Series[batCharge].Points.AddXY(135, 16500);
            //chart1.Series[batCharge].Points.AddXY(180, 16500);
            //chart1.Series[batCharge].Points.AddXY(225, 16500);
            //chart1.Series[batCharge].Points.AddXY(270, 16500);
            //chart1.Series[batCharge].Points.AddXY(315, 16500);
            //chart1.Series[batCharge].Points.AddXY(360, 16500);

            nightHours.Close();

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            radBtnOther.Checked = true;
            textBox1.SelectAll();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // MessageBox.Show("THE ENTER KEY HAS BEEN PRESS!");
                numberCruncher();
                textBox1.SelectAll();
            }
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            radBtnXLamps.Checked = true;
            textBox2.SelectAll();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // MessageBox.Show("THE ENTER KEY HAS BEEN PRESS!");
                numberCruncher();
                textBox2.SelectAll();
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            radBtnBattOther.Checked = true;
            textBox3.SelectAll();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // MessageBox.Show("THE ENTER KEY HAS BEEN PRESS!");
                numberCruncher();
                textBox3.SelectAll();
            }
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            radBtnXPanels.Checked = true;
            textBox4.SelectAll();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // MessageBox.Show("THE ENTER KEY HAS BEEN PRESS!");
                numberCruncher();
                textBox4.SelectAll();
            }
        }


        private void lampWatt_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void lampDimm_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void lampQty_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void panelQty4_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }
        private void panelQty3_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }
        private void panelQty2_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void panelQty1_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void onMode3hr_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void onMode6hr_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void onMode9hr_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }
        private void onMode12hr_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }
        private void onModeDDhr_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }
        private void daysUpdate_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }


        private void radBtn12Batt_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void radBtn10Batt_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void radBtn8Batt_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string whatisDirectory = Directory.GetCurrentDirectory();       // Get the current path.
            whatisDirectory += "\\sunRiseSet";                // Drill down to folder with raw data

            openFileDialog1.InitialDirectory = whatisDirectory;      // Set initial folder for dialog box
            //openFileDialog1.DefaultExt = ".txt"; // Default file extension
            //openFileDialog1.Filter = "Text documents (.txt)|*.txt"; // Filter files by extension
            openFileDialog1.ShowDialog();

            numberCruncher();

        }

        private void chkHybridLTyes_MouseClick(object sender, MouseEventArgs e)
        {
            numberCruncher();
        }

        private void radBtn506gKWh_MouseClick(object sender, MouseEventArgs e)
        {
            chkHybridLTyes.Checked = true;
            numberCruncher();
        }

        private void radBtn24Gal_MouseClick(object sender, MouseEventArgs e)
        {
            chkHybridLTyes.Checked = true;
            numberCruncher();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            chkHybridLTyes.Checked = true;
            radBtngKWhOther.Checked = true;
            textBox5.SelectAll();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // MessageBox.Show("THE ENTER KEY HAS BEEN PRESS!");
                numberCruncher();
                textBox5.SelectAll();
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            chkHybridLTyes.Checked = true;
            radBtnFuelOther.Checked = true;
            textBox6.SelectAll();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // MessageBox.Show("THE ENTER KEY HAS BEEN PRESS!");
                numberCruncher();
                textBox6.SelectAll();
            }
        }
    }
}
