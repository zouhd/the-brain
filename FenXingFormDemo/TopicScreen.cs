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
    public struct Param
    {
        public int x;
        public int y;
    }

    public partial class TopicScreen : Form
    {
        private int screen_width;
        private int screen_height;
        private const int pic_row = 2;
        private const int pic_col = 5;

        private const int mov_width = 1844;
        private const int mov_height = 1392;

        private PictureBox[,] pic_array = new PictureBox[pic_row, pic_col];
        private Label[,] label_array = new Label[pic_row, pic_col];
        private Label fx_param;

        private Param topic_param;

        public TopicScreen()
        {
            InitializeComponent();

            for (int i = 0; i < pic_row; i++)
                for (int j = 0; j < pic_col; j++)
                {
                    pic_array[i, j] = new PictureBox();
                    this.panel1.Controls.Add(pic_array[i, j]);

                    label_array[i, j] = new Label();
                    label_array[i, j].BackColor = Color.Transparent;
                    this.panel1.Controls.Add(label_array[i, j]);
                }

            fx_param = new Label();
            fx_param.Font = new Font("宋体", 12);
            fx_param.Parent = panel1;
            fx_param.BackColor = Color.Transparent;
            this.panel1.Controls.Add(fx_param);

            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += backgroundWorker1_DoWork;
            backgroundWorker1.ProgressChanged += backgroundWorker1_ProgressChanged;
            backgroundWorker1.RunWorkerCompleted += backgroundWorker1_RunWorkerCompleted;


            backgroundWorker2.WorkerReportsProgress = true;
            backgroundWorker2.DoWork += backgroundWorker2_DoWork;
            backgroundWorker2.ProgressChanged += backgroundWorker2_ProgressChanged;
            backgroundWorker2.RunWorkerCompleted += backgroundWorker2_RunWorkerCompleted;

        }

        public void InitScreen()
        {
            screen_width = Screen.PrimaryScreen.Bounds.Width;
            screen_height = Screen.PrimaryScreen.Bounds.Height;

            this.Size = new Size(screen_width, screen_height);
            this.panel1.Size = new Size(screen_width, screen_height);

            this.axPlayer1.Size = new Size((int)(mov_width * 0.46), (int)(mov_height * 0.46));
            this.axPlayer1.Visible = false;

           
            String pic_dir = @"D:\临时项目\Repository\the-brain\FenXingFormDemo\pic\A1";

            for (int i = 0; i < pic_row; i++)
                for (int j = 0; j < pic_col; j++)
                {
                    String img_name = String.Format(@"0{0}{1}.jpg", i+1, j+1);
                    String img_path = String.Format(@"{0}\{1}", pic_dir, img_name);
                    pic_array[i, j].Left = (int)(40 + j * 80 + j * 120 * 1.2);
                    pic_array[i, j].Top = (int)(40 + i * 40 + i * 120 * 1.2);
                    pic_array[i, j].Width = (int)(120 * 1.2);
                    pic_array[i, j].Height = (int)(120 * 1.2);
                    pic_array[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    pic_array[i, j].BringToFront();
                    pic_array[i, j].Visible = true;
                    pic_array[i, j].Load(img_path);

                    label_array[i, j].Font = new Font("宋体", 12);
                    label_array[i, j].Width = 20;
                    label_array[i, j].BackColor = Color.Transparent;
                    label_array[i, j].Left = (int)(100 + j * 80 + j * 120 * 1.2);
                    label_array[i, j].Top = (int)(190 + i * 40 + i * 120 * 1.2);
                    label_array[i, j].Text = (j + 1 + i * pic_col).ToString();
                    label_array[i, j].Visible = true;
                    label_array[i, j].BringToFront();
                }


            fx_param.Visible = false;
        }

        public void SelectTopic(int x, int y)
        {
            topic_param.x = x;
            topic_param.y = y;

            fx_param.Visible = false;

            for (int i = 0; i < pic_row; i++)
                for (int j = 0; j < pic_col; j++)
                    label_array[i, j].Visible = false;

            if (!backgroundWorker1.IsBusy)
                backgroundWorker1.RunWorkerAsync();

        }

        public void PlayMov(int x, int y)
        {
            int player_width = this.axPlayer1.Size.Width;
            int player_height = this.axPlayer1.Size.Height;
            this.axPlayer1.Left = (screen_width - player_width) / 2;
            this.axPlayer1.Top = (screen_height - player_height) / 2;

            this.axPlayer1.Visible = true;
            axPlayer1.BringToFront();


            axPlayer1.Open(@"D:\临时项目\Repository\the-brain\FenXingFormDemo\mov\fx4.mov");
            axPlayer1.OnStateChanged +=axPlayer1_OnStateChanged;
            axPlayer1.Play();

        }

        private void axPlayer1_OnStateChanged(object sender, AxAPlayer3Lib._IPlayerEvents_OnStateChangedEvent e)
        {
            int x = topic_param.x - 1;
            int y = topic_param.y - 1;

            //停止播放
            if (e.nNewState == 0)
            {
                axPlayer1.Visible = false;
                pic_array[x, y].Visible = true;
                fx_param.Visible = true;
            }

            //开始播放
            if (e.nOldState == 1 && e.nNewState == 3)
            {

                if (!backgroundWorker2.IsBusy)
                {
        
                    backgroundWorker2.RunWorkerAsync();
                    //MessageBox.Show(String.Format("old: {0}, new: {1}", e.nOldState, e.nNewState));
                }

            }


        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(1000);
            backgroundWorker1.ReportProgress(1);
            Thread.Sleep(1000);
            backgroundWorker1.ReportProgress(2);
            Thread.Sleep(1000);
        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int x = topic_param.x - 1;
            int y = topic_param.y - 1;

            if (e.ProgressPercentage == 1)
            {
                for (int i = 0; i < pic_row; i++)
                    for (int j = 0; j < pic_col; j++)
                    {
                            pic_array[i, j].Visible = false;
                    }

                int width = pic_array[x, y].Width;
                int height = pic_array[x, y].Height;
                pic_array[x, y].Visible = true;
                pic_array[x, y].Left = (screen_width - width) / 2;
                pic_array[x, y].Top = (screen_height - height) / 2;


            }
            else
            {
                int width = pic_array[x, y].Width;
                int height = pic_array[x, y].Height;

                int left = pic_array[x, y].Left;
                int top = pic_array[x, y].Top;

                int last_width = axPlayer1.Width;
                int last_height = axPlayer1.Height;

                pic_array[x, y].Visible = true;
                pic_array[x, y].Size = new Size(last_width, last_height);

                pic_array[x, y].Left = (screen_width - last_width) / 2;
                pic_array[x, y].Top = (screen_height - last_height) / 2;

                pic_array[x, y].BorderStyle = BorderStyle.Fixed3D;

                fx_param.Left = pic_array[x, y].Left + 20;
                fx_param.Top = pic_array[x, y].Top + last_height - 20;


            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int x = topic_param.x;
            int y = topic_param.y;
            //PlayMov(x, y);

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            backgroundWorker2.ReportProgress(1);
            Thread.Sleep(1000);//片头参数停留时间
            backgroundWorker2.ReportProgress(2);
            Thread.Sleep(7000);
            backgroundWorker2.ReportProgress(3);
            Thread.Sleep(1000);//片尾参数停留时间
            backgroundWorker2.ReportProgress(4);
        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 1)
            {
                fx_param.Visible = true;
                fx_param.Text = "0.7, 0.30";
                fx_param.BringToFront();
                fx_param.ForeColor = Color.Green;
            }
            else if (e.ProgressPercentage == 2)
                fx_param.Visible = false;
            else if (e.ProgressPercentage == 3)
            {
                fx_param.Visible = true;
                fx_param.Text = "0.9, 0.22";
                fx_param.BringToFront();
                fx_param.ForeColor = Color.Green;
            }
            else
                fx_param.Visible = false;
                
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

    }

}
