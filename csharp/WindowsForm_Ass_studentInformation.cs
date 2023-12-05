using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Ass_studentInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome....!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            string name = textBox1.Text;
            string age = numericUpDown1.Text;
            if(textBox1.Text == " ")
            {
                MessageBox.Show("Please Enter Your Name and Age... ");
            }
            if(numericUpDown1.Value <= 18)
            {
                MessageBox.Show("Please Enter Age Greater-than 18... ");
            }
            else
            {
                sb.Append("Name: " + textBox1.Text + "\n");
                sb.Append("Age:  " + numericUpDown1.Value.ToString() + "\n");        
            }
            label3.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            numericUpDown1.Value = 0;
            
        }
    }
}
