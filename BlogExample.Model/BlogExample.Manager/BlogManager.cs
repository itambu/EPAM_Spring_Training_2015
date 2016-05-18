using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlogExample.Manager
{
    public class BlogManager : IDisposable
    {
        private System.IO.FileSystemWatcher _watcher;

        public BlogManager(System.IO.FileSystemWatcher watcher)
        {
            _watcher = watcher;
            _watcher.Created += this.OnWatcherCreated;
        }

        public void OnWatcherCreated(object sender, System.IO.FileSystemEventArgs e)
        {
            
        }

        public void Run()
        {
            if (_watcher != null && !_watcher.EnableRaisingEvents)
            {
                _watcher.EnableRaisingEvents = true;
            }
        }

        public void Stop()
        {
            if (_watcher != null && _watcher.EnableRaisingEvents)
            {
                _watcher.EnableRaisingEvents = false;
            }
        }


        #region IDisposable
        public void Dispose()
        {
            if (_watcher != null)
            {
                Stop();
                _watcher.Dispose();
                _watcher = null;
            }
        }

        ~BlogManager()
        {
            Dispose();
        }
        #endregion 
    }
}
