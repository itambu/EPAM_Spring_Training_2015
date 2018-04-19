using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public class User : IUser
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            private set { _birthDate = value; }
        }

        int IUser.FullUserYear(DateTime current)
        {
            return current.Year - BirthDate.Year;
        }

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
            protected set { _lastName = value; }
        }


        public User(int id, string firstName, string lastName, DateTime birthDate)
            :this()
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }

        private User()
        {
        }

    }



}
