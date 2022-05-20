namespace WeatherApplication
{
    partial class report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(report));
            this.citycmbx = new System.Windows.Forms.ComboBox();
            this.datecmb = new System.Windows.Forms.ComboBox();
            this.datecmbx = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmpbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.printbtn = new System.Windows.Forms.Button();
            this.dgview = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.genbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).BeginInit();
            this.SuspendLayout();
            // 
            // citycmbx
            // 
            this.citycmbx.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.citycmbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.citycmbx.FormattingEnabled = true;
            this.citycmbx.Location = new System.Drawing.Point(162, 37);
            this.citycmbx.Name = "citycmbx";
            this.citycmbx.Size = new System.Drawing.Size(121, 21);
            this.citycmbx.TabIndex = 0;
            this.citycmbx.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // datecmb
            // 
            this.datecmb.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.datecmb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datecmb.FormattingEnabled = true;
            this.datecmb.Location = new System.Drawing.Point(448, 93);
            this.datecmb.Name = "datecmb";
            this.datecmb.Size = new System.Drawing.Size(121, 21);
            this.datecmb.TabIndex = 1;
            this.datecmb.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // datecmbx
            // 
            this.datecmbx.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.datecmbx.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.datecmbx.FormattingEnabled = true;
            this.datecmbx.Location = new System.Drawing.Point(448, 37);
            this.datecmbx.Name = "datecmbx";
            this.datecmbx.Size = new System.Drawing.Size(121, 21);
            this.datecmbx.TabIndex = 2;
            this.datecmbx.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(101, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "City Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(369, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(369, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Date to";
            // 
            // cmpbtn
            // 
            this.cmpbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cmpbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cmpbtn.Location = new System.Drawing.Point(162, 86);
            this.cmpbtn.Name = "cmpbtn";
            this.cmpbtn.Size = new System.Drawing.Size(121, 23);
            this.cmpbtn.TabIndex = 9;
            this.cmpbtn.Text = "Compare Cities";
            this.cmpbtn.UseVisualStyleBackColor = false;
            this.cmpbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(214, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "or";
            // 
            // printbtn
            // 
            this.printbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.printbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printbtn.Location = new System.Drawing.Point(316, 337);
            this.printbtn.Name = "printbtn";
            this.printbtn.Size = new System.Drawing.Size(75, 23);
            this.printbtn.TabIndex = 11;
            this.printbtn.Text = "Print to File";
            this.printbtn.UseVisualStyleBackColor = false;
            this.printbtn.Click += new System.EventHandler(this.printbtn_Click);
            // 
            // dgview
            // 
            this.dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgview.Location = new System.Drawing.Point(12, 153);
            this.dgview.Name = "dgview";
            this.dgview.Size = new System.Drawing.Size(686, 137);
            this.dgview.TabIndex = 13;
            this.dgview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(162, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Go to Dashboard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // genbtn
            // 
            this.genbtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.genbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.genbtn.Location = new System.Drawing.Point(298, 296);
            this.genbtn.Name = "genbtn";
            this.genbtn.Size = new System.Drawing.Size(104, 23);
            this.genbtn.TabIndex = 7;
            this.genbtn.Text = "Generate Report";
            this.genbtn.UseVisualStyleBackColor = false;
            this.genbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgview);
            this.Controls.Add(this.printbtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmpbtn);
            this.Controls.Add(this.genbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datecmbx);
            this.Controls.Add(this.datecmb);
            this.Controls.Add(this.citycmbx);
            this.Name = "report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "report";
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox citycmbx;
        private System.Windows.Forms.ComboBox datecmb;
        private System.Windows.Forms.ComboBox datecmbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmpbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button printbtn;
        private System.Windows.Forms.DataGridView dgview;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button genbtn;
    }
}