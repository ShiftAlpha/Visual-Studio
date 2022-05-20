namespace _19015385_Prog6211_Task2
{
    partial class editforecasts
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
            this.pnlselectforecast = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpSelect = new System.Windows.Forms.DateTimePicker();
            this.btnCaptureData = new System.Windows.Forms.Button();
            this.cmbCitySelect = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.spnMinTemp = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.spnMaxTemp = new System.Windows.Forms.NumericUpDown();
            this.spnPrecip = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.spnHumidity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.spnWindSpd = new System.Windows.Forms.NumericUpDown();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnleditRecord = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbxedited = new System.Windows.Forms.ComboBox();
            this.lstbxFileData = new System.Windows.Forms.ListBox();
            this.pnlselectforecast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHumidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnWindSpd)).BeginInit();
            this.pnleditRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlselectforecast
            // 
            this.pnlselectforecast.BackColor = System.Drawing.SystemColors.Window;
            this.pnlselectforecast.Controls.Add(this.label10);
            this.pnlselectforecast.Controls.Add(this.dtpSelect);
            this.pnlselectforecast.Controls.Add(this.btnCaptureData);
            this.pnlselectforecast.Controls.Add(this.cmbCitySelect);
            this.pnlselectforecast.Controls.Add(this.label7);
            this.pnlselectforecast.Controls.Add(this.label1);
            this.pnlselectforecast.Location = new System.Drawing.Point(27, 81);
            this.pnlselectforecast.Name = "pnlselectforecast";
            this.pnlselectforecast.Size = new System.Drawing.Size(252, 189);
            this.pnlselectforecast.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Select city and date of record to edit";
            // 
            // dtpSelect
            // 
            this.dtpSelect.CustomFormat = "dd/MM/yyyy";
            this.dtpSelect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSelect.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSelect.Location = new System.Drawing.Point(97, 45);
            this.dtpSelect.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpSelect.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtpSelect.Name = "dtpSelect";
            this.dtpSelect.Size = new System.Drawing.Size(144, 21);
            this.dtpSelect.TabIndex = 14;
            // 
            // btnCaptureData
            // 
            this.btnCaptureData.BackColor = System.Drawing.Color.Black;
            this.btnCaptureData.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaptureData.ForeColor = System.Drawing.SystemColors.Window;
            this.btnCaptureData.Location = new System.Drawing.Point(6, 136);
            this.btnCaptureData.Name = "btnCaptureData";
            this.btnCaptureData.Size = new System.Drawing.Size(235, 44);
            this.btnCaptureData.TabIndex = 13;
            this.btnCaptureData.Text = "View Records";
            this.btnCaptureData.UseVisualStyleBackColor = false;
            this.btnCaptureData.Click += new System.EventHandler(this.btnCaptureData_Click);
            // 
            // cmbCitySelect
            // 
            this.cmbCitySelect.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCitySelect.FormattingEnabled = true;
            this.cmbCitySelect.Items.AddRange(new object[] {
            "Durban",
            "Johannesburg",
            "Cape Town",
            "Bloemfontein"});
            this.cmbCitySelect.Location = new System.Drawing.Point(97, 90);
            this.cmbCitySelect.Name = "cmbCitySelect";
            this.cmbCitySelect.Size = new System.Drawing.Size(144, 23);
            this.cmbCitySelect.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "City:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 19);
            this.label14.TabIndex = 16;
            this.label14.Text = "EDIT RECORDS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Min Temp";
            // 
            // spnMinTemp
            // 
            this.spnMinTemp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spnMinTemp.Location = new System.Drawing.Point(176, 59);
            this.spnMinTemp.Name = "spnMinTemp";
            this.spnMinTemp.Size = new System.Drawing.Size(66, 21);
            this.spnMinTemp.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Max Temp";
            // 
            // spnMaxTemp
            // 
            this.spnMaxTemp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.spnMaxTemp.Location = new System.Drawing.Point(175, 105);
            this.spnMaxTemp.Name = "spnMaxTemp";
            this.spnMaxTemp.Size = new System.Drawing.Size(66, 21);
            this.spnMaxTemp.TabIndex = 35;
            // 
            // spnPrecip
            // 
            this.spnPrecip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.spnPrecip.Location = new System.Drawing.Point(175, 155);
            this.spnPrecip.Name = "spnPrecip";
            this.spnPrecip.Size = new System.Drawing.Size(65, 21);
            this.spnPrecip.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Precipitation (%)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Humidity (%)";
            // 
            // spnHumidity
            // 
            this.spnHumidity.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.spnHumidity.Location = new System.Drawing.Point(176, 200);
            this.spnHumidity.Name = "spnHumidity";
            this.spnHumidity.Size = new System.Drawing.Size(65, 21);
            this.spnHumidity.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Wind Speed (km/h)";
            // 
            // spnWindSpd
            // 
            this.spnWindSpd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.spnWindSpd.Location = new System.Drawing.Point(175, 241);
            this.spnWindSpd.Name = "spnWindSpd";
            this.spnWindSpd.Size = new System.Drawing.Size(65, 21);
            this.spnWindSpd.TabIndex = 38;
            // 
            // dtp
            // 
            this.dtp.CustomFormat = "dd/MM/yyyy";
            this.dtp.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp.Location = new System.Drawing.Point(97, 284);
            this.dtp.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtp.MinDate = new System.DateTime(2001, 1, 1, 0, 0, 0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(144, 21);
            this.dtp.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 16);
            this.label8.TabIndex = 47;
            this.label8.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 331);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 16);
            this.label9.TabIndex = 45;
            this.label9.Text = "City:";
            // 
            // pnleditRecord
            // 
            this.pnleditRecord.BackColor = System.Drawing.SystemColors.Window;
            this.pnleditRecord.Controls.Add(this.label11);
            this.pnleditRecord.Controls.Add(this.button1);
            this.pnleditRecord.Controls.Add(this.label2);
            this.pnleditRecord.Controls.Add(this.dtp);
            this.pnleditRecord.Controls.Add(this.spnWindSpd);
            this.pnleditRecord.Controls.Add(this.cmbxedited);
            this.pnleditRecord.Controls.Add(this.label6);
            this.pnleditRecord.Controls.Add(this.label8);
            this.pnleditRecord.Controls.Add(this.spnHumidity);
            this.pnleditRecord.Controls.Add(this.label9);
            this.pnleditRecord.Controls.Add(this.label5);
            this.pnleditRecord.Controls.Add(this.label4);
            this.pnleditRecord.Controls.Add(this.spnMinTemp);
            this.pnleditRecord.Controls.Add(this.spnPrecip);
            this.pnleditRecord.Controls.Add(this.label3);
            this.pnleditRecord.Controls.Add(this.spnMaxTemp);
            this.pnleditRecord.Enabled = false;
            this.pnleditRecord.Location = new System.Drawing.Point(318, 81);
            this.pnleditRecord.Name = "pnleditRecord";
            this.pnleditRecord.Size = new System.Drawing.Size(245, 464);
            this.pnleditRecord.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(68, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 19);
            this.label11.TabIndex = 49;
            this.label11.Text = "Edit Record";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(6, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 44);
            this.button1.TabIndex = 48;
            this.button1.Text = "Save Changes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbxedited
            // 
            this.cmbxedited.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxedited.FormattingEnabled = true;
            this.cmbxedited.Items.AddRange(new object[] {
            "Durban",
            "Johannesburg",
            "Cape Town",
            "Bloemfontein"});
            this.cmbxedited.Location = new System.Drawing.Point(96, 329);
            this.cmbxedited.Name = "cmbxedited";
            this.cmbxedited.Size = new System.Drawing.Size(144, 23);
            this.cmbxedited.TabIndex = 44;
            // 
            // lstbxFileData
            // 
            this.lstbxFileData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbxFileData.FormattingEnabled = true;
            this.lstbxFileData.ItemHeight = 14;
            this.lstbxFileData.Location = new System.Drawing.Point(27, 289);
            this.lstbxFileData.Name = "lstbxFileData";
            this.lstbxFileData.Size = new System.Drawing.Size(252, 256);
            this.lstbxFileData.TabIndex = 49;
            this.lstbxFileData.SelectedIndexChanged += new System.EventHandler(this.lstbxFileData_SelectedIndexChanged);
            // 
            // editforecasts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(605, 574);
            this.Controls.Add(this.lstbxFileData);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pnleditRecord);
            this.Controls.Add(this.pnlselectforecast);
            this.Name = "editforecasts";
            this.Text = "Edit Forecasts";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.editforecasts_FormClosing);
            this.pnlselectforecast.ResumeLayout(false);
            this.pnlselectforecast.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spnMinTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnMaxTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnPrecip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnHumidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnWindSpd)).EndInit();
            this.pnleditRecord.ResumeLayout(false);
            this.pnleditRecord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Panel pnlselectforecast;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpSelect;
        private System.Windows.Forms.Button btnCaptureData;
        private System.Windows.Forms.ComboBox cmbCitySelect;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown spnMinTemp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown spnMaxTemp;
        private System.Windows.Forms.NumericUpDown spnPrecip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown spnHumidity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown spnWindSpd;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnleditRecord;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbxedited;
        private System.Windows.Forms.ListBox lstbxFileData;
    }
}