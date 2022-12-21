using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BANKING_SYSTEM
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void newAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            New_account acc= new New_account();
            acc.MdiParent = this;
            acc.Show();
        }

        private void updateSearchAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Update_Search up = new Update_Search();
            up.MdiParent = this;
            up.Show();
        }

        private void allCustomersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_customers cus = new All_customers();
            cus.MdiParent = this;
            cus.Show();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deposite dep = new Deposite();
            dep.MdiParent = this;
            dep.Show();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Withdraw w = new Withdraw();
            w.MdiParent = this;
            w.Show();
        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transfer tran = new Transfer();
            tran.MdiParent = this;
            tran.Show();
        }

        private void fDFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FD_form fd = new FD_form();
            fd.MdiParent = this;
            fd.Show();
        }

        private void balanceSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Balncesheet blnc = new Balncesheet();
            blnc.MdiParent = this;
            blnc.Show();
        }

        private void viewFDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            viewfd f = new viewfd();
            f.MdiParent = this;
            f.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Changepassword pas = new Changepassword();
            pas.MdiParent = this;
            pas.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EXIT ex = new EXIT();
            ex.MdiParent = this;
            ex.Show();
        }
    }
}
