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
    public partial class Order_MGT : Form
    {



        public static decimal DATAPASS1;
        public static string DATAPASS2;
        public static decimal DATAPASS3;
        public static decimal DATAPASS4;
        public static decimal DATAPASS5;
        public static decimal DATAPASS6;
     




        public Order_MGT()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id, qty;
            int row = 0;

            dataGridView1.Rows.Add();
            row = dataGridView1.Rows.Count - 2;

            float price, total, payment, discount;
            string name;
          


            id= int.Parse(txtOrderId.Text);
            name = (txtProductName.Text);
            qty= int.Parse(txtqty.Text);
            price = float.Parse(txtProductPrice.Text);
           


            total = qty * price;
            txtTotal.Text = "" + total;


            discount = (cmbDiscount.SelectedIndex);

            if (cmbDiscount.SelectedIndex == 1)
                discount = (total * 5) / 100;
            else
                discount = 0;

            payment = total - discount;
            txtPayment.Text = "" + payment;

            dataGridView1["id", row].Value = txtOrderId.Text;
            dataGridView1["name", row].Value = txtProductName.Text;
            dataGridView1["qty", row].Value = txtqty.Text;
            dataGridView1["price", row].Value = txtProductPrice.Text;
            dataGridView1["total", row].Value = txtTotal.Text;
            dataGridView1["payment", row].Value = txtPayment.Text;
            dataGridView1["discount", row].Value = discount;

           

        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con2 = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
                con2.Open();

                string query = "select Quantity,Item_Name from Item_Management where Item_Name='"+txtProductName.Text+"'";
                SqlCommand cmd = new SqlCommand(query, con2);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int nQt, oQt;
                int.TryParse(reader["Quantity"].ToString(), out oQt);
                nQt = oQt - Int32.Parse(txtqty.Text);
                con2.Close();

                SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
                con.Open();
                SqlCommand cmb = new SqlCommand("insert into Order_MGT values (@id,@name,@qty,@price,@date,@total,@payment,@discount)", con);
                cmb.Parameters.AddWithValue("@id", txtOrderId.Text);
                cmb.Parameters.AddWithValue("@name", txtProductName.Text);
                cmb.Parameters.AddWithValue("@qty", txtqty.Text);
                cmb.Parameters.AddWithValue("@price", txtProductPrice.Text);
                cmb.Parameters.AddWithValue("@total", txtTotal.Text);
                cmb.Parameters.AddWithValue("@payment", txtPayment.Text);
                cmb.Parameters.AddWithValue("@date", dateTimePicker1.Text);
                cmb.Parameters.AddWithValue("@discount", cmbDiscount.Text);
                cmb.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Succesfully Insert");

                SqlConnection con1 = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");
                con1.Open();

                String querryAN = "UPDATE Item_Management SET Quantity='" + nQt + "' WHERE Item_Name='" + this.txtProductName.Text + "'";
                SqlCommand cmdAN = new SqlCommand(querryAN, con1);
                cmdAN.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
                con1.Close();


                DATAPASS1 = Convert.ToDecimal(txtOrderId.Text);
                DATAPASS2 = txtProductName.Text;
                DATAPASS3 = Convert.ToDecimal(txtqty.Text);
                DATAPASS4 = Convert.ToDecimal(txtProductPrice.Text);
                DATAPASS5 = Convert.ToDecimal(txtTotal.Text);
                DATAPASS6 = Convert.ToDecimal(txtPayment.Text);
                

                Bill b = new Bill();
                b.Show();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderId.Text = "";
            txtPayment.Text = "";
            txtProductName.Text = "";
            txtProductPrice.Text = "";
            txtqty.Text = "";
            txtTotal.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form FormHome = new FormHome();
            FormHome.Show();
            this.Hide();
        }
    }
}
