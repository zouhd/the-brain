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
    public partial class BigScreen : Form
    {
        private int m_page_num;//当前显示第几页
        private int m_pages;//总共几页
        private String m_pic_dir;//存放图片的路径，图片base路径/题目编号
        private String m_fx_id;//分形题目编号
        private int m_fx_img_num;//分形图片数量
        private FxImageList m_img_list;//图片模型列表

        private List<PictureBox> m_pic_list;//大屏显示屏中的图片框列表，设计成4*5
        private List<Label> m_label_fx_param_list;//大屏中展现参数的空间列表，设计成4*5
        private List<Label> m_label_fx_seq_list;
        private int m_pic_row;//大屏图片控件行数
        private int m_pic_col;//大屏图片空间列数


        /***
         * 
         * Todo:根据实际情况调整参数
         **/
        public BigScreen(int page_num = 1, int pages = 3, int pic_row = 1, int pic_col =5, String pic_dir = "..\\..\\pic\\",  String fx_id = "A1", int fx_img_num = 15)
        {
            InitializeComponent();
            m_page_num = page_num;//默认第一页
            m_pages = pages;
            m_pic_dir = pic_dir;//设置存放图片的路径
            m_fx_id = fx_id;//分形题目编号，A1,A2...
            m_fx_img_num = fx_img_num;
            m_img_list = new FxImageList(m_pic_dir, m_fx_id, m_fx_img_num);
            InitFxImageList();

            m_pic_row = pic_row;
            m_pic_col = pic_col;
            m_pic_list = new List<PictureBox>(m_pic_row * m_pic_col);
            m_label_fx_param_list = new List<Label>(m_pic_row * m_pic_col);
            m_label_fx_seq_list = new List<Label>(m_pic_row * m_pic_col);

            //Todo: 后面改成4*5的
            m_pic_list.Add(pictureBox1);
            m_pic_list.Add(pictureBox2);
            m_pic_list.Add(pictureBox3);
            m_pic_list.Add(pictureBox4);
            m_pic_list.Add(pictureBox5);
            
            //Todo: 后面改成4*5的
            m_label_fx_param_list.Add(label_param1);
            m_label_fx_param_list.Add(label_param2);
            m_label_fx_param_list.Add(label_param3);
            m_label_fx_param_list.Add(label_param4);
            m_label_fx_param_list.Add(label_param5);

            //Todo: 后面改成4*5的
            m_label_fx_seq_list.Add(label_fx1);
            m_label_fx_seq_list.Add(label_fx2);
            m_label_fx_seq_list.Add(label_fx3);
            m_label_fx_seq_list.Add(label_fx4);
            m_label_fx_seq_list.Add(label_fx5);

            label_page.Text = m_page_num.ToString();

            if (m_page_num == 1)
                button_pre.Enabled = false;
            label_page.Text = String.Format("第{0}页", m_page_num.ToString());
            LoadFxPicture(m_page_num);
        }

        /**
         * 初始化图片库
         */
        public void InitFxImageList()
        {

            //初始化图片列表，共15张图片 Todo:需要修改
            m_img_list.InitFxImages();
        }


        /**
         * 载入图片，根据页面调整图片，每页20张图片，起始页图片编号001-020，第二页 021-040，依次类推
         * 每页图片编号开始001+ (page_num-1)*20，结尾020 + (page_num-1) * 20
         * */
        public void LoadFxPicture(int page_num)
        {

            int pic_box_num = m_pic_col * m_pic_row;//PictureBox控件数量

            for (int i = 1; i <= pic_box_num; i++)
            {
                FxImage fx_img;
                m_img_list.GetFxImage(out fx_img, i + (page_num - 1) * pic_box_num);

                String pic_name =  fx_img.IMAGE_NAME;
                m_pic_list[i - 1].Load(pic_name);
                m_pic_list[i - 1].Show();

                m_label_fx_param_list[i - 1].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);

                m_label_fx_seq_list[i - 1].Text = fx_img.SEQ_NUM.ToString();

            }

            /*
            String pic1_name = String.Format("{0}{1}{2}", m_pic_dir, page_num.ToString("D3"), ".jpg");

            pictureBox1.Load(m_pic_dir + "001.jpg");
            pictureBox1.Show();

            pictureBox2.Load(m_pic_dir + "002.jpg");
            pictureBox2.Show();

            pictureBox3.Load(m_pic_dir + "003.jpg");
            pictureBox3.Show();


            pictureBox4.Load(m_pic_dir + "004.jpg");
            pictureBox4.Show();

            pictureBox5.Load(m_pic_dir + "005.jpg");
            pictureBox5.Show();
            */

        }


        /**
         * 上一页按钮
         */
        private void button_pre_Click(object sender, EventArgs e)
        {
            m_page_num--;
            if (m_page_num == 1)
            {
                button_pre.Enabled = false;

            }
            else
            {
                button_pre.Enabled = true;
            }

            LoadFxPicture(m_page_num);

            button_next.Enabled = true;
            label_page.Text = String.Format("第{0}页", m_page_num.ToString());
        }

        /**
         * 下一页按钮，默认共10页
         */
        private void button_next_Click(object sender, EventArgs e)
        {
            m_page_num++;
            if (m_page_num == m_pages)
            {
                button_next.Enabled = false;
            }
            else
            {
                button_next.Enabled = true;
            }

            LoadFxPicture(m_page_num);
            button_pre.Enabled = true;
            label_page.Text = String.Format("第{0}页", m_page_num.ToString());
        }



        /***
         * 窗口关闭事件处理，隐藏不关闭
         * */
        private void BigScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        

        /***
         * 选中制定页，制定编码图片
         * Todo: 已选择的图片保持绿底
         */
        private void button_select_Click(object sender, EventArgs e)
        {

            int pic_box_num = m_pic_col * m_pic_row;//PictureBox控件数量

            //Todo: 加上页码和编号判断
            int page_num =  Int32.Parse(textBox_page_num.Text);
            int pic_num = Int32.Parse(textBox_pic_num.Text);

            if (page_num <= m_pages && page_num > 0)
            {
                LoadFxPicture(page_num);

                for (int i = 1; i <= pic_box_num; i++)
                {

                    FxImage img;
                    m_img_list.GetFxImage(out img, pic_num + (page_num - 1) * pic_box_num);
                   
                    if (img.STUDY_FLAG != true)
                    {
                        m_pic_list[i - 1].BackColor = Color.Transparent;
                    }
                }
               
                m_pic_list[pic_num - 1].BackColor = Color.Green;

                //Todo：返回值不是引用
                
                m_img_list.GetFxImage(pic_num + (page_num - 1) * pic_box_num).STUDY_FLAG = true;

            }

        }


    }
}
