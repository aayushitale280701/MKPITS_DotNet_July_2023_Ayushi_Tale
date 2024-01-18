using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_Product
{
    public partial class Product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Order No : " + TextBox1.Text + "<br>");
            sb.Append("Customer Name : " + TextBox2.Text + "<br>");
            sb.Append("Order Date : " + TextBox3.Text + "<br>");
            sb.Append("Price : " + DropDownList1.Text + "<br>");
            sb.Append("Price : " + TextBox4.Text + "<br>");
            sb.Append("Quantity : " + TextBox5.Text + "<br>");
            sb.Append("Total : " + Convert.ToInt32(TextBox4.Text) * Convert.ToInt32(TextBox5.Text));
            Label1.Text = sb.ToString();
            
        }
    }
}