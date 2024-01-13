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

namespace WindowsForms_Fendal_Product
{
    public partial class Form1 : Form
    {
        string strcon = "server=LAPTOP-SUPR1U1K\\SQLEXPRESS; integrated security=true; database=ProductCategory_Fendal";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public enum Nationality { Indian,Nri}
        Nationality nat;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getcategory();
            getproduct();
            getprice();
            nat = Nationality.Indian;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Enter Only Number...");
            }
        }

        public void getcategory()
        {
            con = new SqlConnection(strcon);
            da = new SqlDataAdapter("select * from TableProductCategory", con);
            ds = new DataSet();
            da.Fill(ds, "tpc");
            comboBox1.DataSource = ds.Tables["tpc"];
            comboBox1.DisplayMember = "Product_Type_Name";
            comboBox1.ValueMember = "Product_Category_id";
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBox10.Text = "0";
            textBox11.Text = "0";
            getproduct();
            string catname = comboBox1.Text;

            if (comboBox1.Text != "System.Data.DataRowView")
            {                
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProductGSTDetail where GstDetail_Name=@gdn", con);
                da.SelectCommand.Parameters.AddWithValue("@gdn", catname);
                ds = new DataSet();
                da.Fill(ds,"tgst");
                foreach(DataRow dr in ds.Tables["tgst"].Rows)
                {
                    textBox3.Text = dr["cgst"].ToString();
                    textBox4.Text = dr["sgst"].ToString();
                    textBox5.Text = dr["igst"].ToString();
                }
            }
        }

        public void getproduct()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProduct where Product_Category_id=@Pci", con);
                da.SelectCommand.Parameters.AddWithValue("@Pci", comboBox1.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp");
                comboBox2.DataSource = ds.Tables["tp"];
                comboBox2.DisplayMember = "ProductName";
                comboBox2.ValueMember = "ProductId";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox10.Text = "0";
            textBox11.Text = "0";
            getprice();
        }

        public void getprice()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableProduct where ProductId=@PI", con);
                da.SelectCommand.Parameters.AddWithValue("@PI", comboBox2.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp1");

                foreach (DataRow dr in ds.Tables["tp1"].Rows)
                {
                    textBox9.Text = dr["ProductPrice"].ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                nat = Nationality.Indian;
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(!radioButton2.Checked)
            {
                nat = Nationality.Nri;
                textBox10.Text = "0";
                textBox11.Text = "0";
                textBox12.Text = "0";
                textBox6.Text = "0";
                textBox7.Text = "0";
                textBox8.Text = "0";
            }
        }


        //Quantity textbox10
        double tcgst = 0;
        double tsgst = 0;
        double tigst = 0;
        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                double price = Convert.ToDouble(textBox9.Text);
                double quantity = Convert.ToDouble(textBox10.Text);
                double totalamount = price * quantity;
                textBox11.Text = totalamount.ToString();

                double pcgst = Convert.ToDouble(textBox3.Text);
                tcgst = totalamount * (pcgst / 100);
                textBox6.Text = tcgst.ToString();

                double psgst = Convert.ToDouble(textBox4.Text);
                tsgst = totalamount * (psgst / 100);
                textBox7.Text = tsgst.ToString();

                double pigst = Convert.ToDouble(textBox5.Text);
                tigst = totalamount * (pigst / 100);
                textBox8.Text = tigst.ToString();

                if (nat.ToString() == "Indian")
                {
                    double netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox7.Text) + Convert.ToDouble(textBox8.Text);
                    textBox12.Text = netamount.ToString();
                }
                else if (nat.ToString() == "Nri")
                {
                    double netamount = Convert.ToDouble(textBox11.Text) + Convert.ToDouble(textBox8.Text);
                    textBox12.Text = netamount.ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("You can not left blank any filed...");
            }
            else
            {
                SqlConnection conn = new SqlConnection(strcon);
                conn.Open();
                string s1 = "insert into TableInvoiceDetails values (@Customer_Name,@Customer_Contact,@Product_Category_id,@ProductId," +
                                                                    "@Residential_Type_Id,@Invoice_Date,@Quantity,@Price,@CGST,@SGST,@IGST," +
                                                                    "@CGST_value,@SGST_Value,@IGST_Value,@TotalAmount)";

                SqlCommand cmd = new SqlCommand(s1, conn);
                cmd.Parameters.AddWithValue("@Customer_Name", textBox1.Text);
                cmd.Parameters.AddWithValue("@Customer_Contact", textBox2.Text);
                cmd.Parameters.AddWithValue("@Product_Category_id", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@ProductId", comboBox2.SelectedValue);
                cmd.Parameters.AddWithValue("@Residential_Type_Id", 1010);
                cmd.Parameters.AddWithValue("@Invoice_Date", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@Quantity", textBox10.Text);
                cmd.Parameters.AddWithValue("@Price", textBox9.Text);
                cmd.Parameters.AddWithValue("@CGST", textBox3.Text);
                cmd.Parameters.AddWithValue("@SGST", textBox4.Text);
                cmd.Parameters.AddWithValue("@IGST", textBox5.Text);
                cmd.Parameters.AddWithValue("@CGST_value", textBox6.Text);
                cmd.Parameters.AddWithValue("@SGST_Value", textBox7.Text);
                cmd.Parameters.AddWithValue("@IGST_Value", textBox8.Text);
                cmd.Parameters.AddWithValue("@TotalAmount", textBox12.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                Clear();
                MessageBox.Show("Record inserted in TableInvoiceDetails");
            }
        } 
        
        public void Clear()
        {
            dateTimePicker1.Value = DateTime.Today;
            comboBox1.Text = "---Select---";
            comboBox2.Text = "--- Select---";
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";    
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "0";
            textBox11.Text = "0";
            textBox12.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
    

