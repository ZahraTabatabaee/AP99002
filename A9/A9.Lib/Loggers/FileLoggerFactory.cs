using System.Collections.Generic;

namespace Logger
{
    static class FileLoggerFactory
    {
        public static FileLogger<LockedLogWriter> FileLogger_1(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        ConsoleLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<LockedLogWriter> FileLogger_2(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        CsvLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    
        public static FileLogger<LockedLogWriter> FileLogger_3(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        XmlLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<LockedLogWriter> FileLogger_4(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        ConsoleLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<LockedLogWriter> FileLogger_5(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        CsvLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    
        public static FileLogger<LockedLogWriter> FileLogger_6(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        XmlLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    
        public static FileLogger<LockedLogWriter> FileLogger_7(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        ConsoleLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<LockedLogWriter> FileLogger_8(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        CsvLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    
        public static FileLogger<LockedLogWriter> FileLogger_9(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        XmlLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<LockedLogWriter> FileLogger_10(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        ConsoleLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<LockedLogWriter> FileLogger_11(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        CsvLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    
        public static FileLogger<LockedLogWriter> FileLogger_12(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<LockedLogWriter>(
                        XmlLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<ConcurrentLogWriter> FileLogger_13(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        ConsoleLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<ConcurrentLogWriter> FileLogger_14(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        CsvLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    
        public static FileLogger<ConcurrentLogWriter> FileLogger_15(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        XmlLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<ConcurrentLogWriter> FileLogger_16(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        ConsoleLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<ConcurrentLogWriter> FileLogger_17(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        CsvLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    
        public static FileLogger<ConcurrentLogWriter> FileLogger_18(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        XmlLogFormatter.Instance,
                        PrivacyScrubberFactory.ScrubAll(),
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    
        public static FileLogger<ConcurrentLogWriter> FileLogger_19(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        ConsoleLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<ConcurrentLogWriter> FileLogger_20(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        CsvLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    
        public static FileLogger<ConcurrentLogWriter> FileLogger_21(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        XmlLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new IncrementalLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<ConcurrentLogWriter> FileLogger_22(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        ConsoleLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);

        public static FileLogger<ConcurrentLogWriter> FileLogger_23(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        CsvLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    
        public static FileLogger<ConcurrentLogWriter> FileLogger_24(string LogDir, string LogPrefix, HashSet<LogLevel> loglevels,
                HashSet<LogSource> logSources, bool append) => new FileLogger<ConcurrentLogWriter>(
                        XmlLogFormatter.Instance,
                        NullPrivacyScrubber.Instance,
                        new TimeBasedLogFileName($@"{LogDir}", LogPrefix, ConsoleLogFormatter.Instance.FileExtention),
                        loglevels,
                        logSources,
                        append);
    }
}