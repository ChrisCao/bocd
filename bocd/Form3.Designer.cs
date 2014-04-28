namespace bocd
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.labelLine1 = new System.Windows.Forms.Label();
            this.labelLine2 = new System.Windows.Forms.Label();
            this.buttonCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLine1
            // 
            this.labelLine1.AutoSize = true;
            this.labelLine1.BackColor = System.Drawing.Color.Transparent;
            this.labelLine1.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLine1.ForeColor = System.Drawing.Color.Black;
            this.labelLine1.Location = new System.Drawing.Point(22, 36);
            this.labelLine1.Name = "labelLine1";
            this.labelLine1.Size = new System.Drawing.Size(382, 38);
            this.labelLine1.TabIndex = 7;
            this.labelLine1.Text = "人数和每日完成数不能为0！";
            // 
            // labelLine2
            // 
            this.labelLine2.AutoSize = true;
            this.labelLine2.BackColor = System.Drawing.Color.Transparent;
            this.labelLine2.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLine2.ForeColor = System.Drawing.Color.Black;
            this.labelLine2.Location = new System.Drawing.Point(31, 86);
            this.labelLine2.Name = "labelLine2";
            this.labelLine2.Size = new System.Drawing.Size(365, 38);
            this.labelLine2.TabIndex = 8;
            this.labelLine2.Text = "请设置人数和每日完成数！";
            // 
            // buttonCompute
            // 
            this.buttonCompute.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonCompute.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonCompute.Location = new System.Drawing.Point(139, 153);
            this.buttonCompute.Name = "buttonCompute";
            this.buttonCompute.Size = new System.Drawing.Size(115, 37);
            this.buttonCompute.TabIndex = 9;
            this.buttonCompute.Text = "确定";
            this.buttonCompute.UseVisualStyleBackColor = false;
            this.buttonCompute.Click += new System.EventHandler(this.buttonCompute_Click);
            // 
            // Form3
            // 
            this.AcceptButton = this.buttonCompute;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::bocd.Properties.Resources.未标题_21;
            this.ClientSize = new System.Drawing.Size(427, 217);
            this.Controls.Add(this.buttonCompute);
            this.Controls.Add(this.labelLine2);
            this.Controls.Add(this.labelLine1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "错误";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLine1;
        private System.Windows.Forms.Label labelLine2;
        private System.Windows.Forms.Button buttonCompute;
    }
}