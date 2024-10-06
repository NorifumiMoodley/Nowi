using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course_Page
{
    public partial class HowToGmailForm2 : Form
    {
        public HowToGmailForm2()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HowToGmailForm form1 = new HowToGmailForm();
            form1.Show();
            Visible = false;
        }

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            QuizHowToUseGmail quizHowToUseGmail = new QuizHowToUseGmail();
            quizHowToUseGmail.Show();
            Visible = false;
        }
    }
}
