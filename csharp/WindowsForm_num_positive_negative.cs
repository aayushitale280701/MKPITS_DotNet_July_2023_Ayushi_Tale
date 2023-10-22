using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_num_positive_negative
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

            if(num>0)
            {
                label2.Text = "Number is Positive";
            }
            else if(num<0)
            {
                label2.Text = "Number is Negetive";
            }
            else
            {
                label2.Text = "Number is Zero";
            }
        }
    }
}
