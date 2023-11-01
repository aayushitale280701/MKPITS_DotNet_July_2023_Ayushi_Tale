using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_RectangleClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle();
            rect.width = Convert.ToInt32(textBox1.Text);
            rect.height= Convert.ToInt32(textBox2.Text);

            rect.getdata(rect.width, rect.height);

            StringBuilder sb = new StringBuilder();
            sb.Append(" Area of Rectangle: " +rect.area +"\n" );
            label3.Text = sb.ToString();
        }
    }
}
/* class file
 internal class Rectangle
    {
        public int width;
        public int height;
        public float area;

        public void getdata(int width, int height)
        {
            this.width = width;
            this.height = height;
            area = width * height;
        }
    }
