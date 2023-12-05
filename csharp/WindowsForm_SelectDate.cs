using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_SelectDate
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

            string age = dateTimePicker1.Text;
            sb.Append("DOB:  " + age + "\n");

            int yr = dateTimePicker1.Value.Year;
            sb.Append("DOB Year:  " + yr + "\n");

            int cyr = DateTime.Now.Year;
            sb.Append("Current Year:  " + cyr + "\n");

            int diff = cyr - Convert.ToInt32(yr);
            sb.Append("Now Your Age is:  " + diff + "\n");
            label2.Text = sb.ToString();
        }
    }
}
