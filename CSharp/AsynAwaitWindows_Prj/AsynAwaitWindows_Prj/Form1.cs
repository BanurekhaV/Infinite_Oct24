using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;

namespace AsynAwaitWindows_Prj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Hi, Working on Async and await  ??");
        }

        private int CountCharacters()
        {
            int count = 0;
            using(StreamReader reader = new StreamReader("DataFile.txt"))
            {
                string contents = reader.ReadToEnd();
                count= contents.Length;
                Thread.Sleep(5000);
            }
            return count;
        }

        //synchronous handling 
        private  void btn_Sync_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label1.Visible = true;
            label1.Enabled = true;
            int z = CountCharacters(); //making a call to another func
            label1.Text = "Processing the data file, please wait....";
            textBox1.Text = "Waiting for counting Work to finish";
            textBox1.Text = z.ToString() + " " + "Characters"; 
        }

        //asynchronously handling
        private async void btn_Async_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            label1.Visible = true;
            label1.Enabled = true;
            Task<int> mytask = new Task<int>(CountCharacters);
            mytask.Start();  //making a call to countcharacters function
            label1.Text = "Processing the data file, please wait....";
            textBox1.Text = "Waiting for counting Work to finish";

            textBox1.BackColor = SystemColors.Window;
            int num = await mytask;
            textBox1.Text = num.ToString() + " " + "Characters found in the File";

        }
    }
}
