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
    public partial class Expenses : Form
    {
        public Expenses()
        {
            InitializeComponent();
        }

        private void Expenses_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
            con.Open();
            SqlCommand cmb = new SqlCommand("select * from Expenses", con);
            SqlDataAdapter da = new SqlDataAdapter(cmb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dvgPayment.DataSource = dt;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
                con.Open();
                SqlCommand cmb = new SqlCommand("insert into Expenses values (@PaymentNO,@PaymentType,@PaymentAmount,@Date)", con);
                cmb.Parameters.AddWithValue("@PaymentNO", txtPaymentNo.Text);
                cmb.Parameters.AddWithValue("@PaymentType", txtpaymenttype.Text);
                cmb.Parameters.AddWithValue("@PaymentAmount", txtPaymentAmount.Text);
                cmb.Parameters.AddWithValue("@Date", dtpPaymentDate.Text);
                cmb.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Succesfully Insert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
            con.Open();
            SqlCommand cmb = new SqlCommand("Delete Expenses where PaymentNO=@PaymentNO", con);
            cmb.Parameters.AddWithValue("@PaymentNO", txtPaymentNo.Text);

            cmb.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Succesfully Delete");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPaymentNo.Text = "";
            txtPaymentAmount.Text = "";
            txtpaymenttype.Text = "";
            dtpPaymentDate.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form FormHome = new FormHome();
            FormHome.Show();
            this.Hide();
        }
    }
}
