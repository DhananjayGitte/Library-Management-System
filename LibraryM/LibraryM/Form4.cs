using MySql.Data.MySqlClient;
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
    public partial class Form4 : Form
    {
        string cs, q, id, name;
        MySqlConnection c1;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable t;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sid.Text == "")
            {
                MessageBox.Show("Please Enter Id");
                sid.Focus();
            }
            c1.Open();
            try
            {
                q = "select * from students where sid = "+sid.Text;
                da = new MySqlDataAdapter(q, c1);
                t = new DataTable();
                da.Fill(t);

                dataGridView1.DataSource = t;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter Valid Text...");
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            id = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            name = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();

            c1.Open();
            try
            {
                Form6 f6=new Form6();
                f6.sid.Text = id;
                f6.sname.Text = name;
                
                q = "select * from record where sid = " + id;
                MySqlDataAdapter da = new MySqlDataAdapter(q, c1);
                DataTable t = new DataTable();
                da.Fill(t);
                f6.dataGridView1.DataSource = t;

                f6.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select Student to Show record...");
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            {
                cs = "server = localhost; database = library; uid=root; pwd=root";
                c1 = new MySqlConnection(cs);

                c1.Open();
                try
                {
                    q = "select * from students";
                    da = new MySqlDataAdapter(q, c1);
                    t = new DataTable();
                    da.Fill(t);

                    dataGridView1.DataSource = t;
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
            }
        }
    }
}
