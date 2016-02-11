using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcLib;

namespace WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void equation(object sender, EventArgs e)
        {
            input.Text += ((Button)sender).Text;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (input.Text != "")
            {
                string s = input.Text;
                s = s.Substring(0, s.Length - 1);
                input.Text = s;
            }

        }

        private void clear_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void calc_Click(object sender, EventArgs e)
        {
            Calc myCal = new Calc();
            myCal.MyInput = input.Text;
            result.Text = (myCal.fun1()).ToString();
        }


    }
}
