using System;
using System.Threading;

namespace A4
{
    public class SingleReminderThread : ISingleReminder
    {
        Thread ReiminderThread = null;
        #region TODO
        public string Msg { get; private set; }
        public int Delay { get; private set; }
        public event Action<string> Reminder;
        public SingleReminderThread(string msg, int delay)
        {
            this.Msg = msg ;
            this.Delay = delay;
        }
        public void Start()
        {
            ReiminderThread = new Thread( () =>
            {
                Thread.Sleep(Delay);
                Reminder(Msg);
            }
            );
            ReiminderThread.Start();
        }
        #endregion
    }
}