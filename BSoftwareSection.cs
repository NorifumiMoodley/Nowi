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
    public partial class BSoftwareSection : Form
    {
        public BSoftwareSection()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BasicsOfAComputerForm b1 = new BasicsOfAComputerForm();
            b1.Show();
            Visible = false;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            BMemStorage mem = new BMemStorage();
            mem.Show();
            Visible = false;
        }
    }
}
