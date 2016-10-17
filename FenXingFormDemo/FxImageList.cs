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
        private List<FxImage> m_fx_list;
        private String m_base_dir;//存放分形图片的目录
        private String m_fx_id;//分形式样名称（16个之一），A1，A2，A3
        private int m_fx_image_num;//分形图片数量
        

        /* *
         * 构造函数，传入分形图片的数量，默认250图片
         * */
        public FxImageList(String base_dir, String fx_id, int fx_image_num = 200)
        {
            m_base_dir = base_dir;
            m_fx_id = fx_id;

            m_fx_image_num = fx_image_num;
            m_fx_list = new List<FxImage>(m_fx_image_num);

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
                
                FxImage img = new FxImage(pic_name, i, i * 2, i *3);
                m_fx_list.Add(img);

            }
        }

        
        /***
         * 
         * 根据Fx编号返回FxImage对象引用
         * Todo:加强判断
         ***/
        public void GetFxImage(out FxImage fx_img,  int fx_seq_num )
        {
            fx_img = m_fx_list[fx_seq_num - 1];
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
         * 
         ***/
        public void ChooseImages(int selected_num)
        {

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
        public void ShuffleImages()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            int randnum = r.Next();
        }

    }
}
