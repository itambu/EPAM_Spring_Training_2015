using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public delegate int MyOperation(int a, int b);
    
    class Program
    {
        static void Main(string[] args)
        {
            //MyOperation f = new MyOperation(Sum) + new MyOperation(Mult);
            //MyOperation p = new MyOperation(Mult) + new MyOperation(Sum);

            //var g = f;

            //f -= p;

            //g += new MyOperation(Mult);

            //Console.WriteLine(Object.ReferenceEquals(f, g));
            //Console.WriteLine(f == p);

            //List<string> s = new List<string>() { "aaaaaaaa", "bbbbb" };

            //Predicate<string> d = delegate(string item)
            //{
            //    return item == "bbbbb";
            //};

            //d += item => item == "aaaaa";

            //bool r = d("aaaaa");

            //var si1 = s.Find(d);

            //if (si1 != null)
            //{
            //    //
            //}

            EventSource e = new EventSource();
            Subsciber s = new Subsciber();
            //-------------------------------------
            e.MyEvent += s.MyAction;
            e.PropertyChanged += e.ActionOnPropertyChanged;
            //-------------------------------------
            e.MyProcess();
            e.FirstName = "Вася";
            //-------------------------------------
            e.MyEvent -= s.MyAction;
            
            //-------------------------------------------------

            string a = "aaa";
            string b = "aaa";

            StringBuilder temp = new StringBuilder(5000);
            for (int i = 0; i < 1000; i++)
            {
                temp.Append(i.ToString());
            }

            
             

            Console.WriteLine(temp.ToString());

        }

        static int Mult(int a, int b)
        {
            return a * b;
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

    }
}
