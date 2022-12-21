using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace BANKING_SYSTEM
{
    public partial class New_account : Form
    {
        string gender = string.Empty;
        string m_status = string.Empty;
        
        bankEntities bse;
        MemoryStream ms;

        public New_account()
        {
            InitializeComponent();
            loaddate();
            
            loadstate();
            
        }

        private void loaddate()
        {
            label3.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        

        private void loadstate()
        {
            comboBox1.Items.Add("Punjab");
            comboBox1.Items.Add("Sindh");
            comboBox1.Items.Add("KPK");
            comboBox1.Items.Add("Balouchistan");
        }

        private void New_account_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                gender = "Male";
            }
            else if(radioButton4.Checked)
            {
                gender = "Female";
            }
            else if (radioButton5.Checked)
            {
                gender = "Others";
            }
            if (radioButton1.Checked)
            {
                m_status = "Married";
            }
            else if (radioButton2.Checked)
            {
                m_status = "Non-Married";
            }
            bse = new bankEntities();
            userAcoount acc = new userAcoount();

            acc.Account_No = Convert.ToInt32(textBox1.Text);
            acc.Name = textBox2.Text;
            acc.DOB = dateTimePicker1.Value.ToString();
            acc.PhoneNo = textBox4.Text;
            acc.Address = textBox5.Text;
            acc.District = textBox6.Text;
            acc.State = comboBox1.SelectedItem.ToString();
            acc.Gender = gender;
            acc.Martial_status = m_status;
            acc.Mother_name = textBox7.Text;
            acc.Father_name = textBox8.Text;
            acc.Balance = Convert.ToDecimal(textBox9.Text);
            acc.Date = label3.Text;
            acc.Picture = ms.ToArray();
            bse.userAcoounts.Add(acc);
            bse.SaveChanges();
            MessageBox.Show("File saved!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opebdlg = new OpenFileDialog();
            if (opebdlg.ShowDialog() == DialogResult.OK)
            {
                Image img = Image.FromFile(opebdlg.FileName);
                pictureBox1.Image = img;
                ms = new MemoryStream();
                img.Save(ms, img.RawFormat);

            }
        }
    }
}
