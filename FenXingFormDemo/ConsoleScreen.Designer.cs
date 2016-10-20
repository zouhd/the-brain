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
            this.button_launch = new System.Windows.Forms.Button();
            this.tabControl_setting = new System.Windows.Forms.TabControl();
            this.tabPage_big_screen = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_shuffle = new System.Windows.Forms.Button();
            this.button_choose = new System.Windows.Forms.Button();
            this.PicNumTextBox = new System.Windows.Forms.TextBox();
            this.PageNumTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_next = new System.Windows.Forms.Button();
            this.BigScreenPageInfo = new System.Windows.Forms.Label();
            this.button_pre = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_reset = new System.Windows.Forms.Button();
            this.tabPage_cast_screen = new System.Windows.Forms.TabPage();
            this.tabPage_player_screen = new System.Windows.Forms.TabPage();
            this.button_clear = new System.Windows.Forms.Button();
            this.tabControl_setting.SuspendLayout();
            this.tabPage_big_screen.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_launch
            // 
            this.button_launch.Location = new System.Drawing.Point(16, 39);
            this.button_launch.Name = "button_launch";
            this.button_launch.Size = new System.Drawing.Size(132, 23);
            this.button_launch.TabIndex = 0;
            this.button_launch.Text = "启动大屏";
            this.button_launch.UseVisualStyleBackColor = true;
            this.button_launch.Click += new System.EventHandler(this.button_launch_Click);
            // 
            // tabControl_setting
            // 
            this.tabControl_setting.Controls.Add(this.tabPage_big_screen);
            this.tabControl_setting.Controls.Add(this.tabPage_cast_screen);
            this.tabControl_setting.Controls.Add(this.tabPage_player_screen);
            this.tabControl_setting.Location = new System.Drawing.Point(12, 12);
            this.tabControl_setting.Name = "tabControl_setting";
            this.tabControl_setting.SelectedIndex = 0;
            this.tabControl_setting.Size = new System.Drawing.Size(557, 338);
            this.tabControl_setting.TabIndex = 2;
            // 
            // tabPage_big_screen
            // 
            this.tabPage_big_screen.Controls.Add(this.groupBox2);
            this.tabPage_big_screen.Controls.Add(this.groupBox1);
            this.tabPage_big_screen.Location = new System.Drawing.Point(4, 22);
            this.tabPage_big_screen.Name = "tabPage_big_screen";
            this.tabPage_big_screen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_big_screen.Size = new System.Drawing.Size(549, 312);
            this.tabPage_big_screen.TabIndex = 0;
            this.tabPage_big_screen.Text = "大屏设置";
            this.tabPage_big_screen.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_shuffle);
            this.groupBox2.Controls.Add(this.button_choose);
            this.groupBox2.Controls.Add(this.PicNumTextBox);
            this.groupBox2.Controls.Add(this.PageNumTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button_next);
            this.groupBox2.Controls.Add(this.BigScreenPageInfo);
            this.groupBox2.Controls.Add(this.button_pre);
            this.groupBox2.Location = new System.Drawing.Point(43, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 162);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "操作";
            // 
            // button_shuffle
            // 
            this.button_shuffle.Location = new System.Drawing.Point(25, 119);
            this.button_shuffle.Name = "button_shuffle";
            this.button_shuffle.Size = new System.Drawing.Size(406, 23);
            this.button_shuffle.TabIndex = 8;
            this.button_shuffle.Text = "打乱图片";
            this.button_shuffle.UseVisualStyleBackColor = true;
            this.button_shuffle.Click += new System.EventHandler(this.button_shuffle_Click);
            // 
            // button_choose
            // 
            this.button_choose.Location = new System.Drawing.Point(309, 74);
            this.button_choose.Name = "button_choose";
            this.button_choose.Size = new System.Drawing.Size(122, 21);
            this.button_choose.TabIndex = 7;
            this.button_choose.Text = "确认选择图片";
            this.button_choose.UseVisualStyleBackColor = true;
            this.button_choose.Click += new System.EventHandler(this.button_choose_Click);
            // 
            // PicNumTextBox
            // 
            this.PicNumTextBox.Location = new System.Drawing.Point(213, 74);
            this.PicNumTextBox.Name = "PicNumTextBox";
            this.PicNumTextBox.Size = new System.Drawing.Size(75, 21);
            this.PicNumTextBox.TabIndex = 6;
            // 
            // PageNumTextBox
            // 
            this.PageNumTextBox.Location = new System.Drawing.Point(62, 74);
            this.PageNumTextBox.Name = "PageNumTextBox";
            this.PageNumTextBox.Size = new System.Drawing.Size(75, 21);
            this.PageNumTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "图片编号";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "页号";
            // 
            // button_next
            // 
            this.button_next.Location = new System.Drawing.Point(309, 27);
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
            this.BigScreenPageInfo.Location = new System.Drawing.Point(205, 32);
            this.BigScreenPageInfo.Name = "BigScreenPageInfo";
            this.BigScreenPageInfo.Size = new System.Drawing.Size(35, 12);
            this.BigScreenPageInfo.TabIndex = 1;
            this.BigScreenPageInfo.Text = "第1页";
            // 
            // button_pre
            // 
            this.button_pre.Enabled = false;
            this.button_pre.Location = new System.Drawing.Point(18, 27);
            this.button_pre.Name = "button_pre";
            this.button_pre.Size = new System.Drawing.Size(132, 21);
            this.button_pre.TabIndex = 0;
            this.button_pre.Text = "上一页";
            this.button_pre.UseVisualStyleBackColor = true;
            this.button_pre.Click += new System.EventHandler(this.button_pre_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.button_reset);
            this.groupBox1.Controls.Add(this.button_launch);
            this.groupBox1.Location = new System.Drawing.Point(45, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 88);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // button_reset
            // 
            this.button_reset.Location = new System.Drawing.Point(164, 39);
            this.button_reset.Name = "button_reset";
            this.button_reset.Size = new System.Drawing.Size(122, 23);
            this.button_reset.TabIndex = 1;
            this.button_reset.Text = "重置大屏";
            this.button_reset.UseVisualStyleBackColor = true;
            this.button_reset.Click += new System.EventHandler(this.button_reset_Click);
            // 
            // tabPage_cast_screen
            // 
            this.tabPage_cast_screen.Location = new System.Drawing.Point(4, 22);
            this.tabPage_cast_screen.Name = "tabPage_cast_screen";
            this.tabPage_cast_screen.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_cast_screen.Size = new System.Drawing.Size(549, 312);
            this.tabPage_cast_screen.TabIndex = 1;
            this.tabPage_cast_screen.Text = "嘉宾屏幕设置";
            this.tabPage_cast_screen.UseVisualStyleBackColor = true;
            // 
            // tabPage_player_screen
            // 
            this.tabPage_player_screen.Location = new System.Drawing.Point(4, 22);
            this.tabPage_player_screen.Name = "tabPage_player_screen";
            this.tabPage_player_screen.Size = new System.Drawing.Size(549, 312);
            this.tabPage_player_screen.TabIndex = 2;
            this.tabPage_player_screen.Text = "选手屏幕设置";
            this.tabPage_player_screen.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_clear.Location = new System.Drawing.Point(307, 39);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(122, 23);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "清除大屏（慎点！）";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // ConsoleScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.tabControl_setting);
            this.Name = "ConsoleScreen";
            this.Text = "控制台";
            this.tabControl_setting.ResumeLayout(false);
            this.tabPage_big_screen.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_launch;
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
        private System.Windows.Forms.Button button_reset;
        private System.Windows.Forms.Button button_clear;
    }
}

