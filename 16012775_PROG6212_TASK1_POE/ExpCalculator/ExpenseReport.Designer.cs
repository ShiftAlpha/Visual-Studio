namespace ExpCalculator
{
    partial class ExpenseReport
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
            this.terminateBtn = new System.Windows.Forms.Button();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.previousBtn);
            this.panel1.Controls.Add(this.terminateBtn);
            this.panel1.Controls.Add(this.rtbOutput);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 463);
            this.panel1.TabIndex = 0;
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(74, 406);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(116, 43);
            this.previousBtn.TabIndex = 4;
            this.previousBtn.Text = "Previous";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // terminateBtn
            // 
            this.terminateBtn.Location = new System.Drawing.Point(297, 404);
            this.terminateBtn.Name = "terminateBtn";
            this.terminateBtn.Size = new System.Drawing.Size(116, 46);
            this.terminateBtn.TabIndex = 1;
            this.terminateBtn.Text = "Terminate";
            this.terminateBtn.UseVisualStyleBackColor = true;
            this.terminateBtn.Click += new System.EventHandler(this.terminateBtn_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(74, 88);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(339, 266);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // ExpenseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 461);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpenseReport";
            this.Text = "ExpenseReport";
            this.Load += new System.EventHandler(this.ExpenseReport_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button terminateBtn;
        private System.Windows.Forms.RichTextBox rtbOutput;
    }
}