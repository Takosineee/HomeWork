namespace Lab_HomeWork
{
    partial class Frm_HW6_StuGradeList
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
            this.lsvShowGrade = new System.Windows.Forms.ListView();
            this.lsvShowStatistics = new System.Windows.Forms.ListView();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gpSearch = new System.Windows.Forms.GroupBox();
            this.labfrom = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labTo = new System.Windows.Forms.Label();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.gpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsvShowGrade
            // 
            this.lsvShowGrade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lsvShowGrade.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lsvShowGrade.GridLines = true;
            this.lsvShowGrade.HideSelection = false;
            this.lsvShowGrade.Location = new System.Drawing.Point(305, 46);
            this.lsvShowGrade.Margin = new System.Windows.Forms.Padding(2);
            this.lsvShowGrade.Name = "lsvShowGrade";
            this.lsvShowGrade.Size = new System.Drawing.Size(580, 341);
            this.lsvShowGrade.TabIndex = 34;
            this.lsvShowGrade.UseCompatibleStateImageBehavior = false;
            this.lsvShowGrade.View = System.Windows.Forms.View.Details;
            // 
            // lsvShowStatistics
            // 
            this.lsvShowStatistics.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lsvShowStatistics.HideSelection = false;
            this.lsvShowStatistics.Location = new System.Drawing.Point(305, 389);
            this.lsvShowStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.lsvShowStatistics.Name = "lsvShowStatistics";
            this.lsvShowStatistics.Size = new System.Drawing.Size(581, 202);
            this.lsvShowStatistics.TabIndex = 33;
            this.lsvShowStatistics.UseCompatibleStateImageBehavior = false;
            this.lsvShowStatistics.View = System.Windows.Forms.View.Details;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnStatistics.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistics.Location = new System.Drawing.Point(912, 608);
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(2);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(180, 36);
            this.btnStatistics.TabIndex = 30;
            this.btnStatistics.Text = "Statistics";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightYellow;
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(59, 247);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 36);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(133, 198);
            this.txtMath.Margin = new System.Windows.Forms.Padding(2);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(123, 34);
            this.txtMath.TabIndex = 27;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(133, 147);
            this.txtEnglish.Margin = new System.Windows.Forms.Padding(2);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(123, 34);
            this.txtEnglish.TabIndex = 26;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(133, 100);
            this.txtChinese.Margin = new System.Windows.Forms.Padding(2);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(123, 34);
            this.txtChinese.TabIndex = 25;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(133, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(123, 34);
            this.txtName.TabIndex = 24;
            // 
            // labEnglish
            // 
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(37, 152);
            this.labEnglish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(95, 26);
            this.labEnglish.TabIndex = 23;
            this.labEnglish.Text = "English:";
            // 
            // labChinese
            // 
            this.labChinese.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(37, 105);
            this.labChinese.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(92, 26);
            this.labChinese.TabIndex = 22;
            this.labChinese.Text = "Chinese:";
            // 
            // labMath
            // 
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(37, 203);
            this.labMath.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(68, 26);
            this.labMath.TabIndex = 21;
            this.labMath.Text = "Math:";
            // 
            // labName
            // 
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(37, 51);
            this.labName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(68, 26);
            this.labName.TabIndex = 20;
            this.labName.Text = "Name:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.LightYellow;
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(59, 293);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(180, 36);
            this.btnInsert.TabIndex = 35;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRemoveAt.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemoveAt.Location = new System.Drawing.Point(59, 340);
            this.btnRemoveAt.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(180, 36);
            this.btnRemoveAt.TabIndex = 36;
            this.btnRemoveAt.Text = "Remove 1st item";
            this.btnRemoveAt.UseVisualStyleBackColor = false;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(58, 552);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 36);
            this.btnClear.TabIndex = 37;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gpSearch
            // 
            this.gpSearch.Controls.Add(this.labfrom);
            this.gpSearch.Controls.Add(this.btnSearch);
            this.gpSearch.Controls.Add(this.labTo);
            this.gpSearch.Controls.Add(this.txtMax);
            this.gpSearch.Controls.Add(this.txtMin);
            this.gpSearch.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpSearch.Location = new System.Drawing.Point(41, 389);
            this.gpSearch.Name = "gpSearch";
            this.gpSearch.Size = new System.Drawing.Size(222, 136);
            this.gpSearch.TabIndex = 38;
            this.gpSearch.TabStop = false;
            this.gpSearch.Text = "\'Chinese\' grades:";
            // 
            // labfrom
            // 
            this.labfrom.AutoSize = true;
            this.labfrom.Location = new System.Drawing.Point(11, 42);
            this.labfrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labfrom.Name = "labfrom";
            this.labfrom.Size = new System.Drawing.Size(49, 22);
            this.labfrom.TabIndex = 40;
            this.labfrom.Text = "from";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(17, 85);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(180, 36);
            this.btnSearch.TabIndex = 39;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labTo
            // 
            this.labTo.Location = new System.Drawing.Point(123, 42);
            this.labTo.Name = "labTo";
            this.labTo.Size = new System.Drawing.Size(29, 27);
            this.labTo.TabIndex = 2;
            this.labTo.Text = "to";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(152, 39);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(56, 30);
            this.txtMax.TabIndex = 1;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(64, 39);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(56, 30);
            this.txtMin.TabIndex = 0;
            // 
            // Frm_HW6_StuGradeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.gpSearch);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lsvShowGrade);
            this.Controls.Add(this.lsvShowStatistics);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_HW6_StuGradeList";
            this.Text = "Student Grades List";
            this.gpSearch.ResumeLayout(false);
            this.gpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lsvShowGrade;
        private System.Windows.Forms.ListView lsvShowStatistics;
        private System.Windows.Forms.Button btnStatistics;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gpSearch;
        private System.Windows.Forms.Label labTo;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labfrom;
    }
}