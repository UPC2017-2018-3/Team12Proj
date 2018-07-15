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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            string constr = "server=.;Database=停车管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            string commandstr = "SELECT 车牌号 FROM TABLE_1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Open();
            conn.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ttype.Text = "";
            this.tcartype.Text = "";
            this.ttime.Text = "";
            this.tprice.Text = "";
            string strname = dataGridView1.SelectedCells[0].Value.ToString();
            string constr = "server=.;Database=停车管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM TABLE_1 WHERE 车牌号='"+strname+"'";
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.Read())
            {
                this.ttype.Text = dr.GetString(2);
                this.tcartype.Text = dr.GetString(1);
                string time1 = dr.GetString(3);
                DateTime t1 = DateTime.Parse(time1);
                DateTime t2 = DateTime.Now;
                System.TimeSpan ts = t2 - t1;
                int timeh = ts.Hours;
                int timem=ts.Minutes;
                int timed = ts.Days;
                this.ttime.Text = (""+timed+"天"+timeh+"时"+timem+"分");
            }
            dr.Close(); ;
            string type = "长租车位      ";
            string type1 = tcartype.Text;
            if (type == type1)
            {
                clbdisc.Enabled = false;
            }
            else
                clbdisc.Enabled = true;
            conn.Close();
        }

        private void bout_Click(object sender, EventArgs e)
        {
            string plate = "";
            string type3 = "";
            string cartype = "";
            string time1 = "";
            string time2 = "";
            {
                string strname = dataGridView1.SelectedCells[0].Value.ToString();
                string constr = "server=.;Database=停车管理;integrated security=SSPI";
                SqlConnection conn = new SqlConnection(constr);
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM TABLE_1 WHERE 车牌号='" + strname + "'";
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    plate = dr.GetString(0);
                    type3 = dr.GetString(2);
                    cartype = dr.GetString(1);
                    time1 = dr.GetString(3);
                    DateTime t1 = DateTime.Parse(time1);
                    DateTime t2 = DateTime.Now;
                    time2 = Convert.ToString(t2);

                }
                dr.Close();
                conn.Close();
            }
            if (tprice.Text != "")
            {
                string constr1 = "server=.;Database=停车管理bak;integrated security=SSPI";
                SqlConnection conn1 = new SqlConnection(constr1);
                string commandstr1 = "INSERT INTO Table_1 (车牌号,车辆类型,停放类型,进场时间,出场时间,费用) values('" + plate + "','" + type3 + "','" + cartype + "','" + time1 + "','" + time2 + "','" + tprice.Text + "');";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(commandstr1, conn1);
                conn1.Open();
                da.Fill(dt);
                conn1.Close();
            }
            if (tprice.Text != "")
            {
                string strname = dataGridView1.SelectedCells[0].Value.ToString();
                string constr = "server=.;Database=停车管理;integrated security=SSPI";
                SqlConnection conn = new SqlConnection(constr);
                string commandstr = "DELETE FROM TABLE_1 where 车牌号='" + strname + "';SELECT 车牌号 FROM TABLE_1";
                conn.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(commandstr, conn);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                this.ttype.Text = "";
                this.tcartype.Text = "";
                this.ttime.Text = "";
                this.tprice.Text = "";
                MessageBox.Show(string.Format("车辆已出场!"));
            }
            else
                MessageBox.Show(string.Format("请先计费后再出场!"));
            Form2 owner = (Form2)this.Owner;
            owner.Function();
        }

        private void bcount_Click(object sender, EventArgs e)
        {
            string strname = dataGridView1.SelectedCells[0].Value.ToString();
            string constr = "server=.;Database=停车管理;integrated security=SSPI";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM TABLE_1 WHERE 车牌号='" + strname + "'";
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                string time1 = dr.GetString(3);
                DateTime t1 = DateTime.Parse(time1);
                DateTime t2 = DateTime.Now;
                System.TimeSpan ts = t2 - t1;
                int timeh = ts.Hours;
                int timem = ts.Minutes;
                int timed = ts.Days;
                int price = 0;
                string cartype = "大型        ";
                if (ttype.Text != cartype)
                {
                    if (timem < 30 && timeh == 0 && timed == 0 )
                    {
                        price = 0;
                    }
                    if (timem >= 30 && timed == 0 && timeh < 24 )
                    {
                        price = 20 * timeh + 20;
                    }
                    if (timem < 30 && timeh > 0 && timeh < 24 && timed == 0)
                    {
                        price = 20 * timeh + 10;
                    }
                    if (timem < 30 && timed != 0)
                    {
                        price = 20 * 24 * timed + timeh  * 30;
                    }
                    if (timed != 0 && timem >= 30)
                    {
                        price = 20 * 24 * timed + timeh * 30 + 15;
                    }

                    if (clbdisc.GetItemChecked(0))
                    {
                        if (price >= 10)
                        {
                            price = price - 10;
                        }
                        else
                        {
                            price = 0;
                        }
                    }
                    if (clbdisc.GetItemChecked(1))
                    {
                        if (price >= 20)
                        {
                            price = price - 20;
                        }
                        else
                        {
                            price = 0;
                        }
                    }
                    if (clbdisc.GetItemChecked(2))
                    {
                        if (price >= 40)
                        {
                            price = price - 40;
                        }
                        else
                        {
                            price = 0;
                        }
                    }
                    if (clbdisc.GetItemChecked(3))
                    {
                        if (price >= 60)
                        {
                            price = price - 60;
                        }
                        else
                        {
                            price = 0;
                        }
                    }
                    if (clbdisc.GetItemChecked(4))
                    {
                        if (price >= 480)
                        {
                            price = price - 480;
                        }
                        else
                        {
                            price = 0;
                        }
                    }
                    string type = "长租车位      ";
                    string type1 = tcartype.Text;
                    if (type1 == type)
                    {
                        price = 0;
                    }

                    string p = Convert.ToString(price);
                    tprice.Text = p + ".00元";
                }
                else
                {
                    if (timem < 30 && timeh == 0 && timed == 0)
                    {
                        price = 0;
                    }
                    if (timem >= 30 && timed == 0 && timeh < 24)
                    {
                        price = 30 * timeh + 30;
                    }
                    if (timem < 30 && timeh > 0 && timeh < 24 && timed == 0)
                    {
                        price = 30 * timeh + 15;
                    }
                    if (timem < 30 && timed != 0)
                    {
                        price = 30 * 24 * timed + timeh * 40;
                    }
                    if (timed != 0 && timem >= 30)
                    {
                        price = 30 * 24 * timed + timeh * 40 + 20;
                    }

                    if (clbdisc.GetItemChecked(0))
                    {
                        if (price >= 15)
                        {
                            price = price - 15;
                        }
                        else
                        {
                            price = 0;
                        }
                    }
                    if (clbdisc.GetItemChecked(1))
                    {
                        if (price >= 30)
                        {
                            price = price - 30;
                        }
                        else
                        {
                            price = 0;
                        }
                    }
                    if (clbdisc.GetItemChecked(2))
                    {
                        if (price >= 60)
                        {
                            price = price - 60;
                        }
                        else
                        {
                            price = 0;
                        }
                    }
                    if (clbdisc.GetItemChecked(3))
                    {
                        if (price >= 90)
                        {
                            price = price - 90;
                        }
                        else
                        {
                            price = 0;
                        }
                    }
                    if (clbdisc.GetItemChecked(4))
                    {
                        if (price >= 720)
                        {
                            price = price - 720;
                        }
                        else
                        {
                            price = 0;
                        }
                    }
                    string type = "长租车位      ";
                    string type1 = tcartype.Text;
                    if (type1 == type)
                    {
                        price = 0;
                        
                    }

                    string p = Convert.ToString(price);
                    tprice.Text = p + ".00元";
                }

            }
            dr.Close(); ;
        }

        private void clbdisc_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void clbdisc_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void ball_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void clbdisc_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tcartype_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttype_TextChanged(object sender, EventArgs e)
        {

        }

        private void ttime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
