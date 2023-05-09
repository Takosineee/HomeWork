namespace Lab_Form
{
    partial class Frm_HW2_Loan
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
            this.labDownPaymaent = new System.Windows.Forms.Label();
            this.labRate = new System.Windows.Forms.Label();
            this.labTerm = new System.Windows.Forms.Label();
            this.labLoan = new System.Windows.Forms.Label();
            this.txtLoan = new System.Windows.Forms.MaskedTextBox();
            this.txtTerm = new System.Windows.Forms.MaskedTextBox();
            this.txtRate = new System.Windows.Forms.MaskedTextBox();
            this.txtDP = new System.Windows.Forms.MaskedTextBox();
            this.btnPMT = new System.Windows.Forms.Button();
            this.btnTotalPay = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labDownPaymaent
            // 
            this.labDownPaymaent.AutoSize = true;
            this.labDownPaymaent.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPaymaent.Location = new System.Drawing.Point(264, 356);
            this.labDownPaymaent.Name = "labDownPaymaent";
            this.labDownPaymaent.Size = new System.Drawing.Size(105, 35);
            this.labDownPaymaent.TabIndex = 0;
            this.labDownPaymaent.Text = "頭期款:";
            // 
            // labRate
            // 
            this.labRate.AutoSize = true;
            this.labRate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRate.Location = new System.Drawing.Point(252, 262);
            this.labRate.Name = "labRate";
            this.labRate.Size = new System.Drawing.Size(120, 35);
            this.labRate.TabIndex = 1;
            this.labRate.Text = "利率(%):";
            // 
            // labTerm
            // 
            this.labTerm.AutoSize = true;
            this.labTerm.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTerm.Location = new System.Drawing.Point(249, 160);
            this.labTerm.Name = "labTerm";
            this.labTerm.Size = new System.Drawing.Size(123, 35);
            this.labTerm.TabIndex = 2;
            this.labTerm.Text = "期限(年):";
            // 
            // labLoan
            // 
            this.labLoan.AutoSize = true;
            this.labLoan.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoan.Location = new System.Drawing.Point(238, 60);
            this.labLoan.Name = "labLoan";
            this.labLoan.Size = new System.Drawing.Size(133, 35);
            this.labLoan.TabIndex = 3;
            this.labLoan.Text = "貸款總額:";
            // 
            // txtLoan
            // 
            this.txtLoan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLoan.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoan.ForeColor = System.Drawing.Color.Black;
            this.txtLoan.Location = new System.Drawing.Point(430, 56);
            this.txtLoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoan.Name = "txtLoan";
            this.txtLoan.Size = new System.Drawing.Size(205, 44);
            this.txtLoan.TabIndex = 4;
            this.txtLoan.Tag = "";
            this.txtLoan.Text = "10000";
            // 
            // txtTerm
            // 
            this.txtTerm.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTerm.ForeColor = System.Drawing.Color.Black;
            this.txtTerm.Location = new System.Drawing.Point(430, 156);
            this.txtTerm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(205, 44);
            this.txtTerm.TabIndex = 5;
            this.txtTerm.Text = "2";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRate.ForeColor = System.Drawing.Color.Black;
            this.txtRate.Location = new System.Drawing.Point(430, 258);
            this.txtRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(205, 44);
            this.txtRate.TabIndex = 6;
            this.txtRate.Text = "10";
            // 
            // txtDP
            // 
            this.txtDP.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDP.ForeColor = System.Drawing.Color.Black;
            this.txtDP.Location = new System.Drawing.Point(430, 353);
            this.txtDP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDP.Name = "txtDP";
            this.txtDP.Size = new System.Drawing.Size(205, 44);
            this.txtDP.TabIndex = 7;
            this.txtDP.Text = "0";
            // 
            // btnPMT
            // 
            this.btnPMT.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPMT.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPMT.Location = new System.Drawing.Point(154, 436);
            this.btnPMT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPMT.Name = "btnPMT";
            this.btnPMT.Size = new System.Drawing.Size(168, 66);
            this.btnPMT.TabIndex = 8;
            this.btnPMT.Text = "PMT月付";
            this.btnPMT.UseVisualStyleBackColor = false;
            this.btnPMT.Click += new System.EventHandler(this.btnPMT_Click);
            // 
            // btnTotalPay
            // 
            this.btnTotalPay.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTotalPay.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotalPay.Location = new System.Drawing.Point(346, 436);
            this.btnTotalPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTotalPay.Name = "btnTotalPay";
            this.btnTotalPay.Size = new System.Drawing.Size(168, 66);
            this.btnTotalPay.TabIndex = 9;
            this.btnTotalPay.Text = "總付款額";
            this.btnTotalPay.UseVisualStyleBackColor = false;
            this.btnTotalPay.Click += new System.EventHandler(this.btnTotalPay_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.SystemColors.Info;
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(672, 436);
            this.btnReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(168, 66);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Frm_HW2_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotalPay);
            this.Controls.Add(this.btnPMT);
            this.Controls.Add(this.txtDP);
            this.Controls.Add(this.txtRate);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.txtLoan);
            this.Controls.Add(this.labLoan);
            this.Controls.Add(this.labTerm);
            this.Controls.Add(this.labRate);
            this.Controls.Add(this.labDownPaymaent);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_HW2_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labDownPaymaent;
        private System.Windows.Forms.Label labRate;
        private System.Windows.Forms.Label labTerm;
        private System.Windows.Forms.Label labLoan;
        private System.Windows.Forms.MaskedTextBox txtLoan;
        private System.Windows.Forms.MaskedTextBox txtTerm;
        private System.Windows.Forms.MaskedTextBox txtRate;
        private System.Windows.Forms.MaskedTextBox txtDP;
        private System.Windows.Forms.Button btnPMT;
        private System.Windows.Forms.Button btnTotalPay;
        private System.Windows.Forms.Button btnReport;
    }
}