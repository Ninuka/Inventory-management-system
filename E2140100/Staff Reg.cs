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
    public partial class Staff_Reg : Form
    {
        public Staff_Reg()
        {
            InitializeComponent();
        }
       
        
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection
                ("Data Source=DESKTOP-IJI8QGV\\SQLEXPRESS;Initial Catalog=IMSDB;Integrated Security=True");
                con.Open();
                SqlCommand cmb = new SqlCommand
                ("insert into StaffREG values (@EmployeeID,@FirstName,@LastName,@Adderss,@DateOfBirthday,@Gender,@NIC,@Username,@Password,@EmployeeType) ", con);
                cmb.Parameters.AddWithValue("@EmployeeID", txtEmpId.Text);//("@Employee_ID", int.parse(txtEmpId.Text));
                cmb.Parameters.AddWithValue("@FirstName", txtFname.Text);
                cmb.Parameters.AddWithValue("@LastName", txtLname.Text);
                cmb.Parameters.AddWithValue("@Adderss", txtAdderss.Text);
                cmb.Parameters.AddWithValue("@DateOfBirthday", dateTimePicker1.ToString());
                cmb.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmb.Parameters.AddWithValue("@NIC", txtNIC.Text);
                cmb.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmb.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmb.Parameters.AddWithValue("@EmployeeType", cmbEmpType.Text);
                cmb.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Succesfully Insert");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Text, ex.Message);  
            }
        }
    
    

        private void Staff_Reg_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection
            ("Data Source=DESKTOP-IJI8QGV\\SQLEXPRESS;Initial Catalog=IMSDB;Integrated Security=True");
            con.Open();
            SqlCommand cmb = new SqlCommand("select * from StaffREG", con);
            SqlDataAdapter da = new SqlDataAdapter(cmb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmp.DataSource = dt;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection
                ("Data Source=DESKTOP-IJI8QGV\\SQLEXPRESS;Initial Catalog=IMSDB;Integrated Security=True");
                con.Open();
                SqlCommand cmb = new SqlCommand
                ("Update StaffREG set FirstName=@FirstName, LastName=@LastName, Adderss=@Adderss, DateOfBirthday=@DateOfBirthday, Gender=@Gender, NIC=@NIC, Username=@Username, Password=@Password, EmployeeType=@EmployeeType where EmployeeID=@EmployeeID", con);
                cmb.Parameters.AddWithValue("@EmployeeID", txtEmpId.Text);//("@Employee_ID", int.parse(txtEmpId.Text));
                cmb.Parameters.AddWithValue("@FirstName", txtFname.Text);
                cmb.Parameters.AddWithValue("@LastName", txtLname.Text);
                cmb.Parameters.AddWithValue("@Adderss", txtAdderss.Text);
                cmb.Parameters.AddWithValue("@DateOfBirthday", dateTimePicker1.Text);
                cmb.Parameters.AddWithValue("@Gender", cmbGender.Text);
                cmb.Parameters.AddWithValue("@NIC", txtNIC.Text);
                cmb.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmb.Parameters.AddWithValue("@Password", txtPassword.Text);
                cmb.Parameters.AddWithValue("@EmployeeType", cmbEmpType.Text);
                cmb.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Succesfully Update");
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message);
            }
        }

        private void buttonDelect_Click(object sender, EventArgs e)
        {
            try
            {


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJI8QGV\\SQLEXPRESS;Initial Catalog=IMSDB;Integrated Security=True");
                con.Open();
                SqlCommand cmb = new SqlCommand("Delete StaffREG where EmployeeID=@EmployeeID", con);
                cmb.Parameters.AddWithValue("@EmployeeID", txtEmpId.Text);

                cmb.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Succesfully Delete");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        {

        }

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJI8QGV\\SQLEXPRESS;Initial Catalog=IMSDB;Integrated Security=True");
            con.Open();
            SqlCommand cmb = new SqlCommand("select * from StaffREG", con);
            SqlDataAdapter da = new SqlDataAdapter(cmb);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvEmp.DataSource = dt;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form FormHome = new FormHome();
            FormHome.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAdderss.Text = "";
            dateTimePicker1.Text = "";
            txtEmpId.Text = "";
            cmbEmpType.Text = "";
            txtFname.Text = "";
            cmbGender.Text = "";
            txtLname.Text = "";
            txtNIC.Text = "";
            txtPassword.Text = "";
            txtUsername.Text = "";

        }
    }
}
