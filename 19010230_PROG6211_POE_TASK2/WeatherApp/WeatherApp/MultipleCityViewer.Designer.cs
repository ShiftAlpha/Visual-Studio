namespace WeatherApp
{
    partial class MultipleCityViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MultipleCityViewer));
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblMaximums = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblForecasts = new System.Windows.Forms.Label();
            this.clbCities = new System.Windows.Forms.CheckedListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.rtbMaximums = new System.Windows.Forms.RichTextBox();
            this.rtbForecasts = new System.Windows.Forms.RichTextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblComboBox = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrintToFile = new System.Windows.Forms.Button();
            this.cmbViewingOption = new System.Windows.Forms.ComboBox();
            this.lblViewingOption = new System.Windows.Forms.Label();
            this.toolTipMultiCity = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Enabled = false;
            this.dtpEnd.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(201, 423);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEnd.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpEnd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(176, 31);
            this.dtpEnd.TabIndex = 29;
            // 
            // dtpStart
            // 
            this.dtpStart.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.dtpStart.CalendarMonthBackground = System.Drawing.SystemColors.Info;
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Enabled = false;
            this.dtpStart.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(201, 334);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpStart.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dtpStart.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(176, 31);
            this.dtpStart.TabIndex = 28;
            // 
            // lblMaximums
            // 
            this.lblMaximums.AutoSize = true;
            this.lblMaximums.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaximums.Location = new System.Drawing.Point(530, 360);
            this.lblMaximums.Name = "lblMaximums";
            this.lblMaximums.Size = new System.Drawing.Size(389, 28);
            this.lblMaximums.TabIndex = 23;
            this.lblMaximums.Text = "Recorded Daily Maximum Values";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(14, 429);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(120, 26);
            this.lblEndDate.TabIndex = 17;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(14, 340);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(144, 26);
            this.lblStartDate.TabIndex = 16;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblForecasts
            // 
            this.lblForecasts.AutoSize = true;
            this.lblForecasts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForecasts.Location = new System.Drawing.Point(632, 58);
            this.lblForecasts.Name = "lblForecasts";
            this.lblForecasts.Size = new System.Drawing.Size(129, 28);
            this.lblForecasts.TabIndex = 32;
            this.lblForecasts.Text = "Forecasts";
            // 
            // clbCities
            // 
            this.clbCities.BackColor = System.Drawing.Color.Moccasin;
            this.clbCities.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbCities.FormattingEnabled = true;
            this.clbCities.Location = new System.Drawing.Point(201, 104);
            this.clbCities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.clbCities.Name = "clbCities";
            this.clbCities.Size = new System.Drawing.Size(176, 116);
            this.clbCities.TabIndex = 33;
            this.clbCities.ThreeDCheckBoxes = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 13);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(146, 73);
            this.btnBack.TabIndex = 34;
            this.btnBack.Text = "Back";
            this.toolTipMultiCity.SetToolTip(this.btnBack, "Return to the menu.");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // rtbMaximums
            // 
            this.rtbMaximums.BackColor = System.Drawing.Color.Moccasin;
            this.rtbMaximums.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbMaximums.Location = new System.Drawing.Point(413, 394);
            this.rtbMaximums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbMaximums.Name = "rtbMaximums";
            this.rtbMaximums.ReadOnly = true;
            this.rtbMaximums.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbMaximums.Size = new System.Drawing.Size(590, 220);
            this.rtbMaximums.TabIndex = 35;
            this.rtbMaximums.Text = "";
            this.rtbMaximums.WordWrap = false;
            // 
            // rtbForecasts
            // 
            this.rtbForecasts.BackColor = System.Drawing.Color.Moccasin;
            this.rtbForecasts.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbForecasts.Location = new System.Drawing.Point(413, 104);
            this.rtbForecasts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbForecasts.Name = "rtbForecasts";
            this.rtbForecasts.ReadOnly = true;
            this.rtbForecasts.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.rtbForecasts.Size = new System.Drawing.Size(590, 235);
            this.rtbForecasts.TabIndex = 36;
            this.rtbForecasts.Text = "";
            this.rtbForecasts.WordWrap = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(225, 512);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(152, 102);
            this.btnConfirm.TabIndex = 37;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblComboBox
            // 
            this.lblComboBox.AutoSize = true;
            this.lblComboBox.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComboBox.Location = new System.Drawing.Point(14, 158);
            this.lblComboBox.Name = "lblComboBox";
            this.lblComboBox.Size = new System.Drawing.Size(108, 26);
            this.lblComboBox.TabIndex = 38;
            this.lblComboBox.Text = "Cities: ";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.DarkOrange;
            this.btnClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(19, 512);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 102);
            this.btnClear.TabIndex = 39;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrintToFile
            // 
            this.btnPrintToFile.BackColor = System.Drawing.Color.DarkOrange;
            this.btnPrintToFile.Enabled = false;
            this.btnPrintToFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintToFile.Location = new System.Drawing.Point(625, 158);
            this.btnPrintToFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrintToFile.Name = "btnPrintToFile";
            this.btnPrintToFile.Size = new System.Drawing.Size(152, 102);
            this.btnPrintToFile.TabIndex = 40;
            this.btnPrintToFile.Text = "Print to File";
            this.toolTipMultiCity.SetToolTip(this.btnPrintToFile, "Print the displayed forecast data to file.");
            this.btnPrintToFile.UseVisualStyleBackColor = false;
            this.btnPrintToFile.Click += new System.EventHandler(this.btnPrintToFile_Click);
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
            this.cmbViewingOption.Location = new System.Drawing.Point(203, 248);
            this.cmbViewingOption.Margin = new System.Windows.Forms.Padding(4);
            this.cmbViewingOption.Name = "cmbViewingOption";
            this.cmbViewingOption.Size = new System.Drawing.Size(174, 31);
            this.cmbViewingOption.TabIndex = 108;
            this.toolTipMultiCity.SetToolTip(this.cmbViewingOption, "Select how you want to view forecast data.");
            this.cmbViewingOption.SelectedIndexChanged += new System.EventHandler(this.cmbViewingOption_SelectedIndexChanged);
            // 
            // lblViewingOption
            // 
            this.lblViewingOption.AutoSize = true;
            this.lblViewingOption.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewingOption.Location = new System.Drawing.Point(13, 249);
            this.lblViewingOption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblViewingOption.Name = "lblViewingOption";
            this.lblViewingOption.Size = new System.Drawing.Size(192, 26);
            this.lblViewingOption.TabIndex = 107;
            this.lblViewingOption.Text = "Viewing Option:";
            // 
            // MultipleCityViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(1016, 623);
            this.Controls.Add(this.cmbViewingOption);
            this.Controls.Add(this.lblViewingOption);
            this.Controls.Add(this.btnPrintToFile);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblComboBox);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.rtbForecasts);
            this.Controls.Add(this.rtbMaximums);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.clbCities);
            this.Controls.Add(this.lblForecasts);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblMaximums);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MultipleCityViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple City Viewer";
            this.Load += new System.EventHandler(this.MultipleCityViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblMaximums;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblForecasts;
        private System.Windows.Forms.CheckedListBox clbCities;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox rtbMaximums;
        private System.Windows.Forms.RichTextBox rtbForecasts;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblComboBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnPrintToFile;
        private System.Windows.Forms.ComboBox cmbViewingOption;
        private System.Windows.Forms.Label lblViewingOption;
        private System.Windows.Forms.ToolTip toolTipMultiCity;
    }
}