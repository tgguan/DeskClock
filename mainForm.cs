using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DSkin.Forms;

namespace DeskClock
{
    public partial class mainForm : DSkinForm
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void god_button_MouseClick(object sender, MouseEventArgs e)
        {
            settingForm f = new settingForm();
            f.ShowDialog();
        }
    }
}
