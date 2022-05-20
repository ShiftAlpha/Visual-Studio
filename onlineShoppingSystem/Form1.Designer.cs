namespace onlineShoppingSystem
{
    partial class Form1
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
            this.control1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.itemList = new System.Windows.Forms.ListBox();
            this.quantityLbl = new System.Windows.Forms.Label();
            this.quantitySelect = new System.Windows.Forms.NumericUpDown();
            this.addToCartBtn = new System.Windows.Forms.Button();
            this.TotalWVLbl = new System.Windows.Forms.Label();
            this.totalWVTxB = new System.Windows.Forms.TextBox();
            this.totalLbl = new System.Windows.Forms.Label();
            this.rateLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cashIssuedLbl = new System.Windows.Forms.Label();
            this.totalTxb = new System.Windows.Forms.TextBox();
            this.rateCB = new System.Windows.Forms.ComboBox();
            this.calcBtn = new System.Windows.Forms.Button();
            this.vatPayTxB = new System.Windows.Forms.TextBox();
            this.TotalIncVTxB = new System.Windows.Forms.TextBox();
            this.cashRenTxB = new System.Windows.Forms.TextBox();
            this.tenderChangeBtn = new System.Windows.Forms.Button();
            this.changeIssuedTxB = new System.Windows.Forms.TextBox();
            this.control1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelect)).BeginInit();
            this.SuspendLayout();
            // 
            // control1
            // 
            this.control1.Controls.Add(this.tabPage1);
            this.control1.Controls.Add(this.tabPage2);
            this.control1.Location = new System.Drawing.Point(12, 12);
            this.control1.Name = "control1";
            this.control1.SelectedIndex = 0;
            this.control1.Size = new System.Drawing.Size(438, 566);
            this.control1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.totalWVTxB);
            this.tabPage1.Controls.Add(this.TotalWVLbl);
            this.tabPage1.Controls.Add(this.addToCartBtn);
            this.tabPage1.Controls.Add(this.quantitySelect);
            this.tabPage1.Controls.Add(this.quantityLbl);
            this.tabPage1.Controls.Add(this.itemList);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(430, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Shop";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.changeIssuedTxB);
            this.tabPage2.Controls.Add(this.tenderChangeBtn);
            this.tabPage2.Controls.Add(this.cashRenTxB);
            this.tabPage2.Controls.Add(this.TotalIncVTxB);
            this.tabPage2.Controls.Add(this.vatPayTxB);
            this.tabPage2.Controls.Add(this.calcBtn);
            this.tabPage2.Controls.Add(this.rateCB);
            this.tabPage2.Controls.Add(this.totalTxb);
            this.tabPage2.Controls.Add(this.cashIssuedLbl);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.rateLbl);
            this.tabPage2.Controls.Add(this.totalLbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(430, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pay";
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.ItemHeight = 16;
            this.itemList.Location = new System.Drawing.Point(16, 18);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(297, 212);
            this.itemList.TabIndex = 0;
            // 
            // quantityLbl
            // 
            this.quantityLbl.AutoSize = true;
            this.quantityLbl.Location = new System.Drawing.Point(16, 282);
            this.quantityLbl.Name = "quantityLbl";
            this.quantityLbl.Size = new System.Drawing.Size(61, 17);
            this.quantityLbl.TabIndex = 1;
            this.quantityLbl.Text = "Quantity";
            // 
            // quantitySelect
            // 
            this.quantitySelect.Location = new System.Drawing.Point(165, 282);
            this.quantitySelect.Name = "quantitySelect";
            this.quantitySelect.Size = new System.Drawing.Size(148, 22);
            this.quantitySelect.TabIndex = 2;
            this.quantitySelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // addToCartBtn
            // 
            this.addToCartBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.addToCartBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addToCartBtn.Location = new System.Drawing.Point(16, 358);
            this.addToCartBtn.Name = "addToCartBtn";
            this.addToCartBtn.Size = new System.Drawing.Size(125, 57);
            this.addToCartBtn.TabIndex = 3;
            this.addToCartBtn.Text = "Add To Cart";
            this.addToCartBtn.UseVisualStyleBackColor = false;
            // 
            // TotalWVLbl
            // 
            this.TotalWVLbl.AutoSize = true;
            this.TotalWVLbl.Location = new System.Drawing.Point(166, 358);
            this.TotalWVLbl.Name = "TotalWVLbl";
            this.TotalWVLbl.Size = new System.Drawing.Size(147, 17);
            this.TotalWVLbl.TabIndex = 4;
            this.TotalWVLbl.Text = "TOTAL (Without VAT)";
            // 
            // totalWVTxB
            // 
            this.totalWVTxB.Location = new System.Drawing.Point(169, 393);
            this.totalWVTxB.Name = "totalWVTxB";
            this.totalWVTxB.Size = new System.Drawing.Size(144, 22);
            this.totalWVTxB.TabIndex = 5;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(17, 42);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(40, 17);
            this.totalLbl.TabIndex = 0;
            this.totalLbl.Text = "Total";
            // 
            // rateLbl
            // 
            this.rateLbl.AutoSize = true;
            this.rateLbl.Location = new System.Drawing.Point(17, 83);
            this.rateLbl.Name = "rateLbl";
            this.rateLbl.Size = new System.Drawing.Size(38, 17);
            this.rateLbl.TabIndex = 1;
            this.rateLbl.Text = "Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "VAT Payable";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "TOTAL INCL VAT";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "CASH Tendered";
            // 
            // cashIssuedLbl
            // 
            this.cashIssuedLbl.AutoSize = true;
            this.cashIssuedLbl.Location = new System.Drawing.Point(17, 450);
            this.cashIssuedLbl.Name = "cashIssuedLbl";
            this.cashIssuedLbl.Size = new System.Drawing.Size(102, 17);
            this.cashIssuedLbl.TabIndex = 5;
            this.cashIssuedLbl.Text = "Change Issued";
            // 
            // totalTxb
            // 
            this.totalTxb.Location = new System.Drawing.Point(268, 42);
            this.totalTxb.Name = "totalTxb";
            this.totalTxb.Size = new System.Drawing.Size(100, 22);
            this.totalTxb.TabIndex = 6;
            // 
            // rateCB
            // 
            this.rateCB.FormattingEnabled = true;
            this.rateCB.Items.AddRange(new object[] {
            "10",
            "15",
            "20"});
            this.rateCB.Location = new System.Drawing.Point(268, 83);
            this.rateCB.Name = "rateCB";
            this.rateCB.Size = new System.Drawing.Size(100, 24);
            this.rateCB.TabIndex = 7;
            // 
            // calcBtn
            // 
            this.calcBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.calcBtn.Location = new System.Drawing.Point(20, 151);
            this.calcBtn.Name = "calcBtn";
            this.calcBtn.Size = new System.Drawing.Size(348, 30);
            this.calcBtn.TabIndex = 8;
            this.calcBtn.Text = "Calculate VAT";
            this.calcBtn.UseVisualStyleBackColor = false;
            this.calcBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // vatPayTxB
            // 
            this.vatPayTxB.Location = new System.Drawing.Point(268, 237);
            this.vatPayTxB.Name = "vatPayTxB";
            this.vatPayTxB.Size = new System.Drawing.Size(100, 22);
            this.vatPayTxB.TabIndex = 9;
            // 
            // TotalIncVTxB
            // 
            this.TotalIncVTxB.Location = new System.Drawing.Point(268, 279);
            this.TotalIncVTxB.Name = "TotalIncVTxB";
            this.TotalIncVTxB.Size = new System.Drawing.Size(100, 22);
            this.TotalIncVTxB.TabIndex = 10;
            // 
            // cashRenTxB
            // 
            this.cashRenTxB.Location = new System.Drawing.Point(268, 329);
            this.cashRenTxB.Name = "cashRenTxB";
            this.cashRenTxB.Size = new System.Drawing.Size(100, 22);
            this.cashRenTxB.TabIndex = 11;
            // 
            // tenderChangeBtn
            // 
            this.tenderChangeBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tenderChangeBtn.Location = new System.Drawing.Point(20, 384);
            this.tenderChangeBtn.Name = "tenderChangeBtn";
            this.tenderChangeBtn.Size = new System.Drawing.Size(348, 32);
            this.tenderChangeBtn.TabIndex = 12;
            this.tenderChangeBtn.Text = "Tender Change";
            this.tenderChangeBtn.UseVisualStyleBackColor = false;
            // 
            // changeIssuedTxB
            // 
            this.changeIssuedTxB.Location = new System.Drawing.Point(268, 445);
            this.changeIssuedTxB.Name = "changeIssuedTxB";
            this.changeIssuedTxB.Size = new System.Drawing.Size(100, 22);
            this.changeIssuedTxB.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(462, 618);
            this.Controls.Add(this.control1);
            this.Name = "Form1";
            this.Text = "Online Shopping";
            this.control1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantitySelect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl control1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox totalWVTxB;
        private System.Windows.Forms.Label TotalWVLbl;
        private System.Windows.Forms.Button addToCartBtn;
        private System.Windows.Forms.NumericUpDown quantitySelect;
        private System.Windows.Forms.Label quantityLbl;
        private System.Windows.Forms.ListBox itemList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox changeIssuedTxB;
        private System.Windows.Forms.Button tenderChangeBtn;
        private System.Windows.Forms.TextBox cashRenTxB;
        private System.Windows.Forms.TextBox TotalIncVTxB;
        private System.Windows.Forms.TextBox vatPayTxB;
        private System.Windows.Forms.Button calcBtn;
        private System.Windows.Forms.ComboBox rateCB;
        private System.Windows.Forms.TextBox totalTxb;
        private System.Windows.Forms.Label cashIssuedLbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label rateLbl;
        private System.Windows.Forms.Label totalLbl;
    }
}

