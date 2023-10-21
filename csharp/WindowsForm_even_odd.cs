using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_even_odd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num=Convert.ToInt32(textBox1.Text);

            if (num % 2 == 0)
            {
                label2.Text = "Number the Even";
            }
            else
            {
                label2.Text = "Number is Odd";
            }
        }
    }
}
