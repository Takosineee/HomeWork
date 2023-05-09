namespace Lab_HomeWork
{
    partial class Frm_HW2_report
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
            this.labReportLoan = new System.Windows.Forms.Label();
            this.labReportTerm = new System.Windows.Forms.Label();
            this.labReportRate = new System.Windows.Forms.Label();
            this.labReportPMT = new System.Windows.Forms.Label();
            this.labTotalPayment = new System.Windows.Forms.Label();
            this.btnEmail = new System.Windows.Forms.Button();
            this.labShowLoan = new System.Windows.Forms.Label();
            this.labShowPayment = new System.Windows.Forms.Label();
            this.labShowPMT = new System.Windows.Forms.Label();
            this.labShowRate = new System.Windows.Forms.Label();
            this.labShowTerm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labReportLoan
            // 
            this.labReportLoan.AutoSize = true;
            this.labReportLoan.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReportLoan.Location = new System.Drawing.Point(189, 61);
            this.labReportLoan.Name = "labReportLoan";
            this.labReportLoan.Size = new System.Drawing.Size(133, 35);
            this.labReportLoan.TabIndex = 0;
            this.labReportLoan.Text = "貸款金額:";
            // 
            // labReportTerm
            // 
            this.labReportTerm.AutoSize = true;
            this.labReportTerm.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReportTerm.Location = new System.Drawing.Point(189, 149);
            this.labReportTerm.Name = "labReportTerm";
            this.labReportTerm.Size = new System.Drawing.Size(123, 35);
            this.labReportTerm.TabIndex = 1;
            this.labReportTerm.Text = "期限(年):";
            // 
            // labReportRate
            // 
            this.labReportRate.AutoSize = true;
            this.labReportRate.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReportRate.Location = new System.Drawing.Point(189, 234);
            this.labReportRate.Name = "labReportRate";
            this.labReportRate.Size = new System.Drawing.Size(120, 35);
            this.labReportRate.TabIndex = 2;
            this.labReportRate.Text = "利率(%):";
            // 
            // labReportPMT
            // 
            this.labReportPMT.AutoSize = true;
            this.labReportPMT.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labReportPMT.Location = new System.Drawing.Point(189, 319);
            this.labReportPMT.Name = "labReportPMT";
            this.labReportPMT.Size = new System.Drawing.Size(105, 35);
            this.labReportPMT.TabIndex = 3;
            this.labReportPMT.Text = "月付額:";
            // 
            // labTotalPayment
            // 
            this.labTotalPayment.AutoSize = true;
            this.labTotalPayment.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPayment.Location = new System.Drawing.Point(189, 395);
            this.labTotalPayment.Name = "labTotalPayment";
            this.labTotalPayment.Size = new System.Drawing.Size(133, 35);
            this.labTotalPayment.TabIndex = 4;
            this.labTotalPayment.Text = "還款總額:";
            // 
            // btnEmail
            // 
            this.btnEmail.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnEmail.Location = new System.Drawing.Point(696, 432);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(142, 67);
            this.btnEmail.TabIndex = 5;
            this.btnEmail.Text = "Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // labShowLoan
            // 
            this.labShowLoan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labShowLoan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labShowLoan.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowLoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labShowLoan.Location = new System.Drawing.Point(349, 50);
            this.labShowLoan.Name = "labShowLoan";
            this.labShowLoan.Size = new System.Drawing.Size(324, 47);
            this.labShowLoan.TabIndex = 6;
            // 
            // labShowPayment
            // 
            this.labShowPayment.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labShowPayment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labShowPayment.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowPayment.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labShowPayment.Location = new System.Drawing.Point(349, 394);
            this.labShowPayment.Name = "labShowPayment";
            this.labShowPayment.Size = new System.Drawing.Size(324, 47);
            this.labShowPayment.TabIndex = 8;
            // 
            // labShowPMT
            // 
            this.labShowPMT.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labShowPMT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labShowPMT.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowPMT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labShowPMT.Location = new System.Drawing.Point(349, 318);
            this.labShowPMT.Name = "labShowPMT";
            this.labShowPMT.Size = new System.Drawing.Size(324, 47);
            this.labShowPMT.TabIndex = 9;
            // 
            // labShowRate
            // 
            this.labShowRate.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labShowRate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labShowRate.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowRate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labShowRate.Location = new System.Drawing.Point(349, 233);
            this.labShowRate.Name = "labShowRate";
            this.labShowRate.Size = new System.Drawing.Size(324, 47);
            this.labShowRate.TabIndex = 10;
            // 
            // labShowTerm
            // 
            this.labShowTerm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.labShowTerm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labShowTerm.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowTerm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labShowTerm.Location = new System.Drawing.Point(349, 149);
            this.labShowTerm.Name = "labShowTerm";
            this.labShowTerm.Size = new System.Drawing.Size(324, 47);
            this.labShowTerm.TabIndex = 11;
            // 
            // Frm_HW2_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 540);
            this.Controls.Add(this.labShowTerm);
            this.Controls.Add(this.labShowRate);
            this.Controls.Add(this.labShowPMT);
            this.Controls.Add(this.labShowPayment);
            this.Controls.Add(this.labShowLoan);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.labTotalPayment);
            this.Controls.Add(this.labReportPMT);
            this.Controls.Add(this.labReportRate);
            this.Controls.Add(this.labReportTerm);
            this.Controls.Add(this.labReportLoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_HW2_report";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "結果";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labReportLoan;
        private System.Windows.Forms.Label labReportTerm;
        private System.Windows.Forms.Label labReportRate;
        private System.Windows.Forms.Label labReportPMT;
        private System.Windows.Forms.Label labTotalPayment;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.Label labShowLoan;
        private System.Windows.Forms.Label labShowPayment;
        private System.Windows.Forms.Label labShowPMT;
        private System.Windows.Forms.Label labShowRate;
        private System.Windows.Forms.Label labShowTerm;
    }
}