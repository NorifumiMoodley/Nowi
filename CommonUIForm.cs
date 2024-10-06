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
    public partial class CommonUIForm : Form
    {
        public CommonUIForm()
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
            QuizCommonUI f1 = new QuizCommonUI();
            f1.Show();
            Visible = false;
        }
    }
}
