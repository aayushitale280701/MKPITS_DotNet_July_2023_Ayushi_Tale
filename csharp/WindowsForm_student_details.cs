using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_student_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //array object

        Student[] std = new Student[10];
        int cnt = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            std[0] = new Student();
            std[1] = new Student();
            std[2] = new Student();
            std[3] = new Student();
            std[4] = new Student();
            std[5] = new Student();
            std[6] = new Student();
            std[7] = new Student();
            std[8] = new Student();
            std[9] = new Student();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cnt < 10)
            {
                std[cnt].name = textBox1.Text;
                std[cnt].rollno=Convert.ToInt32(textBox2.Text);
                std[cnt].fees=Convert.ToDouble(textBox3.Text);
                std[cnt].date=textBox4.Text;
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                if (cnt==10)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("Details of 10 student accepted");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("Student details are : " + "\n");
            for (int i=0; i<10; i++)
            {
                sb1.Append("---------------------------------------\n");
                sb1.Append("Student RollNo : " + std[i].rollno+"\n");
                sb1.Append("Student Name : " + std[i].name + "\n");
                sb1.Append("Student Fee : " + std[i].fees+ "\n");
                sb1.Append("Student Addmision Date : " +std[i].date+"\n");
                sb1.Append("---------------------------------------\n");
            }
            label5.Text = sb1.ToString();
            //1st student display
            double fees = std[0].fees;
            int flag = 0;
            for (int i=0; i<10;i++)
            {
                if (fees < std[i].fees)
                {
                    fees = std[i].fees;
                    flag = i;
                }
            }
            StringBuilder sb2 = new StringBuilder();
            sb2.Append("First Student With Fee.\n ");
            sb2.Append("Student RollNo : " + std[flag].rollno+"\n");
            sb2.Append("Student Name : " + std[flag].name + "\n");
            sb2.Append("Student Fees : " +std[flag].fees+"\n");
            sb2.Append("Student Addmision :" + std[flag].date+"\n");
            label6.Text = sb2.ToString();
        }
    }
}

/*internal class Student
    {
        public string name { get; set; }
        public int rollno { get; set; }
        public double fees { get; set; }

        public string  date { get; set; }
        
    }*/