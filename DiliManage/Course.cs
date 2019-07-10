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
using System.Data.SqlClient;
namespace DiliManage
{

    public partial class pra : Form
    {
        //변수 설정
        public static string Year;
        public static string Season;
        public static string CourseName;
        public static string StaDay;
        public static string FinDay;
        public static string Manager;
        public static string Content;
        public static string RStaDay;
        public static string RFinDay;
        public static int mode1 = 0;
        public static int mode2 = 0;
        // DB설정
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
        public void SetMyCustomFormat()
        {
            // Set the Format type and the CustomFormat string. 
        }
        public pra()
        {
            //메인
            InitializeComponent();
            set_clear();
            DBconnect();
            set_table("select * from TATM_COR");

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

        public void set_value()
        {
            Year = textBox1.Text;
            Season = radioButton1.Checked ? "하계" : "동계";
            CourseName = textBox3.Text;
            StaDay = dateTimePicker1.Text;
            FinDay = dateTimePicker2.Text;
            RStaDay = dateTimePicker3.Text;
            RFinDay = dateTimePicker4.Text;

            Manager = textBox4.Text;
            Content = textBox5.Text;
            Console.WriteLine("-------테스트-------");
            Console.WriteLine(Year);
            Console.WriteLine(Season);
            Console.WriteLine(CourseName);
            Console.WriteLine(StaDay);
            Console.WriteLine(FinDay);
            Console.WriteLine(Manager);
            Console.WriteLine(Content);
            Console.WriteLine(RStaDay);
            Console.WriteLine(RFinDay);
            Console.WriteLine("-------테스트-------");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            //입력
            set_value();
            if (All_space_check() == 1)
            {
                insertSqlQuery();
                set_table("SELECT * FROM TATM_COR");
                set_clear();
            }


        }
        private void insertSqlQuery()
        {
            if(conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string sql = "insert into TATM_COR (APP_YEAR,APP_SEASON,COS_NAME,COS_CONT,COS_SDATE,COS_EDATE,COS_CAR,COS_RSDATE,COS_REDATE)";
            sql += "values(";
            sql += "'"+Year+"',";
            sql += "'"+Season+"',";
            sql += "'"+CourseName+"',";
            sql += "'" + Content + "',";
            sql += "'"+StaDay+"',";
            sql += "'"+FinDay+"',";
            sql += "'"+Manager+"',";
            sql += "'"+RStaDay+"',";
            sql += "'"+RFinDay+"'";
            sql += ")";
            Console.WriteLine(sql);
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                reader.Read();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                reader.Close();
            }
               
        }
        
        private int space_check(string text, string alert_msg)
        {
            //공백체크
            if (text == "")
            {
                MessageBox.Show(alert_msg + " 이(가) 빈칸입니다");
                return 0;
            }
            return 1;
        }
        private int All_space_check()
        {
            int state = 0;
            //전체 빈칸체크
            if (space_check(Year, "년도") == 1)
            {
                if (space_check(Season, "계절") == 1)
                {
                    if (space_check(CourseName, "코스명") == 1)
                    {
                        if (space_check(StaDay, "시작일") == 1)
                        {
                            if (space_check(FinDay, "종료일") == 1)
                            {
                                if (space_check(Manager, "담당자") == 1)
                                {
                                    if (space_check(Content, "실습내용") == 1)
                                    {
                                        if(space_check(RStaDay,"신청시작일") == 1)
                                        {
                                            if (space_check(RFinDay, "신청종료일") == 1)
                                            {
                                                state = 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (state == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //조회
            set_value();
            if (All_space_check() == 1)
            {
                
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            set_value();
            if (All_space_check() == 1)
            {
               
                string sql = "UPDATE TATM_COR set ";
                sql += "APP_YEAR ='" + Year + "', ";
                sql += "APP_SEASON='" + Season + "', ";
                sql += "COS_NAME='" + CourseName + "',";
                sql += "COS_CONT ='"+ Content + "',";
                sql += "COS_SDATE='" + StaDay + "',";
                sql += "COS_EDATE='" + FinDay + "',";
                sql += "COS_CAR='" + Manager + "',";
                sql += "COS_RSDATE='" + RStaDay + "',";
                sql += "COS_REDATE='" + RFinDay + "'";
                sql += " where ";
                sql += "APP_YEAR ='" + Year + "'AND ";
                sql += "APP_SEASON='" + Season + "'AND ";
                sql += "COS_NAME='" + CourseName + "'";
                Console.WriteLine(sql);
                set_table("select * from TATM_COR");
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
                        set_table("select * from TATM_COR");
                        set_clear();
                    }

                }
                else
                {
                    MessageBox.Show("수정 취소 되었습니다");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            set_value();
           
            if (All_space_check() == 1)
            {
                  if(conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                string sql = "DELETE FROM TATM_COR where APP_YEAR ='" + Year+"' AND ";
                sql += "APP_SEASON ='"+Season+"' AND ";
                sql += "COS_NAME ='"+CourseName + "';";
                Console.WriteLine(sql);
                if (MessageBox.Show("선택하신 정보가 삭제됩니다", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        cmd = new MySqlCommand(sql, conn);
                        reader = cmd.ExecuteReader();
                        MessageBox.Show("삭제되었습니다");
                        
                        
                    }catch(Exception e1)
                    {
                        MessageBox.Show(e1.ToString());
                    }
                    finally
                    {
                        reader.Close();
                        set_table("select * from TATM_COR");
                        set_clear();
                    }
                   
                }
                else
                {
                    MessageBox.Show("삭제 취소 되었습니다");
                }
            }
        }
        private void set_clear()
        {
            textBox1.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            button6.Enabled = true;
            button8.Enabled = false;
            button9.Enabled = false;
            dateTimePicker3.Text = "";
            dateTimePicker4.Text = "";
            dateTimePicker2.Enabled = false;
            dateTimePicker4.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            set_value();
            set_clear();
        }

        private void checked_year(object sender, EventArgs e)
        {
            set_value();

            int numChk = 0;
            bool isNum = int.TryParse(Year, out numChk);
            if (!isNum)
            {
                //숫자가 아님
                MessageBox.Show("숫자가 아님");
                textBox1.Focus();
            }
            else
            {
                MessageBox.Show("숫자");
                //숫자
                //숫자일 경우 numChk 의 값은 101 이 된다.
            }

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void set_table(string sql)
        {
            listView1.Items.Clear();
            String[] arr = new String[9];
            ListViewItem lvt;
            listView1.FullRowSelect = true;
            // 리스트 뷰 데이터 출력
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            try
            {
                cmd = new MySqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    listView1.GridLines = true;
                    arr[0] = reader["APP_YEAR"].ToString();
                    arr[1] = reader["APP_SEASON"].ToString();
                    arr[2] = reader["COS_NAME"].ToString();
                    arr[5] = reader["COS_CONT"].ToString();
                    arr[3] = reader["COS_SDATE"].ToString();
                    arr[4] = reader["COS_EDATE"].ToString();
                    arr[8] = reader["COS_CAR"].ToString();
                    arr[6] = reader["COS_RSDATE"].ToString();
                    arr[7] = reader["COS_REDATE"].ToString();
                    lvt = new ListViewItem(arr);
                    listView1.Items.Add(lvt);

                }
            }catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                reader.Close();
            }
           
            
           
        }
       
        private void check_TimePicker1(object sender, EventArgs e)
        {
              Console.WriteLine(dateTimePicker1.Text);
              Console.WriteLine(dateTimePicker2.Text);
        }

        private void set_TimePicker1(object sender, EventArgs e)
        {
            mode1 = 1;
            Console.WriteLine("11");
        }

        private void c1(object sender, LayoutEventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void check_TimePicker(object sender, MouseEventArgs e)
        {

        }

        private void check_TimePicker1(object sender, MouseEventArgs e)
        {
        }

        private void set_TimePicker1(object sender, MouseEventArgs e)
        {
            dateTimePicker2.Enabled = true;
        }

        private void check_TimePicker2(object sender, EventArgs e)
        {
            //TimePicker4를 벗어날경우
            Console.WriteLine(dateTimePicker3.Text);
            Console.WriteLine(dateTimePicker4.Text);
            DateTime dtFirstTime;
            DateTime dtEndTime;

            DateTime.TryParse(dateTimePicker3.Text, out dtFirstTime);
            DateTime.TryParse(dateTimePicker4.Text, out dtEndTime);

            Console.WriteLine(dtFirstTime.Month);
            Console.WriteLine(dtEndTime.Month);



        }

        private void dateTimePicker3_MouseUp(object sender, MouseEventArgs e)
        {
            dateTimePicker4.Enabled = true;
        }

        private void listView1_index_click(object sender, MouseEventArgs e)
        {
            ListView.SelectedListViewItemCollection itemColl = listView1.SelectedItems;
            DateTime dt1,dt2,dt3,dt4;
            foreach (ListViewItem item in itemColl)
            {

                // index 는 가변적임 (row 삭제시마다 바뀜) --> 그냥 index 기준으로 삭제하면 안됨.

                // item 의 모든 subitem 출력
                for (int i = 0; i < listView1.Columns.Count; i++)
                {
                    Console.WriteLine("선택된 row 의 {0}번째 subitem 내용 == {1}", i, item.SubItems[i].Text);
                }
                textBox1.Text = item.SubItems[0].Text;
                radioButton1.Checked =  item.SubItems[1].Text == "하계" ? true:false;
                if(radioButton1.Checked != true)
                {
                    radioButton2.Checked = true; 
                }
                textBox3.Text = item.SubItems[2].Text;

                DateTime.TryParse(item.SubItems[3].Text, out dt1);
                dateTimePicker1.Value = dt1;
                
                DateTime.TryParse(item.SubItems[4].Text, out dt2);
                dateTimePicker2.Value = dt2;

                DateTime.TryParse(item.SubItems[6].Text, out dt3);
                dateTimePicker3.Value = dt3;

                DateTime.TryParse(item.SubItems[7].Text, out dt4);
                dateTimePicker4.Value = dt4;
            
                Console.WriteLine(dt1.ToString());
                Console.WriteLine(dt2.ToString());
                Console.WriteLine(dt3.ToString());
                Console.WriteLine(dt4.ToString());
                //dateTimePicker2.Value = item.SubItems[4].ToString();
                //dateTimePicker3.Value = item.SubItems[6].ToString();
                //dateTimePicker4.Value = item.SubItems[7].ToString();

                textBox4.Text = item.SubItems[8].Text;
                textBox5.Text = item.SubItems[5].Text;
            }
            button1.Enabled = true;
            button6.Enabled = false;
            button8.Enabled = true;
            button9.Enabled = true;

        }
    }
}
