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
        private int pages = 10;//分屏页数
        private int pic_row = 4;
        private int pic_col = 5;
        private int fx_img_num = 200;//初始化fx图片数量

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
        private void button_launch_Click(object sender, EventArgs e)
        {

            if (!Int32.TryParse(this.textBox_ps_page.Text.Trim(), out pages))
            {
                MessageBox.Show("请输入正确的页数.");
                return;
            }
            if (!Int32.TryParse(this.textBox_ps_row.Text.Trim(), out pic_row))
            {
                MessageBox.Show("请输入正确的行值.");
                return;
            }
            if (!Int32.TryParse(this.textBox_ps_col.Text.Trim(), out pic_col))
            {
                MessageBox.Show("请输入正确的列值.");
                return;
            }

            if (!Int32.TryParse(this.textBox_fx_img_num.Text.Trim(), out fx_img_num))
            {
                MessageBox.Show("请输入正确的图片数量.");
                return;
            }

            //m_big_screen.PIC_ROW = 
            m_big_screen = new BigScreen(current_page_num, pages, pic_row, pic_col, fx_img_num);
            UpdatePageAndButtonEnableStatus();

            m_big_screen.StartPosition = FormStartPosition.CenterScreen;
            m_big_screen.ClearComponent();

            m_big_screen.InitializePagesScreen(pic_row, pic_col);
            m_big_screen.LoadPageScreenFxPicture(1);
            m_big_screen.Show();
        }

        /// <summary>
        /// 重置大屏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_reset_Click(object sender, EventArgs e)
        {
            m_big_screen.ResetFxImageList();
            m_big_screen.LoadPageScreenFxPicture(fx_img_num);
        }


        //Todo:后期改成去除图片按钮
        /// <summary>
        /// 启动全屏，照片平铺
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_launch_fs_Click(object sender, EventArgs e)
        {
            int fs_col = 1;
            int fs_row = 1;

            if (!Int32.TryParse(this.textBox_fs_row.Text.Trim(), out fs_row))
            {
                MessageBox.Show("请输入正确的行值.");
                return;
            }
            if (!Int32.TryParse(this.textBox_fs_col.Text.Trim(), out fs_col))
            {
                MessageBox.Show("请输入正确的列值.");
                return;
            }
            if (!Int32.TryParse(this.textBox_fx_img_num.Text.Trim(), out fx_img_num))
            {
                MessageBox.Show("请输入正确的图片数量.");
                return;
            }

            m_big_screen = new BigScreen(current_page_num, pages, fs_row, fs_col, fx_img_num);
            m_big_screen.StartPosition = FormStartPosition.CenterScreen;
            m_big_screen.ClearComponent();
            m_big_screen.InitializeFullScreen(fs_row, fs_col);
            m_big_screen.LoadFullScreenFxPicture(fs_row * fs_col);
            m_big_screen.Show();
        }


        private void button_pre_Click(object sender, EventArgs e)
        {
            m_big_screen.button_pre_Click();
            UpdatePageAndButtonEnableStatus();
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            
            m_big_screen.button_next_Click();
            UpdatePageAndButtonEnableStatus();
        }

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

            if (currentPage >= pages)
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
        }



        
    }
}
