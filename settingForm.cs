using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSkin.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Xml;
using DSkin.Common;
using DSkin.Html.Adapters.Entities;
using System.Threading;

namespace DeskClock
{
    public partial class settingForm : DSkinForm
    {
        mainForm frm1 = null;
        public bool oneLineFlag=false;
        //mainForm mainfrm = new mainForm();
        public settingForm(mainForm f)
        {
            InitializeComponent();
            frm1= f;
            setTime.DateTime = frm1.TimeSet.ToDateTime();
           
            
        }
        
        private void settingCloseButton_MouseClick(object sender, MouseEventArgs e)
        {
            frm1.Titlelabel.Text = TextSetBox.Text;

            //让所有设置生效
          //  if (Autorunbox.Checked)
          //  {
          //      frm1.autorun = true;
          //  }
          //  else
          //  {
          //      frm1.autorun = false;
          //  }
            if (ShowText.Checked)
            {
                frm1.ShowText = true;
                frm1.Titlelabel.Visible = true;
            }
            else
            {
                frm1.ShowText= false;
                frm1.Titlelabel.Visible = false;
            }
            if (ColorSet1.Checked)
            {
                frm1.ChooseColor1 = true;
            }
            else
            {
                frm1.ChooseColor1 = false;
            }

           //label.Font = TextSetBox.Font;
            frm1.Titlelabel.Text = TextSetBox.Text;
            frm1.Titlelabel.ForeColor = TextSetBox.ForeColor;
               
          















            //保存所有设置


            // newconfig = autorunflag + "|" + this.Location.X + "|" + this.Location.Y + "|" + soft_color + "|" + soft_op + "|" + size_x + "|" + size_y + "|" + yiyanflag + "|" + menuflag + "|" + FontSize + "|" + Blow_Flag + "|" + font_color;
            // System.IO.File.WriteAllText(configpath, newconfig);


            this.Close();
            this.Dispose();
            FlushMemory();
        }
        [DllImport("kernel32.dll")]
        private static extern bool SetProcessWorkingSetSize(IntPtr process, int minSize, int maxSize);

        private static void FlushMemory()
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
            if (Environment.OSVersion.Platform == PlatformID.Win32NT)
            {
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
            }
        }

        private void exitbutton_MouseClick(object sender, MouseEventArgs e)
        {
            frm1.Close();
        }

        private void settingForm_Load(object sender, EventArgs e)
        {
            ResetAll();
            


            
        }

        private void FontButton_MouseClick(object sender, MouseEventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

           // fontDialog.ShowColor = true;//显示颜色选择
            fontDialog.Font = TextSetBox.Font;
            fontDialog.Color = TextSetBox.ForeColor;

            
            if (fontDialog.ShowDialog() == DialogResult.OK)//页面弹出判断是否点击确定按钮
            {
                TextSetBox.Font = fontDialog.Font;
                //.Font = fontDialog.Font;//字体
                TextSetBox.ForeColor = fontDialog.Color;//字体颜色



            }

        }

        private void NoButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
            this.Dispose();
            FlushMemory();
        }

        private void TextSetBox_TextChanged(object sender, EventArgs e)
        {
            
            ShowText.Checked=true;
        }

 


        private void ColorSet1_MouseClick(object sender, MouseEventArgs e)
        {
            
            F2DayBar.OuterColor = ColorTranslator.FromHtml("#60686f");
            F2DayBar.ProgressColor = ColorTranslator.FromHtml("#FFCC66");
            F2DayBar.InnerColor = ColorTranslator.FromHtml("#e0e0e0");

            F2HourBar.OuterColor = ColorTranslator.FromHtml("#60686f");
            F2HourBar.ProgressColor = ColorTranslator.FromHtml("#99ccff");
            F2HourBar.InnerColor = ColorTranslator.FromHtml("#e0e0e0");

            F2MinuteBar.OuterColor = ColorTranslator.FromHtml("#60686f");
            F2MinuteBar.ProgressColor = ColorTranslator.FromHtml("#bbffbb");
            F2MinuteBar.InnerColor = ColorTranslator.FromHtml("#e0e0e0");

            F2SecondBar.OuterColor = ColorTranslator.FromHtml("#60686f");
            F2SecondBar.ProgressColor = ColorTranslator.FromHtml("#ff9999");
            F2SecondBar.InnerColor = ColorTranslator.FromHtml("#e0e0e0");





        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Refresh();
            if (frm1.localtxt=="")
            {
                // 
                if (oneLineFlag==true)
                {
                     OneLineCheckbox.Checked = true;
                }
                else
                {
                    oneLine_Non.Checked = true;
                }
            }

        }

        private void OneLineSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }
        
        private void ChooseTxtButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (OneLineCheckbox.Checked)
            {
                oneLineFlag = true;
            }
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择文件";
            dialog.Filter = "文本文件(*.txt)|*.txt";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                frm1.localtxt = dialog.FileName;
                vertext.Text = frm1.localtxt;
            }
            else
            {
                frm1.localtxt = "";
                vertext.Text = frm1.localtxt;
            }
        }

        private void OneLineCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (OneLineCheckbox.Checked == true)
            {
                OneLineSet.Visible=true;
                

            }
            else
            {
                OneLineSet.Visible = false;
                oneLineFlag=false;
            }
            oneLineFlag = true;
        }




        private void NumButton_MouseClick(object sender, MouseEventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (Numtext1.Checked)
            {
                fontDialog.Font = TestNumBar.Font;
            }
            else{

                fontDialog.Font = TestNumBar.SecondaryFont;
            }
            

            // fontDialog.ShowColor = true;//显示颜色选择


            if (fontDialog.ShowDialog() == DialogResult.OK)//页面弹出判断是否点击确定按钮
            {
                if(Numtext1.Checked)
                {
                    TestNumBar.Font = fontDialog.Font;
                }
                else
                {
                    TestNumBar.SecondaryFont = fontDialog.Font;
                }
                
           



            }
        }

        private void ResetButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetAll();
        }
        private void ResetAll()
        {
            //读取参数
            
            TextSetBox.Text = frm1.Titlelabel.Text;
            TextSetBox.ForeColor = frm1.Titlelabel.ForeColor;
            TextSetBox.Font = frm1.Titlelabel.Font;
            setTime.DateTime = frm1.TimeSet.ToDateTime();
            TextSetBox.Text = frm1.TextSet;


            
          //  NumFont;
          //  NumColor;
          //  DayColor1;
          //  DayColor2;
          //  DayColor3;
          //  HoursColor1;
          //  HoursColor2;
          //  HoursColor3;
          //  MinutesColor1;
          //  MinutesColor2;
          //  MinutesColor3;
          //  SecondColor1;
          //  SecondColor2;
          //  SecondColor3;
          //  localtxt;
        }

        private void dSkinColorSelectPanel1_SelectedColorChanged(object sender, EventArgs e)
        {
            vertext.ForeColor = TitlecolorPicker.SelectedColor;
        }

        private void MiaoBian_ValueChanged(object sender, EventArgs e)
        {

        }

        private void oneLine_Non_CheckedChanged(object sender, EventArgs e)
        {
            if (oneLine_Non.Checked)
            {
                if (oneLineFlag==true)
                {
                oneLineFlag = false;
                }
            }else if (oneLineFlag==false)
            {

            }
            

        }

        private void HorizontalBar_ValueChanged(object sender, EventArgs e)
        {
            if (Numtext1.Checked)
            {
                //TestNumBar.TextMargin.All = HorizontalBar.Value;
            }
            else
            {

            }
        }
    }
}
