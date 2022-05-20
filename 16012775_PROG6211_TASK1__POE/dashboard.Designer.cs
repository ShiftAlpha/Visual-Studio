namespace _16012775_PROG6211_TASK1__POE
{
    partial class dashboard
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.viewCityBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.endDPick = new System.Windows.Forms.DateTimePicker();
            this.startDPick = new System.Windows.Forms.DateTimePicker();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.endDlbl = new System.Windows.Forms.Label();
            this.startDlbl = new System.Windows.Forms.Label();
            this.selectCitylbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbCities = new System.Windows.Forms.CheckedListBox();
            this.viewMCityBtn = new System.Windows.Forms.Button();
            this.endDlbl2 = new System.Windows.Forms.DateTimePicker();
            this.startDlbl2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.selectCitieslbl = new System.Windows.Forms.Label();
            this.rtbViewRecords = new System.Windows.Forms.RichTextBox();
            this.updateBtn = new System.Windows.Forms.Button();
            this.createBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewCityBtn
            // 
            this.viewCityBtn.Location = new System.Drawing.Point(23, 198);
            this.viewCityBtn.Name = "viewCityBtn";
            this.viewCityBtn.Size = new System.Drawing.Size(261, 36);
            this.viewCityBtn.TabIndex = 0;
            this.viewCityBtn.Text = "View City Forecast";
            this.viewCityBtn.UseVisualStyleBackColor = true;
            this.viewCityBtn.Click += new System.EventHandler(this.viewCityBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.endDPick);
            this.panel1.Controls.Add(this.startDPick);
            this.panel1.Controls.Add(this.cbCity);
            this.panel1.Controls.Add(this.endDlbl);
            this.panel1.Controls.Add(this.startDlbl);
            this.panel1.Controls.Add(this.selectCitylbl);
            this.panel1.Controls.Add(this.viewCityBtn);
            this.panel1.Location = new System.Drawing.Point(12, 412);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(302, 248);
            this.panel1.TabIndex = 4;
            // 
            // endDPick
            // 
            this.endDPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDPick.Location = new System.Drawing.Point(163, 157);
            this.endDPick.Name = "endDPick";
            this.endDPick.Size = new System.Drawing.Size(121, 22);
            this.endDPick.TabIndex = 6;
            // 
            // startDPick
            // 
            this.startDPick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDPick.Location = new System.Drawing.Point(163, 106);
            this.startDPick.Name = "startDPick";
            this.startDPick.Size = new System.Drawing.Size(121, 22);
            this.startDPick.TabIndex = 5;
            // 
            // cbCity
            // 
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(163, 26);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(121, 24);
            this.cbCity.TabIndex = 4;
            // 
            // endDlbl
            // 
            this.endDlbl.AutoSize = true;
            this.endDlbl.Location = new System.Drawing.Point(23, 162);
            this.endDlbl.Name = "endDlbl";
            this.endDlbl.Size = new System.Drawing.Size(67, 17);
            this.endDlbl.TabIndex = 3;
            this.endDlbl.Text = "End Date";
            // 
            // startDlbl
            // 
            this.startDlbl.AutoSize = true;
            this.startDlbl.Location = new System.Drawing.Point(23, 111);
            this.startDlbl.Name = "startDlbl";
            this.startDlbl.Size = new System.Drawing.Size(72, 17);
            this.startDlbl.TabIndex = 2;
            this.startDlbl.Text = "Start Date";
            // 
            // selectCitylbl
            // 
            this.selectCitylbl.AutoSize = true;
            this.selectCitylbl.Location = new System.Drawing.Point(20, 26);
            this.selectCitylbl.Name = "selectCitylbl";
            this.selectCitylbl.Size = new System.Drawing.Size(103, 17);
            this.selectCitylbl.TabIndex = 1;
            this.selectCitylbl.Text = "SELECT CITY: ";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cbCities);
            this.panel2.Controls.Add(this.viewMCityBtn);
            this.panel2.Controls.Add(this.endDlbl2);
            this.panel2.Controls.Add(this.startDlbl2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.selectCitieslbl);
            this.panel2.Location = new System.Drawing.Point(338, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 248);
            this.panel2.TabIndex = 5;
            // 
            // cbCities
            // 
            this.cbCities.FormattingEnabled = true;
            this.cbCities.Items.AddRange(new object[] {
            "Durban",
            "Johannesburg",
            "Cape Town",
            "Bloemfontein"});
            this.cbCities.Location = new System.Drawing.Point(130, 26);
            this.cbCities.Name = "cbCities";
            this.cbCities.Size = new System.Drawing.Size(167, 72);
            this.cbCities.TabIndex = 21;
            // 
            // viewMCityBtn
            // 
            this.viewMCityBtn.Location = new System.Drawing.Point(24, 198);
            this.viewMCityBtn.Name = "viewMCityBtn";
            this.viewMCityBtn.Size = new System.Drawing.Size(273, 36);
            this.viewMCityBtn.TabIndex = 0;
            this.viewMCityBtn.Text = "View Multi-City Forecast";
            this.viewMCityBtn.UseVisualStyleBackColor = true;
            this.viewMCityBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // endDlbl2
            // 
            this.endDlbl2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDlbl2.Location = new System.Drawing.Point(130, 157);
            this.endDlbl2.Name = "endDlbl2";
            this.endDlbl2.Size = new System.Drawing.Size(167, 22);
            this.endDlbl2.TabIndex = 20;
            // 
            // startDlbl2
            // 
            this.startDlbl2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDlbl2.Location = new System.Drawing.Point(130, 111);
            this.startDlbl2.Name = "startDlbl2";
            this.startDlbl2.Size = new System.Drawing.Size(167, 22);
            this.startDlbl2.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "End Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Start Date";
            // 
            // selectCitieslbl
            // 
            this.selectCitieslbl.AutoSize = true;
            this.selectCitieslbl.Location = new System.Drawing.Point(21, 26);
            this.selectCitieslbl.Name = "selectCitieslbl";
            this.selectCitieslbl.Size = new System.Drawing.Size(103, 17);
            this.selectCitieslbl.TabIndex = 15;
            this.selectCitieslbl.Text = "SELECT CITY: ";
            // 
            // rtbViewRecords
            // 
            this.rtbViewRecords.BackColor = System.Drawing.Color.DarkGray;
            this.rtbViewRecords.Location = new System.Drawing.Point(12, 36);
            this.rtbViewRecords.Name = "rtbViewRecords";
            this.rtbViewRecords.Size = new System.Drawing.Size(568, 359);
            this.rtbViewRecords.TabIndex = 6;
            this.rtbViewRecords.Text = "";
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.DarkGray;
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.updateBtn.Location = new System.Drawing.Point(589, 101);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(64, 34);
            this.updateBtn.TabIndex = 41;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.DarkGray;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.createBtn.Location = new System.Drawing.Point(589, 36);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(64, 34);
            this.createBtn.TabIndex = 42;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(665, 672);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.rtbViewRecords);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "dashboard";
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button viewCityBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label endDlbl;
        private System.Windows.Forms.Label startDlbl;
        private System.Windows.Forms.Label selectCitylbl;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button viewMCityBtn;
        private System.Windows.Forms.DateTimePicker endDPick;
        private System.Windows.Forms.DateTimePicker startDPick;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.DateTimePicker endDlbl2;
        private System.Windows.Forms.DateTimePicker startDlbl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label selectCitieslbl;
        private System.Windows.Forms.CheckedListBox cbCities;
        private System.Windows.Forms.RichTextBox rtbViewRecords;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button createBtn;
    }
}