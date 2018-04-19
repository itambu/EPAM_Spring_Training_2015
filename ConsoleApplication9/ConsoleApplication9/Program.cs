using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            Student u = new Student(id: 1, firstName: "Вася", 
                lastName: "Коровин", 
                birthDate: new DateTime(1990, 11, 3 ));

            

            List<IUser> items = new List<IUser>()
            {
                new Student(id: 1, firstName: "Вася", 
                lastName: "Коровин", 
                birthDate: new DateTime(1990, 11, 3 )),

                new Employee(id: 2, firstName: "Петя", 
                lastName: "Лисицын", 
                birthDate: new DateTime(1992, 3, 13 ))
            };

            DoAllWork(items.Cast<IWorkable>().ToList());
        }

        public static void DoAllWork(List<IWorkable> items)
        {
            foreach (IWorkable u in items)
            {
                //Console.WriteLine("{0} {1}", u.Id, u.FullUserYear(DateTime.Now));
                u.DoWork();
            }
        }
    }
}
