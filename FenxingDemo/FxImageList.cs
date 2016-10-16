using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace FenxingDemo
{
    class FxImageList
    {
        private List<FxImage> m_fx_list;
        private int m_fx_image_num;//分形图片数量

        /* *
         * 构造函数，传入分形图片的数量，默认250图片
         * */
        public FxImageList(int fx_image_num = 200)
        {
            m_fx_image_num = fx_image_num;
            m_fx_list = new List<FxImage>(m_fx_image_num);

        }


        /**
         * 
         *将分形图片打乱展示 
         **/
        public void ShuffleImages()
        {

        }

        /**
         * 显示分形图片
         * */
        public void ShowImages()
        {
        }

        /***
         *放大显示图片 
         * */
        public void MaginifyImage(String image_name)
        {
        }



    }
}
