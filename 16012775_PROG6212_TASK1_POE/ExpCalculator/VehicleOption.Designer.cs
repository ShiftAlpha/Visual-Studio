namespace ExpCalculator
{
    partial class VehicleOption
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
            this.previousUD = new System.Windows.Forms.Button();
            this.VehicleDoNotUD = new System.Windows.Forms.Button();
            this.VehiclePurchaseUD = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // previousUD
            // 
            this.previousUD.Location = new System.Drawing.Point(33, 237);
            this.previousUD.Name = "previousUD";
            this.previousUD.Size = new System.Drawing.Size(75, 31);
            this.previousUD.TabIndex = 3;
            this.previousUD.Text = "Previous";
            this.previousUD.UseVisualStyleBackColor = true;
            this.previousUD.Click += new System.EventHandler(this.previousUD_Click);
            // 
            // VehicleDoNotUD
            // 
            this.VehicleDoNotUD.Location = new System.Drawing.Point(33, 160);
            this.VehicleDoNotUD.Name = "VehicleDoNotUD";
            this.VehicleDoNotUD.Size = new System.Drawing.Size(259, 41);
            this.VehicleDoNotUD.TabIndex = 2;
            this.VehicleDoNotUD.Text = "DO NOT PURCHASE";
            this.VehicleDoNotUD.UseVisualStyleBackColor = true;
            this.VehicleDoNotUD.Click += new System.EventHandler(this.VehicleDoNotUD_Click);
            // 
            // VehiclePurchaseUD
            // 
            this.VehiclePurchaseUD.Location = new System.Drawing.Point(33, 86);
            this.VehiclePurchaseUD.Name = "VehiclePurchaseUD";
            this.VehiclePurchaseUD.Size = new System.Drawing.Size(259, 41);
            this.VehiclePurchaseUD.TabIndex = 1;
            this.VehiclePurchaseUD.Text = "Vehicle : Purchase";
            this.VehiclePurchaseUD.UseVisualStyleBackColor = true;
            this.VehiclePurchaseUD.Click += new System.EventHandler(this.VehiclePurchaseUD_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECT ONE OF THE AVAILABLE OPTIONS";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.previousUD);
            this.panel1.Controls.Add(this.VehicleDoNotUD);
            this.panel1.Controls.Add(this.VehiclePurchaseUD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 288);
            this.panel1.TabIndex = 1;
            // 
            // VehicleOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 288);
            this.Controls.Add(this.panel1);
            this.Name = "VehicleOption";
            this.Text = "VehicleOption";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button previousUD;
        private System.Windows.Forms.Button VehicleDoNotUD;
        private System.Windows.Forms.Button VehiclePurchaseUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}