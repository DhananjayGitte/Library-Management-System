using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryM
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void t1_Click(object sender, EventArgs e)
        {
            if (t1.Text == "Username")
            {
                t1.Clear();
            }
        }

        private void t2_Click(object sender, EventArgs e)
        {
            if (t2.Text == "Password")
            {
                t2.Clear();
                t2.PasswordChar = '*';
            }
        }

        private void t2_TextChanged(object sender, EventArgs e)
        {
            if (t2.Text == "")
            {
                t2.PasswordChar = '*';
            }
            else
            {
                t2.PasswordChar = '*';
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Currently Unavailable\nProcess is in Development...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t1.Text == "")
            {
                MessageBox.Show("Please Enter your Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t1.Focus();
            }
            else if (t2.Text == "")
            {
                MessageBox.Show("Please Enter your Password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                t2.Focus();
            }
            else if (t1.Text != "admin")
            {
                MessageBox.Show("Invalid Username.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t1.Clear();
                t1.Focus();
            }
            else if (t2.Text != "admin123")
            {
                MessageBox.Show("Invalid password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                t2.Clear();
                t2.Focus();
            }
            else
            {
                Form1 f1= new Form1();
                f1.ShowDialog();
                t1.Clear();
                t2.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
