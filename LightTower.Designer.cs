namespace SolarChart
{
    partial class EnergyChart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint15 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(100D, 100D);
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint16 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, "0,0,0,0");
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.LoadChart = new System.Windows.Forms.Button();
            this.lampWatts = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radBtnOther = new System.Windows.Forms.RadioButton();
            this.radBtn80 = new System.Windows.Forms.RadioButton();
            this.radBtn160 = new System.Windows.Forms.RadioButton();
            this.radBtn300 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBtnDim = new System.Windows.Forms.RadioButton();
            this.radBtnNormal = new System.Windows.Forms.RadioButton();
            this.radBtnBright = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.radBtnXLamps = new System.Windows.Forms.RadioButton();
            this.radBtn2Lamps = new System.Windows.Forms.RadioButton();
            this.radBtn3Lamps = new System.Windows.Forms.RadioButton();
            this.radBtn4Lamps = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.radBtnXPanels = new System.Windows.Forms.RadioButton();
            this.radBtn1Panels = new System.Windows.Forms.RadioButton();
            this.radBtn2Panels = new System.Windows.Forms.RadioButton();
            this.radBtn3Panels = new System.Windows.Forms.RadioButton();
            this.radBtn4Panels = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radBtnDDhrs = new System.Windows.Forms.RadioButton();
            this.radBtn12hrs = new System.Windows.Forms.RadioButton();
            this.radBtn9hrs = new System.Windows.Forms.RadioButton();
            this.radBtn6hrs = new System.Windows.Forms.RadioButton();
            this.radBtn3hrs = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkSun = new System.Windows.Forms.CheckBox();
            this.chkSat = new System.Windows.Forms.CheckBox();
            this.chkFri = new System.Windows.Forms.CheckBox();
            this.chkThu = new System.Windows.Forms.CheckBox();
            this.chkWed = new System.Windows.Forms.CheckBox();
            this.chkTue = new System.Windows.Forms.CheckBox();
            this.chkMon = new System.Windows.Forms.CheckBox();
            this.qtyBatt = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.radBtnBattOther = new System.Windows.Forms.RadioButton();
            this.radBtn8Batt = new System.Windows.Forms.RadioButton();
            this.radBtn10Batt = new System.Windows.Forms.RadioButton();
            this.radBtn12Batt = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fileName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hybridLT = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.radBtnFuelOther = new System.Windows.Forms.RadioButton();
            this.radBtn24Gal = new System.Windows.Forms.RadioButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.radBtngKWhOther = new System.Windows.Forms.RadioButton();
            this.radBtn506gKWh = new System.Windows.Forms.RadioButton();
            this.chkHybridLTyes = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.lampWatts.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.qtyBatt.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.hybridLT.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            chartArea8.BackColor = System.Drawing.Color.Black;
            chartArea8.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            chartArea8.BackSecondaryColor = System.Drawing.Color.Silver;
            chartArea8.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea8);
            legend8.Alignment = System.Drawing.StringAlignment.Center;
            legend8.BackColor = System.Drawing.Color.Silver;
            legend8.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend8.IsTextAutoFit = false;
            legend8.Name = "Legend1";
            this.chart1.Legends.Add(legend8);
            this.chart1.Location = new System.Drawing.Point(200, 140);
            this.chart1.Name = "chart1";
            series22.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.TopRight;
            series22.BorderWidth = 3;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series22.Color = System.Drawing.Color.White;
            series22.LabelBackColor = System.Drawing.Color.White;
            series22.Legend = "Legend1";
            series22.Name = "Energy Demand";
            dataPoint15.BorderWidth = 10;
            dataPoint15.LabelBackColor = System.Drawing.Color.White;
            series22.Points.Add(dataPoint15);
            series23.BorderWidth = 3;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series23.Legend = "Legend1";
            series23.Name = "Energy Supply";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series24.Color = System.Drawing.Color.Red;
            series24.Legend = "Legend1";
            series24.MarkerColor = System.Drawing.Color.Red;
            series24.MarkerSize = 2;
            series24.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle;
            series24.Name = "Battery Charge";
            series24.Points.Add(dataPoint16);
            series24.YValuesPerPoint = 4;
            this.chart1.Series.Add(series22);
            this.chart1.Series.Add(series23);
            this.chart1.Series.Add(series24);
            this.chart1.Size = new System.Drawing.Size(1052, 586);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // LoadChart
            // 
            this.LoadChart.Location = new System.Drawing.Point(40, 695);
            this.LoadChart.Name = "LoadChart";
            this.LoadChart.Size = new System.Drawing.Size(75, 25);
            this.LoadChart.TabIndex = 1;
            this.LoadChart.Text = "LoadChart";
            this.LoadChart.UseVisualStyleBackColor = true;
            this.LoadChart.Click += new System.EventHandler(this.LoadChart_Click);
            // 
            // lampWatts
            // 
            this.lampWatts.BackColor = System.Drawing.SystemColors.Control;
            this.lampWatts.Controls.Add(this.textBox1);
            this.lampWatts.Controls.Add(this.radBtnOther);
            this.lampWatts.Controls.Add(this.radBtn80);
            this.lampWatts.Controls.Add(this.radBtn160);
            this.lampWatts.Controls.Add(this.radBtn300);
            this.lampWatts.Location = new System.Drawing.Point(40, 40);
            this.lampWatts.Name = "lampWatts";
            this.lampWatts.Size = new System.Drawing.Size(130, 120);
            this.lampWatts.TabIndex = 2;
            this.lampWatts.TabStop = false;
            this.lampWatts.Text = "Lamp Wattage";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // radBtnOther
            // 
            this.radBtnOther.AutoSize = true;
            this.radBtnOther.Location = new System.Drawing.Point(10, 74);
            this.radBtnOther.Name = "radBtnOther";
            this.radBtnOther.Size = new System.Drawing.Size(51, 17);
            this.radBtnOther.TabIndex = 3;
            this.radBtnOther.Text = "Other";
            this.radBtnOther.UseVisualStyleBackColor = true;
            // 
            // radBtn80
            // 
            this.radBtn80.AutoSize = true;
            this.radBtn80.Location = new System.Drawing.Point(10, 56);
            this.radBtn80.Name = "radBtn80";
            this.radBtn80.Size = new System.Drawing.Size(68, 17);
            this.radBtn80.TabIndex = 2;
            this.radBtn80.Text = "80 Watts";
            this.radBtn80.UseVisualStyleBackColor = true;
            this.radBtn80.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lampWatt_MouseClick);
            // 
            // radBtn160
            // 
            this.radBtn160.AutoSize = true;
            this.radBtn160.Checked = true;
            this.radBtn160.Location = new System.Drawing.Point(10, 38);
            this.radBtn160.Name = "radBtn160";
            this.radBtn160.Size = new System.Drawing.Size(74, 17);
            this.radBtn160.TabIndex = 1;
            this.radBtn160.TabStop = true;
            this.radBtn160.Text = "160 Watts";
            this.radBtn160.UseVisualStyleBackColor = true;
            this.radBtn160.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lampWatt_MouseClick);
            // 
            // radBtn300
            // 
            this.radBtn300.AutoSize = true;
            this.radBtn300.Location = new System.Drawing.Point(10, 20);
            this.radBtn300.Name = "radBtn300";
            this.radBtn300.Size = new System.Drawing.Size(74, 17);
            this.radBtn300.TabIndex = 0;
            this.radBtn300.Text = "300 Watts";
            this.radBtn300.UseVisualStyleBackColor = true;
            this.radBtn300.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lampWatt_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBtnDim);
            this.groupBox1.Controls.Add(this.radBtnNormal);
            this.groupBox1.Controls.Add(this.radBtnBright);
            this.groupBox1.Location = new System.Drawing.Point(40, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dimming";
            // 
            // radBtnDim
            // 
            this.radBtnDim.AutoSize = true;
            this.radBtnDim.Location = new System.Drawing.Point(10, 56);
            this.radBtnDim.Name = "radBtnDim";
            this.radBtnDim.Size = new System.Drawing.Size(43, 17);
            this.radBtnDim.TabIndex = 2;
            this.radBtnDim.Text = "Dim";
            this.radBtnDim.UseVisualStyleBackColor = true;
            this.radBtnDim.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lampDimm_MouseClick);
            // 
            // radBtnNormal
            // 
            this.radBtnNormal.AutoSize = true;
            this.radBtnNormal.Location = new System.Drawing.Point(10, 38);
            this.radBtnNormal.Name = "radBtnNormal";
            this.radBtnNormal.Size = new System.Drawing.Size(58, 17);
            this.radBtnNormal.TabIndex = 1;
            this.radBtnNormal.Text = "Normal";
            this.radBtnNormal.UseVisualStyleBackColor = true;
            this.radBtnNormal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lampDimm_MouseClick);
            // 
            // radBtnBright
            // 
            this.radBtnBright.AutoSize = true;
            this.radBtnBright.Checked = true;
            this.radBtnBright.Location = new System.Drawing.Point(10, 20);
            this.radBtnBright.Name = "radBtnBright";
            this.radBtnBright.Size = new System.Drawing.Size(52, 17);
            this.radBtnBright.TabIndex = 0;
            this.radBtnBright.TabStop = true;
            this.radBtnBright.Text = "Bright";
            this.radBtnBright.UseVisualStyleBackColor = true;
            this.radBtnBright.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lampDimm_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.radBtnXLamps);
            this.groupBox2.Controls.Add(this.radBtn2Lamps);
            this.groupBox2.Controls.Add(this.radBtn3Lamps);
            this.groupBox2.Controls.Add(this.radBtn4Lamps);
            this.groupBox2.Location = new System.Drawing.Point(40, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(130, 120);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Qty of lamps";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(10, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // radBtnXLamps
            // 
            this.radBtnXLamps.AutoSize = true;
            this.radBtnXLamps.Location = new System.Drawing.Point(10, 74);
            this.radBtnXLamps.Name = "radBtnXLamps";
            this.radBtnXLamps.Size = new System.Drawing.Size(51, 17);
            this.radBtnXLamps.TabIndex = 3;
            this.radBtnXLamps.Text = "Other";
            this.radBtnXLamps.UseVisualStyleBackColor = true;
            // 
            // radBtn2Lamps
            // 
            this.radBtn2Lamps.AutoSize = true;
            this.radBtn2Lamps.Location = new System.Drawing.Point(10, 56);
            this.radBtn2Lamps.Name = "radBtn2Lamps";
            this.radBtn2Lamps.Size = new System.Drawing.Size(65, 17);
            this.radBtn2Lamps.TabIndex = 2;
            this.radBtn2Lamps.Text = "2 Lamps";
            this.radBtn2Lamps.UseVisualStyleBackColor = true;
            this.radBtn2Lamps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lampQty_MouseClick);
            // 
            // radBtn3Lamps
            // 
            this.radBtn3Lamps.AutoSize = true;
            this.radBtn3Lamps.Location = new System.Drawing.Point(10, 38);
            this.radBtn3Lamps.Name = "radBtn3Lamps";
            this.radBtn3Lamps.Size = new System.Drawing.Size(65, 17);
            this.radBtn3Lamps.TabIndex = 1;
            this.radBtn3Lamps.Text = "3 Lamps";
            this.radBtn3Lamps.UseVisualStyleBackColor = true;
            this.radBtn3Lamps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lampQty_MouseClick);
            // 
            // radBtn4Lamps
            // 
            this.radBtn4Lamps.AutoSize = true;
            this.radBtn4Lamps.Checked = true;
            this.radBtn4Lamps.Location = new System.Drawing.Point(10, 20);
            this.radBtn4Lamps.Name = "radBtn4Lamps";
            this.radBtn4Lamps.Size = new System.Drawing.Size(65, 17);
            this.radBtn4Lamps.TabIndex = 0;
            this.radBtn4Lamps.TabStop = true;
            this.radBtn4Lamps.Text = "4 Lamps";
            this.radBtn4Lamps.UseVisualStyleBackColor = true;
            this.radBtn4Lamps.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lampQty_MouseClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox4);
            this.groupBox3.Controls.Add(this.radBtnXPanels);
            this.groupBox3.Controls.Add(this.radBtn1Panels);
            this.groupBox3.Controls.Add(this.radBtn2Panels);
            this.groupBox3.Controls.Add(this.radBtn3Panels);
            this.groupBox3.Controls.Add(this.radBtn4Panels);
            this.groupBox3.Location = new System.Drawing.Point(40, 407);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(130, 138);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Qty of Solar Panels";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(10, 110);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 5;
            this.textBox4.Click += new System.EventHandler(this.textBox4_Click);
            this.textBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox4_KeyPress);
            // 
            // radBtnXPanels
            // 
            this.radBtnXPanels.AutoSize = true;
            this.radBtnXPanels.Location = new System.Drawing.Point(10, 92);
            this.radBtnXPanels.Name = "radBtnXPanels";
            this.radBtnXPanels.Size = new System.Drawing.Size(51, 17);
            this.radBtnXPanels.TabIndex = 4;
            this.radBtnXPanels.TabStop = true;
            this.radBtnXPanels.Text = "Other";
            this.radBtnXPanels.UseVisualStyleBackColor = true;
            // 
            // radBtn1Panels
            // 
            this.radBtn1Panels.AutoSize = true;
            this.radBtn1Panels.Location = new System.Drawing.Point(10, 74);
            this.radBtn1Panels.Name = "radBtn1Panels";
            this.radBtn1Panels.Size = new System.Drawing.Size(60, 17);
            this.radBtn1Panels.TabIndex = 3;
            this.radBtn1Panels.TabStop = true;
            this.radBtn1Panels.Text = "1 panel";
            this.radBtn1Panels.UseVisualStyleBackColor = true;
            this.radBtn1Panels.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelQty1_MouseClick);
            // 
            // radBtn2Panels
            // 
            this.radBtn2Panels.AutoSize = true;
            this.radBtn2Panels.Location = new System.Drawing.Point(10, 56);
            this.radBtn2Panels.Name = "radBtn2Panels";
            this.radBtn2Panels.Size = new System.Drawing.Size(65, 17);
            this.radBtn2Panels.TabIndex = 2;
            this.radBtn2Panels.Text = "2 panels";
            this.radBtn2Panels.UseVisualStyleBackColor = true;
            this.radBtn2Panels.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelQty2_MouseClick);
            // 
            // radBtn3Panels
            // 
            this.radBtn3Panels.AutoSize = true;
            this.radBtn3Panels.Checked = true;
            this.radBtn3Panels.Location = new System.Drawing.Point(10, 38);
            this.radBtn3Panels.Name = "radBtn3Panels";
            this.radBtn3Panels.Size = new System.Drawing.Size(65, 17);
            this.radBtn3Panels.TabIndex = 1;
            this.radBtn3Panels.TabStop = true;
            this.radBtn3Panels.Text = "3 panels";
            this.radBtn3Panels.UseVisualStyleBackColor = true;
            this.radBtn3Panels.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelQty3_MouseClick);
            // 
            // radBtn4Panels
            // 
            this.radBtn4Panels.AutoSize = true;
            this.radBtn4Panels.Location = new System.Drawing.Point(10, 20);
            this.radBtn4Panels.Name = "radBtn4Panels";
            this.radBtn4Panels.Size = new System.Drawing.Size(65, 17);
            this.radBtn4Panels.TabIndex = 0;
            this.radBtn4Panels.Text = "4 panels";
            this.radBtn4Panels.UseVisualStyleBackColor = true;
            this.radBtn4Panels.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelQty4_MouseClick);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radBtnDDhrs);
            this.groupBox4.Controls.Add(this.radBtn12hrs);
            this.groupBox4.Controls.Add(this.radBtn9hrs);
            this.groupBox4.Controls.Add(this.radBtn6hrs);
            this.groupBox4.Controls.Add(this.radBtn3hrs);
            this.groupBox4.Location = new System.Drawing.Point(40, 557);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 120);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "ON Mode";
            // 
            // radBtnDDhrs
            // 
            this.radBtnDDhrs.AutoSize = true;
            this.radBtnDDhrs.Checked = true;
            this.radBtnDDhrs.Location = new System.Drawing.Point(10, 92);
            this.radBtnDDhrs.Name = "radBtnDDhrs";
            this.radBtnDDhrs.Size = new System.Drawing.Size(81, 17);
            this.radBtnDDhrs.TabIndex = 4;
            this.radBtnDDhrs.TabStop = true;
            this.radBtnDDhrs.Text = "Dusk-Dawn";
            this.radBtnDDhrs.UseVisualStyleBackColor = true;
            this.radBtnDDhrs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onModeDDhr_MouseClick);
            // 
            // radBtn12hrs
            // 
            this.radBtn12hrs.AutoSize = true;
            this.radBtn12hrs.Location = new System.Drawing.Point(10, 74);
            this.radBtn12hrs.Name = "radBtn12hrs";
            this.radBtn12hrs.Size = new System.Drawing.Size(54, 17);
            this.radBtn12hrs.TabIndex = 3;
            this.radBtn12hrs.Text = "12 hrs";
            this.radBtn12hrs.UseVisualStyleBackColor = true;
            this.radBtn12hrs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMode12hr_MouseClick);
            // 
            // radBtn9hrs
            // 
            this.radBtn9hrs.AutoSize = true;
            this.radBtn9hrs.Location = new System.Drawing.Point(10, 56);
            this.radBtn9hrs.Name = "radBtn9hrs";
            this.radBtn9hrs.Size = new System.Drawing.Size(48, 17);
            this.radBtn9hrs.TabIndex = 2;
            this.radBtn9hrs.Text = "9 hrs";
            this.radBtn9hrs.UseVisualStyleBackColor = true;
            this.radBtn9hrs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMode9hr_MouseClick);
            // 
            // radBtn6hrs
            // 
            this.radBtn6hrs.AutoSize = true;
            this.radBtn6hrs.Location = new System.Drawing.Point(10, 38);
            this.radBtn6hrs.Name = "radBtn6hrs";
            this.radBtn6hrs.Size = new System.Drawing.Size(48, 17);
            this.radBtn6hrs.TabIndex = 1;
            this.radBtn6hrs.Text = "6 hrs";
            this.radBtn6hrs.UseVisualStyleBackColor = true;
            this.radBtn6hrs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMode6hr_MouseClick);
            // 
            // radBtn3hrs
            // 
            this.radBtn3hrs.AutoSize = true;
            this.radBtn3hrs.Location = new System.Drawing.Point(10, 20);
            this.radBtn3hrs.Name = "radBtn3hrs";
            this.radBtn3hrs.Size = new System.Drawing.Size(48, 17);
            this.radBtn3hrs.TabIndex = 0;
            this.radBtn3hrs.Text = "3 hrs";
            this.radBtn3hrs.UseVisualStyleBackColor = true;
            this.radBtn3hrs.MouseClick += new System.Windows.Forms.MouseEventHandler(this.onMode3hr_MouseClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkSun);
            this.groupBox5.Controls.Add(this.chkSat);
            this.groupBox5.Controls.Add(this.chkFri);
            this.groupBox5.Controls.Add(this.chkThu);
            this.groupBox5.Controls.Add(this.chkWed);
            this.groupBox5.Controls.Add(this.chkTue);
            this.groupBox5.Controls.Add(this.chkMon);
            this.groupBox5.Location = new System.Drawing.Point(867, 40);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(351, 84);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Day of Week";
            // 
            // chkSun
            // 
            this.chkSun.AutoSize = true;
            this.chkSun.Checked = true;
            this.chkSun.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSun.Location = new System.Drawing.Point(304, 40);
            this.chkSun.Name = "chkSun";
            this.chkSun.Size = new System.Drawing.Size(45, 17);
            this.chkSun.TabIndex = 13;
            this.chkSun.Text = "Sun";
            this.chkSun.UseVisualStyleBackColor = true;
            this.chkSun.MouseClick += new System.Windows.Forms.MouseEventHandler(this.daysUpdate_MouseClick);
            // 
            // chkSat
            // 
            this.chkSat.AutoSize = true;
            this.chkSat.Checked = true;
            this.chkSat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSat.Location = new System.Drawing.Point(257, 40);
            this.chkSat.Name = "chkSat";
            this.chkSat.Size = new System.Drawing.Size(42, 17);
            this.chkSat.TabIndex = 12;
            this.chkSat.Text = "Sat";
            this.chkSat.UseVisualStyleBackColor = true;
            this.chkSat.MouseClick += new System.Windows.Forms.MouseEventHandler(this.daysUpdate_MouseClick);
            // 
            // chkFri
            // 
            this.chkFri.AutoSize = true;
            this.chkFri.Checked = true;
            this.chkFri.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFri.Location = new System.Drawing.Point(216, 40);
            this.chkFri.Name = "chkFri";
            this.chkFri.Size = new System.Drawing.Size(37, 17);
            this.chkFri.TabIndex = 11;
            this.chkFri.Text = "Fri";
            this.chkFri.UseVisualStyleBackColor = true;
            this.chkFri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.daysUpdate_MouseClick);
            // 
            // chkThu
            // 
            this.chkThu.AutoSize = true;
            this.chkThu.Checked = true;
            this.chkThu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkThu.Location = new System.Drawing.Point(166, 40);
            this.chkThu.Name = "chkThu";
            this.chkThu.Size = new System.Drawing.Size(45, 17);
            this.chkThu.TabIndex = 10;
            this.chkThu.Text = "Thu";
            this.chkThu.UseVisualStyleBackColor = true;
            this.chkThu.MouseClick += new System.Windows.Forms.MouseEventHandler(this.daysUpdate_MouseClick);
            // 
            // chkWed
            // 
            this.chkWed.AutoSize = true;
            this.chkWed.Checked = true;
            this.chkWed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWed.Location = new System.Drawing.Point(112, 40);
            this.chkWed.Name = "chkWed";
            this.chkWed.Size = new System.Drawing.Size(49, 17);
            this.chkWed.TabIndex = 9;
            this.chkWed.Text = "Wed";
            this.chkWed.UseVisualStyleBackColor = true;
            this.chkWed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.daysUpdate_MouseClick);
            // 
            // chkTue
            // 
            this.chkTue.AutoSize = true;
            this.chkTue.Checked = true;
            this.chkTue.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTue.Location = new System.Drawing.Point(62, 40);
            this.chkTue.Name = "chkTue";
            this.chkTue.Size = new System.Drawing.Size(45, 17);
            this.chkTue.TabIndex = 8;
            this.chkTue.Text = "Tue";
            this.chkTue.UseVisualStyleBackColor = true;
            this.chkTue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.daysUpdate_MouseClick);
            // 
            // chkMon
            // 
            this.chkMon.AutoSize = true;
            this.chkMon.Checked = true;
            this.chkMon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMon.Location = new System.Drawing.Point(10, 40);
            this.chkMon.Name = "chkMon";
            this.chkMon.Size = new System.Drawing.Size(47, 17);
            this.chkMon.TabIndex = 7;
            this.chkMon.Text = "Mon";
            this.chkMon.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.chkMon.UseVisualStyleBackColor = true;
            this.chkMon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.daysUpdate_MouseClick);
            // 
            // qtyBatt
            // 
            this.qtyBatt.Controls.Add(this.textBox3);
            this.qtyBatt.Controls.Add(this.radBtnBattOther);
            this.qtyBatt.Controls.Add(this.radBtn8Batt);
            this.qtyBatt.Controls.Add(this.radBtn10Batt);
            this.qtyBatt.Controls.Add(this.radBtn12Batt);
            this.qtyBatt.Location = new System.Drawing.Point(200, 40);
            this.qtyBatt.Name = "qtyBatt";
            this.qtyBatt.Size = new System.Drawing.Size(230, 84);
            this.qtyBatt.TabIndex = 8;
            this.qtyBatt.TabStop = false;
            this.qtyBatt.Text = "Qty of Batteries";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            this.textBox3.Click += new System.EventHandler(this.textBox3_Click);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // radBtnBattOther
            // 
            this.radBtnBattOther.AutoSize = true;
            this.radBtnBattOther.Location = new System.Drawing.Point(110, 38);
            this.radBtnBattOther.Name = "radBtnBattOther";
            this.radBtnBattOther.Size = new System.Drawing.Size(51, 17);
            this.radBtnBattOther.TabIndex = 3;
            this.radBtnBattOther.Text = "Other";
            this.radBtnBattOther.UseVisualStyleBackColor = true;
            // 
            // radBtn8Batt
            // 
            this.radBtn8Batt.AutoSize = true;
            this.radBtn8Batt.Location = new System.Drawing.Point(110, 20);
            this.radBtn8Batt.Name = "radBtn8Batt";
            this.radBtn8Batt.Size = new System.Drawing.Size(75, 17);
            this.radBtn8Batt.TabIndex = 2;
            this.radBtn8Batt.Text = "8 Batteries";
            this.radBtn8Batt.UseVisualStyleBackColor = true;
            this.radBtn8Batt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radBtn8Batt_MouseClick);
            // 
            // radBtn10Batt
            // 
            this.radBtn10Batt.AutoSize = true;
            this.radBtn10Batt.Location = new System.Drawing.Point(10, 38);
            this.radBtn10Batt.Name = "radBtn10Batt";
            this.radBtn10Batt.Size = new System.Drawing.Size(81, 17);
            this.radBtn10Batt.TabIndex = 1;
            this.radBtn10Batt.Text = "10 Batteries";
            this.radBtn10Batt.UseVisualStyleBackColor = true;
            this.radBtn10Batt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radBtn10Batt_MouseClick);
            // 
            // radBtn12Batt
            // 
            this.radBtn12Batt.AutoSize = true;
            this.radBtn12Batt.Checked = true;
            this.radBtn12Batt.Location = new System.Drawing.Point(10, 20);
            this.radBtn12Batt.Name = "radBtn12Batt";
            this.radBtn12Batt.Size = new System.Drawing.Size(81, 17);
            this.radBtn12Batt.TabIndex = 0;
            this.radBtn12Batt.TabStop = true;
            this.radBtn12Batt.Text = "12 Batteries";
            this.radBtn12Batt.UseVisualStyleBackColor = true;
            this.radBtn12Batt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radBtn12Batt_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.toolStripMenuItem1.Text = "Home";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.fileToolStripMenuItem.Text = "Import Data";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.exitToolStripMenuItem.Tag = "";
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // chartToolStripMenuItem
            // 
            this.chartToolStripMenuItem.Name = "chartToolStripMenuItem";
            this.chartToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.chartToolStripMenuItem.Text = "Chart";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.indexToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.indexToolStripMenuItem.Text = "Index";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Text documents (.txt)|*.txt";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // fileName
            // 
            this.fileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileName.Location = new System.Drawing.Point(570, 125);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(291, 28);
            this.fileName.TabIndex = 10;
            this.fileName.Text = "fileName";
            this.fileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(475, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Source File:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // hybridLT
            // 
            this.hybridLT.Controls.Add(this.groupBox6);
            this.hybridLT.Controls.Add(this.textBox5);
            this.hybridLT.Controls.Add(this.radBtngKWhOther);
            this.hybridLT.Controls.Add(this.radBtn506gKWh);
            this.hybridLT.Controls.Add(this.chkHybridLTyes);
            this.hybridLT.Location = new System.Drawing.Point(450, 40);
            this.hybridLT.Name = "hybridLT";
            this.hybridLT.Size = new System.Drawing.Size(396, 84);
            this.hybridLT.TabIndex = 12;
            this.hybridLT.TabStop = false;
            this.hybridLT.Text = "Hybrid Light Tower, (grams/KWh)";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.radBtnFuelOther);
            this.groupBox6.Controls.Add(this.radBtn24Gal);
            this.groupBox6.Location = new System.Drawing.Point(201, 10);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(185, 64);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Fuel, ( Gallons )";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(66, 38);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 2;
            this.textBox6.Click += new System.EventHandler(this.textBox6_Click);
            this.textBox6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox6_KeyPress);
            // 
            // radBtnFuelOther
            // 
            this.radBtnFuelOther.AutoSize = true;
            this.radBtnFuelOther.Location = new System.Drawing.Point(10, 38);
            this.radBtnFuelOther.Name = "radBtnFuelOther";
            this.radBtnFuelOther.Size = new System.Drawing.Size(51, 17);
            this.radBtnFuelOther.TabIndex = 1;
            this.radBtnFuelOther.Text = "Other";
            this.radBtnFuelOther.UseVisualStyleBackColor = true;
            // 
            // radBtn24Gal
            // 
            this.radBtn24Gal.AutoSize = true;
            this.radBtn24Gal.Checked = true;
            this.radBtn24Gal.Location = new System.Drawing.Point(10, 20);
            this.radBtn24Gal.Name = "radBtn24Gal";
            this.radBtn24Gal.Size = new System.Drawing.Size(56, 17);
            this.radBtn24Gal.TabIndex = 0;
            this.radBtn24Gal.TabStop = true;
            this.radBtn24Gal.Text = "24 Gal";
            this.radBtn24Gal.UseVisualStyleBackColor = true;
            this.radBtn24Gal.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radBtn24Gal_MouseClick);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(65, 56);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 3;
            this.textBox5.Click += new System.EventHandler(this.textBox5_Click);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // radBtngKWhOther
            // 
            this.radBtngKWhOther.AutoSize = true;
            this.radBtngKWhOther.Location = new System.Drawing.Point(10, 56);
            this.radBtngKWhOther.Name = "radBtngKWhOther";
            this.radBtngKWhOther.Size = new System.Drawing.Size(51, 17);
            this.radBtngKWhOther.TabIndex = 2;
            this.radBtngKWhOther.Text = "Other";
            this.radBtngKWhOther.UseVisualStyleBackColor = true;
            // 
            // radBtn506gKWh
            // 
            this.radBtn506gKWh.AutoSize = true;
            this.radBtn506gKWh.Checked = true;
            this.radBtn506gKWh.Location = new System.Drawing.Point(10, 38);
            this.radBtn506gKWh.Name = "radBtn506gKWh";
            this.radBtn506gKWh.Size = new System.Drawing.Size(43, 17);
            this.radBtn506gKWh.TabIndex = 1;
            this.radBtn506gKWh.TabStop = true;
            this.radBtn506gKWh.Text = "506";
            this.radBtn506gKWh.UseVisualStyleBackColor = true;
            this.radBtn506gKWh.MouseClick += new System.Windows.Forms.MouseEventHandler(this.radBtn506gKWh_MouseClick);
            // 
            // chkHybridLTyes
            // 
            this.chkHybridLTyes.AutoSize = true;
            this.chkHybridLTyes.Location = new System.Drawing.Point(10, 20);
            this.chkHybridLTyes.Name = "chkHybridLTyes";
            this.chkHybridLTyes.Size = new System.Drawing.Size(44, 17);
            this.chkHybridLTyes.TabIndex = 0;
            this.chkHybridLTyes.Text = "Yes";
            this.chkHybridLTyes.UseVisualStyleBackColor = true;
            this.chkHybridLTyes.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chkHybridLTyes_MouseClick);
            // 
            // EnergyChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1264, 730);
            this.Controls.Add(this.hybridLT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.qtyBatt);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lampWatts);
            this.Controls.Add(this.LoadChart);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EnergyChart";
            this.Text = "EnergyChart";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.lampWatts.ResumeLayout(false);
            this.lampWatts.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.qtyBatt.ResumeLayout(false);
            this.qtyBatt.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.hybridLT.ResumeLayout(false);
            this.hybridLT.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button LoadChart;
        private System.Windows.Forms.GroupBox lampWatts;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radBtnOther;
        private System.Windows.Forms.RadioButton radBtn80;
        private System.Windows.Forms.RadioButton radBtn160;
        private System.Windows.Forms.RadioButton radBtn300;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBtnDim;
        private System.Windows.Forms.RadioButton radBtnNormal;
        private System.Windows.Forms.RadioButton radBtnBright;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.RadioButton radBtnXLamps;
        private System.Windows.Forms.RadioButton radBtn2Lamps;
        private System.Windows.Forms.RadioButton radBtn3Lamps;
        private System.Windows.Forms.RadioButton radBtn4Lamps;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radBtn2Panels;
        private System.Windows.Forms.RadioButton radBtn3Panels;
        private System.Windows.Forms.RadioButton radBtn4Panels;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radBtnDDhrs;
        private System.Windows.Forms.RadioButton radBtn12hrs;
        private System.Windows.Forms.RadioButton radBtn9hrs;
        private System.Windows.Forms.RadioButton radBtn6hrs;
        private System.Windows.Forms.RadioButton radBtn3hrs;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkSun;
        private System.Windows.Forms.CheckBox chkSat;
        private System.Windows.Forms.CheckBox chkFri;
        private System.Windows.Forms.CheckBox chkThu;
        private System.Windows.Forms.CheckBox chkWed;
        private System.Windows.Forms.CheckBox chkTue;
        private System.Windows.Forms.CheckBox chkMon;
        private System.Windows.Forms.GroupBox qtyBatt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.RadioButton radBtnBattOther;
        private System.Windows.Forms.RadioButton radBtn8Batt;
        private System.Windows.Forms.RadioButton radBtn10Batt;
        private System.Windows.Forms.RadioButton radBtn12Batt;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.RadioButton radBtn1Panels;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.RadioButton radBtnXPanels;
        private System.Windows.Forms.GroupBox hybridLT;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.RadioButton radBtngKWhOther;
        private System.Windows.Forms.RadioButton radBtn506gKWh;
        private System.Windows.Forms.CheckBox chkHybridLTyes;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.RadioButton radBtnFuelOther;
        private System.Windows.Forms.RadioButton radBtn24Gal;
    }
}

