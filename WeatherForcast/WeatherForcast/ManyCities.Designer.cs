namespace WeatherForcast
{
    partial class ManyCities
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
            this.mclabel1 = new System.Windows.Forms.Label();
            this.mclabel2 = new System.Windows.Forms.Label();
            this.mcListView = new System.Windows.Forms.ListView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mclabel1
            // 
            this.mclabel1.AutoSize = true;
            this.mclabel1.Location = new System.Drawing.Point(159, 92);
            this.mclabel1.Name = "mclabel1";
            this.mclabel1.Size = new System.Drawing.Size(35, 13);
            this.mclabel1.TabIndex = 0;
            this.mclabel1.Text = "label1";
            this.mclabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // mclabel2
            // 
            this.mclabel2.AutoSize = true;
            this.mclabel2.Location = new System.Drawing.Point(299, 92);
            this.mclabel2.Name = "mclabel2";
            this.mclabel2.Size = new System.Drawing.Size(35, 13);
            this.mclabel2.TabIndex = 1;
            this.mclabel2.Text = "label2";
            this.mclabel2.Click += new System.EventHandler(this.mclabel2_Click);
            // 
            // mcListView
            // 
            this.mcListView.HideSelection = false;
            this.mcListView.Location = new System.Drawing.Point(92, 138);
            this.mcListView.Name = "mcListView";
            this.mcListView.Size = new System.Drawing.Size(326, 235);
            this.mcListView.TabIndex = 2;
            this.mcListView.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 40);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(282, 40);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 430);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "view forcast";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ManyCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 523);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.mcListView);
            this.Controls.Add(this.mclabel2);
            this.Controls.Add(this.mclabel1);
            this.Name = "ManyCities";
            this.Text = "ManyCities";
            this.Load += new System.EventHandler(this.ManyCities_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mclabel1;
        private System.Windows.Forms.Label mclabel2;
        private System.Windows.Forms.ListView mcListView;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button button1;
    }
}