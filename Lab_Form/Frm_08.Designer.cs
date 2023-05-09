namespace Lab_Form
{
    partial class Frm_08
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
            this.btnRegisterEvent = new System.Windows.Forms.Button();
            this.btnRegisterEvent01 = new System.Windows.Forms.Button();
            this.btnRegisterEvent02 = new System.Windows.Forms.Button();
            this.btnDismiss = new System.Windows.Forms.Button();
            this.btnMessageBox = new System.Windows.Forms.Button();
            this.btncallHelloForm = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnShowStaticNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegisterEvent
            // 
            this.btnRegisterEvent.Location = new System.Drawing.Point(158, 62);
            this.btnRegisterEvent.Name = "btnRegisterEvent";
            this.btnRegisterEvent.Size = new System.Drawing.Size(161, 60);
            this.btnRegisterEvent.TabIndex = 0;
            this.btnRegisterEvent.Text = "Register Event";
            this.btnRegisterEvent.UseVisualStyleBackColor = true;
            this.btnRegisterEvent.Click += new System.EventHandler(this.btnRegisterEvent_Click);
            // 
            // btnRegisterEvent01
            // 
            this.btnRegisterEvent01.Location = new System.Drawing.Point(158, 158);
            this.btnRegisterEvent01.Name = "btnRegisterEvent01";
            this.btnRegisterEvent01.Size = new System.Drawing.Size(161, 68);
            this.btnRegisterEvent01.TabIndex = 1;
            this.btnRegisterEvent01.Text = "Register Event01";
            this.btnRegisterEvent01.UseVisualStyleBackColor = true;
            // 
            // btnRegisterEvent02
            // 
            this.btnRegisterEvent02.Location = new System.Drawing.Point(158, 264);
            this.btnRegisterEvent02.Name = "btnRegisterEvent02";
            this.btnRegisterEvent02.Size = new System.Drawing.Size(161, 60);
            this.btnRegisterEvent02.TabIndex = 2;
            this.btnRegisterEvent02.Text = "Register Event02";
            this.btnRegisterEvent02.UseVisualStyleBackColor = true;
            // 
            // btnDismiss
            // 
            this.btnDismiss.Location = new System.Drawing.Point(402, 60);
            this.btnDismiss.Name = "btnDismiss";
            this.btnDismiss.Size = new System.Drawing.Size(163, 62);
            this.btnDismiss.TabIndex = 3;
            this.btnDismiss.Text = "解除註冊";
            this.btnDismiss.UseVisualStyleBackColor = true;
            this.btnDismiss.Click += new System.EventHandler(this.btnDismiss_Click);
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.Location = new System.Drawing.Point(402, 158);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(163, 58);
            this.btnMessageBox.TabIndex = 4;
            this.btnMessageBox.Text = "MessageBox";
            this.btnMessageBox.UseVisualStyleBackColor = true;
            this.btnMessageBox.Click += new System.EventHandler(this.btnMessageBox_Click);
            // 
            // btncallHelloForm
            // 
            this.btncallHelloForm.Location = new System.Drawing.Point(402, 264);
            this.btncallHelloForm.Name = "btncallHelloForm";
            this.btncallHelloForm.Size = new System.Drawing.Size(163, 60);
            this.btncallHelloForm.TabIndex = 5;
            this.btncallHelloForm.Text = "callHelloForm";
            this.btncallHelloForm.UseVisualStyleBackColor = true;
            this.btncallHelloForm.Click += new System.EventHandler(this.btncallHelloForm_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(158, 357);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(161, 56);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "測試";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // btnShowStaticNum
            // 
            this.btnShowStaticNum.Location = new System.Drawing.Point(404, 357);
            this.btnShowStaticNum.Name = "btnShowStaticNum";
            this.btnShowStaticNum.Size = new System.Drawing.Size(161, 56);
            this.btnShowStaticNum.TabIndex = 7;
            this.btnShowStaticNum.Text = "Show Static Number";
            this.btnShowStaticNum.UseVisualStyleBackColor = true;
            this.btnShowStaticNum.Click += new System.EventHandler(this.btnShowStaticNum_Click);
            // 
            // Frm_08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnShowStaticNum);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btncallHelloForm);
            this.Controls.Add(this.btnMessageBox);
            this.Controls.Add(this.btnDismiss);
            this.Controls.Add(this.btnRegisterEvent02);
            this.Controls.Add(this.btnRegisterEvent01);
            this.Controls.Add(this.btnRegisterEvent);
            this.Name = "Frm_08";
            this.Text = "Frm_08";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterEvent;
        private System.Windows.Forms.Button btnRegisterEvent01;
        private System.Windows.Forms.Button btnRegisterEvent02;
        private System.Windows.Forms.Button btnDismiss;
        private System.Windows.Forms.Button btnMessageBox;
        private System.Windows.Forms.Button btncallHelloForm;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnShowStaticNum;
    }
}