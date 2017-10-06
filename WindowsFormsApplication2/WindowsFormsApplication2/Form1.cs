using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            this.SuspendLayout();
            button1.Top = this.Size.Height / 2;
            button1.Left = this.Size.Width / 2;
            this.ResumeLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi!", "Text", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
