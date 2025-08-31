using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryM
{
    public partial class Form3 : Form
    {
        string cs, q;
        MySqlConnection c1;
        MySqlCommand cmd;
        MySqlDataReader d;
        public Form3()
        {
            InitializeComponent();
        }
        void clearall()
        {
            bname.Text = "";
            aut.Text = "";
            qua.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want to exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want to exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (bid.Text == "")
            {
                MessageBox.Show("Please enter your ID...");
                bid.Focus();
            }
            else
            {
                c1.Open();
                try
                {
                    int n = Convert.ToInt32(bid.Text);
                    q = "select * from books where bid = " + n;
                    cmd = new MySqlCommand(q, c1);
                    d = cmd.ExecuteReader();
                    if (d.Read())
                    {
                        bname.ReadOnly = false;
                        aut.ReadOnly = false;
                        qua.ReadOnly = false;

                        bname.Text = d["bname"].ToString();
                        aut.Text = d["AutherName"].ToString();
                        qua.Text = d["Quantity"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid Id...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
                finally
                {
                    if (c1.State == ConnectionState.Open)
                        c1.Close();
                }
            }
        }

        private void sub_Click(object sender, EventArgs e)
        {
            if (bname.Text == "")
            {
                MessageBox.Show("Please enter Book name ");
                bname.Focus();
            }
            else if (aut.Text == "")
            {
                MessageBox.Show("Please enter Auther name... ");
                aut.Focus();
            }
            else if (qua.Text == "")
            {
                MessageBox.Show("Please enter quantity ");
            }
            else
            {
                c1.Open();
                try
                {
                    q = "insert into books values(" + bid.Text + ",'" + bname.Text + "','" + aut.Text + "'," + qua.Text +")";
                    cmd = new MySqlCommand(q, c1);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("New Book aded successfully...");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Book not added...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter valid text...");
                }
                finally
                {
                    if (c1.State == ConnectionState.Open)
                        c1.Close();
                }
            }
        }

        private void refr_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void rem_Click(object sender, EventArgs e)
        {
            if (bid.Text == "")
            {
                MessageBox.Show("Please enter book ID...");
                bid.Focus();
            }
            else if (bname.Text == "")
            {
                MessageBox.Show("First search info...");
            }
            else
            {
                c1.Open();
                try
                {
                    q = "delete from books where bid = " + bid.Text;
                    cmd = new MySqlCommand(q, c1);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("selected book removed successfully from the database...");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("something went wrong...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter valid text...");
                }
                finally
                {
                    if (c1.State == ConnectionState.Open)
                        c1.Close();
                }
            }
        }

        private void upd_Click(object sender, EventArgs e)
        {
            if (bid.Text == "")
            {
                MessageBox.Show("Please enter book ID...");
                bid.Focus();
            }
            else if (bname.Text == "")
            {
                MessageBox.Show("First search info...");
            }
            else
            {
                c1.Open();
                try
                {
                    q = "update books set bname = '" + bname.Text + "',AutherName = '" + aut.Text + "',quantity = " + qua.Text + " where bid = " + bid.Text;
                    cmd = new MySqlCommand(q, c1);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("book record updated successfully...");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data not updated...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please enter valid text...");
                }
                finally
                {
                    if (c1.State == ConnectionState.Open)
                        c1.Close();
                }
            }
        }

        private void sr_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            c1.Open();
            try
            {
                q = "select * from books";
                MySqlDataAdapter da = new MySqlDataAdapter(q, c1);
                DataTable t = new DataTable();
                da.Fill(t);

                f5.dataGridView1.DataSource = t;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went Wrong...");
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
            f5.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cs = "server = localhost; database = library; uid=root; pwd=root";
            c1 = new MySqlConnection(cs);
        }
    }
}
