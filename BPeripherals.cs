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
    public partial class BPeripherals : Form
    {
        public BPeripherals()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BMemStorage memStorage = new BMemStorage();
            memStorage.Show();
            Visible = false;
        }

        private void btnQuiz1_Click(object sender, EventArgs e)
        {
            QuizBasicsOfAComputer q1 = new QuizBasicsOfAComputer();
            q1.Show();
            Visible=false;
        }
    }
}
