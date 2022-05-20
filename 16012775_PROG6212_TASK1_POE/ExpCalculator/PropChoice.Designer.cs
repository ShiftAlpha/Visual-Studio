namespace ExpCalculator
{
    partial class PropChoice
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
            this.previousBtn = new System.Windows.Forms.Button();
            this.PropertyRentBtn = new System.Windows.Forms.Button();
            this.propertyPurchaseBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.previousBtn);
            this.panel1.Controls.Add(this.PropertyRentBtn);
            this.panel1.Controls.Add(this.propertyPurchaseBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-3, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 288);
            this.panel1.TabIndex = 0;
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(33, 237);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 31);
            this.previousBtn.TabIndex = 3;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // PropertyRentBtn
            // 
            this.PropertyRentBtn.Location = new System.Drawing.Point(33, 160);
            this.PropertyRentBtn.Name = "PropertyRentBtn";
            this.PropertyRentBtn.Size = new System.Drawing.Size(259, 41);
            this.PropertyRentBtn.TabIndex = 2;
            this.PropertyRentBtn.Text = "Property : Rent";
            this.PropertyRentBtn.UseVisualStyleBackColor = true;
            this.PropertyRentBtn.Click += new System.EventHandler(this.PropertyRentBtn_Click);
            // 
            // propertyPurchaseBtn
            // 
            this.propertyPurchaseBtn.Location = new System.Drawing.Point(33, 86);
            this.propertyPurchaseBtn.Name = "propertyPurchaseBtn";
            this.propertyPurchaseBtn.Size = new System.Drawing.Size(259, 41);
            this.propertyPurchaseBtn.TabIndex = 1;
            this.propertyPurchaseBtn.Text = "Property : Purchase";
            this.propertyPurchaseBtn.UseVisualStyleBackColor = true;
            this.propertyPurchaseBtn.Click += new System.EventHandler(this.propertyPurchaseBtn_Click);
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
            // PropChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 284);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PropChoice";
            this.Text = "PropChoice";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button PropertyRentBtn;
        private System.Windows.Forms.Button propertyPurchaseBtn;
        private System.Windows.Forms.Label label1;
    }
}