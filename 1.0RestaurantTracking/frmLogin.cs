using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _1._0RestaurantTracking
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=ASUS;Initial Catalog=RestaurantTrackingDB;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {
                
        }

        private void buttonKayit_Click(object sender, EventArgs e)
        {
            frmAdminScreen Register = new frmAdminScreen();
            Register.Show();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
                try
                {
                    SqlConnection cnn = new SqlConnection("Data Source=ASUS;Initial Catalog=RestaurantTrackingDB;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("select GorevID from TblPersoneller where KullaniciAdi = 'admin' and Sifre = 'admin'", cnn);
                    cmd.Parameters.AddWithValue("@KAdi", TxtNickname.Text);
                    cmd.Parameters.AddWithValue("@KParola", TxtPassword.Text);
                    cmd.Connection.Open();
                    SqlDataReader rd = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
                    {
                        while (rd.Read()) // reader Okuyabiliyorsa
                        {
                            if (rd["TypeId"].ToString() == "1") // 1 Rolü Admin'e ait olarak Ayarlanmışdır
                            {
                            // Kullanıcı Rolü 1 ise Admin Ekranı Aç 
                            frmAdminScreen admin = new frmAdminScreen();
                                admin.Show();
                                this.Hide();
                            }
                            if (rd["TypeId"].ToString() == "2") // 2 Rolü Manager'e ait olarak Ayarlanmışdır
                            {
                            // Kullanıcı Rolü 2 ise manager Ekranı Aç 
                            frmManagerScreen ManagerScreen = new frmManagerScreen();
                            ManagerScreen.Show();
                                           this.Hide();
                        }
                        if (rd["TypeId"].ToString() == "3") // 3 Rolü Staff'e ait olarak Ayarlanmışdır
                        {
                            // Kullanıcı Rolü 3 ise staff Ekranı Aç 
                            frmStaffScreen StaffScreen = new frmStaffScreen();
                               StaffScreen.Show();
                                           this.Hide();
                        }
                        else
                            {
                            // Kullanıcı Rolü 1 dışında ise Kullanıcı Ekranı Aç
                          //  frmStaffScreen kul = new frmStaffScreen();
                             //   kul.Show();
                             //   this.Hide();
                            }
                        }
                    }
                    else /// Reader SATIR döndüremiyorsa K.Adı Parola Yanlış Demekdir
                    {
                        rd.Close();
                        MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch // Bağlantı açamayıp Sorgu Çalıştıramıyorsa Veritabanına Ulaşamıyor Demekdir
                {
                    MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            


            //try
            //{
            //    if (connect.State == ConnectionState.Closed)
            //        connect.Open();
            //    string kayit = "select UserType from LoginTable where username = @username and password = @password;";
            //    SqlCommand command = new SqlCommand(kayit, connect);
            //    command.Parameters.AddWithValue("@username", txtUsername.Text);
            //    command.Parameters.AddWithValue("@password", txtPassword.Text);
            //    //command.Connection.Open();
            //    SqlDataReader rd = command.ExecuteReader(CommandBehavior.CloseConnection);
            //    if (rd.HasRows) // Girilen K.Adı ve K.Parola Dahilinde Gelen Data var ise 
            //    {
            //        while (rd.Read()) // reader Okuyabiliyorsa
            //        {
            //            if (rd["UserType"].ToString() == "1") // Admin Rolü Admin'e ait olarak Ayarlanmışdır
            //            {
            //                // Kullanıcı Rolü Admin ise Admin Ekranı Aç 
            //                frmAdminScreen Register = new frmAdminScreen();
            //                Register.Show();
            //                this.Hide();
            //            }

            //            else if (rd["UserType"].ToString() == "2") // Manager Rolü manager'e ait olarak Ayarlanmışdır
            //            {
            //                // Kullanıcı Rolü Manager ise Manager Ekranı Aç 
            //                frmManagerScreen ManagerScreen = new frmManagerScreen();
            //                ManagerScreen.Show();
            //                this.Hide();
            //            }

            //            else
            //            {
            //                // Kullanıcı Rolü admin dışında ise Manager Ekranı Aç
            //                frmStaffScreen StaffScreen = new frmStaffScreen();
            //                StaffScreen.Show();
            //                this.Hide();
            //            }
            //        }
            //    }
            //    else /// Reader SATIR döndüremiyorsa K.Adı Parola Yanlış Demekdir
            //    {
            //        rd.Close();
            //        MessageBox.Show("Kullanıcı Adı veya Parola Geçersizdir", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //}
            //catch // Bağlantı açamayıp Sorgu Çalıştıramıyorsa Veritabanına Ulaşamıyor Demekdir
            //{
            //    MessageBox.Show("DB ye ulaşılamadı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
    }
}
