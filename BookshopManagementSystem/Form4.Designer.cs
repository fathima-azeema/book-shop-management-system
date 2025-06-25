namespace BookshopManagementSystem
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblShowTotal = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblShowPrice = new System.Windows.Forms.Label();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Impact", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Image = global::BookshopManagementSystem.Properties.Resources.pngtree_smoky_glowing_waves_in_the_dark_picture_image_1899520;
            this.label1.Location = new System.Drawing.Point(215, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = " Order and Payment";
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblBookTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBookTitle.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblBookTitle.Location = new System.Drawing.Point(118, 95);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(159, 35);
            this.lblBookTitle.TabIndex = 1;
            this.lblBookTitle.Text = "Book Title:";
            this.lblBookTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.BackColor = System.Drawing.Color.Transparent;
            this.lblQuantity.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblQuantity.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblQuantity.Location = new System.Drawing.Point(142, 158);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(137, 35);
            this.lblQuantity.TabIndex = 2;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblTotal.Location = new System.Drawing.Point(144, 258);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(135, 35);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total: Rs.";
            // 
            // cmbBooks
            // 
            this.cmbBooks.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(323, 99);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(321, 33);
            this.cmbBooks.TabIndex = 4;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DarkGreen;
            this.btnPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPay.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.Info;
            this.btnPay.Image = global::BookshopManagementSystem.Properties.Resources.pngtree_smoky_glowing_waves_in_the_dark_picture_image_1899520;
            this.btnPay.Location = new System.Drawing.Point(118, 361);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(533, 73);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay Now";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click_1);
            // 
            // lblShowTotal
            // 
            this.lblShowTotal.AutoSize = true;
            this.lblShowTotal.Location = new System.Drawing.Point(302, 269);
            this.lblShowTotal.Name = "lblShowTotal";
            this.lblShowTotal.Size = new System.Drawing.Size(0, 20);
            this.lblShowTotal.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.Transparent;
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrice.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblPrice.Location = new System.Drawing.Point(187, 210);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(92, 35);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price:";
            this.lblPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblShowPrice
            // 
            this.lblShowPrice.AutoSize = true;
            this.lblShowPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblShowPrice.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowPrice.ForeColor = System.Drawing.Color.Red;
            this.lblShowPrice.Location = new System.Drawing.Point(323, 212);
            this.lblShowPrice.Name = "lblShowPrice";
            this.lblShowPrice.Size = new System.Drawing.Size(76, 34);
            this.lblShowPrice.TabIndex = 11;
            this.lblShowPrice.Text = "Price:";
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Location = new System.Drawing.Point(323, 158);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(321, 33);
            this.cmbQuantity.TabIndex = 12;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookshopManagementSystem.Properties.Resources.b2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(782, 486);
            this.Controls.Add(this.cmbQuantity);
            this.Controls.Add(this.lblShowPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblShowTotal);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.cmbBooks);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbBooks;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblShowTotal;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblShowPrice;
        private System.Windows.Forms.ComboBox cmbQuantity;


    }
}