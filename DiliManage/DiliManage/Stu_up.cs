using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace DiliManage
{
    
    
    public partial class Stu_up : Form
    {
        public Stu_up()
        {
            InitializeComponent();
            DBconnect();
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
        private static string mysql_str = "server=l.bsks.ac.kr;port=3306;Database=p201887082;Uid=p201887082;Pwd=dkxltks25;Charset=utf8;SSLMODE = NONE";
        private static int mode;
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;
        MySqlDataReader reader;
        public static string url = "SERVER = l.bsks.ac.kr; USER=p201887082; DATABASE = p201887082; PORT=3306; PASSWORD=pp201887082;SSLMODE=NONE";

        public void DBconnect()
        {
            conn = new MySqlConnection(url);
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }
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
            Console.WriteLine("------테스트--------");
            Console.WriteLine(StudentNumber);
            Console.WriteLine(StudentName);
            Console.WriteLine(StudentCall1);
            Console.WriteLine(StudentCall2);
            Console.WriteLine(StudentCall3);
            Console.WriteLine(StudentRrn1);
            Console.WriteLine(StudentRrn2);
            Console.WriteLine(StudentPass);
            Console.WriteLine(StudentBnkName);
            Console.WriteLine(StudentBnkSName);
            Console.WriteLine(StudentBnkNumber);
            Console.WriteLine(StudentAdress1);
            Console.WriteLine(StudentAdress2);
            Console.WriteLine(StudentAdress3);
            Console.WriteLine("------테스트--------");
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
            insertQuery();
        }
        private void insertQuery()
        {
            string sql = "INSERT INTO TATM_STU(STU_STUNO,STU_NAME ,STU_BIRTH,STU_PASS ,STU_SEX  ,STU_PHONE,STU_MAIL ,STU_POST ,STU_ADR  ,STU_ADDR ,STU_ACC_B,STU_ACC_N,STU_ACC_N,STU_IMAGE,STU_SYS)";
            sql += " VALUES (";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentNumber + "'";
            sql += ")";
        }

        private void button7_Click(object sender, EventArgs e)
        {

            
            set_value();
            if(space_check(StudentNumber,"학번") == 1)
            {
                OpenFileDialog f1 = new OpenFileDialog();
                String fname;
                if (f1.ShowDialog() == DialogResult.OK)
                {
                    string h = f1.FileName.Substring(f1.FileName.LastIndexOf('.'));
                    h = h.ToLower();
                    string[] hwakjang = { ".jpg", ".jpeg", ".png", ".gif", ".jpe", ".bmp" };
                    int check = 1;
                    foreach (string n in hwakjang)
                    {
                        if (h == n)
                        {
                            check = 0;
                        }
                    }
                    if (check == 1)
                    {
                        MessageBox.Show("그림파일 (jpg,jpeg,png,gif,jpe,bmp)만 가능합니다!");
                        return;
                    }

                    pictureBox2.Image = Image.FromFile(f1.FileName);
                    fname = Path.GetFileName(f1.FileName);
                    Console.WriteLine(fname);
                    fname = "C:/sers/MTPC4-06/Desktop/2019-07-11/DiliManage/DiliManage/img/" + textBox1.Text+ hwakjang;
                    Console.WriteLine(fname);
                    //pictureBox2.Image.Save(fname);
                }

            }
            

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            string[] cell = new string[3];
            cell[0] = "010";
            cell[1] = "011";
            cell[2] = "018";
            int i;
            int chk = 0;
            string index = comboBox1.Text;
            for(i =0; i < 3; i++)
            {
                if(index == cell[i])
                {
                    chk = 1;
                }
            }

            if(chk != 1)
            {
                MessageBox.Show("잘못된 형식의 전화번호입니다");
                comboBox1.Focus();
            }
        }
    }
}
