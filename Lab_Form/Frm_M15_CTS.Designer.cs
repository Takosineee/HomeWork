namespace Lab_Form
{
    partial class Frm_M15_CTS
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
            this.btnValueType = new System.Windows.Forms.Button();
            this.btnReferenceType = new System.Windows.Forms.Button();
            this.txtReferenceType = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnValueType
            // 
            this.btnValueType.Location = new System.Drawing.Point(52, 35);
            this.btnValueType.Name = "btnValueType";
            this.btnValueType.Size = new System.Drawing.Size(130, 60);
            this.btnValueType.TabIndex = 0;
            this.btnValueType.Text = "Value Type";
            this.btnValueType.UseVisualStyleBackColor = true;
            this.btnValueType.Click += new System.EventHandler(this.btnStack_Click);
            // 
            // btnReferenceType
            // 
            this.btnReferenceType.Location = new System.Drawing.Point(52, 231);
            this.btnReferenceType.Name = "btnReferenceType";
            this.btnReferenceType.Size = new System.Drawing.Size(130, 49);
            this.btnReferenceType.TabIndex = 1;
            this.btnReferenceType.Text = "Reference Type";
            this.btnReferenceType.UseVisualStyleBackColor = true;
            this.btnReferenceType.Click += new System.EventHandler(this.btnReferenceType_Click);
            // 
            // txtReferenceType
            // 
            this.txtReferenceType.Location = new System.Drawing.Point(52, 177);
            this.txtReferenceType.Name = "txtReferenceType";
            this.txtReferenceType.Size = new System.Drawing.Size(130, 25);
            this.txtReferenceType.TabIndex = 2;
            // 
            // Frm_M15_CTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtReferenceType);
            this.Controls.Add(this.btnReferenceType);
            this.Controls.Add(this.btnValueType);
            this.Name = "Frm_M15_CTS";
            this.Text = "Frm_15_CTS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnValueType;
        private System.Windows.Forms.Button btnReferenceType;
        private System.Windows.Forms.TextBox txtReferenceType;
    }
}