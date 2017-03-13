namespace _1032002
{
    partial class Ball
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.tipClose = new System.Windows.Forms.PictureBox();
            this.tipShow = new System.Windows.Forms.PictureBox();
            this.picTip = new System.Windows.Forms.PictureBox();
            this.pictimer = new System.Windows.Forms.PictureBox();
            this.picbar = new System.Windows.Forms.PictureBox();
            this.ball1 = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tipClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(601, 9);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(32, 37);
            this.lblTimer.TabIndex = 19;
            this.lblTimer.Text = "1";
            // 
            // tipClose
            // 
            this.tipClose.BackColor = System.Drawing.Color.Transparent;
            this.tipClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tipClose.Image = global::_1032002.Resource1.tipclose;
            this.tipClose.Location = new System.Drawing.Point(639, -5);
            this.tipClose.Name = "tipClose";
            this.tipClose.Size = new System.Drawing.Size(78, 52);
            this.tipClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tipClose.TabIndex = 14;
            this.tipClose.TabStop = false;
            this.tipClose.Click += new System.EventHandler(this.tip_Click);
            // 
            // tipShow
            // 
            this.tipShow.BackColor = System.Drawing.Color.Transparent;
            this.tipShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tipShow.Image = global::_1032002.Resource1.tipshow;
            this.tipShow.Location = new System.Drawing.Point(639, -5);
            this.tipShow.Name = "tipShow";
            this.tipShow.Size = new System.Drawing.Size(78, 52);
            this.tipShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tipShow.TabIndex = 13;
            this.tipShow.TabStop = false;
            this.tipShow.Visible = false;
            this.tipShow.Click += new System.EventHandler(this.tip_Click);
            // 
            // picTip
            // 
            this.picTip.BackColor = System.Drawing.Color.Transparent;
            this.picTip.Image = global::_1032002.Resource1.balltip;
            this.picTip.Location = new System.Drawing.Point(0, -2);
            this.picTip.Name = "picTip";
            this.picTip.Size = new System.Drawing.Size(726, 410);
            this.picTip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTip.TabIndex = 20;
            this.picTip.TabStop = false;
            this.picTip.DoubleClick += new System.EventHandler(this.tip_Click);
            // 
            // pictimer
            // 
            this.pictimer.BackColor = System.Drawing.Color.Transparent;
            this.pictimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictimer.Image = global::_1032002.Resource1.timer;
            this.pictimer.Location = new System.Drawing.Point(534, -5);
            this.pictimer.Name = "pictimer";
            this.pictimer.Size = new System.Drawing.Size(78, 52);
            this.pictimer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictimer.TabIndex = 18;
            this.pictimer.TabStop = false;
            // 
            // picbar
            // 
            this.picbar.BackColor = System.Drawing.Color.Transparent;
            this.picbar.Image = global::_1032002.Resource1.bar;
            this.picbar.Location = new System.Drawing.Point(283, 365);
            this.picbar.Name = "picbar";
            this.picbar.Size = new System.Drawing.Size(150, 30);
            this.picbar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picbar.TabIndex = 17;
            this.picbar.TabStop = false;
            // 
            // ball1
            // 
            this.ball1.BackColor = System.Drawing.Color.Transparent;
            this.ball1.Image = global::_1032002.Resource1.ball2;
            this.ball1.Location = new System.Drawing.Point(-2, -5);
            this.ball1.Name = "ball1";
            this.ball1.Size = new System.Drawing.Size(115, 135);
            this.ball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ball1.TabIndex = 16;
            this.ball1.TabStop = false;
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Image = global::_1032002.Resource1.icon_group_2x;
            this.picExit.Location = new System.Drawing.Point(0, -2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(70, 50);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 21;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(563, 383);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "點選米老鼠收起提示";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Ball
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 407);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.tipClose);
            this.Controls.Add(this.tipShow);
            this.Controls.Add(this.picTip);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.pictimer);
            this.Controls.Add(this.picbar);
            this.Controls.Add(this.ball1);
            this.MaximumSize = new System.Drawing.Size(735, 454);
            this.MinimumSize = new System.Drawing.Size(735, 454);
            this.Name = "Ball";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatMao";
            this.Load += new System.EventHandler(this.Ball_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Ball_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.tipClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox tipShow;
        private System.Windows.Forms.PictureBox tipClose;
        private System.Windows.Forms.PictureBox ball1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox picbar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox pictimer;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.PictureBox picTip;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label1;
    }
}