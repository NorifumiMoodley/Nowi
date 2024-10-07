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
    public partial class AssignTeacher : Form
    {
        public AssignTeacher()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 frm = new Form5();
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
            int uID2 = dbh.getUid(line2);
            int TeacherID = dbh.getTid(uID2);
            int uID = dbh.getUid(textBox1.Text);
            int qID = dbh.getQuizID(uID);
            databaseHelper.updateTid(uID, TeacherID);
            databaseHelper.updateQuizTID(qID, TeacherID);
        }
    }
}
