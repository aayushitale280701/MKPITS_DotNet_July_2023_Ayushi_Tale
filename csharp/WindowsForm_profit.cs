using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_profit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sp=Convert.ToInt32(textBox1.Text);
            int cp=Convert.ToInt32(textBox2.Text);

            int Profit = sp - cp;
            if (sp>cp)
            {
                label3.Text = ("You got profit.");
            }
            else
            {
                label3.Text = "You got loss.";
            }
        }
    }
}
