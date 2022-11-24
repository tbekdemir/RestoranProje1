namespace _1._0RestaurantTracking
{
    partial class frmStaffScreen
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
            this.btnAnaYemek = new System.Windows.Forms.Button();
            this.btnIcecek = new System.Windows.Forms.Button();
            this.btnTatlı = new System.Windows.Forms.Button();
            this.gridMenu = new System.Windows.Forms.DataGridView();
            this.gridTickets = new System.Windows.Forms.DataGridView();
            this.btnTciketCreate = new System.Windows.Forms.Button();
            this.LblProductId = new System.Windows.Forms.Label();
            this.lblCatagory = new System.Windows.Forms.Label();
            this.lblProdctName = new System.Windows.Forms.Label();
            this.cbCustomerStaff = new System.Windows.Forms.ComboBox();
            this.TxtProductId = new System.Windows.Forms.TextBox();
            this.cbStaffStaff = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gBOXTicket = new System.Windows.Forms.GroupBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.lblProductPiece = new System.Windows.Forms.Label();
            this.txtPiece = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTickets)).BeginInit();
            this.gBOXTicket.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAnaYemek
            // 
            this.btnAnaYemek.Location = new System.Drawing.Point(432, 31);
            this.btnAnaYemek.Name = "btnAnaYemek";
            this.btnAnaYemek.Size = new System.Drawing.Size(160, 76);
            this.btnAnaYemek.TabIndex = 0;
            this.btnAnaYemek.Text = "Ana Yemekler";
            this.btnAnaYemek.UseVisualStyleBackColor = true;
            this.btnAnaYemek.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIcecek
            // 
            this.btnIcecek.Location = new System.Drawing.Point(432, 121);
            this.btnIcecek.Name = "btnIcecek";
            this.btnIcecek.Size = new System.Drawing.Size(160, 76);
            this.btnIcecek.TabIndex = 0;
            this.btnIcecek.Text = "İçecekler";
            this.btnIcecek.UseVisualStyleBackColor = true;
            this.btnIcecek.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTatlı
            // 
            this.btnTatlı.Location = new System.Drawing.Point(432, 215);
            this.btnTatlı.Name = "btnTatlı";
            this.btnTatlı.Size = new System.Drawing.Size(160, 76);
            this.btnTatlı.TabIndex = 0;
            this.btnTatlı.Text = "Tatlılar";
            this.btnTatlı.UseVisualStyleBackColor = true;
            this.btnTatlı.Click += new System.EventHandler(this.button3_Click);
            // 
            // gridMenu
            // 
            this.gridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMenu.Location = new System.Drawing.Point(598, 33);
            this.gridMenu.Name = "gridMenu";
            this.gridMenu.ReadOnly = true;
            this.gridMenu.RowHeadersWidth = 51;
            this.gridMenu.RowTemplate.Height = 24;
            this.gridMenu.Size = new System.Drawing.Size(396, 258);
            this.gridMenu.TabIndex = 1;
            this.gridMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridMenu_CellContentClick);
            // 
            // gridTickets
            // 
            this.gridTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTickets.Location = new System.Drawing.Point(12, 374);
            this.gridTickets.Name = "gridTickets";
            this.gridTickets.ReadOnly = true;
            this.gridTickets.RowHeadersWidth = 51;
            this.gridTickets.RowTemplate.Height = 24;
            this.gridTickets.Size = new System.Drawing.Size(982, 335);
            this.gridTickets.TabIndex = 1;
            this.gridTickets.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridTickets_CellContentClick);
            // 
            // btnTciketCreate
            // 
            this.btnTciketCreate.Location = new System.Drawing.Point(172, 282);
            this.btnTciketCreate.Name = "btnTciketCreate";
            this.btnTciketCreate.Size = new System.Drawing.Size(149, 59);
            this.btnTciketCreate.TabIndex = 2;
            this.btnTciketCreate.Text = "Sipariş Oluştur";
            this.btnTciketCreate.UseVisualStyleBackColor = true;
            this.btnTciketCreate.Click += new System.EventHandler(this.btnTciketCreate_Click);
            // 
            // LblProductId
            // 
            this.LblProductId.AutoSize = true;
            this.LblProductId.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblProductId.Location = new System.Drawing.Point(36, 131);
            this.LblProductId.Name = "LblProductId";
            this.LblProductId.Size = new System.Drawing.Size(62, 16);
            this.LblProductId.TabIndex = 4;
            this.LblProductId.Text = "Ürün ID :";
            // 
            // lblCatagory
            // 
            this.lblCatagory.AutoSize = true;
            this.lblCatagory.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCatagory.Location = new System.Drawing.Point(36, 97);
            this.lblCatagory.Name = "lblCatagory";
            this.lblCatagory.Size = new System.Drawing.Size(86, 16);
            this.lblCatagory.TabIndex = 7;
            this.lblCatagory.Text = "Müşteri Adı :";
            // 
            // lblProdctName
            // 
            this.lblProdctName.AutoSize = true;
            this.lblProdctName.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProdctName.Location = new System.Drawing.Point(36, 61);
            this.lblProdctName.Name = "lblProdctName";
            this.lblProdctName.Size = new System.Drawing.Size(141, 16);
            this.lblProdctName.TabIndex = 5;
            this.lblProdctName.Text = "Siparşi Alan Garson :";
            // 
            // cbCustomerStaff
            // 
            this.cbCustomerStaff.FormattingEnabled = true;
            this.cbCustomerStaff.Location = new System.Drawing.Point(6, 46);
            this.cbCustomerStaff.Name = "cbCustomerStaff";
            this.cbCustomerStaff.Size = new System.Drawing.Size(121, 24);
            this.cbCustomerStaff.TabIndex = 11;
            this.cbCustomerStaff.SelectedIndexChanged += new System.EventHandler(this.cbCustomerStaff_SelectedIndexChanged);
            // 
            // TxtProductId
            // 
            this.TxtProductId.Location = new System.Drawing.Point(6, 80);
            this.TxtProductId.Name = "TxtProductId";
            this.TxtProductId.Size = new System.Drawing.Size(121, 22);
            this.TxtProductId.TabIndex = 9;
            // 
            // cbStaffStaff
            // 
            this.cbStaffStaff.FormattingEnabled = true;
            this.cbStaffStaff.Location = new System.Drawing.Point(6, 5);
            this.cbStaffStaff.Name = "cbStaffStaff";
            this.cbStaffStaff.Size = new System.Drawing.Size(121, 24);
            this.cbStaffStaff.TabIndex = 11;
            this.cbStaffStaff.SelectedIndexChanged += new System.EventHandler(this.cbStaffStaff_SelectedIndexChanged);
            // 
            // gBOXTicket
            // 
            this.gBOXTicket.Controls.Add(this.txtPiece);
            this.gBOXTicket.Controls.Add(this.cbStaffStaff);
            this.gBOXTicket.Controls.Add(this.TxtProductId);
            this.gBOXTicket.Controls.Add(this.cbCustomerStaff);
            this.gBOXTicket.Location = new System.Drawing.Point(183, 53);
            this.gBOXTicket.Name = "gBOXTicket";
            this.gBOXTicket.Size = new System.Drawing.Size(138, 144);
            this.gBOXTicket.TabIndex = 12;
            this.gBOXTicket.TabStop = false;
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(919, 4);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 27;
            this.BtnExit.Text = "ÇIKIŞ";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // lblProductPiece
            // 
            this.lblProductPiece.AutoSize = true;
            this.lblProductPiece.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProductPiece.Location = new System.Drawing.Point(36, 167);
            this.lblProductPiece.Name = "lblProductPiece";
            this.lblProductPiece.Size = new System.Drawing.Size(44, 16);
            this.lblProductPiece.TabIndex = 4;
            this.lblProductPiece.Text = "Adet :";
            // 
            // txtPiece
            // 
            this.txtPiece.Location = new System.Drawing.Point(6, 108);
            this.txtPiece.Name = "txtPiece";
            this.txtPiece.Size = new System.Drawing.Size(121, 22);
            this.txtPiece.TabIndex = 12;
            // 
            // frmStaffScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 790);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.gBOXTicket);
            this.Controls.Add(this.lblProductPiece);
            this.Controls.Add(this.LblProductId);
            this.Controls.Add(this.lblCatagory);
            this.Controls.Add(this.lblProdctName);
            this.Controls.Add(this.btnTciketCreate);
            this.Controls.Add(this.gridTickets);
            this.Controls.Add(this.gridMenu);
            this.Controls.Add(this.btnTatlı);
            this.Controls.Add(this.btnIcecek);
            this.Controls.Add(this.btnAnaYemek);
            this.Name = "frmStaffScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStaffScreen";
            this.Load += new System.EventHandler(this.frmStaffScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTickets)).EndInit();
            this.gBOXTicket.ResumeLayout(false);
            this.gBOXTicket.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnaYemek;
        private System.Windows.Forms.Button btnIcecek;
        private System.Windows.Forms.Button btnTatlı;
        public System.Windows.Forms.DataGridView gridMenu;
        public System.Windows.Forms.DataGridView gridTickets;
        private System.Windows.Forms.Button btnTciketCreate;
        private System.Windows.Forms.Label LblProductId;
        private System.Windows.Forms.Label lblCatagory;
        private System.Windows.Forms.Label lblProdctName;
        private System.Windows.Forms.ComboBox cbCustomerStaff;
        private System.Windows.Forms.TextBox TxtProductId;
        private System.Windows.Forms.ComboBox cbStaffStaff;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gBOXTicket;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.TextBox txtPiece;
        private System.Windows.Forms.Label lblProductPiece;
    }
}