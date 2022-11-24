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

namespace _1._0RestaurantTracking
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=ASUS;Initial Catalog=RestaurantTrackingDB;Integrated Security=True");

        private void ListProduct()  // veritabanı kayırların görüntülenmesi
        {
            if (connect.State == ConnectionState.Closed)
                connect.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select product_name as ÜrünAdi,catagory_name as Katagori,ProductPrice as Fiyat,Stock as StokAdedi ,ShipDate as SevkiyatTarihi from Products,Catagory where Catagory.catagory_id=Products.CatagoryId\r\n", connect);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            DgProducts.DataSource = tablo;
            connect.Close();
        }
        private void ListCatagory()
        {
            SqlCommand komut128 = new SqlCommand("Select * from Catagory", connect);
            SqlDataAdapter da128 = new SqlDataAdapter(komut128);
            DataTable dt128 = new DataTable();
            da128.Fill(dt128);
            cbCatagory.ValueMember = "catagory_id";
            cbCatagory.DisplayMember = "catagory_name";
            cbCatagory.DataSource = dt128;

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            ListCatagory();
            ListProduct();
        }

        private void btnProductCreate_Click(object sender, EventArgs e) //veri ekleme
        {
            try
            {
                connect.Open();
                SqlCommand command = new SqlCommand("INSERT INTO Products (product_name,catagoryId,ProductPrice,Stock,ShipDate) VALUES (@product_name,@catagoryId,@ProductPrice,@Stock,GETDATE())", connect);
                command.Parameters.AddWithValue("@product_name", txtProductName.Text);
                command.Parameters.AddWithValue("@catagoryId", cbCatagory.SelectedValue);
                command.Parameters.AddWithValue("@ProductPrice", txtPrice.Text);
                command.Parameters.AddWithValue("@Stock", int.Parse(txtStock.Text));

                command.ExecuteNonQuery();
                
                connect.Close();
                MessageBox.Show("Ürün Eklendi.");
                ListProduct();
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Hata Meydana Geldi" + Hata.Message);
            }

            //Ürün ekleme ekranı geliştirmek için brave > yer imleri > BRM > ürün ekleme ekranı (youtube video) da gelişmiş özellikler 
            //barkod no seçilerek dahq önceden eklenen ürünün bilgiler getirilir güncellenir falan

            foreach (Control item in groupBox1.Controls)//Veri girildikten sonra textvox ve combo box temizleme
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }

            }

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCatagory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            frmLogin exit = new frmLogin();
            exit.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            frmManagerScreen back = new frmManagerScreen();
            back.Show();
            this.Hide();
        }
    }
}
