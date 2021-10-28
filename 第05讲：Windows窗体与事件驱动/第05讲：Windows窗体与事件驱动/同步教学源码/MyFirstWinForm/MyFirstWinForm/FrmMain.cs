using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyFirstWinForm
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.btnAndy.Click += new System.EventHandler(this.btn_Click);
            this.btnCarry.Click += new System.EventHandler(this.btn_Click);
            this.btnCoco.Click += new System.EventHandler(this.btn_Click);
        }
        private void btn_Click(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            MessageBox.Show("大家好！我是：" + text);
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            MessageBox.Show("请输入学员姓名！");
            MessageBox.Show("请输入学员姓名！", "验证提示");
            MessageBox.Show("请输入学员姓名！", "验证提示", MessageBoxButtons.OKCancel);
            MessageBox.Show("请输入学员姓名！", "验证提示", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Information);


            DialogResult result = MessageBox.Show("请输入学员姓名！", "验证提示",
                MessageBoxButtons.OKCancel,
                  MessageBoxIcon.Error);
            if (result == DialogResult.OK)//用户点击了确定按钮
            {
                MessageBox.Show("用户点击了确定按钮");
            }
            else
            {
                MessageBox.Show("用户点击了取消按钮");
            }
        }
    }
}
