 namespace WeatherApp
{
    partial class CityViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CityViewer));
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblMaximums = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.rtbForecasts = new System.Windows.Forms.RichTextBox();
            this.rtbMaximums = new System.Windows.Forms.RichTextBox();
            this.lblForecasts = new System.Windows.Forms.Label();
            this.btnPrintToFile = new System.Windows.Forms.Button();
            this.lblViewingOption = new System.Windows.Forms.Label();
            this.cmbViewingOption = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.toolTipSingleCity = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(13, 196);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(131, 23);
            this.lblStartDate.TabIndex = 0;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(13, 243);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(109, 23);
            this.lblEndDate.TabIndex = 1;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblMaximums
            // 
            this.lblMaximums.AutoSize = true;
            this.lblMaximums.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximums.Location = new System.Drawing.Point(100, 307);
            this.lblMaximums.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaximums.Name = "lblMaximums";
            this.lblMaximums.Size = new System.Drawing.Size(300, 26);
            this.lblMaximums.TabIndex = 7;
            this.lblMaximums.Text = "Recorded Maximum Values:";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Enabled = false;
            this.dtpStart.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(194, 190);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(167, 31);
            this.dtpStart.TabIndex = 13;
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(194, 243);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEnd.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(167, 31);
            this.dtpEnd.TabIndex = 14;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(13, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(116, 54);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "Back";
            this.toolTipSingleCity.SetToolTip(this.btnBack, "Return to the menu.");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirm.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(369, 81);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(122, 85);
            this.btnConfirm.TabIndex = 18;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmbCity
            // 
            this.cmbCity.BackColor = System.Drawing.Color.Moccasin;
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(194, 81);
            this.cmbCity.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(167, 31);
            this.cmbCity.TabIndex = 19;
            this.toolTipSingleCity.SetToolTip(this.cmbCity, "Select the city you would like to view forecasts for.");
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(13, 84);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(142, 23);
            this.lblCity.TabIndex = 20;
            this.lblCity.Text = "Select City:";
            // 
            // rtbForecasts
            // 
            this.rtbForecasts.BackColor = System.Drawing.Color.Moccasin;
            this.rtbForecasts.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbForecasts.Location = new System.Drawing.Point(514, 47);
            this.rtbForecasts.Margin = new System.Windows.Forms.Padding(4);
            this.rtbForecasts.Name = "rtbForecasts";
            this.rtbForecasts.ReadOnly = true;
            this.rtbForecasts.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbForecasts.Size = new System.Drawing.Size(741, 536);
            this.rtbForecasts.TabIndex = 101;
            this.rtbForecasts.Text = "";
            this.rtbForecasts.WordWrap = false;
            // 
            // rtbMaximums
            // 
            this.rtbMaximums.BackColor = System.Drawing.Color.Moccasin;
            this.rtbMaximums.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMaximums.Location = new System.Drawing.Point(17, 337);
            this.rtbMaximums.Margin = new System.Windows.Forms.Padding(4);
            this.rtbMaximums.Name = "rtbMaximums";
            this.rtbMaximums.ReadOnly = true;
            this.rtbMaximums.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.rtbMaximums.Size = new System.Drawing.Size(474, 246);
            this.rtbMaximums.TabIndex = 102;
            this.rtbMaximums.Text = "";
            this.rtbMaximums.WordWrap = false;
            // 
            // lblForecasts
            // 
            this.lblForecasts.AutoSize = true;
            this.lblForecasts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForecasts.Location = new System.Drawing.Point(821, 15);
            this.lblForecasts.Name = "lblForecasts";
            this.lblForecasts.Size = new System.Drawing.Size(142, 28);
            this.lblForecasts.TabIndex = 103;
            this.lblForecasts.Text = "Forecasts:";
            // 
            // btnPrintToFile
            // 
            this.btnPrintToFile.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrintToFile.Enabled = false;
            this.btnPrintToFile.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintToFile.Location = new System.Drawing.Point(639, 234);
            this.btnPrintToFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintToFile.Name = "btnPrintToFile";
            this.btnPrintToFile.Size = new System.Drawing.Size(122, 85);
            this.btnPrintToFile.TabIndex = 104;
            this.btnPrintToFile.Text = "Print to File";
            this.toolTipSingleCity.SetToolTip(this.btnPrintToFile, "Print the displayed forecast data to file.");
            this.btnPrintToFile.UseVisualStyleBackColor = false;
            this.btnPrintToFile.Click += new System.EventHandler(this.btnPrintToFile_Click);
            // 
            // lblViewingOption
            // 
            this.lblViewingOption.AutoSize = true;
            this.lblViewingOption.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewingOption.Location = new System.Drawing.Point(13, 143);
            this.lblViewingOption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewingOption.Name = "lblViewingOption";
            this.lblViewingOption.Size = new System.Drawing.Size(175, 23);
            this.lblViewingOption.TabIndex = 105;
            this.lblViewingOption.Text = "Viewing Option:";
            // 
            // cmbViewingOption
            // 
            this.cmbViewingOption.BackColor = System.Drawing.Color.Moccasin;
            this.cmbViewingOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbViewingOption.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbViewingOption.FormattingEnabled = true;
            this.cmbViewingOption.Items.AddRange(new object[] {
            "View All Forecasts",
            "View Selected Forecasts"});
            this.cmbViewingOption.Location = new System.Drawing.Point(194, 135);
            this.cmbViewingOption.Margin = new System.Windows.Forms.Padding(4);
            this.cmbViewingOption.Name = "cmbViewingOption";
            this.cmbViewingOption.Size = new System.Drawing.Size(167, 31);
            this.cmbViewingOption.TabIndex = 106;
            this.toolTipSingleCity.SetToolTip(this.cmbViewingOption, "Select how you want to view the forecast data.");
            this.cmbViewingOption.SelectedIndexChanged += new System.EventHandler(this.cmbViewingOption_SelectedIndexChanged);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.Enabled = false;
            this.btnClear.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(369, 190);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(122, 84);
            this.btnClear.TabIndex = 107;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnCLear_Click);
            // 
            // CityViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1285, 604);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmbViewingOption);
            this.Controls.Add(this.lblViewingOption);
            this.Controls.Add(this.btnPrintToFile);
            this.Controls.Add(this.lblForecasts);
            this.Controls.Add(this.rtbMaximums);
            this.Controls.Add(this.rtbForecasts);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.cmbCity);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblMaximums);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CityViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Single City View";
            this.Load += new System.EventHandler(this.CityViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblMaximums;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.RichTextBox rtbForecasts;
        private System.Windows.Forms.RichTextBox rtbMaximums;
        private System.Windows.Forms.Label lblForecasts;
        private System.Windows.Forms.Button btnPrintToFile;
        private System.Windows.Forms.Label lblViewingOption;
        private System.Windows.Forms.ComboBox cmbViewingOption;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolTip toolTipSingleCity;
    }
}