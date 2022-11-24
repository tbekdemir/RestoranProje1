namespace _1._0RestaurantTracking
{
    partial class frmManagerScreen
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
            this.buttonHistory = new System.Windows.Forms.Button();
            this.buttonToday = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ManagerScreen";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonHistory
            // 
            this.buttonHistory.Location = new System.Drawing.Point(162, 28);
            this.buttonHistory.Name = "buttonHistory";
            this.buttonHistory.Size = new System.Drawing.Size(144, 98);
            this.buttonHistory.TabIndex = 1;
            this.buttonHistory.Text = "SİPARİŞLER  (GEÇMİŞ)";
            this.buttonHistory.UseVisualStyleBackColor = true;
            this.buttonHistory.Click += new System.EventHandler(this.buttonHistory_Click);
            // 
            // buttonToday
            // 
            this.buttonToday.Location = new System.Drawing.Point(12, 28);
            this.buttonToday.Name = "buttonToday";
            this.buttonToday.Size = new System.Drawing.Size(144, 98);
            this.buttonToday.TabIndex = 1;
            this.buttonToday.Text = "Siparişler      (BUGÜN)";
            this.buttonToday.UseVisualStyleBackColor = true;
            this.buttonToday.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.Location = new System.Drawing.Point(312, 28);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(144, 98);
            this.buttonStock.TabIndex = 2;
            this.buttonStock.Text = "Stok Takip";
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(381, 6);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 27;
            this.BtnExit.Text = "ÇIKIŞ";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // frmManagerScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 144);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.buttonToday);
            this.Controls.Add(this.buttonHistory);
            this.Controls.Add(this.label1);
            this.Name = "frmManagerScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagerScreen";
            this.Load += new System.EventHandler(this.ManagerScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHistory;
        private System.Windows.Forms.Button buttonToday;
        private System.Windows.Forms.Button buttonStock;
        private System.Windows.Forms.Button BtnExit;
    }
}