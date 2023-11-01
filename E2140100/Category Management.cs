using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace E2140100
{
    public partial class Item_Management : Form
    {
        public Item_Management()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
                con.Open();
                SqlCommand cmb = new SqlCommand("insert into Item_Management values (@Item_Code,@Item_Name,@Price,@Quantity)", con);
                cmb.Parameters.AddWithValue("@Item_Code", txtItemCode.Text);
                cmb.Parameters.AddWithValue("@Item_Name", txtItemName.Text);
                cmb.Parameters.AddWithValue("@Price", txtPrice.Text);
                cmb.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
                cmb.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Succesfully Insert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";

        }

        private void buttonDelect_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
            con.Open();
            SqlCommand cmb = new SqlCommand("Delete Item_Management where Item_Code=@Item_Code", con);
            cmb.Parameters.AddWithValue("@Item_Code", txtItemCode.Text);

            cmb.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Succesfully Delete");
            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
            con.Open();
            SqlCommand cmb = new SqlCommand("Update Item_Management set Item_Name=@Item_Name, Price=@Price, Quantity=@Quantity where Item_Code=@Item_Code", con);
            cmb.Parameters.AddWithValue("@Item_Code", txtItemCode.Text); //("@Employee_ID", int.parse(txtEmpId.Text));
            cmb.Parameters.AddWithValue("@Item_Name", txtItemName.Text);
            cmb.Parameters.AddWithValue("@Price", txtPrice.Text);
            cmb.Parameters.AddWithValue("@Quantity", txtQuantity.Text);
            cmb.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Succesfully Update");

            txtItemCode.Text = "";
            txtItemName.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
            con.Open();
            SqlCommand cmb = new SqlCommand("select * from Item_Management", con);
            SqlDataAdapter da = new SqlDataAdapter(cmb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItemStock.DataSource = dt;
        }

        private void Item_Management_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
            con.Open();
            SqlCommand cmb = new SqlCommand("select * from Item_Management", con);
            SqlDataAdapter da = new SqlDataAdapter(cmb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvItemStock.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form FormHome = new FormHome();
            FormHome.Show();
            this.Hide();
        }
    }
}
