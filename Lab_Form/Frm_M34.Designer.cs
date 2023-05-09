namespace Lab_Form
{
    partial class Frm_M34
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
            this.btnStreamReader = new System.Windows.Forms.Button();
            this.txtStreamReader = new System.Windows.Forms.TextBox();
            this.btnStreamWriter = new System.Windows.Forms.Button();
            this.btnDeBug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStreamReader
            // 
            this.btnStreamReader.Location = new System.Drawing.Point(26, 38);
            this.btnStreamReader.Name = "btnStreamReader";
            this.btnStreamReader.Size = new System.Drawing.Size(154, 53);
            this.btnStreamReader.TabIndex = 0;
            this.btnStreamReader.Text = "Stream Reader";
            this.btnStreamReader.UseVisualStyleBackColor = true;
            this.btnStreamReader.Click += new System.EventHandler(this.btnStreamReader_Click);
            // 
            // txtStreamReader
            // 
            this.txtStreamReader.Location = new System.Drawing.Point(210, 32);
            this.txtStreamReader.Multiline = true;
            this.txtStreamReader.Name = "txtStreamReader";
            this.txtStreamReader.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStreamReader.Size = new System.Drawing.Size(568, 388);
            this.txtStreamReader.TabIndex = 1;
            // 
            // btnStreamWriter
            // 
            this.btnStreamWriter.Location = new System.Drawing.Point(26, 114);
            this.btnStreamWriter.Name = "btnStreamWriter";
            this.btnStreamWriter.Size = new System.Drawing.Size(154, 53);
            this.btnStreamWriter.TabIndex = 2;
            this.btnStreamWriter.Text = "Stream Writer";
            this.btnStreamWriter.UseVisualStyleBackColor = true;
            this.btnStreamWriter.Click += new System.EventHandler(this.btnStreamWriter_Click);
            // 
            // btnDeBug
            // 
            this.btnDeBug.Location = new System.Drawing.Point(26, 296);
            this.btnDeBug.Name = "btnDeBug";
            this.btnDeBug.Size = new System.Drawing.Size(154, 53);
            this.btnDeBug.TabIndex = 3;
            this.btnDeBug.Text = "中斷模式";
            this.btnDeBug.UseVisualStyleBackColor = true;
            this.btnDeBug.Click += new System.EventHandler(this.btnDeBug_Click);
            // 
            // Frm_M34
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeBug);
            this.Controls.Add(this.btnStreamWriter);
            this.Controls.Add(this.txtStreamReader);
            this.Controls.Add(this.btnStreamReader);
            this.Name = "Frm_M34";
            this.Text = "Frm_M34";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStreamReader;
        private System.Windows.Forms.TextBox txtStreamReader;
        private System.Windows.Forms.Button btnStreamWriter;
        private System.Windows.Forms.Button btnDeBug;
    }
}