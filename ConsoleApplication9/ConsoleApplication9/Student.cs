using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public class Student : User, IWorkable
    {
        public string LastName
        {
            get { return base.LastName; }
            protected set 
            {
                Validate(value);
                base.LastName = value; 
            }
        }

        public void Validate(string newLastName)
        {
        }

        public Student(int id, string firstName, 
            string lastName, DateTime birthDate)
        :base(id, firstName, lastName, birthDate)
        {
        }

        public void DoWork()
        {
            //base.DoWork();
            Console.WriteLine("Student");
        }
    }
}
