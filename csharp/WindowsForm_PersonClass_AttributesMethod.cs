using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_PersonClass_AttributesMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person per=new person();
            per.name = textBox1.Text;
            per.addres = textBox2.Text;
            per.age=Convert.ToInt32(textBox3.Text);

           StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + per.name + "\n");
            sb.Append("Address : " + per.addres + "\n");
            sb.Append("Age : " + per.age + "\n");

            label4.Text = sb.ToString();
        }
    }
}
/*
 class file
 internal class person
    {
        public string name;
        public string addres;
        public int age;

        public void getdata(string name, string addres, int age)
        {
            this.name = name;
            this.addres = addres;   
            this.age = age;
        }
    }
