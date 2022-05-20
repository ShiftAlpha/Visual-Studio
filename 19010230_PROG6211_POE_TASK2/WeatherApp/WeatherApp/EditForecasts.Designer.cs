namespace WeatherApp
{
    partial class EditForecasts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForecasts));
            this.btnBack = new System.Windows.Forms.Button();
            this.lstbForecasts = new System.Windows.Forms.ListBox();
            this.cmbChoices = new System.Windows.Forms.ComboBox();
            this.lblForecasts = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblChoice = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.nupWindSpeed = new System.Windows.Forms.NumericUpDown();
            this.nupHumidity = new System.Windows.Forms.NumericUpDown();
            this.nupPrecipitation = new System.Windows.Forms.NumericUpDown();
            this.nupMaxTemp = new System.Windows.Forms.NumericUpDown();
            this.nupMinTemp = new System.Windows.Forms.NumericUpDown();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPrecip = new System.Windows.Forms.Label();
            this.lblMaxTemp = new System.Windows.Forms.Label();
            this.lblMinTemp = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.btnConfirmChoices = new System.Windows.Forms.Button();
            this.btnDeleteForecast = new System.Windows.Forms.Button();
            this.toolTipEdit = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nupWindSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecipitation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(11, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 59);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.toolTipEdit.SetToolTip(this.btnBack, "Return to the menu.");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lstbForecasts
            // 
            this.lstbForecasts.BackColor = System.Drawing.Color.Moccasin;
            this.lstbForecasts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstbForecasts.ColumnWidth = 30;
            this.lstbForecasts.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbForecasts.HorizontalExtent = 1500;
            this.lstbForecasts.HorizontalScrollbar = true;
            this.lstbForecasts.ItemHeight = 26;
            this.lstbForecasts.Location = new System.Drawing.Point(12, 317);
            this.lstbForecasts.Name = "lstbForecasts";
            this.lstbForecasts.ScrollAlwaysVisible = true;
            this.lstbForecasts.Size = new System.Drawing.Size(532, 340);
            this.lstbForecasts.TabIndex = 1;
            this.lstbForecasts.SelectedIndexChanged += new System.EventHandler(this.lstbForecasts_SelectedIndexChanged);
            // 
            // cmbChoices
            // 
            this.cmbChoices.BackColor = System.Drawing.Color.Moccasin;
            this.cmbChoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChoices.FormattingEnabled = true;
            this.cmbChoices.Items.AddRange(new object[] {
            "View All Forecast Data",
            "View Select Forecast Data"});
            this.cmbChoices.Location = new System.Drawing.Point(131, 118);
            this.cmbChoices.Name = "cmbChoices";
            this.cmbChoices.Size = new System.Drawing.Size(268, 31);
            this.cmbChoices.TabIndex = 2;
            this.toolTipEdit.SetToolTip(this.cmbChoices, "Select how you want to view the forecast data.");
            this.cmbChoices.SelectedIndexChanged += new System.EventHandler(this.cmbChoices_SelectedIndexChanged);
            // 
            // lblForecasts
            // 
            this.lblForecasts.AutoSize = true;
            this.lblForecasts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForecasts.Location = new System.Drawing.Point(198, 286);
            this.lblForecasts.Name = "lblForecasts";
            this.lblForecasts.Size = new System.Drawing.Size(129, 28);
            this.lblForecasts.TabIndex = 3;
            this.lblForecasts.Text = "Forecasts";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(831, 186);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(183, 82);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.Moccasin;
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(131, 213);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(268, 31);
            this.cmbCity.TabIndex = 5;
            this.toolTipEdit.SetToolTip(this.cmbCity, "Select the city you want to view and edit forecast data for.");
            // 
            // lblChoice
            // 
            this.lblChoice.AutoSize = true;
            this.lblChoice.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoice.Location = new System.Drawing.Point(12, 119);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(96, 26);
            this.lblChoice.TabIndex = 6;
            this.lblChoice.Text = "Choice:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(12, 218);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(72, 26);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City:";
            // 
            // nupWindSpeed
            // 
            this.nupWindSpeed.BackColor = System.Drawing.Color.Moccasin;
            this.nupWindSpeed.Enabled = false;
            this.nupWindSpeed.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupWindSpeed.Location = new System.Drawing.Point(867, 521);
            this.nupWindSpeed.Name = "nupWindSpeed";
            this.nupWindSpeed.ReadOnly = true;
            this.nupWindSpeed.Size = new System.Drawing.Size(147, 33);
            this.nupWindSpeed.TabIndex = 32;
            // 
            // nupHumidity
            // 
            this.nupHumidity.BackColor = System.Drawing.Color.Moccasin;
            this.nupHumidity.Enabled = false;
            this.nupHumidity.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupHumidity.Location = new System.Drawing.Point(867, 470);
            this.nupHumidity.Name = "nupHumidity";
            this.nupHumidity.ReadOnly = true;
            this.nupHumidity.Size = new System.Drawing.Size(147, 33);
            this.nupHumidity.TabIndex = 31;
            // 
            // nupPrecipitation
            // 
            this.nupPrecipitation.BackColor = System.Drawing.Color.Moccasin;
            this.nupPrecipitation.Enabled = false;
            this.nupPrecipitation.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupPrecipitation.Location = new System.Drawing.Point(867, 417);
            this.nupPrecipitation.Name = "nupPrecipitation";
            this.nupPrecipitation.ReadOnly = true;
            this.nupPrecipitation.Size = new System.Drawing.Size(147, 33);
            this.nupPrecipitation.TabIndex = 30;
            // 
            // nupMaxTemp
            // 
            this.nupMaxTemp.BackColor = System.Drawing.Color.Moccasin;
            this.nupMaxTemp.Enabled = false;
            this.nupMaxTemp.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMaxTemp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.nupMaxTemp.Location = new System.Drawing.Point(867, 363);
            this.nupMaxTemp.Name = "nupMaxTemp";
            this.nupMaxTemp.ReadOnly = true;
            this.nupMaxTemp.Size = new System.Drawing.Size(147, 33);
            this.nupMaxTemp.TabIndex = 29;
            // 
            // nupMinTemp
            // 
            this.nupMinTemp.BackColor = System.Drawing.Color.Moccasin;
            this.nupMinTemp.Enabled = false;
            this.nupMinTemp.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupMinTemp.Location = new System.Drawing.Point(867, 312);
            this.nupMinTemp.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nupMinTemp.Name = "nupMinTemp";
            this.nupMinTemp.ReadOnly = true;
            this.nupMinTemp.Size = new System.Drawing.Size(147, 33);
            this.nupMinTemp.TabIndex = 28;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.AutoSize = true;
            this.lblWindSpeed.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.Location = new System.Drawing.Point(555, 526);
            this.lblWindSpeed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(228, 26);
            this.lblWindSpeed.TabIndex = 27;
            this.lblWindSpeed.Text = "Wind Speed (km/h):";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHumidity.Location = new System.Drawing.Point(555, 475);
            this.lblHumidity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(168, 26);
            this.lblHumidity.TabIndex = 26;
            this.lblHumidity.Text = "Humidity (%):";
            // 
            // lblPrecip
            // 
            this.lblPrecip.AutoSize = true;
            this.lblPrecip.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecip.Location = new System.Drawing.Point(555, 422);
            this.lblPrecip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecip.Name = "lblPrecip";
            this.lblPrecip.Size = new System.Drawing.Size(228, 26);
            this.lblPrecip.TabIndex = 25;
            this.lblPrecip.Text = "Precipitation (%):";
            // 
            // lblMaxTemp
            // 
            this.lblMaxTemp.AutoSize = true;
            this.lblMaxTemp.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTemp.Location = new System.Drawing.Point(555, 368);
            this.lblMaxTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaxTemp.Name = "lblMaxTemp";
            this.lblMaxTemp.Size = new System.Drawing.Size(312, 26);
            this.lblMaxTemp.TabIndex = 24;
            this.lblMaxTemp.Text = "Maximum Temperature (°C):";
            // 
            // lblMinTemp
            // 
            this.lblMinTemp.AutoSize = true;
            this.lblMinTemp.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinTemp.Location = new System.Drawing.Point(555, 317);
            this.lblMinTemp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMinTemp.Name = "lblMinTemp";
            this.lblMinTemp.Size = new System.Drawing.Size(312, 26);
            this.lblMinTemp.TabIndex = 23;
            this.lblMinTemp.Text = "Minimum Temperature (°C):";
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarMonthBackground = System.Drawing.Color.LightGoldenrodYellow;
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Enabled = false;
            this.dtpStart.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(586, 112);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(176, 33);
            this.dtpStart.TabIndex = 33;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(439, 115);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(144, 26);
            this.lblStartDate.TabIndex = 34;
            this.lblStartDate.Text = "Start Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 26);
            this.label1.TabIndex = 35;
            this.label1.Text = "End Date:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CalendarMonthBackground = System.Drawing.Color.LightGoldenrodYellow;
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(586, 213);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(176, 33);
            this.dtpEnd.TabIndex = 36;
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirmChanges.Enabled = false;
            this.btnConfirmChanges.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmChanges.Location = new System.Drawing.Point(831, 576);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(183, 81);
            this.btnConfirmChanges.TabIndex = 37;
            this.btnConfirmChanges.Text = "Confirm Changes";
            this.btnConfirmChanges.UseVisualStyleBackColor = false;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // btnConfirmChoices
            // 
            this.btnConfirmChoices.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirmChoices.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmChoices.Location = new System.Drawing.Point(831, 88);
            this.btnConfirmChoices.Name = "btnConfirmChoices";
            this.btnConfirmChoices.Size = new System.Drawing.Size(183, 82);
            this.btnConfirmChoices.TabIndex = 38;
            this.btnConfirmChoices.Text = "Confirm Choices";
            this.toolTipEdit.SetToolTip(this.btnConfirmChoices, "Confirm viewing and city choices.");
            this.btnConfirmChoices.UseVisualStyleBackColor = false;
            this.btnConfirmChoices.Click += new System.EventHandler(this.btnConfirmChoices_Click);
            // 
            // btnDeleteForecast
            // 
            this.btnDeleteForecast.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDeleteForecast.Enabled = false;
            this.btnDeleteForecast.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteForecast.Location = new System.Drawing.Point(560, 576);
            this.btnDeleteForecast.Name = "btnDeleteForecast";
            this.btnDeleteForecast.Size = new System.Drawing.Size(183, 81);
            this.btnDeleteForecast.TabIndex = 39;
            this.btnDeleteForecast.Text = "Delete Forecast";
            this.btnDeleteForecast.UseVisualStyleBackColor = false;
            this.btnDeleteForecast.Click += new System.EventHandler(this.btnDeleteForecast_Click);
            // 
            // EditForecasts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1045, 682);
            this.Controls.Add(this.btnDeleteForecast);
            this.Controls.Add(this.btnConfirmChoices);
            this.Controls.Add(this.btnConfirmChanges);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.nupWindSpeed);
            this.Controls.Add(this.nupHumidity);
            this.Controls.Add(this.nupPrecipitation);
            this.Controls.Add(this.nupMaxTemp);
            this.Controls.Add(this.nupMinTemp);
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.lblHumidity);
            this.Controls.Add(this.lblPrecip);
            this.Controls.Add(this.lblMaxTemp);
            this.Controls.Add(this.lblMinTemp);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblChoice);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblForecasts);
            this.Controls.Add(this.cmbChoices);
            this.Controls.Add(this.lstbForecasts);
            this.Controls.Add(this.btnBack);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForecasts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Forecasts";
            this.Load += new System.EventHandler(this.EditForecasts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupWindSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupPrecipitation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMaxTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupMinTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstbForecasts;
        private System.Windows.Forms.ComboBox cmbChoices;
        private System.Windows.Forms.Label lblForecasts;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.NumericUpDown nupWindSpeed;
        private System.Windows.Forms.NumericUpDown nupHumidity;
        private System.Windows.Forms.NumericUpDown nupPrecipitation;
        private System.Windows.Forms.NumericUpDown nupMaxTemp;
        private System.Windows.Forms.NumericUpDown nupMinTemp;
        private System.Windows.Forms.Label lblWindSpeed;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPrecip;
        private System.Windows.Forms.Label lblMaxTemp;
        private System.Windows.Forms.Label lblMinTemp;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirmChoices;
        private System.Windows.Forms.Button btnDeleteForecast;
        private System.Windows.Forms.ToolTip toolTipEdit;
    }
}