namespace FenXingFormDemo
{
    partial class ConsoleScreen
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
            this.button_launch_ps = new System.Windows.Forms.Button();
            this.tabControl_setting = new System.Windows.Forms.TabControl();
            this.tabPage_big_screen = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_set = new System.Windows.Forms.Button();
            this.textBox_fs_col = new System.Windows.Forms.TextBox();
            this.textBox_fs_row = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ps_page = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ps_col = new System.Windows.Forms.TextBox();
            this.textBox_ps_row = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_fx_img_num = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_choose = new System.Windows.Forms.Button();
            this.PicNumTextBox = new System.Windows.Forms.TextBox();
            this.PageNumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.BigScreenPageInfo = new System.Windows.Forms.Label();
            this.button_pre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_rand = new System.Windows.Forms.Button();
            this.button_text = new System.Windows.Forms.Button();
            this.button_shuffle = new System.Windows.Forms.Button();
            this.button_launch_fs = new System.Windows.Forms.Button();
            this.button_adjust = new System.Windows.Forms.Button();
            this.tabPage_cast_screen = new System.Windows.Forms.TabPage();
            this.tabPage_player_screen = new System.Windows.Forms.TabPage();
            this.tabControl_setting.SuspendLayout();
            this.tabPage_big_screen.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_launch_ps
            // 
            this.button_launch_ps.Enabled = false;
            this.button_launch_ps.Location = new System.Drawing.Point(30, 29);
            this.button_launch_ps.Name = "button_launch_ps";
            this.button_launch_ps.Size = new System.Drawing.Size(413, 23);
            this.button_launch_ps.TabIndex = 0;
            this.button_launch_ps.Text = "启动分页大屏";
            this.button_launch_ps.UseVisualStyleBackColor = true;
            this.button_launch_ps.Click += new System.EventHandler(this.button_launch_ps_Click);
            // 
            // tabControl_setting
            // 
            this.tabControl_setting.Controls.Add(this.tabPage_big_screen);
            this.tabControl_setting.Controls.Add(this.tabPage_cast_screen);
            this.tabControl_setting.Controls.Add(this.tabPage_player_screen);
            this.tabControl_setting.Location = new System.Drawing.Point(12, 12);
            this.tabControl_setting.Name = "tabControl_setting";
            this.tabControl_setting.SelectedIndex = 0;
            this.tabControl_setting.Size = new System.Drawing.Size(557, 438);
            this.tabControl_setting.TabIndex = 2;
            // 
            // tabPage_big_screen
            // 
            this.tabPage_big_screen.Controls.Add(this.groupBox3);
            this.tabPage_big_screen.Controls.Add(this.groupBox2);
            this.tabPage_big_screen.Controls.Add(this.groupBox1);
            this.tabPage_big_screen.Location = new System.Drawing.Point(4, 22);
            this.tabPage_big_screen.Name = "tabPage_big_screen";
            this.tabPage_big_screen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_big_screen.Size = new System.Drawing.Size(549, 412);
            this.tabPage_big_screen.TabIndex = 0;
            this.tabPage_big_screen.Text = "大屏设置";
            this.tabPage_big_screen.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_set);
            this.groupBox3.Controls.Add(this.textBox_fs_col);
            this.groupBox3.Controls.Add(this.textBox_fs_row);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.textBox_ps_page);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBox_ps_col);
            this.groupBox3.Controls.Add(this.textBox_ps_row);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_fx_img_num);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(45, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(453, 152);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "大屏显示设置";
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(307, 123);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(122, 23);
            this.button_set.TabIndex = 13;
            this.button_set.Text = "设置";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // textBox_fs_col
            // 
            this.textBox_fs_col.Location = new System.Drawing.Point(246, 52);
            this.textBox_fs_col.Name = "textBox_fs_col";
            this.textBox_fs_col.Size = new System.Drawing.Size(40, 21);
            this.textBox_fs_col.TabIndex = 12;
            this.textBox_fs_col.Text = "10";
            // 
            // textBox_fs_row
            // 
            this.textBox_fs_row.Location = new System.Drawing.Point(119, 52);
            this.textBox_fs_row.Name = "textBox_fs_row";
            this.textBox_fs_row.Size = new System.Drawing.Size(40, 21);
            this.textBox_fs_row.TabIndex = 11;
            this.textBox_fs_row.Text = "4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(187, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "全屏列数";
            // 
            // textBox_ps_page
            // 
            this.textBox_ps_page.Location = new System.Drawing.Point(119, 91);
            this.textBox_ps_page.Name = "textBox_ps_page";
            this.textBox_ps_page.Size = new System.Drawing.Size(40, 21);
            this.textBox_ps_page.TabIndex = 12;
            this.textBox_ps_page.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "全屏行数";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "分页屏列数";
            // 
            // textBox_ps_col
            // 
            this.textBox_ps_col.Location = new System.Drawing.Point(388, 91);
            this.textBox_ps_col.Name = "textBox_ps_col";
            this.textBox_ps_col.Size = new System.Drawing.Size(40, 21);
            this.textBox_ps_col.TabIndex = 12;
            this.textBox_ps_col.Text = "5";
            // 
            // textBox_ps_row
            // 
            this.textBox_ps_row.Location = new System.Drawing.Point(246, 91);
            this.textBox_ps_row.Name = "textBox_ps_row";
            this.textBox_ps_row.Size = new System.Drawing.Size(40, 21);
            this.textBox_ps_row.TabIndex = 11;
            this.textBox_ps_row.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "分页屏页数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "分形图数量";
            // 
            // textBox_fx_img_num
            // 
            this.textBox_fx_img_num.Location = new System.Drawing.Point(119, 20);
            this.textBox_fx_img_num.Name = "textBox_fx_img_num";
            this.textBox_fx_img_num.Size = new System.Drawing.Size(40, 21);
            this.textBox_fx_img_num.TabIndex = 12;
            this.textBox_fx_img_num.Text = "40";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "分页屏行数";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_choose);
            this.groupBox2.Controls.Add(this.PicNumTextBox);
            this.groupBox2.Controls.Add(this.PageNumTextBox);
            this.groupBox2.Controls.Add(this.button_launch_ps);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_next);
            this.groupBox2.Controls.Add(this.BigScreenPageInfo);
            this.groupBox2.Controls.Add(this.button_pre);
            this.groupBox2.Location = new System.Drawing.Point(43, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 147);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "分页屏操作";
            // 
            // button_choose
            // 
            this.button_choose.Enabled = false;
            this.button_choose.Location = new System.Drawing.Point(317, 105);
            this.button_choose.Name = "button_choose";
            this.button_choose.Size = new System.Drawing.Size(122, 21);
            this.button_choose.TabIndex = 7;
            this.button_choose.Text = "确认选择图片";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button_choose_Click);
            // 
            // PicNumTextBox
            // 
            this.PicNumTextBox.Location = new System.Drawing.Point(221, 105);
            this.PicNumTextBox.Name = "PicNumTextBox";
            this.PicNumTextBox.Size = new System.Drawing.Size(75, 21);
            this.PicNumTextBox.TabIndex = 6;
            // 
            // PageNumTextBox
            // 
            this.PageNumTextBox.Location = new System.Drawing.Point(70, 105);
            this.PageNumTextBox.Name = "PageNumTextBox";
            this.PageNumTextBox.Size = new System.Drawing.Size(75, 21);
            this.PageNumTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "图片编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "页号";
            // 
            // button_next
            // 
            this.button_next.Enabled = false;
            this.button_next.Location = new System.Drawing.Point(319, 68);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(122, 21);
            this.button_next.TabIndex = 2;
            this.button_next.Text = "下一页";
            this.button_next.UseVisualStyleBackColor = true;
            this.button_next.Click += new System.EventHandler(this.button_next_Click);
            // 
            // BigScreenPageInfo
            // 
            this.BigScreenPageInfo.AutoSize = true;
            this.BigScreenPageInfo.Location = new System.Drawing.Point(215, 72);
            this.BigScreenPageInfo.Name = "BigScreenPageInfo";
            this.BigScreenPageInfo.Size = new System.Drawing.Size(35, 12);
            this.BigScreenPageInfo.TabIndex = 1;
            this.BigScreenPageInfo.Text = "第1页";
            // 
            // button_pre
            // 
            this.button_pre.Enabled = false;
            this.button_pre.Location = new System.Drawing.Point(28, 66);
            this.button_pre.Name = "button_pre";
            this.button_pre.Size = new System.Drawing.Size(132, 21);
            this.button_pre.TabIndex = 0;
            this.button_pre.Text = "上一页";
            this.button_pre.UseVisualStyleBackColor = true;
            this.button_pre.Click += new System.EventHandler(this.button_pre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_rand);
            this.groupBox1.Controls.Add(this.button_text);
            this.groupBox1.Controls.Add(this.button_shuffle);
            this.groupBox1.Controls.Add(this.button_adjust);
            this.groupBox1.Controls.Add(this.button_launch_fs);
            this.groupBox1.Location = new System.Drawing.Point(45, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 58);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "全屏操作";
            // 
            // button_rand
            // 
            this.button_rand.Enabled = false;
            this.button_rand.Location = new System.Drawing.Point(110, 20);
            this.button_rand.Name = "button_rand";
            this.button_rand.Size = new System.Drawing.Size(75, 23);
            this.button_rand.TabIndex = 9;
            this.button_rand.Text = "随机删除";
            this.button_rand.UseVisualStyleBackColor = true;
            this.button_rand.Click += new System.EventHandler(this.button_rand_Click);
            // 
            // button_text
            // 
            this.button_text.Enabled = false;
            this.button_text.Location = new System.Drawing.Point(272, 20);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(78, 23);
            this.button_text.TabIndex = 8;
            this.button_text.Text = "隐藏文本";
            this.button_text.UseVisualStyleBackColor = true;
            this.button_text.Click += new System.EventHandler(this.button_text_Click);
            // 
            // button_shuffle
            // 
            this.button_shuffle.Enabled = false;
            this.button_shuffle.Location = new System.Drawing.Point(363, 20);
            this.button_shuffle.Name = "button_shuffle";
            this.button_shuffle.Size = new System.Drawing.Size(78, 23);
            this.button_shuffle.TabIndex = 8;
            this.button_shuffle.Text = "打乱图片";
            this.button_shuffle.UseVisualStyleBackColor = true;
            this.button_shuffle.Click += new System.EventHandler(this.button_shuffle_Click);
            // 
            // button_launch_fs
            // 
            this.button_launch_fs.Enabled = false;
            this.button_launch_fs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_launch_fs.Location = new System.Drawing.Point(25, 20);
            this.button_launch_fs.Name = "button_launch_fs";
            this.button_launch_fs.Size = new System.Drawing.Size(67, 23);
            this.button_launch_fs.TabIndex = 2;
            this.button_launch_fs.Text = "启动全屏";
            this.button_launch_fs.UseVisualStyleBackColor = true;
            this.button_launch_fs.Click += new System.EventHandler(this.button_launch_fs_Click);
            // 
            // button_adjust
            // 
            this.button_adjust.Enabled = false;
            this.button_adjust.Location = new System.Drawing.Point(191, 20);
            this.button_adjust.Name = "button_adjust";
            this.button_adjust.Size = new System.Drawing.Size(75, 23);
            this.button_adjust.TabIndex = 1;
            this.button_adjust.Text = "调整大屏";
            this.button_adjust.UseVisualStyleBackColor = true;
            this.button_adjust.Click += new System.EventHandler(this.button_adjust_Click);
            // 
            // tabPage_cast_screen
            // 
            this.tabPage_cast_screen.Location = new System.Drawing.Point(4, 22);
            this.tabPage_cast_screen.Name = "tabPage_cast_screen";
            this.tabPage_cast_screen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_cast_screen.Size = new System.Drawing.Size(549, 412);
            this.tabPage_cast_screen.TabIndex = 1;
            this.tabPage_cast_screen.Text = "嘉宾屏幕设置";
            this.tabPage_cast_screen.UseVisualStyleBackColor = true;
            // 
            // tabPage_player_screen
            // 
            this.tabPage_player_screen.Location = new System.Drawing.Point(4, 22);
            this.tabPage_player_screen.Name = "tabPage_player_screen";
            this.tabPage_player_screen.Size = new System.Drawing.Size(549, 412);
            this.tabPage_player_screen.TabIndex = 2;
            this.tabPage_player_screen.Text = "选手屏幕设置";
            this.tabPage_player_screen.UseVisualStyleBackColor = true;
            // 
            // ConsoleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 462);
            this.Controls.Add(this.tabControl_setting);
            this.Name = "ConsoleScreen";
            this.Text = "控制台";
            this.tabControl_setting.ResumeLayout(false);
            this.tabPage_big_screen.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_launch_ps;
        private System.Windows.Forms.TabControl tabControl_setting;
        private System.Windows.Forms.TabPage tabPage_big_screen;
        private System.Windows.Forms.TabPage tabPage_cast_screen;
        private System.Windows.Forms.Button button_pre;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label BigScreenPageInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PicNumTextBox;
        private System.Windows.Forms.TextBox PageNumTextBox;
        private System.Windows.Forms.Button button_choose;
        private System.Windows.Forms.TabPage tabPage_player_screen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_shuffle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_adjust;
        private System.Windows.Forms.Button button_launch_fs;
        private System.Windows.Forms.TextBox textBox_ps_page;
        private System.Windows.Forms.TextBox textBox_ps_col;
        private System.Windows.Forms.TextBox textBox_ps_row;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_fx_img_num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_fs_col;
        private System.Windows.Forms.TextBox textBox_fs_row;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.Button button_rand;
        private System.Windows.Forms.Button button_text;
    }
}

