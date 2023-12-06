using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_MDI_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountForm a = new AccountForm();
            a.MdiParent = this;
            a.Show();
        }

        private void registrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRegistration r = new FormRegistration();
            r.MdiParent = this;
            r.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }

        private void accountFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AccountForm a = new AccountForm();
            a.MdiParent = this;
            a.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountFormToolStripMenuItem.Enabled = true;
            registrationFormToolStripMenuItem.Enabled = true;
            toolStripButton1.Enabled = true;
            toolStripButton2.Enabled = true;

            if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                MessageBox.Show("Log in sucessfully !");
                panel1.Hide();
            }   
            else
            {
                MessageBox.Show("Enter Correct User Name and Password...!");
            }
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void titleHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void titleVarticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void registrationFormToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormRegistration r = new FormRegistration();
            r.MdiParent = this;
            r.Show();

        }
    }
}
