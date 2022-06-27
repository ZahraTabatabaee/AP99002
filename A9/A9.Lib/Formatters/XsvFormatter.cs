using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class XsvFormatter : ILogFormatter
    {
        public XsvFormatter(char givenChar) {
            this.givenChar = givenChar ;
        }
        public char givenChar { get;  set; }

        public string Header => $"level{givenChar}date{givenChar}source{givenChar}threadId{givenChar}ProcessId{givenChar}message{givenChar}name:value pairs";

        public string Footer => string.Empty;

        public string FileExtention => "log";


        public string Format(LogEntry entry)
        {
            return $"{entry.Level.ToString()}{givenChar}{entry.DateTime.ToString()}{givenChar}{entry.Source.ToString()}{givenChar}" +
                   $"{entry.ThreadId.ToString()}{givenChar}{entry.ProcessId}{givenChar}{entry.Message}{givenChar}" +
                    string.Join(givenChar.ToString(), entry.NameValuePairs.Select(v => $"'{v.name}':'{v.value}'"));
        }
    }
}
