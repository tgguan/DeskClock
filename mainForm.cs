using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using DSkin.Common;
using DSkin.Forms;

using System.IO;
using DSkin.Controls;
using DSkin.Html.Adapters.Entities;

namespace DeskClock
{
    public partial class mainForm : DSkinForm
    {

        #region  //所有公共变量声明
        public string path = System.Environment.CurrentDirectory;
        public string configpath;
        public string softpath;

        public bool autorun = false;//开机启动
        public bool ShowText = true;//显示文字
        public bool ChooseColor1 = false;
        public bool ChooseColor2 = false;
        public bool ShowSecText = true;
        public int tempcount = 0; //右键计数器
        public string TimeSet= "2023/01/22 00:00:00"; //设定时间
        public string TextSet= "距离2023年春节";//设定文字
        public string TextFont;
        public string TextColor;
        public string NumFont;
        public string NumColor;
        public string DayColor1;
        public string DayColor2;
        public string DayColor3;
        public string HoursColor1;
        public string HoursColor2;
        public string HoursColor3;
        public string MinutesColor1;
        public string MinutesColor2;
        public string MinutesColor3;
        public string SecondColor1;
        public string SecondColor2;
        public string SecondColor3;
        public string localtxt;



        public int tempnum = 0; //右键计数器


        #endregion

        //



        public mainForm()
        {
            InitializeComponent();
            
            configpath = path + @"\config.ini";
            Checkconfigini();



        }
        //public string exepath = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        #region 配置文件初始化
        private void Checkconfigini()
        {
            if (!File.Exists(configpath))
            {
                
                try
                {
                    //初始化参数
                   // newconfig = autorunflag + "|" + this.Location.X + "|" + this.Location.Y + "|" + soft_color + "|" + soft_op + "|" + size_x + "|" + size_y + "|" + yiyanflag + "|" + menuflag + "|" + FontSize + "|" + Blow_Flag + "|" + font_color;
                   // System.IO.File.WriteAllText(configpath, newconfig);

                }
                catch (Exception)
                {

                    MessageBox.Show("配置文件损坏或丢失，按确定键重置配置文件");
                    


                }
            }
            else
            {
                try
                {
                 

                }
                catch (Exception)
                {
                    MessageBox.Show("配置文件生成失败，程序无法运行");
                    this.Close();
                    throw;
                }
            }
        }

        private void Setconfig()//设置配置文件
        {

            //newconfig = autorunflag + "|" + soft_x + "|" + soft_y + "|" + soft_color + "|" + soft_op + "|" + size_x + "|" + size_y + "|" + yiyanflag + "|" + menuflag + "|" + FontSize + "|" + Blow_Flag + "|" + font_color;
            try
            {
                //System.IO.File.WriteAllText(configpath, newconfig);
            }
            catch
            {

            }
        }
        #endregion

        #region 窗体移动代码
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
       



        

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }
        #endregion
        private void Opensetting(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

            } //左键

            else if (e.Button == MouseButtons.Right)
            {
                if (tempnum>=2)
                {
                    tempnum = 0; 
                    settingForm f = new settingForm(this);
                    
                    f.Show();
                }
                else
                {
                    tempnum++;
                }
            } //右键

            else
            {

            } //滚轮
        }
        


        
    }
}
