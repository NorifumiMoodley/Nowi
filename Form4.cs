using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CtrlFreaks_SignUp_LogIn;
using HomePage;
using System.Data.SQLite;
using System.IO;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Diagnostics;


namespace SeniorCitizenLogin
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picVideoPlaceholder_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 Frm = new Form3();
            Frm.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username=txtUsername.Text;
            
            string correctdetails = "";

			string Input = txtPassword.Text.Trim();

			if (string.IsNullOrEmpty(Input))
			{
				MessageBox.Show("Please enter some text to encrypt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			HashAlgorithm algorithm = null;
			string pwd = Input;
			string hashPassword;
			using (var sHA256 = SHA256.Create())
			{
				byte[] inputBytes = Encoding.UTF8.GetBytes(pwd);
				byte[] hashBytes = sHA256.ComputeHash(inputBytes);
				hashPassword = BitConverter.ToString(hashBytes).Replace("-", "");

				Input = hashPassword;
			}

			databaseHelper dbH = new databaseHelper();
			
            correctdetails = dbH.Login(username, Input);
            if(correctdetails=="true")
            {
                TextWriter txt = null;
				string filePath = @"Data Source = ..\..\username.txt";
				txt = new StreamWriter(filePath);
				txt.WriteLine(username);
				txt.Close();

                if (dbH.getPosition(username)=="Teacher")
                {
                    this.Hide();
				    Form5 Frm = new Form5();
				    Frm.Show();
                }
                else
                {
					this.Hide();
					Form1 Frm = new Form1();
					Frm.Show();
				}
				
            }
            else
            {
                MessageBox.Show("Incorrect Login Details :(");
            }
			
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

		private void button1_Click(object sender, EventArgs e)
		{
			this.Hide();
			Form5 Frm = new Form5();
			Frm.Show();
		}

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 frm = new Form7();
            this.Hide();
            frm.Show();
        }
    }
}
