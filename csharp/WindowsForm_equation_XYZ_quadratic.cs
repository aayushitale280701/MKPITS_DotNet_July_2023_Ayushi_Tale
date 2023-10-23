using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_equation_XYZ_quadratic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x, y, z;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            z = Convert.ToInt32(textBox3.Text);

            int result = x * y - 4 * x * z;
            if (result != 0)
            {
                label4.Text = "It is imaginanry";
            }
            else
            {
                label4.Text = "It is real";
            }
        }
    }
}
