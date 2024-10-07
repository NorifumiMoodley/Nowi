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
    public partial class HowToGmailForm : Form
    {
        public HowToGmailForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            Visible = false;
        }

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            QuizHowToUseGmail f1 = new QuizHowToUseGmail();
            f1.Show();
            Visible = false;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            HowToGmailForm2 form2 = new HowToGmailForm2();
            form2.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string whatevavariableIwannacallit = "C:\\Users\\Caldon\\Desktop\\Gmail Tutorial - Made with Clipchamp\\Gmail Tutorial - Made with Clipchamp.mp4";
            axWindowsMediaPlayer1.URL = whatevavariableIwannacallit;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            HowToGmailForm2 howToGmailForm2 = new HowToGmailForm2();
            this.Hide();
            howToGmailForm2.Show();
        }
    }
}
