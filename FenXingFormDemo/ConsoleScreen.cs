using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FenXingFormDemo
{
    public partial class ConsoleScreen : Form
    {
        private int fx_img_num = 25;//初始化fx图片数量
        private int fs_pic_row = 5;//全屏 行数
        private int fs_pic_col = 5;//全屏 列数
        private static bool show_param = false;//显示参数

        private int study_num = 0;
        private const int study_max_num = 3;

        private int topic_x;
        private int topic_y;

        private BigScreen m_big_screen;//大屏程序
        private TopicScreen m_topic_screen;//选题大屏

        public ConsoleScreen()
        {
            InitializeComponent();

            m_topic_screen = new TopicScreen();
            /*
             * 根据选手的选题，初始化大屏图片 （提供图片basedir以及题号）
             * 图片库的命名规范是
             * basedir/
             * *******--A1 ————001.jpg 002.jpg  003.jpg
             * *******--A2
             * *******--A3
             * *******-B1等
             */
            //m_big_screen = new BigScreen(current_page_num, pages, pic_row, pic_col, const_fx_img);
            //UpdatePageAndButtonEnableStatus();
            //m_big_screen.InitFxImageList();
        }

      
        //Todo:后期改成去除图片按钮
        /// <summary>
        /// 启动全屏，照片平铺
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_launch_fs_Click(object sender, EventArgs e)
        {
            m_big_screen.Left = 0;
            m_big_screen.Top = 0;
            m_big_screen.ClearComponent();
            m_big_screen.InitializeFullScreen(fs_pic_row, fs_pic_col);
            m_big_screen.LoadFullScreenFxPicture();
            m_big_screen.Show();

            this.button_text.Enabled = true;
            this.button_choose.Enabled = true;

        }


        /// <summary>
        /// 选手选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_choose_Click(object sender, EventArgs e)
        {

            int pic_num = 1;

            if (!Int32.TryParse(PicNumTextBox.Text.Trim(), out pic_num))
            {
                MessageBox.Show("请输入正确的图片索引.");
                return;
            }

            //Todo:考虑重复选择图片
            study_num = m_big_screen.StudyFxImage(pic_num);
            if (study_num >= study_max_num)
                button_choose.Enabled = false;
        }

       
        /// <summary>
        /// 大屏显示设置参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_set_Click(object sender, EventArgs e)
        {

            if (!Int32.TryParse(this.textBox_fx_img_num.Text.Trim(), out fx_img_num))
            {
                MessageBox.Show("请输入正确的图片数量.");
                return;
            }

            

            if (!Int32.TryParse(this.textBox_fs_row.Text.Trim(), out fs_pic_row))
            {
                MessageBox.Show("请输入正确的全屏行值.");
                return;
            }
            if (!Int32.TryParse(this.textBox_fs_col.Text.Trim(), out fs_pic_col))
            {
                MessageBox.Show("请输入正确的全屏列值.");
                return;
            }


            //Todo: 设置图片的根目录
            m_big_screen = new BigScreen(fs_pic_row, fs_pic_col, fx_img_num);

            this.button_launch_fs.Enabled = true;
           
            //Todo:可以改成true,这样用户可以随意设置大屏大小
            this.button_set.Enabled = false;

        }


        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_text_Click(object sender, EventArgs e)
        {

            show_param = !show_param;
            if (show_param)
            {
                button_text.Text = "隐藏文本";
            }
            else
            {
                button_text.Text = "显示文本";
            }


            m_big_screen.ShowParam(show_param);
        }

        /// <summary>
        /// 显示大屏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            m_topic_screen.InitScreen();
            m_topic_screen.Show();
        }

        /// <summary>
        /// 选择题目
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if (!Int32.TryParse(this.textBox_x.Text.Trim(), out topic_x))
            {
                MessageBox.Show("横轴值.");
                return;
            }

            if (!Int32.TryParse(this.textBox_y.Text.Trim(), out topic_y))
            {
                MessageBox.Show("纵轴值.");
                return;
            }

            m_topic_screen.SelectTopic(topic_x, topic_y);
        }

        /// <summary>
        /// 播放视频
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            m_topic_screen.PlayMov(topic_x, topic_y);
        }

        /// <summary>
        /// 恢复原状
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            m_topic_screen.InitScreen();
        }

    }
}
