using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Timers;

namespace FenxingDemo
{
    class FxImageList
    {
        private List<FxImage> m_fx_list;
        private String m_base_dir;//存放分形图片的目录
        private String m_fx_style;//分形式样名称（16个之一）
        private int m_fx_image_num;//分形图片数量
        

        /* *
         * 构造函数，传入分形图片的数量，默认250图片
         * */
        public FxImageList(String base_dir, String fx_style, int fx_image_num = 200)
        {
            m_base_dir = base_dir;
            m_fx_style = fx_style;

            m_fx_image_num = fx_image_num;
            m_fx_list = new List<FxImage>(m_fx_image_num);

        }


        /***
         * 
         * 根据目录，读取分形图片，加入分形图片列表中
         **/
        public void ReadFxImage()
        {

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
