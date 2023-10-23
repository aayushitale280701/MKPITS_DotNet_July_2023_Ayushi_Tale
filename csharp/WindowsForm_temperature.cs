using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int temp=Convert.ToInt32(textBox1.Text);
            
            if (temp<0)
            {
                label2.Text = "Freezing weather";
            }
            else if (temp > 0 && temp < 10)
            {
                label2.Text = "Cold weather";
            }
            else if (temp > 10 && temp < 20)
            {
                label2.Text = "Normal weather";
            }
            else if (temp > 20 && temp < 30)
            {
                label2.Text = "Its Hot weather";
            }
            else 
            {
                label2.Text = "Very Hot weather";
            }

        }
    }
}
