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
    public partial class BMemStorage : Form
    {
        public BMemStorage()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            BSoftwareSection s = new BSoftwareSection();
            s.Show();
            Visible = false;
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            BNetworking bNetworking = new BNetworking();
            bNetworking.Show();
            Visible=false;
        }
    }
}
