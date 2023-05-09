namespace Lab_Form
{
    partial class Frm_M32
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
            this.btnStringBuilder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStringBuilder
            // 
            this.btnStringBuilder.Location = new System.Drawing.Point(57, 67);
            this.btnStringBuilder.Name = "btnStringBuilder";
            this.btnStringBuilder.Size = new System.Drawing.Size(155, 79);
            this.btnStringBuilder.TabIndex = 0;
            this.btnStringBuilder.Text = "String Builder";
            this.btnStringBuilder.UseVisualStyleBackColor = true;
            this.btnStringBuilder.Click += new System.EventHandler(this.btnStringBuilder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 79);
            this.button1.TabIndex = 1;
            this.button1.Text = "Path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_M32
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStringBuilder);
            this.Name = "Frm_M32";
            this.Text = "Frm_M32";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStringBuilder;
        private System.Windows.Forms.Button button1;
    }
}