using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AllclickesMethod()
        {

        }
        private void btn_Click_Click(object sender, EventArgs e)
        {
            txtPwd.Text = txtName.Text;
            MessageBox.Show("hello and welcome to windows programming..");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPwd.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Click.Click += btn_Click_Click;
            button1.Click += btn_Click_Click;
        }
    }
}
