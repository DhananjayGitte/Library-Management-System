using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryM
{
    public partial class Form5 : Form
    {
        string cs, q, quantity, idb = "", bname = "",an = "";
        MySqlConnection c1;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable t;
        public Form5()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ret_Click(object sender, EventArgs e)
        {
            idb = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
          
            c1.Open();
            try
            {
                q = "delete from record where bid = " + idb;
                cmd = new MySqlCommand(q, c1);
                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                {
                    DialogResult dialog = MessageBox.Show("Do you want to Return selected book ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        MessageBox.Show("Selected book returned Successfully...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selected Book is already issued...");
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c1.Open();
            try
            {
                q = "select * from books where bid = " + bid.Text;
                da = new MySqlDataAdapter(q, c1);
                t = new DataTable();
                da.Fill(t);

                dataGridView1.DataSource = t;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Enter ID");
                bid.Focus();
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void iss_Click(object sender, EventArgs e)
        {
            idb = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            bname = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            an = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            quantity = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            int v = Convert.ToInt32(quantity);
            
            c1.Open();
            try
            {
                int u = v - 1;

                q = "select count(sid) from record where sid = "+sid.Text;
                cmd = new MySqlCommand(q, c1);
                int l = Convert.ToInt32(cmd.ExecuteScalar());
                if (l > 2)
                {
                    MessageBox.Show("You already have issued 3 books, you should return books to get more books...", "Warning...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    q = "select quantity from books where bid = " + idb;
                    cmd = new MySqlCommand(q, c1);
                    int qy = Convert.ToInt32(cmd.ExecuteScalar());
                    if (qy <= 0)
                    {
                        MessageBox.Show("Not enough quantity available.\nCome back later...", "Appologies for inconvenience...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        q = "insert into record values(" + sid.Text + "," + idb + ",'" + bname + "', '" + an + "','" + dtp1.Text + "', '" + dtp2.Text + "')";
                        cmd = new MySqlCommand(q, c1);
                        int r = cmd.ExecuteNonQuery();
                        if (r > 0)
                        {
                            q = "update books set quantity = "+u+" where bid = " + idb;
                            cmd = new MySqlCommand(q, c1);
                            int w = cmd.ExecuteNonQuery();
                            if (w > 0)
                            {
                                DialogResult dialog = MessageBox.Show("Do you want to isuue selected book ? ", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (dialog == DialogResult.Yes)
                                {
                                    MessageBox.Show("Selected book issued successfully...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Book Not issued", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You already have issued this book...","can't issue",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            {
                cs = "server = localhost; database = library; uid=root; pwd=root";
                c1 = new MySqlConnection(cs);
            }
        }
    }
}
