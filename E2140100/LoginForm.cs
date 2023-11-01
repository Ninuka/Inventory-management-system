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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-IJI8QGV\\SQLEXPRESS;Initial Catalog=IMSDB;Integrated Security=True");
            SqlCommand cmb = new SqlCommand("select * from Login where username='" + txtUsername.Text + "'and password='" + txtpassword.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmb);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            String cmbItemValue = cmbUsertype.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["usertype"].ToString() == cmbItemValue)
                    {
                        MessageBox.Show("You are login as" + dt.Rows[i][2]);
                        if (cmbUsertype.SelectedIndex == 0)
                        {
                            FormHome f = new FormHome();
                            f.Show();
                            this.Hide();
                        }
                        else
                        {
                            CaisarHome f = new CaisarHome();
                            f.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Enter Correct Details");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
