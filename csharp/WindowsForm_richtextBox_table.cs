using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_richtextBox_table
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int num = Convert.ToInt32(textBox1.Text);
            int res = 1;

            for (int cnt = 1; cnt <= 10; cnt++)
            {
                res = num * cnt;
                sb.Append(num + " * " + cnt + " = " + res + "\n");
            }
            richTextBox1.Text = sb.ToString();
        }
    }
}
