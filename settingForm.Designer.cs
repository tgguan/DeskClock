namespace DeskClock
{
    partial class settingForm
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
            this.settingCloseButton = new DSkin.Controls.DSkinButton();
            this.SuspendLayout();
            // 
            // settingCloseButton
            // 
            this.settingCloseButton.ButtonBorderWidth = 1;
            this.settingCloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.settingCloseButton.HoverColor = System.Drawing.Color.Empty;
            this.settingCloseButton.HoverImage = null;
            this.settingCloseButton.Location = new System.Drawing.Point(604, 343);
            this.settingCloseButton.Name = "settingCloseButton";
            this.settingCloseButton.NormalImage = null;
            this.settingCloseButton.PressColor = System.Drawing.Color.Empty;
            this.settingCloseButton.PressedImage = null;
            this.settingCloseButton.Radius = 10;
            this.settingCloseButton.ShowButtonBorder = true;
            this.settingCloseButton.Size = new System.Drawing.Size(100, 40);
            this.settingCloseButton.TabIndex = 0;
            this.settingCloseButton.Text = "取消";
            this.settingCloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.settingCloseButton.TextPadding = 0;
            this.settingCloseButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.settingCloseButton_MouseClick);
            // 
            // settingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.settingCloseButton);
            this.DrawIcon = false;
            this.EX_COMPOSITED = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "settingForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private DSkin.Controls.DSkinButton settingCloseButton;
    }
}