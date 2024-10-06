using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace HomePage
{
	public partial class Form7 : Form
	{
		public Form7()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{   string password = passwordtxt.Text.Trim();
            String line;

            HashAlgorithm algorithm = null;
            string pwd = password;
            string hashPassword;
            using (var sHA256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(pwd);
                byte[] hashBytes = sHA256.ComputeHash(inputBytes);
                hashPassword = BitConverter.ToString(hashBytes).Replace("-", "");

                password = hashPassword;
            }

            try
            {
                StreamReader sr = new StreamReader(@"C:\Users\Caldon\Desktop\New folder (2)\HomepagePRJT\HomePage\username.txt");

                line = sr.ReadLine();

                sr.Close();
                Console.ReadLine();
                string name = line;
                databaseHelper.updatePassword(name, password);

                MessagBox.ShowBox("Password Changed Successfully");
            }
            
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }

            
			//string fileContent = string.Empty;
            //string filePath = "C:\\Users\\Caldon\\Documents\\CTRL_APP\\CTRL_APP\\HomepagePRJT (1)\\HomepagePRJT\\HomePage\\username.txt";
			
		}
	}
}
