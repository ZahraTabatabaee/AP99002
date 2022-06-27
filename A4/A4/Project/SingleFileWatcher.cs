using System;
using System.IO;

namespace A4
{

    public class SingleFileWatcher: IDisposable
    {
        private FileSystemWatcher Watcher;
        public event Action Action;
        public SingleFileWatcher(string fileName)
        {
            Watcher = new FileSystemWatcher(Path.GetDirectoryName(fileName),Path.GetFileName(fileName));
            Watcher.EnableRaisingEvents = true;
            Watcher.Changed += Changed;
        }

        private void Changed(object sender, FileSystemEventArgs e)
        {
            if(Action != null)
                Action();
        }

        public void Unregister(Action action)
        {
            Action -= action ;
        }
        public void Register(Action action)
        {
            Action += action ;
        }
        public void Dispose()
        {
            if(Watcher != null)
                Watcher.Dispose();
        }
        #region TODO

        #endregion
    }
}