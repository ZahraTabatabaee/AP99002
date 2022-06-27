using System;
using System.IO;
using System.Threading;

namespace A4
{
    public enum ObserverType { Create, Delete }

    public class DirectoryWatcher : IDisposable
    {
        #region TODO
        FileSystemWatcher Watcher;
        public string _filename ;
        public event Action<string> _create = null ;
        public event Action<string> _delete = null ;
        public DirectoryWatcher(string fileName)
        {
            Watcher = new FileSystemWatcher(fileName);
            Watcher.EnableRaisingEvents = true;
            Watcher.Deleted += delete ;
            Watcher.Created += create ;
        }

        private void create(object sender, FileSystemEventArgs e)
        {
            if(_create != null)
                _create(e.FullPath);
        }

        private void delete(object sender, FileSystemEventArgs e)
        {
            if( _delete != null)
                _delete(e.FullPath);
        }
        public void Unregister(Action<string> action , ObserverType o)
        {
            if(o == ObserverType.Create)
                _create -= action;
            else
                _delete -= action;
        }
        public void Register(Action<string> action , ObserverType o)
        {
            if(o == ObserverType.Create)
                _create += action;
            else
                _delete += action;
        }

        public void Dispose()
        {
            if(Watcher != null)
                Watcher.Dispose();
        }

        #endregion
    }
}