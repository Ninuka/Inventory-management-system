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
    public partial class ItemDemand : Form
    {
        public ItemDemand()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=AsusVivobook-S;Initial Catalog=IMSDB;Integrated Security=True");

        private void btnSort_Click(object sender, EventArgs e)
        {
            {

                try
                {
                    string allTables = "Select SUM(qty) From Order_MGT Where total BETWEEN '" + dateTimePicker1.Text + "' AND '" + dateTimePicker2.Text + "' group by name ";
                    SqlCommand cmd = new SqlCommand(allTables, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();

                    DemandChart.Series["qty"].Points.Clear();
                    while (rdr.Read())
                    {
                        this.DemandChart.Series["qty"].Points.AddXY("qty", rdr[0]);

                    }
                    rdr.Close();
                    con.Close();
                }
                catch (SqlException ex)
                { MessageBox.Show(ex.Message); }



            }

        }

        private void ItemDemand_Load(object sender, EventArgs e)
        {
            try
            {
                string allTables = "Select SUM(qty), name From Order_MGT group by name ";
                SqlCommand cmd = new SqlCommand(allTables, con);
                con.Open();
                SqlDataReader rdr = cmd.ExecuteReader();

                DemandChart.Series["qty"].Points.Clear();
                while (rdr.Read())
                {
                    this.DemandChart.Series["qty"].Points.AddXY(rdr[1], rdr[0]);

                }
                rdr.Close();
                con.Close();
            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
