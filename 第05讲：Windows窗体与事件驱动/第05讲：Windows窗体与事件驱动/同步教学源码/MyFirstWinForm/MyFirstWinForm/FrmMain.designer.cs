namespace MyFirstWinForm
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btn = new System.Windows.Forms.Button();
            this.btnAndy = new System.Windows.Forms.Button();
            this.btnCarry = new System.Windows.Forms.Button();
            this.btnCoco = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(12, 43);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(110, 23);
            this.btn.TabIndex = 0;
            this.btn.Text = "测试按钮事件";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnAndy
            // 
            this.btnAndy.Location = new System.Drawing.Point(142, 43);
            this.btnAndy.Name = "btnAndy";
            this.btnAndy.Size = new System.Drawing.Size(75, 23);
            this.btnAndy.TabIndex = 1;
            this.btnAndy.Text = "Andy老师";
            this.btnAndy.UseVisualStyleBackColor = true;
            // 
            // btnCarry
            // 
            this.btnCarry.Location = new System.Drawing.Point(223, 43);
            this.btnCarry.Name = "btnCarry";
            this.btnCarry.Size = new System.Drawing.Size(75, 23);
            this.btnCarry.TabIndex = 1;
            this.btnCarry.Text = "Carry老师";
            this.btnCarry.UseVisualStyleBackColor = true;
            // 
            // btnCoco
            // 
            this.btnCoco.Location = new System.Drawing.Point(304, 43);
            this.btnCoco.Name = "btnCoco";
            this.btnCoco.Size = new System.Drawing.Size(75, 23);
            this.btnCoco.TabIndex = 1;
            this.btnCoco.Text = "Coco老师";
            this.btnCoco.UseVisualStyleBackColor = true;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(13, 78);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(109, 23);
            this.btnTest.TabIndex = 2;
            this.btnTest.Text = "测试对话框";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 113);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnCoco);
            this.Controls.Add(this.btnCarry);
            this.Controls.Add(this.btnAndy);
            this.Controls.Add(this.btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "管理信息系统";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnAndy;
        private System.Windows.Forms.Button btnCarry;
        private System.Windows.Forms.Button btnCoco;
        private System.Windows.Forms.Button btnTest;
    }
}

