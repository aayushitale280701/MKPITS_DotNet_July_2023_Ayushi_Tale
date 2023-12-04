using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ProvideList_ComboBox
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
            string designation = comboBox1.Text;
            float bonus = 0.0f;
            float totalsal = 0.0f;
            label4.Text = " ";
            switch(designation)
            {
                case "Manager":
                    bonus = bsal * 0.55f;
                    break;

                case "Clerk":
                    bonus = bsal * 0.45f;
                    break;

                case "Peon":
                    bonus = bsal * 0.35f;
                    break;
            }
            totalsal = bsal + bonus;
            if (checkBox1.Checked)
                label4.Text = "Bonus " + bonus;
            if (checkBox2.Checked)
            {
                label4.Text = "Total sal " + totalsal;
            }

        }
    }
}
