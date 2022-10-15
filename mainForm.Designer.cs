namespace DeskClock
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dSkinPanel1 = new DSkin.Controls.DSkinPanel();
            this.SecendBar = new CircularProgressBar.CircularProgressBar();
            this.MinuteBar = new CircularProgressBar.CircularProgressBar();
            this.HourBar = new CircularProgressBar.CircularProgressBar();
            this.DayBar = new CircularProgressBar.CircularProgressBar();
            this.Titlelabel = new DSkin.Controls.DSkinLabel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dSkinPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSkinPanel1
            // 
            this.dSkinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.dSkinPanel1.Controls.Add(this.SecendBar);
            this.dSkinPanel1.Controls.Add(this.MinuteBar);
            this.dSkinPanel1.Controls.Add(this.HourBar);
            this.dSkinPanel1.Controls.Add(this.DayBar);
            this.dSkinPanel1.Location = new System.Drawing.Point(4, 147);
            this.dSkinPanel1.Name = "dSkinPanel1";
            this.dSkinPanel1.RightBottom = ((System.Drawing.Image)(resources.GetObject("dSkinPanel1.RightBottom")));
            this.dSkinPanel1.Size = new System.Drawing.Size(666, 158);
            this.dSkinPanel1.TabIndex = 1;
            this.dSkinPanel1.Text = "dSkinPanel1";
            // 
            // SecendBar
            // 
            this.SecendBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.SecendBar.AnimationSpeed = 500;
            this.SecendBar.BackColor = System.Drawing.Color.Transparent;
            this.SecendBar.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SecendBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SecendBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SecendBar.InnerMargin = 2;
            this.SecendBar.InnerWidth = -1;
            this.SecendBar.Location = new System.Drawing.Point(514, 3);
            this.SecendBar.MarqueeAnimationSpeed = 2000;
            this.SecendBar.Maximum = 600;
            this.SecendBar.Name = "SecendBar";
            this.SecendBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(104)))), ((int)(((byte)(111)))));
            this.SecendBar.OuterMargin = -25;
            this.SecendBar.OuterWidth = 25;
            this.SecendBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.SecendBar.ProgressWidth = 15;
            this.SecendBar.SecondaryFont = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SecendBar.Size = new System.Drawing.Size(148, 144);
            this.SecendBar.StartAngle = 270;
            this.SecendBar.Step = 1;
            this.SecendBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SecendBar.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.SecendBar.SubscriptText = "";
            this.SecendBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.SecendBar.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.SecendBar.SuperscriptText = "";
            this.SecendBar.TabIndex = 3;
            this.SecendBar.Text = "0";
            this.SecendBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.SecendBar.Value = 450;
            this.SecendBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opensetting);
            this.SecendBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // MinuteBar
            // 
            this.MinuteBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.MinuteBar.AnimationSpeed = 500;
            this.MinuteBar.BackColor = System.Drawing.Color.Transparent;
            this.MinuteBar.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinuteBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinuteBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MinuteBar.InnerMargin = 2;
            this.MinuteBar.InnerWidth = -1;
            this.MinuteBar.Location = new System.Drawing.Point(341, 3);
            this.MinuteBar.MarqueeAnimationSpeed = 2000;
            this.MinuteBar.Maximum = 600;
            this.MinuteBar.Name = "MinuteBar";
            this.MinuteBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(104)))), ((int)(((byte)(111)))));
            this.MinuteBar.OuterMargin = -25;
            this.MinuteBar.OuterWidth = 25;
            this.MinuteBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(255)))), ((int)(((byte)(187)))));
            this.MinuteBar.ProgressWidth = 15;
            this.MinuteBar.SecondaryFont = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MinuteBar.Size = new System.Drawing.Size(148, 144);
            this.MinuteBar.StartAngle = 270;
            this.MinuteBar.Step = 1;
            this.MinuteBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.MinuteBar.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.MinuteBar.SubscriptText = "";
            this.MinuteBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.MinuteBar.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.MinuteBar.SuperscriptText = "";
            this.MinuteBar.TabIndex = 2;
            this.MinuteBar.Text = "0";
            this.MinuteBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.MinuteBar.Value = 450;
            this.MinuteBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opensetting);
            this.MinuteBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // HourBar
            // 
            this.HourBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.HourBar.AnimationSpeed = 500;
            this.HourBar.BackColor = System.Drawing.Color.Transparent;
            this.HourBar.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HourBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HourBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.HourBar.InnerMargin = 2;
            this.HourBar.InnerWidth = -1;
            this.HourBar.Location = new System.Drawing.Point(170, 3);
            this.HourBar.MarqueeAnimationSpeed = 2000;
            this.HourBar.Maximum = 600;
            this.HourBar.Name = "HourBar";
            this.HourBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(104)))), ((int)(((byte)(111)))));
            this.HourBar.OuterMargin = -25;
            this.HourBar.OuterWidth = 25;
            this.HourBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.HourBar.ProgressWidth = 15;
            this.HourBar.SecondaryFont = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HourBar.Size = new System.Drawing.Size(148, 144);
            this.HourBar.StartAngle = 270;
            this.HourBar.Step = 1;
            this.HourBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.HourBar.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.HourBar.SubscriptText = "";
            this.HourBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.HourBar.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.HourBar.SuperscriptText = "";
            this.HourBar.TabIndex = 1;
            this.HourBar.Text = "0";
            this.HourBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.HourBar.Value = 450;
            this.HourBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opensetting);
            this.HourBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // DayBar
            // 
            this.DayBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.DayBar.AnimationSpeed = 500;
            this.DayBar.BackColor = System.Drawing.Color.Transparent;
            this.DayBar.Font = new System.Drawing.Font("宋体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DayBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DayBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DayBar.InnerMargin = 2;
            this.DayBar.InnerWidth = -1;
            this.DayBar.Location = new System.Drawing.Point(3, 3);
            this.DayBar.MarqueeAnimationSpeed = 2000;
            this.DayBar.Maximum = 600;
            this.DayBar.Name = "DayBar";
            this.DayBar.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(104)))), ((int)(((byte)(111)))));
            this.DayBar.OuterMargin = -25;
            this.DayBar.OuterWidth = 25;
            this.DayBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(102)))));
            this.DayBar.ProgressWidth = 15;
            this.DayBar.SecondaryFont = new System.Drawing.Font("宋体", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.DayBar.Size = new System.Drawing.Size(148, 144);
            this.DayBar.StartAngle = 270;
            this.DayBar.Step = 1;
            this.DayBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.DayBar.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.DayBar.SubscriptText = "";
            this.DayBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.DayBar.SuperscriptMargin = new System.Windows.Forms.Padding(0);
            this.DayBar.SuperscriptText = "";
            this.DayBar.TabIndex = 0;
            this.DayBar.Text = "0";
            this.DayBar.TextMargin = new System.Windows.Forms.Padding(0);
            this.DayBar.Value = 450;
            this.DayBar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.opensetting);
            this.DayBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MouseMove);
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = false;
            this.Titlelabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titlelabel.Font = new System.Drawing.Font("幼圆", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Titlelabel.Location = new System.Drawing.Point(4, 34);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(664, 59);
            this.Titlelabel.TabIndex = 2;
            this.Titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(672, 307);
            this.Controls.Add(this.Titlelabel);
            this.Controls.Add(this.dSkinPanel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.ShadowColor = System.Drawing.Color.Transparent;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ShowSystemButtons = false;
            this.Text = "";
            this.dSkinPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private DSkin.Controls.DSkinPanel dSkinPanel1;
        public CircularProgressBar.CircularProgressBar DayBar;
        public CircularProgressBar.CircularProgressBar SecendBar;
        public CircularProgressBar.CircularProgressBar MinuteBar;
        public CircularProgressBar.CircularProgressBar HourBar;
        public DSkin.Controls.DSkinLabel Titlelabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

