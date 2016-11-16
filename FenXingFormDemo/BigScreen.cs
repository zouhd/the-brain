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
        private String m_pic_dir;//存放图片的路径，图片base路径/题目编号
        private String m_fx_id;//分形题目编号
        private int m_fx_img_num;//分形图片数量
        private FxImageList m_img_list;//图片模型列表

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
        public BigScreen(int fs_pic_row = 5, int fs_pic_col = 5, int fx_img_num = 25, String pic_dir = "..\\..\\pic\\", String fx_id = "A1")
        {
            InitializeComponent();

            m_fs_pic_row = fs_pic_row;
            m_fs_pic_col = fs_pic_col;

            m_fx_img_num = fx_img_num;

            m_pic_dir = pic_dir;//设置存放图片的路径
            m_fx_id = fx_id;//分形题目编号，A1,A2...
            
            m_img_list = new FxImageList(m_pic_dir, m_fx_id, m_fx_img_num);
            InitFxImageList();

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;

            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            backgroundWorker2.ProgressChanged += backgroundWorker2_ProgressChanged;
            backgroundWorker2.RunWorkerCompleted += backgroundWorker2_RunWorkerCompleted;

        }

        public int FX_IMAGE_NUM
        {
            get { return m_fx_img_num; }
            set { m_fx_img_num = value; }
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
        /// 载入全屏图片
        /// </summary>
        /// <param name="pic_num"></param>
        /// /// <param name="check_show_flag">判断是否要检查show_flag标记</param>
        public void LoadFullScreenFxPicture()
        {

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            int pic_num = m_fx_img_num;
            for (int i = 0; i < m_fx_img_num; i++)
            {
                backgroundWorker1.ReportProgress(i);
                Thread.Sleep(500);//片头参数停留时间
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            FxImage fx_img;
            String pic_name;

            int fx_index = e.ProgressPercentage;

            fx_img = m_img_list.GetFxImage(fx_index + 1);
            pic_name = fx_img.IMAGE_NAME;
            m_fs_pic_list[fx_index].Load(pic_name);

            m_fs_label_param_list[fx_index].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);

            if (fx_img.FIRST_FLAG || fx_img.LAST_FLAG || fx_img.STUDY_FLAG)
            {
                m_fs_label_param_list[fx_index].ForeColor = Color.Red;
                m_fs_label_param_list[fx_index].BringToFront();
                m_fs_label_param_list[fx_index].Visible = true;
            }
            else
            {
                m_fs_label_param_list[fx_index].Visible = false;
            }
           

            /*
            int row = e.ProgressPercentage;
            int fx_index = 0;
            for (int i = 0; i < m_fs_pic_col; i++)
            {
                fx_index = i  + (row - 1) * m_fs_pic_col;
                fx_img = m_img_list.GetFxImage(fx_index + 1);
                pic_name = fx_img.IMAGE_NAME;
                m_fs_pic_list[fx_index].Load(pic_name);

                m_fs_label_param_list[fx_index].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);

                if (fx_img.FIRST_FLAG || fx_img.LAST_FLAG || fx_img.STUDY_FLAG)
                {
                    m_fs_label_param_list[fx_index].ForeColor = Color.Red;
                    m_fs_label_param_list[fx_index].BringToFront();
                    m_fs_label_param_list[fx_index].Visible = true;
                }
                else
                {
                    m_fs_label_param_list[fx_index].Visible = false;
                }
            }
             */
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            FxImage fx_img;
            //初始化图片框内容
            for (int i = 1; i <= m_fx_img_num; i++)
            {
                fx_img = m_img_list.GetFxImage(i);
                m_fs_label_seq_list[i - 1].Text = fx_img.SEQ_NUM.ToString();
                m_fs_label_seq_list[i - 1].Visible = true;
            }
        }

        /***
         * 选中制定页，制定编码图片
         * 
         */
        public int StudyFxImage(int pic_num)
        {
            //加载选手选择的页面
            if (pic_num > 0 && pic_num <= m_fx_img_num && m_study_num < m_study_max_num)
            {
                int pic_box_num = m_fs_pic_row * m_fs_pic_col;
                int ret = m_img_list.ChooseImage(pic_num);
                if (ret == 0)
                {
                    m_study_num++;
                }
                
                if (!backgroundWorker2.IsBusy)
                    backgroundWorker2.RunWorkerAsync(pic_num);

            }

            return m_study_num;


        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int pic_num = (int)e.Argument;
            backgroundWorker2.ReportProgress(pic_num);
            Thread.Sleep(m_study_time * 1000);//学习时间
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //初始化图片框内容
            FxImage fx_img;
            String blur_pic_name;
            int pic_num = e.ProgressPercentage;

            for (int i = 1; i <= m_fx_img_num; i++)
            {
                fx_img = m_img_list.GetFxImage(i);
                if (i == pic_num)
                {
                    m_fs_label_param_list[pic_num - 1].Text = String.Format("x: {0}, y: {1}", fx_img.FX_X, fx_img.FX_Y);
                    m_fs_label_param_list[pic_num - 1].ForeColor = Color.Red;
                    m_fs_label_param_list[pic_num - 1].BringToFront();
                    m_fs_label_param_list[pic_num - 1].Visible = true;
                }
                else
                {
                    blur_pic_name = fx_img.BLUR_IMAGE_NAME;
                    m_fs_pic_list[i - 1].Load(blur_pic_name);

                    
                }

            }            
            
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            
            FxImage fx_img;
            String pic_name;
            //初始化图片框内容
            for (int i = 1; i <= m_fx_img_num; i++)
            {
                fx_img = m_img_list.GetFxImage(i);
                pic_name = fx_img.IMAGE_NAME;
                m_fs_pic_list[i - 1].Load(pic_name);
            }
            

            MessageBox.Show("学习时间到");
        }

        /// <summary>
        /// 设置文本显示特性
        /// </summary>
        /// <param name="show_text"></param>
        public void ShowParam(bool show_text)
        {
            FxImage img;
            for (int i = 0; i < m_fx_img_num; i++)
            {
                img = m_img_list.GetFxImage(i + 1);
                if (!img.STUDY_FLAG)
                {
                    m_fs_label_param_list[i].ForeColor = Color.Gray;
                    m_fs_label_param_list[i].BringToFront();
                    m_fs_label_param_list[i].Visible = show_text;
                }
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


        /***
         * 窗口关闭事件处理，隐藏不关闭
         * */
        private void BigScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        

        private void pictureBox_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

            
            PictureBox pi = (PictureBox)sender;
            //恢复光标
            pi.UseWaitCursor = false;
        }



    }
}
