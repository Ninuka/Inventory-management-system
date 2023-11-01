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


namespace E2140100
{
    public partial class CaisarHome : Form
    {
        public CaisarHome()
        {
            InitializeComponent();
        }

        private void toolStriptxtOrder_ButtonClick(object sender, EventArgs e)
        {
            Form addOrder = new Order_MGT();
            addOrder.Show();
            this.Hide();
        }

        private void toolStripLogout_ButtonClick(object sender, EventArgs e)
        {
            Form LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
            
        }

        private void CaisarHome_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
            con.Open();
            SqlCommand cmb = new SqlCommand("select * from Item_Management", con);
            SqlDataAdapter da = new SqlDataAdapter(cmb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dvgStock.DataSource = dt;
        }
    }
}
