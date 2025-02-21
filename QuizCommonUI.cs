﻿using System;
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

namespace Course_Page
{
    public partial class QuizCommonUI : Form
    {
        public QuizCommonUI()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CommonUIForm f1 = new CommonUIForm();
            f1.Show();
            Visible = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // Check if the quiz is complete before calculating the score
            if (QuizIncomplete())
            {
                Incomplete.Text = "Quiz Incomplete!";
            }
            else
            {
                int score = CalculateScore();
                int percentage = (score * 100) / 50; // 50 is the total score
                Mark.Text = percentage.ToString() + "%";

                string line = "";
                StreamReader sr = new StreamReader(@"Data Source = ..\..\username.txt");

                line = sr.ReadLine();

                sr.Close();
                Console.ReadLine();
                string name = line;
                databaseHelper dbh = new databaseHelper();
                int uID = dbh.getUid(name);
                int qID = dbh.getQuizID(uID);
                int q3 = dbh.getQ3(qID);
                databaseHelper.updateQ3(qID, percentage);

                if (q3 == 0 && !QuizIncomplete())
                {
                    string line3 = "";
                    using (StreamReader sr3 = new StreamReader(@"Data Source = ..\..\progress.txt"))
                    {
                        line3 = sr3.ReadLine();
                        Console.ReadLine();
                    }

                    //sr.Close();

                    int progress = Convert.ToInt32(line3);
                    if (progress == 0)
                    {
                        progress = 20;
                        databaseHelper.updateProgress(qID, progress);
                        TextWriter txt4 = null;
                        string filePath4 = @"Data Source = ..\..\progress.txt";
                        txt4 = new StreamWriter(filePath4);
                        txt4.WriteLine(progress.ToString());
                        txt4.Close();
                    }
                    else if (progress < 100 && progress >= 20)
                    {
                        progress += 20;
                        databaseHelper.updateProgress(qID, progress);
                        TextWriter txt5 = null;
                        string filePath5 = @"Data Source = ..\..\progress.txt";
                        txt5 = new StreamWriter(filePath5);
                        txt5.WriteLine(progress.ToString());
                        txt5.Close();
                    }
                    else
                    {
                        progress = 100;
                        databaseHelper.updateProgress(qID, progress);
                        TextWriter txt6 = null;
                        string filePath6 = @"Data Source = ..\..\progress.txt";
                        txt6 = new StreamWriter(filePath6);
                        txt6.WriteLine(progress.ToString());
                        txt6.Close();
                    }
                }
                else
                {
                    MessagBox.ShowBox("Are you sure you want to re-attempt? Your progress will not change.");
                }
            }
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
            if (rb1OptionA.Checked) totalScore += 10; // Question 1
            if (rb2OptionB.Checked) totalScore += 10; // Question 2
            if (rb3OptionC.Checked) totalScore += 10; // Question 3
            if (rb4OptionA.Checked) totalScore += 10; // Question 4
            if (rb5OptionC.Checked) totalScore += 10; // Question 5

            return totalScore;
        }
    }
}
