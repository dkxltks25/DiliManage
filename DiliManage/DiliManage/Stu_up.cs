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
        public Stu_up(int mode)
        {
            InitializeComponent();
            DBconnect();
            PageMode = mode;
        }
        public Stu_up(int mode, string StudentNumber)
        {
            InitializeComponent();
            DBconnect();
            PageMode = mode;
            PKStudentNumber = StudentNumber;
        }
        private static String PKStudentNumber;
        public static int PageMode;
        private static String StudentNumber;
        private static String StudentName;
        private static String StudentCall1;
        private static String StudentCall2;
        private static String StudentCall3;
        private static String StudentSex;
        private static String StudentRrn1;
        private static String StudentRrn2;
        private static String StudentPass;
        private static String StudentEmail1;
        private static String StudentEmail2;
        private static String StudentBnkName;
        private static String StudentBnkSName;
        private static String StudentBnkNumber;
        private static String StudentAdress1;
        private static String StudentAdress2;
        private static String StudentAdress3;
        private static String StudentImg = "";


        private static string mysql_str = "server=l.bsks.ac.kr;port=3306;Database=p201887082;Uid=p201887082;Pwd=pp201887082;Charset=utf8;SSLMODE = NONE";
        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;
        MySqlDataReader reader;

        public void DBconnect()
        {
            conn = new MySqlConnection(mysql_str);
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
            StudentEmail1 = textBox14.Text;
            StudentEmail2 = textBox15.Text;
            StudentSex = radioButton1.Checked == true ? "남" : "여";
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
            Console.WriteLine(StudentImg);
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

        private void Ft_Click(object sender, EventArgs e)
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
            set_value();
            int i = 0;
            if (space_check(StudentNumber, "학번") != 1)
            {
                return;
            }
            bool result = int.TryParse(StudentNumber, out i); //i now = 108  
            if (result)
            {
                selectQuery();
            }
            else
            {
                MessageBox.Show("학번은 문자가 들어 갈 수 없습니다");
                textBox1.Focus();
            }
        }


        private void selectQuery()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql;
            sql = "select * from TATM_STU where STU_STUNO = '" + StudentNumber + "'";
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show($"{reader["STU_NAME"]}님은 이미 등록된 학생입니다");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Console.WriteLine(sql);
                reader.Close();
            }
        }


        private int space_check(string text, string alert_msg)
        {
            if (text == "")
            {
                MessageBox.Show($"{alert_msg}는 빈칸입니다");
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private int All_space_check()
        {
            set_value();
            if (space_check(StudentNumber, "학번") == 1)
                if (space_check(StudentName, "성명") == 1)
                    if (space_check(StudentCall1, "연락처") == 1)
                        if (space_check(StudentCall2, "연락처") == 1)
                            if (space_check(StudentCall3, "연락처") == 1)
                                if (space_check(StudentRrn1, "주민번호 앞자리") == 1)
                                    if (space_check(StudentRrn2, "주민번호 뒷자리") == 1)
                                        if (space_check(StudentBnkName, "은행명") == 1)
                                            if (space_check(StudentEmail1, "이메일") == 1)
                                                if (space_check(StudentEmail2, "이메일") == 1)
                                                    if (space_check(StudentBnkSName, "예금주") == 1)
                                                        if (space_check(StudentBnkNumber, "계좌번호") == 1)
                                                            if (space_check(StudentAdress1, "우편번호") == 1)
                                                                if (space_check(StudentAdress2, "주소") == 1)
                                                                    if (space_check(StudentAdress3, "나머지주소") == 1)
                                                                        if (space_check(StudentImg, "이미지") == 1)
                                                                        {
                                                                            Console.WriteLine("--------공백테스트 완료--------");
                                                                            return 1;
                                                                        }


            return 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {

            if (All_space_check() == 1)
            {
                if (PageMode == 2)
                {
                    insertQuery();
                }
                else if (PageMode == 3)
                {
                    updateQuery();
                }
            }
        }

        private void insertQuery()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            set_value();

            string sql = "INSERT INTO TATM_STU(STU_STUNO,STU_NAME ,STU_BIRTH,STU_PASS ,STU_SEX  ,STU_PHONE,STU_MAIL ,STU_POST ,STU_ADR  ,STU_ADDR ,STU_ACC_BANK,STU_ACC_NAME,STU_ACC_NO,STU_IMAGE)";
            sql += " VALUES (";
            sql += " '" + StudentNumber + "',";
            sql += " '" + StudentName + "',";
            sql += " '" + StudentRrn1 + "-" + StudentRrn2 + "',";
            sql += " '" + StudentPass + "',";
            sql += " '" + StudentSex + "',";
            sql += " '" + StudentCall1 + StudentCall2 + StudentCall3 + "',";
            sql += " '" + StudentEmail1 + "@" + StudentEmail2 + "',";
            sql += " '" + StudentAdress1 + "',";
            sql += " '" + StudentAdress2 + "',";
            sql += " '" + StudentAdress3 + "',";
            sql += " '" + StudentBnkName + "',";
            sql += " '" + StudentBnkSName + "',";
            sql += " '" + StudentBnkNumber + "',";
            sql += " '" + StudentImg + "'";
            sql += ")";
            Console.WriteLine(sql);
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                reader.Close();
                set_Clear();
            }
        }
        private void updateQuery()
        {
            set_value();
            string sql = "UPDATE TATM_STU SET ";
            sql += "STU_STUNO   ='"+StudentNumber+"',";
            sql += "STU_NAME    ='"+StudentName+"',";
            sql += "STU_BIRTH   ='"+StudentRrn1+"-"+StudentRrn2+"',";
            sql += "STU_PASS    ='"+StudentPass+"',";
            sql += "STU_SEX     ='"+StudentSex+"',";
            sql += "STU_PHONE   ='"+StudentCall1+StudentCall2+StudentCall3+"',";
            sql += "STU_MAIL    ='"+StudentEmail1+"@"+StudentEmail2+"',";
            sql += "STU_POST    ='"+StudentAdress1+"',";
            sql += "STU_ADR     ='"+StudentAdress2+"',";
            sql += "STU_ADDR    ='"+StudentAdress3+"',";
            sql += "STU_ACC_BANK='"+StudentBnkName+"',";
            sql += "STU_ACC_NAME='"+StudentBnkSName+"',";
            sql += "STU_ACC_NO  ='"+StudentBnkNumber+"',";
            sql += "STU_IMAGE   ='"+StudentImg+"'";
            sql += "WHERE STU_STUNO ='" + PKStudentNumber+"'";
            Console.Write(sql);
            if (MessageBox.Show("선택하신 정보를 수정하시겠습니까", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("수정되었습니다");


                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
                finally
                {
                    reader.Close();
                    Stu_sel s1 = new Stu_sel();
                    s1.ShowDialog();
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("수정 취소 되었습니다");
            }


        }
        private void button7_Click(object sender, EventArgs e)
        {


            set_value();
            if (space_check(StudentNumber, "학번") == 1)
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
                    fname = "C:/Users/USER/Desktop/2019-07-011(2)/DiliManage/DiliManage/img/" + textBox1.Text + h;
                    StudentImg = fname;
                    Console.WriteLine(fname);
                    pictureBox2.Image.Save(fname);
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
            for (i = 0; i < 3; i++)
            {
                if (index == cell[i])
                {
                    chk = 1;
                }
            }

            if (chk != 1)
            {
                MessageBox.Show("잘못된 형식의 전화번호입니다");
                comboBox1.Focus();
            }
        }

        private void set_Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox13.Text = "";
            textBox12.Text = "";
            textBox3.Text = "";
            textBox11.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            pictureBox2.Image = null;

        }

        private void button10_Click(object sender, EventArgs e)
        {
            set_Clear();
        }

       

        private void Stu_up_Load(object sender, EventArgs e)
        {
            Console.WriteLine(PageMode);
            Console.WriteLine(PKStudentNumber);
            if (PageMode == 3)
            {
                string sql = "SELECT * from TATM_STU where STU_STUNO = '" + PKStudentNumber + "'";
                button11.Text = "수정";
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();

                }
                try
                {
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        textBox1.Text =  reader["STU_STUNO"].ToString();
                        textBox2.Text =  reader["STU_NAME"].ToString();
                        comboBox1.Text = reader["STU_PHONE"].ToString().Substring(0, 3);
                        textBox9.Text =  reader["STU_PHONE"].ToString().Substring(3, 4);
                        textBox10.Text = reader["STU_PHONE"].ToString().Substring(7, 4);
                        textBox4.Text =  reader["STU_BIRTH"].ToString().Substring(0, reader["STU_BIRTH"].ToString().IndexOf('-'));
                        textBox5.Text =  reader["STU_BIRTH"].ToString().Substring((int)reader["STU_BIRTH"].ToString().IndexOf('-')+1);
                        textBox6.Text =  reader["STU_ACC_BANK"].ToString();
                        textBox7.Text =  reader["STU_ACC_NAME"].ToString();
                        textBox8.Text =  reader["STU_ACC_NO"].ToString();
                        textBox13.Text = reader["STU_POST"].ToString();
                        textBox12.Text = reader["STU_ADR"].ToString();
                        textBox3.Text =  reader["STU_ADDR"].ToString();
                        textBox11.Text = reader["STU_PASS"].ToString();
                        textBox14.Text = reader["STU_MAIL"].ToString().Substring(0, reader["STU_MAIL"].ToString().IndexOf('@'));
                        textBox15.Text = reader["STU_MAIL"].ToString().Substring(reader["STU_MAIL"].ToString().IndexOf('@')+1);
                        StudentImg = reader["STU_IMAGE"].ToString();
                        pictureBox2.Load(reader["STU_IMAGE"].ToString());
                      
                    }
                 

                }
                catch (Exception e1)
                {
                    Console.WriteLine(e1.ToString());
                }
                finally
                {
                    reader.Close();
                }

            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
