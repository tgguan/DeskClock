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



namespace DeskClock
{
    public partial class settingForm : DSkinForm
    {
        public settingForm()
        {
            InitializeComponent();
        }

        private void settingCloseButton_MouseClick(object sender, MouseEventArgs e)
        {
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
    }
}
