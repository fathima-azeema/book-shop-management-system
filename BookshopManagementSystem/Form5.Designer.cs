namespace BookshopManagementSystem
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblOrderSummary = new System.Windows.Forms.Label();
            this.lblCardInfo = new System.Windows.Forms.Label();
            this.lblCashMessage = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.btnConfirmPayment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbCard = new System.Windows.Forms.RadioButton();
            this.rdbCash = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblOrderSummary
            // 
            this.lblOrderSummary.AutoSize = true;
            this.lblOrderSummary.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderSummary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOrderSummary.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderSummary.ForeColor = System.Drawing.Color.White;
            this.lblOrderSummary.Location = new System.Drawing.Point(36, 29);
            this.lblOrderSummary.Name = "lblOrderSummary";
            this.lblOrderSummary.Size = new System.Drawing.Size(72, 27);
            this.lblOrderSummary.TabIndex = 0;
            this.lblOrderSummary.Text = "label";
            // 
            // lblCardInfo
            // 
            this.lblCardInfo.AutoSize = true;
            this.lblCardInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblCardInfo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.lblCardInfo.Font = new System.Drawing.Font("Cascadia Code", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardInfo.Location = new System.Drawing.Point(275, 178);
            this.lblCardInfo.Name = "lblCardInfo";
            this.lblCardInfo.Size = new System.Drawing.Size(266, 43);
            this.lblCardInfo.TabIndex = 1;
            this.lblCardInfo.Text = "Card Detailes";
            // 
            // lblCashMessage
            // 
            this.lblCashMessage.AutoSize = true;
            this.lblCashMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblCashMessage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCashMessage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCashMessage.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCashMessage.ForeColor = System.Drawing.Color.Red;
            this.lblCashMessage.Location = new System.Drawing.Point(163, 409);
            this.lblCashMessage.Name = "lblCashMessage";
            this.lblCashMessage.Size = new System.Drawing.Size(68, 26);
            this.lblCashMessage.TabIndex = 2;
            this.lblCashMessage.Text = "label3";
            this.lblCashMessage.Visible = false;
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardNumber.Location = new System.Drawing.Point(354, 232);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(301, 30);
            this.txtCardNumber.TabIndex = 9;
            // 
            // txtCardName
            // 
            this.txtCardName.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardName.Location = new System.Drawing.Point(354, 276);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(301, 30);
            this.txtCardName.TabIndex = 10;
            // 
            // txtExpiry
            // 
            this.txtExpiry.Font = new System.Drawing.Font("SimSun", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExpiry.Location = new System.Drawing.Point(354, 321);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(301, 30);
            this.txtExpiry.TabIndex = 11;
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnConfirmPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmPayment.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmPayment.Location = new System.Drawing.Point(156, 451);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(499, 57);
            this.btnConfirmPayment.TabIndex = 12;
            this.btnConfirmPayment.Text = "Confirm Payment";
            this.btnConfirmPayment.UseVisualStyleBackColor = false;
            this.btnConfirmPayment.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 29);
            this.label1.TabIndex = 13;
            this.label1.Text = "Card Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(156, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Card Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(156, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Expiry Date";
            // 
            // rdbCard
            // 
            this.rdbCard.AutoSize = true;
            this.rdbCard.BackColor = System.Drawing.Color.Transparent;
            this.rdbCard.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbCard.Font = new System.Drawing.Font("Javanese Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCard.ForeColor = System.Drawing.Color.White;
            this.rdbCard.Location = new System.Drawing.Point(143, 121);
            this.rdbCard.Name = "rdbCard";
            this.rdbCard.Size = new System.Drawing.Size(159, 54);
            this.rdbCard.TabIndex = 4;
            this.rdbCard.TabStop = true;
            this.rdbCard.Text = "Pay by Card";
            this.rdbCard.UseVisualStyleBackColor = false;
            this.rdbCard.CheckedChanged += new System.EventHandler(this.rdbCard_CheckedChanged);
            // 
            // rdbCash
            // 
            this.rdbCash.AutoSize = true;
            this.rdbCash.BackColor = System.Drawing.Color.Transparent;
            this.rdbCash.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.rdbCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbCash.Font = new System.Drawing.Font("Javanese Text", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCash.ForeColor = System.Drawing.Color.White;
            this.rdbCash.Location = new System.Drawing.Point(143, 79);
            this.rdbCash.Name = "rdbCash";
            this.rdbCash.Size = new System.Drawing.Size(206, 54);
            this.rdbCash.TabIndex = 3;
            this.rdbCash.TabStop = true;
            this.rdbCash.Text = "Cash on Delivery";
            this.rdbCash.UseVisualStyleBackColor = false;
            this.rdbCash.CheckedChanged += new System.EventHandler(this.rdbCash_CheckedChanged);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookshopManagementSystem.Properties.Resources.istockphoto_583822488_612x612;
            this.ClientSize = new System.Drawing.Size(800, 592);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmPayment);
            this.Controls.Add(this.txtExpiry);
            this.Controls.Add(this.txtCardName);
            this.Controls.Add(this.txtCardNumber);
            this.Controls.Add(this.rdbCard);
            this.Controls.Add(this.rdbCash);
            this.Controls.Add(this.lblCashMessage);
            this.Controls.Add(this.lblCardInfo);
            this.Controls.Add(this.lblOrderSummary);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderSummary;
        private System.Windows.Forms.Label lblCardInfo;
        private System.Windows.Forms.Label lblCashMessage;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.Button btnConfirmPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbCard;
        private System.Windows.Forms.RadioButton rdbCash;
    }
}
