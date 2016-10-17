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
            m_big_screen = new BigScreen(1, 3);
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


    }
}
