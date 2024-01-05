using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_dataconnection_EmpCUSD
{
    public partial class Form1 : Form
    {
        public string ConnectionString { get; set; } = @"Data Source = .\sqlexpress; Initial Catalog = MkpSample; Integrated Security = true;"; SqlDataAdapter Sqlda;
        DataSet dataset;
        SqlCommandBuilder cb;

        public Form1()
        {
            InitializeComponent();
            Sqlda = new SqlDataAdapter("Select * from Employee", ConnectionString);
            cb = new SqlCommandBuilder(Sqlda);
            dataset = new DataSet();
            Sqlda.Fill(dataset,"Emp");
        }

       
        //Create
        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = dataset.Tables["Emp"].NewRow();
            dr[0] = textBox1.Text;
            dr[1] = textBox2.Text;
            dr[2] = textBox3.Text;
            dr[3] = Convert.ToInt16(textBox4.Text);
            dr[4] = textBox5.Text;
            dr[5] = textBox6.Text;
            dr[6] = Convert.ToInt32(textBox7.Text);
            dataset.Tables["Emp"].Rows.Add(dr);
            Sqlda.Update(dataset.Tables["Emp"]);
            MessageBox.Show("Data Successfully Inserted...");
        }

        //Update
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dataset.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr[0] = textBox1.Text;
                        dr[1] = textBox2.Text;
                        dr[2] = textBox3.Text;
                        dr[3] = Convert.ToInt16(textBox4.Text);
                        dr[4] = textBox5.Text;
                        dr[5] = textBox6.Text;
                        dr[6] = Convert.ToInt32(textBox7.Text);
                        Sqlda.Update(dataset.Tables["Emp"]);
                        MessageBox.Show("Data Successfully Updated...");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }
        //Select
        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dataset.Tables["Emp"];
        }

        //Delete
        private void button4_Click(object sender, EventArgs e)
        {
            int intCounter = 0;
            DataRow drTarget;
            foreach (DataRow dr in dataset.Tables["Emp"].Rows)
            {
                if (dr[0].ToString() == textBox1.Text)
                {
                    try
                    {
                        dr.Delete();
                        Sqlda.Update(dataset.Tables["Emp"]);
                        dataset.Tables["Emp"].AcceptChanges();
                        MessageBox.Show("Data Successfully Deleted..");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1[0, e.RowIndex].Value.ToString();
            textBox2.Text = dataGridView1[1, e.RowIndex].Value.ToString();
            textBox3.Text = dataGridView1[2, e.RowIndex].Value.ToString();
            textBox4.Text = dataGridView1[3, e.RowIndex].Value.ToString();
            textBox5.Text = dataGridView1[4, e.RowIndex].Value.ToString();
            textBox6.Text = dataGridView1[5, e.RowIndex].Value.ToString();
            textBox7.Text = dataGridView1[6, e.RowIndex].Value.ToString();      
        }
    }
}
