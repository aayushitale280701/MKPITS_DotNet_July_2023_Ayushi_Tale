using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_RegistrationForm
{
    public partial class RForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Username : " + TextBox1.Text + "<br>");
            sb.Append("Password : " + TextBox2.Text + "<br>");
            sb.Append("Address : " + TextBox3.Text + "<br>");

            string g = null;
            if (RadioButton1.Checked)
            {
                g = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                g = RadioButton2.Text;
            }
            sb.Append("Gender : " + g + "<br>");

            string h = null;
            if (CheckBox1.Checked)
            {
                h = h + " " + CheckBox1.Text;
            }
            if (CheckBox2.Checked)
            {
                h = h + " " + CheckBox2.Text;
            }
            sb.Append("Hobby : " + h + "<br>");

            sb.Append("Country : " + DropDownList1.Text + "<br>");
            sb.Append("City : " + DropDownList2.Text + "<br>");

            string c = null;
            foreach(ListItem li in ListBox1.Items)
            {
                if (li.Selected)
                {
                    c = c + li.Value + "<br>";
                }
            }
            sb.Append("Courses : " + c + "<br>");

            string cen = null;
            foreach(ListItem li in CheckBoxList1.Items)
            {
                if (li.Selected)
                {
                    cen +=  li.Value + "<br>";
                }
            }
            sb.Append("Center : " + cen + "<br>");
            Label1.Text = sb.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;
            DropDownList2.Items.Clear();
            switch (c)
            {
                case "India":
                    DropDownList2.Items.Add("Nagpur");
                    DropDownList2.Items.Add("Pune");
                    DropDownList2.Items.Add("Solapur");
                    break;

                case "USA":
                    DropDownList2.Items.Add("New York City");
                    DropDownList2.Items.Add("Chicago");
                    DropDownList2.Items.Add("San Francisco");
                    break;

                case "Shri Lanka":
                    DropDownList2.Items.Add("Colombo");
                    DropDownList2.Items.Add("Kandy");
                    DropDownList2.Items.Add("Galle");
                    break;
            }
        }
    }
}