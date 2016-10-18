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
        private const int const_page_num = 1;
        private const int const_pages = 3;
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
            m_big_screen = new BigScreen(const_page_num, const_pages);
            m_big_screen.InitFxImageList();
        }

        /***
         * 
         * 关闭窗口程序
         * 
         * */
        private void button_bigscreen_Click(object sender, EventArgs e)
        {
            m_big_screen.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m_big_screen.button_pre_Click();
            UpdatePageAndButtonEnableStatus();
        }

        private void button2_Click(object sender, EventArgs e)
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
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }

            if (currentPage >= const_pages)
            {
                button2.Enabled = false;
            }
            else
            {
                button2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
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
    }
}
