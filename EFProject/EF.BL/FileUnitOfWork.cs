using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.BL
{
    public class FileUnitOfWork
    {
        private TaskFactory<bool> taskFactory;

        public FileUnitOfWork(TaskFactory<bool> taskFactory, DbContext context)
        {
        }

        public FileUnitOfWork()
        {
        }

        //public Task<bool> CreateTask(string fileName, )
        //{
        //    taskFactory.; 
        //}
    }
}
