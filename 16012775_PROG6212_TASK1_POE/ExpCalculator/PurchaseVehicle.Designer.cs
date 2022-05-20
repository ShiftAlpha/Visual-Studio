namespace ExpCalculator
{
    partial class PurchaseVehicle
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
            this.PreviousBtn = new System.Windows.Forms.Button();
            this.InsurancePremiumUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfirmationBtn = new System.Windows.Forms.Button();
            this.InterestRateUD = new System.Windows.Forms.NumericUpDown();
            this.vehicleDepositUD = new System.Windows.Forms.NumericUpDown();
            this.vehiclePriceUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.vehicleMakeTB = new System.Windows.Forms.TextBox();
            this.vehicleModelTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsurancePremiumUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDepositUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePriceUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.vehicleModelTB);
            this.panel1.Controls.Add(this.vehicleMakeTB);
            this.panel1.Controls.Add(this.PreviousBtn);
            this.panel1.Controls.Add(this.InsurancePremiumUD);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ConfirmationBtn);
            this.panel1.Controls.Add(this.InterestRateUD);
            this.panel1.Controls.Add(this.vehicleDepositUD);
            this.panel1.Controls.Add(this.vehiclePriceUD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(427, 583);
            this.panel1.TabIndex = 1;
            // 
            // PreviousBtn
            // 
            this.PreviousBtn.Location = new System.Drawing.Point(38, 524);
            this.PreviousBtn.Name = "PreviousBtn";
            this.PreviousBtn.Size = new System.Drawing.Size(75, 31);
            this.PreviousBtn.TabIndex = 15;
            this.PreviousBtn.Text = "Previous";
            this.PreviousBtn.UseVisualStyleBackColor = true;
            this.PreviousBtn.Click += new System.EventHandler(this.PreviousBtn_Click);
            // 
            // InsurancePremiumUD
            // 
            this.InsurancePremiumUD.BackColor = System.Drawing.Color.Ivory;
            this.InsurancePremiumUD.DecimalPlaces = 2;
            this.InsurancePremiumUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.InsurancePremiumUD.Location = new System.Drawing.Point(275, 388);
            this.InsurancePremiumUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InsurancePremiumUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.InsurancePremiumUD.Name = "InsurancePremiumUD";
            this.InsurancePremiumUD.Size = new System.Drawing.Size(139, 22);
            this.InsurancePremiumUD.TabIndex = 14;
            this.InsurancePremiumUD.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Insurance Premium: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(152, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Enter Information";
            // 
            // ConfirmationBtn
            // 
            this.ConfirmationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmationBtn.Location = new System.Drawing.Point(38, 451);
            this.ConfirmationBtn.Name = "ConfirmationBtn";
            this.ConfirmationBtn.Size = new System.Drawing.Size(376, 43);
            this.ConfirmationBtn.TabIndex = 10;
            this.ConfirmationBtn.Text = "Confirmation";
            this.ConfirmationBtn.UseVisualStyleBackColor = true;
            this.ConfirmationBtn.Click += new System.EventHandler(this.ConfirmationBtn_Click);
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
            this.InterestRateUD.Location = new System.Drawing.Point(275, 341);
            this.InterestRateUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InterestRateUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.InterestRateUD.Name = "InterestRateUD";
            this.InterestRateUD.Size = new System.Drawing.Size(139, 22);
            this.InterestRateUD.TabIndex = 9;
            this.InterestRateUD.ThousandsSeparator = true;
            // 
            // vehicleDepositUD
            // 
            this.vehicleDepositUD.BackColor = System.Drawing.Color.Ivory;
            this.vehicleDepositUD.DecimalPlaces = 2;
            this.vehicleDepositUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.vehicleDepositUD.Location = new System.Drawing.Point(275, 290);
            this.vehicleDepositUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vehicleDepositUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.vehicleDepositUD.Name = "vehicleDepositUD";
            this.vehicleDepositUD.Size = new System.Drawing.Size(139, 22);
            this.vehicleDepositUD.TabIndex = 8;
            this.vehicleDepositUD.ThousandsSeparator = true;
            // 
            // vehiclePriceUD
            // 
            this.vehiclePriceUD.BackColor = System.Drawing.Color.Ivory;
            this.vehiclePriceUD.DecimalPlaces = 2;
            this.vehiclePriceUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.vehiclePriceUD.Location = new System.Drawing.Point(275, 226);
            this.vehiclePriceUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.vehiclePriceUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.vehiclePriceUD.Name = "vehiclePriceUD";
            this.vehiclePriceUD.Size = new System.Drawing.Size(139, 22);
            this.vehiclePriceUD.TabIndex = 7;
            this.vehiclePriceUD.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Interest(%): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Deposit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Purchase Price: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "vehicle Model:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle Make:";
            // 
            // vehicleMakeTB
            // 
            this.vehicleMakeTB.BackColor = System.Drawing.Color.Ivory;
            this.vehicleMakeTB.Location = new System.Drawing.Point(275, 108);
            this.vehicleMakeTB.Name = "vehicleMakeTB";
            this.vehicleMakeTB.Size = new System.Drawing.Size(139, 22);
            this.vehicleMakeTB.TabIndex = 30;
            // 
            // vehicleModelTB
            // 
            this.vehicleModelTB.BackColor = System.Drawing.Color.Ivory;
            this.vehicleModelTB.Location = new System.Drawing.Point(275, 164);
            this.vehicleModelTB.Name = "vehicleModelTB";
            this.vehicleModelTB.Size = new System.Drawing.Size(139, 22);
            this.vehicleModelTB.TabIndex = 31;
            // 
            // PurchaseVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 581);
            this.Controls.Add(this.panel1);
            this.Name = "PurchaseVehicle";
            this.Text = "PurchaseVehicle";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InsurancePremiumUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InterestRateUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleDepositUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePriceUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown InsurancePremiumUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ConfirmationBtn;
        private System.Windows.Forms.NumericUpDown InterestRateUD;
        private System.Windows.Forms.NumericUpDown vehicleDepositUD;
        private System.Windows.Forms.NumericUpDown vehiclePriceUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button PreviousBtn;
        private System.Windows.Forms.TextBox vehicleModelTB;
        private System.Windows.Forms.TextBox vehicleMakeTB;
    }
}