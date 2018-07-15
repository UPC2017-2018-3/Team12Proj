namespace 停车场管理系统
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ttype = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clbdisc = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ttime = new System.Windows.Forms.TextBox();
            this.tprice = new System.Windows.Forms.TextBox();
            this.bcount = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tcartype = new System.Windows.Forms.TextBox();
            this.ball = new System.Windows.Forms.Button();
            this.bin = new System.Windows.Forms.Button();
            this.bout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "车牌号:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label4.Location = new System.Drawing.Point(287, 44);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "车辆类型:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ttype
            // 
            this.ttype.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ttype.Location = new System.Drawing.Point(408, 115);
            this.ttype.Margin = new System.Windows.Forms.Padding(4);
            this.ttype.Name = "ttype";
            this.ttype.ReadOnly = true;
            this.ttype.Size = new System.Drawing.Size(129, 27);
            this.ttype.TabIndex = 8;
            this.ttype.TextChanged += new System.EventHandler(this.ttype_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label2.Location = new System.Drawing.Point(586, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "抵扣券:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // clbdisc
            // 
            this.clbdisc.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.clbdisc.FormattingEnabled = true;
            this.clbdisc.Items.AddRange(new object[] {
            "半小时优惠",
            "一小时优惠",
            "两小时优惠",
            "三小时优惠",
            "全天免费"});
            this.clbdisc.Location = new System.Drawing.Point(659, 42);
            this.clbdisc.Margin = new System.Windows.Forms.Padding(4);
            this.clbdisc.Name = "clbdisc";
            this.clbdisc.Size = new System.Drawing.Size(152, 180);
            this.clbdisc.TabIndex = 11;
            this.clbdisc.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbdisc_ItemCheck);
            this.clbdisc.SelectedIndexChanged += new System.EventHandler(this.clbdisc_SelectedIndexChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label3.Location = new System.Drawing.Point(287, 252);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "最终费用:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label5.Location = new System.Drawing.Point(287, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "停车时长:";
            // 
            // ttime
            // 
            this.ttime.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ttime.Location = new System.Drawing.Point(408, 183);
            this.ttime.Margin = new System.Windows.Forms.Padding(4);
            this.ttime.Name = "ttime";
            this.ttime.ReadOnly = true;
            this.ttime.Size = new System.Drawing.Size(129, 27);
            this.ttime.TabIndex = 14;
            this.ttime.TextChanged += new System.EventHandler(this.ttime_TextChanged);
            // 
            // tprice
            // 
            this.tprice.BackColor = System.Drawing.SystemColors.Window;
            this.tprice.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tprice.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tprice.Location = new System.Drawing.Point(408, 250);
            this.tprice.Margin = new System.Windows.Forms.Padding(4);
            this.tprice.Name = "tprice";
            this.tprice.ReadOnly = true;
            this.tprice.Size = new System.Drawing.Size(129, 27);
            this.tprice.TabIndex = 15;
            // 
            // bcount
            // 
            this.bcount.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bcount.Location = new System.Drawing.Point(679, 248);
            this.bcount.Margin = new System.Windows.Forms.Padding(4);
            this.bcount.Name = "bcount";
            this.bcount.Size = new System.Drawing.Size(104, 35);
            this.bcount.TabIndex = 16;
            this.bcount.Text = "计费";
            this.bcount.UseVisualStyleBackColor = true;
            this.bcount.Click += new System.EventHandler(this.bcount_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(87, 45);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(156, 236);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.label6.Location = new System.Drawing.Point(287, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "停放类型:";
            // 
            // tcartype
            // 
            this.tcartype.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tcartype.Location = new System.Drawing.Point(408, 45);
            this.tcartype.Margin = new System.Windows.Forms.Padding(4);
            this.tcartype.Name = "tcartype";
            this.tcartype.ReadOnly = true;
            this.tcartype.Size = new System.Drawing.Size(129, 27);
            this.tcartype.TabIndex = 21;
            this.tcartype.TextChanged += new System.EventHandler(this.tcartype_TextChanged);
            // 
            // ball
            // 
            this.ball.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ball.Location = new System.Drawing.Point(113, 302);
            this.ball.Margin = new System.Windows.Forms.Padding(4);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(104, 35);
            this.ball.TabIndex = 22;
            this.ball.Text = "所有记录";
            this.ball.UseVisualStyleBackColor = true;
            this.ball.Click += new System.EventHandler(this.ball_Click);
            // 
            // bin
            // 
            this.bin.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bin.Location = new System.Drawing.Point(537, 366);
            this.bin.Margin = new System.Windows.Forms.Padding(4);
            this.bin.Name = "bin";
            this.bin.Size = new System.Drawing.Size(114, 43);
            this.bin.TabIndex = 17;
            this.bin.Text = "返回";
            this.bin.UseVisualStyleBackColor = true;
            this.bin.Click += new System.EventHandler(this.bin_Click);
            // 
            // bout
            // 
            this.bout.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.bout.Location = new System.Drawing.Point(311, 366);
            this.bout.Margin = new System.Windows.Forms.Padding(4);
            this.bout.Name = "bout";
            this.bout.Size = new System.Drawing.Size(114, 43);
            this.bout.TabIndex = 19;
            this.bout.Text = "出场";
            this.bout.UseVisualStyleBackColor = true;
            this.bout.Click += new System.EventHandler(this.bout_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(874, 450);
            this.Controls.Add(this.bout);
            this.Controls.Add(this.bcount);
            this.Controls.Add(this.bin);
            this.Controls.Add(this.tcartype);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tprice);
            this.Controls.Add(this.ttime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clbdisc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ttype);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form3";
            this.Text = "出场管理";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ttype;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox clbdisc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ttime;
        private System.Windows.Forms.TextBox tprice;
        private System.Windows.Forms.Button bcount;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tcartype;
        private System.Windows.Forms.Button ball;
        private System.Windows.Forms.Button bin;
        private System.Windows.Forms.Button bout;
    }
}