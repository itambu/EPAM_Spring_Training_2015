using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public class Employee : User, IWorkable
    {
        public Employee(int id, string firstName,
            string lastName, DateTime birthDate)
            : base(id, firstName, lastName, birthDate)
        {
        }

        public virtual void DoWork()
        {
            Console.WriteLine("Employee");
        }
    }
}
