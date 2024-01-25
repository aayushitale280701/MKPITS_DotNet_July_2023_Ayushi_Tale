using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClintSideStateManagement_Temporary_cookie
{
    public partial class TemporaryCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Code to creat temporary cookie

            HttpCookie Cookie1 = new HttpCookie("Cook");
            Cookie1.Values.Add("Username:- ", TextBox1.Text);
            Response.Cookies.Add(Cookie1);
            Label2.Text = "Temporary cookie added to cilent machine...";
            //We don’t store cookie ie automatically stored by web server

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //code to retrieve cookie from client machine
            HttpCookie Cookie1 = Request.Cookies["Cook"];
            if (Cookie1 != null)
            {
                string uname = Cookie1.Values["Username:- "].ToString();
                Label2.Text = "Username:- " + uname;
            }
            else
            {
                Label2.Text = "No Cookie Exits...";
            }
        }
    }
}