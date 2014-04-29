namespace bocd
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
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.主页HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.详情DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.日志LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textShenPi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textZiXin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textLuRu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFirst = new System.Windows.Forms.Label();
            this.labelSecond = new System.Windows.Forms.Label();
            this.labelNum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.主页HToolStripMenuItem,
            this.设置SToolStripMenuItem,
            this.详情DToolStripMenuItem,
            this.日志LToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(925, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // 主页HToolStripMenuItem
            // 
            this.主页HToolStripMenuItem.Name = "主页HToolStripMenuItem";
            this.主页HToolStripMenuItem.Size = new System.Drawing.Size(89, 29);
            this.主页HToolStripMenuItem.Text = "主页(&H)";
            this.主页HToolStripMenuItem.Click += new System.EventHandler(this.主页HToolStripMenuItem_Click);
            // 
            // 设置SToolStripMenuItem
            // 
            this.设置SToolStripMenuItem.Name = "设置SToolStripMenuItem";
            this.设置SToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.设置SToolStripMenuItem.Text = "设置(&S)";
            this.设置SToolStripMenuItem.Click += new System.EventHandler(this.设置SToolStripMenuItem_Click);
            // 
            // 详情DToolStripMenuItem
            // 
            this.详情DToolStripMenuItem.Name = "详情DToolStripMenuItem";
            this.详情DToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.详情DToolStripMenuItem.Text = "详情(&D)";
            this.详情DToolStripMenuItem.Click += new System.EventHandler(this.详情DToolStripMenuItem_Click);
            // 
            // 日志LToolStripMenuItem
            // 
            this.日志LToolStripMenuItem.Name = "日志LToolStripMenuItem";
            this.日志LToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.日志LToolStripMenuItem.Text = "日志(&L)";
            this.日志LToolStripMenuItem.Click += new System.EventHandler(this.日志LToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textShenPi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.buttonCompute);
            this.groupBox1.Controls.Add(this.textZiXin);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textLuRu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(14, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 390);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "存量";
            // 
            // textShenPi
            // 
            this.textShenPi.BackColor = System.Drawing.Color.AliceBlue;
            this.textShenPi.Location = new System.Drawing.Point(18, 273);
            this.textShenPi.Name = "textShenPi";
            this.textShenPi.Size = new System.Drawing.Size(157, 33);
            this.textShenPi.TabIndex = 3;
            this.textShenPi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textShenPi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(13, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "审批：";
            // 
            // textZiXin
            // 
            this.textZiXin.BackColor = System.Drawing.Color.AliceBlue;
            this.textZiXin.Location = new System.Drawing.Point(18, 179);
            this.textZiXin.Name = "textZiXin";
            this.textZiXin.Size = new System.Drawing.Size(157, 33);
            this.textZiXin.TabIndex = 2;
            this.textZiXin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textZiXin_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(13, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "资信调查：";
            // 
            // textLuRu
            // 
            this.textLuRu.BackColor = System.Drawing.Color.AliceBlue;
            this.textLuRu.Location = new System.Drawing.Point(18, 85);
            this.textLuRu.Name = "textLuRu";
            this.textLuRu.Size = new System.Drawing.Size(157, 33);
            this.textLuRu.TabIndex = 1;
            this.textLuRu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textLuRu_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "录入：";
            // 
            // labelFirst
            // 
            this.labelFirst.AutoSize = true;
            this.labelFirst.BackColor = System.Drawing.Color.Transparent;
            this.labelFirst.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFirst.Location = new System.Drawing.Point(351, 152);
            this.labelFirst.Name = "labelFirst";
            this.labelFirst.Size = new System.Drawing.Size(162, 38);
            this.labelFirst.TabIndex = 6;
            this.labelFirst.Text = "剩余件预计";
            // 
            // labelSecond
            // 
            this.labelSecond.AutoSize = true;
            this.labelSecond.BackColor = System.Drawing.Color.Transparent;
            this.labelSecond.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSecond.Location = new System.Drawing.Point(633, 152);
            this.labelSecond.Name = "labelSecond";
            this.labelSecond.Size = new System.Drawing.Size(104, 38);
            this.labelSecond.TabIndex = 7;
            this.labelSecond.Text = "天完成";
            // 
            // labelNum
            // 
            this.labelNum.AutoSize = true;
            this.labelNum.BackColor = System.Drawing.Color.Transparent;
            this.labelNum.Font = new System.Drawing.Font("微软雅黑", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelNum.ForeColor = System.Drawing.Color.Red;
            this.labelNum.Location = new System.Drawing.Point(515, 136);
            this.labelNum.Name = "labelNum";
            this.labelNum.Size = new System.Drawing.Size(111, 62);
            this.labelNum.TabIndex = 8;
            this.labelNum.Text = "500";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(616, 358);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(295, 77);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonCompute
            // 
            this.buttonCompute.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonCompute.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCompute.Location = new System.Drawing.Point(43, 339);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(115, 37);
            this.buttonCompute.TabIndex = 4;
            this.buttonCompute.Text = "推算";
            this.buttonCompute.UseVisualStyleBackColor = false;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(234, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(679, 294);
            this.textBox1.TabIndex = 10;
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonSaveLog.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonSaveLog.Location = new System.Drawing.Point(274, 375);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(115, 37);
            this.buttonSaveLog.TabIndex = 11;
            this.buttonSaveLog.Text = "导出";
            this.buttonSaveLog.UseVisualStyleBackColor = false;
            this.buttonSaveLog.Click += new System.EventHandler(this.buttonSaveLog_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonClear.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonClear.Location = new System.Drawing.Point(476, 375);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(115, 37);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "清空";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::bocd.Properties.Resources._161931nc98fpnndghvvdhg;
            this.ClientSize = new System.Drawing.Size(925, 438);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSaveLog);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNum);
            this.Controls.Add(this.labelSecond);
            this.Controls.Add(this.labelFirst);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "成都银行信用卡中心";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem 主页HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 详情DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 日志LToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textShenPi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textZiXin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLuRu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFirst;
        private System.Windows.Forms.Label labelSecond;
        private System.Windows.Forms.Label labelNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonCompute;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSaveLog;
        private System.Windows.Forms.Button buttonClear;

    }
}

