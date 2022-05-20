namespace ExpCalculator
{
    partial class PurchaseProp
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
            this.NumberMonthlyPayUD = new System.Windows.Forms.NumericUpDown();
            this.InterestRateUD = new System.Windows.Forms.NumericUpDown();
            this.depositAmtUD = new System.Windows.Forms.NumericUpDown();
            this.priceUD = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.confirmationUD = new System.Windows.Forms.Button();
            this.previousUD = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NumberMonthlyPayUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositAmtUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUD)).BeginInit();
            this.SuspendLayout();
            // 
            // NumberMonthlyPayUD
            // 
            this.NumberMonthlyPayUD.BackColor = System.Drawing.Color.Ivory;
            this.NumberMonthlyPayUD.DecimalPlaces = 2;
            this.NumberMonthlyPayUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.NumberMonthlyPayUD.Location = new System.Drawing.Point(261, 254);
            this.NumberMonthlyPayUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NumberMonthlyPayUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.NumberMonthlyPayUD.Name = "NumberMonthlyPayUD";
            this.NumberMonthlyPayUD.Size = new System.Drawing.Size(139, 22);
            this.NumberMonthlyPayUD.TabIndex = 16;
            this.NumberMonthlyPayUD.ThousandsSeparator = true;
            // 
            // InterestRateUD
            // 
            this.InterestRateUD.BackColor = System.Drawing.Color.Ivory;
            this.InterestRateUD.DecimalPlaces = 2;
            this.InterestRateUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.InterestRateUD.Location = new System.Drawing.Point(261, 190);
            this.InterestRateUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InterestRateUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.InterestRateUD.Name = "InterestRateUD";
            this.InterestRateUD.Size = new System.Drawing.Size(139, 22);
            this.InterestRateUD.TabIndex = 15;
            this.InterestRateUD.ThousandsSeparator = true;
            // 
            // depositAmtUD
            // 
            this.depositAmtUD.BackColor = System.Drawing.Color.Ivory;
            this.depositAmtUD.DecimalPlaces = 2;
            this.depositAmtUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.depositAmtUD.Location = new System.Drawing.Point(261, 133);
            this.depositAmtUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.depositAmtUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.depositAmtUD.Name = "depositAmtUD";
            this.depositAmtUD.Size = new System.Drawing.Size(139, 22);
            this.depositAmtUD.TabIndex = 14;
            this.depositAmtUD.ThousandsSeparator = true;
            // 
            // priceUD
            // 
            this.priceUD.BackColor = System.Drawing.Color.Ivory;
            this.priceUD.DecimalPlaces = 2;
            this.priceUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.priceUD.Location = new System.Drawing.Point(261, 77);
            this.priceUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.priceUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.priceUD.Name = "priceUD";
            this.priceUD.Size = new System.Drawing.Size(139, 22);
            this.priceUD.TabIndex = 13;
            this.priceUD.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "# of months for payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Interest (%):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Deposit Amount: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Purchase Price: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(151, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Enter Information";
            // 
            // confirmationUD
            // 
            this.confirmationUD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmationUD.Location = new System.Drawing.Point(24, 308);
            this.confirmationUD.Name = "confirmationUD";
            this.confirmationUD.Size = new System.Drawing.Size(376, 60);
            this.confirmationUD.TabIndex = 17;
            this.confirmationUD.Text = "Confirmation";
            this.confirmationUD.UseVisualStyleBackColor = true;
            this.confirmationUD.Click += new System.EventHandler(this.confirmationUD_Click);
            // 
            // previousUD
            // 
            this.previousUD.Location = new System.Drawing.Point(24, 398);
            this.previousUD.Name = "previousUD";
            this.previousUD.Size = new System.Drawing.Size(75, 31);
            this.previousUD.TabIndex = 19;
            this.previousUD.Text = "Previous";
            this.previousUD.UseVisualStyleBackColor = true;
            this.previousUD.Click += new System.EventHandler(this.previousUD_Click);
            // 
            // PurchaseProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 450);
            this.Controls.Add(this.previousUD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.confirmationUD);
            this.Controls.Add(this.NumberMonthlyPayUD);
            this.Controls.Add(this.InterestRateUD);
            this.Controls.Add(this.depositAmtUD);
            this.Controls.Add(this.priceUD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseProp";
            this.Text = "PurchaseProp";
            ((System.ComponentModel.ISupportInitialize)(this.NumberMonthlyPayUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.depositAmtUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumberMonthlyPayUD;
        private System.Windows.Forms.NumericUpDown InterestRateUD;
        private System.Windows.Forms.NumericUpDown depositAmtUD;
        private System.Windows.Forms.NumericUpDown priceUD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button confirmationUD;
        private System.Windows.Forms.Button previousUD;
    }
}