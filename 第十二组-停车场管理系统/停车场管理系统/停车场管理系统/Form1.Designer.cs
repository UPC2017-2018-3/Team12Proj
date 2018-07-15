namespace 停车场管理系统
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.tpasswd = new System.Windows.Forms.TextBox();
            this.blogin = new System.Windows.Forms.Button();
            this.bexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(169, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "管理员登陆系统";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(231, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "工号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.label3.Location = new System.Drawing.Point(231, 248);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 2;
            this.label3.Text = "密码：";
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(325, 183);
            this.tname.Margin = new System.Windows.Forms.Padding(4);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(213, 25);
            this.tname.TabIndex = 3;
            this.tname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.tname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tname_KeyDown);
            // 
            // tpasswd
            // 
            this.tpasswd.Location = new System.Drawing.Point(325, 248);
            this.tpasswd.Margin = new System.Windows.Forms.Padding(4);
            this.tpasswd.Name = "tpasswd";
            this.tpasswd.PasswordChar = '*';
            this.tpasswd.Size = new System.Drawing.Size(213, 25);
            this.tpasswd.TabIndex = 4;
            this.tpasswd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tpasswd_KeyDown);
            // 
            // blogin
            // 
            this.blogin.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.blogin.Location = new System.Drawing.Point(226, 321);
            this.blogin.Margin = new System.Windows.Forms.Padding(4);
            this.blogin.Name = "blogin";
            this.blogin.Size = new System.Drawing.Size(123, 42);
            this.blogin.TabIndex = 5;
            this.blogin.Text = "登录";
            this.blogin.UseVisualStyleBackColor = true;
            this.blogin.Click += new System.EventHandler(this.blogin_Click);
            // 
            // bexit
            // 
            this.bexit.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bexit.Location = new System.Drawing.Point(440, 321);
            this.bexit.Margin = new System.Windows.Forms.Padding(4);
            this.bexit.Name = "bexit";
            this.bexit.Size = new System.Drawing.Size(123, 42);
            this.bexit.TabIndex = 6;
            this.bexit.Text = "退出";
            this.bexit.UseVisualStyleBackColor = true;
            this.bexit.Click += new System.EventHandler(this.bexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(782, 445);
            this.Controls.Add(this.bexit);
            this.Controls.Add(this.blogin);
            this.Controls.Add(this.tpasswd);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "停车场管理员登陆";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tpasswd;
        private System.Windows.Forms.Button blogin;
        private System.Windows.Forms.Button bexit;
    }
}