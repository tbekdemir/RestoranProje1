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
    public partial class frmToday : Form
    {
        public frmToday()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=ASUS;Initial Catalog=RestaurantTrackingDB;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void ListToday()  // veritabanı kayırların görüntülenmesi
        {
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("EXEC sp_TodayTickets27102022_2", con);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            gridToday.DataSource = tablo;
            con.Close();
        }
        private void frmToday_Load(object sender, EventArgs e)
        {
            ListToday();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
