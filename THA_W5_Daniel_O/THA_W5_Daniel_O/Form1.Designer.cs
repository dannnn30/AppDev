namespace THA_W5_Daniel_O
{
    partial class Form1
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
            this.label_product = new System.Windows.Forms.Label();
            this.label_category = new System.Windows.Forms.Label();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_filter = new System.Windows.Forms.Button();
            this.combox_product = new System.Windows.Forms.ComboBox();
            this.dataGridView_product = new System.Windows.Forms.DataGridView();
            this.dataGridView_category = new System.Windows.Forms.DataGridView();
            this.label_nama = new System.Windows.Forms.Label();
            this.tebox_namaCategory = new System.Windows.Forms.TextBox();
            this.btn_addCategory = new System.Windows.Forms.Button();
            this.btn_removeCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tebox_namaProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.combox_category = new System.Windows.Forms.ComboBox();
            this.tebox_price = new System.Windows.Forms.TextBox();
            this.tebox_stock = new System.Windows.Forms.TextBox();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_removeProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_product
            // 
            this.label_product.AutoSize = true;
            this.label_product.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_product.Location = new System.Drawing.Point(64, 35);
            this.label_product.Name = "label_product";
            this.label_product.Size = new System.Drawing.Size(133, 32);
            this.label_product.TabIndex = 0;
            this.label_product.Text = "Product";
            this.label_product.Click += new System.EventHandler(this.label_product_Click);
            // 
            // label_category
            // 
            this.label_category.AutoSize = true;
            this.label_category.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_category.Location = new System.Drawing.Point(940, 35);
            this.label_category.Name = "label_category";
            this.label_category.Size = new System.Drawing.Size(150, 32);
            this.label_category.TabIndex = 1;
            this.label_category.Text = "Category";
            // 
            // btn_all
            // 
            this.btn_all.Location = new System.Drawing.Point(504, 67);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(67, 39);
            this.btn_all.TabIndex = 2;
            this.btn_all.TabStop = false;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = true;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(577, 67);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(107, 39);
            this.btn_filter.TabIndex = 3;
            this.btn_filter.TabStop = false;
            this.btn_filter.Text = "Filter";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // combox_product
            // 
            this.combox_product.Enabled = false;
            this.combox_product.FormattingEnabled = true;
            this.combox_product.Location = new System.Drawing.Point(690, 71);
            this.combox_product.Name = "combox_product";
            this.combox_product.Size = new System.Drawing.Size(152, 33);
            this.combox_product.TabIndex = 4;
            this.combox_product.SelectedIndexChanged += new System.EventHandler(this.combox_product_SelectedIndexChanged);
            // 
            // dataGridView_product
            // 
            this.dataGridView_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_product.Location = new System.Drawing.Point(46, 116);
            this.dataGridView_product.Name = "dataGridView_product";
            this.dataGridView_product.RowHeadersVisible = false;
            this.dataGridView_product.RowHeadersWidth = 82;
            this.dataGridView_product.RowTemplate.Height = 33;
            this.dataGridView_product.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_product.Size = new System.Drawing.Size(796, 543);
            this.dataGridView_product.TabIndex = 5;
            // 
            // dataGridView_category
            // 
            this.dataGridView_category.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_category.Location = new System.Drawing.Point(920, 116);
            this.dataGridView_category.Name = "dataGridView_category";
            this.dataGridView_category.RowHeadersVisible = false;
            this.dataGridView_category.RowHeadersWidth = 80;
            this.dataGridView_category.RowTemplate.Height = 33;
            this.dataGridView_category.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_category.Size = new System.Drawing.Size(435, 411);
            this.dataGridView_category.TabIndex = 6;
            // 
            // label_nama
            // 
            this.label_nama.AutoSize = true;
            this.label_nama.Location = new System.Drawing.Point(920, 533);
            this.label_nama.Name = "label_nama";
            this.label_nama.Size = new System.Drawing.Size(80, 25);
            this.label_nama.TabIndex = 7;
            this.label_nama.Text = "Nama: ";
            // 
            // tebox_namaCategory
            // 
            this.tebox_namaCategory.Location = new System.Drawing.Point(1007, 533);
            this.tebox_namaCategory.Name = "tebox_namaCategory";
            this.tebox_namaCategory.Size = new System.Drawing.Size(348, 31);
            this.tebox_namaCategory.TabIndex = 8;
            // 
            // btn_addCategory
            // 
            this.btn_addCategory.Location = new System.Drawing.Point(1068, 575);
            this.btn_addCategory.Name = "btn_addCategory";
            this.btn_addCategory.Size = new System.Drawing.Size(138, 89);
            this.btn_addCategory.TabIndex = 9;
            this.btn_addCategory.TabStop = false;
            this.btn_addCategory.Text = "Add\r\nCategory\r\n";
            this.btn_addCategory.UseVisualStyleBackColor = true;
            this.btn_addCategory.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_removeCategory
            // 
            this.btn_removeCategory.Location = new System.Drawing.Point(1212, 575);
            this.btn_removeCategory.Name = "btn_removeCategory";
            this.btn_removeCategory.Size = new System.Drawing.Size(143, 89);
            this.btn_removeCategory.TabIndex = 10;
            this.btn_removeCategory.TabStop = false;
            this.btn_removeCategory.Text = "Remove\r\nCategory\r\n";
            this.btn_removeCategory.UseVisualStyleBackColor = true;
            this.btn_removeCategory.Click += new System.EventHandler(this.btn_removeCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 729);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nama: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 779);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Category: ";
            // 
            // tebox_namaProduct
            // 
            this.tebox_namaProduct.Location = new System.Drawing.Point(127, 726);
            this.tebox_namaProduct.Name = "tebox_namaProduct";
            this.tebox_namaProduct.Size = new System.Drawing.Size(554, 31);
            this.tebox_namaProduct.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 823);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 865);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Stock: ";
            // 
            // combox_category
            // 
            this.combox_category.FormattingEnabled = true;
            this.combox_category.Location = new System.Drawing.Point(127, 771);
            this.combox_category.Name = "combox_category";
            this.combox_category.Size = new System.Drawing.Size(179, 33);
            this.combox_category.TabIndex = 16;
            // 
            // tebox_price
            // 
            this.tebox_price.Location = new System.Drawing.Point(127, 817);
            this.tebox_price.Name = "tebox_price";
            this.tebox_price.Size = new System.Drawing.Size(179, 31);
            this.tebox_price.TabIndex = 17;
            this.tebox_price.TextChanged += new System.EventHandler(this.tebox_price_TextChanged);
            this.tebox_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tebox_price_KeyPress);
            // 
            // tebox_stock
            // 
            this.tebox_stock.Location = new System.Drawing.Point(127, 859);
            this.tebox_stock.Name = "tebox_stock";
            this.tebox_stock.Size = new System.Drawing.Size(179, 31);
            this.tebox_stock.TabIndex = 18;
            this.tebox_stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tebox_stock_KeyPress);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Location = new System.Drawing.Point(441, 794);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(117, 77);
            this.btn_editProduct.TabIndex = 20;
            this.btn_editProduct.TabStop = false;
            this.btn_editProduct.Text = "Edit\r\nProduct\r\n";
            this.btn_editProduct.UseVisualStyleBackColor = true;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(321, 794);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(114, 77);
            this.btn_addProduct.TabIndex = 19;
            this.btn_addProduct.TabStop = false;
            this.btn_addProduct.Text = "Add\r\nProduct\r\n";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_removeProduct
            // 
            this.btn_removeProduct.Location = new System.Drawing.Point(564, 797);
            this.btn_removeProduct.Name = "btn_removeProduct";
            this.btn_removeProduct.Size = new System.Drawing.Size(117, 77);
            this.btn_removeProduct.TabIndex = 21;
            this.btn_removeProduct.TabStop = false;
            this.btn_removeProduct.Text = "Remove\r\nProduct";
            this.btn_removeProduct.UseVisualStyleBackColor = true;
            this.btn_removeProduct.Click += new System.EventHandler(this.btn_removeProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MingLiU-ExtB", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 678);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Details";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::THA_W5_Daniel_O.Properties.Resources.download_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(1114, 674);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 284);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1396, 903);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_removeProduct);
            this.Controls.Add(this.btn_editProduct);
            this.Controls.Add(this.btn_addProduct);
            this.Controls.Add(this.tebox_stock);
            this.Controls.Add(this.tebox_price);
            this.Controls.Add(this.combox_category);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tebox_namaProduct);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_removeCategory);
            this.Controls.Add(this.btn_addCategory);
            this.Controls.Add(this.tebox_namaCategory);
            this.Controls.Add(this.label_nama);
            this.Controls.Add(this.dataGridView_category);
            this.Controls.Add(this.dataGridView_product);
            this.Controls.Add(this.combox_product);
            this.Controls.Add(this.btn_filter);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.label_category);
            this.Controls.Add(this.label_product);
            this.Name = "Form1";
            this.Text = "Blink Shop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_product;
        private System.Windows.Forms.Label label_category;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.ComboBox combox_product;
        private System.Windows.Forms.DataGridView dataGridView_product;
        private System.Windows.Forms.DataGridView dataGridView_category;
        private System.Windows.Forms.Label label_nama;
        private System.Windows.Forms.TextBox tebox_namaCategory;
        private System.Windows.Forms.Button btn_addCategory;
        private System.Windows.Forms.Button btn_removeCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tebox_namaProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combox_category;
        private System.Windows.Forms.TextBox tebox_price;
        private System.Windows.Forms.TextBox tebox_stock;
        private System.Windows.Forms.Button btn_editProduct;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_removeProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

