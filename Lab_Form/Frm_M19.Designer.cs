namespace Lab_Form
{
    partial class Frm_M19
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtEmployeeAge = new System.Windows.Forms.TextBox();
            this.labEmployeeName = new System.Windows.Forms.Label();
            this.labEmployeeAge = new System.Windows.Forms.Label();
            this.labShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(100, 281);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 56);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeName.Location = new System.Drawing.Point(242, 113);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(117, 38);
            this.txtEmployeeName.TabIndex = 1;
            // 
            // txtEmployeeAge
            // 
            this.txtEmployeeAge.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEmployeeAge.Location = new System.Drawing.Point(242, 182);
            this.txtEmployeeAge.Name = "txtEmployeeAge";
            this.txtEmployeeAge.Size = new System.Drawing.Size(117, 38);
            this.txtEmployeeAge.TabIndex = 2;
            // 
            // labEmployeeName
            // 
            this.labEmployeeName.AutoSize = true;
            this.labEmployeeName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmployeeName.Location = new System.Drawing.Point(35, 122);
            this.labEmployeeName.Name = "labEmployeeName";
            this.labEmployeeName.Size = new System.Drawing.Size(187, 29);
            this.labEmployeeName.TabIndex = 3;
            this.labEmployeeName.Text = "EmployeeName";
            // 
            // labEmployeeAge
            // 
            this.labEmployeeAge.AutoSize = true;
            this.labEmployeeAge.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEmployeeAge.Location = new System.Drawing.Point(35, 182);
            this.labEmployeeAge.Name = "labEmployeeAge";
            this.labEmployeeAge.Size = new System.Drawing.Size(165, 29);
            this.labEmployeeAge.TabIndex = 4;
            this.labEmployeeAge.Text = "EmployeeAge";
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShow.Location = new System.Drawing.Point(427, 28);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(126, 29);
            this.labShow.TabIndex = 5;
            this.labShow.Text = "Employee:";
            // 
            // Frm_M19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 402);
            this.Controls.Add(this.labShow);
            this.Controls.Add(this.labEmployeeAge);
            this.Controls.Add(this.labEmployeeName);
            this.Controls.Add(this.txtEmployeeAge);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.btnSave);
            this.Name = "Frm_M19";
            this.Text = "Frm_M19";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtEmployeeAge;
        private System.Windows.Forms.Label labEmployeeName;
        private System.Windows.Forms.Label labEmployeeAge;
        private System.Windows.Forms.Label labShow;
    }
}