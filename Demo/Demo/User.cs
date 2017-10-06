using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class User
    {
        private string _firstName;
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public TimeSpan GetUserAge(DateTime current)
        {
            return current - _birthDate;
        }

        public User(string firstName, string lastName, DateTime birthDate, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Address = address;
        }

        public User()
        {
        }

        public Address Address { get; set; }


        static User()
        {
        }

        public virtual void DoWork()
        {
            Console.WriteLine("User is working");
        }

    }
}
