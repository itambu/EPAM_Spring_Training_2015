using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF.Entites;
using System.Data.Entity.Infrastructure;
using EF.BL;
using EF.DAL;
using EF.DIService;
using System.Data.Entity;
using EF.DAL.Abstractions;
using System.Linq.Expressions;
using EF.BL.Models;
using EF.BL.Support;

namespace EF.ConsoleClient
{
    public class Program
    {
        static void Main()
        {
            ServiceLocator.Register(typeof(IGenericRepository<User>), typeof(GenericRepository<User>));
            ServiceLocator.Register(typeof(System.Data.Entity.DbContext), typeof(BlogDbContext));
            ServiceLocator.Register(typeof(DAL.Abstractions.IRepositoryFactory), typeof(DAL.Factory.GenericRepositoryFactory));

//            Expression<Func<Customer, bool>> ex = x => x.LastName == "aaaa";
//            var c= ex.Project<Customer, EF.Entites.User>();
        }

        static void DbInitialize(BlogDbContext context)
        {
            
            User user = new User() { FirstName = "John", LastName = "Smith" };
            context.Users.Add(user);

            Blog blog = new Blog() { Title = "My first post", Text = "fjsfhdsfjdsj", Author = user };
            context.Blogs.Add(blog);

            User user2 = new User() { FirstName = "Martin", LastName = "Dirt" };
            context.Users.Add(user2);

            Comment comment = new Comment() { Blog = blog, Parent = null, Text = "aaaaaaaaa", User = user2 };
            context.Comments.Add(comment);

            context.SaveChanges();
        }
    }
}
