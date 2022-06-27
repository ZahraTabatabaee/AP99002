using System;
using System.Threading;
using System.Threading.Tasks;

namespace A4
{
    public class SingleReminderTask : ISingleReminder
    {
        Task ReiminderTask = null;
        #region TODO
        public string Msg { get; private set; }
        public int Delay { get; private set; }
        public event Action<string> Reminder;
        public SingleReminderTask(string msg, int delay)
        {
            this.Msg = msg ;
            this.Delay = delay;
        }
        public void Start()
        {
            ReiminderTask = new Task( () =>
            {
                Thread.Sleep(Delay);
                Reminder(Msg);
            }
            );
            ReiminderTask.Start();
        }
        #endregion
    }
}