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
using Course_Page;
using CtrlFreaks_SignUp_LogIn;
using SeniorCitizenLogin;

namespace HomePage
{
    public partial class Form1 : Form
    {
        string messageInfo = "";
        public string Message
        {
            get { return messageInfo; }
        }
        public Form1()
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
            string whatevavariableIwannacallit = "C:\\Users\\Caldon\\Desktop\\HomepagePRJT\\Because I Can - Healthy Seniors TV Commercial 30.mp4";
            axWindowsMediaPlayer1.URL=whatevavariableIwannacallit;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            Form2 frm2 = new Form2();
            frm1.Close();
            frm2.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            TextWriter txt = null;
            string filePath = @"Data Source =..\..\username.txt";
            txt = new StreamWriter(filePath);
            txt.WriteLine("");
            txt.Close();

            this.Hide();
            Form4 frm = new Form4();
            frm.Show();
        }

		private void button6_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form7 frm = new Form7();
			frm.Show();


		}

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReviewResult frm=new ReviewResult();
            frm.Show();
        }
    }
    
}
