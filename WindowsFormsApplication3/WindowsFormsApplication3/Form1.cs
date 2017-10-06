using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        CalcLib.ICalculator _calc;

        public void InitializeCalc()
        {
            _calc = new CalcLib.Calculator(4);

            //--------------------------------------------
            UpdateForm();
        }
        
        public Form1()
        {
            InitializeComponent();
            InitializeCalc();
        }

        public string ConvertRegisterValueToString(double value)
        {
            return Convert.ToString(value);
        }

        public void UpdateForm()
        {
            this.SuspendLayout();
            register1.Text = ConvertRegisterValueToString(_calc[0]);
            register2.Text = ConvertRegisterValueToString(_calc[1]);
            register3.Text = ConvertRegisterValueToString(_calc[2]);
            register4.Text = ConvertRegisterValueToString(_calc[3]);
            this.ResumeLayout();
        }

        public double ConvertTextToRegisterValue(string strValue)
        {
            return Convert.ToDouble(strValue);
        }

        private void buttonPush_Click(object sender, EventArgs e)
        {
            var value = ConvertTextToRegisterValue(register1.Text);
            _calc.HeadRegister = value;
            _calc.Push(value);
            UpdateForm();
        }

        private void buttonPop_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            switch (f2.ShowDialog())
            {
                case System.Windows.Forms.DialogResult.OK:
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                    break;
            }
        }


    }
}
