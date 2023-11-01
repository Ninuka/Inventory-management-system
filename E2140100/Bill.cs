using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2140100
{
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
            
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            lblOrderID.Text = Order_MGT.DATAPASS1.ToString();
            lblProductName.Text = Order_MGT.DATAPASS2;
            lblQuantity.Text = Order_MGT.DATAPASS3.ToString();
            lblProductPrice.Text = Order_MGT.DATAPASS4.ToString();
            lblTotal.Text = Order_MGT.DATAPASS5.ToString();
            lblPayment.Text = Order_MGT.DATAPASS6.ToString();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form Order_MGT = new Order_MGT();
            Order_MGT.Show();
            this.Hide();
        }
    }
}
