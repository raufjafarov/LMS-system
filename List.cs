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
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
        }

        private void List_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Teachers : ");
            for (int i = 0; i < Database.teachers.Length; i++)
            {
                if (Database.teachers[i] != null)
                {
                    MessageBox.Show(("ID : " + Database.teachers[i].Id + "\n" +
                     "Name : " + Database.teachers[i].Name + "\n" +
                     "Surname : " + Database.teachers[i].Surname + "\n" +
                      "---------"));
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Students :");
            for (int i = 0; i < Database.students.Length; i++)
            {
                if (Database.students[i] != null)
                {
                    MessageBox.Show(("ID : " + Database.students[i].Id + "\n" +
                     "Name : " + Database.students[i].Name + "\n" +
                     "Surname : " + Database.students[i].Surname + "\n" +
                      "---------"));
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
