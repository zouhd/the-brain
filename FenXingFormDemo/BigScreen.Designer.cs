using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Threading;

namespace FenXingFormDemo
{
    partial class BigScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label_param1 = new System.Windows.Forms.Label();
            this.label_fx1 = new System.Windows.Forms.Label();
            this.label_fx2 = new System.Windows.Forms.Label();
            this.label_fx3 = new System.Windows.Forms.Label();
            this.label_fx4 = new System.Windows.Forms.Label();
            this.label_fx5 = new System.Windows.Forms.Label();
            this.label_param2 = new System.Windows.Forms.Label();
            this.label_param3 = new System.Windows.Forms.Label();
            this.label_param4 = new System.Windows.Forms.Label();
            this.label_param5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_param10 = new System.Windows.Forms.Label();
            this.label_param9 = new System.Windows.Forms.Label();
            this.label_param8 = new System.Windows.Forms.Label();
            this.label_param7 = new System.Windows.Forms.Label();
            this.label_fx10 = new System.Windows.Forms.Label();
            this.label_fx9 = new System.Windows.Forms.Label();
            this.label_fx8 = new System.Windows.Forms.Label();
            this.label_fx7 = new System.Windows.Forms.Label();
            this.label_fx6 = new System.Windows.Forms.Label();
            this.label_param6 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.label_param11 = new System.Windows.Forms.Label();
            this.label_param12 = new System.Windows.Forms.Label();
            this.label_param13 = new System.Windows.Forms.Label();
            this.label_param14 = new System.Windows.Forms.Label();
            this.label_param15 = new System.Windows.Forms.Label();
            this.label_fx11 = new System.Windows.Forms.Label();
            this.label_fx12 = new System.Windows.Forms.Label();
            this.label_fx13 = new System.Windows.Forms.Label();
            this.label_fx14 = new System.Windows.Forms.Label();
            this.label_fx15 = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.label_param16 = new System.Windows.Forms.Label();
            this.label_param17 = new System.Windows.Forms.Label();
            this.label_param18 = new System.Windows.Forms.Label();
            this.label_param19 = new System.Windows.Forms.Label();
            this.label_param20 = new System.Windows.Forms.Label();
            this.label_fx16 = new System.Windows.Forms.Label();
            this.label_fx17 = new System.Windows.Forms.Label();
            this.label_fx18 = new System.Windows.Forms.Label();
            this.label_fx19 = new System.Windows.Forms.Label();
            this.label_fx20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(160, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox2.Size = new System.Drawing.Size(130, 130);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(310, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox3.Size = new System.Drawing.Size(130, 130);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(460, 20);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox4.Size = new System.Drawing.Size(130, 130);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(610, 20);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox5.Size = new System.Drawing.Size(130, 130);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(10, 190);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox6.Size = new System.Drawing.Size(130, 130);
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(160, 190);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox7.Size = new System.Drawing.Size(130, 130);
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(310, 190);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox8.Size = new System.Drawing.Size(130, 130);
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(460, 190);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox9.Size = new System.Drawing.Size(130, 130);
            this.pictureBox9.TabIndex = 0;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(610, 190);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox10.Size = new System.Drawing.Size(130, 130);
            this.pictureBox10.TabIndex = 0;
            this.pictureBox10.TabStop = false;

            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(10, 360);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox11.Size = new System.Drawing.Size(130, 130);
            this.pictureBox11.TabIndex = 0;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(160, 360);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox12.Size = new System.Drawing.Size(130, 130);
            this.pictureBox12.TabIndex = 0;
            this.pictureBox12.TabStop = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(310, 360);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox13.Size = new System.Drawing.Size(130, 130);
            this.pictureBox13.TabIndex = 0;
            this.pictureBox13.TabStop = false;
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(460, 360);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox14.Size = new System.Drawing.Size(130, 130);
            this.pictureBox14.TabIndex = 0;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(610, 360);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox15.Size = new System.Drawing.Size(130, 130);
            this.pictureBox15.TabIndex = 0;
            this.pictureBox15.TabStop = false;

            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(10, 530);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox16.Size = new System.Drawing.Size(130, 130);
            this.pictureBox16.TabIndex = 0;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(160, 530);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox17.Size = new System.Drawing.Size(130, 130);
            this.pictureBox17.TabIndex = 0;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(310, 530);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox18.Size = new System.Drawing.Size(130, 130);
            this.pictureBox18.TabIndex = 0;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(460, 530);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox19.Size = new System.Drawing.Size(130, 130);
            this.pictureBox19.TabIndex = 0;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(610, 530);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox20.Size = new System.Drawing.Size(130, 130);
            this.pictureBox20.TabIndex = 0;
            this.pictureBox20.TabStop = false;

            // 
            // label_param1
            // 
            this.label_param1.AutoSize = true;
            this.label_param1.BackColor = System.Drawing.Color.Transparent;
            this.label_param1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param1.Location = new System.Drawing.Point(45, 125);
            this.label_param1.Name = "label_param1";
            this.label_param1.Size = new System.Drawing.Size(55, 21);
            this.label_param1.TabIndex = 1;
            this.label_param1.Text = "label1";
            // 
            // label_param2
            // 
            this.label_param2.AutoSize = true;
            this.label_param2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param2.Location = new System.Drawing.Point(195, 125);
            this.label_param2.Name = "label_param2";
            this.label_param2.Size = new System.Drawing.Size(55, 21);
            this.label_param2.TabIndex = 1;
            this.label_param2.Text = "label1";
            // 
            // label_param3
            // 
            this.label_param3.AutoSize = true;
            this.label_param3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param3.Location = new System.Drawing.Point(344, 125);
            this.label_param3.Name = "label_param3";
            this.label_param3.Size = new System.Drawing.Size(55, 21);
            this.label_param3.TabIndex = 1;
            this.label_param3.Text = "label1";
            // 
            // label_param4
            // 
            this.label_param4.AutoSize = true;
            this.label_param4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param4.Location = new System.Drawing.Point(494, 125);
            this.label_param4.Name = "label_param4";
            this.label_param4.Size = new System.Drawing.Size(55, 21);
            this.label_param4.TabIndex = 1;
            this.label_param4.Text = "label1";
            // 
            // label_param5
            // 
            this.label_param5.AutoSize = true;
            this.label_param5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param5.Location = new System.Drawing.Point(645, 125);
            this.label_param5.Name = "label_param5";
            this.label_param5.Size = new System.Drawing.Size(55, 21);
            this.label_param5.TabIndex = 1;
            this.label_param5.Text = "label1";


            // 
            // label_fx1
            // 
            this.label_fx1.AutoSize = true;
            this.label_fx1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx1.Location = new System.Drawing.Point(60, 155);
            this.label_fx1.Name = "label_fx1";
            this.label_fx1.Size = new System.Drawing.Size(55, 21);
            this.label_fx1.TabIndex = 1;
            this.label_fx1.Text = "label1";
            // 
            // label_fx2
            // 
            this.label_fx2.AutoSize = true;
            this.label_fx2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx2.Location = new System.Drawing.Point(198, 155);
            this.label_fx2.Name = "label_fx2";
            this.label_fx2.Size = new System.Drawing.Size(55, 21);
            this.label_fx2.TabIndex = 1;
            this.label_fx2.Text = "label1";
            // 
            // label_fx3
            // 
            this.label_fx3.AutoSize = true;
            this.label_fx3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx3.Location = new System.Drawing.Point(348, 155);
            this.label_fx3.Name = "label_fx3";
            this.label_fx3.Size = new System.Drawing.Size(55, 21);
            this.label_fx3.TabIndex = 1;
            this.label_fx3.Text = "label1";
            // 
            // label_fx4
            // 
            this.label_fx4.AutoSize = true;
            this.label_fx4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx4.Location = new System.Drawing.Point(498, 155);
            this.label_fx4.Name = "label_fx4";
            this.label_fx4.Size = new System.Drawing.Size(55, 21);
            this.label_fx4.TabIndex = 1;
            this.label_fx4.Text = "label1";
            // 
            // label_fx5
            // 
            this.label_fx5.AutoSize = true;
            this.label_fx5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx5.Location = new System.Drawing.Point(648, 155);
            this.label_fx5.Name = "label_fx5";
            this.label_fx5.Size = new System.Drawing.Size(55, 21);
            this.label_fx5.TabIndex = 1;
            this.label_fx5.Text = "label1";

            // 
            // label_param10
            // 
            this.label_param10.AutoSize = true;
            this.label_param10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param10.Location = new System.Drawing.Point(648, 295);
            this.label_param10.Name = "label_param10";
            this.label_param10.Size = new System.Drawing.Size(55, 21);
            this.label_param10.TabIndex = 1;
            this.label_param10.Text = "label1";
            // 
            // label_param9
            // 
            this.label_param9.AutoSize = true;
            this.label_param9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param9.Location = new System.Drawing.Point(498, 295);
            this.label_param9.Name = "label_param9";
            this.label_param9.Size = new System.Drawing.Size(55, 21);
            this.label_param9.TabIndex = 1;
            this.label_param9.Text = "label1";
            // 
            // label_param8
            // 
            this.label_param8.AutoSize = true;
            this.label_param8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param8.Location = new System.Drawing.Point(348, 295);
            this.label_param8.Name = "label_param8";
            this.label_param8.Size = new System.Drawing.Size(55, 21);
            this.label_param8.TabIndex = 1;
            this.label_param8.Text = "label1";
            // 
            // label_param7
            // 
            this.label_param7.AutoSize = true;
            this.label_param7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param7.Location = new System.Drawing.Point(198, 295);
            this.label_param7.Name = "label_param7";
            this.label_param7.Size = new System.Drawing.Size(55, 21);
            this.label_param7.TabIndex = 1;
            this.label_param7.Text = "label1";
            // 
            // label_fx10
            // 
            this.label_fx10.AutoSize = true;
            this.label_fx10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx10.Location = new System.Drawing.Point(648, 325);
            this.label_fx10.Name = "label_fx10";
            this.label_fx10.Size = new System.Drawing.Size(55, 21);
            this.label_fx10.TabIndex = 1;
            this.label_fx10.Text = "label1";
            // 
            // label_fx9
            // 
            this.label_fx9.AutoSize = true;
            this.label_fx9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx9.Location = new System.Drawing.Point(498, 325);
            this.label_fx9.Name = "label_fx9";
            this.label_fx9.Size = new System.Drawing.Size(55, 21);
            this.label_fx9.TabIndex = 1;
            this.label_fx9.Text = "label1";
            // 
            // label_fx8
            // 
            this.label_fx8.AutoSize = true;
            this.label_fx8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx8.Location = new System.Drawing.Point(348, 325);
            this.label_fx8.Name = "label_fx8";
            this.label_fx8.Size = new System.Drawing.Size(55, 21);
            this.label_fx8.TabIndex = 1;
            this.label_fx8.Text = "label1";
            // 
            // label_fx7
            // 
            this.label_fx7.AutoSize = true;
            this.label_fx7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx7.Location = new System.Drawing.Point(198, 325);
            this.label_fx7.Name = "label_fx7";
            this.label_fx7.Size = new System.Drawing.Size(55, 21);
            this.label_fx7.TabIndex = 1;
            this.label_fx7.Text = "label1";
            // 
            // label_fx6
            // 
            this.label_fx6.AutoSize = true;
            this.label_fx6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx6.Location = new System.Drawing.Point(60, 325);
            this.label_fx6.Name = "label_fx6";
            this.label_fx6.Size = new System.Drawing.Size(55, 21);
            this.label_fx6.TabIndex = 1;
            this.label_fx6.Text = "label1";
            // 
            // label_param6
            // 
            this.label_param6.AutoSize = true;
            this.label_param6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param6.Location = new System.Drawing.Point(45, 295);
            this.label_param6.Name = "label_param6";
            this.label_param6.Size = new System.Drawing.Size(55, 21);
            this.label_param6.TabIndex = 1;
            this.label_param6.Text = "label1";


            // 
            // label_param11
            // 
            this.label_param11.AutoSize = true;
            this.label_param11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param11.Location = new System.Drawing.Point(45, 465);
            this.label_param11.Name = "label_param11";
            this.label_param11.Size = new System.Drawing.Size(55, 21);
            this.label_param11.TabIndex = 1;
            this.label_param11.Text = "label1";
            // 
            // label_param12
            // 
            this.label_param12.AutoSize = true;
            this.label_param12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param12.Location = new System.Drawing.Point(198, 465);
            this.label_param12.Name = "label_param12";
            this.label_param12.Size = new System.Drawing.Size(55, 21);
            this.label_param12.TabIndex = 1;
            this.label_param12.Text = "label1";
            // 
            // label_param13
            // 
            this.label_param13.AutoSize = true;
            this.label_param13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param13.Location = new System.Drawing.Point(348, 465);
            this.label_param13.Name = "label_param13";
            this.label_param13.Size = new System.Drawing.Size(55, 21);
            this.label_param13.TabIndex = 1;
            this.label_param13.Text = "label1";
            // 
            // label_param14
            // 
            this.label_param14.AutoSize = true;
            this.label_param14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param14.Location = new System.Drawing.Point(498, 465);
            this.label_param14.Name = "label_param14";
            this.label_param14.Size = new System.Drawing.Size(55, 21);
            this.label_param14.TabIndex = 1;
            this.label_param14.Text = "label1";
            // 
            // label_param15
            // 
            this.label_param15.AutoSize = true;
            this.label_param15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param15.Location = new System.Drawing.Point(648, 465);
            this.label_param15.Name = "label_param15";
            this.label_param15.Size = new System.Drawing.Size(55, 21);
            this.label_param15.TabIndex = 1;
            this.label_param15.Text = "label1";
            // 
            // label_fx11
            // 
            this.label_fx11.AutoSize = true;
            this.label_fx11.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx11.Location = new System.Drawing.Point(60, 493);
            this.label_fx11.Name = "label_fx11";
            this.label_fx11.Size = new System.Drawing.Size(55, 21);
            this.label_fx11.TabIndex = 1;
            this.label_fx11.Text = "label1";
            // 
            // label_fx12
            // 
            this.label_fx12.AutoSize = true;
            this.label_fx12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx12.Location = new System.Drawing.Point(198, 493);
            this.label_fx12.Name = "label_fx12";
            this.label_fx12.Size = new System.Drawing.Size(55, 21);
            this.label_fx12.TabIndex = 1;
            this.label_fx12.Text = "label1";
            // 
            // label_fx13
            // 
            this.label_fx13.AutoSize = true;
            this.label_fx13.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx13.Location = new System.Drawing.Point(348, 493);
            this.label_fx13.Name = "label_fx13";
            this.label_fx13.Size = new System.Drawing.Size(55, 21);
            this.label_fx13.TabIndex = 1;
            this.label_fx13.Text = "label1";
            // 
            // label_fx14
            // 
            this.label_fx14.AutoSize = true;
            this.label_fx14.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx14.Location = new System.Drawing.Point(498, 493);
            this.label_fx14.Name = "label_fx14";
            this.label_fx14.Size = new System.Drawing.Size(55, 21);
            this.label_fx14.TabIndex = 1;
            this.label_fx14.Text = "label1";
            // 
            // label_fx15
            // 
            this.label_fx15.AutoSize = true;
            this.label_fx15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx15.Location = new System.Drawing.Point(648, 493);
            this.label_fx15.Name = "label_fx15";
            this.label_fx15.Size = new System.Drawing.Size(55, 21);
            this.label_fx15.TabIndex = 1;
            this.label_fx15.Text = "label1";

            // 
            // label_fx16
            // 
            this.label_fx16.AutoSize = true;
            this.label_fx16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx16.Location = new System.Drawing.Point(60, 665);
            this.label_fx16.Name = "label_fx16";
            this.label_fx16.Size = new System.Drawing.Size(55, 21);
            this.label_fx16.TabIndex = 1;
            this.label_fx16.Text = "label1";
            // 
            // label_fx17
            // 
            this.label_fx17.AutoSize = true;
            this.label_fx17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx17.Location = new System.Drawing.Point(198, 665);
            this.label_fx17.Name = "label_fx17";
            this.label_fx17.Size = new System.Drawing.Size(55, 21);
            this.label_fx17.TabIndex = 1;
            this.label_fx17.Text = "label1";
            // 
            // label_fx18
            // 
            this.label_fx18.AutoSize = true;
            this.label_fx18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx18.Location = new System.Drawing.Point(348, 665);
            this.label_fx18.Name = "label_fx18";
            this.label_fx18.Size = new System.Drawing.Size(55, 21);
            this.label_fx18.TabIndex = 1;
            this.label_fx18.Text = "label1";
            // 
            // label_fx19
            // 
            this.label_fx19.AutoSize = true;
            this.label_fx19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx19.Location = new System.Drawing.Point(498, 665);
            this.label_fx19.Name = "label_fx19";
            this.label_fx19.Size = new System.Drawing.Size(55, 21);
            this.label_fx19.TabIndex = 1;
            this.label_fx19.Text = "label1";
            // 
            // label_fx20
            // 
            this.label_fx20.AutoSize = true;
            this.label_fx20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_fx20.Location = new System.Drawing.Point(648, 665);
            this.label_fx20.Name = "label_fx20";
            this.label_fx20.Size = new System.Drawing.Size(55, 21);
            this.label_fx20.TabIndex = 1;
            this.label_fx20.Text = "label1";



            // 
            // label_param16
            // 
            this.label_param16.AutoSize = true;
            this.label_param16.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param16.Location = new System.Drawing.Point(45, 635);
            this.label_param16.Name = "label_param16";
            this.label_param16.Size = new System.Drawing.Size(55, 21);
            this.label_param16.TabIndex = 1;
            this.label_param16.Text = "label1";
            // 
            // label_param17
            // 
            this.label_param17.AutoSize = true;
            this.label_param17.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param17.Location = new System.Drawing.Point(198, 635);
            this.label_param17.Name = "label_param17";
            this.label_param17.Size = new System.Drawing.Size(55, 21);
            this.label_param17.TabIndex = 1;
            this.label_param17.Text = "label1";
            // 
            // label_param18
            // 
            this.label_param18.AutoSize = true;
            this.label_param18.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param18.Location = new System.Drawing.Point(348, 635);
            this.label_param18.Name = "label_param18";
            this.label_param18.Size = new System.Drawing.Size(55, 21);
            this.label_param18.TabIndex = 1;
            this.label_param18.Text = "label1";
            // 
            // label_param19
            // 
            this.label_param19.AutoSize = true;
            this.label_param19.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param19.Location = new System.Drawing.Point(498, 635);
            this.label_param19.Name = "label_param19";
            this.label_param19.Size = new System.Drawing.Size(55, 21);
            this.label_param19.TabIndex = 1;
            this.label_param19.Text = "label1";
            // 
            // label_param20
            // 
            this.label_param20.AutoSize = true;
            this.label_param20.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_param20.Location = new System.Drawing.Point(648, 635);
            this.label_param20.Name = "label_param20";
            this.label_param20.Size = new System.Drawing.Size(55, 21);
            this.label_param20.TabIndex = 1;
            this.label_param20.Text = "label1";

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_param20);
            this.panel1.Controls.Add(this.label_param15);
            this.panel1.Controls.Add(this.label_param10);
            this.panel1.Controls.Add(this.label_param19);
            this.panel1.Controls.Add(this.label_param14);
            this.panel1.Controls.Add(this.label_param9);
            this.panel1.Controls.Add(this.label_param5);
            this.panel1.Controls.Add(this.label_param18);
            this.panel1.Controls.Add(this.label_param13);
            this.panel1.Controls.Add(this.label_param8);
            this.panel1.Controls.Add(this.label_param4);
            this.panel1.Controls.Add(this.label_param17);
            this.panel1.Controls.Add(this.label_param12);
            this.panel1.Controls.Add(this.label_param7);
            this.panel1.Controls.Add(this.label_param3);
            this.panel1.Controls.Add(this.label_param2);
            this.panel1.Controls.Add(this.label_fx20);
            this.panel1.Controls.Add(this.label_fx15);
            this.panel1.Controls.Add(this.label_fx10);
            this.panel1.Controls.Add(this.label_fx5);
            this.panel1.Controls.Add(this.label_fx19);
            this.panel1.Controls.Add(this.label_fx14);
            this.panel1.Controls.Add(this.label_fx9);
            this.panel1.Controls.Add(this.label_fx4);
            this.panel1.Controls.Add(this.label_fx18);
            this.panel1.Controls.Add(this.label_fx13);
            this.panel1.Controls.Add(this.label_fx8);
            this.panel1.Controls.Add(this.label_fx3);
            this.panel1.Controls.Add(this.label_fx17);
            this.panel1.Controls.Add(this.label_fx12);
            this.panel1.Controls.Add(this.label_fx7);
            this.panel1.Controls.Add(this.label_fx2);
            this.panel1.Controls.Add(this.label_param16);
            this.panel1.Controls.Add(this.label_param11);
            this.panel1.Controls.Add(this.label_fx16);
            this.panel1.Controls.Add(this.label_fx11);
            this.panel1.Controls.Add(this.label_fx6);
            this.panel1.Controls.Add(this.label_param6);
            this.panel1.Controls.Add(this.label_fx1);
            this.panel1.Controls.Add(this.label_param1);
            this.panel1.Controls.Add(this.pictureBox20);
            this.panel1.Controls.Add(this.pictureBox15);
            this.panel1.Controls.Add(this.pictureBox19);
            this.panel1.Controls.Add(this.pictureBox14);
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.pictureBox18);
            this.panel1.Controls.Add(this.pictureBox13);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox17);
            this.panel1.Controls.Add(this.pictureBox12);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox16);
            this.panel1.Controls.Add(this.pictureBox11);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(10, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 685);
            this.panel1.TabIndex = 0;
           
            
            // 
            // BigScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 692);
            this.Controls.Add(this.panel1);
            this.Name = "BigScreen";
            this.Text = "大屏";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BigScreen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();

        }

        /// <summary>
        /// 清除面板中所有组件
        /// </summary>
        public void ClearComponent()
        {
            this.panel1.Controls.Clear();
        }

        
        /// <summary>
        /// 初始化分页屏界面
        /// </summary>
        /// <param name="pic_row"></param>
        /// <param name="pic_col"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="padding"></param>
        public void InitializePagesScreen(int pic_row = 4, int pic_col = 5, int width = 130, int height = 130, int padding = 5)
        {
            int pic_num = pic_row * pic_col;//Todo:改成 m_pic_row * m_pic_col
            int width_gap = 10;
            int height_gap = 40;

            int init_label_param_left = 45;
            int init_label_param_top = 125;

            int init_label_seq_left = 60;
            int init_label_seq_top = 155;

            this.Width = 800;
            this.panel1.Width = 750;

            ClearComponent();

            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigScreen));


            if (m_ps_pic_list != null)
                m_ps_pic_list.Clear();

            if (m_ps_label_param_list != null)
                m_ps_label_param_list.Clear();

            if (m_ps_label_seq_list != null)
                m_ps_label_seq_list.Clear();

            m_ps_pic_list = new List<PictureBox>(pic_num);
            m_ps_label_param_list = new List<Label>(pic_num);
            m_ps_label_seq_list = new List<Label>(pic_num);

            for (int i = 0; i < pic_num; i++)
            {
                m_ps_pic_list.Add(new PictureBox());
                ((System.ComponentModel.ISupportInitialize)(this.m_ps_pic_list[i])).BeginInit();

                m_ps_pic_list[i].Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_test.Image")));

                m_ps_pic_list[i].Name = "pictureBox" + i.ToString();
                m_ps_pic_list[i].Padding = new System.Windows.Forms.Padding(5);
                m_ps_pic_list[i].Size = new System.Drawing.Size(width, height);
                m_ps_pic_list[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                m_ps_pic_list[i].TabIndex = 0;
                m_ps_pic_list[i].TabStop = false;

                m_ps_label_param_list.Add(new Label());
                m_ps_label_param_list[i].AutoSize = true;
                m_ps_label_param_list[i].Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                m_ps_label_param_list[i].Location = new System.Drawing.Point(45, 125);
                m_ps_label_param_list[i].Name = "label_fx" + i.ToString();
                m_ps_label_param_list[i].Size = new System.Drawing.Size(55, 21);
                m_ps_label_param_list[i].TabIndex = 1;
                m_ps_label_param_list[i].Text = "param" + i.ToString();

                m_ps_label_seq_list.Add(new Label());
                m_ps_label_seq_list[i].AutoSize = true;
                m_ps_label_seq_list[i].Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                m_ps_label_seq_list[i].Location = new System.Drawing.Point(60, 155);
                m_ps_label_seq_list[i].Name = "label_seq" + i.ToString();
                m_ps_label_seq_list[i].Size = new System.Drawing.Size(55, 21);
                m_ps_label_seq_list[i].TabIndex = 1;
                m_ps_label_seq_list[i].Text = "seq" + i.ToString();

                this.panel1.Controls.Add(m_ps_pic_list[i]);
                this.panel1.Controls.Add(m_ps_label_param_list[i]);
                this.panel1.Controls.Add(m_ps_label_seq_list[i]);

                ((System.ComponentModel.ISupportInitialize)(this.m_ps_pic_list[i])).EndInit();
            }

            int pic_height = m_ps_pic_list[0].Height;
            int pic_width = m_ps_pic_list[0].Width;
            //设置图片控件的位置
            for (int i = 0; i < pic_row; i++)//Todo:改成m_pic_row
            {
                for (int j = 0; j < pic_col; j++)//Todo:改成m_pic_col
                {
                    m_ps_pic_list[j + i * pic_col].Left = 10 + j * width_gap + j * pic_width;//Todo:改成m_pic_col
                    m_ps_pic_list[j + i * pic_col].Top = 20 + i * height_gap + i * pic_height;//Todo:改成m_pic_col

                    m_ps_label_seq_list[j + i * pic_col].Left = init_label_seq_left + j * width_gap + j * pic_width;
                    m_ps_label_seq_list[j + i * pic_col].Top = init_label_seq_top + i * height_gap + i * pic_height;

                    m_ps_label_param_list[j + i * pic_col].Left = init_label_param_left + j * width_gap + j * pic_width;
                    m_ps_label_param_list[j + i * pic_col].Top = init_label_param_top + i * height_gap + i * pic_height;
                }
            }


        }

        //Todo: 增加定制化图片控件
        /// <summary>
        /// 定制大屏，显示200个图片或者100个图片
        /// </summary>
        /// <param name="width">图片控件宽度</param>
        /// <param name="height">图片控件高度</param>
        /// <param name="padding"></param>
        public void InitializeFullScreen(int pic_row = 4, int pic_col = 6, int width = 130, int height = 130, int padding = 5)
        {
            int pic_num = pic_row * pic_col;//Todo:改成 m_pic_row * m_pic_col
            int width_gap = 10;
            int height_gap = 40;

            int init_label_param_left = 45;
            int init_label_param_top = 125;

            int init_label_seq_left = 60;
            int init_label_seq_top = 155;

            //Todo:根据图片数量设置
            this.Width = 1400;
            this.panel1.Width = 1400;


            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BigScreen));

            if (m_fs_pic_list != null)
                m_fs_pic_list.Clear();

            if (m_fs_label_param_list != null)
                m_fs_label_param_list.Clear();

            if (m_fs_label_seq_list != null)
                m_fs_label_seq_list.Clear();

            m_fs_pic_list = new List<PictureBox>(pic_num);
            m_fs_label_param_list = new List<Label>(pic_num);
            m_fs_label_seq_list = new List<Label>(pic_num);

            for (int i = 0; i < pic_num; i++)
            {
                m_fs_pic_list.Add(new PictureBox());
                ((System.ComponentModel.ISupportInitialize)(this.m_fs_pic_list[i])).BeginInit();

                m_fs_pic_list[i].Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_test.Image")));

                m_fs_pic_list[i].Name = "pictureBox"+i.ToString();
                m_fs_pic_list[i].Padding = new System.Windows.Forms.Padding(5);
                m_fs_pic_list[i].Size = new System.Drawing.Size(width, height);
                m_fs_pic_list[i].SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
                m_fs_pic_list[i].TabIndex = 0;
                m_fs_pic_list[i].TabStop = false;

                m_fs_label_param_list.Add(new Label());
                m_fs_label_param_list[i].AutoSize = true;
                m_fs_label_param_list[i].Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                m_fs_label_param_list[i].Location = new System.Drawing.Point(45, 125);
                m_fs_label_param_list[i].Name = "label_fx"+i.ToString();
                m_fs_label_param_list[i].Size = new System.Drawing.Size(55, 21);
                m_fs_label_param_list[i].TabIndex = 1;
                m_fs_label_param_list[i].Text = "param"+i.ToString();

                m_fs_label_seq_list.Add(new Label());
                m_fs_label_seq_list[i].AutoSize = true;
                m_fs_label_seq_list[i].Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                m_fs_label_seq_list[i].Location = new System.Drawing.Point(60, 155);
                m_fs_label_seq_list[i].Name = "label_seq" + i.ToString();
                m_fs_label_seq_list[i].Size = new System.Drawing.Size(55, 21);
                m_fs_label_seq_list[i].TabIndex = 1;
                m_fs_label_seq_list[i].Text = "seq" + i.ToString();

                this.panel1.Controls.Add(m_fs_pic_list[i]);
                this.panel1.Controls.Add(m_fs_label_param_list[i]);
                this.panel1.Controls.Add(m_fs_label_seq_list[i]);

                ((System.ComponentModel.ISupportInitialize)(this.m_fs_pic_list[i])).EndInit();
            }

            int pic_height = m_fs_pic_list[0].Height;
            int pic_width = m_fs_pic_list[0].Width;
            //设置图片控件的位置
            for (int i = 0; i < pic_row; i++)//Todo:改成m_pic_row
            {
                for (int j = 0; j < pic_col; j++)//Todo:改成m_pic_col
                {
                    m_fs_pic_list[j + i * pic_col].Left = 10 + j * width_gap + j * pic_width;//Todo:改成m_pic_col
                    m_fs_pic_list[j + i * pic_col].Top = 20 + i * height_gap + i * pic_height;//Todo:改成m_pic_col

                    m_fs_label_seq_list[j + i * pic_col].Left = init_label_seq_left + j * width_gap + j * pic_width;
                    m_fs_label_seq_list[j + i * pic_col].Top = init_label_seq_top + i * height_gap + i * pic_height;

                    m_fs_label_param_list[j + i * pic_col].Left = init_label_param_left + j * width_gap + j * pic_width;
                    m_fs_label_param_list[j + i * pic_col].Top = init_label_param_top + i * height_gap + i * pic_height;
                }
            }


        }
        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;

        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;


        private System.Windows.Forms.Label label_param1;
        private System.Windows.Forms.Label label_fx1;
        private System.Windows.Forms.Label label_fx2;
        private System.Windows.Forms.Label label_fx3;
        private System.Windows.Forms.Label label_fx4;
        private System.Windows.Forms.Label label_fx5;
        private System.Windows.Forms.Label label_param2;
        private System.Windows.Forms.Label label_param3;
        private System.Windows.Forms.Label label_param4;
        private System.Windows.Forms.Label label_param5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_fx10;
        private System.Windows.Forms.Label label_fx9;
        private System.Windows.Forms.Label label_fx8;
        private System.Windows.Forms.Label label_fx7;
        private System.Windows.Forms.Label label_fx6;
        private System.Windows.Forms.Label label_param10;
        private System.Windows.Forms.Label label_param9;
        private System.Windows.Forms.Label label_param8;
        private System.Windows.Forms.Label label_param7;
        private System.Windows.Forms.Label label_param6;

        private PictureBox pictureBox15;
        private PictureBox pictureBox14;
        private PictureBox pictureBox13;
        private PictureBox pictureBox12;
        private PictureBox pictureBox11;
        private Label label_param15;
        private Label label_param14;
        private Label label_param13;
        private Label label_param12;
        private Label label_param11;
        private Label label_fx15;
        private Label label_fx14;
        private Label label_fx13;
        private Label label_fx12;
        private Label label_fx11;
        private PictureBox pictureBox20;
        private PictureBox pictureBox19;
        private PictureBox pictureBox18;
        private PictureBox pictureBox17;
        private PictureBox pictureBox16;
        private Label label_param20;
        private Label label_param19;
        private Label label_param18;
        private Label label_param17;
        private Label label_param16;
        private Label label_fx20;
        private Label label_fx19;
        private Label label_fx18;
        private Label label_fx17;
        private Label label_fx16;
    }
}