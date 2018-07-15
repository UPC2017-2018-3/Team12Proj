using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 停车场管理系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void blogin_Click(object sender, EventArgs e)
        {
            string constr = "server=.;Database=停车管理员表;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "SELECT * FROM TABLE_1 WHERE 工号='" + tname.Text + "'and 密码='" + tpasswd.Text + "'";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            conn.Open();
            if (dt.Rows.Count > 0)
            {
                string name = tname.Text;
                MessageBox.Show(string.Format("工号"+tname.Text+"登录成功!"));
                Form2 f2 = new Form2();
                f2.ShowDialog(this);
            }
            else
                MessageBox.Show(string.Format("用户名或密码错误，登录失败"));
            conn.Close();
        }

        private void tname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)   
            {
                this.tpasswd.Focus();
            }
        }

        private void tpasswd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)   
            {
                this.blogin.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
