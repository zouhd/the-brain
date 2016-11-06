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
        private int m_page_num = 1;//当前显示第几页
        private int m_pages;//总共几页
        private int m_pic_row;//分页屏图片控件行数
        private int m_pic_col;//分页屏图片空间列数

        private String m_pic_dir;//存放图片的路径，图片base路径/题目编号
        private String m_fx_id;//分形题目编号
        private int m_fx_img_num;//分形图片数量
        private FxImageList m_img_list;//图片模型列表

        private List<PictureBox> m_ps_pic_list;//大屏显示屏中的图片框列表，设计成4*5
        private List<Label> m_ps_label_param_list;//大屏中展现参数的空间列表，设计成4*5
        private List<Label> m_ps_label_seq_list;

        private List<PictureBox> m_fs_pic_list;//full screen图片
        private List<Label> m_fs_label_param_list;//full screen标签
        private List<Label> m_fs_label_seq_list;//full screen标签

        private int m_fs_pic_row;//全屏图片行数
        private int m_fs_pic_col;//全屏图片列数

        private int m_study_num = 0;//当前学习图片数量
        private int m_study_max_num = 3;//最大学习图片数量

        private int m_study_time = 3;//学习3秒钟
        /// <summary>
        /// 设置大屏的参数
        /// </summary>
        /// <param name="pages"></param>
        /// <param name="ps_pic_row"></param>
        /// <param name="ps_pic_col"></param>
        /// <param name="fs_pic_row"></param>
        /// <param name="fs_pic_col"></param>
        /// <param name="fx_img_num"></param>
        /// <param name="pic_dir"></param>
        /// <param name="fx_id"></param>
        public BigScreen(int pages, int ps_pic_row = 4, int ps_pic_col = 5, int fs_pic_row = 4, int fs_pic_col = 10, int fx_img_num = 40, String pic_dir = "..\\..\\pic\\", String fx_id = "A1")
        {
            InitializeComponent();

           

            m_pages = pages;
            m_pic_row = ps_pic_row;
            m_pic_col = ps_pic_col;

            m_fs_pic_row = fs_pic_row;
            m_fs_pic_col = fs_pic_col;

            m_fx_img_num = fx_img_num;

            m_pic_dir = pic_dir;//设置存放图片的路径
            m_fx_id = fx_id;//分形题目编号，A1,A2...
            

            m_img_list = new FxImageList(m_pic_dir, m_fx_id, m_fx_img_num);
            InitFxImageList();

        }

        
        /***
         * 
         * 初始化分页屏
         **/

        /*
        public BigScreen(int page_num, int pages, int pic_row = 1, int pic_col =5, int fx_img_num = 40, String pic_dir = "..\\..\\pic\\",  String fx_id = "A1")
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

        }
         */
            /*
            m_ps_pic_list = new List<PictureBox>(m_pic_row * m_pic_col);
            m_ps_label_param_list = new List<Label>(m_pic_row * m_pic_col);
            m_ps_label_seq_list = new List<Label>(m_pic_row * m_pic_col);

            m_ps_pic_list.Add(pictureBox1);
            m_ps_pic_list.Add(pictureBox2);
            m_ps_pic_list.Add(pictureBox3);
            m_ps_pic_list.Add(pictureBox4);
            m_ps_pic_list.Add(pictureBox5);
            m_ps_pic_list.Add(pictureBox6);
            m_ps_pic_list.Add(pictureBox7);
            m_ps_pic_list.Add(pictureBox8);
            m_ps_pic_list.Add(pictureBox9);
            m_ps_pic_list.Add(pictureBox10);

            m_ps_pic_list.Add(pictureBox11);
            m_ps_pic_list.Add(pictureBox12);
            m_ps_pic_list.Add(pictureBox13);
            m_ps_pic_list.Add(pictureBox14);
            m_ps_pic_list.Add(pictureBox15);
            m_ps_pic_list.Add(pictureBox16);
            m_ps_pic_list.Add(pictureBox17);
            m_ps_pic_list.Add(pictureBox18);
            m_ps_pic_list.Add(pictureBox19);
            m_ps_pic_list.Add(pictureBox20);
            
            m_ps_label_param_list.Add(label_param1);
            m_ps_label_param_list.Add(label_param2);
            m_ps_label_param_list.Add(label_param3);
            m_ps_label_param_list.Add(label_param4);
            m_ps_label_param_list.Add(label_param5);
            m_ps_label_param_list.Add(label_param6);
            m_ps_label_param_list.Add(label_param7);
            m_ps_label_param_list.Add(label_param8);
            m_ps_label_param_list.Add(label_param9);
            m_ps_label_param_list.Add(label_param10);

            m_ps_label_param_list.Add(label_param11);
            m_ps_label_param_list.Add(label_param12);
            m_ps_label_param_list.Add(label_param13);
            m_ps_label_param_list.Add(label_param14);
            m_ps_label_param_list.Add(label_param15);
            m_ps_label_param_list.Add(label_param16);
            m_ps_label_param_list.Add(label_param17);
            m_ps_label_param_list.Add(label_param18);
            m_ps_label_param_list.Add(label_param19);
            m_ps_label_param_list.Add(label_param20);

            m_ps_label_seq_list.Add(label_fx1);
            m_ps_label_seq_list.Add(label_fx2);
            m_ps_label_seq_list.Add(label_fx3);
            m_ps_label_seq_list.Add(label_fx4);
            m_ps_label_seq_list.Add(label_fx5);
            m_ps_label_seq_list.Add(label_fx6);
            m_ps_label_seq_list.Add(label_fx7);
            m_ps_label_seq_list.Add(label_fx8);
            m_ps_label_seq_list.Add(label_fx9);
            m_ps_label_seq_list.Add(label_fx10);

            m_ps_label_seq_list.Add(label_fx11);
            m_ps_label_seq_list.Add(label_fx12);
            m_ps_label_seq_list.Add(label_fx13);
            m_ps_label_seq_list.Add(label_fx14);
            m_ps_label_seq_list.Add(label_fx15);
            m_ps_label_seq_list.Add(label_fx16);
            m_ps_label_seq_list.Add(label_fx17);
            m_ps_label_seq_list.Add(label_fx18);
            m_ps_label_seq_list.Add(label_fx19);
            m_ps_label_seq_list.Add(label_fx20);
            */



        public int PAGE_NUM
        {
            get { return m_page_num; }
            set { m_page_num = value; }
        }

        public int PAGES
        {
            get { return m_pages; }
            set { m_pages = value; }
        }

        public int PIC_ROW
        {
            get { return m_pic_row; }
            set { m_pic_row = value; }
        }

        public int PIC_COL
        {
            get { return m_pic_col; }
            set { m_pic_col = value; }
        }

        public int FX_IMAGE_NUM
        {
            get { return m_fx_img_num; }
            set { m_fx_img_num = value; }
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
        /// 初始化分页屏图片控件位置
        /// </summary>
        public void InitPageScreenPictureBox()
        {
            int width_gap = 10;
            int height_gap = 40;

            int init_pic_left = m_ps_pic_list[0].Left;
            int init_pic_top = m_ps_pic_list[0].Top;
            int pic_height = m_ps_pic_list[0].Height;
            int pic_width = m_ps_pic_list[0].Width;

            int init_label_param_left = m_ps_label_param_list[0].Left;
            int init_label_param_top = m_ps_label_param_list[0].Top;

            int init_label_seq_left = m_ps_label_seq_list[0].Left;
            int init_label_seq_top = m_ps_label_seq_list[0].Top;

            //设置图片控件的位置
            for (int i = 0; i < m_pic_row; i++)
            {
                for (int j = 0; j < m_pic_col; j++)
                {
                    //设置图片空间的起始位置
                    m_ps_pic_list[j + i * m_pic_col].Left = init_pic_left + j *  width_gap + j * pic_width;
                    m_ps_pic_list[j + i * m_pic_col].Top = init_pic_top + i * height_gap + i * pic_height;
                    m_ps_pic_list[j + i * m_pic_col].BackColor = Color.Transparent;

                    //设置fx文本控件起始位置
                    m_ps_label_param_list[j + i * m_pic_col].Left = init_label_param_left + j * width_gap + j * pic_width;
                    //m_ps_label_param_list[j + i * m_pic_col].Left = m_ps_pic_list[j + i * m_pic_col].Left +  (pic_width - m_ps_label_param_list[j + i * m_pic_col].Width) / 2;
                    m_ps_label_param_list[j + i * m_pic_col].Top = init_label_param_top + i * height_gap + i * pic_height;

                    //设置seq文本控件起始位置
                    m_ps_label_seq_list[j + i * m_pic_col].Left = init_label_seq_left + j * width_gap + j * pic_width;
                    //m_ps_label_seq_list[j + i * m_pic_col].Left = m_ps_pic_list[j + i * m_pic_col].Left + (pic_width - m_ps_label_seq_list[j + i * m_pic_col].Width) / 2;
                    m_ps_label_seq_list[j + i * m_pic_col].Top = init_label_seq_top + i * height_gap + i * pic_height;
                }
            }
        }

        /**
         * 载入图片，根据页面调整图片，每页20张图片，起始页图片编号001-020，第二页 021-040，依次类推
         * 每页图片编号开始001+ (page_num-1)*20，结尾020 + (page_num-1) * 20
         * */
        public void LoadPageScreenFxPicture(int page_num)
        {
            int pic_box_num = m_pic_col * m_pic_row;//PictureBox控件数量

            InitPageScreenPictureBox();

            //初始化图片框内容
            for (int i = 1; i <= pic_box_num; i++)
            {
                FxImage fx_img = m_img_list.GetFxImage(i + (page_num - 1) * pic_box_num);

                String pic_name =  fx_img.IMAGE_NAME;
                m_ps_pic_list[i - 1].Load(pic_name);
                m_ps_pic_list[i - 1].Show();

                m_ps_label_param_list[i - 1].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);
                m_ps_label_seq_list[i - 1].Text = fx_img.SEQ_NUM.ToString();

                //选手学过的图片高亮显示
                if (fx_img.STUDY_FLAG == true)
                {
                    m_ps_pic_list[i - 1].BackColor = Color.Green;
                    m_ps_pic_list[i - 1].BringToFront();

                    m_ps_label_param_list[i - 1].Visible = true;
                    m_ps_label_param_list[i - 1].BringToFront();
                }
                else
                {
                    m_ps_pic_list[i - 1].BackColor = Color.Transparent;
                    m_ps_label_param_list[i - 1].Visible = false;
                }
                

            }


        }


        /// <summary>
        /// 载入全屏图片
        /// </summary>
        /// <param name="pic_num"></param>
        /// /// <param name="check_show_flag">判断是否要检查show_flag标记</param>
        public void LoadFullScreenFxPicture(int pic_num, bool check_show_flag = false)
        {
            FxImage fx_img;
            String pic_name;
            //初始化图片框内容

            if (!check_show_flag)
            {
                for (int i = 1; i <= pic_num; i++)
                {
                    fx_img = m_img_list.GetFxImage(i);


                    pic_name = fx_img.IMAGE_NAME;
                    //m_fs_pic_list[i - 1].Load(pic_name);
                    m_fs_pic_list[i - 1].UseWaitCursor = true;
                    m_fs_pic_list[i - 1].WaitOnLoad = false;
                    m_fs_pic_list[i - 1].LoadCompleted += new AsyncCompletedEventHandler(pictureBox_LoadCompleted);
                    m_fs_pic_list[i - 1].LoadAsync(pic_name);

                    //m_fs_pic_list[i - 1].Show();

                    m_fs_label_param_list[i - 1].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);
                    m_fs_label_seq_list[i - 1].Text = fx_img.SEQ_NUM.ToString();

                    //选手学过的图片高亮显示
                    if (fx_img.STUDY_FLAG == true)
                    {
                        m_fs_pic_list[i - 1].BackColor = Color.Green;
                        m_fs_pic_list[i - 1].SendToBack();
                        m_fs_label_param_list[i - 1].Visible = true;
                        m_fs_label_param_list[i - 1].BackColor = Color.Transparent;
                        m_fs_label_param_list[i - 1].BringToFront();
                    }
                    else
                    {
                        m_fs_pic_list[i - 1].BackColor = Color.Transparent;
                        m_fs_label_param_list[i - 1].Visible = false;
                    }

                    
                }
            }
            else
            {
                
                for (int i = 1; i <= pic_num; i++)
                {
                    fx_img = m_img_list.GetFxImage(i);

                    if (fx_img.SHOW_FLAG)
                    {
                        pic_name = fx_img.IMAGE_NAME;
                        m_fs_pic_list[i - 1].Load(pic_name);
                        m_fs_pic_list[i - 1].BackColor = Color.Transparent;
                        m_fs_pic_list[i - 1].Show();
                        m_fs_label_param_list[i - 1].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);
                        m_fs_label_param_list[i - 1].BringToFront();
                        m_fs_label_seq_list[i - 1].Text = fx_img.SEQ_NUM.ToString();
                    } 
                    
                }
            }
        }

        /// <summary>
        /// 删除部分图片后，调整展示
        /// </summary>
        /// <param name="pic_num"></param>
        public void AdjustFullScreenFxPicture(int pic_num)
        {
            int pic_count = 0;
            int fx_count = 0;


            while (pic_count < pic_num)
            {            
                while (fx_count < m_fx_img_num)
                {
                    FxImage fx_img = m_img_list.GetFxImage(fx_count + 1);
                    if (fx_img.SHOW_FLAG)
                    { 
                        String pic_name = fx_img.IMAGE_NAME;
                        m_fs_pic_list[pic_count].Load(pic_name);
                        m_fs_pic_list[pic_count].Show();

                        m_fs_label_param_list[pic_count].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);
                        m_fs_label_param_list[pic_count].Visible = false;
                        m_fs_label_param_list[pic_count].BringToFront();//Todo:容易忘的bringtofront，这是一个坑

                        m_fs_label_seq_list[pic_count].Text = fx_img.SEQ_NUM.ToString();
                        m_fs_label_seq_list[pic_count].Visible = false;
                        fx_count++;
                        break;
                    }
                    else
                    {
                        fx_count++;
                    }
                }

                pic_count++;
            }

            for (int i = pic_num; i < m_fx_img_num; i++)
            {
                m_fs_pic_list[i].Image = null;
                m_fs_label_param_list[i].Text = "";
                m_fs_label_seq_list[i].Text = "";
            }

            /*
            this.m_fs_pic_list[0].SizeMode = PictureBoxSizeMode.Zoom;
            this.m_fs_pic_list[0].BackColor = Color.Gray;
            this.m_fs_pic_list[0].Height = (int)(this.m_fs_pic_list[0].Height * 1.5);
            this.m_fs_pic_list[0].Width = (int)(this.m_fs_pic_list[0].Width * 1.5);
        
             */ 
        }

        /// <summary>
        /// 设置文本显示特性
        /// </summary>
        /// <param name="show_text"></param>
        public void ShowText(bool show_text)
        {

            for (int i = 0; i < m_fx_img_num; i++)
            {
                m_fs_label_param_list[i].Visible = show_text;
                m_fs_label_seq_list[i].Visible = show_text;
            }

        }
        /// <summary>
        /// 随机删除一些图片
        /// </summary>
        /// <param name="remove_num"></param>
        public void RandomRemove(int remove_num)
        {

            List<int> remove_index = m_img_list.RandomRemove(remove_num);

            //先删除选手已学习的图片
            for (int i = 0; i < m_fx_img_num; i++)
            {
                if (m_img_list.GetFxImage(i + 1).SHOW_FLAG == false)
                {
                    m_fs_pic_list[i].Image = null;
                    
                    m_fs_label_param_list[i].Text = "";
                    m_fs_label_seq_list[i].Text = "";

                    m_fs_pic_list[i].BackColor = Color.Blue;
                    Thread.Sleep(50);
                    m_fs_pic_list[i].BackColor = Color.Transparent;
                }
            }

            foreach (int index in remove_index)
            {
                m_img_list.GetFxImage(index + 1).SHOW_FLAG = false;

                m_fs_pic_list[index].Image = null;
                m_fs_label_param_list[index].Text = "";
                m_fs_label_seq_list[index].Text = "";

            }

            
            this.Refresh();
        }

        /// <summary>
        /// 打乱图片顺序
        /// </summary>
        public void ShuffleFxPicture()
        {
            m_img_list.ShuffleFxImages();

            m_img_list.CreateFinalFxList();
            int final_fx_count = m_img_list.GetFinalFxCount();
            FxImage img;
            for (int i = 0; i < final_fx_count; i++)
            {
                img = m_img_list.GetFinalFxImage(i);

                m_fs_pic_list[i].Load(img.IMAGE_NAME);
                m_fs_pic_list[i].Show();

                m_fs_label_param_list[i].Text = String.Format("x: {0}, y: {1}", img.FX_X, img.FX_Y);
                m_fs_label_param_list[i].Visible = false;

                m_fs_label_seq_list[i].Text = img.SEQ_NUM.ToString();
                m_fs_label_seq_list[i].Visible = false;

                
            }

            this.Refresh();



        }
        /**
         * 上一页按钮
         */
        public void button_pre_Click()
        {
            m_page_num--;
            LoadPageScreenFxPicture(m_page_num);
        }

        /**
         * 下一页按钮，默认共10页
         */
        public void button_next_Click()
        {
            m_page_num++;
            LoadPageScreenFxPicture(m_page_num);
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
         * 
         */
        public void button_select_Click(int page_num, int pic_num)
        {
            //加载选手选择的页面
            if (page_num <= m_pages && page_num > 0 && pic_num <= m_fx_img_num)
            {
                int pic_box_num = m_pic_col * m_pic_row;//分页屏PictureBox控件数量
                int select_pic_box_num = pic_num % (m_pic_col * m_pic_row);//1号-20号

                InitPageScreenPictureBox();

                m_img_list.ChooseImage(pic_num);


                //设置学习时间
                timer1.Interval = 1000;
                timer1.Enabled = true;
                m_study_time = 3;
                timer1.Start();
                timer1.Tag = pic_num;

                //初始化图片框内容
                FxImage fx_img;
                String pic_name, blur_pic_name;
                for (int i = 1; i <= pic_box_num; i++)
                {
                    fx_img = m_img_list.GetFxImage(i + (page_num - 1) * pic_box_num);
                    pic_name = fx_img.IMAGE_NAME;
                    blur_pic_name = fx_img.BLUR_IMAGE_NAME;

                    //选中的图片
                    if (i == select_pic_box_num)
                    {
                        m_ps_pic_list[i - 1].Load(pic_name);
                        m_ps_pic_list[i - 1].Show();

                    }
                    else//非选中的图片
                    {
                        m_ps_pic_list[i - 1].Load(blur_pic_name);
                        m_ps_pic_list[i - 1].Show();
                    }

                    //选手学过的图片高亮显示
                    if (fx_img.STUDY_FLAG == true)
                    {
                        m_ps_pic_list[i - 1].BackColor = Color.Green;
                        m_ps_label_param_list[i - 1].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);
                        m_ps_label_param_list[i - 1].Visible = true;
                        m_ps_label_param_list[i - 1].BringToFront();
                    }
                    else
                    {
                        m_ps_pic_list[i - 1].BackColor = Color.Transparent;
                        m_ps_label_param_list[i - 1].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);
                        m_ps_label_param_list[i - 1].Visible = false;
                    }

                    //显示序号
                    m_ps_label_seq_list[i - 1].Text = fx_img.SEQ_NUM.ToString();

                    this.Refresh();

                }

            }


        }

        private void pictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

            
            PictureBox pi = (PictureBox)sender;
            //恢复光标
            pi.UseWaitCursor = false;
        }

        private void BigScreen_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 时间事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (m_study_time > 0)
            {
                m_study_time--;
                
            }
            else
            {
                System.Windows.Forms.Timer t = (System.Windows.Forms.Timer)sender;
                int img_num = (int)t.Tag;
                int select_pic_box_num = img_num % (m_pic_col * m_pic_row);//1号-20号

                timer1.Enabled = false;
                timer1.Stop();

                FxImage img = m_img_list.GetFxImage(img_num);
                m_ps_pic_list[select_pic_box_num - 1].Load(img.BLUR_IMAGE_NAME);
            }
        }
    }
}
