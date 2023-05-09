namespace Lab_Form
{
    partial class Frm_M12
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
            this.btnCount = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.btnCount2 = new System.Windows.Forms.Button();
            this.btnCount3 = new System.Windows.Forms.Button();
            this.btnLocalVar = new System.Windows.Forms.Button();
            this.btnClassVar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStatic = new System.Windows.Forms.Button();
            this.btnInstanceCount = new System.Windows.Forms.Button();
            this.gpboxStataic = new System.Windows.Forms.GroupBox();
            this.labInstanceCount = new System.Windows.Forms.Label();
            this.labStaticCount = new System.Windows.Forms.Label();
            this.btnOpenFrm_08 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gpboxStataic.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCount.Location = new System.Drawing.Point(123, 133);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(183, 79);
            this.btnCount.TabIndex = 0;
            this.btnCount.Text = "+=, -=,*=, /=, %=";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCount.Location = new System.Drawing.Point(157, 27);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(80, 23);
            this.labCount.TabIndex = 1;
            this.labCount.Text = "Count:0";
            // 
            // btnCount2
            // 
            this.btnCount2.Location = new System.Drawing.Point(122, 241);
            this.btnCount2.Name = "btnCount2";
            this.btnCount2.Size = new System.Drawing.Size(184, 72);
            this.btnCount2.TabIndex = 3;
            this.btnCount2.Text = "++num,--num";
            this.btnCount2.UseVisualStyleBackColor = true;
            this.btnCount2.Click += new System.EventHandler(this.btnCount2_Click);
            // 
            // btnCount3
            // 
            this.btnCount3.Location = new System.Drawing.Point(122, 338);
            this.btnCount3.Name = "btnCount3";
            this.btnCount3.Size = new System.Drawing.Size(184, 72);
            this.btnCount3.TabIndex = 4;
            this.btnCount3.Text = "num++,num--";
            this.btnCount3.UseVisualStyleBackColor = true;
            this.btnCount3.Click += new System.EventHandler(this.btnCount3_Click);
            // 
            // btnLocalVar
            // 
            this.btnLocalVar.Location = new System.Drawing.Point(18, 59);
            this.btnLocalVar.Name = "btnLocalVar";
            this.btnLocalVar.Size = new System.Drawing.Size(143, 25);
            this.btnLocalVar.TabIndex = 5;
            this.btnLocalVar.Text = "Local Var.";
            this.btnLocalVar.UseVisualStyleBackColor = true;
            this.btnLocalVar.Click += new System.EventHandler(this.btnLocalVar_Click);
            // 
            // btnClassVar
            // 
            this.btnClassVar.Location = new System.Drawing.Point(18, 123);
            this.btnClassVar.Name = "btnClassVar";
            this.btnClassVar.Size = new System.Drawing.Size(143, 25);
            this.btnClassVar.TabIndex = 6;
            this.btnClassVar.Text = "Class Var.";
            this.btnClassVar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClassVar);
            this.groupBox1.Controls.Add(this.btnLocalVar);
            this.groupBox1.Location = new System.Drawing.Point(333, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 212);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "變數";
            // 
            // btnStatic
            // 
            this.btnStatic.Location = new System.Drawing.Point(18, 97);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(172, 46);
            this.btnStatic.TabIndex = 9;
            this.btnStatic.Text = "Static";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.btnStatic_Click);
            // 
            // btnInstanceCount
            // 
            this.btnInstanceCount.Location = new System.Drawing.Point(18, 24);
            this.btnInstanceCount.Name = "btnInstanceCount";
            this.btnInstanceCount.Size = new System.Drawing.Size(172, 37);
            this.btnInstanceCount.TabIndex = 8;
            this.btnInstanceCount.Text = "Instance";
            this.btnInstanceCount.UseVisualStyleBackColor = true;
            this.btnInstanceCount.Click += new System.EventHandler(this.btnInstanceCount_Click);
            // 
            // gpboxStataic
            // 
            this.gpboxStataic.Controls.Add(this.btnStatic);
            this.gpboxStataic.Controls.Add(this.btnInstanceCount);
            this.gpboxStataic.Location = new System.Drawing.Point(333, 241);
            this.gpboxStataic.Name = "gpboxStataic";
            this.gpboxStataic.Size = new System.Drawing.Size(214, 187);
            this.gpboxStataic.TabIndex = 10;
            this.gpboxStataic.TabStop = false;
            this.gpboxStataic.Text = "Static";
            // 
            // labInstanceCount
            // 
            this.labInstanceCount.AutoSize = true;
            this.labInstanceCount.Location = new System.Drawing.Point(595, 286);
            this.labInstanceCount.Name = "labInstanceCount";
            this.labInstanceCount.Size = new System.Drawing.Size(52, 15);
            this.labInstanceCount.TabIndex = 11;
            this.labInstanceCount.Text = "Count:0";
            // 
            // labStaticCount
            // 
            this.labStaticCount.AutoSize = true;
            this.labStaticCount.Location = new System.Drawing.Point(595, 354);
            this.labStaticCount.Name = "labStaticCount";
            this.labStaticCount.Size = new System.Drawing.Size(52, 15);
            this.labStaticCount.TabIndex = 12;
            this.labStaticCount.Text = "Count:0";
            // 
            // btnOpenFrm_08
            // 
            this.btnOpenFrm_08.Location = new System.Drawing.Point(598, 382);
            this.btnOpenFrm_08.Name = "btnOpenFrm_08";
            this.btnOpenFrm_08.Size = new System.Drawing.Size(172, 46);
            this.btnOpenFrm_08.TabIndex = 10;
            this.btnOpenFrm_08.Text = "OpenFrm_08";
            this.btnOpenFrm_08.UseVisualStyleBackColor = true;
            this.btnOpenFrm_08.Click += new System.EventHandler(this.btnOpenFrm_08_Click);
            // 
            // Frm_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenFrm_08);
            this.Controls.Add(this.labStaticCount);
            this.Controls.Add(this.labInstanceCount);
            this.Controls.Add(this.gpboxStataic);
            this.Controls.Add(this.btnCount3);
            this.Controls.Add(this.btnCount2);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_M12";
            this.Text = "Frm_M12";
            this.groupBox1.ResumeLayout(false);
            this.gpboxStataic.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button btnCount2;
        private System.Windows.Forms.Button btnCount3;
        private System.Windows.Forms.Button btnLocalVar;
        private System.Windows.Forms.Button btnClassVar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Button btnInstanceCount;
        private System.Windows.Forms.GroupBox gpboxStataic;
        private System.Windows.Forms.Label labInstanceCount;
        private System.Windows.Forms.Label labStaticCount;
        private System.Windows.Forms.Button btnOpenFrm_08;
    }
}