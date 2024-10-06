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
    public partial class HowToUseInternetSafePractices : Form
    {
        public HowToUseInternetSafePractices()
        {
            InitializeComponent();
        }

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            QuizHowToUseInternet q = new QuizHowToUseInternet();
            q.Show();
            Visible = false;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            HowToUseInternetForm q = new HowToUseInternetForm();
            q.Show();
            Visible = false;
        }
    }
}
