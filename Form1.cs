using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Student_final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void list_Click(object sender, EventArgs e)
        {

        }

        private void person_Click(object sender, EventArgs e)
        {

        }

        private void person_Click_1(object sender, EventArgs e)
        {
            Users p1 = new Users();
            p1.Show();
        }

        private void list_Click_1(object sender, EventArgs e)
        {
            List list = new List();
            list.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RelInfo2 relInfo2 = new RelInfo2();
            relInfo2.Show();

        }

        private void search_Click(object sender, EventArgs e)
        {
            Relation relation = new Relation();
            relation.Show();
        }
    }   
}
