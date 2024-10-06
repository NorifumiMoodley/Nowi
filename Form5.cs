using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using SeniorCitizenLogin;

namespace HomePage
{
    public partial class Form5 : Form
    {
        string messageInfo = "";
        public string Message
        {
            get { return messageInfo; }
        }
        public Form5()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {//Update account

            //messageInfo="When you click on update account, in the navbar you will be greeted with a page that will display your current username and password. You can change your username or password, and save these changes.";
            string result = MessagBox.ShowBox("When you click on update account, in the navbar \nyou will be greeted with a page that will display your \ncurrent username and password.You can change \nyour username or password, and save these changes.", "Message Box");//message misplled--box
            
            if (result.Equals("1"))//taking button from form 2
            {
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {//Review course
                                             
            string result = MessagBox.ShowBox("When you click on review course, you will be greeted \nwith two options. \nOne: To review results and Two: To view lessons. ", "Message Box");
        }

        private void button3_Click(object sender, EventArgs e)
        {//help
            string result = MessagBox.ShowBox("In the event that you are still confused on how to \nuse the program, you can click on help for additional \ninformation.", "Message Box");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
			databaseHelper.FillTable(dataGridView1);
		}

        private void btnHome_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        bool menuExpand = false;
		private void menuTransition_Tick(object sender, EventArgs e)
		{
			if (menuExpand == false)
			{
				menuContainer.Height += 10;
				if (menuContainer.Height >= 200)
				{
					menuTransition.Stop();
					menuExpand = true;
				}
			}
			else
			{
				menuContainer.Height -= 10;
				if (menuContainer.Height <= 70)
				{
					menuTransition.Stop();
					menuExpand = false;
				}

			}


		}

		private void button10_Click(object sender, EventArgs e)//menu for review course
		{
			menuTransition.Start();
		}
		bool sidebarExpand = true;
		private void sidebarTransition_Tick(object sender, EventArgs e)
		{
			if (sidebarExpand)
			{
				sidebar.Width -= 10;
				if (sidebar.Width <= 82)
				{
					sidebarExpand = false;
					sidebarTransition.Stop();
				}
			}
			else
			{
				sidebar.Width += 10;
				if (sidebar.Width >= 239)
				{
					sidebarExpand = true;
					sidebarTransition.Stop();
				}
			}
		}

		private void btnHamburger_Click(object sender, EventArgs e)
		{
			sidebarTransition.Start();
		}

		private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form6 Frm = new Form6();
			Frm.Show();
		}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form7 frm = new Form7();
            frm.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TextWriter txt = null;
            string filePath = "C:\\Users\\Caldon\\Desktop\\New folder (2)\\HomepagePRJT\\HomePage\\username.txt";
            txt = new StreamWriter(filePath);
            txt.WriteLine("");
            txt.Close();

            this.Hide();
            Form4 frm = new Form4();
            frm.Show();
        }
    }
    
}
