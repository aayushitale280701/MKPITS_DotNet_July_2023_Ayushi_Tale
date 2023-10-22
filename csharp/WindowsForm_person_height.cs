using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_person_height
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

            if(num>=110)
            {
                label2.Text = "The person is Dwarf.";
            }
            else
            {
                label2.Text = "The person is Not Dwarf.";
            }
        }
    }
}
