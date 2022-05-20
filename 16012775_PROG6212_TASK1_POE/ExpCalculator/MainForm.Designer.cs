namespace ExpCalculator
{
    partial class MainForm
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
            this.MiscUD = new System.Windows.Forms.NumericUpDown();
            this.CellTelUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ConfirmationUD = new System.Windows.Forms.Button();
            this.travelComUD = new System.Windows.Forms.NumericUpDown();
            this.UtilitiesUD = new System.Windows.Forms.NumericUpDown();
            this.groceriesUD = new System.Windows.Forms.NumericUpDown();
            this.taxDeductionsUD = new System.Windows.Forms.NumericUpDown();
            this.monthlyIncUD = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiscUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellTelUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelComUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UtilitiesUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceriesUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxDeductionsUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyIncUD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MiscUD);
            this.panel1.Controls.Add(this.CellTelUD);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ConfirmationUD);
            this.panel1.Controls.Add(this.travelComUD);
            this.panel1.Controls.Add(this.UtilitiesUD);
            this.panel1.Controls.Add(this.groceriesUD);
            this.panel1.Controls.Add(this.taxDeductionsUD);
            this.panel1.Controls.Add(this.monthlyIncUD);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(428, 568);
            this.panel1.TabIndex = 0;
            // 
            // MiscUD
            // 
            this.MiscUD.BackColor = System.Drawing.Color.Ivory;
            this.MiscUD.DecimalPlaces = 2;
            this.MiscUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.MiscUD.Location = new System.Drawing.Point(275, 438);
            this.MiscUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MiscUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.MiscUD.Name = "MiscUD";
            this.MiscUD.Size = new System.Drawing.Size(139, 22);
            this.MiscUD.TabIndex = 15;
            this.MiscUD.ThousandsSeparator = true;
            // 
            // CellTelUD
            // 
            this.CellTelUD.BackColor = System.Drawing.Color.Ivory;
            this.CellTelUD.DecimalPlaces = 2;
            this.CellTelUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.CellTelUD.Location = new System.Drawing.Point(275, 388);
            this.CellTelUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CellTelUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.CellTelUD.Name = "CellTelUD";
            this.CellTelUD.Size = new System.Drawing.Size(139, 22);
            this.CellTelUD.TabIndex = 14;
            this.CellTelUD.ThousandsSeparator = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 388);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cell & Tel ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 438);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Misc";
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
            // ConfirmationUD
            // 
            this.ConfirmationUD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmationUD.Location = new System.Drawing.Point(38, 492);
            this.ConfirmationUD.Name = "ConfirmationUD";
            this.ConfirmationUD.Size = new System.Drawing.Size(376, 43);
            this.ConfirmationUD.TabIndex = 10;
            this.ConfirmationUD.Text = "Confirmation";
            this.ConfirmationUD.UseVisualStyleBackColor = true;
            this.ConfirmationUD.Click += new System.EventHandler(this.ConfirmationUD_Click);
            // 
            // travelComUD
            // 
            this.travelComUD.BackColor = System.Drawing.Color.Ivory;
            this.travelComUD.DecimalPlaces = 2;
            this.travelComUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.travelComUD.Location = new System.Drawing.Point(275, 341);
            this.travelComUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.travelComUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.travelComUD.Name = "travelComUD";
            this.travelComUD.Size = new System.Drawing.Size(139, 22);
            this.travelComUD.TabIndex = 9;
            this.travelComUD.ThousandsSeparator = true;
            // 
            // UtilitiesUD
            // 
            this.UtilitiesUD.BackColor = System.Drawing.Color.Ivory;
            this.UtilitiesUD.DecimalPlaces = 2;
            this.UtilitiesUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.UtilitiesUD.Location = new System.Drawing.Point(275, 290);
            this.UtilitiesUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.UtilitiesUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.UtilitiesUD.Name = "UtilitiesUD";
            this.UtilitiesUD.Size = new System.Drawing.Size(139, 22);
            this.UtilitiesUD.TabIndex = 8;
            this.UtilitiesUD.ThousandsSeparator = true;
            // 
            // groceriesUD
            // 
            this.groceriesUD.BackColor = System.Drawing.Color.Ivory;
            this.groceriesUD.DecimalPlaces = 2;
            this.groceriesUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.groceriesUD.Location = new System.Drawing.Point(275, 226);
            this.groceriesUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groceriesUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.groceriesUD.Name = "groceriesUD";
            this.groceriesUD.Size = new System.Drawing.Size(139, 22);
            this.groceriesUD.TabIndex = 7;
            this.groceriesUD.ThousandsSeparator = true;
            // 
            // taxDeductionsUD
            // 
            this.taxDeductionsUD.BackColor = System.Drawing.Color.Ivory;
            this.taxDeductionsUD.DecimalPlaces = 2;
            this.taxDeductionsUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.taxDeductionsUD.Location = new System.Drawing.Point(275, 169);
            this.taxDeductionsUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.taxDeductionsUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.taxDeductionsUD.Name = "taxDeductionsUD";
            this.taxDeductionsUD.Size = new System.Drawing.Size(139, 22);
            this.taxDeductionsUD.TabIndex = 6;
            this.taxDeductionsUD.ThousandsSeparator = true;
            // 
            // monthlyIncUD
            // 
            this.monthlyIncUD.BackColor = System.Drawing.Color.Ivory;
            this.monthlyIncUD.DecimalPlaces = 2;
            this.monthlyIncUD.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.monthlyIncUD.Location = new System.Drawing.Point(275, 113);
            this.monthlyIncUD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.monthlyIncUD.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.monthlyIncUD.Name = "monthlyIncUD";
            this.monthlyIncUD.Size = new System.Drawing.Size(139, 22);
            this.monthlyIncUD.TabIndex = 5;
            this.monthlyIncUD.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Travel & Conmute: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Utilities:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Groceries:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enstimated Monthly Tax Deductions";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gross Monthly Income:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 564);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MiscUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CellTelUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.travelComUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UtilitiesUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groceriesUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taxDeductionsUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthlyIncUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown MiscUD;
        private System.Windows.Forms.NumericUpDown CellTelUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ConfirmationUD;
        private System.Windows.Forms.NumericUpDown travelComUD;
        private System.Windows.Forms.NumericUpDown UtilitiesUD;
        private System.Windows.Forms.NumericUpDown groceriesUD;
        private System.Windows.Forms.NumericUpDown taxDeductionsUD;
        private System.Windows.Forms.NumericUpDown monthlyIncUD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

