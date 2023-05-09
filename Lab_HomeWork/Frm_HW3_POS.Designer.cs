namespace Lab_HomeWork
{
    partial class Frm_HW3_POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HW3_POS));
            this.labTotalPrice = new System.Windows.Forms.Label();
            this.labPayment = new System.Windows.Forms.Label();
            this.labList = new System.Windows.Forms.Label();
            this.plManu = new System.Windows.Forms.Panel();
            this.btnMilleCrepes = new System.Windows.Forms.Button();
            this.btnPuffs = new System.Windows.Forms.Button();
            this.btnNYCheeseCake = new System.Windows.Forms.Button();
            this.btnSwissRoll = new System.Windows.Forms.Button();
            this.labManu = new System.Windows.Forms.Label();
            this.plList = new System.Windows.Forms.Panel();
            this.labShowOrder = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.plTotalPrice = new System.Windows.Forms.Panel();
            this.labShowTotalPrice = new System.Windows.Forms.Label();
            this.plPayby = new System.Windows.Forms.Panel();
            this.labDiscount = new System.Windows.Forms.Label();
            this.btnCreditCard = new System.Windows.Forms.Button();
            this.btnCash = new System.Windows.Forms.Button();
            this.plManu.SuspendLayout();
            this.plList.SuspendLayout();
            this.plTotalPrice.SuspendLayout();
            this.plPayby.SuspendLayout();
            this.SuspendLayout();
            // 
            // labTotalPrice
            // 
            this.labTotalPrice.AutoSize = true;
            this.labTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotalPrice.Location = new System.Drawing.Point(3, 0);
            this.labTotalPrice.Name = "labTotalPrice";
            this.labTotalPrice.Size = new System.Drawing.Size(141, 31);
            this.labTotalPrice.TabIndex = 1;
            this.labTotalPrice.Text = "Total Price:";
            // 
            // labPayment
            // 
            this.labPayment.AutoSize = true;
            this.labPayment.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPayment.Location = new System.Drawing.Point(3, 0);
            this.labPayment.Name = "labPayment";
            this.labPayment.Size = new System.Drawing.Size(96, 31);
            this.labPayment.TabIndex = 2;
            this.labPayment.Text = "Pay by:";
            // 
            // labList
            // 
            this.labList.AutoSize = true;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(3, -1);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(60, 31);
            this.labList.TabIndex = 3;
            this.labList.Text = "List:";
            // 
            // plManu
            // 
            this.plManu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plManu.Controls.Add(this.btnMilleCrepes);
            this.plManu.Controls.Add(this.btnPuffs);
            this.plManu.Controls.Add(this.btnNYCheeseCake);
            this.plManu.Controls.Add(this.btnSwissRoll);
            this.plManu.Controls.Add(this.labManu);
            this.plManu.Font = new System.Drawing.Font("新細明體", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plManu.Location = new System.Drawing.Point(10, 48);
            this.plManu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plManu.Name = "plManu";
            this.plManu.Size = new System.Drawing.Size(308, 390);
            this.plManu.TabIndex = 3;
            // 
            // btnMilleCrepes
            // 
            this.btnMilleCrepes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMilleCrepes.BackgroundImage")));
            this.btnMilleCrepes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMilleCrepes.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMilleCrepes.Location = new System.Drawing.Point(154, 217);
            this.btnMilleCrepes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMilleCrepes.Name = "btnMilleCrepes";
            this.btnMilleCrepes.Size = new System.Drawing.Size(136, 158);
            this.btnMilleCrepes.TabIndex = 8;
            this.btnMilleCrepes.Text = "Mille crepes\n$100";
            this.btnMilleCrepes.UseVisualStyleBackColor = true;
            this.btnMilleCrepes.Click += new System.EventHandler(this.btnMilleCrepes_Click);
            // 
            // btnPuffs
            // 
            this.btnPuffs.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPuffs.BackgroundImage")));
            this.btnPuffs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPuffs.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPuffs.Location = new System.Drawing.Point(12, 217);
            this.btnPuffs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPuffs.Name = "btnPuffs";
            this.btnPuffs.Size = new System.Drawing.Size(136, 158);
            this.btnPuffs.TabIndex = 7;
            this.btnPuffs.Text = "Puffs\n$60";
            this.btnPuffs.UseVisualStyleBackColor = true;
            this.btnPuffs.Click += new System.EventHandler(this.btnPuffs_Click);
            // 
            // btnNYCheeseCake
            // 
            this.btnNYCheeseCake.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNYCheeseCake.BackgroundImage")));
            this.btnNYCheeseCake.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNYCheeseCake.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNYCheeseCake.Location = new System.Drawing.Point(154, 53);
            this.btnNYCheeseCake.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNYCheeseCake.Name = "btnNYCheeseCake";
            this.btnNYCheeseCake.Size = new System.Drawing.Size(136, 158);
            this.btnNYCheeseCake.TabIndex = 6;
            this.btnNYCheeseCake.Text = "NY cheesecake\n$75";
            this.btnNYCheeseCake.UseVisualStyleBackColor = true;
            this.btnNYCheeseCake.Click += new System.EventHandler(this.btnNYCheeseCake_Click);
            // 
            // btnSwissRoll
            // 
            this.btnSwissRoll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSwissRoll.BackgroundImage")));
            this.btnSwissRoll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSwissRoll.Font = new System.Drawing.Font("微軟正黑體", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwissRoll.ForeColor = System.Drawing.Color.Black;
            this.btnSwissRoll.Location = new System.Drawing.Point(12, 53);
            this.btnSwissRoll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSwissRoll.Name = "btnSwissRoll";
            this.btnSwissRoll.Size = new System.Drawing.Size(136, 158);
            this.btnSwissRoll.TabIndex = 5;
            this.btnSwissRoll.Text = "Swiss roll\n$50";
            this.btnSwissRoll.UseVisualStyleBackColor = true;
            this.btnSwissRoll.Click += new System.EventHandler(this.btnSwissRoll_Click);
            // 
            // labManu
            // 
            this.labManu.AutoSize = true;
            this.labManu.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labManu.Location = new System.Drawing.Point(3, 3);
            this.labManu.Name = "labManu";
            this.labManu.Size = new System.Drawing.Size(87, 31);
            this.labManu.TabIndex = 4;
            this.labManu.Text = "Manu:";
            // 
            // plList
            // 
            this.plList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plList.Controls.Add(this.labShowOrder);
            this.plList.Controls.Add(this.btnClear);
            this.plList.Controls.Add(this.labList);
            this.plList.Location = new System.Drawing.Point(691, 48);
            this.plList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plList.Name = "plList";
            this.plList.Size = new System.Drawing.Size(374, 476);
            this.plList.TabIndex = 5;
            // 
            // labShowOrder
            // 
            this.labShowOrder.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labShowOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labShowOrder.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowOrder.Location = new System.Drawing.Point(13, 53);
            this.labShowOrder.Name = "labShowOrder";
            this.labShowOrder.Size = new System.Drawing.Size(345, 335);
            this.labShowOrder.TabIndex = 5;
            this.labShowOrder.Text = "No order";
            this.labShowOrder.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Khaki;
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(228, 404);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 58);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // plTotalPrice
            // 
            this.plTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plTotalPrice.Controls.Add(this.labShowTotalPrice);
            this.plTotalPrice.Controls.Add(this.labTotalPrice);
            this.plTotalPrice.Location = new System.Drawing.Point(331, 48);
            this.plTotalPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plTotalPrice.Name = "plTotalPrice";
            this.plTotalPrice.Size = new System.Drawing.Size(349, 145);
            this.plTotalPrice.TabIndex = 6;
            // 
            // labShowTotalPrice
            // 
            this.labShowTotalPrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labShowTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labShowTotalPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labShowTotalPrice.Location = new System.Drawing.Point(12, 53);
            this.labShowTotalPrice.Name = "labShowTotalPrice";
            this.labShowTotalPrice.Size = new System.Drawing.Size(317, 62);
            this.labShowTotalPrice.TabIndex = 2;
            this.labShowTotalPrice.Text = "NT$0";
            this.labShowTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plPayby
            // 
            this.plPayby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plPayby.Controls.Add(this.labDiscount);
            this.plPayby.Controls.Add(this.btnCreditCard);
            this.plPayby.Controls.Add(this.btnCash);
            this.plPayby.Controls.Add(this.labPayment);
            this.plPayby.Location = new System.Drawing.Point(331, 230);
            this.plPayby.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plPayby.Name = "plPayby";
            this.plPayby.Size = new System.Drawing.Size(349, 208);
            this.plPayby.TabIndex = 7;
            // 
            // labDiscount
            // 
            this.labDiscount.BackColor = System.Drawing.Color.Transparent;
            this.labDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDiscount.ForeColor = System.Drawing.Color.DarkOrange;
            this.labDiscount.Location = new System.Drawing.Point(181, 138);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(156, 29);
            this.labDiscount.TabIndex = 5;
            this.labDiscount.Text = "10% discount!";
            // 
            // btnCreditCard
            // 
            this.btnCreditCard.BackColor = System.Drawing.Color.Orange;
            this.btnCreditCard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCreditCard.Location = new System.Drawing.Point(181, 78);
            this.btnCreditCard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreditCard.Name = "btnCreditCard";
            this.btnCreditCard.Size = new System.Drawing.Size(156, 65);
            this.btnCreditCard.TabIndex = 4;
            this.btnCreditCard.Text = "Credit Card";
            this.btnCreditCard.UseVisualStyleBackColor = false;
            this.btnCreditCard.Click += new System.EventHandler(this.btnCreditCard_Click);
            // 
            // btnCash
            // 
            this.btnCash.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCash.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCash.Location = new System.Drawing.Point(13, 78);
            this.btnCash.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCash.Name = "btnCash";
            this.btnCash.Size = new System.Drawing.Size(156, 65);
            this.btnCash.TabIndex = 3;
            this.btnCash.Text = "Cash";
            this.btnCash.UseVisualStyleBackColor = false;
            this.btnCash.Click += new System.EventHandler(this.btnCash_Click);
            // 
            // Frm_HW3_POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1081, 542);
            this.Controls.Add(this.plPayby);
            this.Controls.Add(this.plTotalPrice);
            this.Controls.Add(this.plList);
            this.Controls.Add(this.plManu);
            this.Name = "Frm_HW3_POS";
            this.Text = "POS";
            this.plManu.ResumeLayout(false);
            this.plManu.PerformLayout();
            this.plList.ResumeLayout(false);
            this.plList.PerformLayout();
            this.plTotalPrice.ResumeLayout(false);
            this.plTotalPrice.PerformLayout();
            this.plPayby.ResumeLayout(false);
            this.plPayby.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labTotalPrice;
        private System.Windows.Forms.Label labPayment;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Panel plManu;
        private System.Windows.Forms.Button btnMilleCrepes;
        private System.Windows.Forms.Button btnPuffs;
        private System.Windows.Forms.Button btnNYCheeseCake;
        private System.Windows.Forms.Button btnSwissRoll;
        private System.Windows.Forms.Label labManu;
        private System.Windows.Forms.Panel plList;
        private System.Windows.Forms.Panel plTotalPrice;
        private System.Windows.Forms.Panel plPayby;
        private System.Windows.Forms.Label labShowTotalPrice;
        private System.Windows.Forms.Button btnCash;
        private System.Windows.Forms.Label labDiscount;
        private System.Windows.Forms.Button btnCreditCard;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label labShowOrder;
    }
}