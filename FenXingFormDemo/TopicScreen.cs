using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;

namespace FenXingFormDemo
{
    public partial class TopicScreen : Form
    {
        private int screen_width;
        private int screen_height;
        private int pic_row = 4;
        private int pic_col = 5;

        private PictureBox[, ] pic_array = new PictureBox[4, 5];

        public TopicScreen()
        {
            InitializeComponent();

            screen_width = Screen.PrimaryScreen.Bounds.Width;
            screen_height = Screen.PrimaryScreen.Bounds.Height;

            this.Size = new Size(screen_width, screen_height);
            this.panel1.Size = new Size(screen_width - 20, screen_height - 20);

            int player_width = this.axPlayer1.Size.Width;
            int player_height = this.axPlayer1.Size.Height;
            this.axPlayer1.Left = (screen_width - player_width) / 2;
            this.axPlayer1.Top = (screen_height - player_height) / 2;

            this.axPlayer1.Scale(new SizeF(856, 751));
            /*
            int wmp_width = this.axWindowsMediaPlayer1.Size.Width;
            int wmp_height = this.axWindowsMediaPlayer1.Size.Height;

            this.axWindowsMediaPlayer1.Left = (screen_width - wmp_width) / 2;
            this.axWindowsMediaPlayer1.Top = (screen_height - wmp_height) / 2;
            */
            InitScreen();
            Thread thread = new Thread(new ThreadStart(PlayThread));
            thread.Start();

        }

        private void PlayThread()
        {
            axPlayer1.BringToFront();
            axPlayer1.Open( @"D:\临时项目\Repository\the-brain\FenXingFormDemo\mov\fx4.mov");
            axPlayer1.Play();
        }


        public void SelectTopic(int x, int y)
        {
            //Todo:选完之后 图片移动到中央，然后播放视频


        }

        public void InitScreen()
        {
            String pic_dir = @"D:\临时项目\Repository\the-brain\FenXingFormDemo\pic\A1";

            for (int i = 0; i < pic_row; i++)
                for (int j = 0; j < pic_col; j++)
                {
                    String img_name = String.Format(@"0{0}{1}.jpg", i+1, j+1);
                    String img_path = String.Format(@"{0}\{1}", pic_dir, img_name);

                    pic_array[i,j] = new PictureBox();
                    pic_array[i, j].Left = (int)(40 + j * 80 + j * 120 * 1.2);
                    pic_array[i, j].Top = (int)(40 + i * 40 + i * 120 * 1.2);
                    pic_array[i, j].Width = (int)(120 * 1.2);
                    pic_array[i, j].Height = (int)(120 * 1.2);
                    pic_array[i, j].SizeMode = PictureBoxSizeMode.Zoom;

                    pic_array[i, j].BringToFront();

                    this.panel1.Controls.Add(pic_array[i, j]);

                    pic_array[i, j].Load(img_path);
                    
                }
        }
    }

}
