namespace Lab_Form
{
    partial class Frm_M04
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
            this.btnOpenHelloForm = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnReturnMethod = new System.Windows.Forms.Button();
            this.btnMyClass = new System.Windows.Forms.Button();
            this.btnEnc = new System.Windows.Forms.Button();
            this.btnPartialClass = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenHelloForm
            // 
            this.btnOpenHelloForm.Location = new System.Drawing.Point(297, 47);
            this.btnOpenHelloForm.Name = "btnOpenHelloForm";
            this.btnOpenHelloForm.Size = new System.Drawing.Size(185, 50);
            this.btnOpenHelloForm.TabIndex = 0;
            this.btnOpenHelloForm.Text = "Open Hello Form";
            this.btnOpenHelloForm.UseVisualStyleBackColor = true;
            this.btnOpenHelloForm.Click += new System.EventHandler(this.btnOpenHelloForm_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(297, 133);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(185, 48);
            this.btnMethod.TabIndex = 1;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnReturnMethod
            // 
            this.btnReturnMethod.Location = new System.Drawing.Point(297, 209);
            this.btnReturnMethod.Name = "btnReturnMethod";
            this.btnReturnMethod.Size = new System.Drawing.Size(185, 51);
            this.btnReturnMethod.TabIndex = 2;
            this.btnReturnMethod.Text = "ReturnMethod";
            this.btnReturnMethod.UseVisualStyleBackColor = true;
            this.btnReturnMethod.Click += new System.EventHandler(this.btnReturnMethod_Click);
            // 
            // btnMyClass
            // 
            this.btnMyClass.Location = new System.Drawing.Point(301, 301);
            this.btnMyClass.Name = "btnMyClass";
            this.btnMyClass.Size = new System.Drawing.Size(181, 43);
            this.btnMyClass.TabIndex = 3;
            this.btnMyClass.Text = "MyClass";
            this.btnMyClass.UseVisualStyleBackColor = true;
            this.btnMyClass.Click += new System.EventHandler(this.btnMyClass_Click);
            // 
            // btnEnc
            // 
            this.btnEnc.Location = new System.Drawing.Point(301, 375);
            this.btnEnc.Name = "btnEnc";
            this.btnEnc.Size = new System.Drawing.Size(181, 43);
            this.btnEnc.TabIndex = 4;
            this.btnEnc.Text = "Enc";
            this.btnEnc.UseVisualStyleBackColor = true;
            this.btnEnc.Click += new System.EventHandler(this.btnEnc_Click);
            // 
            // btnPartialClass
            // 
            this.btnPartialClass.Location = new System.Drawing.Point(59, 51);
            this.btnPartialClass.Name = "btnPartialClass";
            this.btnPartialClass.Size = new System.Drawing.Size(181, 43);
            this.btnPartialClass.TabIndex = 5;
            this.btnPartialClass.Text = "Partial Class";
            this.btnPartialClass.UseVisualStyleBackColor = true;
            this.btnPartialClass.Click += new System.EventHandler(this.btnPartialClass_Click);
            // 
            // btnMember
            // 
            this.btnMember.Location = new System.Drawing.Point(59, 133);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(181, 43);
            this.btnMember.TabIndex = 6;
            this.btnMember.Text = "Member";
            this.btnMember.UseVisualStyleBackColor = true;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // Frm_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnPartialClass);
            this.Controls.Add(this.btnEnc);
            this.Controls.Add(this.btnMyClass);
            this.Controls.Add(this.btnReturnMethod);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.btnOpenHelloForm);
            this.Name = "Frm_M04";
            this.Text = "Frm_M04";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenHelloForm;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnReturnMethod;
        private System.Windows.Forms.Button btnMyClass;
        private System.Windows.Forms.Button btnEnc;
        private System.Windows.Forms.Button btnPartialClass;
        private System.Windows.Forms.Button btnMember;
    }
}