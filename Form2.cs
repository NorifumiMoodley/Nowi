using HomePage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Page
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BasicsOfAComputerForm bcom = new BasicsOfAComputerForm();
            this.Hide();
            bcom.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HowToUseInternetForm hti = new HowToUseInternetForm();
            this.Hide();
            hti.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HowToGmailForm hti = new HowToGmailForm();
            this.Hide();
            hti.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ATMSimulationsForm atm = new ATMSimulationsForm();
            this.Hide();
            atm.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            CommonUIForm hti = new CommonUIForm();
            this.Hide();
            hti.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
