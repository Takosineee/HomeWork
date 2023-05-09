namespace Lab_Form
{
    partial class Frm_M28_Overload
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnForint = new System.Windows.Forms.Button();
            this.btnGenericMethod = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnForint);
            this.groupBox1.Location = new System.Drawing.Point(107, 128);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(414, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Overload";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(84, 317);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "for string";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnForstring_Click);
            // 
            // btnForint
            // 
            this.btnForint.Location = new System.Drawing.Point(84, 136);
            this.btnForint.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnForint.Name = "btnForint";
            this.btnForint.Size = new System.Drawing.Size(232, 82);
            this.btnForint.TabIndex = 0;
            this.btnForint.Text = "for int";
            this.btnForint.UseVisualStyleBackColor = true;
            this.btnForint.Click += new System.EventHandler(this.btnForint_Click);
            // 
            // btnGenericMethod
            // 
            this.btnGenericMethod.Location = new System.Drawing.Point(623, 264);
            this.btnGenericMethod.Margin = new System.Windows.Forms.Padding(5);
            this.btnGenericMethod.Name = "btnGenericMethod";
            this.btnGenericMethod.Size = new System.Drawing.Size(232, 82);
            this.btnGenericMethod.TabIndex = 2;
            this.btnGenericMethod.Text = "Generic Method";
            this.btnGenericMethod.UseVisualStyleBackColor = true;
            this.btnGenericMethod.Click += new System.EventHandler(this.btnGenericMethod_Click);
            // 
            // Frm_M28_Overload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 720);
            this.Controls.Add(this.btnGenericMethod);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Frm_M28_Overload";
            this.Text = "Frm_M28_Overload";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnForint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGenericMethod;
    }
}