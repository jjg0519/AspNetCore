using System;

namespace WebCore.Logging
{
    public struct LogEntry
    {
        public DateTime At;
        public LogMode Type;
        public string Source;
        public string Logger;
        public string Message;
        public Exception Exception;
    }
}