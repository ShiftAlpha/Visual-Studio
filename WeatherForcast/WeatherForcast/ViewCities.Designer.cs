namespace WeatherForcast
{
    partial class ViewCities
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
            this.viewcitiesLstView = new System.Windows.Forms.ListView();
            this.vcbackBtn = new System.Windows.Forms.Button();
            this.vcSelectManyBtn = new System.Windows.Forms.Button();
            this.vcSelectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewcitiesLstView
            // 
            this.viewcitiesLstView.FullRowSelect = true;
            this.viewcitiesLstView.HideSelection = false;
            this.viewcitiesLstView.Location = new System.Drawing.Point(81, 128);
            this.viewcitiesLstView.Name = "viewcitiesLstView";
            this.viewcitiesLstView.Size = new System.Drawing.Size(326, 235);
            this.viewcitiesLstView.TabIndex = 0;
            this.viewcitiesLstView.UseCompatibleStateImageBehavior = false;
            this.viewcitiesLstView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // vcbackBtn
            // 
            this.vcbackBtn.Location = new System.Drawing.Point(81, 445);
            this.vcbackBtn.Name = "vcbackBtn";
            this.vcbackBtn.Size = new System.Drawing.Size(75, 23);
            this.vcbackBtn.TabIndex = 1;
            this.vcbackBtn.Text = "back";
            this.vcbackBtn.UseVisualStyleBackColor = true;
            this.vcbackBtn.Click += new System.EventHandler(this.vcbackBtn_Click);
            // 
            // vcSelectManyBtn
            // 
            this.vcSelectManyBtn.Location = new System.Drawing.Point(205, 445);
            this.vcSelectManyBtn.Name = "vcSelectManyBtn";
            this.vcSelectManyBtn.Size = new System.Drawing.Size(75, 23);
            this.vcSelectManyBtn.TabIndex = 2;
            this.vcSelectManyBtn.Text = "select many";
            this.vcSelectManyBtn.UseVisualStyleBackColor = true;
            this.vcSelectManyBtn.Click += new System.EventHandler(this.vcSelectManyBtn_Click);
            // 
            // vcSelectBtn
            // 
            this.vcSelectBtn.Location = new System.Drawing.Point(332, 445);
            this.vcSelectBtn.Name = "vcSelectBtn";
            this.vcSelectBtn.Size = new System.Drawing.Size(75, 23);
            this.vcSelectBtn.TabIndex = 3;
            this.vcSelectBtn.Text = "select";
            this.vcSelectBtn.UseVisualStyleBackColor = true;
            this.vcSelectBtn.Click += new System.EventHandler(this.vcSelectBtn_Click);
            // 
            // ViewCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 523);
            this.Controls.Add(this.vcSelectBtn);
            this.Controls.Add(this.vcSelectManyBtn);
            this.Controls.Add(this.vcbackBtn);
            this.Controls.Add(this.viewcitiesLstView);
            this.Name = "ViewCities";
            this.Text = "ViewCities";
            this.Load += new System.EventHandler(this.ViewCities_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView viewcitiesLstView;
        private System.Windows.Forms.Button vcbackBtn;
        private System.Windows.Forms.Button vcSelectManyBtn;
        private System.Windows.Forms.Button vcSelectBtn;
    }
}