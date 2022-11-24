namespace _1._0RestaurantTracking
{
    partial class frmStock
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblProdctName = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lplStock = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.cbCatagory = new System.Windows.Forms.ComboBox();
            this.btnProductCreate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.DgProducts = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stok Takip Ekranı";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(41, 32);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(121, 22);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // lblProdctName
            // 
            this.lblProdctName.AutoSize = true;
            this.lblProdctName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProdctName.Location = new System.Drawing.Point(42, 47);
            this.lblProdctName.Name = "lblProdctName";
            this.lblProdctName.Size = new System.Drawing.Size(70, 16);
            this.lblProdctName.TabIndex = 2;
            this.lblProdctName.Text = "Ürün Adı :";
            this.lblProdctName.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCatagory.Location = new System.Drawing.Point(42, 83);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(69, 16);
            this.lblCatagory.TabIndex = 3;
            this.lblCatagory.Text = "Katagori :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrice.Location = new System.Drawing.Point(42, 117);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(46, 16);
            this.lblPrice.TabIndex = 2;
            this.lblPrice.Text = "Fiyat :";
            this.lblPrice.Click += new System.EventHandler(this.label2_Click);
            // 
            // lplStock
            // 
            this.lplStock.AutoSize = true;
            this.lplStock.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lplStock.Location = new System.Drawing.Point(42, 151);
            this.lplStock.Name = "lplStock";
            this.lplStock.Size = new System.Drawing.Size(76, 16);
            this.lplStock.TabIndex = 3;
            this.lplStock.Text = "Stok Adet :";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(41, 102);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 22);
            this.txtPrice.TabIndex = 4;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(41, 136);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(121, 22);
            this.txtStock.TabIndex = 5;
            // 
            // cbCatagory
            // 
            this.cbCatagory.FormattingEnabled = true;
            this.cbCatagory.Location = new System.Drawing.Point(41, 66);
            this.cbCatagory.Name = "cbCatagory";
            this.cbCatagory.Size = new System.Drawing.Size(121, 24);
            this.cbCatagory.TabIndex = 6;
            this.cbCatagory.SelectedIndexChanged += new System.EventHandler(this.cbCatagory_SelectedIndexChanged);
            // 
            // btnProductCreate
            // 
            this.btnProductCreate.Location = new System.Drawing.Point(165, 191);
            this.btnProductCreate.Name = "btnProductCreate";
            this.btnProductCreate.Size = new System.Drawing.Size(121, 38);
            this.btnProductCreate.TabIndex = 7;
            this.btnProductCreate.Text = "Ürün Oluştur";
            this.btnProductCreate.UseVisualStyleBackColor = true;
            this.btnProductCreate.Click += new System.EventHandler(this.btnProductCreate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtProductName);
            this.groupBox1.Controls.Add(this.cbCatagory);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Location = new System.Drawing.Point(117, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(169, 173);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(535, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 27;
            this.BtnExit.Text = "ÇIKIŞ";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(454, 12);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 29;
            this.BtnBack.Text = "GERİ";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // DgProducts
            // 
            this.DgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgProducts.Location = new System.Drawing.Point(15, 235);
            this.DgProducts.Name = "DgProducts";
            this.DgProducts.RowHeadersWidth = 51;
            this.DgProducts.RowTemplate.Height = 24;
            this.DgProducts.Size = new System.Drawing.Size(595, 186);
            this.DgProducts.TabIndex = 30;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.DgProducts);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnProductCreate);
            this.Controls.Add(this.lplStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.lblProdctName);
            this.Controls.Add(this.label1);
            this.Name = "frmStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.frmStock_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblProdctName;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lplStock;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.ComboBox cbCatagory;
        private System.Windows.Forms.Button btnProductCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.DataGridView DgProducts;
    }
}