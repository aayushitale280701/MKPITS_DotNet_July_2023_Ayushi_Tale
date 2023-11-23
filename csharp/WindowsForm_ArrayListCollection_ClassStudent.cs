using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ArrayListCollection_ClassStudent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Student s;
        ArrayList ar = new ArrayList();

        private void button1_Click(object sender, EventArgs e)
        {
            s = new Student(Convert.ToInt32(textBox1.Text), textBox2.Text);
            ar.Add(s);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(Student s in ar)
            {
                sb.Append("Roll No  " + s.rno + "\n" + "Name  " + s.name + "\n");
            }
            label3.Text = sb.ToString();
        }
    }
}
/*internal class Student
    {
        public int rno;
        public String name;
        public Student(int rno, string name)
        {
            this.rno = rno;
            this.name = name;
        }
    }
*/