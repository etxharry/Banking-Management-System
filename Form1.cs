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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bankEntities dbe = new bankEntities();
            if (textBox1.Text != string.Empty || textBox2.Text != string.Empty)
            {
                var user1 = dbe.admin_table.FirstOrDefault(a => a.Username.Equals(textBox1.Text));
                if (user1 != null)
                {
                    if (user1.Password.Equals(textBox2.Text))
                    {
                        Menu m1 = new Menu();
                        m1.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password incorrect!");
                    }
                }
                else
                {
                    MessageBox.Show("NULL");
                }
            }
            else
            {
                MessageBox.Show("Please enter Username and Password.");
            }
        }
    }
}
