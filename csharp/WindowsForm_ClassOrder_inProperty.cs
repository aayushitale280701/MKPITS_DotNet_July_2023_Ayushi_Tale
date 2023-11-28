using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ClassOrder_inProperty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, Orders> ordercollection = new Dictionary<int, Orders>();
        Orders ord = null;

        private void button1_Click(object sender, EventArgs e)
        {
            ord = new Orders(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
            ordercollection.Add(Convert.ToInt32(textBox1.Text), ord);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            MessageBox.Show("Customer objects added to dictionary colletion");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                int total = 0;
                StringBuilder sb = new StringBuilder();
                foreach (KeyValuePair<int, Orders> kvp in ordercollection)
                {
                    int amount = kvp.Value.rate * kvp.Value.quantity;
                    total = total + amount;
                    sb.Append("Order id " + kvp.Key + " Item name " + kvp.Value.itemname + "Rate " + kvp.Value.rate + "Qty " + kvp.Value.quantity + "Amount " + amount + "\n");

                }
                label5.Text = sb.ToString();
                MessageBox.Show("Total Amount " + total);

            }
        }
    }
}


/*class Orders
    {
        public int orderid { get; set; }
        public string itemname { get; set; }
        public int rate { get; set; }
        public int quantity { get; set; }
        public Orders(int o, string i, int r, int q)
        {
            orderid = o;
            itemname = i;
            rate = r;
            quantity = q;
        }
*/

