using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FenXingFormDemo
{
    class FxImageList
    {
        private List<FxImage> m_fx_list;//初始fx图片列表
        private List<FxImage> m_question_fx_list;//提问的fx图片列表
        private String m_base_dir;//存放分形图片的目录
        private String m_fx_id;//分形式样名称（16个之一），A1，A2，A3
        private int m_fx_image_num;//分形图片数量

        private int m_fx_study_max_num;//选手学习图片的数量上线
        private int m_fx_study_num;//选手选择的图片数量
        /// <summary>
        /// 构造函数，传入分形图片的数量，默认200图片
        /// </summary>
        /// <param name="base_dir">存放图片的路径</param>
        /// <param name="fx_id">嘉宾选择的分形题目编号，A1，A2，A3</param>
        /// <param name="fx_image_num">节目组生成的分形图片数量，默认200张</param>
        /// <param name="fx_study_max_num">选手可以学习的图片数量</param>
        /// <param name="fx_study_max_num">选手已经选择学习的图片数量</param>
        public FxImageList(String base_dir, String fx_id, int fx_image_num = 200, int fx_study_max_num = 3)
        {
            m_base_dir = base_dir;
            m_fx_id = fx_id;

            m_fx_image_num = fx_image_num;
            m_fx_study_max_num = fx_study_max_num;
            m_fx_study_num = 0;

            m_fx_list = new List<FxImage>(m_fx_image_num);

        }


        public int FX_STUDY_NUM
        {
            get { return m_fx_study_num; }
            set { m_fx_study_num = value; }
        }

        public int FX_STUDY_MAX_NUM
        {
            get { return m_fx_study_max_num; }
            set { m_fx_study_max_num = value; }
        }
        

        public int FX_IMAGE_NUM
        {
            get { return m_fx_image_num; }
            set { m_fx_image_num = value; }
        }
        /***
         * 
         * 根据目录，读取分形图片，加入分形图片列表中
         * 
         * Todo:读取每张图片的参数值
         **/
        public void InitFxImages()
        {
            for (int i = 1; i <= m_fx_image_num; i++)
            {

                String pic_name = String.Format("{0}{1}\\{2}{3}", m_base_dir, m_fx_id, i.ToString("D3"), ".jpg");
                String blur_pic_name = String.Format("{0}{1}\\{2}{3}", m_base_dir, m_fx_id, i.ToString("D3"), "_blur.jpg");
                FxImage img = new FxImage(pic_name, blur_pic_name, i, i * 2, i * 3);
                
                //初始化fx图片数据
                //Todo: 对第一张图片和最后一张图片处理
                if (i == 1)
                {
                    img.STUDY_FLAG = true;//默认第一张和最后一张图片学习
                    img.FIRST_FLAG = true;
                    img.SHOW_FLAG = false;
                    
                }
                if (i == 1 || i == m_fx_image_num)
                {
                    img.STUDY_FLAG = true;//默认第一张和最后一张图片学习
                    img.LAST_FLAG = true;//
                    img.SHOW_FLAG = false;
                }

                m_fx_list.Add(img);

            }
        }

        //重置分形图片数据
        public void ResetFxImages()
        {
            //Todo:恢复排序
            m_fx_list.Sort(FxImage.Compare);

            for (int i = 1; i <= m_fx_image_num; i++)
            {

                m_fx_list[i - 1].SHOW_FLAG = true;

                //初始化fx图片数据
                //Todo: 对第一张图片和最后一张图片处理
                if (i == 1)
                {
                    m_fx_list[i - 1].STUDY_FLAG = true;//默认第一张和最后一张图片学习
                    m_fx_list[i - 1].FIRST_FLAG = true;

                }
                else if (i == m_fx_image_num)
                {
                    m_fx_list[i - 1].STUDY_FLAG = true;//默认第一张和最后一张图片学习
                    m_fx_list[i - 1].LAST_FLAG = true;//
                }
                else
                {
                    m_fx_list[i - 1].STUDY_FLAG = false;
                }


            }
        }


        public FxImage GetFxImage(int fx_seq_num)
        {
            return m_fx_list[fx_seq_num - 1];
        }


        /**
         * 按照编号显示分形图片
         * */
        public void ShowImages()
        {

        }

        /***
         * 
         * 选手选择3张图片，显示分形图片参数
         * 前提条件是选手选择少于规定的图片数量
         ***/
        public bool ChooseImage(int selected_num)
        {
            bool flag = false;
            if (m_fx_study_num < m_fx_study_max_num)
            {
                if (selected_num > 0 && selected_num <= m_fx_image_num)
                {
                    m_fx_list[selected_num - 1].STUDY_FLAG = true;
                    m_fx_list[selected_num - 1].SHOW_FLAG = false;
                    m_fx_study_num++;
                    flag = true;
                }
            }

            return flag;
        }
        
        /***
         *放大显示图片 
         * */
        public void MaginifyImage(String image_name)
        {
        }

        
 
        /**
         * 
         *将分形图片打乱展示 
         **/
        public void ShuffleFxImages()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            
            int index = 0;
            FxImage temp = null;
            for (int i = 0; i < m_fx_image_num; i++)
            {

                index = r.Next(0, m_fx_image_num);

                if (index != i)
                {
                    temp = m_fx_list[i];
                    m_fx_list[i] = m_fx_list[index];
                    m_fx_list[index] = temp;
                }
            }

        }

        /// <summary>
        /// 随机删除num个元素
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public List<int> RandomRemove(int remove_num)
        {
            List<int> remove_list = new List<int>();

            Random r = new Random(DateTime.Now.Millisecond);

            int index = 0;
            int count = 0;
            FxImage temp = null;

            
            while (count < remove_num)
            {
                index = r.Next(0, m_fx_image_num);

                if (!remove_list.Contains(index) && index != 0 && index != m_fx_image_num - 1)
                {
                    temp = m_fx_list[index];
                    if (!temp.FIRST_FLAG && !temp.LAST_FLAG && !temp.STUDY_FLAG)
                    {
                        remove_list.Add(index);
                        temp.SHOW_FLAG = false;

                        count++;
                    }
                }
            }

            return remove_list;
        }

        /// <summary>
        /// 获取最后提问的fx图片清单
        /// </summary>
        /// <returns></returns>
        public void CreateFinalFxList()
        {
            m_question_fx_list = new List<FxImage>();

            for (int i = 0; i < m_fx_image_num; i++)
            {
                if (m_fx_list[i].SHOW_FLAG)
                    m_question_fx_list.Add(m_fx_list[i]);
            }
        }

        public int GetFinalFxCount()
        {
            return m_question_fx_list.Count;
        }

        public FxImage GetFinalFxImage(int index)
        {
            return m_question_fx_list[index];
        }

    }
}
