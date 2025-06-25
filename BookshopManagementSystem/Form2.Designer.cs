namespace BookshopManagementSystem
{
    partial class Form2
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.btnOpenCart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTitle.Font = new System.Drawing.Font("Gabriola", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.MintCream;
            this.lblTitle.Location = new System.Drawing.Point(282, -7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(394, 96);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Bookshop Dashboard";
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.Teal;
            this.btnAddBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBook.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAddBook.Location = new System.Drawing.Point(32, 70);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(267, 48);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "Add New Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnEditBook
            // 
            this.btnEditBook.BackColor = System.Drawing.Color.Teal;
            this.btnEditBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditBook.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEditBook.Location = new System.Drawing.Point(325, 70);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(258, 48);
            this.btnEditBook.TabIndex = 2;
            this.btnEditBook.Text = "Edit Selected Book";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.BackColor = System.Drawing.Color.Teal;
            this.btnDeleteBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteBook.Font = new System.Drawing.Font("Cascadia Code SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnDeleteBook.Location = new System.Drawing.Point(610, 70);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(328, 48);
            this.btnDeleteBook.TabIndex = 3;
            this.btnDeleteBook.Text = "Delete Selected Book";
            this.btnDeleteBook.UseVisualStyleBackColor = false;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // dgvBooks
            // 
            this.dgvBooks.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.GridColor = System.Drawing.Color.BurlyWood;
            this.dgvBooks.Location = new System.Drawing.Point(32, 124);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 62;
            this.dgvBooks.RowTemplate.Height = 28;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(906, 380);
            this.dgvBooks.TabIndex = 4;
            // 
            // btnOpenCart
            // 
            this.btnOpenCart.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnOpenCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenCart.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenCart.ForeColor = System.Drawing.SystemColors.Window;
            this.btnOpenCart.Location = new System.Drawing.Point(447, 510);
            this.btnOpenCart.Name = "btnOpenCart";
            this.btnOpenCart.Size = new System.Drawing.Size(491, 78);
            this.btnOpenCart.TabIndex = 5;
            this.btnOpenCart.Text = "Open Cart";
            this.btnOpenCart.UseVisualStyleBackColor = false;
            this.btnOpenCart.Click += new System.EventHandler(this.btnOpenCart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BookshopManagementSystem.Properties.Resources.pngtree_futuristic_library_with_neon_lights_and_bookshelves_image_16123591;
            this.ClientSize = new System.Drawing.Size(950, 630);
            this.Controls.Add(this.btnOpenCart);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnEditBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.Button btnOpenCart;
    }
}