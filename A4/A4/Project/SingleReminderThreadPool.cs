using System;
using System.Threading;

namespace A4
{
    public class SingleReminderThreadPool : ISingleReminder
    {
        #region TODO
        public string Msg { get; private set; }
        public int Delay { get; private set; }
        public event Action<string> Reminder;
        object o = new object(){};
        public SingleReminderThreadPool(string msg, int delay)
        {
            this.Msg = msg ;
            this.Delay = delay;
        }
        public void Start()
        {
            ThreadPool.QueueUserWorkItem((o) => 
            {
                Thread.Sleep(Delay);
                Reminder(Msg);
            }
            );
        }
        #endregion
    }
}