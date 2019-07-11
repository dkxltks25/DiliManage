using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiliManage
{
    public partial class MainPage1 : Form
    {
        public static string StudentNumber;
        public static string StudentName;
        public static string StudentSex;
        public static string StudentCel;
        public static string StudentEmail;
        public static string StudentFtime;
        public static string StudentTtime;
        public static string StudentImg;
        public MainPage1()
        {
            //메인페이지
            InitializeComponent();
            set_clear();
        }

        public MainPage1(int mode)
        {
            //관리자 등급별 메인페이지
            InitializeComponent();
            set_clear();
            if (mode == 1)
            {
                cou.Enabled = true;
                re.Enabled = true;
                apt.Enabled = true;
                ft.Enabled = true;
                stu.Enabled = true;
                sta.Enabled = true;
            }
            if (mode == 2)
            {
                cou.Enabled = false;
                re.Enabled = false;
                apt.Enabled = false;
                ft.Enabled = false;
                stu.Enabled = false;
                sta.Enabled = false;
            }
        }
        private void cou_Click(object sender, EventArgs e)
        {
            pra cou = new pra();
            this.Close();
            cou.Show();
        }

        private void re_Click(object sender, EventArgs e)
        {
            requset As = new requset();
            this.Close();
            As.Show();
        }

        private void stu_Click(object sender, EventArgs e)
        {
            Stu_sel apt = new Stu_sel();
            this.Close();
            apt.Show();
        }

        private void ft_Click(object sender, EventArgs e)
        {
            FT FT = new FT();
            this.Close();
            FT.Show();
        }

        private void Apt_Click(object sender, EventArgs e)
        {

            Apt_sel stu = new Apt_sel();
            this.Close();
            stu.Show();
        }

        private void Sta_Click(object sender, EventArgs e)
        {
            Statics sta = new Statics();
            this.Close();
            sta.Show();
        }

        private void set_value()
        {
            //변수 설정
            StudentNumber = textBox1.Text;
            StudentName = textBox2.Text;
            StudentSex = textBox3.Text;
            StudentCel = textBox4.Text;
            StudentEmail = textBox6.Text;
            StudentFtime = textBox7.Text;
            StudentTtime = textBox8.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            set_value();
            if (StudentNumber == "")
            {
                MessageBox.Show("학번이 없습니다");

            }

        }

        private void set_clear()
        {
            //빈칸 조정
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            pictureBox2.Image = null;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;
            textBox8.ReadOnly = true;

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
