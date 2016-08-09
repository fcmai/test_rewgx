namespace WindowsFormRegx
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
            this.textBox_BCMask = new System.Windows.Forms.TextBox();
            this.textBox_BC2Check = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_BCMask
            // 
            this.textBox_BCMask.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_BCMask.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox_BCMask.Location = new System.Drawing.Point(120, 28);
            this.textBox_BCMask.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_BCMask.Name = "textBox_BCMask";
            this.textBox_BCMask.Size = new System.Drawing.Size(758, 28);
            this.textBox_BCMask.TabIndex = 1;
            this.textBox_BCMask.Text = "12345?????12345";
            // 
            // textBox_BC2Check
            // 
            this.textBox_BC2Check.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_BC2Check.ForeColor = System.Drawing.Color.Navy;
            this.textBox_BC2Check.Location = new System.Drawing.Point(120, 148);
            this.textBox_BC2Check.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox_BC2Check.Name = "textBox_BC2Check";
            this.textBox_BC2Check.Size = new System.Drawing.Size(758, 28);
            this.textBox_BC2Check.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCheck.Location = new System.Drawing.Point(116, 211);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(172, 83);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "检查条码字符串";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "BC Mask";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "待检BC";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(706, 211);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(172, 83);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "关闭";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("幼圆", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.textBox1.Location = new System.Drawing.Point(120, 82);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(758, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "12345?????12345";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "待检BC";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(909, 324);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.textBox_BC2Check);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_BCMask);
            this.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "regx 测试条码匹配";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_BCMask;
        private System.Windows.Forms.TextBox textBox_BC2Check;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;

    }
}

