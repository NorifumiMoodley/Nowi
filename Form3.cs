using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using HomePage;
using SeniorCitizenLogin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.IO;

namespace CtrlFreaks_SignUp_LogIn
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void NameLbl_Click(object sender, EventArgs e)
        {

        }

        private void SurnameLbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsernameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
			string uUsername = UsernameTxt.Text;
			string sFName = FNameTxt.Text;
			string sLName = LNameTxt.Text;
			int sProgress = 0;
            string uPosition = "Senior Citizen";
            //password
			string Input = PwsdTxt.Text.Trim();

			if (string.IsNullOrEmpty(Input))
			{
				MessageBox.Show("Please enter some text to encrypt", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

				return;
			}
			HashAlgorithm algorithm = null;
            string pwd=Input;
            string hashPassword;
            using (var sHA256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(pwd);
			    byte[] hashBytes = sHA256.ComputeHash(inputBytes);
			    hashPassword = BitConverter.ToString(hashBytes).Replace("-", "");
                
                Input = hashPassword;
            }
            int q1 = 0;
			int q2 = 0;
			int q3 = 0;
			int q4 = 0;
			int q5 = 0;

			databaseHelper.AddSeniorCitizen(sFName, sLName, sProgress);
            databaseHelper.AddUser(uUsername, uPosition, Input);
            databaseHelper.AddQuiz(q1, q2, q3, q4, q5);
			MessageBox.Show("Record Added");

            TextWriter txt = null;
            string filePath = @"Data Source =..\..\progress.txt";
            txt = new StreamWriter(filePath);
            txt.WriteLine("0");
            txt.Close();

            this.Hide();
            Form4 Frm = new Form4();
            Frm.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string f = @"Data Source =..\..\wannaBuildMethLab.mp4";
            axWindowsMediaPlayer1.URL = f;
                
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 Frm = new Form4();
            Frm.Show();
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void UsernameTxt_Leave(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "")
            {
                UsernameTxt.Text = "Enter Username";
                UsernameTxt.ForeColor = Color.Black;
            }
        }

        private void UsernameTxt_Enter(object sender, EventArgs e)
        {
            if (UsernameTxt.Text == "Enter Username")
            {
                UsernameTxt.Text = "";
                UsernameTxt.ForeColor = Color.Black;
            }
        }

        private void FNameTxt_Leave(object sender, EventArgs e)
        {
            if (FNameTxt.Text == "")
            {
                FNameTxt.Text = "Enter Name";
                FNameTxt.ForeColor = Color.Silver;
            }
        }

        private void FNameTxt_Enter(object sender, EventArgs e)
        {
            if (FNameTxt.Text == "Enter Name")
            {
                FNameTxt.Text = "";
                FNameTxt.ForeColor = Color.Black;
            }

        }

        private void LNameTxt_Leave(object sender, EventArgs e)
        {
            if (LNameTxt.Text == "")
            {
                LNameTxt.Text = "Enter Surname";
                LNameTxt.ForeColor = Color.Silver;
            }

        }

        private void LNameTxt_Enter(object sender, EventArgs e)
        {
            if (LNameTxt.Text == "Enter Surname")
            {
                LNameTxt.Text = "";
                LNameTxt.ForeColor = Color.Black;
            }

        }

        private void PwsdTxt_Leave(object sender, EventArgs e)
        {
            if (PwsdTxt.Text == "")
            {
                PwsdTxt.Text = "Enter Password";
                PwsdTxt.ForeColor = Color.Silver;
            }

        }

        private void PwsdTxt_Enter(object sender, EventArgs e)
        {
            if (PwsdTxt.Text == "Enter Password")
            {
                PwsdTxt.Text = "";
                PwsdTxt.ForeColor = Color.Black;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

		private void Form3_Load(object sender, EventArgs e)
		{
			
		}

	}
}
