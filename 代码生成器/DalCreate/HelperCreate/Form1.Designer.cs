namespace DALCreate
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TB_NameSpace = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CB_TableList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CB_DataList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TB_Pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_User = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_Result
            // 
            this.TB_Result.Location = new System.Drawing.Point(271, 26);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.Size = new System.Drawing.Size(501, 542);
            this.TB_Result.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 349);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "批量生成";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "生成单一文件";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TB_NameSpace);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(17, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 69);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "自定义配置";
            // 
            // TB_NameSpace
            // 
            this.TB_NameSpace.Location = new System.Drawing.Point(100, 27);
            this.TB_NameSpace.Name = "TB_NameSpace";
            this.TB_NameSpace.Size = new System.Drawing.Size(100, 21);
            this.TB_NameSpace.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "自定义命名空间:";
            // 
            // CB_TableList
            // 
            this.CB_TableList.FormattingEnabled = true;
            this.CB_TableList.Location = new System.Drawing.Point(87, 204);
            this.CB_TableList.Name = "CB_TableList";
            this.CB_TableList.Size = new System.Drawing.Size(121, 20);
            this.CB_TableList.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "数据库表:";
            // 
            // CB_DataList
            // 
            this.CB_DataList.FormattingEnabled = true;
            this.CB_DataList.Location = new System.Drawing.Point(87, 169);
            this.CB_DataList.Name = "CB_DataList";
            this.CB_DataList.Size = new System.Drawing.Size(121, 20);
            this.CB_DataList.TabIndex = 8;
            this.CB_DataList.SelectionChangeCommitted += new System.EventHandler(this.CB_DataList_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "数据库列表:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(144, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "连接数据库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_Pwd
            // 
            this.TB_Pwd.Location = new System.Drawing.Point(87, 85);
            this.TB_Pwd.Name = "TB_Pwd";
            this.TB_Pwd.PasswordChar = '*';
            this.TB_Pwd.Size = new System.Drawing.Size(132, 21);
            this.TB_Pwd.TabIndex = 5;
            this.TB_Pwd.Text = "123456";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "登录密码：";
            // 
            // TB_User
            // 
            this.TB_User.Location = new System.Drawing.Point(87, 52);
            this.TB_User.Name = "TB_User";
            this.TB_User.Size = new System.Drawing.Size(132, 21);
            this.TB_User.TabIndex = 3;
            this.TB_User.Text = "sa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "数据库账号：";
            // 
            // TB_IP
            // 
            this.TB_IP.Location = new System.Drawing.Point(87, 23);
            this.TB_IP.Name = "TB_IP";
            this.TB_IP.Size = new System.Drawing.Size(132, 21);
            this.TB_IP.TabIndex = 1;
            this.TB_IP.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "数据库IP：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.CB_TableList);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CB_DataList);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TB_Pwd);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TB_User);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TB_IP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 543);
            this.panel1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 593);
            this.Controls.Add(this.TB_Result);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_NameSpace;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CB_TableList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CB_DataList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TB_Pwd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_User;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

