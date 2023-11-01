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
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        private void toolStriptxtStaff_ButtonClick(object sender, EventArgs e)
        {
            Form staffReg = new Staff_Reg();
            staffReg.Show();
            this.Hide();
        }

        private void toolStriptxtItem_ButtonClick(object sender, EventArgs e)
        {
            Form addItem = new Item_Management();
            addItem.Show();
            this.Hide();
        }

        private void toolStriptxtOrder_ButtonClick(object sender, EventArgs e)
        {
            Form addOrder = new Order_MGT();
            addOrder.Show();
            this.Hide();
        }

        private void itemDemandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Demand = new ItemDemand();
            Demand.Show();
            this.Hide();
        }

        private void expensesToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            Form expen = new Expenses();
            expen.Show();
            this.Hide();
        }

        

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Daily= new DailyTransactions();
            Daily.Show();
            this.Hide();
        }

        private void toolStripLogout_ButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
