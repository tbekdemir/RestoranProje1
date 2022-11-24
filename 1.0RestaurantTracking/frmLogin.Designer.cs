namespace _1._0RestaurantTracking
{
    partial class frmLogin
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
            this.labelGiris = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.TxtNickname = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelGiris
            // 
            this.labelGiris.AutoSize = true;
            this.labelGiris.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGiris.Location = new System.Drawing.Point(123, 9);
            this.labelGiris.Name = "labelGiris";
            this.labelGiris.Size = new System.Drawing.Size(87, 33);
            this.labelGiris.TabIndex = 0;
            this.labelGiris.Text = "GIRIS";
            this.labelGiris.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelGiris.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(59, 90);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(79, 16);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Kullanıcı Adı";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(59, 134);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(34, 16);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Şifre";
            this.labelPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtNickname
            // 
            this.TxtNickname.Location = new System.Drawing.Point(62, 109);
            this.TxtNickname.Name = "TxtNickname";
            this.TxtNickname.Size = new System.Drawing.Size(214, 22);
            this.TxtNickname.TabIndex = 3;
            this.TxtNickname.Tag = "";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(62, 153);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(214, 22);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(111, 181);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(109, 26);
            this.buttonLogin.TabIndex = 5;
            this.buttonLogin.Text = "Giriş Yap";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 281);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtNickname);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelGiris);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGiris;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox TxtNickname;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Button buttonLogin;
    }
}