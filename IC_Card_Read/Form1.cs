using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IC_Card_Read
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if条件检测按下的是不是Enter键,两个判断,,这个一定要放在第一个
            if (e.KeyCode == Keys.Enter)
            {
                string inputValue = textBox1.Text;
                int len = inputValue.Length;
                inputValue += " len=";
                inputValue += len;
                inputValue += "\r\n";

                MessageBox.Show(inputValue);
                // textBox2.Text += inputValue;
                label1.Text = inputValue;
                textBox1.Text = "";

            }
            else
            {
                return;
            }
        }
    }
}
