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
    public partial class BNetworking : Form
    {
        public BNetworking()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BMemStorage memStorage = new BMemStorage();
            memStorage.Show();
            Visible = false;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            BPeripherals bPeripherals = new BPeripherals();
            bPeripherals.Show();
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
