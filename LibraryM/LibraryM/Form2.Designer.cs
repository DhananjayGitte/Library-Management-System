namespace LibraryM
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sem = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.rn = new System.Windows.Forms.TextBox();
            this.sub = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.rem = new System.Windows.Forms.Button();
            this.refr = new System.Windows.Forms.Button();
            this.iss = new System.Windows.Forms.Button();
            this.ret = new System.Windows.Forms.Button();
            this.sr = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.ext = new System.Windows.Forms.Button();
            this.brach = new System.Windows.Forms.ComboBox();
            this.semister = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(369, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Portal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(107, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(107, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Student Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(107, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Roll No.:";
            // 
            // sem
            // 
            this.sem.AutoSize = true;
            this.sem.BackColor = System.Drawing.Color.Transparent;
            this.sem.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.sem.ForeColor = System.Drawing.Color.Black;
            this.sem.Location = new System.Drawing.Point(455, 270);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(78, 21);
            this.sem.TabIndex = 1;
            this.sem.Text = "Semister:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(107, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Branch:";
            // 
            // sid
            // 
            this.sid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sid.Location = new System.Drawing.Point(228, 121);
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            this.sid.Size = new System.Drawing.Size(66, 15);
            this.sid.TabIndex = 2;
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(228, 171);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(190, 22);
            this.sname.TabIndex = 2;
            // 
            // rn
            // 
            this.rn.Location = new System.Drawing.Point(228, 218);
            this.rn.Name = "rn";
            this.rn.Size = new System.Drawing.Size(190, 22);
            this.rn.TabIndex = 2;
            // 
            // sub
            // 
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.sub.Location = new System.Drawing.Point(51, 342);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(131, 30);
            this.sub.TabIndex = 3;
            this.sub.Text = "Submit";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Visible = false;
            this.sub.Click += new System.EventHandler(this.button1_Click);
            // 
            // upd
            // 
            this.upd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upd.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.upd.Location = new System.Drawing.Point(51, 342);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(131, 30);
            this.upd.TabIndex = 3;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Visible = false;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // rem
            // 
            this.rem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rem.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.rem.Location = new System.Drawing.Point(51, 342);
            this.rem.Name = "rem";
            this.rem.Size = new System.Drawing.Size(131, 30);
            this.rem.TabIndex = 3;
            this.rem.Text = "Remove";
            this.rem.UseVisualStyleBackColor = true;
            this.rem.Visible = false;
            this.rem.Click += new System.EventHandler(this.rem_Click);
            // 
            // refr
            // 
            this.refr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refr.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.refr.Location = new System.Drawing.Point(211, 342);
            this.refr.Name = "refr";
            this.refr.Size = new System.Drawing.Size(131, 30);
            this.refr.TabIndex = 3;
            this.refr.Text = "Refresh";
            this.refr.UseVisualStyleBackColor = true;
            this.refr.Click += new System.EventHandler(this.refr_Click);
            // 
            // iss
            // 
            this.iss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iss.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.iss.Location = new System.Drawing.Point(51, 342);
            this.iss.Name = "iss";
            this.iss.Size = new System.Drawing.Size(131, 30);
            this.iss.TabIndex = 3;
            this.iss.Text = "Issue ";
            this.iss.UseVisualStyleBackColor = true;
            this.iss.Visible = false;
            this.iss.Click += new System.EventHandler(this.iss_Click);
            // 
            // ret
            // 
            this.ret.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ret.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.ret.Location = new System.Drawing.Point(51, 418);
            this.ret.Name = "ret";
            this.ret.Size = new System.Drawing.Size(131, 30);
            this.ret.TabIndex = 3;
            this.ret.Text = "Return";
            this.ret.UseVisualStyleBackColor = true;
            this.ret.Visible = false;
            this.ret.Click += new System.EventHandler(this.ret_Click);
            // 
            // sr
            // 
            this.sr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sr.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.sr.Location = new System.Drawing.Point(539, 342);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(131, 30);
            this.sr.TabIndex = 3;
            this.sr.Text = "Show Record";
            this.sr.UseVisualStyleBackColor = true;
            this.sr.Click += new System.EventHandler(this.sr_Click);
            // 
            // search
            // 
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(319, 118);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(99, 22);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Visible = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ext
            // 
            this.ext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ext.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.ext.Location = new System.Drawing.Point(375, 342);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(131, 30);
            this.ext.TabIndex = 3;
            this.ext.Text = "Exit";
            this.ext.UseVisualStyleBackColor = true;
            this.ext.Click += new System.EventHandler(this.ext_Click);
            // 
            // brach
            // 
            this.brach.FormattingEnabled = true;
            this.brach.Items.AddRange(new object[] {
            "CSE",
            "Civil",
            "Mechanical",
            "Electrical"});
            this.brach.Location = new System.Drawing.Point(228, 269);
            this.brach.Name = "brach";
            this.brach.Size = new System.Drawing.Size(190, 24);
            this.brach.TabIndex = 4;
            // 
            // semister
            // 
            this.semister.FormattingEnabled = true;
            this.semister.Items.AddRange(new object[] {
            "1st",
            "2nd",
            "3rd",
            "4th",
            "5th",
            "6th",
            "7th",
            "8th"});
            this.semister.Location = new System.Drawing.Point(539, 269);
            this.semister.Name = "semister";
            this.semister.Size = new System.Drawing.Size(87, 24);
            this.semister.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(891, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 22);
            this.button1.TabIndex = 5;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(440, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(721, 351);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 123);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 497);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.semister);
            this.Controls.Add(this.brach);
            this.Controls.Add(this.search);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.ret);
            this.Controls.Add(this.iss);
            this.Controls.Add(this.refr);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.rem);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.rn);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label sem;
        private System.Windows.Forms.Label label6;
        protected internal System.Windows.Forms.Button sub;
        protected internal System.Windows.Forms.Button upd;
        protected internal System.Windows.Forms.Button rem;
        protected internal System.Windows.Forms.Button iss;
        protected internal System.Windows.Forms.Button ret;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.TextBox sid;
        protected internal System.Windows.Forms.Button search;
        protected internal System.Windows.Forms.TextBox sname;
        protected internal System.Windows.Forms.TextBox rn;
        protected internal System.Windows.Forms.ComboBox brach;
        protected internal System.Windows.Forms.ComboBox semister;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        protected internal System.Windows.Forms.Button sr;
        protected internal System.Windows.Forms.Button refr;
        protected internal System.Windows.Forms.Button ext;
    }
}