using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_switch_area_of_circle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float area;
            int r,num;
            num=Convert.ToInt32(textBox2.Text);
            
            switch (num)
            {
                case 1:
                    r = Convert.ToInt32(textBox2.Text);

                    area = 3.14f * r * r;
                    label2.Text = "Area of circle";
                    break;

            }
            
        }
    }
}
