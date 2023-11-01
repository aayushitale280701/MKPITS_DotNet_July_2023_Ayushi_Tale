using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_class_person
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person per = new person();
            per.name=textBox1.Text;
            per.address=textBox2.Text;
            per.age = Convert.ToInt32(textBox3.Text);

            StringBuilder sb = new StringBuilder();
            sb.Append("Name : " + per.name + "\n");
            sb.Append("Address : " + per.address +"\n") ;
            sb.Append("Age : " +per.age+ "\n");

            label4.Text = sb.ToString();
        }
    }
}
