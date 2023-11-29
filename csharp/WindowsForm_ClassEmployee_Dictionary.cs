using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ClassEmployee_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Employee> d = new Dictionary <int, Employee>();
        private void Button1_Click(object sender, EventArgs e)
        {
            Employee emp1 = new Employee(Convert.ToInt32(textBox1.Text), textBox2.Text);
            Employee emp2 = new Employee(Convert.ToInt32(textBox3.Text), textBox4.Text);
            d.Add(emp1.empid, emp1);
            d.Add(emp2.empid, emp2);
        }   

         
        private void button2_Click_1(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<int, Employee> kv in d)
            {
                sb.Append("Emp id " + kv.Key + "Emp name " + kv.Value.empname + "\n");
            }
            label5.Text = sb.ToString();
        }
    }
}


/*internal class Employee
{


    public int empid { get; set; }
    public string empname { get; set; }
    public Employee(int e1, string en)
    {
        empid = e1;
        empname = en;
    }
}
*/