using System;
using System.IO;

namespace Lesson10
{
    interface ILogWriter
    {
        void LogInfo(string message);
        void LogWarning(string massage);
        void LogError(string message);
    }

    abstract class AbstractLogWriter : ILogWriter
    {
        protected string LogOutput(string typeOfLog, string message) =>
        $"{DateTimeOffset.Now} {typeOfLog} {message}";
        protected void LogMessage(string message, string type) =>
        WriteMessage(LogOutput(message, type));
        public void LogInfo(string message) =>
        LogMessage(message, "Info");
        public void LogWarning(string message) =>
        LogMessage(message, "Warning");
        public void LogError(string message) =>
        LogMessage(message, "Error");
        protected abstract void WriteMessage(string line);
    }

    class ConsoleLogWriter : AbstractLogWriter, ILogWriter
    {
        protected override void WriteMessage(string line) =>
        Console.WriteLine(line);
    }
    class FileLogWriter : AbstractLogWriter, ILogWriter
    {
        private readonly string _path;

        public FileLogWriter(string path)
        {
            _path = path;
        }
        protected override void WriteMessage(string line) =>
        File.AppendAllText(_path, line);
        class MultipleLogWriter : ILogWriter
        {
            private readonly ILogWriter[] _logWriters;

            public MultipleLogWriter(params ILogWriter[] writer)
            {
                _logWriters = writer;
            }

            public void LogInfo(string message)
            {
                foreach (var writer in _logWriters)
                {
                    writer.LogInfo(message);
                }
            }
            public void LogWarning(string message)
            {
                foreach (var writer in _logWriters)
                {
                    writer.LogWarning(message);
                }
            }
            public void LogError(string message)
            {
                foreach (var writer in _logWriters)
                {
                    writer.LogError(message);
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.Write("Enter a file name: ");
                var path = Console.ReadLine();

                var filelogwriter = new FileLogWriter(path);
                filelogwriter.LogInfo("Message containing information");
                filelogwriter.LogWarning("Message containing warning");
                filelogwriter.LogError("Message containing error");

                var consolelogwriter = new ConsoleLogWriter();
                consolelogwriter.LogInfo("Message containing information");
                consolelogwriter.LogWarning("Message containing warning");
                consolelogwriter.LogError("Message containing error");

                var miltipleogriter = new MultipleLogWriter(consolelogwriter, filelogwriter);
                miltipleogriter.LogInfo("Message containing information");
                miltipleogriter.LogWarning("Message containing warning");
                miltipleogriter.LogError("Message containing error");

                Console.ReadKey();

            }
        }
    }
}