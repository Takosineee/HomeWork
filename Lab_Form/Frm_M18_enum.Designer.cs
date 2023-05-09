namespace Lab_Form
{
    partial class Frm_M18_enum
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
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnValidation_var = new System.Windows.Forms.Button();
            this.btnValidation_const = new System.Windows.Forms.Button();
            this.btnValidation_enum = new System.Windows.Forms.Button();
            this.btnValidation_switch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Enabled = false;
            this.btnProduct.Location = new System.Drawing.Point(95, 52);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(151, 72);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnValidation_var
            // 
            this.btnValidation_var.Location = new System.Drawing.Point(443, 61);
            this.btnValidation_var.Name = "btnValidation_var";
            this.btnValidation_var.Size = new System.Drawing.Size(148, 45);
            this.btnValidation_var.TabIndex = 1;
            this.btnValidation_var.Text = "Validation_var";
            this.btnValidation_var.UseVisualStyleBackColor = true;
            // 
            // btnValidation_const
            // 
            this.btnValidation_const.Location = new System.Drawing.Point(443, 143);
            this.btnValidation_const.Name = "btnValidation_const";
            this.btnValidation_const.Size = new System.Drawing.Size(148, 45);
            this.btnValidation_const.TabIndex = 2;
            this.btnValidation_const.Text = "Validation_const";
            this.btnValidation_const.UseVisualStyleBackColor = true;
            // 
            // btnValidation_enum
            // 
            this.btnValidation_enum.Location = new System.Drawing.Point(443, 235);
            this.btnValidation_enum.Name = "btnValidation_enum";
            this.btnValidation_enum.Size = new System.Drawing.Size(148, 45);
            this.btnValidation_enum.TabIndex = 3;
            this.btnValidation_enum.Text = "Validation_enum";
            this.btnValidation_enum.UseVisualStyleBackColor = true;
            this.btnValidation_enum.Click += new System.EventHandler(this.btnValidation3_Click);
            // 
            // btnValidation_switch
            // 
            this.btnValidation_switch.Location = new System.Drawing.Point(443, 322);
            this.btnValidation_switch.Name = "btnValidation_switch";
            this.btnValidation_switch.Size = new System.Drawing.Size(148, 45);
            this.btnValidation_switch.TabIndex = 4;
            this.btnValidation_switch.Text = "Validation_switch";
            this.btnValidation_switch.UseVisualStyleBackColor = true;
            this.btnValidation_switch.Click += new System.EventHandler(this.btnValidation_switch_Click);
            // 
            // Frm_M18_enum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnValidation_switch);
            this.Controls.Add(this.btnValidation_enum);
            this.Controls.Add(this.btnValidation_const);
            this.Controls.Add(this.btnValidation_var);
            this.Controls.Add(this.btnProduct);
            this.Name = "Frm_M18_enum";
            this.Text = "Frm_M18_enum";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnValidation_var;
        private System.Windows.Forms.Button btnValidation_const;
        private System.Windows.Forms.Button btnValidation_enum;
        private System.Windows.Forms.Button btnValidation_switch;
    }
}