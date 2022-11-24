namespace _1._0RestaurantTracking
{
    partial class frmToday
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.restaurantTrackingDBDataSet = new _1._0RestaurantTracking.RestaurantTrackingDBDataSet();
            this.restaurantTrackingDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridToday = new System.Windows.Forms.DataGridView();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantTrackingDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantTrackingDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridToday)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bugün Gelen Müşteriler Ekranı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // restaurantTrackingDBDataSet
            // 
            this.restaurantTrackingDBDataSet.DataSetName = "RestaurantTrackingDBDataSet";
            this.restaurantTrackingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantTrackingDBDataSetBindingSource
            // 
            this.restaurantTrackingDBDataSetBindingSource.DataSource = this.restaurantTrackingDBDataSet;
            this.restaurantTrackingDBDataSetBindingSource.Position = 0;
            // 
            // gridToday
            // 
            this.gridToday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridToday.Location = new System.Drawing.Point(12, 28);
            this.gridToday.Name = "gridToday";
            this.gridToday.RowHeadersWidth = 51;
            this.gridToday.RowTemplate.Height = 24;
            this.gridToday.Size = new System.Drawing.Size(942, 410);
            this.gridToday.TabIndex = 1;
            this.gridToday.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(879, 2);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 23);
            this.BtnExit.TabIndex = 27;
            this.BtnExit.Text = "ÇIKIŞ";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(798, 2);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(75, 23);
            this.BtnBack.TabIndex = 28;
            this.BtnBack.Text = "GERİ";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // frmToday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 469);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.gridToday);
            this.Controls.Add(this.label1);
            this.Name = "frmToday";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Today";
            this.Load += new System.EventHandler(this.frmToday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restaurantTrackingDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantTrackingDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridToday)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RestaurantTrackingDBDataSet restaurantTrackingDBDataSet;
        private System.Windows.Forms.BindingSource restaurantTrackingDBDataSetBindingSource;
        private System.Windows.Forms.DataGridView gridToday;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnBack;
    }
}