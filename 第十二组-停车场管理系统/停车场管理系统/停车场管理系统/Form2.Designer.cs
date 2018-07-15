namespace 停车场管理系统
{
    partial class Form2
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tplate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ttime = new System.Windows.Forms.TextBox();
            this.cbtype = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bok = new System.Windows.Forms.Button();
            this.brefresh = new System.Windows.Forms.Button();
            this.bout = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbcartype = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(49, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号:";
            // 
            // tplate
            // 
            this.tplate.Location = new System.Drawing.Point(122, 112);
            this.tplate.Margin = new System.Windows.Forms.Padding(4);
            this.tplate.Name = "tplate";
            this.tplate.Size = new System.Drawing.Size(115, 25);
            this.tplate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(-3, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "当前时间:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ttime);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.groupBox1.Location = new System.Drawing.Point(52, 168);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(571, 346);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "场内车辆";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(441, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 29);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 294);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "剩余车位:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(25, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(488, 229);
            this.dataGridView1.TabIndex = 0;
            // 
            // ttime
            // 
            this.ttime.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ttime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ttime.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ttime.Location = new System.Drawing.Point(92, 298);
            this.ttime.Margin = new System.Windows.Forms.Padding(4);
            this.ttime.Name = "ttime";
            this.ttime.ReadOnly = true;
            this.ttime.Size = new System.Drawing.Size(168, 22);
            this.ttime.TabIndex = 12;
            this.ttime.TextChanged += new System.EventHandler(this.ttime_TextChanged);
            // 
            // cbtype
            // 
            this.cbtype.FormattingEnabled = true;
            this.cbtype.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cbtype.Items.AddRange(new object[] {
            "短时停放",
            "长租车位"});
            this.cbtype.Location = new System.Drawing.Point(425, 112);
            this.cbtype.Margin = new System.Windows.Forms.Padding(4);
            this.cbtype.Name = "cbtype";
            this.cbtype.Size = new System.Drawing.Size(115, 23);
            this.cbtype.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label4.Location = new System.Drawing.Point(323, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "停放类型:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // bok
            // 
            this.bok.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.bok.Location = new System.Drawing.Point(720, 270);
            this.bok.Margin = new System.Windows.Forms.Padding(4);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(102, 41);
            this.bok.TabIndex = 7;
            this.bok.Text = "确认进场";
            this.bok.UseVisualStyleBackColor = true;
            this.bok.Click += new System.EventHandler(this.bok_Click);
            // 
            // brefresh
            // 
            this.brefresh.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.brefresh.Location = new System.Drawing.Point(720, 209);
            this.brefresh.Margin = new System.Windows.Forms.Padding(4);
            this.brefresh.Name = "brefresh";
            this.brefresh.Size = new System.Drawing.Size(102, 41);
            this.brefresh.TabIndex = 8;
            this.brefresh.Text = "刷新列表";
            this.brefresh.UseVisualStyleBackColor = true;
            this.brefresh.Click += new System.EventHandler(this.brefresh_Click);
            // 
            // bout
            // 
            this.bout.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.bout.Location = new System.Drawing.Point(720, 334);
            this.bout.Margin = new System.Windows.Forms.Padding(4);
            this.bout.Name = "bout";
            this.bout.Size = new System.Drawing.Size(102, 41);
            this.bout.TabIndex = 9;
            this.bout.Text = "出场管理";
            this.bout.UseVisualStyleBackColor = true;
            this.bout.Click += new System.EventHandler(this.button3_Click);
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.bexit.Location = new System.Drawing.Point(720, 397);
            this.bexit.Margin = new System.Windows.Forms.Padding(4);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(102, 41);
            this.bexit.TabIndex = 10;
            this.bexit.Text = "退出";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.Location = new System.Drawing.Point(634, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 13;
            this.label3.Text = "车辆类型:";
            // 
            // cbcartype
            // 
            this.cbcartype.FormattingEnabled = true;
            this.cbcartype.Items.AddRange(new object[] {
            "中小型",
            "大型"});
            this.cbcartype.Location = new System.Drawing.Point(737, 110);
            this.cbcartype.Margin = new System.Windows.Forms.Padding(4);
            this.cbcartype.Name = "cbcartype";
            this.cbcartype.Size = new System.Drawing.Size(115, 23);
            this.cbcartype.TabIndex = 14;
            this.cbcartype.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(60, 65);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(792, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "*本停车场共10个车位，进场半小时以内免费，超过半小时后按一小时计费，超过24小时后每小时加10元";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(150, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "收费标准: 中小型车20元/小时";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(461, 27);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 19);
            this.label7.TabIndex = 17;
            this.label7.Text = "大型车30/小时";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(634, 27);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "长租车辆免费";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(934, 527);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.bout);
            this.Controls.Add(this.bok);
            this.Controls.Add(this.brefresh);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbcartype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbtype);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tplate);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "进场管理";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tplate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cbtype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bok;
        private System.Windows.Forms.Button brefresh;
        private System.Windows.Forms.Button bout;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.TextBox ttime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbcartype;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
    }
}

