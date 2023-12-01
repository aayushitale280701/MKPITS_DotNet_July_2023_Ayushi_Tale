using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_MinorYoungOld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age = Convert.ToInt32(textBox1.Text);
            if (age <= 18)
            {
                label2.Text = "YOU ARE MINOR";
            }
            else if (age <= 60  )
            {
                label2.Text = "YOU ARE YOUNG";

            }
            else if (age <= 110)
            {
                label2.Text = "YOU ARE OLD";

            }
            else
            {
                label2.Text = "SORRY...!";

            }
        }
    }
}
