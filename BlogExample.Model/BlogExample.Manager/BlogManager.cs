using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
using System.Collections.Concurrent;


namespace BlogExample.Manager
{
    public class BlogManager : IDisposable
    {
        
        private System.IO.FileSystemWatcher _watcher;

        private BlockingCollection<CancellationToken> cancelTokenCollection = new BlockingCollection<CancellationToken>(); 

        public BlogManager(System.IO.FileSystemWatcher watcher)
        {
            _watcher = watcher;
            _watcher.Created += this.OnWatcherCreated;
        }

        public void OnWatcherCreated(object sender, System.IO.FileSystemEventArgs e)
        {
            try
            {
                CancellationToken token = new CancellationToken();

                Action createTaskAction = () =>
                {
                    using (var stream = new FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.None))
                    {
                        using (var reader = new StreamReader(stream))
                        {
                            ParseCsv(reader, token);
                        }
                    }
                };

                var task = new Task(createTaskAction, token);
                cancelTokenCollection.Add(token);

                task.ContinueWith((sourceTask) =>
                    {
                        cancelTokenCollection.Take(token);
                    });

                task.Start();

            }
            finally
            {
                // Sql Server 2008 R2
            }

        }

        protected void ParseCsv(System.IO.TextReader reader, CancellationToken token)
        {
            
            try
            {
                string current = null;
                while ((current = reader.ReadLine()) != null && !token.IsCancellationRequested)
                {
                    // Parse string
                    // add records to data context

                    // add Order


                }

                if (current != null && token.IsCancellationRequested)
                {
                    // Rollback
                }
            }
            catch (IOException e)
            {
                //Rollback
            }

            
        }

        private object orderSyncObj = new object();

        public void Add(Order order)
        {
            // create repository
            lock (orderSyncObj)
            {

            }
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
