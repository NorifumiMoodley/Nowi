using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomePage
{
    public partial class ReviewResult : Form
    {
        public ReviewResult()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm=new Form5();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line2 = "";

            using (StreamReader sr2 = new StreamReader(@"Data Source =..\..\username.txt"))
            {
                line2 = sr2.ReadLine();
                Console.ReadLine();
            }

            databaseHelper dbh = new databaseHelper();
            int uID = dbh.getUid(line2);
            int sID = dbh.getSid(uID);
            databaseHelper.FillTable3(dataGridView1, sID);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string line2 = "";

            using (StreamReader sr2 = new StreamReader(@"Data Source =..\..\username.txt"))
            {
                line2 = sr2.ReadLine();
                Console.ReadLine();
            }

            databaseHelper dbh = new databaseHelper();
            int uID = dbh.getUid(line2);
            //int sID = dbh.getSid(uID);
            int qID=dbh.getQuizID(uID);
            databaseHelper.FillTable4(dataGridView1, qID);
        }
    }
}
