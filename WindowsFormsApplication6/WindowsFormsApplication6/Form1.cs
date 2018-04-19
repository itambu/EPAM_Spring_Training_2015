using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitButtons();
        }

        protected void InitButtons()
        {
            button1.Tag = "0";
            button2.Tag = "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button temp = sender as Button;
            if (temp != null)
            {
                textBox1.Text += (temp.Tag as string);
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0': button2_Click(button1, null); break;
            }
        }
    }
}
