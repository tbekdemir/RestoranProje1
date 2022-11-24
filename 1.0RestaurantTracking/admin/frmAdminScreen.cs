using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _1._0RestaurantTracking
{
    public partial class frmAdminScreen : Form
    {
        public frmAdminScreen()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection(@"Data Source=ASUS;Initial Catalog=RestaurantTrackingDB;Integrated Security=True");

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void ListType()
        {
            SqlCommand komut28 = new SqlCommand("Select * from UserType", connect);
            SqlDataAdapter da28 = new SqlDataAdapter(komut28);
            DataTable dt28 = new DataTable();
            da28.Fill(dt28);
            cbType.ValueMember = "Id";
            cbType.DisplayMember = "userType";
            cbType.DataSource = dt28;

        }

        private void Register_Load(object sender, EventArgs e)
        {
            ListType();
            listview();
        }

        private void listview()  // veritabanı kayırların görüntülenmesi
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("select LoginTable.Id,username as KullanıcıAdi, password as Şifre, userType KullanıcıTipi , ActiveDeactive as AktifPasif from LoginTable , UserType where UserType.Id=LoginTable.UserTypeId", connect);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            connect.Close();
        }



        
        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {

                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "INSERT INTO LoginTable (username, password,UserTypeId,ActiveDeactive) VALUES (@username,@password,@UserTypeId,@ActiveDeactive);";
                SqlCommand command = new SqlCommand(kayit, connect);

                command.Parameters.AddWithValue("@username", txtUsername.Text);

                command.Parameters.AddWithValue("@password", txtPassword.Text);

                command.Parameters.AddWithValue("@UserTypeId", cbType.SelectedValue);

                command.Parameters.AddWithValue("@ActiveDeactive", SqlDbType.Int).Value = chkActive.CheckState;


                command.ExecuteNonQuery();

                connect.Close();

                MessageBox.Show("Kayıt Oluşturuldu.");
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + Hata.Message);
            }

            listview();


        }

        private void btnExit1_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Sil Butonu
            String t1 = txtUsername.Text; //seçilen satırın idsini al
            connect.Open();
            SqlCommand command = new SqlCommand("DELETE FROM LoginTable WHERE username=('" + t1 + "')", connect);
            command.ExecuteNonQuery();
            connect.Close();
            listview();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            /*
            try
            {

                if (connect.State == ConnectionState.Closed)
                    connect.Open();
                string kayit = "UPDATE LoginTable SET username=@username,password=@password,UserTypeId=@UserTypeId,ActiveDeactive=@ActiveDeactive where Id=@Id";
                SqlCommand command = new SqlCommand(kayit, connect);

                command.Parameters.AddWithValue("@username", txtUsername.Text);

                command.Parameters.AddWithValue("@password", txtPassword.Text);

                command.Parameters.AddWithValue("@UserTypeId", cbType.SelectedValue);

                command.Parameters.AddWithValue("@ActiveDeactive", SqlDbType.Int).Value = chkActive.CheckState;

                command.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);

                command.ExecuteNonQuery();

                connect.Close();

                MessageBox.Show("Güncelleme Başarılı.");
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + Hata.Message);
            }

            listview();

            */

            
            
            // Onayı kontrol edecek durum tanımlanır ve checkbox işaretli ise durum true yapılır:
            bool durum = false;
            if (chkActive.Checked)
                durum = true;
            else
                durum = false;


            // try ile yazacağımız kod denenir:
            try
            {

                // Bağlantı açıldığında çalışacak sql sorgusu için cmd nesnesi oluşturulur: 
                SqlCommand cmd = new SqlCommand("UPDATE LoginTable SET username=@username,password=@password,UserTypeId=@UserTypeId,ActiveDeactive=@ActiveDeactive WHERE ID=@id ", connect);


                // Fare ile seçilmiş satırın değeri @id'ye aktarılır:
                cmd.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells[0].Value);


                // TextBox'lardan alınan bilgiler etiketlere, oradan da sorguya gönderilir:
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);

                cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                //cmd.Parameters.AddWithValue("@UserTypeId", cbType.SelectedValue);
                  cmd.Parameters.AddWithValue("@UserTypeId", cbType.SelectedIndex);

                cmd.Parameters.AddWithValue("@ActiveDeactive", durum);


                // Bağlantı kapalı ise açılır:
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }


                // Sorgu çalıştırılır:
                cmd.ExecuteNonQuery();


                // Bağlantı kapatılır:
                connect.Close();


                // kisiGetir fonksiyonu ile tablonun son hali getirilir:
                listview();

                // Güncellendi mesajı gösterilir:
                MessageBox.Show("Güncellendi.");
            }


            // Bir yerde hata varsa catch ile yakalanır ve mesaj verilir:
            catch (Exception Hata)
            {
                MessageBox.Show("!!!" + Hata.Message);
            }
            
        }



        private void BtnExit_Click(object sender, EventArgs e)
        {
            frmLogin exit = new frmLogin();
            exit.Show();
            this.Hide();
        }
    }
}