namespace 停车场管理系统
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.brefresh = new System.Windows.Forms.Button();
            this.bchange = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tchange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 22);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(717, 355);
            this.dataGridView1.TabIndex = 0;
            // 
            // brefresh
            // 
            this.brefresh.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.brefresh.Location = new System.Drawing.Point(4, 46);
            this.brefresh.Margin = new System.Windows.Forms.Padding(4);
            this.brefresh.Name = "brefresh";
            this.brefresh.Size = new System.Drawing.Size(99, 34);
            this.brefresh.TabIndex = 1;
            this.brefresh.Text = "刷新";
            this.brefresh.UseVisualStyleBackColor = true;
            this.brefresh.Click += new System.EventHandler(this.brefresh_Click);
            // 
            // bchange
            // 
            this.bchange.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.bchange.Location = new System.Drawing.Point(4, 4);
            this.bchange.Margin = new System.Windows.Forms.Padding(4);
            this.bchange.Name = "bchange";
            this.bchange.Size = new System.Drawing.Size(99, 34);
            this.bchange.TabIndex = 2;
            this.bchange.Text = "修改";
            this.bchange.UseVisualStyleBackColor = true;
            this.bchange.Click += new System.EventHandler(this.bchange_Click);
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.bexit.Location = new System.Drawing.Point(4, 88);
            this.bexit.Margin = new System.Windows.Forms.Padding(4);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(99, 34);
            this.bexit.TabIndex = 3;
            this.bexit.Text = "返回";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.bchange);
            this.flowLayoutPanel1.Controls.Add(this.brefresh);
            this.flowLayoutPanel1.Controls.Add(this.bexit);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(805, 163);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(112, 130);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // tchange
            // 
            this.tchange.Location = new System.Drawing.Point(861, 57);
            this.tchange.Margin = new System.Windows.Forms.Padding(4);
            this.tchange.Name = "tchange";
            this.tchange.Size = new System.Drawing.Size(97, 25);
            this.tchange.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label1.Location = new System.Drawing.Point(754, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "请填写金额:";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1001, 479);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tchange);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form4";
            this.Text = "记录修改";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button brefresh;
        private System.Windows.Forms.Button bchange;
        private System.Windows.Forms.Button bexit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tchange;
        private System.Windows.Forms.Label label1;
    }
}