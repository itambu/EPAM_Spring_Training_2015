using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(
                firstName: "Вася",
                lastName: "Петров",
                birthDate: new DateTime(1999, 09, 10),
                address: new Address() {ZipCode="22222", City="village Gadukino", Street="Edistvennaja" },
                groupNumber: "2 group"
                );

            student.DoWork();

            User user = student;
            user.DoWork();

            //User u2 = new User() 
            //{ 
            //    FirstName = "Миша", 
            //    LastName = "Медведев", 
            //    BirthDate = new DateTime(2001, 1, 15) 
            //};

            //u2.DoWork();




            //Console.WriteLine(student.GetUserAge(DateTime.Now));

            //User[] users = new User[]
            //{
            //    student, 
            //    new User(firstName: "Вася",
            //        lastName: "Петров",
            //        birthDate: new DateTime(1999, 09, 10),
            //        address: new Address() {ZipCode="22222", City="village Gadukino", Street="Edistvennaja" }) 
            //};

            //users.Process();
        }



        public static void ObligateUserToWork(User user)
        {
            user.DoWork();
        }
    }
}
