namespace _19015385_Prog6211_Task1
{
    partial class WeatherApp
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
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.spnMinTemp = new System.Windows.Forms.NumericUpDown();
            this.spnMaxTemp = new System.Windows.Forms.NumericUpDown();
            this.spnPrecip = new System.Windows.Forms.NumericUpDown();
            this.spnHumidity = new System.Windows.Forms.NumericUpDown();
            this.spnWindSpd = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCaptureData = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSelectedCity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dpStartDate = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnGenReport1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dpEndDate1 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dpStartDate1 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.chklstbxCities = new System.Windows.Forms.CheckedListBox();
            this.redoutput = new System.Windows.Forms.RichTextBox();
            this.pnlcaptureforecast = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.pnlReport1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.pnlReport2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnWindSpd)).BeginInit();
            this.pnlcaptureforecast.SuspendLayout();
            this.pnlReport1.SuspendLayout();
            this.pnlReport2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbCity
            // 
            this.cmbCity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Items.AddRange(new object[] {
            "Durban",
            "Johannesburg",
            "Cape Town",
            "Bloemfontein"});
            this.cmbCity.Location = new System.Drawing.Point(97, 121);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(144, 23);
            this.cmbCity.TabIndex = 1;
            // 
            // spnMinTemp
            // 
            this.spnMinTemp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnMinTemp.Location = new System.Drawing.Point(176, 175);
            this.spnMinTemp.Name = "spnMinTemp";
            this.spnMinTemp.Size = new System.Drawing.Size(66, 21);
            this.spnMinTemp.TabIndex = 2;
            // 
            // spnMaxTemp
            // 
            this.spnMaxTemp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.spnMaxTemp.Location = new System.Drawing.Point(175, 221);
            this.spnMaxTemp.Name = "spnMaxTemp";
            this.spnMaxTemp.Size = new System.Drawing.Size(66, 21);
            this.spnMaxTemp.TabIndex = 3;
            // 
            // spnPrecip
            // 
            this.spnPrecip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.spnPrecip.Location = new System.Drawing.Point(175, 271);
            this.spnPrecip.Name = "spnPrecip";
            this.spnPrecip.Size = new System.Drawing.Size(65, 21);
            this.spnPrecip.TabIndex = 4;
            // 
            // spnHumidity
            // 
            this.spnHumidity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.spnHumidity.Location = new System.Drawing.Point(176, 316);
            this.spnHumidity.Name = "spnHumidity";
            this.spnHumidity.Size = new System.Drawing.Size(65, 21);
            this.spnHumidity.TabIndex = 5;
            // 
            // spnWindSpd
            // 
            this.spnWindSpd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.spnWindSpd.Location = new System.Drawing.Point(175, 357);
            this.spnWindSpd.Name = "spnWindSpd";
            this.spnWindSpd.Size = new System.Drawing.Size(65, 21);
            this.spnWindSpd.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "City:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Min Temp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Max Temp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Precipitation (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Humidity (%)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Wind Speed (km/h)";
            // 
            // btnCaptureData
            // 
            this.btnCaptureData.BackColor = System.Drawing.Color.Black;
            this.btnCaptureData.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptureData.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCaptureData.Location = new System.Drawing.Point(6, 437);
            this.btnCaptureData.Name = "btnCaptureData";
            this.btnCaptureData.Size = new System.Drawing.Size(234, 44);
            this.btnCaptureData.TabIndex = 13;
            this.btnCaptureData.Text = "Capture Data";
            this.btnCaptureData.UseVisualStyleBackColor = false;
            this.btnCaptureData.Click += new System.EventHandler(this.btnCaptureData_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(97, 76);
            this.dateTimePicker1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(144, 21);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(3, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "SELECT CITY:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cmbSelectedCity
            // 
            this.cmbSelectedCity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.cmbSelectedCity.FormattingEnabled = true;
            this.cmbSelectedCity.Items.AddRange(new object[] {
            "Durban",
            "Johannesburg",
            "Cape Town",
            "Bloemfontein"});
            this.cmbSelectedCity.Location = new System.Drawing.Point(159, 66);
            this.cmbSelectedCity.Name = "cmbSelectedCity";
            this.cmbSelectedCity.Size = new System.Drawing.Size(138, 23);
            this.cmbSelectedCity.TabIndex = 16;
            this.cmbSelectedCity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(3, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Start Date:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dpStartDate
            // 
            this.dpStartDate.CustomFormat = "dd/MM/yyyy";
            this.dpStartDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpStartDate.Location = new System.Drawing.Point(159, 118);
            this.dpStartDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpStartDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dpStartDate.Name = "dpStartDate";
            this.dpStartDate.Size = new System.Drawing.Size(138, 21);
            this.dpStartDate.TabIndex = 18;
            this.dpStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(3, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "End Date:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dpEndDate
            // 
            this.dpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dpEndDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpEndDate.Location = new System.Drawing.Point(159, 170);
            this.dpEndDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpEndDate.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dpEndDate.Name = "dpEndDate";
            this.dpEndDate.Size = new System.Drawing.Size(138, 21);
            this.dpEndDate.TabIndex = 20;
            this.dpEndDate.ValueChanged += new System.EventHandler(this.dpEndDate_ValueChanged);
            // 
            // btnGenReport1
            // 
            this.btnGenReport1.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnGenReport1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenReport1.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenReport1.Location = new System.Drawing.Point(49, 228);
            this.btnGenReport1.Name = "btnGenReport1";
            this.btnGenReport1.Size = new System.Drawing.Size(211, 44);
            this.btnGenReport1.TabIndex = 22;
            this.btnGenReport1.Text = "Generate Report";
            this.btnGenReport1.UseVisualStyleBackColor = false;
            this.btnGenReport1.Click += new System.EventHandler(this.btnGenReport1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(46, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "Generate Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(168, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "End Date:";
            // 
            // dpEndDate1
            // 
            this.dpEndDate1.CustomFormat = "dd/MM/yyyy";
            this.dpEndDate1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dpEndDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpEndDate1.Location = new System.Drawing.Point(171, 179);
            this.dpEndDate1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpEndDate1.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dpEndDate1.Name = "dpEndDate1";
            this.dpEndDate1.Size = new System.Drawing.Size(121, 21);
            this.dpEndDate1.TabIndex = 26;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(3, 151);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Start Date:";
            // 
            // dpStartDate1
            // 
            this.dpStartDate1.CustomFormat = "dd/MM/yyyy";
            this.dpStartDate1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.dpStartDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpStartDate1.Location = new System.Drawing.Point(6, 179);
            this.dpStartDate1.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dpStartDate1.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dpStartDate1.Name = "dpStartDate1";
            this.dpStartDate1.Size = new System.Drawing.Size(121, 21);
            this.dpStartDate1.TabIndex = 24;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(3, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "SELECT CITIES:";
            // 
            // chklstbxCities
            // 
            this.chklstbxCities.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.chklstbxCities.FormattingEnabled = true;
            this.chklstbxCities.Items.AddRange(new object[] {
            "Durban",
            "Johannesburg",
            "Cape Town",
            "Bloemfontein"});
            this.chklstbxCities.Location = new System.Drawing.Point(171, 66);
            this.chklstbxCities.Name = "chklstbxCities";
            this.chklstbxCities.Size = new System.Drawing.Size(121, 68);
            this.chklstbxCities.TabIndex = 30;
            // 
            // redoutput
            // 
            this.redoutput.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.redoutput.Location = new System.Drawing.Point(282, 105);
            this.redoutput.Name = "redoutput";
            this.redoutput.Size = new System.Drawing.Size(631, 203);
            this.redoutput.TabIndex = 31;
            this.redoutput.Text = "";
            // 
            // pnlcaptureforecast
            // 
            this.pnlcaptureforecast.BackColor = System.Drawing.SystemColors.Window;
            this.pnlcaptureforecast.Controls.Add(this.label14);
            this.pnlcaptureforecast.Controls.Add(this.dateTimePicker1);
            this.pnlcaptureforecast.Controls.Add(this.btnCaptureData);
            this.pnlcaptureforecast.Controls.Add(this.cmbCity);
            this.pnlcaptureforecast.Controls.Add(this.label7);
            this.pnlcaptureforecast.Controls.Add(this.label1);
            this.pnlcaptureforecast.Controls.Add(this.label2);
            this.pnlcaptureforecast.Controls.Add(this.spnMinTemp);
            this.pnlcaptureforecast.Controls.Add(this.label3);
            this.pnlcaptureforecast.Controls.Add(this.spnMaxTemp);
            this.pnlcaptureforecast.Controls.Add(this.spnPrecip);
            this.pnlcaptureforecast.Controls.Add(this.label4);
            this.pnlcaptureforecast.Controls.Add(this.label5);
            this.pnlcaptureforecast.Controls.Add(this.spnHumidity);
            this.pnlcaptureforecast.Controls.Add(this.label6);
            this.pnlcaptureforecast.Controls.Add(this.spnWindSpd);
            this.pnlcaptureforecast.Location = new System.Drawing.Point(3, 105);
            this.pnlcaptureforecast.Name = "pnlcaptureforecast";
            this.pnlcaptureforecast.Size = new System.Drawing.Size(250, 499);
            this.pnlcaptureforecast.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 19);
            this.label14.TabIndex = 16;
            this.label14.Text = "CAPTURE NEW FORECAST";
            // 
            // pnlReport1
            // 
            this.pnlReport1.BackColor = System.Drawing.SystemColors.Window;
            this.pnlReport1.Controls.Add(this.label15);
            this.pnlReport1.Controls.Add(this.btnGenReport1);
            this.pnlReport1.Controls.Add(this.dpEndDate);
            this.pnlReport1.Controls.Add(this.label10);
            this.pnlReport1.Controls.Add(this.label9);
            this.pnlReport1.Controls.Add(this.dpStartDate);
            this.pnlReport1.Controls.Add(this.label8);
            this.pnlReport1.Controls.Add(this.cmbSelectedCity);
            this.pnlReport1.Location = new System.Drawing.Point(282, 314);
            this.pnlReport1.Name = "pnlReport1";
            this.pnlReport1.Size = new System.Drawing.Size(302, 290);
            this.pnlReport1.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(104, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(74, 19);
            this.label15.TabIndex = 23;
            this.label15.Text = "Report 1";
            // 
            // pnlReport2
            // 
            this.pnlReport2.BackColor = System.Drawing.SystemColors.Window;
            this.pnlReport2.Controls.Add(this.label16);
            this.pnlReport2.Controls.Add(this.chklstbxCities);
            this.pnlReport2.Controls.Add(this.label13);
            this.pnlReport2.Controls.Add(this.button1);
            this.pnlReport2.Controls.Add(this.label12);
            this.pnlReport2.Controls.Add(this.label11);
            this.pnlReport2.Controls.Add(this.dpStartDate1);
            this.pnlReport2.Controls.Add(this.dpEndDate1);
            this.pnlReport2.Location = new System.Drawing.Point(613, 314);
            this.pnlReport2.Name = "pnlReport2";
            this.pnlReport2.Size = new System.Drawing.Size(300, 290);
            this.pnlReport2.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(113, 13);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 19);
            this.label16.TabIndex = 31;
            this.label16.Text = "Report 2";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(276, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 38);
            this.panel1.TabIndex = 35;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(276, 616);
            this.panel2.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.Window;
            this.label17.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(448, 41);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(292, 44);
            this.label17.TabIndex = 36;
            this.label17.Text = "WEATHER APP";
            // 
            // WeatherApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(914, 616);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlReport2);
            this.Controls.Add(this.pnlReport1);
            this.Controls.Add(this.pnlcaptureforecast);
            this.Controls.Add(this.redoutput);
            this.Controls.Add(this.panel2);
            this.Name = "WeatherApp";
            this.Text = "Forecasting App";
            this.Load += new System.EventHandler(this.WeatherApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spnMinTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnWindSpd)).EndInit();
            this.pnlcaptureforecast.ResumeLayout(false);
            this.pnlcaptureforecast.PerformLayout();
            this.pnlReport1.ResumeLayout(false);
            this.pnlReport1.PerformLayout();
            this.pnlReport2.ResumeLayout(false);
            this.pnlReport2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.NumericUpDown spnMinTemp;
        private System.Windows.Forms.NumericUpDown spnMaxTemp;
        private System.Windows.Forms.NumericUpDown spnPrecip;
        private System.Windows.Forms.NumericUpDown spnHumidity;
        private System.Windows.Forms.NumericUpDown spnWindSpd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCaptureData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSelectedCity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dpStartDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dpEndDate;
        private System.Windows.Forms.Button btnGenReport1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dpEndDate1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dpStartDate1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox chklstbxCities;
        private System.Windows.Forms.RichTextBox redoutput;
        private System.Windows.Forms.Panel pnlcaptureforecast;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel pnlReport1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnlReport2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label17;
    }
}

