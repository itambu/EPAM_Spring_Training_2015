using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CollectorService
{
    public partial class Service1 : ServiceBase
    {
        FileSystemWatcher watcher;
        
        public Service1()
        {
            InitializeComponent();
        }

        protected virtual void InititilizeWatcher()
        {
            var watchPath = System.Configuration.ConfigurationManager.AppSettings["DirectoryWatching"];
            watcher = new FileSystemWatcher();
            watcher.Created += watcher_Created;
            watcher.EnableRaisingEvents = true;
        }

        protected override void OnStart(string[] args)
        {
            InititilizeWatcher();

        }

        private void watcher_Created(object sender, FileSystemEventArgs e)
        {
            
        }

        protected override void OnStop()
        {
        }

    }
}
