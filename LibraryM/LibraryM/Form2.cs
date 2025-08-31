using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace LibraryM
{
    public partial class Form2 : Form
    {
        string cs, q;
        MySqlConnection c1;
        MySqlCommand cmd;
        MySqlDataReader d;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void clearall()
        {
            sname.Text = "";
            rn.Text = "";
            brach.Text = "";
            semister.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (sname.Text == "")
            {
                MessageBox.Show("Please enter your name ");
                sname.Focus();
            }
            else if (rn.Text == "")
            {
                MessageBox.Show("Please enter your roll no... ");
                rn.Focus();
            }
            else if (brach.Text == "")
            {
                MessageBox.Show("Please select your branch... ");
            }
            else if (semister.Text == "")
            {
                MessageBox.Show("Please select your current semister...");
            }
            else
            {
                c1.Open();
                try
                {
                    q = "insert into students values(" + sid.Text + ",'" + sname.Text + "'," + rn.Text + ",'"+brach.Text+"','"+semister.Text+"')";
                    cmd = new MySqlCommand(q, c1);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Student data saved successfully...", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data not saved...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Valid Text.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (c1.State == ConnectionState.Open)
                        c1.Close();
                }
            }
        }

        private void ext_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want to exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure want to exit ? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (sid.Text == "")
            {
                MessageBox.Show("Please enter your ID...");
                sid.Focus();
            }
            else
            {
                c1.Open();
                try
                {
                    int n = Convert.ToInt32(sid.Text);
                    q = "select * from students where sid = " + n;
                    cmd = new MySqlCommand(q, c1);
                    d = cmd.ExecuteReader();
                    if (d.Read())
                    {
                        sname.ReadOnly = false;
                        rn.ReadOnly = false;

                        sname.Text = d["sname"].ToString();
                        rn.Text = d["rn"].ToString();
                        brach.Text = d["branch"].ToString();
                        semister.Text = d["sem"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Valid Text.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void upd_Click(object sender, EventArgs e)
        {
            if (sid.Text == "")
            {
                MessageBox.Show("Please Enter Your ID.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                sid.Focus();
            }
            else if (sname.Text == "")
            {
                MessageBox.Show("First search your info.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                c1.Open();
                try
                {
                    q = "update students set sname = '" + sname.Text + "',rn = " + rn.Text + ",branch = '" + brach.Text + "',sem = '" + semister.Text + "' where sid = " + sid.Text;
                    cmd = new MySqlCommand(q, c1);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Student record updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data not updated...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please Enter Valid Text.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (c1.State == ConnectionState.Open)
                        c1.Close();
                }
            }
        }
        private void rem_Click(object sender, EventArgs e)
        {
            if (sid.Text == "")
            {
                MessageBox.Show("Please Enter Your ID.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sid.Focus();
            }
            else if (sname.Text == "")
            {
                MessageBox.Show("First search your info.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                c1.Open();
                try
                {
                    q = "delete from students where sid = " + sid.Text;
                    cmd = new MySqlCommand(q, c1);
                    int r = cmd.ExecuteNonQuery();
                    if (r > 0)
                    {
                        MessageBox.Show("Student reord deleted successfully...");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data not updated...");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Can't delete student record, this student has not returned books yet", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (c1.State == ConnectionState.Open)
                        c1.Close();
                }
            }
        }

        private void iss_Click(object sender, EventArgs e)
        {
            if (sid.Text == "")
            {
                MessageBox.Show("Please Enter Your ID.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sid.Focus();
            }
            else if (sname.Text == "")
            {
                MessageBox.Show("First search your info.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form5 f5 = new Form5();
                f5.iss.Visible = true;
                f5.dtp1.Visible = true;
                f5.dtp2.Visible = true;
                f5.label3.Visible = true;
                f5.label4.Visible = true;
                f5.label1.Text = "Issue Books";
                f5.sid.Text = sid.Text;

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
                    MessageBox.Show("Something went wrong.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (c1.State == ConnectionState.Open)
                        c1.Close();
                }

                f5.Show();
                this.Close();
            }
        }

        private void ret_Click(object sender, EventArgs e)
        {
            if (sid.Text == "")
            {
                MessageBox.Show("Please Enter Your ID.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                sid.Focus();
            }
            else if (sname.Text == "")
            {
                MessageBox.Show("First search your info.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form5 f5 = new Form5();
                f5.ret.Visible = true;
                f5.dtp1.Visible = true;
                f5.dtp2.Visible = true;
                f5.button1.Visible = false;
                f5.label2.Visible= false;
                f5.bid.Visible = false;
                f5.label3.Visible = true;
                f5.label4.Visible = true;
                f5.label1.Text = "Return Books";
                f5.sid.Text = sid.Text;

                c1.Open();
                try
                {
                    q = "select * from record where sid = "+sid.Text;
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
                this.Close();
            }
        }

        private void sr_Click(object sender, EventArgs e)
        {
            if (sid.Text == "")
            {
                MessageBox.Show("Please Enter Your ID.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                sid.Focus();
            }
            else if (sname.Text == "")
            {
                MessageBox.Show("First search your info.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Form6 f6 = new Form6();
                f6.sname.Text = sname.Text;
                f6.sid.Text = sid.Text;

                c1.Open();
                try
                {
                    q = "select * from record where sid = " + sid.Text;
                    MySqlDataAdapter da = new MySqlDataAdapter(q, c1);
                    DataTable t = new DataTable();
                    da.Fill(t);

                    f6.dataGridView1.DataSource = t;
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

                f6.Show();
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cs = "server = localhost; database = library; uid=root; pwd=root";
            c1 = new MySqlConnection(cs);
        }
    }
}
