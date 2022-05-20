namespace WeatherForcast
{
    partial class SingleCity
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
            this.singlecityListView = new System.Windows.Forms.ListView();
            this.scdateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.scdateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // singlecityListView
            // 
            this.singlecityListView.FullRowSelect = true;
            this.singlecityListView.HideSelection = false;
            this.singlecityListView.Location = new System.Drawing.Point(85, 137);
            this.singlecityListView.Name = "singlecityListView";
            this.singlecityListView.Size = new System.Drawing.Size(326, 235);
            this.singlecityListView.TabIndex = 0;
            this.singlecityListView.UseCompatibleStateImageBehavior = false;
            this.singlecityListView.SelectedIndexChanged += new System.EventHandler(this.singlecityListView_SelectedIndexChanged);
            // 
            // scdateTimePicker1
            // 
            this.scdateTimePicker1.Location = new System.Drawing.Point(30, 63);
            this.scdateTimePicker1.MaxDate = new System.DateTime(2020, 3, 30, 0, 0, 0, 0);
            this.scdateTimePicker1.MinDate = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            this.scdateTimePicker1.Name = "scdateTimePicker1";
            this.scdateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.scdateTimePicker1.TabIndex = 1;
            this.scdateTimePicker1.Value = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            this.scdateTimePicker1.ValueChanged += new System.EventHandler(this.scdateTimePicker1_ValueChanged);
            // 
            // scdateTimePicker2
            // 
            this.scdateTimePicker2.Location = new System.Drawing.Point(278, 63);
            this.scdateTimePicker2.MaxDate = new System.DateTime(2020, 3, 30, 0, 0, 0, 0);
            this.scdateTimePicker2.MinDate = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            this.scdateTimePicker2.Name = "scdateTimePicker2";
            this.scdateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.scdateTimePicker2.TabIndex = 2;
            this.scdateTimePicker2.Value = new System.DateTime(2020, 3, 1, 0, 0, 0, 0);
            this.scdateTimePicker2.ValueChanged += new System.EventHandler(this.scdateTimePicker2_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "view forcast";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SingleCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 523);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.scdateTimePicker2);
            this.Controls.Add(this.scdateTimePicker1);
            this.Controls.Add(this.singlecityListView);
            this.Name = "SingleCity";
            this.Text = "SingleCity";
            this.Load += new System.EventHandler(this.SingleCity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView singlecityListView;
        private System.Windows.Forms.DateTimePicker scdateTimePicker1;
        private System.Windows.Forms.DateTimePicker scdateTimePicker2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}