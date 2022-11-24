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
    public partial class frmStaffScreenOLD : Form
    {
        public frmStaffScreenOLD()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        
        void process(object sender, EventArgs e)//sayılara basınca ekrana girdirme
        {
            Button btn = sender as Button;

            switch (btn.Name)//Sayılar
            {
                case "btn0":
                    txtPiece.Text += (0).ToString();
                    break;
                case "btn1":
                    txtPiece.Text += (1).ToString();
                    break;
                case "btn2":
                    txtPiece.Text += (2).ToString();
                    break;
                case "btn3":
                    txtPiece.Text += (3).ToString();
                    break;
                case "btn4":
                    txtPiece.Text += (4).ToString();
                    break;
                case "btn5":
                    txtPiece.Text += (5).ToString();
                    break;
                case "btn6":
                    txtPiece.Text += (6).ToString();
                    break;
                case "btn7":
                    txtPiece.Text += (7).ToString();
                    break;
                case "btn8":
                    txtPiece.Text += (8).ToString();
                    break;
                case "btn9":
                    txtPiece.Text += (9).ToString();
                    break;
                default:
                    MessageBox.Show("Sayı Gir");
                    break;
            }
        }
            private void frmStaffScreen_Load(object sender, EventArgs e)
            {

            btn0.Click += new EventHandler(process);
            btn1.Click += new EventHandler(process);
            btn2.Click += new EventHandler(process);
            btn3.Click += new EventHandler(process);
            btn4.Click += new EventHandler(process);
            btn5.Click += new EventHandler(process);
            btn6.Click += new EventHandler(process);
            btn7.Click += new EventHandler(process);
            btn8.Click += new EventHandler(process);
            btn9.Click += new EventHandler(process);



        }

        
    }
}
