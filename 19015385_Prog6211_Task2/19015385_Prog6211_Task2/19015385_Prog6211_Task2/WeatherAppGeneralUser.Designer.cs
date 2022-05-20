namespace _19015385_Prog6211_Task2
{
    partial class WeatherAppGeneralUser
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
            this.pnlReport2 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.chklstbxCities = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pnlReport2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlReport2
            // 
            this.pnlReport2.BackColor = System.Drawing.SystemColors.Window;
            this.pnlReport2.Controls.Add(this.richTextBox1);
            this.pnlReport2.Controls.Add(this.label16);
            this.pnlReport2.Controls.Add(this.chklstbxCities);
            this.pnlReport2.Controls.Add(this.label13);
            this.pnlReport2.Controls.Add(this.button1);
            this.pnlReport2.Location = new System.Drawing.Point(12, 12);
            this.pnlReport2.Name = "pnlReport2";
            this.pnlReport2.Size = new System.Drawing.Size(300, 465);
            this.pnlReport2.TabIndex = 35;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(68, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(152, 19);
            this.label16.TabIndex = 31;
            this.label16.Text = "Weather Forecasts";
            // 
            // chklstbxCities
            // 
            this.chklstbxCities.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.chklstbxCities.FormattingEnabled = true;
            this.chklstbxCities.Items.AddRange(new object[] {
            "Durban",
            "Johannesburg",
            "Cape Town",
            "Bloemfontein"});
            this.chklstbxCities.Location = new System.Drawing.Point(171, 68);
            this.chklstbxCities.Name = "chklstbxCities";
            this.chklstbxCities.Size = new System.Drawing.Size(121, 68);
            this.chklstbxCities.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(3, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(108, 16);
            this.label13.TabIndex = 29;
            this.label13.Text = "SELECT CITIES:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.WindowText;
            this.button1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Window;
            this.button1.Location = new System.Drawing.Point(42, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(211, 44);
            this.button1.TabIndex = 28;
            this.button1.Text = "VIEW FORECASTS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(286, 226);
            this.richTextBox1.TabIndex = 32;
            this.richTextBox1.Text = "";
            // 
            // WeatherAppGeneralUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 489);
            this.Controls.Add(this.pnlReport2);
            this.Name = "WeatherAppGeneralUser";
            this.Text = "Weather App";
            this.pnlReport2.ResumeLayout(false);
            this.pnlReport2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlReport2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckedListBox chklstbxCities;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}