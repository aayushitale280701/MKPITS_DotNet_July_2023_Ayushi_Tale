using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_factorial_usingClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Factorial f = new Factorial();
            f.dispaly(Convert.ToInt32(textBox1.Text));
           
            label2.Text = "Factorial:  " + f.fact;
        }
    }
}

/*internal class Factorial
    {
        public int num;
        public int fact=1;
        public void dispaly(int num)
        {
            while(num>0)
            {
                fact = fact * num;
                num--;
            }
        }
    }
*/
