using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class Program
    {
        public static Dictionary<string,int> dic = new Dictionary<string, int>();
        public static void check(LogEntry L)
        {
            if(dic.Keys.Contains(L.Level.ToString()))
                dic[L.Level.ToString()] += L.Message.Length ;
            else
                dic.Add(L.Level.ToString(),L.Message.Length);
            Console.ForegroundColor = ConsoleColor.Red ;
            System.Console.WriteLine($"LogLevel:{L.Level.ToString()} number of char:{dic[L.Level.ToString()]}");
            Console.ForegroundColor = ConsoleColor.White ;
        }
        static void Main(string[] args)
        {
            ConsoleLogger clogger = new ConsoleLogger();

            FileLogger<LockedLogWriter> errorLogger = new FileLogger<LockedLogWriter>(
                CsvLogFormatter.Instance,
                new PrivacyScrubber(PhoneNumberScrubber.Instance, IDScrubber.Instance, FullNameScrubber.Instance),
                new IncrementalLogFileName(@"c:\log", "A9_error", CsvLogFormatter.Instance.FileExtention),
                LogLevels.ErrorOnly,
                LogSources.All,
                true);

            FileLogger<LockedLogWriter> allLogger = new FileLogger<LockedLogWriter>(
                CsvLogFormatter.Instance,
                new PrivacyScrubber(PhoneNumberScrubber.Instance, IDScrubber.Instance, FullNameScrubber.Instance),
                new IncrementalLogFileName(@"c:\log", "A9_all", CsvLogFormatter.Instance.FileExtention),
                LogLevels.All,
                LogSources.All,
                true);

            FileLogger<LockedLogWriter> uiLogger = new FileLogger<LockedLogWriter>(
                CsvLogFormatter.Instance,
                new PrivacyScrubber(PhoneNumberScrubber.Instance, IDScrubber.Instance, FullNameScrubber.Instance),
                new IncrementalLogFileName(@"c:\log", "A9_ui", CsvLogFormatter.Instance.FileExtention),
                LogLevels.All,
                LogSources.Create(LogSource.UI),
                true);

            FileLogger<LockedLogWriter> allLoggerNew = new FileLogger<LockedLogWriter>(
                CsvLogFormatter.Instance,
                new PrivacyScrubber(IDScrubber.Instance, FullNameScrubber.Instance),
                new IncrementalLogFileName(@"c:\log", "A9_all_New", CsvLogFormatter.Instance.FileExtention),
                LogLevels.All,
                LogSources.Create(LogSource.UI),
                true);

           FileLogger<LockedLogWriter> allLoggerNew2 = new FileLogger<LockedLogWriter>(
                CsvLogFormatter.Instance,
                new PrivacyScrubber(PhoneNumberScrubber.Instance, IDScrubber.Instance, FullNameScrubber.Instance),
                new IncrementalLogFileName(@"c:\log", "A9_all_New2", CsvLogFormatter.Instance.FileExtention),
                LogLevels.All,
                LogSources.Create(LogSource.UI),
                true);

            Logger.Instance.OnLog += check ;
            Logger.Loggers.Add(errorLogger);
            Logger.Loggers.Add(allLogger);
            Logger.Loggers.Add(clogger);
            Logger.Loggers.Add(uiLogger);
            Logger.Loggers.Add(allLoggerNew);
            Logger.Loggers.Add(allLoggerNew2);

            // Logger is set up and ready to use

            // درسته که همه این دستورات را پشت سر هم زدم
            // ولی شما فرض کنید که اینها در جاهای مختلف برنامه 
            // زده شده...
            Logger.Instance.Debug(LogSource.UI, "Login button clicked");
            Logger.Instance.Debug(LogSource.Client, "User logged in", ("Name", "Mr. Ali Hassan"));
            Logger.Instance.Debug(LogSource.UI, "Add phone number cliecked");
            Logger.Instance.Info(LogSource.Client, "User number added", ("Name", "Mr. Ali Hassan"), ("PhoneNumber", "+9821 2543331"));
            Logger.Instance.Debug(LogSource.UI, "Add national ID cliecked");
            Logger.Instance.Warn(LogSource.Client, "User national ID added", ("ID", "232-12-1212"));
            Logger.Instance.Debug(LogSource.UI, "Display error to user");
            Logger.Instance.Error(LogSource.Client, "Unable to add user", ("ID", "232-12-1212"));
        }
    }
}

