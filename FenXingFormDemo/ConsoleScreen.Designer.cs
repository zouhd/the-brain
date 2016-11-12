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
            this.tabControl_setting = new System.Windows.Forms.TabControl();
            this.tabPage_topic = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox_y = new System.Windows.Forms.TextBox();
            this.textBox_x = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage_big_screen = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_set = new System.Windows.Forms.Button();
            this.textBox_fs_col = new System.Windows.Forms.TextBox();
            this.textBox_fs_row = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_fx_img_num = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_choose = new System.Windows.Forms.Button();
            this.PicNumTextBox = new System.Windows.Forms.TextBox();
            this.button_text = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button_launch_fs = new System.Windows.Forms.Button();
            this.tabPage_cast_screen = new System.Windows.Forms.TabPage();
            this.tabPage_player_screen = new System.Windows.Forms.TabPage();
            this.tabControl_setting.SuspendLayout();
            this.tabPage_topic.SuspendLayout();
            this.tabPage_big_screen.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_setting
            // 
            this.tabControl_setting.Controls.Add(this.tabPage_topic);
            this.tabControl_setting.Controls.Add(this.tabPage_big_screen);
            this.tabControl_setting.Controls.Add(this.tabPage_cast_screen);
            this.tabControl_setting.Controls.Add(this.tabPage_player_screen);
            this.tabControl_setting.Location = new System.Drawing.Point(12, 12);
            this.tabControl_setting.Name = "tabControl_setting";
            this.tabControl_setting.SelectedIndex = 0;
            this.tabControl_setting.Size = new System.Drawing.Size(646, 438);
            this.tabControl_setting.TabIndex = 2;
            // 
            // tabPage_topic
            // 
            this.tabPage_topic.Controls.Add(this.button4);
            this.tabPage_topic.Controls.Add(this.button3);
            this.tabPage_topic.Controls.Add(this.label10);
            this.tabPage_topic.Controls.Add(this.label9);
            this.tabPage_topic.Controls.Add(this.button2);
            this.tabPage_topic.Controls.Add(this.textBox_y);
            this.tabPage_topic.Controls.Add(this.textBox_x);
            this.tabPage_topic.Controls.Add(this.button1);
            this.tabPage_topic.Location = new System.Drawing.Point(4, 22);
            this.tabPage_topic.Name = "tabPage_topic";
            this.tabPage_topic.Size = new System.Drawing.Size(638, 412);
            this.tabPage_topic.TabIndex = 3;
            this.tabPage_topic.Text = "选题大屏设置";
            this.tabPage_topic.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(44, 177);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(460, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "4.恢复原状";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(44, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(460, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "3.播放视频";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = "纵轴";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "横轴";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(382, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "2.选择题目";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_y
            // 
            this.textBox_y.Location = new System.Drawing.Point(243, 68);
            this.textBox_y.Name = "textBox_y";
            this.textBox_y.Size = new System.Drawing.Size(58, 21);
            this.textBox_y.TabIndex = 2;
            // 
            // textBox_x
            // 
            this.textBox_x.Location = new System.Drawing.Point(77, 68);
            this.textBox_x.Name = "textBox_x";
            this.textBox_x.Size = new System.Drawing.Size(55, 21);
            this.textBox_x.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(460, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1.显示选题大屏";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage_big_screen
            // 
            this.tabPage_big_screen.Controls.Add(this.groupBox3);
            this.tabPage_big_screen.Controls.Add(this.groupBox1);
            this.tabPage_big_screen.Location = new System.Drawing.Point(4, 22);
            this.tabPage_big_screen.Name = "tabPage_big_screen";
            this.tabPage_big_screen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_big_screen.Size = new System.Drawing.Size(638, 412);
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
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_fx_img_num);
            this.groupBox3.Location = new System.Drawing.Point(45, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 169);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "大屏显示设置";
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(414, 140);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(122, 23);
            this.button_set.TabIndex = 13;
            this.button_set.Text = "设置";
            this.button_set.UseVisualStyleBackColor = true;
            this.button_set.Click += new System.EventHandler(this.button_set_Click);
            // 
            // textBox_fs_col
            // 
            this.textBox_fs_col.Location = new System.Drawing.Point(366, 28);
            this.textBox_fs_col.Name = "textBox_fs_col";
            this.textBox_fs_col.Size = new System.Drawing.Size(40, 21);
            this.textBox_fs_col.TabIndex = 12;
            this.textBox_fs_col.Text = "5";
            // 
            // textBox_fs_row
            // 
            this.textBox_fs_row.Location = new System.Drawing.Point(251, 28);
            this.textBox_fs_row.Name = "textBox_fs_row";
            this.textBox_fs_row.Size = new System.Drawing.Size(40, 21);
            this.textBox_fs_row.TabIndex = 11;
            this.textBox_fs_row.Text = "5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "全屏列数";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "全屏行数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 10;
            this.label8.Text = "分形图数量";
            // 
            // textBox_fx_img_num
            // 
            this.textBox_fx_img_num.Location = new System.Drawing.Point(118, 28);
            this.textBox_fx_img_num.Name = "textBox_fx_img_num";
            this.textBox_fx_img_num.Size = new System.Drawing.Size(40, 21);
            this.textBox_fx_img_num.TabIndex = 12;
            this.textBox_fx_img_num.Text = "25";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_choose);
            this.groupBox1.Controls.Add(this.PicNumTextBox);
            this.groupBox1.Controls.Add(this.button_text);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button_launch_fs);
            this.groupBox1.Location = new System.Drawing.Point(45, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "全屏操作";
            // 
            // button_choose
            // 
            this.button_choose.Enabled = false;
            this.button_choose.Location = new System.Drawing.Point(206, 59);
            this.button_choose.Name = "button_choose";
            this.button_choose.Size = new System.Drawing.Size(330, 21);
            this.button_choose.TabIndex = 7;
            this.button_choose.Text = "6.确认选择图片";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button_choose_Click);
            // 
            // PicNumTextBox
            // 
            this.PicNumTextBox.Location = new System.Drawing.Point(103, 59);
            this.PicNumTextBox.Name = "PicNumTextBox";
            this.PicNumTextBox.Size = new System.Drawing.Size(75, 21);
            this.PicNumTextBox.TabIndex = 6;
            // 
            // button_text
            // 
            this.button_text.Enabled = false;
            this.button_text.Location = new System.Drawing.Point(25, 86);
            this.button_text.Name = "button_text";
            this.button_text.Size = new System.Drawing.Size(511, 23);
            this.button_text.TabIndex = 8;
            this.button_text.Text = "7.显示参数";
            this.button_text.UseVisualStyleBackColor = true;
            this.button_text.Click += new System.EventHandler(this.button_text_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "图片编号";
            // 
            // button_launch_fs
            // 
            this.button_launch_fs.Enabled = false;
            this.button_launch_fs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_launch_fs.Location = new System.Drawing.Point(25, 30);
            this.button_launch_fs.Name = "button_launch_fs";
            this.button_launch_fs.Size = new System.Drawing.Size(511, 23);
            this.button_launch_fs.TabIndex = 2;
            this.button_launch_fs.Text = "5.启动全屏";
            this.button_launch_fs.UseVisualStyleBackColor = true;
            this.button_launch_fs.Click += new System.EventHandler(this.button_launch_fs_Click);
            // 
            // tabPage_cast_screen
            // 
            this.tabPage_cast_screen.Location = new System.Drawing.Point(4, 22);
            this.tabPage_cast_screen.Name = "tabPage_cast_screen";
            this.tabPage_cast_screen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_cast_screen.Size = new System.Drawing.Size(638, 412);
            this.tabPage_cast_screen.TabIndex = 1;
            this.tabPage_cast_screen.Text = "嘉宾屏幕设置";
            this.tabPage_cast_screen.UseVisualStyleBackColor = true;
            // 
            // tabPage_player_screen
            // 
            this.tabPage_player_screen.Location = new System.Drawing.Point(4, 22);
            this.tabPage_player_screen.Name = "tabPage_player_screen";
            this.tabPage_player_screen.Size = new System.Drawing.Size(638, 412);
            this.tabPage_player_screen.TabIndex = 2;
            this.tabPage_player_screen.Text = "选手屏幕设置";
            this.tabPage_player_screen.UseVisualStyleBackColor = true;
            // 
            // ConsoleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 413);
            this.Controls.Add(this.tabControl_setting);
            this.Name = "ConsoleScreen";
            this.Text = "控制台";
            this.tabControl_setting.ResumeLayout(false);
            this.tabPage_topic.ResumeLayout(false);
            this.tabPage_topic.PerformLayout();
            this.tabPage_big_screen.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_setting;
        private System.Windows.Forms.TabPage tabPage_big_screen;
        private System.Windows.Forms.TabPage tabPage_cast_screen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PicNumTextBox;
        private System.Windows.Forms.Button button_choose;
        private System.Windows.Forms.TabPage tabPage_player_screen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_launch_fs;
        private System.Windows.Forms.TextBox textBox_fx_img_num;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_fs_col;
        private System.Windows.Forms.TextBox textBox_fs_row;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.TabPage tabPage_topic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox_y;
        private System.Windows.Forms.TextBox textBox_x;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_text;
    }
}

