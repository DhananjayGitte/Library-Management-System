namespace LibraryM
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.search = new System.Windows.Forms.Button();
            this.refr = new System.Windows.Forms.Button();
            this.rem = new System.Windows.Forms.Button();
            this.upd = new System.Windows.Forms.Button();
            this.sub = new System.Windows.Forms.Button();
            this.qua = new System.Windows.Forms.TextBox();
            this.aut = new System.Windows.Forms.TextBox();
            this.bname = new System.Windows.Forms.TextBox();
            this.bid = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sr = new System.Windows.Forms.Button();
            this.ext = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(299, 134);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(99, 22);
            this.search.TabIndex = 22;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Visible = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // refr
            // 
            this.refr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.refr.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.refr.Location = new System.Drawing.Point(238, 355);
            this.refr.Name = "refr";
            this.refr.Size = new System.Drawing.Size(131, 30);
            this.refr.TabIndex = 18;
            this.refr.Text = "Refresh";
            this.refr.UseVisualStyleBackColor = true;
            this.refr.Click += new System.EventHandler(this.refr_Click);
            // 
            // rem
            // 
            this.rem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.rem.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.rem.Location = new System.Drawing.Point(71, 355);
            this.rem.Name = "rem";
            this.rem.Size = new System.Drawing.Size(131, 30);
            this.rem.TabIndex = 17;
            this.rem.Text = "Remove";
            this.rem.UseVisualStyleBackColor = true;
            this.rem.Visible = false;
            this.rem.Click += new System.EventHandler(this.rem_Click);
            // 
            // upd
            // 
            this.upd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upd.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.upd.Location = new System.Drawing.Point(71, 355);
            this.upd.Name = "upd";
            this.upd.Size = new System.Drawing.Size(131, 30);
            this.upd.TabIndex = 16;
            this.upd.Text = "Update";
            this.upd.UseVisualStyleBackColor = true;
            this.upd.Visible = false;
            this.upd.Click += new System.EventHandler(this.upd_Click);
            // 
            // sub
            // 
            this.sub.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sub.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.sub.Location = new System.Drawing.Point(71, 355);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(131, 30);
            this.sub.TabIndex = 15;
            this.sub.Text = "Submit";
            this.sub.UseVisualStyleBackColor = true;
            this.sub.Visible = false;
            this.sub.Click += new System.EventHandler(this.sub_Click);
            // 
            // qua
            // 
            this.qua.Location = new System.Drawing.Point(208, 261);
            this.qua.Name = "qua";
            this.qua.Size = new System.Drawing.Size(190, 22);
            this.qua.TabIndex = 13;
            // 
            // aut
            // 
            this.aut.Location = new System.Drawing.Point(208, 221);
            this.aut.Name = "aut";
            this.aut.Size = new System.Drawing.Size(190, 22);
            this.aut.TabIndex = 12;
            // 
            // bname
            // 
            this.bname.Location = new System.Drawing.Point(208, 174);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(190, 22);
            this.bname.TabIndex = 11;
            // 
            // bid
            // 
            this.bid.Location = new System.Drawing.Point(208, 135);
            this.bid.Name = "bid";
            this.bid.ReadOnly = true;
            this.bid.Size = new System.Drawing.Size(66, 22);
            this.bid.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(105, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 21);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(105, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Auther:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(105, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Book Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(105, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Book ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(399, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Books Portal";
            // 
            // sr
            // 
            this.sr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sr.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.sr.Location = new System.Drawing.Point(405, 355);
            this.sr.Name = "sr";
            this.sr.Size = new System.Drawing.Size(131, 30);
            this.sr.TabIndex = 21;
            this.sr.Text = "Show Record";
            this.sr.UseVisualStyleBackColor = true;
            this.sr.Click += new System.EventHandler(this.sr_Click);
            // 
            // ext
            // 
            this.ext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ext.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold);
            this.ext.Location = new System.Drawing.Point(562, 355);
            this.ext.Name = "ext";
            this.ext.Size = new System.Drawing.Size(131, 30);
            this.ext.TabIndex = 16;
            this.ext.Text = "Exit";
            this.ext.UseVisualStyleBackColor = true;
            this.ext.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(430, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 18);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(891, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(26, 22);
            this.button6.TabIndex = 24;
            this.button6.Text = "X";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 497);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.sr);
            this.Controls.Add(this.refr);
            this.Controls.Add(this.rem);
            this.Controls.Add(this.ext);
            this.Controls.Add(this.upd);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.qua);
            this.Controls.Add(this.aut);
            this.Controls.Add(this.bname);
            this.Controls.Add(this.bid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button refr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button sr;
        private System.Windows.Forms.Button ext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button6;
        protected internal System.Windows.Forms.Button rem;
        protected internal System.Windows.Forms.Button upd;
        protected internal System.Windows.Forms.Button sub;
        protected internal System.Windows.Forms.TextBox qua;
        protected internal System.Windows.Forms.TextBox aut;
        protected internal System.Windows.Forms.TextBox bname;
        protected internal System.Windows.Forms.TextBox bid;
        protected internal System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Button search;
    }
}