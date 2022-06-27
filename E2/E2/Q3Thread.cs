using System;
using System.Threading;

namespace E2
{
    public class Q3Thread
    {
        private Random RndGen = new Random(1);
        private static int _InstanceCount = 0;
        public static int InstanceCount => _InstanceCount;

        private static Q3Thread _Instance = null;

        private static object o = new Object();
        public static void ResetInstanceToNull() 
        {
            _Instance = null;
            _InstanceCount = 0;
        }
        public static Q3Thread Instance()
        {
            lock(o)
            {
                if (_Instance == null)
                {
                    _Instance = new Q3Thread();
                }
                
            }
            return _Instance;
        }

        public int GetSomeRandomNumber() => RndGen.Next();

        private Q3Thread()
        {
            Interlocked.Increment(ref _InstanceCount);
        }
    }
}