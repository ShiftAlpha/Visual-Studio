namespace ExpCalculator
{
    partial class RentProp
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
            this.confirmationUD = new System.Windows.Forms.Button();
            this.rentAmtUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.previousBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentAmtUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirmationUD);
            this.panel1.Controls.Add(this.rentAmtUD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.previousBtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 202);
            this.panel1.TabIndex = 0;
            // 
            // confirmationUD
            // 
            this.confirmationUD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmationUD.Location = new System.Drawing.Point(14, 126);
            this.confirmationUD.Name = "confirmationUD";
            this.confirmationUD.Size = new System.Drawing.Size(296, 43);
            this.confirmationUD.TabIndex = 11;
            this.confirmationUD.Text = "Confirmation";
            this.confirmationUD.UseVisualStyleBackColor = true;
            this.confirmationUD.Click += new System.EventHandler(this.confirmationUD_Click);
            // 
            // rentAmtUD
            // 
            this.rentAmtUD.BackColor = System.Drawing.Color.Ivory;
            this.rentAmtUD.DecimalPlaces = 2;
            this.rentAmtUD.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.rentAmtUD.Location = new System.Drawing.Point(102, 85);
            this.rentAmtUD.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.rentAmtUD.Name = "rentAmtUD";
            this.rentAmtUD.Size = new System.Drawing.Size(208, 22);
            this.rentAmtUD.TabIndex = 6;
            this.rentAmtUD.ThousandsSeparator = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amount: ";
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(11, 11);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 31);
            this.previousBtn.TabIndex = 4;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // RentProp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 204);
            this.Controls.Add(this.panel1);
            this.Name = "RentProp";
            this.Text = "RentProp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rentAmtUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown rentAmtUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button confirmationUD;
    }
}