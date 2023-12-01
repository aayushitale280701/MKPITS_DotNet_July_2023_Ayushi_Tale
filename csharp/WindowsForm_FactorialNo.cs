using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_FactorialNo
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

        private void button1_Click(object sender, EventArgs e)
        {
            int n= Convert.ToInt32(textBox1.Text);
            int fact = 1;

            while( n > 0)
            {
                fact = fact * n;
                n--;
            }
            label2.Text = "Factorial: " + fact;
        }
    }
}
