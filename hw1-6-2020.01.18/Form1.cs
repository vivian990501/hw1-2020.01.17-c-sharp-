using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw1_6_2020._01._18
{
    public partial class Form1 : Form
    {
        private mydata _data;
        public Form1()
        {
            InitializeComponent();
            _data = new mydata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _data.Y = int.Parse(textBox1.Text);
            label1.Text = "星期六 " + _data.Sat().ToString() + "天";
            label2.Text = "星期天 " + _data.Sun().ToString() + "天";

        }
    }
}
