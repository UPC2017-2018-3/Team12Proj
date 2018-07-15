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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            string constr = "server=.;Database=停车管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "SELECT * FROM TABLE_1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Open();
            conn.Close();
                
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3=new Form3();
            f3.Owner = this;
            f3.ShowDialog();
            //this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void brefresh_Click(object sender, EventArgs e)
        {
            
            string constr = "server=.;Database=停车管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "SELECT * FROM TABLE_1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            int count1 = dataGridView1.Rows.Count;
            textBox1.Text = (10 - count1 + 1).ToString();
            conn.Open();
                MessageBox.Show(string.Format("数据刷新成功!"));
            conn.Close();
        }

        private void bok_Click(object sender, EventArgs e)
        {
            if (tplate.Text != ""&&cbtype.Text!=""&&cbcartype.Text!="")
            {
                int count = dataGridView1.Rows.Count;
                if (count <= 10)
                {
                    string constr = "server=.;Database=停车管理;integrated security=SSPI";
                    SqlConnection conn = new SqlConnection(constr);
                    string commandstr = "INSERT into TABLE_1 (车牌号,车辆类型,停放类型,进场时间) values('" + tplate.Text + "','" + cbcartype.Text + "','" + cbtype.Text + "','" + ttime.Text + "');SELECT * FROM TABLE_1";
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Open();
                    conn.Close();
                    this.cbtype.Text = "";
                    this.cbcartype.Text = "";
                    this.tplate.Text = "";
                }
                else
                    MessageBox.Show(string.Format("车位已满!"));
            }
            else
                MessageBox.Show(string.Format("请填写完整信息!"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           ttime.Text = DateTime.Now.ToString();  
        }

        private void ttime_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Owner.Hide();
        }
        public void Function()
        {
            string constr = "server=.;Database=停车管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "SELECT * FROM TABLE_1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Open();
            conn.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
