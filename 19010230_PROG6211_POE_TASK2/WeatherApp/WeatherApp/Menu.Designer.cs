namespace WeatherApp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnEnterData = new System.Windows.Forms.Button();
            this.btnOneCity = new System.Windows.Forms.Button();
            this.btnMultipleCities = new System.Windows.Forms.Button();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnEditData = new System.Windows.Forms.Button();
            this.btnUpdateCities = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.toolTipMenu = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // btnEnterData
            // 
            this.btnEnterData.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEnterData.Location = new System.Drawing.Point(270, 125);
            this.btnEnterData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEnterData.Name = "btnEnterData";
            this.btnEnterData.Size = new System.Drawing.Size(232, 100);
            this.btnEnterData.TabIndex = 0;
            this.btnEnterData.Text = "Capture Data";
            this.toolTipMenu.SetToolTip(this.btnEnterData, "Capture new forecast data.");
            this.btnEnterData.UseVisualStyleBackColor = false;
            this.btnEnterData.Click += new System.EventHandler(this.btnEnterData_Click);
            // 
            // btnOneCity
            // 
            this.btnOneCity.BackColor = System.Drawing.Color.DarkOrange;
            this.btnOneCity.Location = new System.Drawing.Point(270, 341);
            this.btnOneCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOneCity.Name = "btnOneCity";
            this.btnOneCity.Size = new System.Drawing.Size(232, 100);
            this.btnOneCity.TabIndex = 1;
            this.btnOneCity.Text = "View Data for One City";
            this.toolTipMenu.SetToolTip(this.btnOneCity, "View forecast data for a single city.");
            this.btnOneCity.UseVisualStyleBackColor = false;
            this.btnOneCity.Click += new System.EventHandler(this.btnOneCity_Click);
            // 
            // btnMultipleCities
            // 
            this.btnMultipleCities.BackColor = System.Drawing.Color.DarkOrange;
            this.btnMultipleCities.Location = new System.Drawing.Point(270, 449);
            this.btnMultipleCities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMultipleCities.Name = "btnMultipleCities";
            this.btnMultipleCities.Size = new System.Drawing.Size(232, 100);
            this.btnMultipleCities.TabIndex = 2;
            this.btnMultipleCities.Text = "View Data for Multiple cities";
            this.toolTipMenu.SetToolTip(this.btnMultipleCities, "View forecast data for multiple cities simultaneously");
            this.btnMultipleCities.UseVisualStyleBackColor = false;
            this.btnMultipleCities.Click += new System.EventHandler(this.btnMultipleCities_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblHeading.Font = new System.Drawing.Font("Consolas", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(326, 48);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(128, 56);
            this.lblHeading.TabIndex = 3;
            this.lblHeading.Text = "Menu";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.LightSlateGray;
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(60, 26);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "date";
            // 
            // btnEditData
            // 
            this.btnEditData.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEditData.Location = new System.Drawing.Point(270, 233);
            this.btnEditData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(232, 100);
            this.btnEditData.TabIndex = 6;
            this.btnEditData.Text = "View && Edit Data";
            this.toolTipMenu.SetToolTip(this.btnEditData, "View and edit existing forecast data.");
            this.btnEditData.UseVisualStyleBackColor = false;
            this.btnEditData.Click += new System.EventHandler(this.btnEditData_Click);
            // 
            // btnUpdateCities
            // 
            this.btnUpdateCities.BackColor = System.Drawing.Color.DarkOrange;
            this.btnUpdateCities.Location = new System.Drawing.Point(12, 341);
            this.btnUpdateCities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateCities.Name = "btnUpdateCities";
            this.btnUpdateCities.Size = new System.Drawing.Size(232, 100);
            this.btnUpdateCities.TabIndex = 7;
            this.btnUpdateCities.Text = "Update Your Favourite Cities";
            this.toolTipMenu.SetToolTip(this.btnUpdateCities, "Update cities you regularly want to view forecasts for.");
            this.btnUpdateCities.UseVisualStyleBackColor = false;
            this.btnUpdateCities.Click += new System.EventHandler(this.btnUpdateCities_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.DarkOrange;
            this.btnLogout.Location = new System.Drawing.Point(270, 557);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(232, 100);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.toolTipMenu.SetToolTip(this.btnLogout, "Logout of the application.");
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(729, 678);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnUpdateCities);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.btnMultipleCities);
            this.Controls.Add(this.btnOneCity);
            this.Controls.Add(this.btnEnterData);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnterData;
        private System.Windows.Forms.Button btnOneCity;
        private System.Windows.Forms.Button btnMultipleCities;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnEditData;
        private System.Windows.Forms.Button btnUpdateCities;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ToolTip toolTipMenu;
    }
}

