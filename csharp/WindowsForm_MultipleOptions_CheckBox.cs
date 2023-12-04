using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_MultipleOptions_CheckBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bsal = Convert.ToInt32(textBox2.Text);
            float bonus = bsal * 0.42f;
            float totalsal = bsal + bonus;
            label3.Text = " ";
            if (checkBox1.Checked)
            {
                label3.Text = "Bonus " + bonus;
            }
            else if (checkBox2.Checked)
            {
                label3.Text = "Total Salary  " + totalsal;
            }
            
        }
    }
}
