using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Student : User
    {
        protected string _groupNumber;

        public string GroupNumber
        {
            get { return _groupNumber; }
            set { _groupNumber = value; }
        }
     
        public Student(string firstName, 
            string lastName, 
            DateTime birthDate, 
            Address address, string groupNumber) 
            : base(firstName, lastName, birthDate, address) 
        {
            GroupNumber = groupNumber;
        }

        public override void DoWork()
        {
            Console.WriteLine("Student rests");
        }
    }
}
