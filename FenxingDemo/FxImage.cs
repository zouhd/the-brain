using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FenxingDemo
{
    class FxImage
    {
        private String m_image_name;//分形图片名称,A1_001.jpg,A1表示分形题号，001表示分形截图。
        private int m_seq_num;//图片编号
        private int m_fx_x;//分形函数参数x
        private int m_fx_y;//分形函数参数y
        private Boolean m_show_flag;/*显示标记，标记图片是否显示，不显示的图片
       包括开头，结尾，选手选择的3张截图以及电脑随机消除的95张截图*/
        private Boolean m_study_flag;//是否被选手选中学习

        public FxImage(String image_name, int seq_num, int fx_x, int fx_y)
        {
 
            m_image_name = image_name;
            m_seq_num = seq_num;
            m_fx_x = fx_x;
            m_fx_y = fx_y;

            m_show_flag = true;//默认显示
            m_study_flag = false;//默认没被选手选中学习
        }

        public int SEQ_NUM
        {
            get { return m_seq_num; }
            set { m_seq_num = value; }
        }

        public Boolean SHOW_FLAG
        {
            get { return m_show_flag; }
            set { m_show_flag = value; }
        }

        public int FX_X
        {
            get { return m_fx_x; }
            set { m_fx_x = value; }
        }

        public int FX_Y
        {
            get { return m_fx_y; }
            set { m_fx_y = value; }
        }


        /*
         * 显示该图片
         */
        public void ShowImage()
        {

        }


    }
}
