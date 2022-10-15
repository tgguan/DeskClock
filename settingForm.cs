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

namespace DeskClock
{
    public partial class settingForm : DSkinForm
    {
        mainForm frm1 = null;
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
            //读取参数
            

        }

        private void FontButton_MouseClick(object sender, MouseEventArgs e)
        {
          
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

        private void ShowText_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowText.Checked == true)
            {
                frm1.Titlelabel.Visible = true;

            }
            else
            {
                frm1.Titlelabel.Visible = false;
            }
        }

        private void SetNumFontButton_MouseClick(object sender, MouseEventArgs e)
        {
            FontDialog fontDialog = new FontDialog();

            fontDialog.ShowColor = true;//显示颜色选择
            fontDialog.Font = frm1.DayBar.Font;
            fontDialog.Color = frm1.DayBar.ForeColor;
           



            if (fontDialog.ShowDialog() == DialogResult.OK)//页面弹出判断是否点击确定按钮
            {
                frm1.DayBar.Font = fontDialog.Font;
                //.Font = fontDialog.Font;//字体
                frm1.DayBar.ForeColor = fontDialog.Color;//字体颜色


                
            }
        }
    }
}
