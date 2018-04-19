using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<int> m = new List<int>() { 1, 2, 3, 4, 5 };

           

            foreach (var item in m)
            {
                if (item % 4 == 0)
                {
                    // do something
                    break;
                }
            }


            IEnumerable<int> enumerable = m as IEnumerable<int>;
            if (enumerable != null)
            {
                IEnumerator<int> iterator = enumerable.GetEnumerator();

                
                int current = default(int);
                bool notPassAll = true;
                while (notPassAll = iterator.MoveNext() && (current = iterator.Current) % 4 != 0)
                {
                }

                if (!notPassAll)
                {
                    // do something
                }

            }

            int i = 0;
            while (i < m.Length && m[i] )
            {
                i++;
            }
            if (i < m.Length)
            {
                // do something
            }


        }
    }
}
