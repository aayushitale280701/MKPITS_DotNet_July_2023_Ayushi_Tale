using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_InstituteCourseRegistration_DataBase
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\SQLEXPRESS; integrated security=true; database=InstituteCourseRegistration_DataBase";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableNation order by NationID",con);
                ds = new DataSet();
                da.Fill(ds, "TableNation");
                comboBox1.DataSource = ds.Tables["TableNation"];
                comboBox1.DisplayMember = "NationName";
                comboBox1.ValueMember = "NationID";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableState where NationID=@NationID", con);
                    da.SelectCommand.Parameters.AddWithValue("NationID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableState");
                    comboBox2.DataSource = ds.Tables["TableState"];
                    comboBox2.DisplayMember = "StateName";
                    comboBox2.ValueMember = "StateID";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection (strcon);
                    da = new SqlDataAdapter("Select * from TableCity where StateID=@StateID", con);
                    da.SelectCommand.Parameters.AddWithValue("@StateID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableCity");
                    comboBox3.DataSource = ds.Tables["TableCity"];
                    comboBox3.DisplayMember = "CityName";
                    comboBox3.ValueMember = "CityID";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
