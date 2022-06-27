using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace A4
{
    public static class ActionTools
    {
        public static long CallSequential(params Action[] actions)
        {
            #region TODO
            Stopwatch s = new Stopwatch();
            s.Start();
            foreach(Action a in actions)
            {
                Task task = new Task(a); 
                task.Start();
                task.Wait();
            }
            long result = s.ElapsedMilliseconds;
            return result ;
            #endregion
        }

        public static long CallParallel(params Action[] actions)
        {
            #region TODO
            Stopwatch s = new Stopwatch();
            s.Start();
            List<Task> list = new List<Task>();
            foreach(Action a in actions)
            {
                Task task = new Task(a); 
                task.Start();
                list.Add(task);
            }
            Task.WaitAll(list.ToArray());
            long result = s.ElapsedMilliseconds;
            return result ;
            #endregion

        }

        public static long CallParallelThreadSafe(int count, params Action[] actions)
        {
            #region TODO
            Stopwatch s = new Stopwatch();
            s.Start();
            List<Task> list = new List<Task>();
            object o = new object();
            foreach(Action a in actions)
            {
                for(int i = 0 ; i < count ; i++)
                {
                    Task task = Task.Run(()=>
                        {
                            lock (o)
                            {
                                a();
                            }
                        });
                    list.Add(task);
                }
            }
            Task.WaitAll(list.ToArray());
            long result = s.ElapsedMilliseconds;
            return result ;
            #endregion

        }


        public static async Task<long> CallSequentialAsync(params Action[] actions)
        {
            #region TODO
            Stopwatch s = new Stopwatch();
            s.Start();
            foreach(Action a in actions)
            {
                Task task = new Task(a); 
                task.Start();
                await task;
                // task.Wait();
            }
            long result = s.ElapsedMilliseconds;
            return result ;
            #endregion

        }

        public static async Task<long> CallParallelAsync(params Action[] actions)
        {
            #region TODO
            Stopwatch s = Stopwatch.StartNew();
            s.Start();
            List<Task> list = new List<Task>();
            foreach(Action a in actions)
            {
                Task task = new Task(a); 
                task.Start();
                list.Add(task);

            }
            for(int j = 0 ; j < list.Count ;j++)
                await list[j];
            long result = s.ElapsedMilliseconds;
            return result ;
            #endregion
        }

        public static async Task<long> CallParallelThreadSafeAsync(int count, params Action[] actions)
        {
            #region TODO
            Stopwatch s = new Stopwatch();
            s.Start();
            List<Task> list = new List<Task>();
            object o = new object();
            foreach(Action a in actions)
            {
                for(int i = 0 ; i < count ; i++)
                {
                    Task task = Task.Run(()=>
                        {
                            lock (o)
                            {
                                a();
                            }
                        });
                    list.Add(task);
                }
            }
            for(int j = 0 ; j < list.Count ;j++)
                await list[j];
            long result = s.ElapsedMilliseconds;
            return result ;
            #endregion
        }
    }
}