namespace WeatherForcast
{
    partial class viewSelectedForcast
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
            this.viewSelectForcastListVierw = new System.Windows.Forms.ListView();
            this.vsfBackBtn = new System.Windows.Forms.Button();
            this.vsfOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewSelectForcastListVierw
            // 
            this.viewSelectForcastListVierw.HideSelection = false;
            this.viewSelectForcastListVierw.Location = new System.Drawing.Point(25, 113);
            this.viewSelectForcastListVierw.Name = "viewSelectForcastListVierw";
            this.viewSelectForcastListVierw.Size = new System.Drawing.Size(443, 256);
            this.viewSelectForcastListVierw.TabIndex = 0;
            this.viewSelectForcastListVierw.UseCompatibleStateImageBehavior = false;
            this.viewSelectForcastListVierw.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // vsfBackBtn
            // 
            this.vsfBackBtn.Location = new System.Drawing.Point(136, 412);
            this.vsfBackBtn.Name = "vsfBackBtn";
            this.vsfBackBtn.Size = new System.Drawing.Size(75, 23);
            this.vsfBackBtn.TabIndex = 1;
            this.vsfBackBtn.Text = "back";
            this.vsfBackBtn.UseVisualStyleBackColor = true;
            this.vsfBackBtn.Click += new System.EventHandler(this.vsfBackBtn_Click);
            // 
            // vsfOkay
            // 
            this.vsfOkay.Location = new System.Drawing.Point(237, 412);
            this.vsfOkay.Name = "vsfOkay";
            this.vsfOkay.Size = new System.Drawing.Size(75, 23);
            this.vsfOkay.TabIndex = 2;
            this.vsfOkay.Text = "okay";
            this.vsfOkay.UseVisualStyleBackColor = true;
            this.vsfOkay.Click += new System.EventHandler(this.vsfOkay_Click);
            // 
            // viewSelectedForcast
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 523);
            this.Controls.Add(this.vsfOkay);
            this.Controls.Add(this.vsfBackBtn);
            this.Controls.Add(this.viewSelectForcastListVierw);
            this.Name = "viewSelectedForcast";
            this.Text = "viewSelectedForcast";
            this.Load += new System.EventHandler(this.viewSelectedForcast_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView viewSelectForcastListVierw;
        private System.Windows.Forms.Button vsfBackBtn;
        private System.Windows.Forms.Button vsfOkay;
    }
}