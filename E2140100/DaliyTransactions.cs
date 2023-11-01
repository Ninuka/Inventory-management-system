using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2140100
{
    public partial class DailyTransactions : Form
    {
        public DailyTransactions()
        {
            InitializeComponent();
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
            con.Open();

            try
            {
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Order_MGT WHERE total='" + dtpTo.Text + "'", con);
                DataTable dtable = new DataTable();
                sqlDa.Fill(dtable);
                dataGridView1.DataSource = dtable;

                con.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form FormHome = new FormHome();
            FormHome.Show();
            this.Hide();
        }
    }
}
