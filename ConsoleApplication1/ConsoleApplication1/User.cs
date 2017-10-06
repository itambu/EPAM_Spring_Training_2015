using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class User
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            private set { _firstName = value; }
        }

        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            private set { _lastName = value; }
        }

        public void ChangeLastName(string newLastName)
        {
            LastName = newLastName;
        }

        public User(string firstName, string lastName, DateTime birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            private set { _birthDate = value; }
        }

        public TimeSpan GetUserAge(DateTime currentTime)
        {
            return currentTime - BirthDate;
        }
    }
}
