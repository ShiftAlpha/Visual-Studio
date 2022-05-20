namespace _16012775_PROG6211_TASK1__POE
{
    partial class BasicUser_AppInterface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.rtbViewForecasts = new System.Windows.Forms.RichTextBox();
            this.chbCities = new System.Windows.Forms.CheckedListBox();
            this.selectCitieslbl = new System.Windows.Forms.Label();
            this.ForecastHeadinglbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.rtbViewForecasts);
            this.panel1.Controls.Add(this.chbCities);
            this.panel1.Controls.Add(this.selectCitieslbl);
            this.panel1.Controls.Add(this.ForecastHeadinglbl);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 552);
            this.panel1.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.DarkGray;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnView.Location = new System.Drawing.Point(146, 492);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(142, 40);
            this.btnView.TabIndex = 5;
            this.btnView.Text = "VIEW";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbViewForecasts
            // 
            this.rtbViewForecasts.BackColor = System.Drawing.Color.DarkGray;
            this.rtbViewForecasts.Location = new System.Drawing.Point(39, 199);
            this.rtbViewForecasts.Name = "rtbViewForecasts";
            this.rtbViewForecasts.Size = new System.Drawing.Size(351, 272);
            this.rtbViewForecasts.TabIndex = 4;
            this.rtbViewForecasts.Text = "";
            // 
            // chbCities
            // 
            this.chbCities.BackColor = System.Drawing.Color.DarkGray;
            this.chbCities.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbCities.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chbCities.FormattingEnabled = true;
            this.chbCities.Items.AddRange(new object[] {
            "Durban",
            "Johannesburg",
            "Cape Town",
            "Bloemfontein"});
            this.chbCities.Location = new System.Drawing.Point(226, 91);
            this.chbCities.Name = "chbCities";
            this.chbCities.Size = new System.Drawing.Size(164, 92);
            this.chbCities.TabIndex = 3;
            // 
            // selectCitieslbl
            // 
            this.selectCitieslbl.AutoSize = true;
            this.selectCitieslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCitieslbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.selectCitieslbl.Location = new System.Drawing.Point(34, 91);
            this.selectCitieslbl.Name = "selectCitieslbl";
            this.selectCitieslbl.Size = new System.Drawing.Size(175, 29);
            this.selectCitieslbl.TabIndex = 1;
            this.selectCitieslbl.Text = "Select Cities: ";
            // 
            // ForecastHeadinglbl
            // 
            this.ForecastHeadinglbl.AutoSize = true;
            this.ForecastHeadinglbl.BackColor = System.Drawing.Color.Silver;
            this.ForecastHeadinglbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForecastHeadinglbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ForecastHeadinglbl.Location = new System.Drawing.Point(140, 18);
            this.ForecastHeadinglbl.Name = "ForecastHeadinglbl";
            this.ForecastHeadinglbl.Size = new System.Drawing.Size(148, 32);
            this.ForecastHeadinglbl.TabIndex = 0;
            this.ForecastHeadinglbl.Text = "Forecasts";
            // 
            // BasicUser_AppInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 555);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BasicUser_AppInterface";
            this.Text = "BasicUser_AppInterface";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ForecastHeadinglbl;
        private System.Windows.Forms.Label selectCitieslbl;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.RichTextBox rtbViewForecasts;
        private System.Windows.Forms.CheckedListBox chbCities;
    }
}