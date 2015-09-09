using Calculator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc.Visual
{
    public partial class Form1 : Form
    {
        ICalculator icalc = new Calculator.Calculator(4);

        public Form1()
        {
            InitializeComponent();

        }

        private void CreateStackLayout()
        {
            panel2.SuspendLayout();
            for (int i = 0; i < icalc.Count; i++)
            {
                Label item = new Label();
                item.Left = 10;
                item.Top = 20 * i;
                item.AutoSize = false;
                item.Width = panel2.ClientSize.Width - 2*10;
                item.Name = "item" + i.ToString();
                item.BorderStyle = BorderStyle.FixedSingle;
                item.Height = 18;
                item.TextAlign = ContentAlignment.BottomRight;
                panel2.Controls.Add(item);
            }
            panel2.Height = (icalc.Count ) * 20 + 10;
            //this.Height = (icalc.Count +1 * 20) + panel1.Height;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.ResumeLayout();
        }

        private void DrawStackValues()
        {
            for (int i = 0; i < icalc.Count; i++)
            {
                panel2.Controls.Find("item" + i.ToString(), false).First().Text = icalc[i].ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateStackLayout();
            DrawStackValues();
        }
    }
}
