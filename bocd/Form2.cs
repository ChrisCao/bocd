﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace bocd
{
    public partial class Form2 : Form
    {
        private string[] strsTemp = new string[6];
        public Form2()
        {
            InitializeComponent();
            this.textLuRu_Num.Text = "0";
            this.textLuRu_Every.Text = "0";
            this.textZiXin_Num.Text = "0";
            this.textZiXin_Every.Text = "0";
            this.textShenPi_Num.Text = "0";
            this.textShenPi_Every.Text = "0";
            this.StartPosition = FormStartPosition.CenterParent;
        }

        public void SetLuRuNumText(string str)
        {
            this.textLuRu_Num.Text = str;
            strsTemp[0] = str;
        }
        public void SetLuRuEveryText(string str)
        {
            this.textLuRu_Every.Text = str;
            strsTemp[1] = str;
        }
        public void SetZiXinNumText(string str)
        {
            this.textZiXin_Num.Text = str;
            strsTemp[2] = str;
        }
        public void SetZiXinEveryText(string str)
        {
            this.textZiXin_Every.Text = str;
            strsTemp[3] = str;
        }
        public void SetShenPiNumText(string str)
        {
            this.textShenPi_Num.Text = str;
            strsTemp[4] = str;
        }
        public void SetShenPiEveryText(string str)
        {
            this.textShenPi_Every.Text = str;
            strsTemp[5] = str;
        }


        public string GetLuRuNumText()
        {
            return this.textLuRu_Num.Text;
        }
        public string GetLuRuEveryText()
        {
            return this.textLuRu_Every.Text;
        }
        public string GetZiXinNumText()
        {
            return this.textZiXin_Num.Text;
        }
        public string GetZiXinEveryText()
        {
            return this.textZiXin_Every.Text;
        }
        public string GetShenPiNumText()
        {
            return this.textShenPi_Num.Text;
        }
        public string GetShenPiEveryText()
        {
            return this.textShenPi_Every.Text;
        }

        private void textLuRu_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textLuRu_Every_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textZiXin_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textZiXin_Every_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textShenPi_Num_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void textShenPi_Every_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字
                {
                    e.Handled = true;
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.textLuRu_Num.Text = strsTemp[0];
            this.textLuRu_Every.Text = strsTemp[1];
            this.textZiXin_Num.Text = strsTemp[2];
            this.textZiXin_Every.Text = strsTemp[3];
            this.textShenPi_Num.Text = strsTemp[4];
            this.textShenPi_Every.Text = strsTemp[5];
        }
    }
}
