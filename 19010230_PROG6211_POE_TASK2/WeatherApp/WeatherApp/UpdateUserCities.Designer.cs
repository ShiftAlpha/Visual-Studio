namespace WeatherApp
{
    partial class UpdateUserCities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateUserCities));
            this.lblCityOptions = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblUserFavourites = new System.Windows.Forms.Label();
            this.lstUserFavourites = new System.Windows.Forms.ListBox();
            this.lstAllCities = new System.Windows.Forms.ListBox();
            this.btnAddCity = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.toolTipUpdateCities = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lblCityOptions
            // 
            this.lblCityOptions.AutoSize = true;
            this.lblCityOptions.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCityOptions.Location = new System.Drawing.Point(93, 121);
            this.lblCityOptions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCityOptions.Name = "lblCityOptions";
            this.lblCityOptions.Size = new System.Drawing.Size(142, 28);
            this.lblCityOptions.TabIndex = 1;
            this.lblCityOptions.Text = "All Cities";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkOrange;
            this.btnBack.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(18, 17);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(160, 68);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.toolTipUpdateCities.SetToolTip(this.btnBack, "Return to the menu.");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblUserFavourites
            // 
            this.lblUserFavourites.AutoSize = true;
            this.lblUserFavourites.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFavourites.Location = new System.Drawing.Point(589, 121);
            this.lblUserFavourites.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUserFavourites.Name = "lblUserFavourites";
            this.lblUserFavourites.Size = new System.Drawing.Size(207, 28);
            this.lblUserFavourites.TabIndex = 3;
            this.lblUserFavourites.Text = "Your Favourites";
            // 
            // lstUserFavourites
            // 
            this.lstUserFavourites.BackColor = System.Drawing.Color.Moccasin;
            this.lstUserFavourites.FormattingEnabled = true;
            this.lstUserFavourites.ItemHeight = 23;
            this.lstUserFavourites.Location = new System.Drawing.Point(543, 166);
            this.lstUserFavourites.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstUserFavourites.Name = "lstUserFavourites";
            this.lstUserFavourites.Size = new System.Drawing.Size(318, 165);
            this.lstUserFavourites.TabIndex = 4;
            this.lstUserFavourites.SelectedIndexChanged += new System.EventHandler(this.lstUserFavourites_SelectedIndexChanged);
            // 
            // lstAllCities
            // 
            this.lstAllCities.BackColor = System.Drawing.Color.Moccasin;
            this.lstAllCities.FormattingEnabled = true;
            this.lstAllCities.ItemHeight = 23;
            this.lstAllCities.Location = new System.Drawing.Point(17, 166);
            this.lstAllCities.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstAllCities.Name = "lstAllCities";
            this.lstAllCities.Size = new System.Drawing.Size(318, 165);
            this.lstAllCities.TabIndex = 5;
            this.lstAllCities.SelectedIndexChanged += new System.EventHandler(this.lstAllCities_SelectedIndexChanged);
            // 
            // btnAddCity
            // 
            this.btnAddCity.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAddCity.Enabled = false;
            this.btnAddCity.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCity.Location = new System.Drawing.Point(359, 166);
            this.btnAddCity.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnAddCity.Name = "btnAddCity";
            this.btnAddCity.Size = new System.Drawing.Size(156, 59);
            this.btnAddCity.TabIndex = 6;
            this.btnAddCity.Text = "Add";
            this.toolTipUpdateCities.SetToolTip(this.btnAddCity, "Add the currently selected city to your favourite cities.");
            this.btnAddCity.UseVisualStyleBackColor = false;
            this.btnAddCity.Click += new System.EventHandler(this.btnAddCity_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DarkOrange;
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(359, 272);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(156, 59);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.toolTipUpdateCities.SetToolTip(this.btnRemove, "Remove the currently selected city from your favourite cities.");
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.DarkOrange;
            this.btnConfirm.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(359, 380);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(156, 76);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm Changes";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // UpdateUserCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(892, 474);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddCity);
            this.Controls.Add(this.lstAllCities);
            this.Controls.Add(this.lstUserFavourites);
            this.Controls.Add(this.lblUserFavourites);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCityOptions);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateUserCities";
            this.Text = "Update Your Favourite Cities";
            this.Load += new System.EventHandler(this.UpdateUserCities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCityOptions;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblUserFavourites;
        private System.Windows.Forms.ListBox lstUserFavourites;
        private System.Windows.Forms.ListBox lstAllCities;
        private System.Windows.Forms.Button btnAddCity;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ToolTip toolTipUpdateCities;
    }
}