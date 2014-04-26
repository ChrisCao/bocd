﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace bocd
{
    public partial class Form1 : Form
    {
        private int[] m_Res = new int[3];
        private int[] m_Num = new int[3];
        private int[] m_Every = new int[3];
        public Form1()
        {
            InitializeComponent();
            this.textBox1.Visible = false;
            this.labelNum.Text = "000";

            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            path += "\\bocd.cfg";
            if (File.Exists(path))
            {
                StreamReader srReadFile = new StreamReader(path);
                while (!srReadFile.EndOfStream)
                {
                    string str = srReadFile.ReadLine();
                    m_Num[0] = Convert.ToInt32(str);
                    str = srReadFile.ReadLine();
                    m_Every[0] = Convert.ToInt32(str);
                    str = srReadFile.ReadLine();
                    m_Num[1] = Convert.ToInt32(str);
                    str = srReadFile.ReadLine();
                    m_Every[1] = Convert.ToInt32(str);
                    str = srReadFile.ReadLine();
                    m_Num[2] = Convert.ToInt32(str);
                    str = srReadFile.ReadLine();
                    m_Every[2] = Convert.ToInt32(str);
                }
                srReadFile.Close();
            }

            this.textLuRu.Text = Convert.ToString(m_Res[0]);
            this.textZiXin.Text = Convert.ToString(m_Res[0]);
            this.textShenPi.Text = Convert.ToString(m_Res[0]);
        }

        private void textLuRu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textZiXin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textShenPi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void 设置SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.SetLuRuNumText(Convert.ToString(m_Num[0]));
            form2.SetLuRuEveryText(Convert.ToString(m_Every[0]));
            form2.SetZiXinNumText(Convert.ToString(m_Num[1]));
            form2.SetZiXinEveryText(Convert.ToString(m_Every[1]));
            form2.SetShenPiNumText(Convert.ToString(m_Num[2]));
            form2.SetShenPiEveryText(Convert.ToString(m_Every[2]));
            form2.ShowDialog();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            path += "\\bocd.cfg";
            StreamWriter srWriteFile = new StreamWriter(path);
            srWriteFile.WriteLine(form2.GetLuRuNumText());
            srWriteFile.WriteLine(form2.GetLuRuEveryText());
            srWriteFile.WriteLine(form2.GetZiXinNumText());
            srWriteFile.WriteLine(form2.GetZiXinEveryText());
            srWriteFile.WriteLine(form2.GetShenPiNumText());
            srWriteFile.WriteLine(form2.GetShenPiEveryText());
            m_Num[0] = Convert.ToInt32(form2.GetLuRuNumText());
            m_Num[1] = Convert.ToInt32(form2.GetZiXinNumText());
            m_Num[2] = Convert.ToInt32(form2.GetShenPiNumText());
            m_Every[0] = Convert.ToInt32(form2.GetLuRuEveryText());
            m_Every[1] = Convert.ToInt32(form2.GetZiXinEveryText());
            m_Every[2] = Convert.ToInt32(form2.GetShenPiEveryText());
            srWriteFile.Close();
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (m_Num[i] == 0 || m_Every[i] == 0)
                {
                    MessageBox.Show(this, "请设置人数和每日完成数！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


	        string log = "";
	        int dayindex = 0;
	        int[] reduceEvery = new int[3];
	        for (int i=0; i<3; i++)
	        {
		        reduceEvery[i] = m_Num[i]*m_Every[i];
	        }

	        int[] today = new int[3];
            m_Res[0] = Convert.ToInt32(this.textLuRu.Text);
            m_Res[1] = Convert.ToInt32(this.textZiXin.Text);
            m_Res[2] = Convert.ToInt32(this.textShenPi.Text);
            string str;
	        str = String.Format(" 初  始 ：      录入剩余{0} 件，资信剩余{1} 件，审批剩余{2} 件\r\n\r\n", m_Res[0], m_Res[1], m_Res[2]);
	        log += str;
	        while(m_Res[0]!=0 || m_Res[1]!=0 || m_Res[2]!=0)
	        {
		        if (m_Res[0]>reduceEvery[0])
		        {
			        m_Res[0] -= reduceEvery[0];
			        today[0] = reduceEvery[0];
		        }
		        else
		        {
			        today[0] = m_Res[0];
			        m_Res[0] = 0;
		        }

		        if (m_Res[1]>reduceEvery[1])
		        {
			        m_Res[1] -= reduceEvery[1];
			        today[1] = reduceEvery[1];
		        }
		        else
		        {
			        today[1] = m_Res[1];
			        m_Res[1] = 0;
		        }

		        if (m_Res[2]>reduceEvery[2])
		        {
			        m_Res[2] -= reduceEvery[2];
			        today[2] = reduceEvery[2];
		        }
		        else
		        {
			        today[2] = m_Res[2];
			        m_Res[2] = 0;
		        }

		        m_Res[1] += today[0];
		        m_Res[2] += today[1];
		        dayindex++;
		        str = String.Format("第{0,4}天 录入：完成{1,4} 件，剩余{2,4} 件\r\n         资信：新增{3,4} 件，完成{4,4} 件，剩余{5,4} 件\r\n         审批：新增{6,4} 件，完成{7,4} 件，剩余{8,4} 件\r\n\r\n", 
						        dayindex, today[0], m_Res[0], today[0], today[1], m_Res[1], today[1], today[2], m_Res[2]);
		        log += str;
	        }


	        str = String.Format("预计 {0} 天完成现有存件\r\n\r\n", dayindex);
	        log = str+log;

            this.textBox1.Text = log;
            str = String.Format("{0,03}", dayindex);
            this.labelNum.Text = str;

            this.textBox1.Visible = false;
            this.labelFirst.Visible = true;
            this.labelNum.Visible = true;
            this.labelSecond.Visible = true;
        }

        private void 主页HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Visible = false;
            this.labelFirst.Visible = true;
            this.labelNum.Visible = true;
            this.labelSecond.Visible = true;
        }

        private void 详情DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.textBox1.Visible = true;
            this.labelFirst.Visible = false;
            this.labelNum.Visible = false;
            this.labelSecond.Visible = false;
        }
    }
}
