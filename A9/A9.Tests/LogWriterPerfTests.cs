using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;

namespace Logger.Tests
{
    [TestClass()]
    public class LogWriterPerfTests
    {
        [TestMethod()]
        public void LockedLogWriterPerfTest()
        {
            var time = PerfTest<LockedLogWriter>(threadCount:1, linePerThread:1000);
            System.Console.WriteLine(time);
        }

        [TestMethod()]
        public void ConcurrentLogWriterPerfTest()
        {
            var time = PerfTest<ConcurrentLogWriter>(threadCount: 1, linePerThread: 1000);
            System.Console.WriteLine(time);
        }

        [TestMethod()]
        public void LockedQueueLogWriterTest()
        {
            var time = PerfTest<LockedQueueLogWriter>(threadCount: 1, linePerThread: 1000);
            System.Console.WriteLine(time);

        }



        // [TestMethod()]
        // public void NoLockPerfTest()
        // {
        //     var time = PerfTest<NoLockLogWriter>(threadCount: 25, linePerThread: 1000);
        // }

        private string PerfTest<_LogWriter>(int threadCount, int linePerThread)
            where _LogWriter: GuardedLogWriter, new()
        {
            string logDir = Path.GetTempFileName();
            File.Delete(logDir);
            string logPrefix = "sauleh_all";
            string time = string.Empty;
            using (FileLogger<_LogWriter> logger = new FileLogger<_LogWriter>(
                    XmlLogFormatter.Instance,
                    new PrivacyScrubber(PhoneNumberScrubber.Instance, IDScrubber.Instance, FullNameScrubber.Instance),
                    new TimeBasedLogFileName(logDir, logPrefix, XmlLogFormatter.Instance.FileExtention),
                    LogLevels.All,
                    LogSources.All,
                    false))
            {
                var threads = Enumerable.Range(0, threadCount)
                                        .Select(n => new Thread(
                                            new ThreadStart(() => LogRandomMessages(linePerThread, logger))))
                                        .ToList();

                Stopwatch sw = Stopwatch.StartNew();
                threads.ForEach(t => t.Start());
                threads.ForEach(t => t.Join());
                sw.Stop();

                time = sw.Elapsed.TotalSeconds.ToString();
                
            }

            int actualLogLines = CountLogLines(logDir, pattern: $"{logPrefix}*.{XmlLogFormatter.Instance.FileExtention}");

            Assert.AreEqual(linePerThread * threadCount + 2, actualLogLines); // plus 2 for header and footer

            return time;
        }

        private int CountLogLines(string logDir, string pattern)
        {
            return Directory.GetFiles(logDir, pattern).Sum(f => File.ReadAllLines(f).Length);
        }

        private void LogRandomMessages(int count, ILogger logger)
        {
            for (int i=0; i<count; i++)
            {
                LogEntry logEntry = new LogEntry(LogSource.Client, LogLevel.Debug,
                    $"student {i} created", ("FirstName", $"Pegah_{i}"), ("LastName", $"Ayati_{i}"));
                logger.Log(logEntry);
            }
        }
    }
}
        /*no locked 
        به دلیل این که نوع لاک رایتر ، نو لاکد است ، تداخل بیشتری دارند و با ترد های بیشتر تداخل بیشتری صورت می گیرد
        و چندین ترد میخواهند یک کار را(نوشتن خط ها در فایل) را انجام دهند که ارور 
        Arithmetic operation resulted in an overflow
        می دهد*/

        /* 
            count   LockedLogWriter     ConcurrentLogWriter     LockedQueueLogWriter
        -------------------------------------------------------------------------------
            1          0.2345509            0.163557                0.2221071
            2          0.1882834            01653299                0.152008
            5          0.3039688            0.241871                0.235799
            10         0.4420532            0.434963                0.3535142
            20         0.8943872            0.646646                0.8495448
            50         2.1341547            2.208797                2.0642248
            100        4.7247824            5.276214                4.9116992
        */

        /* مقایسه
        در حالت کلی پیش بینی میشه که در شمار ترد های بیشتر 
        ConcurrentLogWriter
        زمان بیشتری رو نسبت به  
        LockedLogWriter
        داشته باشه اما در تلاش هایی که شد خلاف این ثابت شد . ممکنه دلیل این باشه که تعداد
        LinePerThread هم بر این اعداد اثر داره
        */