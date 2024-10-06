using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class MessagBox : Form// missplled message ignore
    {
        static MessagBox newMessageBox;
        static string Buttin_ID;
        public MessagBox()
        {
            InitializeComponent();
        }
        public static string ShowBox(string txtMessage)
        {
            newMessageBox = new MessagBox();
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Buttin_ID;
        }
        public static string ShowBox(string txtMessage, string txtTitle)
        {
            newMessageBox = new MessagBox();
            newMessageBox.lblTitle.Text = txtTitle;
            newMessageBox.lblMessage.Text = txtMessage;
            newMessageBox.ShowDialog();
            return Buttin_ID;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            Buttin_ID = "1";
            newMessageBox.Dispose();
        }

        private void MessagBox_Load(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            lblTitle.Text=form1.Message;
            
        }
    }
}
