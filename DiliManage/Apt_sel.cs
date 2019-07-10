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
    public partial class Apt_sel : Form
    {
        public Apt_sel()
        {
            InitializeComponent();
        }


        private void Cour_Click(object sender, EventArgs e)
        {
            pra cou = new pra();
            this.Close();
            cou.Show();
        }

        private void Re_Click(object sender, EventArgs e)
        {
            requset re = new requset();
            this.Close();
            re.Show();
        }

        private void Stu_Click(object sender, EventArgs e)
        {
            Stu_sel apt = new Stu_sel();
            this.Close();
            apt.Show();
        }


        private void Ft_Click(object sender, EventArgs e)
        {
            FT ft = new FT();
            this.Close();
            ft.Show();
        }

        private void Apt_Click(object sender, EventArgs e)
        {
           Apt_sel apt = new Apt_sel();
            this.Close();
            apt.Show();
        }

        private void Sta_Click(object sender, EventArgs e)
        {
            Statics sta = new Statics();
            this.Close();
            sta.Show();
        }

        private void Ins_Click(object sender, EventArgs e)
        {
            Apt_up aptu = new Apt_up();
            this.Close();
            aptu.Show();
        }
    }
}
