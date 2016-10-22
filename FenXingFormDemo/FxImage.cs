using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FenXingFormDemo
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
        private Boolean m_first_flag;//第一张图片标记
        private Boolean m_last_flag;//最后一张图片标记
        public FxImage(String image_name, int seq_num, int fx_x, int fx_y)
        {
 
            m_image_name = image_name;
            m_seq_num = seq_num;
            m_fx_x = fx_x;
            m_fx_y = fx_y;

            m_show_flag = true;//默认显示
            //m_study_flag = false;//默认没被选手选中学习

            m_study_flag = false;//默认没被选手选中学习

            m_first_flag = false;
            m_last_flag = false;
        }

        public String IMAGE_NAME
        {
            get { return m_image_name; }
            set { m_image_name = value; }
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

        public Boolean STUDY_FLAG
        {
            get { return m_study_flag; }
            set { m_study_flag = value; }
        }

        public Boolean FIRST_FLAG
        {
            get { return m_first_flag; }
            set { m_first_flag = value; }
        }
        public Boolean LAST_FLAG
        {
            get { return m_last_flag; }
            set { m_last_flag = value; }
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

        public static int Compare(FxImage left, FxImage right)
        {
            int ret = 0;
            if (left.SEQ_NUM == right.SEQ_NUM)
            {
                ret = 0;
            }
            else if (left.SEQ_NUM < right.SEQ_NUM)
            {
                ret = -1;
            }
            else
            {
                ret = 1;
            }

            return ret;
        }

    }
}
