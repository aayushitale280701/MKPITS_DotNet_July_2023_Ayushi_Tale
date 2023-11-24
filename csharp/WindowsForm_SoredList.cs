using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace WindowsForm_SoredList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SortedList sl = new SortedList();
        private void button1_Click(object sender, EventArgs e)
        {
            sl.Add(textBox1.Text, Convert.ToInt32(textBox2.Text));
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            ICollection key = sl.Keys;
            foreach (string o in key)
            {
                sb.Append("Student Name:"+o+"\n");
            }
            label3.Text = sb.ToString();

            StringBuilder sb2 = new StringBuilder();
            ICollection k = sl.Values;
            foreach(int o in k)
            {
                sb2.Append("Student Roll no:  "+o+"\n");
            }
            label4.Text = sb2.ToString();
        }
    }
}
