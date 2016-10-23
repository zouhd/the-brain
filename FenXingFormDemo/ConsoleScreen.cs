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
        private int current_page_num = 1;//起始页
        private int ps_pages = 10;//分屏页数
        private int ps_pic_row = 4;//分页屏行数
        private int ps_pic_col = 5;//分页屏列数
        private int fx_img_num = 200;//初始化fx图片数量
        private int fs_pic_row = 10;//全屏 行数
        private int fs_pic_col = 20;//全屏 列数
        private static bool show_text = true;//显示

        private const int const_remove = 5;//随机删除图片数量

        private int study_num = 0;
        private const int study_max_num = 3;

        private BigScreen m_big_screen;//大屏程序

        public ConsoleScreen()
        {
            InitializeComponent();

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

        /// <summary>
        /// 启动分页大屏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_launch_ps_Click(object sender, EventArgs e)
        {

            UpdatePageAndButtonEnableStatus();

            m_big_screen.StartPosition = FormStartPosition.CenterScreen;
            m_big_screen.ClearComponent();
            m_big_screen.InitializePagesScreen(ps_pic_row, ps_pic_col);
            m_big_screen.LoadPageScreenFxPicture(1);
            m_big_screen.Show();

            this.button_choose.Enabled = true;
        }

        //Todo:后期改成去除图片按钮
        /// <summary>
        /// 启动全屏，照片平铺
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_launch_fs_Click(object sender, EventArgs e)
        {
            m_big_screen.StartPosition = FormStartPosition.CenterScreen;
            m_big_screen.ClearComponent();
            m_big_screen.InitializeFullScreen(fs_pic_row, fs_pic_col);
            m_big_screen.LoadFullScreenFxPicture(fs_pic_row * fs_pic_col);
            m_big_screen.Show();

            this.button_shuffle.Enabled = true;
            this.button_adjust.Enabled = true;
            this.button_text.Enabled = true;
            this.button_rand.Enabled = true;

        }

        /// <summary>
        /// 重置大屏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_adjust_Click(object sender, EventArgs e)
        {
            //m_big_screen.ResetFxImageList();
            //m_big_screen.LoadPageScreenFxPicture(fx_img_num);
            m_big_screen.AdjustFullScreenFxPicture(fx_img_num - const_remove - study_num - 2);

            show_text = false;
            button_text.Text = "显示文本";

            
        }

        /// <summary>
        /// 前一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_pre_Click(object sender, EventArgs e)
        {
            m_big_screen.button_pre_Click();
            UpdatePageAndButtonEnableStatus();
        }

        /// <summary>
        /// 后一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_next_Click(object sender, EventArgs e)
        {
            
            m_big_screen.button_next_Click();
            UpdatePageAndButtonEnableStatus();
        }

        /// <summary>
        /// 更新前一页、后一页按钮
        /// </summary>
        private void UpdatePageAndButtonEnableStatus()
        {
            int currentPage = m_big_screen.GetCurrentPageIndex();
            BigScreenPageInfo.Text = "第" + currentPage + "页";

            if(currentPage <= 1)
            {
                button_pre.Enabled = false;
            }
            else
            {
                button_pre.Enabled = true;
            }

            if (currentPage >= ps_pages)
            {
                button_next.Enabled = false;
            }
            else
            {
                button_next.Enabled = true;
            }
        }

        /// <summary>
        /// 选手选择图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_choose_Click(object sender, EventArgs e)
        {
            
            int page_num = 1;
            int pic_num = 1;
            if(!Int32.TryParse(PageNumTextBox.Text.Trim(), out page_num))
            {
                MessageBox.Show("请输入正确的页码值.");
                return;
            }
            if (!Int32.TryParse(PicNumTextBox.Text.Trim(), out pic_num))
            {
                MessageBox.Show("请输入正确的图片索引.");
                return;
            }

            study_num++;
            if (study_num >= study_max_num)
                button_choose.Enabled = false;
            
            m_big_screen.button_select_Click(page_num, pic_num);
        }

        

        /// <summary>
        /// 打乱图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_shuffle_Click(object sender, EventArgs e)
        {
            m_big_screen.ShuffleFxPicture();

            show_text = false;
            button_text.Text = "显示文本";
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

            if (!Int32.TryParse(this.textBox_ps_row.Text.Trim(), out ps_pic_row))
            {
                MessageBox.Show("请输入正确的分页屏行数.");
                return;
            }
            if (!Int32.TryParse(this.textBox_ps_col.Text.Trim(), out ps_pic_col))
            {
                MessageBox.Show("请输入正确的分页屏列值.");
                return;
            }
            if (!Int32.TryParse(this.textBox_ps_page.Text.Trim(), out ps_pages))
            {
                MessageBox.Show("请输入正确的分页屏页数.");
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

            m_big_screen = new BigScreen(ps_pages, ps_pic_row, ps_pic_col, fs_pic_row, fs_pic_col, fx_img_num);

            this.button_launch_ps.Enabled = true;
            this.button_launch_fs.Enabled = true;
           
            /*
            this.button_shuffle.Enabled = true;
            this.button_adjust.Enabled = true;
            this.button_choose.Enabled = true;
            this.button_text.Enabled = true;
            this.button_rand.Enabled = true;
            */
            //Todo:可以改成true,这样用户可以随意设置大屏大小
            this.button_set.Enabled = false;

        }

        /// <summary>
        /// 随机删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_rand_Click(object sender, EventArgs e)
        {
            //Todo:随机删除指定数量的图片
            m_big_screen.RandomRemove(const_remove);
        }

        /// <summary>
        /// 显示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_text_Click(object sender, EventArgs e)
        {

            show_text = !show_text;
            if (show_text)
            {
                button_text.Text = "隐藏文本";
            }
            else
            {
                button_text.Text = "显示文本";
            }

            
            m_big_screen.ShowText(show_text);
        }

        



        
    }
}
