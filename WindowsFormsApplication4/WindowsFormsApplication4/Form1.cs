using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void callToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f1 = new Form2();
            f1.MdiParent = this;
            
            f1.Show();
        }
    }
}
