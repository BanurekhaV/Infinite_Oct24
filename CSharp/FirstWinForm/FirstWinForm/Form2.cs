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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void CommonButtonClickHandler(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            if(clickedButton !=null)
            {
                MessageBox.Show($"Button {clickedButton.Name} clicked");
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(CommonButtonClickHandler);
            button2.Click += new EventHandler(CommonButtonClickHandler);
            button3.Click += new EventHandler(CommonButtonClickHandler);
        }
    }
}
