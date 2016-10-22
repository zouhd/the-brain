using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

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
        public BigScreen(int page_num, int pages, int pic_row = 1, int pic_col =5, int fx_img_num = 60, String pic_dir = "..\\..\\pic\\",  String fx_id = "A1")
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
            m_pic_list.Add(pictureBox6);
            m_pic_list.Add(pictureBox7);
            m_pic_list.Add(pictureBox8);
            m_pic_list.Add(pictureBox9);
            m_pic_list.Add(pictureBox10);

            m_pic_list.Add(pictureBox11);
            m_pic_list.Add(pictureBox12);
            m_pic_list.Add(pictureBox13);
            m_pic_list.Add(pictureBox14);
            m_pic_list.Add(pictureBox15);
            m_pic_list.Add(pictureBox16);
            m_pic_list.Add(pictureBox17);
            m_pic_list.Add(pictureBox18);
            m_pic_list.Add(pictureBox19);
            m_pic_list.Add(pictureBox20);
            
            //Todo: 后面改成4*5的
            m_label_fx_param_list.Add(label_param1);
            m_label_fx_param_list.Add(label_param2);
            m_label_fx_param_list.Add(label_param3);
            m_label_fx_param_list.Add(label_param4);
            m_label_fx_param_list.Add(label_param5);
            m_label_fx_param_list.Add(label_param6);
            m_label_fx_param_list.Add(label_param7);
            m_label_fx_param_list.Add(label_param8);
            m_label_fx_param_list.Add(label_param9);
            m_label_fx_param_list.Add(label_param10);

            m_label_fx_param_list.Add(label_param11);
            m_label_fx_param_list.Add(label_param12);
            m_label_fx_param_list.Add(label_param13);
            m_label_fx_param_list.Add(label_param14);
            m_label_fx_param_list.Add(label_param15);
            m_label_fx_param_list.Add(label_param16);
            m_label_fx_param_list.Add(label_param17);
            m_label_fx_param_list.Add(label_param18);
            m_label_fx_param_list.Add(label_param19);
            m_label_fx_param_list.Add(label_param20);

            //Todo: 后面改成4*5的
            m_label_fx_seq_list.Add(label_fx1);
            m_label_fx_seq_list.Add(label_fx2);
            m_label_fx_seq_list.Add(label_fx3);
            m_label_fx_seq_list.Add(label_fx4);
            m_label_fx_seq_list.Add(label_fx5);
            m_label_fx_seq_list.Add(label_fx6);
            m_label_fx_seq_list.Add(label_fx7);
            m_label_fx_seq_list.Add(label_fx8);
            m_label_fx_seq_list.Add(label_fx9);
            m_label_fx_seq_list.Add(label_fx10);

            m_label_fx_seq_list.Add(label_fx11);
            m_label_fx_seq_list.Add(label_fx12);
            m_label_fx_seq_list.Add(label_fx13);
            m_label_fx_seq_list.Add(label_fx14);
            m_label_fx_seq_list.Add(label_fx15);
            m_label_fx_seq_list.Add(label_fx16);
            m_label_fx_seq_list.Add(label_fx17);
            m_label_fx_seq_list.Add(label_fx18);
            m_label_fx_seq_list.Add(label_fx19);
            m_label_fx_seq_list.Add(label_fx20);

            LoadFxPicture(m_page_num);
        }

        public int GetCurrentPageIndex()
        {
            return m_page_num;
        }

        /**
         * 初始化图片库，读入fx图片信息
         */
        public void InitFxImageList()
        {

            //初始化图片列表，共20张图片 Todo:需要修改
            m_img_list.InitFxImages();
        }

        /// <summary>
        /// 重置fx图片列表，不重新读入fx图片信息，只调整列表顺序
        /// </summary>
        public void ResetFxImageList()
        {

            //初始化图片列表，共20张图片 Todo:需要修改
            m_img_list.ResetFxImages();
        }

        /// <summary>
        /// 初始化图片控件位置
        /// </summary>
        public void InitPictureBox()
        {
            int width_gap = 10;
            int height_gap = 40;

            int init_pic_left = m_pic_list[0].Left;
            int init_pic_top = m_pic_list[0].Top;
            int pic_height = m_pic_list[0].Height;
            int pic_width = m_pic_list[0].Width;

            int init_label_param_left = m_label_fx_param_list[0].Left;
            int init_label_param_top = m_label_fx_param_list[0].Top;

            int init_label_seq_left = m_label_fx_seq_list[0].Left;
            int init_label_seq_top = m_label_fx_seq_list[0].Top;

            //设置图片控件的位置
            for (int i = 0; i < m_pic_row; i++)
            {
                for (int j = 0; j < m_pic_col; j++)
                {
                    //设置图片空间的起始位置
                    m_pic_list[j + i * m_pic_col].Left = init_pic_left + j *  width_gap + j * pic_width;
                    m_pic_list[j + i * m_pic_col].Top = init_pic_top + i * height_gap + i * pic_height;
                    m_pic_list[j + i * m_pic_col].BackColor = Color.Transparent;

                    //设置fx文本控件起始位置
                    m_label_fx_param_list[j + i * m_pic_col].Left = init_label_param_left + j * width_gap + j * pic_width;
                    //m_label_fx_param_list[j + i * m_pic_col].Left = m_pic_list[j + i * m_pic_col].Left +  (pic_width - m_label_fx_param_list[j + i * m_pic_col].Width) / 2;
                    m_label_fx_param_list[j + i * m_pic_col].Top = init_label_param_top + i * height_gap + i * pic_height;

                    //设置seq文本控件起始位置
                    m_label_fx_seq_list[j + i * m_pic_col].Left = init_label_seq_left + j * width_gap + j * pic_width;
                    //m_label_fx_seq_list[j + i * m_pic_col].Left = m_pic_list[j + i * m_pic_col].Left + (pic_width - m_label_fx_seq_list[j + i * m_pic_col].Width) / 2;
                    m_label_fx_seq_list[j + i * m_pic_col].Top = init_label_seq_top + i * height_gap + i * pic_height;
                }
            }
        }

        /**
         * 载入图片，根据页面调整图片，每页20张图片，起始页图片编号001-020，第二页 021-040，依次类推
         * 每页图片编号开始001+ (page_num-1)*20，结尾020 + (page_num-1) * 20
         * */
        public void LoadFxPicture(int page_num)
        {
            int pic_box_num = m_pic_col * m_pic_row;//PictureBox控件数量

            /*
            //初始化所有图片框背景色
            for (int i = 1; i <= pic_box_num; i++)
            {
                m_pic_list[i - 1].BackColor = Color.Transparent;
            }
            */
            InitPictureBox();

            //初始化图片框内容
            for (int i = 1; i <= pic_box_num; i++)
            {
                FxImage fx_img = m_img_list.GetFxImage(i + (page_num - 1) * pic_box_num);

                String pic_name =  fx_img.IMAGE_NAME;
                m_pic_list[i - 1].Load(pic_name);
                m_pic_list[i - 1].Show();

                //选手学过的图片高亮显示
                if (fx_img.STUDY_FLAG == true)
                {
                    m_pic_list[i - 1].BackColor = Color.Green;
                    m_pic_list[i - 1].BringToFront();
                    m_label_fx_param_list[i - 1].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);
                    m_label_fx_param_list[i - 1].BringToFront();
                }
                else
                {
                    m_pic_list[i - 1].BackColor = Color.Transparent;
                    m_label_fx_param_list[i - 1].Text = "";
                }
                
                m_label_fx_seq_list[i - 1].Text = fx_img.SEQ_NUM.ToString();
                

            }


        }

        /// <summary>
        /// 打乱图片顺序
        /// </summary>
        public void ShuffleFxPicture()
        {
            m_img_list.ShuffleFxImages();

            LoadFxPicture(m_page_num);
        }
        /**
         * 上一页按钮
         */
        public void button_pre_Click()
        {
            m_page_num--;
            LoadFxPicture(m_page_num);
        }

        /**
         * 下一页按钮，默认共10页
         */
        public void button_next_Click()
        {
            m_page_num++;
            LoadFxPicture(m_page_num);
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
        public void button_select_Click(int page_num, int pic_num)
        {
            int pic_box_num = m_pic_col * m_pic_row;//PictureBox控件数量

            //Todo: 加上页码和编号判断
            
            //加载选手选择的页面
            if (page_num <= m_pages && page_num > 0)
            {
                //选手选择学习图片
                bool flag = m_img_list.ChooseImage(pic_num + (page_num - 1) * pic_box_num);

                //载入分形图片
                this.Refresh();
                LoadFxPicture(page_num);

                this.Refresh();

                if (flag)
                {
                    //Todo:改成定时器方式，逐步移动到原来位置
                    Thread.Sleep(500);

                    //m_pic_list[pic_num - 1].Width = origin_width * 2;
                    //m_pic_list[pic_num - 1].Height = origin_height * 2;

                    int origin_width = m_pic_list[pic_num - 1].Width;
                    int origin_height = m_pic_list[pic_num - 1].Height;

                    int panel_width = panel1.Width;
                    int panel_height = panel1.Height;

                    m_pic_list[pic_num - 1].Left = (panel_width - origin_width) / 2;
                    m_pic_list[pic_num - 1].Top = (panel_height - origin_height) / 2;
                   
                    m_pic_list[pic_num - 1].BackColor = Color.Green;

                    m_pic_list[pic_num - 1].BringToFront();//放置在顶层

                    m_label_fx_param_list[pic_num - 1].Left = (panel_width - origin_width) / 2 + 20;
                    m_label_fx_param_list[pic_num - 1].Top = (panel_height + origin_height) / 2 - 30;
                    //m_label_fx_param_list[pic_num - 1].Parent = m_pic_list[pic_num - 1];
                    m_label_fx_param_list[pic_num - 1].BackColor = Color.Transparent;
                    m_label_fx_param_list[pic_num - 1].BringToFront();

                    m_label_fx_seq_list[pic_num - 1].Left = panel_width / 2 - 10;
                    m_label_fx_seq_list[pic_num - 1].Top = (panel_height + origin_height) / 2;
                    m_label_fx_seq_list[pic_num - 1].BringToFront();

                    //this.Refresh();
                }


            }

        }


    }
}
