using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace BlogService
{
    public partial class BlogService : ServiceBase
    {

        private BlogExample.Manager.BlogManager blogManager;

        public BlogService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            blogManager = new BlogExample.Manager.BlogManager(new System.IO.FileSystemWatcher(@"D:\", "*.csv"));
            blogManager.Run();
        }

        protected override void OnStop()
        {
            try
            {
                blogManager.Stop();
            }
            finally
            {
                blogManager.Dispose();
            }
        }
    }
}
