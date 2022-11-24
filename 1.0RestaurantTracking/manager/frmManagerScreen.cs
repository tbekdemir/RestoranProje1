using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1._0RestaurantTracking
{
    public partial class frmManagerScreen : Form
    {
        public frmManagerScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManagerScreen_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmToday Today = new frmToday();
            Today.Show();
            this.Hide();
        }

        private void buttonHistory_Click(object sender, EventArgs e)
        {
            frmHistory History = new frmHistory();
            History.Show();
            this.Hide();
        }

        private void buttonStock_Click(object sender, EventArgs e)
        {
            frmStock Stock = new frmStock();
            Stock.Show();
            this.Hide();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            frmLogin exit = new frmLogin();
            exit.Show();
            this.Hide();
        }
    }
}
