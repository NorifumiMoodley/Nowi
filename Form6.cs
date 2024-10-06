using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
	public partial class Form6 : Form
	{
		public Form6()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			string tContact = ContactTxt.Text;
			string tFName = FNameTxt.Text;
			string tLName = LNameTxt.Text;
			string uUsername = usernametxt.Text;
			string uPassword = passwordtxt.Text;
			string uPosition = "Teacher";
			//password
			string Input = passwordtxt.Text.Trim();

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

			databaseHelper.AddTeacher(tFName, tLName, tContact);
			databaseHelper.AddUser(uUsername, uPosition, Input);
			MessageBox.Show("Record Added");

			this.Hide();
			Form5 Frm = new Form5();
			Frm.Show();
		}
	}
}
