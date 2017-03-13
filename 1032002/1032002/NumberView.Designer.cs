namespace _1032002.Resources
{
    partial class NumberView
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
            this.tbxNum = new System.Windows.Forms.TextBox();
            this.picCheck = new System.Windows.Forms.PictureBox();
            this.lblAns = new System.Windows.Forms.Label();
            this.tipShow = new System.Windows.Forms.PictureBox();
            this.tipClose = new System.Windows.Forms.PictureBox();
            this.picTip = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNum
            // 
            this.tbxNum.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbxNum.Location = new System.Drawing.Point(235, 292);
            this.tbxNum.MaxLength = 4;
            this.tbxNum.Name = "tbxNum";
            this.tbxNum.Size = new System.Drawing.Size(171, 47);
            this.tbxNum.TabIndex = 0;
            this.tbxNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxNum.TextChanged += new System.EventHandler(this.tbxNum_TextChanged);
            // 
            // picCheck
            // 
            this.picCheck.BackColor = System.Drawing.Color.Transparent;
            this.picCheck.Image = global::_1032002.Resource1.check;
            this.picCheck.Location = new System.Drawing.Point(421, 284);
            this.picCheck.Name = "picCheck";
            this.picCheck.Size = new System.Drawing.Size(60, 60);
            this.picCheck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCheck.TabIndex = 1;
            this.picCheck.TabStop = false;
            this.picCheck.Click += new System.EventHandler(this.picCheck_Click);
            // 
            // lblAns
            // 
            this.lblAns.AutoSize = true;
            this.lblAns.BackColor = System.Drawing.Color.Transparent;
            this.lblAns.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAns.Location = new System.Drawing.Point(283, 178);
            this.lblAns.Name = "lblAns";
            this.lblAns.Size = new System.Drawing.Size(151, 50);
            this.lblAns.TabIndex = 7;
            this.lblAns.Text = "0 A 0 B";
            this.lblAns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // picTip
            // 
            this.picTip.BackColor = System.Drawing.Color.Transparent;
            this.picTip.Image = global::_1032002.Resource1.NumberTip;
            this.picTip.Location = new System.Drawing.Point(-5, -2);
            this.picTip.Name = "picTip";
            this.picTip.Size = new System.Drawing.Size(726, 410);
            this.picTip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTip.TabIndex = 15;
            this.picTip.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(76, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Image = global::_1032002.Resource1.icon_group_2x;
            this.picExit.Location = new System.Drawing.Point(0, -2);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(70, 50);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 17;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(563, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "點選米老鼠收起提示";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NumberView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::_1032002.Resource1.Numberback;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 407);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipShow);
            this.Controls.Add(this.tipClose);
            this.Controls.Add(this.picTip);
            this.Controls.Add(this.lblAns);
            this.Controls.Add(this.picCheck);
            this.Controls.Add(this.tbxNum);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(735, 454);
            this.MinimumSize = new System.Drawing.Size(735, 454);
            this.Name = "NumberView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CatMao";
            this.Load += new System.EventHandler(this.NumberView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNum;
        private System.Windows.Forms.PictureBox picCheck;
        private System.Windows.Forms.Label lblAns;
        private System.Windows.Forms.PictureBox tipShow;
        private System.Windows.Forms.PictureBox tipClose;
        private System.Windows.Forms.PictureBox picTip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Label label2;
    }
}