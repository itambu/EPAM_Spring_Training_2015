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

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        CancellationTokenSource cancelSource = new CancellationTokenSource();
        
        public Form1()
        {
            InitializeComponent();

            SwichButtonState(true);
        }

        private void DoSomething()
        {
            SwichButtonState(false);
            
            progressBar1.Value = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            for (int i = 1; i <= 10; i++)
            {
                if (progressBar1.InvokeRequired)
                {
                    Action temp = delegate() { progressBar1.Value = i * 10; };
                    progressBar1.Invoke(temp, null);
                }
                Thread.Sleep(1000);
                if (cancelSource.Token.IsCancellationRequested)
                {
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task t = Task.Factory.StartNew(DoSomething, cancelSource.Token);
            Task continuation = t.ContinueWith((x) => { SwichButtonState(true); });
        }

        private void SwichButtonState(bool state)
        {
            if (button1.InvokeRequired)
            {
                Action temp = new Action(delegate(){button1.Enabled = state;});
                button1.Invoke( temp, null);
            }

            if (button2.InvokeRequired)
            {
                Action temp = new Action(delegate() { button2.Enabled = !state; });
                button2.Invoke(temp, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancelSource.Cancel();
        }
    }
}
