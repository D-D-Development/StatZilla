//using Newtonsoft.Json;
using System;
using System.IO;
using System.Text;
using StatZilla_Services.Extensions;

namespace StatZilla_Services.Utility
{
    /// <summary>
    /// An iterface which represents a message log
    /// </summary>
    public class Log
    {
        /// <summary>
        /// An enumeration which represents a type of log message
        /// </summary>
        public enum Type { INFO, ERROR, DEBUG, WARNING, CRITICAL }

        /// <summary>
        /// The time zone the log date should be formatted as, defaults to local time
        /// </summary>
        public TimeZoneInfo TimeZone { get; set; } = TimeZoneInfo.Local;
        /// <summary>
        /// The time format the log date should be formatted as
        /// </summary>
        public string TimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.fffffffK";
        /// <summary>
        /// The streams the log messages should be written to
        /// </summary>
        private Stream[] Streams { get; set; }

        /// <summary>
        /// Creates a new log instance
        /// </summary>
        /// <param name="streams">The streams the log messages should be written to</param>
        public Log(params Stream[] streams)
        {
            Streams = streams;
        }

        /// <summary>
        /// Writes a new log message
        /// </summary>
        /// <param name="type">The type of message</param>
        /// <param name="message">The message</param>
        public void WriteLine(Type type, string message)
        {
            // Format the message line
            // All control characters such as carriage return, line feed, and tabs are removed and replaced by their literal representation
            var datetime = TimeZoneInfo.ConvertTime(DateTime.Now, TimeZone);
            var line = $"[{datetime.ToString(TimeFormat)}] {type,-9} {message.ToLiteral()}";

            // Write the message for each stream the message should be written to
            foreach (Stream stream in Streams)
            {
                // Write the message using UTF8 Encoding without BOM
                using (var writer = new StreamWriter(stream, new UTF8Encoding(false), 512, true))
                {
                    writer.WriteLine(line);
                    writer.Flush();
                }
            }
        }
    }
}
