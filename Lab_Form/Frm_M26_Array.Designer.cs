namespace Lab_Form
{
    partial class Frm_M26_Array
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
            this.btnCreateArray = new System.Windows.Forms.Button();
            this.btnArray2 = new System.Windows.Forms.Button();
            this.btnSystemArray = new System.Windows.Forms.Button();
            this.btnReturnArray = new System.Windows.Forms.Button();
            this.btnforeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateArray
            // 
            this.btnCreateArray.Location = new System.Drawing.Point(75, 98);
            this.btnCreateArray.Name = "btnCreateArray";
            this.btnCreateArray.Size = new System.Drawing.Size(146, 52);
            this.btnCreateArray.TabIndex = 0;
            this.btnCreateArray.Text = "Array";
            this.btnCreateArray.UseVisualStyleBackColor = true;
            this.btnCreateArray.Click += new System.EventHandler(this.btnCreateArray_Click);
            // 
            // btnArray2
            // 
            this.btnArray2.Location = new System.Drawing.Point(75, 219);
            this.btnArray2.Name = "btnArray2";
            this.btnArray2.Size = new System.Drawing.Size(146, 52);
            this.btnArray2.TabIndex = 1;
            this.btnArray2.Text = "Array2";
            this.btnArray2.UseVisualStyleBackColor = true;
            // 
            // btnSystemArray
            // 
            this.btnSystemArray.Location = new System.Drawing.Point(75, 324);
            this.btnSystemArray.Name = "btnSystemArray";
            this.btnSystemArray.Size = new System.Drawing.Size(146, 52);
            this.btnSystemArray.TabIndex = 2;
            this.btnSystemArray.Text = "建立類別陣列";
            this.btnSystemArray.UseVisualStyleBackColor = true;
            this.btnSystemArray.Click += new System.EventHandler(this.btnSystemArray_Click);
            // 
            // btnReturnArray
            // 
            this.btnReturnArray.Location = new System.Drawing.Point(278, 98);
            this.btnReturnArray.Name = "btnReturnArray";
            this.btnReturnArray.Size = new System.Drawing.Size(146, 52);
            this.btnReturnArray.TabIndex = 3;
            this.btnReturnArray.Text = "傳回陣列值";
            this.btnReturnArray.UseVisualStyleBackColor = true;
            this.btnReturnArray.Click += new System.EventHandler(this.btnReturnArray_Click);
            // 
            // btnforeach
            // 
            this.btnforeach.Location = new System.Drawing.Point(278, 219);
            this.btnforeach.Name = "btnforeach";
            this.btnforeach.Size = new System.Drawing.Size(146, 52);
            this.btnforeach.TabIndex = 4;
            this.btnforeach.Text = "foreach";
            this.btnforeach.UseVisualStyleBackColor = true;
            this.btnforeach.Click += new System.EventHandler(this.btnforeach_Click);
            // 
            // Frm_M26_Array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnforeach);
            this.Controls.Add(this.btnReturnArray);
            this.Controls.Add(this.btnSystemArray);
            this.Controls.Add(this.btnArray2);
            this.Controls.Add(this.btnCreateArray);
            this.Name = "Frm_M26_Array";
            this.Text = "Frm_M26_Array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateArray;
        private System.Windows.Forms.Button btnArray2;
        private System.Windows.Forms.Button btnSystemArray;
        private System.Windows.Forms.Button btnReturnArray;
        private System.Windows.Forms.Button btnforeach;
    }
}