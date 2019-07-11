namespace DiliManage
{
    partial class Stu_sel
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
            this.ft = new System.Windows.Forms.Button();
            this.cou = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.ins = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sta = new System.Windows.Forms.Button();
            this.apt = new System.Windows.Forms.Button();
            this.stu = new System.Windows.Forms.Button();
            this.re = new System.Windows.Forms.Button();
            this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // ft
            // 
            this.ft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.ft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ft.FlatAppearance.BorderSize = 0;
            this.ft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ft.ForeColor = System.Drawing.Color.White;
            this.ft.Location = new System.Drawing.Point(354, 0);
            this.ft.Name = "ft";
            this.ft.Size = new System.Drawing.Size(118, 99);
            this.ft.TabIndex = 4;
            this.ft.Text = "출결관리";
            this.ft.UseVisualStyleBackColor = false;
            this.ft.Click += new System.EventHandler(this.Ft_Click);
            // 
            // cou
            // 
            this.cou.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.cou.Dock = System.Windows.Forms.DockStyle.Left;
            this.cou.FlatAppearance.BorderSize = 0;
            this.cou.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cou.ForeColor = System.Drawing.Color.White;
            this.cou.Location = new System.Drawing.Point(0, 0);
            this.cou.Name = "cou";
            this.cou.Size = new System.Drawing.Size(118, 99);
            this.cou.TabIndex = 1;
            this.cou.Text = "코스관리";
            this.cou.UseVisualStyleBackColor = false;
            this.cou.Click += new System.EventHandler(this.Cou_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1025, 532);
            this.panel1.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.listView1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 99);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(615, 433);
            this.panel7.TabIndex = 4;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.ColumnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(615, 433);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "학번";
            this.columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "학생이름";
            this.columnHeader2.Width = 66;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.ins);
            this.panel3.Controls.Add(this.radioButton2);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.button7);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(615, 99);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(410, 433);
            this.panel3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(324, 367);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 38);
            this.button1.TabIndex = 34;
            this.button1.Text = "취소";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(247, 367);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 38);
            this.button9.TabIndex = 34;
            this.button9.Text = "삭제";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(170, 367);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 38);
            this.button8.TabIndex = 33;
            this.button8.Text = "수정";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // ins
            // 
            this.ins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.ins.FlatAppearance.BorderSize = 0;
            this.ins.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ins.ForeColor = System.Drawing.Color.White;
            this.ins.Location = new System.Drawing.Point(94, 367);
            this.ins.Name = "ins";
            this.ins.Size = new System.Drawing.Size(71, 38);
            this.ins.TabIndex = 32;
            this.ins.Text = "입력";
            this.ins.UseVisualStyleBackColor = false;
            this.ins.Click += new System.EventHandler(this.Ins_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(167, 161);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(35, 16);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "여";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(103, 161);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(35, 16);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "남";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(18, 367);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 38);
            this.button7.TabIndex = 26;
            this.button7.Text = "조회";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 23;
            this.label2.Text = "성별";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "이름";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 12);
            this.label7.TabIndex = 23;
            this.label7.Text = "*조건 미입력시 전체검색으로 진행됩니다";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 23;
            this.label1.Text = "학번";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(103, 125);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(263, 21);
            this.textBox2.TabIndex = 22;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 21);
            this.textBox1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 99);
            this.panel2.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.panel5.Controls.Add(this.sta);
            this.panel5.Controls.Add(this.apt);
            this.panel5.Controls.Add(this.ft);
            this.panel5.Controls.Add(this.stu);
            this.panel5.Controls.Add(this.re);
            this.panel5.Controls.Add(this.cou);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1025, 99);
            this.panel5.TabIndex = 2;
            // 
            // sta
            // 
            this.sta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.sta.Dock = System.Windows.Forms.DockStyle.Left;
            this.sta.FlatAppearance.BorderSize = 0;
            this.sta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sta.ForeColor = System.Drawing.Color.White;
            this.sta.Location = new System.Drawing.Point(590, 0);
            this.sta.Name = "sta";
            this.sta.Size = new System.Drawing.Size(118, 99);
            this.sta.TabIndex = 7;
            this.sta.Text = "통계";
            this.sta.UseVisualStyleBackColor = false;
            this.sta.Click += new System.EventHandler(this.Sta_Click);
            // 
            // apt
            // 
            this.apt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.apt.Dock = System.Windows.Forms.DockStyle.Left;
            this.apt.FlatAppearance.BorderSize = 0;
            this.apt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apt.ForeColor = System.Drawing.Color.White;
            this.apt.Location = new System.Drawing.Point(472, 0);
            this.apt.Name = "apt";
            this.apt.Size = new System.Drawing.Size(118, 99);
            this.apt.TabIndex = 5;
            this.apt.Text = "실습생관리";
            this.apt.UseVisualStyleBackColor = false;
            this.apt.Click += new System.EventHandler(this.Apt_Click);
            // 
            // stu
            // 
            this.stu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.stu.Dock = System.Windows.Forms.DockStyle.Left;
            this.stu.FlatAppearance.BorderSize = 0;
            this.stu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stu.ForeColor = System.Drawing.Color.White;
            this.stu.Location = new System.Drawing.Point(236, 0);
            this.stu.Name = "stu";
            this.stu.Size = new System.Drawing.Size(118, 99);
            this.stu.TabIndex = 3;
            this.stu.Text = "학생관리";
            this.stu.UseVisualStyleBackColor = false;
            this.stu.Click += new System.EventHandler(this.Stu_Click);
            // 
            // re
            // 
            this.re.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(84)))), ((int)(((byte)(100)))));
            this.re.Dock = System.Windows.Forms.DockStyle.Left;
            this.re.FlatAppearance.BorderSize = 0;
            this.re.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.re.ForeColor = System.Drawing.Color.White;
            this.re.Location = new System.Drawing.Point(118, 0);
            this.re.Name = "re";
            this.re.Size = new System.Drawing.Size(118, 99);
            this.re.TabIndex = 2;
            this.re.Text = "신청관리";
            this.re.UseVisualStyleBackColor = false;
            this.re.Click += new System.EventHandler(this.Re_Click);
            // 
            // ColumnHeader5
            // 
            this.ColumnHeader5.Text = "학생성별";
            this.ColumnHeader5.Width = 64;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "학생 메일주소";
            this.columnHeader6.Width = 140;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "학생전화번호";
            this.columnHeader7.Width = 200;
            // 
            // Stu_sel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1025, 532);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Stu_sel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPractitionerPage";
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ft;
        private System.Windows.Forms.Button cou;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button apt;
        private System.Windows.Forms.Button stu;
        private System.Windows.Forms.Button re;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button ins;
        private System.Windows.Forms.Button sta;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader ColumnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
    }
}