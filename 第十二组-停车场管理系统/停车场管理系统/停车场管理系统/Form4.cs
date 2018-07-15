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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            string constr = "server=.;Database=停车管理bak;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "SELECT * FROM TABLE_1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Open();
            conn.Close();
        }

        private void brefresh_Click(object sender, EventArgs e)
        {
            string constr = "server=.;Database=停车管理bak;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "SELECT * FROM TABLE_1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Open();
            conn.Close();
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bchange_Click(object sender, EventArgs e)
        {
            string str = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string temp = ".00元";
            string text1 = tchange.Text + temp;
            string constr = "server=.;Database=停车管理bak;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "UPDATE Table_1 SET 费用 = '"+text1+"' WHERE 车牌号 = '"+str+"';SELECT * FROM TABLE_1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Open();
            MessageBox.Show(string.Format("数据更新成功!"));
            conn.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
