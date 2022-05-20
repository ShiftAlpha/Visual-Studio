namespace WeatherApp
{
    partial class DataCapture
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataCapture));
            this.lblCity = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblPrecip = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCapture = new System.Windows.Forms.Button();
            this.nupMinTemp = new System.Windows.Forms.NumericUpDown();
            this.nupMaxTemp = new System.Windows.Forms.NumericUpDown();
            this.nupPrecipitation = new System.Windows.Forms.NumericUpDown();
            this.nupHumidity = new System.Windows.Forms.NumericUpDown();
            this.nupWindSpeed = new System.Windows.Forms.NumericUpDown();
            this.toolTipDataCapture = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupMinTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecipitation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWindSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(29, 166);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(77, 28);
            this.lblCity.TabIndex = 0;
            this.lblCity.Text = "City:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(29, 218);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(77, 28);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date:";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(29, 270);
            this.lblMinTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(337, 28);
            this.lblMinTemp.TabIndex = 2;
            this.lblMinTemp.Text = "Minimum Temperature (°C):";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(29, 334);
            this.lblMaxTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(337, 28);
            this.lblMaxTemp.TabIndex = 3;
            this.lblMaxTemp.Text = "Maximum Temperature (°C):";
            // 
            // lblPrecip
            // 
            this.lblPrecip.AutoSize = true;
            this.lblPrecip.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecip.Location = new System.Drawing.Point(29, 394);
            this.lblPrecip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecip.Name = "lblPrecip";
            this.lblPrecip.Size = new System.Drawing.Size(246, 28);
            this.lblPrecip.TabIndex = 4;
            this.lblPrecip.Text = "Precipitation (%):";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(29, 452);
            this.lblHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(181, 28);
            this.lblHumidity.TabIndex = 5;
            this.lblHumidity.Text = "Humidity (%):";
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.Location = new System.Drawing.Point(29, 509);
            this.lblWindSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(246, 28);
            this.lblWindSpeed.TabIndex = 6;
            this.lblWindSpeed.Text = "Wind Speed (km/h):";
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.cmbCity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(375, 158);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(191, 36);
            this.cmbCity.TabIndex = 7;
            this.toolTipDataCapture.SetToolTip(this.cmbCity, "Select an existing city or add a new city.");
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.LightGoldenrodYellow;
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDate.Location = new System.Drawing.Point(375, 210);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpDate.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpDate.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(191, 36);
            this.dtpDate.TabIndex = 8;
            this.toolTipDataCapture.SetToolTip(this.dtpDate, "Select the date you want to record a forecast for.");
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(127, 76);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "Back";
            this.toolTipDataCapture.SetToolTip(this.btnBack, "Return to the menu.");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnCapture
            // 
            this.btnCapture.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCapture.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapture.Location = new System.Drawing.Point(375, 558);
            this.btnCapture.Margin = new System.Windows.Forms.Padding(4);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(191, 71);
            this.btnCapture.TabIndex = 17;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseVisualStyleBackColor = false;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // nupMinTemp
            // 
            this.nupMinTemp.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.nupMinTemp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMinTemp.Location = new System.Drawing.Point(375, 262);
            this.nupMinTemp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nupMinTemp.Name = "nupMinTemp";
            this.nupMinTemp.Size = new System.Drawing.Size(191, 36);
            this.nupMinTemp.TabIndex = 18;
            // 
            // nupMaxTemp
            // 
            this.nupMaxTemp.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.nupMaxTemp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMaxTemp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nupMaxTemp.Location = new System.Drawing.Point(375, 326);
            this.nupMaxTemp.Name = "nupMaxTemp";
            this.nupMaxTemp.Size = new System.Drawing.Size(191, 36);
            this.nupMaxTemp.TabIndex = 19;
            // 
            // nupPrecipitation
            // 
            this.nupPrecipitation.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.nupPrecipitation.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPrecipitation.Location = new System.Drawing.Point(375, 386);
            this.nupPrecipitation.Name = "nupPrecipitation";
            this.nupPrecipitation.Size = new System.Drawing.Size(191, 36);
            this.nupPrecipitation.TabIndex = 20;
            // 
            // nupHumidity
            // 
            this.nupHumidity.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.nupHumidity.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupHumidity.Location = new System.Drawing.Point(375, 444);
            this.nupHumidity.Name = "nupHumidity";
            this.nupHumidity.Size = new System.Drawing.Size(191, 36);
            this.nupHumidity.TabIndex = 21;
            // 
            // nupWindSpeed
            // 
            this.nupWindSpeed.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.nupWindSpeed.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupWindSpeed.Location = new System.Drawing.Point(375, 501);
            this.nupWindSpeed.Name = "nupWindSpeed";
            this.nupWindSpeed.Size = new System.Drawing.Size(191, 36);
            this.nupWindSpeed.TabIndex = 22;
            // 
            // DataCapture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(636, 657);
            this.Controls.Add(this.nupWindSpeed);
            this.Controls.Add(this.nupHumidity);
            this.Controls.Add(this.nupPrecipitation);
            this.Controls.Add(this.nupMaxTemp);
            this.Controls.Add(this.nupMinTemp);
            this.Controls.Add(this.btnCapture);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblPrecip);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblCity);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataCapture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Capture";
            this.Load += new System.EventHandler(this.DataCapture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupMinTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecipitation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupWindSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblPrecip;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.NumericUpDown nupMinTemp;
        private System.Windows.Forms.NumericUpDown nupMaxTemp;
        private System.Windows.Forms.NumericUpDown nupPrecipitation;
        private System.Windows.Forms.NumericUpDown nupHumidity;
        private System.Windows.Forms.NumericUpDown nupWindSpeed;
        private System.Windows.Forms.ToolTip toolTipDataCapture;
    }
}