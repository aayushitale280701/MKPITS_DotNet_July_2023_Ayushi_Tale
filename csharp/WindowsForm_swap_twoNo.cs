using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_swap_twoNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1;
            num1=Convert.ToInt32(textBox1.Text);
            int num2;
            num2= Convert.ToInt32(textBox2.Text);
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            label3.Text = "Swap Number 1 :- " + num1;
            label4.Text = "Swap Number 2 :- " + num2;

        }
    }
}
