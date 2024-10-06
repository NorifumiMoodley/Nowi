using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
//using Курсовая_Имитация_банкомата_;

namespace Course_Page
{
    public partial class ATMSimulationsForm : Form
    {
        public ATMSimulationsForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            Visible = false;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            QuizATMSimulations q1 = new QuizATMSimulations();
            q1.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //"C:\Users\dylan\Desktop\HomepagePRJT\HomepagePRJT\HomePage\ATM.application"
            string appPath = "..\\..\\ATM.application";
            //"C:\Users\dylan\Desktop\HomepagePRJT\HomepagePRJT\HomePage\ATMSim\ATM.application"
            try
            {
                Process.Start(appPath);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }

            /*

            try
            {
                // Define the file name
                string fileName = "ATM.application";

                // Try to find the file in the application's directory or its subfolders
                string appDirectory = AppDomain.CurrentDomain.BaseDirectory; // Current app directory
                string appPath = FindFileInDirectory(appDirectory, fileName);

                if (!string.IsNullOrEmpty(appPath) && File.Exists(appPath))
                {
                    // Start the .application file
                    Process.Start(appPath);
                }
                else
                {
                    MessageBox.Show("Application file not found!");
                }
            }
            catch (Exception ex)
            {
                // Handle errors
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        // Helper method to search for the file in a directory and subdirectories
        private string FindFileInDirectory(string directory, string fileName)
        {
            try
            {
                // Search for the file in the directory and subdirectories
                foreach (var file in Directory.EnumerateFiles(directory, fileName, SearchOption.AllDirectories))
                {
                    return file;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error searching for file: {ex.Message}");
            }

            return null;
        }*/
        }
    }

}
    

