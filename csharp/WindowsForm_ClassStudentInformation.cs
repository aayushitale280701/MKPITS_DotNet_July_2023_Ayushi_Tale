using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ClassStudentInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.name = textBox1.Text;
            s.rollno=Convert.ToInt32(textBox2.Text);
            s.marks[0]=Convert.ToInt32(textBox3.Text);
            s.marks[1]=Convert.ToInt32(textBox4.Text);
            s.marks[2]=Convert.ToInt32(textBox5.Text);

            StringBuilder sb = new StringBuilder();
            s.getdata(s.name, s.rollno, s.marks);
            sb.Append("\n Name : " + s.name);
            sb.Append("\n Roll no : " + s.rollno);
            sb.Append("\n Total : " + s.total);
            sb.Append("\n Avrage : " +s.avr);
            label6.Text = sb.ToString();
        }
    }
}

/* class file Strudent
 
 public string name;
        public int rollno;
        public int[] marks = new int[3];
        public int total;
        public float avr;

        public void getdata(string name,int rollno, int[] marks)
        {
            this.name = name;
            this.rollno = rollno;
            this.marks = marks;

            for (int i = 0; i < 3; i++)
            {
                total = total + marks[i];
                   
            }
             avr = total / 3.0f;

        }
