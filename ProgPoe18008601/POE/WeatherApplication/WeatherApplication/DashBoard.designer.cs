namespace WeatherApplication
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.citybtn = new System.Windows.Forms.Button();
            this.cmpcitybtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.dgviewer = new System.Windows.Forms.DataGridView();
            this.prntbtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewer)).BeginInit();
            this.SuspendLayout();
            // 
            // citybtn
            // 
            this.citybtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.citybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.citybtn.Location = new System.Drawing.Point(460, 12);
            this.citybtn.Name = "citybtn";
            this.citybtn.Size = new System.Drawing.Size(192, 33);
            this.citybtn.TabIndex = 1;
            this.citybtn.Text = "View Other City";
            this.citybtn.UseVisualStyleBackColor = false;
            this.citybtn.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cmpcitybtn
            // 
            this.cmpcitybtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cmpcitybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmpcitybtn.Location = new System.Drawing.Point(460, 60);
            this.cmpcitybtn.Name = "cmpcitybtn";
            this.cmpcitybtn.Size = new System.Drawing.Size(192, 33);
            this.cmpcitybtn.TabIndex = 2;
            this.cmpcitybtn.Text = "Compare Cities";
            this.cmpcitybtn.UseVisualStyleBackColor = false;
            this.cmpcitybtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(158, 113);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 33);
            this.button3.TabIndex = 3;
            this.button3.Text = "Add Favourite";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // lstCity
            // 
            this.lstCity.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lstCity.FormattingEnabled = true;
            this.lstCity.Location = new System.Drawing.Point(120, 12);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(173, 95);
            this.lstCity.TabIndex = 4;
            // 
            // dgviewer
            // 
            this.dgviewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewer.Location = new System.Drawing.Point(12, 152);
            this.dgviewer.Name = "dgviewer";
            this.dgviewer.Size = new System.Drawing.Size(754, 150);
            this.dgviewer.TabIndex = 5;
            this.dgviewer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // prntbtn
            // 
            this.prntbtn.BackColor = System.Drawing.SystemColors.ControlDark;
            this.prntbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prntbtn.Location = new System.Drawing.Point(460, 113);
            this.prntbtn.Name = "prntbtn";
            this.prntbtn.Size = new System.Drawing.Size(192, 33);
            this.prntbtn.TabIndex = 6;
            this.prntbtn.Text = "Print to File";
            this.prntbtn.UseVisualStyleBackColor = false;
            this.prntbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(278, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Highest and Lowest Temperatures";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(776, 368);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prntbtn);
            this.Controls.Add(this.dgviewer);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.cmpcitybtn);
            this.Controls.Add(this.citybtn);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgviewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button citybtn;
        private System.Windows.Forms.Button cmpcitybtn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.DataGridView dgviewer;
        private System.Windows.Forms.Button prntbtn;
        private System.Windows.Forms.Button button1;
    }
}