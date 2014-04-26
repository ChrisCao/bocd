using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace bocd
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void buttonCompute_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void setString(string line1, string line2)
        {
            this.labelLine1.Text = line1;
            this.labelLine2.Text = line2;
        }
    }
}
