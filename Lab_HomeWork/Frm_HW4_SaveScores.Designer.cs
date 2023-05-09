namespace Lab_HomeWork
{
    partial class Frm_HW4_SaveScores
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
            this.gbScores = new System.Windows.Forms.GroupBox();
            this.labTopAndBtm = new System.Windows.Forms.Label();
            this.labScores = new System.Windows.Forms.Label();
            this.btnShowTopAndBtm = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnShowSavedData = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.labChi = new System.Windows.Forms.Label();
            this.labEng = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChiScore = new System.Windows.Forms.TextBox();
            this.txtEngScore = new System.Windows.Forms.TextBox();
            this.txtMathScore = new System.Windows.Forms.TextBox();
            this.gbScores.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbScores
            // 
            this.gbScores.Controls.Add(this.labTopAndBtm);
            this.gbScores.Controls.Add(this.labScores);
            this.gbScores.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gbScores.Location = new System.Drawing.Point(670, 72);
            this.gbScores.Name = "gbScores";
            this.gbScores.Size = new System.Drawing.Size(521, 594);
            this.gbScores.TabIndex = 0;
            this.gbScores.TabStop = false;
            this.gbScores.Text = "Scores";
            // 
            // labTopAndBtm
            // 
            this.labTopAndBtm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTopAndBtm.Location = new System.Drawing.Point(16, 432);
            this.labTopAndBtm.Name = "labTopAndBtm";
            this.labTopAndBtm.Size = new System.Drawing.Size(494, 145);
            this.labTopAndBtm.TabIndex = 1;
            // 
            // labScores
            // 
            this.labScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labScores.Location = new System.Drawing.Point(16, 61);
            this.labScores.Name = "labScores";
            this.labScores.Size = new System.Drawing.Size(494, 358);
            this.labScores.TabIndex = 0;
            // 
            // btnShowTopAndBtm
            // 
            this.btnShowTopAndBtm.AutoSize = true;
            this.btnShowTopAndBtm.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowTopAndBtm.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowTopAndBtm.Location = new System.Drawing.Point(811, 697);
            this.btnShowTopAndBtm.Name = "btnShowTopAndBtm";
            this.btnShowTopAndBtm.Size = new System.Drawing.Size(372, 86);
            this.btnShowTopAndBtm.TabIndex = 1;
            this.btnShowTopAndBtm.Text = "Show Top and Bottom";
            this.btnShowTopAndBtm.UseVisualStyleBackColor = false;
            this.btnShowTopAndBtm.Click += new System.EventHandler(this.btnShowTopAndBtm_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Info;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(14, 550);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(284, 99);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnShowSavedData
            // 
            this.btnShowSavedData.AutoEllipsis = true;
            this.btnShowSavedData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnShowSavedData.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnShowSavedData.Location = new System.Drawing.Point(319, 550);
            this.btnShowSavedData.Name = "btnShowSavedData";
            this.btnShowSavedData.Size = new System.Drawing.Size(333, 99);
            this.btnShowSavedData.TabIndex = 3;
            this.btnShowSavedData.Text = "Show Saved Scores";
            this.btnShowSavedData.UseVisualStyleBackColor = false;
            this.btnShowSavedData.Click += new System.EventHandler(this.btnShowSavedData_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.Location = new System.Drawing.Point(51, 83);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(116, 40);
            this.labName.TabIndex = 4;
            this.labName.Text = "Name:";
            // 
            // labChi
            // 
            this.labChi.AutoSize = true;
            this.labChi.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labChi.Location = new System.Drawing.Point(51, 200);
            this.labChi.Name = "labChi";
            this.labChi.Size = new System.Drawing.Size(142, 40);
            this.labChi.TabIndex = 5;
            this.labChi.Text = "Chinese:";
            // 
            // labEng
            // 
            this.labEng.AutoSize = true;
            this.labEng.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labEng.Location = new System.Drawing.Point(51, 305);
            this.labEng.Name = "labEng";
            this.labEng.Size = new System.Drawing.Size(130, 40);
            this.labEng.TabIndex = 6;
            this.labEng.Text = "English:";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labMath.Location = new System.Drawing.Point(51, 424);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(104, 40);
            this.labMath.TabIndex = 7;
            this.labMath.Text = "Math:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(246, 83);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(277, 50);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Student";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtChiScore
            // 
            this.txtChiScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChiScore.Location = new System.Drawing.Point(246, 200);
            this.txtChiScore.Name = "txtChiScore";
            this.txtChiScore.Size = new System.Drawing.Size(277, 50);
            this.txtChiScore.TabIndex = 10;
            this.txtChiScore.Text = "0";
            this.txtChiScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtEngScore
            // 
            this.txtEngScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEngScore.Location = new System.Drawing.Point(246, 314);
            this.txtEngScore.Name = "txtEngScore";
            this.txtEngScore.Size = new System.Drawing.Size(277, 50);
            this.txtEngScore.TabIndex = 11;
            this.txtEngScore.Text = "0";
            this.txtEngScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMathScore
            // 
            this.txtMathScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMathScore.Location = new System.Drawing.Point(246, 428);
            this.txtMathScore.Name = "txtMathScore";
            this.txtMathScore.Size = new System.Drawing.Size(277, 50);
            this.txtMathScore.TabIndex = 12;
            this.txtMathScore.Text = "0";
            this.txtMathScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Frm_HW4_SaveScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1213, 834);
            this.Controls.Add(this.txtMathScore);
            this.Controls.Add(this.txtEngScore);
            this.Controls.Add(this.txtChiScore);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labEng);
            this.Controls.Add(this.labChi);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnShowSavedData);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnShowTopAndBtm);
            this.Controls.Add(this.gbScores);
            this.Name = "Frm_HW4_SaveScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scores Struct Form";
            this.gbScores.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScores;
        private System.Windows.Forms.Label labTopAndBtm;
        private System.Windows.Forms.Label labScores;
        private System.Windows.Forms.Button btnShowTopAndBtm;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnShowSavedData;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labChi;
        private System.Windows.Forms.Label labEng;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChiScore;
        private System.Windows.Forms.TextBox txtEngScore;
        private System.Windows.Forms.TextBox txtMathScore;
    }
}