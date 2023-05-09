namespace Lab_Form
{
    partial class Frm_M16
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
            this.btnPassbyValueType = new System.Windows.Forms.Button();
            this.btnPassbyReferenceType = new System.Windows.Forms.Button();
            this.btnRef = new System.Windows.Forms.Button();
            this.btnOutPut = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPassbyValueType
            // 
            this.btnPassbyValueType.Location = new System.Drawing.Point(41, 57);
            this.btnPassbyValueType.Name = "btnPassbyValueType";
            this.btnPassbyValueType.Size = new System.Drawing.Size(201, 54);
            this.btnPassbyValueType.TabIndex = 0;
            this.btnPassbyValueType.Text = "Pass by Value Type";
            this.btnPassbyValueType.UseVisualStyleBackColor = true;
            this.btnPassbyValueType.Click += new System.EventHandler(this.btnPassbyValueType_Click);
            // 
            // btnPassbyReferenceType
            // 
            this.btnPassbyReferenceType.Location = new System.Drawing.Point(41, 157);
            this.btnPassbyReferenceType.Name = "btnPassbyReferenceType";
            this.btnPassbyReferenceType.Size = new System.Drawing.Size(201, 54);
            this.btnPassbyReferenceType.TabIndex = 1;
            this.btnPassbyReferenceType.Text = "Pass by Reference Type";
            this.btnPassbyReferenceType.UseVisualStyleBackColor = true;
            this.btnPassbyReferenceType.Click += new System.EventHandler(this.btnPassbyReferenceType_Click);
            // 
            // btnRef
            // 
            this.btnRef.Location = new System.Drawing.Point(41, 258);
            this.btnRef.Name = "btnRef";
            this.btnRef.Size = new System.Drawing.Size(201, 54);
            this.btnRef.TabIndex = 2;
            this.btnRef.Text = "Ref";
            this.btnRef.UseVisualStyleBackColor = true;
            this.btnRef.Click += new System.EventHandler(this.btnRef_Click);
            // 
            // btnOutPut
            // 
            this.btnOutPut.Location = new System.Drawing.Point(41, 347);
            this.btnOutPut.Name = "btnOutPut";
            this.btnOutPut.Size = new System.Drawing.Size(201, 54);
            this.btnOutPut.TabIndex = 3;
            this.btnOutPut.Text = "OutPut";
            this.btnOutPut.UseVisualStyleBackColor = true;
            this.btnOutPut.Click += new System.EventHandler(this.btnOutPut_Click);
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(312, 57);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(134, 54);
            this.btnParams.TabIndex = 4;
            this.btnParams.Text = "Params";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // Frm_M16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnOutPut);
            this.Controls.Add(this.btnRef);
            this.Controls.Add(this.btnPassbyReferenceType);
            this.Controls.Add(this.btnPassbyValueType);
            this.Name = "Frm_M16";
            this.Text = "Frm_M16";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPassbyValueType;
        private System.Windows.Forms.Button btnPassbyReferenceType;
        private System.Windows.Forms.Button btnRef;
        private System.Windows.Forms.Button btnOutPut;
        private System.Windows.Forms.Button btnParams;
    }
}