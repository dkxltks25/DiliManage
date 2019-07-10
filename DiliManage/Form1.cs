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
    public partial class Form1 : Form
    {
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
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //창 닫기 
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            //로그인
            string id = login_id.Text;
            string pw = login_pw.Text;

            if (space_check(id, "아이디") == 1)
            {
                if (space_check(pw, "패스워드") == 1)
                {

                    if (check_login(id, pw) != 0)
                    {

                        MainPage1 m1 = new MainPage1(mode);
                        m1.ShowDialog();

                    }
                }
            }


        }
        private int check_login(string id, string pw)
        {
            DBconnect();
            try
            {
                string sql = "SELECT * FROM ADMIN_TABLE where ADMIN_ID = '" + id + "' AND ADMIN_PASS = '" + pw + "' ";
                conn.Open();
                cmd = new MySqlCommand(sql, conn);

                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string aut = reader["ADMIN_AUT"].ToString();
                    reader.Close();
                    if (aut == "A")
                    {
                        mode = 1;

                    }
                    else
                    {
                        mode = 2;

                    }
                    return 1;
                }
                else
                {
                    MessageBox.Show("ID 혹은 비밀번호가 잘못되었습니다");
                    reader.Close();
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.Write(e.ToString());
                return 0;
            }


        }
        private void login_id_TextChanged(object sender, EventArgs e)
        {

        }
        private int space_check(string text, string alert_msg)
        {
            if (text == "")
            {
                MessageBox.Show(alert_msg + "빈칸입니다");
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
