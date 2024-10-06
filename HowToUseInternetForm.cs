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
    public partial class HowToUseInternetForm : Form
    {
        public HowToUseInternetForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.Show();
            Visible = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            QuizHowToUseInternet q2 = new QuizHowToUseInternet();
            q2.Show();
            Visible = false;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            HowToUseInternetSafePractices sp = new HowToUseInternetSafePractices();
            sp.Show();
            Visible = false;
        }
    }
}
