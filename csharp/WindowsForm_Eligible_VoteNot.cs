using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Eligible_VoteNot
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
            if(18 <= num)
            {
                label2.Text = "Your Age is Eligible to Voit....";
            }
            else
            {
                label2.Text = "Sorry! You are Not Eligible to voit...";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
