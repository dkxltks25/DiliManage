using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
namespace DiliManage
{
    public partial class Stu_sel : Form
    {
        private static string mysql_str = "server=l.bsks.ac.kr;port=3306;Database=p201887082;Uid=p201887082;Pwd=pp201887082;Charset=utf8;SSLMODE = NONE";
        private static string StudentNumber;
        private static string StudentName;
        private static string StudentSex;
        private static int mode;

        public void DBconnect()
        {
            conn = new MySqlConnection(mysql_str);
            cmd = new MySqlCommand();
            cmd.Connection = conn;
        }

        public Stu_sel()
        {
            InitializeComponent();
            DBconnect();
            SelectQuery();

        }

        MySqlConnection conn = new MySqlConnection(mysql_str);
        MySqlCommand cmd;
        MySqlDataReader reader;

        private void SelectQuery()
        {
            string sql = "SELECT * FROM TATM_STU";
            set_table(sql);
        }
        private void SelectQuery(string sql)
        {
            set_table(sql);
        }
        private void set_table(string sql)
        {
            listView1.Items.Clear();
            String[] arr = new String[5];
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
                    arr[0] = reader["STU_STUNO"].ToString();
                    arr[1] = reader["STU_NAME"].ToString();
                    arr[2] = reader["STU_SEX"].ToString();
                    arr[3] = reader["STU_PHONE"].ToString();
                    arr[4] = reader["STU_MAIL"].ToString();
                    lvt = new ListViewItem(arr);
                    listView1.Items.Add(lvt);
                }
                set_clear();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            finally
            {
                reader.Close();
            }
        }
        

        private void set_clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton1.Checked = true;
            button7.Enabled = true;
            ins.Enabled = true;
            button8.Enabled = false;
            button9.Enabled = false;
            button1.Enabled = true;
        }
        private void set_value()
        {
            StudentNumber = textBox1.Text;
            StudentName = textBox2.Text;
            StudentSex = radioButton1.Checked == true ? "남" : "여";
            Console.WriteLine("--------------테스트-----------");
            Console.WriteLine(StudentNumber);
            Console.WriteLine(StudentName);
            Console.WriteLine(StudentSex);
            Console.WriteLine("--------------테스트-----------");

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

        private void Ins_Click(object sender, EventArgs e)
        {
            mode = 2;
            Stu_up aptu = new Stu_up(2);
            this.Close();
            aptu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            set_value();
            string sql;
            sql = "SELECT * FROM TATM_STU where STU_STUNO LIKE '%"+StudentNumber+"%' AND STU_NAME LIKE '%" +StudentName+"%' AND STU_SEX LIKE '%"+StudentSex+"%'";
            Console.WriteLine(sql);
            SelectQuery(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectQuery();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection itemColl = listView1.SelectedItems;
            foreach(ListViewItem item in itemColl)
            {

                // index 는 가변적임 (row 삭제시마다 바뀜) --> 그냥 index 기준으로 삭제하면 안됨.

                // item 의 모든 subitem 출력
                for (int i = 0; i < listView1.Columns.Count; i++)
                {
                    Console.WriteLine("선택된 row 의 {0}번째 subitem 내용 == {1}", i, item.SubItems[i].Text);
                }
                textBox1.Text = item.SubItems[0].Text;
                textBox2.Text = item.SubItems[1].Text;
                radioButton1.Checked = item.SubItems[2].Text == "남" ? true : false;
            }
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            button8.Enabled = true;
            button9.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            set_value();
            string sql = "DELETE FROM TATM_STU where STU_STUNO = '"+StudentNumber+"'";
            if (MessageBox.Show("선택하신 정보를 삭제하시겠습니까", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Console.WriteLine(sql);
                    if(conn.State == ConnectionState.Closed)
                    {
                        conn.Open();
                    }
                    cmd = new MySqlCommand(sql, conn);
                    reader = cmd.ExecuteReader();
                    MessageBox.Show("삭제되었습니다");
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString());
                }
                finally
                {
                    reader.Close();
                    SelectQuery();
                }

            }
            else
            {
                MessageBox.Show("삭제 취소 되었습니다");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            set_value();
            mode = 3;
            Stu_up aptu = new Stu_up(mode,StudentNumber.ToString());
            this.Close();
            aptu.ShowDialog();
        }
    }
}
