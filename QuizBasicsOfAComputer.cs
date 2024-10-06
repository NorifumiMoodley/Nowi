using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Course_Page
{
    public partial class QuizBasicsOfAComputer : Form
    {
        public QuizBasicsOfAComputer()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BasicsOfAComputerForm back = new BasicsOfAComputerForm();
            back.Show();
            Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if the quiz is complete before calculating the score
            if (QuizIncomplete())
            {
                Incomplete.Text = "Quiz Incomplete!";
            }
            //@"Data Source =..\..\CTRL2.db;Version=3;"
            else
            {
                int score = CalculateScore();
                int percentage = (score * 100) / 50; // 50 is the total score
                Mark.Text = percentage.ToString() + "%";

                string line = "";
                StreamReader sr = new StreamReader(@"Data Source =..\..\username.txt");

                line = sr.ReadLine();

                sr.Close();
                Console.ReadLine();
                string name = line;
                databaseHelper dbh = new databaseHelper();
                int uID = dbh.getUid(name);
                int qID = dbh.getQuizID(uID);
                int q1 = dbh.getQ1(qID);
                databaseHelper.updateQ1(qID, percentage);
                
                if(q1 == 0)
                {   
                    string line2 = "";

                    using (StreamReader sr2 = new StreamReader(@"Data Source =..\..\progress.txt"))
                    {
                        line2 = sr2.ReadLine();
                        Console.ReadLine(); 
                    }

                    //sr.Close();
                    
                    int progress = Convert.ToInt32(line2);
                    if (progress == 0)
                    {
                        progress = 20;
                        databaseHelper.updateProgress(qID, progress);
                        TextWriter txt1 = null;
                        string filePath1 = @"Data Source =..\..\progress.txt";
                        txt1 = new StreamWriter(filePath1);
                        txt1.WriteLine(progress.ToString());
                        txt1.Close();
                    }
                    else if (progress < 100 && progress >=20)
                    { 
                        progress += 20;
                        databaseHelper.updateProgress(qID, progress);
                        TextWriter txt2 = null;
                        string filePath2 = @"Data Source =..\..\progress.txt";
                        txt2 = new StreamWriter(filePath2);
                        txt2.WriteLine(progress.ToString());
                        txt2.Close();
                    }
                    else
                    {
                        progress = 100;
                        databaseHelper.updateProgress(qID, progress);
                        TextWriter txt3 = null;
                        string filePath3 = @"Data Source =..\..\progress.txt";
                        txt3 = new StreamWriter(filePath3);
                        txt3.WriteLine(progress.ToString());
                        txt3.Close();
                    }
                }
                else
                {
                    MessagBox.ShowBox("Are you sure you want to re-attempt? Your progress will not change.");
                }
            }
            

            MessagBox.ShowBox("Password Changed Successfully");
        }

        // Method to check if any question is incomplete
        private bool QuizIncomplete()
        {
            // Return true if any question is unanswered
            if (!(rb1OptionA.Checked || rb1OptionB.Checked || rb1OptionC.Checked)) return true; // Question 1
            if (!(rb2OptionA.Checked || rb2OptionB.Checked || rb2OptionC.Checked)) return true; // Question 2
            if (!(rb3OptionA.Checked || rb3OptionB.Checked || rb3OptionC.Checked)) return true; // Question 3
            if (!(rb4OptionA.Checked || rb4OptionB.Checked || rb4OptionC.Checked)) return true; // Question 4
            if (!(rb5OptionA.Checked || rb5OptionB.Checked || rb5OptionC.Checked)) return true; // Question 5

            // If all questions are answered, return false
            return false;
        }

        private int CalculateScore()
        {
            int totalScore = 0;

            // Marks each question out of 10
            if (rb1OptionB.Checked) totalScore += 10; // Question 1
            if (rb2OptionA.Checked) totalScore += 10; // Question 2
            if (rb3OptionC.Checked) totalScore += 10; // Question 3
            if (rb4OptionA.Checked) totalScore += 10; // Question 4
            if (rb5OptionB.Checked) totalScore += 10; // Question 5

            return totalScore;
        }

    }
}
