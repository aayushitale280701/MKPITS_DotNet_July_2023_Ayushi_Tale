using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_GenericCollection_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string,string> domains = new Dictionary<string, string>();
        private void button1_Click(object sender, EventArgs e)
        {
            domains.Add(textBox1.Text,textBox2.Text);
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            MessageBox.Show("Added in dictionary: ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(domains.Keys);
            foreach (string key in keys)
            {
                sb.Append("Keys in dictionay " + key + "\n");
            }
            label3.Text = sb.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            List<string> keys = new List<string>(domains.Values);
            foreach (string val in keys)
            {
                sb.Append("Values in dictionay " + val + "\n") ;
            }
            label4.Text = sb.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> kvp in domains)
            {
                sb.Append("Key " + kvp.Key + " Value " + kvp.Value + "\n");
            }
            label4.Text = sb.ToString();
        }
    }
}