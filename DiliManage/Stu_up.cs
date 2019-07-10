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
    
    
    public partial class Stu_up : Form
    {
        public Stu_up()
        {
            InitializeComponent();
        }
        private static String StudentNumber;
        private static String StudentName;
        private static String StudentCall1;
        private static String StudentCall2;
        private static String StudentCall3;
        private static String StudentRrn1;
        private static String StudentRrn2;
        private static String StudentPass;
        private static String StudentBnkName;
        private static String StudentBnkSName;
        private static String StudentBnkNumber;
        private static String StudentAdress1;
        private static String StudentAdress2;
        private static String StudentAdress3;
        private static String StudentImg;

        private void set_value()
        {
            StudentNumber = textBox1.Text;
            StudentName = textBox2.Text;
            StudentCall1 = comboBox1.Text;
            StudentCall2 = textBox9.Text;
            StudentCall3 = textBox10.Text;
            StudentRrn1 = textBox4.Text;
            StudentRrn2 = textBox5.Text;
            StudentPass = textBox11.Text == "" ? StudentRrn2 : textBox11.Text;
            StudentBnkName = textBox6.Text;
            StudentBnkSName = textBox7.Text;
            StudentBnkNumber = textBox8.Text;
            StudentAdress1 = textBox13.Text;
            StudentAdress2 = textBox12.Text;
            StudentAdress3 = textBox3.Text;
            //StudentImg = pictureBox2.Image.ToString();
        }
        private void Cou_Click(object sender, EventArgs e)
        {
            pra cou = new pra();
            this.Close();
            cou.Show();
        }

        private void Re_Click(object sender, EventArgs e)
        {
            requset As = new requset();
            this.Close();
            As.Show();
        }

        private void Stu_Click(object sender, EventArgs e)
        {
            Stu_sel apt = new Stu_sel();
            this.Close();
            apt.Show();
        }

        private void Ft_Click (object sender, EventArgs e)
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
        private void Back_Click(object sender, EventArgs e)
        {
            Stu_sel apt = new Stu_sel();
            this.Close();
            apt.Show();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void Check_StudentNumber(object sender, EventArgs e)
        {

        }
        private int space_check(string text, string alert_msg)
        {
            if (text == "")
            {
                MessageBox.Show(alert_msg);
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void All_space_check()
        {
            set_value();
            if(space_check(StudentNumber,"학번")==1)
                if (space_check(StudentName, "성명") == 1)
                    if (space_check(StudentCall1, "연락처") == 1)
                        if (space_check(StudentCall2, "연락처") == 1)
                            if (space_check(StudentCall3, "연락처") == 1)
                                if (space_check(StudentRrn1, "주민번호 앞자리") == 1)
                                    if (space_check(StudentRrn2, "주민번호 뒷자리") == 1)
                                        if (space_check(StudentBnkName, "은행명") == 1)
                                            if (space_check(StudentBnkSName, "예금주") == 1)
                                                if (space_check(StudentBnkNumber, "계좌번호") == 1)
                                                    if (space_check(StudentAdress1, "우편번호") == 1)
                                                        if (space_check(StudentAdress2, "주소") == 1)
                                                            if (space_check(StudentAdress3, "나머지주소") == 1)
                                                                if (space_check(StudentImg, "이미지") == 1)
                                                                {
                                                                    MessageBox.Show("빈칸 체크 완료");
                                                                }
            
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            All_space_check();
        }
    }
}
