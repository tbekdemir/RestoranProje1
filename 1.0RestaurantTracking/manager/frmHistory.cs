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
    public partial class frmHistory : Form
    {
        public frmHistory()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=ASUS;Initial Catalog=RestaurantTrackingDB;Integrated Security=True");


        private void ListHistory()  // veritabanı kayırların görüntülenmesi
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select FirstName+' '+LastName as Musteri,TicketDate as SiparisTarihi, product_name as SiparisEdilenUrunler ,Name+' '+Surname as Garson,ProductPrice as SiparisTutari from Customers,\tStaff,Tickets,Products where Customers.CustomerId=Tickets.CustomerId  and Staff.StaffId=Tickets.StaffId and Products.barcode=Tickets.ProductsId\r\n", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridHistory.DataSource = tablo;
            con.Close();
        }
        private void frmHistory_Load(object sender, EventArgs e)
        {
            ListHistory();
        }

        private void gridHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
