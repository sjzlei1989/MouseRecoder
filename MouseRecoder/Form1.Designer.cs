namespace MouseRecoder
{
    partial class Form1
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
            if(disposing && (components != null)) {
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
            this.label_leftClickCount = new System.Windows.Forms.Label();
            this.label_rightClickCount = new System.Windows.Forms.Label();
            this.label_middleClickCount = new System.Windows.Forms.Label();
            this.label_leftClick_display = new System.Windows.Forms.Label();
            this.label_rightClick_display = new System.Windows.Forms.Label();
            this.label_middleClick_display = new System.Windows.Forms.Label();
            this.mousePos = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.opacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_leftClickCount
            // 
            this.label_leftClickCount.AutoSize = true;
            this.label_leftClickCount.Location = new System.Drawing.Point(43, 42);
            this.label_leftClickCount.Name = "label_leftClickCount";
            this.label_leftClickCount.Size = new System.Drawing.Size(77, 12);
            this.label_leftClickCount.TabIndex = 0;
            this.label_leftClickCount.Text = "左键点击次数";
            // 
            // label_rightClickCount
            // 
            this.label_rightClickCount.AutoSize = true;
            this.label_rightClickCount.Location = new System.Drawing.Point(43, 78);
            this.label_rightClickCount.Name = "label_rightClickCount";
            this.label_rightClickCount.Size = new System.Drawing.Size(77, 12);
            this.label_rightClickCount.TabIndex = 1;
            this.label_rightClickCount.Text = "右键点击次数";
            // 
            // label_middleClickCount
            // 
            this.label_middleClickCount.AutoSize = true;
            this.label_middleClickCount.Location = new System.Drawing.Point(43, 117);
            this.label_middleClickCount.Name = "label_middleClickCount";
            this.label_middleClickCount.Size = new System.Drawing.Size(77, 12);
            this.label_middleClickCount.TabIndex = 2;
            this.label_middleClickCount.Text = "中键点击次数";
            // 
            // label_leftClick_display
            // 
            this.label_leftClick_display.AutoSize = true;
            this.label_leftClick_display.Location = new System.Drawing.Point(144, 42);
            this.label_leftClick_display.Name = "label_leftClick_display";
            this.label_leftClick_display.Size = new System.Drawing.Size(11, 12);
            this.label_leftClick_display.TabIndex = 3;
            this.label_leftClick_display.Text = "0";
            // 
            // label_rightClick_display
            // 
            this.label_rightClick_display.AutoSize = true;
            this.label_rightClick_display.Location = new System.Drawing.Point(144, 78);
            this.label_rightClick_display.Name = "label_rightClick_display";
            this.label_rightClick_display.Size = new System.Drawing.Size(11, 12);
            this.label_rightClick_display.TabIndex = 4;
            this.label_rightClick_display.Text = "0";
            // 
            // label_middleClick_display
            // 
            this.label_middleClick_display.AutoSize = true;
            this.label_middleClick_display.Location = new System.Drawing.Point(144, 117);
            this.label_middleClick_display.Name = "label_middleClick_display";
            this.label_middleClick_display.Size = new System.Drawing.Size(11, 12);
            this.label_middleClick_display.TabIndex = 5;
            this.label_middleClick_display.Text = "0";
            // 
            // mousePos
            // 
            this.mousePos.AutoSize = true;
            this.mousePos.Location = new System.Drawing.Point(45, 179);
            this.mousePos.Name = "mousePos";
            this.mousePos.Size = new System.Drawing.Size(77, 12);
            this.mousePos.TabIndex = 6;
            this.mousePos.Text = "显示鼠标位置";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(71, 213);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(140, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // opacity
            // 
            this.opacity.AutoSize = true;
            this.opacity.Location = new System.Drawing.Point(25, 213);
            this.opacity.Name = "opacity";
            this.opacity.Size = new System.Drawing.Size(41, 12);
            this.opacity.TabIndex = 8;
            this.opacity.Text = "透明度";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 541);
            this.Controls.Add(this.opacity);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.mousePos);
            this.Controls.Add(this.label_middleClick_display);
            this.Controls.Add(this.label_rightClick_display);
            this.Controls.Add(this.label_leftClick_display);
            this.Controls.Add(this.label_middleClickCount);
            this.Controls.Add(this.label_rightClickCount);
            this.Controls.Add(this.label_leftClickCount);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.Text = "爱咋咋地";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_leftClickCount;
        private System.Windows.Forms.Label label_rightClickCount;
        private System.Windows.Forms.Label label_middleClickCount;
        private System.Windows.Forms.Label label_leftClick_display;
        private System.Windows.Forms.Label label_rightClick_display;
        private System.Windows.Forms.Label label_middleClick_display;
        private System.Windows.Forms.Label mousePos;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label opacity;
    }
}

