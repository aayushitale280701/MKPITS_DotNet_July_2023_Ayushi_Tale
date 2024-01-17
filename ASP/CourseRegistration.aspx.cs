using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_CourseRegistration
{
    public partial class CourseRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (RadioButton4.Checked)
            {
                TextBox3.Text = "1000";
            }
        }
        public enum category { Student, It_Profession }
        category cat;

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            sb.Append("Full Name : " + TextBox1.Text + "<br>");
            sb.Append("Payment Date : " + TextBox2.Text + "<br>");
            sb.Append("Total Amount : " + TextBox3.Text + "<br>");
            sb.Append("Fees Paid : " + TextBox4.Text + "<br>");
            sb.Append("Balance Amount : " + TextBox5.Text + "<br>");

            string g = null;
            if (RadioButton1.Checked)
            {
                g = RadioButton1.Text;
            }
            else if (RadioButton2.Checked)
            {
                g = RadioButton2.Text;
            }
            else if (RadioButton3.Checked)
            {
                g = RadioButton3.Text;
            }
            sb.Append("Gender : " + g + "<br>");

            string cat = null;
            if (RadioButton5.Checked)
            {
                cat = RadioButton4.Text;
            }
            else if (RadioButton5.Checked)
            {
                cat = RadioButton5.Text;
            }
            sb.Append("Category : " + cat + "<br>");

            sb.Append("Country : " + DropDownList1.Text + "<br>");
            sb.Append("State : " + DropDownList2.Text + "<br>");
            sb.Append("City : " + DropDownList3.Text + "<br>");

            Label11.Text = sb.ToString();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string c = DropDownList1.Text;
            DropDownList2.Items.Clear();
            
            switch (c)
            {
                case "India":
                    DropDownList2.Items.Add("Maharashtra");
                    DropDownList2.Items.Add("MP");
                    DropDownList2.Items.Add("UP");
                    break;

                case "USA":
                    DropDownList2.Items.Add("New York");
                    DropDownList2.Items.Add("Chicago");
                    DropDownList2.Items.Add("San Francisco");
                    break;

                case "Shri Lanka":
                    DropDownList2.Items.Add("Colombo");
                    DropDownList2.Items.Add("Kandy");
                    DropDownList2.Items.Add("Jaffna");
                    break;
            }

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = DropDownList2.Text;
            DropDownList3.Items.Clear();

            switch (s)
            {
                case "Maharashtra":
                    DropDownList3.Items.Add("Mumbai");
                    DropDownList3.Items.Add("Pune");
                    DropDownList3.Items.Add("Nagpur");
                    break;

                case "MP":
                    DropDownList3.Items.Add("Chhatisghar");
                    DropDownList3.Items.Add("Jabalpur");
                    DropDownList3.Items.Add("Indor");
                    break;

                case "UP":
                    DropDownList3.Items.Add("Bhopal");
                    DropDownList3.Items.Add("Jarkhand");
                    DropDownList3.Items.Add("Bihar");
                    break;

                case "New York":
                    DropDownList3.Items.Add("New Jersey");
                    DropDownList3.Items.Add("Yonkers");
                    DropDownList3.Items.Add("White Plains");
                    break;

                case "Chicago":
                    DropDownList3.Items.Add("Harlem");
                    DropDownList3.Items.Add("Brooklyn");
                    DropDownList3.Items.Add("Flushing");
                    break;

                case "San Francisco":
                    DropDownList3.Items.Add("Colombia");
                    DropDownList3.Items.Add("Mexico");
                    DropDownList3.Items.Add("Philippines");
                    break;

                case "Colombo":
                    DropDownList3.Items.Add("Kolpity");
                    DropDownList3.Items.Add("bambalapitiya");
                    DropDownList3.Items.Add("Pettah");
                    break;

                case "Kandy":
                    DropDownList3.Items.Add("Matale");
                    DropDownList3.Items.Add("Nuwara Eilya");
                    DropDownList3.Items.Add("South Kandy");
                    break;

                case "Jaffna":
                    DropDownList3.Items.Add("Kilinochchi");
                    DropDownList3.Items.Add("Mullaitivu");
                    DropDownList3.Items.Add("Vavuniya");
                    break;
            }            
        }
        

        float fp=0;
        float bamt=0;
        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();

            if (cat.ToString() == "Student")
            {
                
                float ta = Convert.ToSingle(TextBox3.Text);
                fp = ta * 0.5f;
                float amt = Convert.ToSingle(TextBox4.Text);
                if(amt < fp)
                {
                    Response.Write("Minimum amount to be paid 50 per...!");
                    TextBox5.Text = "0";
                }
                else
                {
                    bamt = ta - amt;
                    TextBox5.Text = bamt.ToString();
                }
            }
            else if (cat.ToString() == "It_Profession")
            {
                float ta = Convert.ToSingle(TextBox3.Text);
                fp = ta * 0.5f;
                float amt = Convert.ToSingle(TextBox4.Text);
                if (amt < fp)
                {
                    Response.Write("Minimum amount to be paid 50 per...!");
                }
                else
                {
                    bamt = ta - amt;
                    TextBox5.Text = bamt.ToString();
                }
                sb.Append("Total Amount : " + TextBox3.Text + "<br>");
            }
        }

        protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
        {
            cat = category.Student;
            TextBox3.Text = "1000";
            TextBox4.Text = "0";
            TextBox5.Text = "0";
        }

        protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            cat = category.It_Profession;
            TextBox3.Text = "3000";
            TextBox4.Text = "0";
            TextBox5.Text = "0";
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}