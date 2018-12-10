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
        public BlogService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            using (var fs = System.IO.File.Create(@"d:\aaaaaa.txt"))
            {

            }
        }

        protected override void OnStop()
        {
        }

         
    }
}
