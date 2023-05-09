namespace Lab_Form
{
    partial class Frm_M02_HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SayHello = new System.Windows.Forms.Button();
            this.EngName1 = new System.Windows.Forms.TextBox();
            this.labEngName = new System.Windows.Forms.Label();
            this.Name1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labSex = new System.Windows.Forms.Label();
            this.Sex1 = new System.Windows.Forms.TextBox();
            this.Zod1 = new System.Windows.Forms.TextBox();
            this.labZod = new System.Windows.Forms.Label();
            this.SayHi_click = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SayHello
            // 
            this.SayHello.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SayHello.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SayHello.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SayHello.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SayHello.Location = new System.Drawing.Point(340, 492);
            this.SayHello.Margin = new System.Windows.Forms.Padding(4);
            this.SayHello.Name = "SayHello";
            this.SayHello.Size = new System.Drawing.Size(146, 59);
            this.SayHello.TabIndex = 0;
            this.SayHello.Text = "SayHello";
            this.SayHello.UseVisualStyleBackColor = false;
            this.SayHello.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // EngName1
            // 
            this.EngName1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EngName1.Location = new System.Drawing.Point(420, 194);
            this.EngName1.Margin = new System.Windows.Forms.Padding(4);
            this.EngName1.Name = "EngName1";
            this.EngName1.Size = new System.Drawing.Size(196, 38);
            this.EngName1.TabIndex = 9;
            // 
            // labEngName
            // 
            this.labEngName.AutoSize = true;
            this.labEngName.BackColor = System.Drawing.Color.Transparent;
            this.labEngName.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEngName.Location = new System.Drawing.Point(179, 198);
            this.labEngName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labEngName.Name = "labEngName";
            this.labEngName.Size = new System.Drawing.Size(168, 29);
            this.labEngName.TabIndex = 8;
            this.labEngName.Text = "English Name:";
            this.labEngName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Name1
            // 
            this.Name1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name1.Location = new System.Drawing.Point(420, 84);
            this.Name1.Margin = new System.Windows.Forms.Padding(4);
            this.Name1.Name = "Name1";
            this.Name1.Size = new System.Drawing.Size(196, 38);
            this.Name1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(179, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "請輸入姓名:";
            // 
            // labSex
            // 
            this.labSex.AutoSize = true;
            this.labSex.BackColor = System.Drawing.Color.Transparent;
            this.labSex.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSex.Location = new System.Drawing.Point(179, 301);
            this.labSex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labSex.Name = "labSex";
            this.labSex.Size = new System.Drawing.Size(64, 29);
            this.labSex.TabIndex = 10;
            this.labSex.Text = "性別:";
            // 
            // Sex1
            // 
            this.Sex1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sex1.Location = new System.Drawing.Point(420, 290);
            this.Sex1.Margin = new System.Windows.Forms.Padding(4);
            this.Sex1.Name = "Sex1";
            this.Sex1.Size = new System.Drawing.Size(196, 38);
            this.Sex1.TabIndex = 11;
            // 
            // Zod1
            // 
            this.Zod1.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Zod1.Location = new System.Drawing.Point(420, 388);
            this.Zod1.Margin = new System.Windows.Forms.Padding(4);
            this.Zod1.Name = "Zod1";
            this.Zod1.Size = new System.Drawing.Size(196, 38);
            this.Zod1.TabIndex = 13;
            // 
            // labZod
            // 
            this.labZod.AutoSize = true;
            this.labZod.BackColor = System.Drawing.Color.Transparent;
            this.labZod.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labZod.Location = new System.Drawing.Point(179, 399);
            this.labZod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labZod.Name = "labZod";
            this.labZod.Size = new System.Drawing.Size(64, 29);
            this.labZod.TabIndex = 12;
            this.labZod.Text = "星座:";
            // 
            // SayHi_click
            // 
            this.SayHi_click.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SayHi_click.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.SayHi_click.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.SayHi_click.Location = new System.Drawing.Point(530, 492);
            this.SayHi_click.Margin = new System.Windows.Forms.Padding(4);
            this.SayHi_click.Name = "SayHi_click";
            this.SayHi_click.Size = new System.Drawing.Size(163, 59);
            this.SayHi_click.TabIndex = 14;
            this.SayHi_click.Text = "SayHi";
            this.SayHi_click.UseVisualStyleBackColor = false;
            this.SayHi_click.Click += new System.EventHandler(this.btnSayHi_Click);
            // 
            // Frm_M02_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1003, 564);
            this.Controls.Add(this.SayHi_click);
            this.Controls.Add(this.Zod1);
            this.Controls.Add(this.labZod);
            this.Controls.Add(this.Sex1);
            this.Controls.Add(this.labSex);
            this.Controls.Add(this.EngName1);
            this.Controls.Add(this.labEngName);
            this.Controls.Add(this.Name1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SayHello);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_M02_HelloForm";
            this.Text = "Frm_M02_HelloForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SayHello;
        private System.Windows.Forms.TextBox EngName1;
        private System.Windows.Forms.Label labEngName;
        private System.Windows.Forms.TextBox Name1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labSex;
        private System.Windows.Forms.TextBox Sex1;
        private System.Windows.Forms.TextBox Zod1;
        private System.Windows.Forms.Label labZod;
        private System.Windows.Forms.Button SayHi_click;
    }
}

