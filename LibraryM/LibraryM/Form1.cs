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
using MySql.Data.MySqlClient;

namespace LibraryM
{
    public partial class Form1 : Form
    {
        string cs, q;
        MySqlConnection c1;
        MySqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cs = "server = localhost; database = library; uid=root; pwd=root";
            c1 = new MySqlConnection(cs);
            MessageBox.Show("Welcome To Library");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.iss.Visible = true;
            f2.ret.Visible = true;
            f2.search.Visible = true;
            f2.label1.Text = "Issue/Return Books";
            f2.sid.ReadOnly = false;
            f2.sname.ReadOnly = true;
            f2.rn.ReadOnly = true;
            f2.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void addStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.sub.Visible = true;
            f2.sr.Visible = false;
            f2.label1.Text = "Add Student";

            c1.Open();
            try
            {
                q = "select max(sid) from students";
                cmd = new MySqlCommand(q, c1);
                
                int ids = Convert.ToInt32(cmd.ExecuteScalar());
                ids++;
                f2.sid.Text = ids.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Welcome to library, you are the first one...", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                f2.sid.Text = "1";
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }

            f2.Show();
        }

        private void updateStudentProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.upd.Visible = true;
            f2.search.Visible = true;
            f2.label1.Text = "Update Student Profile";
            f2.sid.ReadOnly = false;
            f2.sname.ReadOnly = true;
            f2.rn.ReadOnly = true;
            f2.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.search.Visible = true;
            f2.rem.Visible = true;
            f2.label1.Text = "Remove Student Profile";
            f2.sid.ReadOnly = false;
            f2.sname.ReadOnly = true;
            f2.rn.ReadOnly = true;
            f2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }

        private void addBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.sub.Visible = true;
            f3.label1.Text = "Add Books";

            c1.Open();
            try
            {
                q = "select max(bid) from books";
                cmd = new MySqlCommand(q, c1);
                int idb = Convert.ToInt32(cmd.ExecuteScalar());
                idb++;
                f3.bid.Text = idb.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Welcome, This will be first book of library.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                f3.bid.Text = "1";
            }
            finally
            {
                if (c1.State == ConnectionState.Open)
                    c1.Close();
            }

            f3.Show();
        }

        private void modifyBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.upd.Visible = true;
            f3.search.Visible = true;
            f3.label1.Text = "Update Books";
            f3.bid.ReadOnly = false;
            f3.bname.ReadOnly = true;
            f3.aut.ReadOnly = true;
            f3.qua.ReadOnly = true;
            f3.Show();
        }

        private void removeBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.search.Visible = true;
            f3.rem.Visible = true;
            f3.label1.Text = "Remove Books";
            f3.bid.ReadOnly = false;
            f3.bname.ReadOnly = true;
            f3.aut.ReadOnly = true;
            f3.qua.ReadOnly = true;
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f5= new Form5();
            f5.label5.Visible = false;
            f5.sid.Visible = false;

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
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
                MessageBox.Show("लायब्ररी मॅनेजमेंट सिस्टीममध्ये आपले स्वागत आहे...\n\nलायब्ररी मॅनेजमेंट सिस्टीम ही एक डेस्कटॉप अॅप्लिकेशन आहे जी लायब्ररीच्या दैनंदिन कामकाजाला सुलभ आणि स्वयंचलित करण्यासाठी डिझाइन केलेली आहे. हे ग्रंथपाल आणि कर्मचाऱ्यांना पुस्तके, सदस्य आणि व्यवहार कार्यक्षमतेने व्यवस्थापित करण्यास, मॅन्युअल काम कमी करण्यास आणि अचूकता सुधारण्यास अनुमती देते.\nही प्रणाली पुस्तकांच्या नोंदी जोडणे आणि अद्यतनित करणे, सदस्यांचे तपशील व्यवस्थापित करणे, पुस्तके जारी करणे आणि परत करणे आणि देय तारखा ट्रॅक करणे यासारख्या मुख्य कार्यांना समर्थन देते. या प्रक्रियांचे डिजिटायझेशन करून, सॉफ्टवेअर कार्यक्षमता सुधारते, कागदपत्रे कमी करते आणि अचूक, अद्ययावत रेकॉर्ड राखण्यास मदत करते.\n\n\nDhananjay Gitte: vishalgitte8888@gamil.com", "बद्दल", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Welcome to Library Management System...\n\nThe Library Management System is a desktop application designed to streamline and automate the day-to-day operations of a library. It allows librarians and staff to efficiently manage books, members, and transactions, reducing manual work and improving accuracy.\nThe system supports core functionalities such as adding and updating book records, managing member details, issuing and returning books and tracking due dates. By digitizing these processes, the software improves efficiency, reduces paperwork, and helps maintain accurate, up-to-date records. \n\n\n\nDhananjay Gitte: vishalgitte8888@gamil.com", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
        private void label2_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            label1.Text = "LIBRARY MANAGEMENT SYSTEM";
            studentsToolStripMenuItem.Text = "Students";
            addStudentsToolStripMenuItem.Text = "Add Students";
            updateStudentProfileToolStripMenuItem.Text = "Uodate Students Profile";
            removeStudentToolStripMenuItem.Text = "Remove Students";
            booksToolStripMenuItem.Text = "Books";
            addBooksToolStripMenuItem.Text = "Add Books";
            modifyBooksToolStripMenuItem.Text = "Update Books";
            removeBooksToolStripMenuItem.Text = "Remove Books";
            aboutToolStripMenuItem.Text = "About";
            button1.Text = "Show Students record";
            button2.Text = "Show Books Record";
            button3.Text = "Issue Return Books";
            button4.Text = "Exit";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel3.Visible = true;
            label1.Text = "                    लायब्ररी व्यवस्थापन प्रणाली";
            studentsToolStripMenuItem.Text = "विद्यार्थी";
            addStudentsToolStripMenuItem.Text = "विद्यार्थ्यांना जोडा";
            updateStudentProfileToolStripMenuItem.Text = "विद्यार्थी अद्यतनित करा";
            removeStudentToolStripMenuItem.Text = "विद्यार्थ्यांना काढा";
            booksToolStripMenuItem.Text = "पुस्तके";
            addBooksToolStripMenuItem.Text = "पुस्तके जोडा";
            modifyBooksToolStripMenuItem.Text = "पुस्तके अद्यतनित करा";
            removeBooksToolStripMenuItem.Text = "पुस्तके काढा";
            aboutToolStripMenuItem.Text = "बद्दल";
            button1.Text = "विद्यार्थ्याची नोंद दाखवा";
            button2.Text = "पुस्तकाची नोंद दाखवा";
            button3.Text = "पुस्तके जारी करा / परत करा";
            button4.Text = "बाहेर पडा";

            MessageBox.Show("This language is in development process, only this page will be shown in Marathi Language...", "",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (panel3.Visible == true)
            {
                DialogResult dialog = MessageBox.Show("तुम्हाला नक्की लॉग आउट करून बाहेर पडायचे आहे ? ", "बाहेर पडणे", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Are you sure want to log out and exit ? ", "Logging Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }
    }
}
