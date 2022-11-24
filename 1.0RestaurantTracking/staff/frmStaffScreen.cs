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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace _1._0RestaurantTracking
{
    public partial class frmStaffScreen : Form
    {
        public frmStaffScreen()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=ASUS;Initial Catalog=RestaurantTrackingDB;Integrated Security=True");

       

        private void TicketsCreate()
        {
            try
            {

                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "INSERT INTO Tickets (TicketDate,CustomerId,StaffId,ProductsId,Stock) VALUES (GETDATE(),@CustomerId,@StaffId,@ProductsId,@Stock);";
                SqlCommand command = new SqlCommand(kayit, con);

                command.Parameters.AddWithValue("@CustomerId", cbCustomerStaff.SelectedValue);

                command.Parameters.AddWithValue("@StaffId", cbStaffStaff.SelectedValue);
                command.Parameters.AddWithValue("@ProductsId", TxtProductId.Text);

                command.Parameters.AddWithValue("@Stock", txtPiece.Text);

                command.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Kayıt Oluşturuldu.");
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + Hata.Message);
            }

            ListFisler3();


        }

        private void ListFisler3()  //fisler  veritabanı kayırların görüntülenmesi
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select FirstName+' '+LastName as Musteri,Name+' '+Surname as Garson ,TicketDate as SiparisTarihi, product_name as SiparisEdilenUrunler ,Tickets.Stock as Adedi from Customers,\tStaff,Tickets,Products where Customers.CustomerId=Tickets.CustomerId  and Staff.StaffId=Tickets.StaffId and Products.barcode=Tickets.ProductsId and (DATEPART(DAY, TicketDate) = DATEPART(DAY, GETDATE())) AND (DATEPART(MONTH, TicketDate) = DATEPART(MONTH, GETDATE()));\r\n", con);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            gridTickets.DataSource = tablo2;
            con.Close();
        }

        private void Customershow()//Müşteri combox için sql veri tabanın dan veri alma
        {
            con.Open();
            SqlDataReader oku;
            SqlCommand kmt = new SqlCommand("SELECT * ,  FirstName+' '+LastName as AdiSoyadi FROM Customers", con);
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                cbCustomerStaff.ValueMember = "CustomerId";
                cbCustomerStaff.DisplayMember = "AdiSoyadi";
                cbCustomerStaff.Items.Add(oku[3]);
            }
            con.Close();
        }

        private void ListStaff()  // Siparişi Alan Garson Combobox İsim seçilip ID yazdırma
        { 
            con.Open();
            SqlDataReader oku;
            SqlCommand kmt = new SqlCommand("SELECT * ,  Name+' '+Surname as AdiSoyadi FROM Staff WHERE TypeId='3'", con);
            oku = kmt.ExecuteReader();
            while (oku.Read())
            {
                cbStaffStaff.ValueMember = "StaffId"[0].ToString();
                cbStaffStaff.DisplayMember = "AdiSoyadi"[6].ToString();
                cbStaffStaff.Items.Add(oku[6]);
            }
            con.Close();
        }
        private void ListAnaYemek()  //ana yemek veritabanı kayırların görüntülenmesi
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select barcode as ÜrunId ,product_name as ÜrünAdı,ProductPrice as Fiyatı,stock as StokAdedi from Products where Products.CatagoryId='1';", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridMenu.DataSource = tablo;
            con.Close();
        }

        private void ListTatlı()  //tatlı  veritabanı kayırların görüntülenmesi
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select barcode as ÜrunId ,product_name as ÜrünAdı,ProductPrice as Fiyatı,stock as StokAdedi from Products where Products.CatagoryId='3';", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridMenu.DataSource = tablo;
            con.Close();
        }

        private void Listicecek()  // icecek veritabanı kayırların görüntülenmesi
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select barcode as ÜrunId ,product_name as ÜrünAdı,ProductPrice as Fiyatı ,stock as StokAdedi from Products where Products.CatagoryId='2';", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridMenu.DataSource = tablo;
            con.Close();
        }

        private void ListFisler()  // Tickets veritabanı kayırların görüntülenmesi
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("EXEC sp_TodayTickets27102022_2", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridTickets.DataSource = tablo;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ListAnaYemek();
        }//Ana yemekleri menüde gör

        private void button2_Click(object sender, EventArgs e)
        {
            Listicecek();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListTatlı();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ListFisler2()  //fisler  veritabanı kayırların görüntülenmesi
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("EXEC sp_TodayTickets27102022_2;", con);
            DataTable tablo2 = new DataTable();
            da.Fill(tablo2);
            gridTickets.DataSource = tablo2;
            con.Close();
        }

        private void ListComboboxCostomer() // Customer tablosunu combobx da ismini gösterip id sini tutma
        {
            SqlCommand komut428 = new SqlCommand("Select * from Customers", con);
            SqlDataAdapter da428 = new SqlDataAdapter(komut428);
            DataTable dt428 = new DataTable();
            da428.Fill(dt428);
            cbCustomerStaff.ValueMember = "CustomerId";
            cbCustomerStaff.DisplayMember = "FirstName";
            cbCustomerStaff.DataSource = dt428;

        }

        private void ListComboboxStaff() // Customer tablosunu combobx da ismini gösterip id sini tutma
        {
            SqlCommand komut228 = new SqlCommand("select*from Staff where TypeId=3;", con);
            SqlDataAdapter da228 = new SqlDataAdapter(komut228);
            DataTable dt228 = new DataTable();
            da228.Fill(dt228);
            cbStaffStaff.ValueMember = "StaffId";
            cbStaffStaff.DisplayMember = "Name";
            cbStaffStaff.DataSource = dt228;

        }
        private void frmStaffScreen_Load(object sender, EventArgs e)
        {
            // ListStaff();
            ListComboboxStaff();
            ListAnaYemek();
            //ListFisler();
            ListFisler3();
            //Customershow();
            ListComboboxCostomer();
           // Staffshow();
        }

        private void btnTciketCreate_Click(object sender, EventArgs e)
        {
            TicketsCreate();


            /*
            try
            {
                // TicketDate,CustomerId,StaffId,ProductsId


                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Tickets (TicketDate,CustomerId,StaffId,ProductsId,Stock) VALUES (GETDATE(),'" + cbCustomerStaff.SelectedValue + "','" + cbStaffStaff.SelectedValue + "','" + TxtProductId.Text + "',@Stock);", con);
                command.Parameters.AddWithValue("@Stock", txtPiece.Text);
                command.ExecuteNonQuery();
                con.Close();
                ListFisler2();
                MessageBox.Show("Fiş Oluşturuldu.");
                
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + Hata.Message);
            }

            //Ürün ekleme ekranı geliştirmek için brave > yer imleri > BRM > ürün ekleme ekranı (youtube video) da gelişmiş özellikler 
            //barkod no seçilerek dahq önceden eklenen ürünün bilgiler getirilir güncellenir falan

            foreach (Control item in gBOXTicket.Controls)//Veri girildikten sonra textvox ve combo box temizleme
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
                if (item is System.Windows.Forms.ComboBox)
                {
                    item.Text = "";
                }

            }





            /*
             try
            {
                con.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Tickets (,SatffName,CustomerName,TicketDate) VALUES (@SatffName,@CustomerName,GETDATE())", con);
                //  command.Parameters.AddWithValue("@ActiveDeactive", SqlDbType.Int).Value = chkActive.CheckState;
                //command.Parameters.AddWithValue("@Price", txtPrice.Text);
                command.Parameters.AddWithValue("@SatffName", cbStaffStaff.Text);
                command.Parameters.AddWithValue("@CustomerName", cbCustomerStaff.Text);
                
                

                command.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Fiş Oluşturuldu.");
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + Hata.Message);
            }

            //Ürün ekleme ekranı geliştirmek için brave > yer imleri > BRM > ürün ekleme ekranı (youtube video) da gelişmiş özellikler 
            //barkod no seçilerek dahq önceden eklenen ürünün bilgiler getirilir güncellenir falan

            foreach (Control item in gBOXTicket.Controls)//Veri girildikten sonra textvox ve combo box temizleme
            {
                if (item is System.Windows.Forms.TextBox)
                {
                    item.Text = "";
                }
                if (item is System.Windows.Forms.ComboBox)
                {
                    item.Text = "";
                }

            }
             */
        }

        private void gridMenu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Menüden Seçilen ürünün fişe yazdırma için getirilmesi

            //txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TxtProductId.Text = gridMenu.CurrentRow.Cells[0].Value.ToString();
            //txtPrice.Text = gridMenu.CurrentRow.Cells[1].Value.ToString();
        }

        private void cbStaffStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gridTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnTableUpdate_Click(object sender, EventArgs e)
        {
            ListFisler2();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            frmLogin exit = new frmLogin();
            exit.Show();
            this.Hide();
        }

        private void cbCustomerStaff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
