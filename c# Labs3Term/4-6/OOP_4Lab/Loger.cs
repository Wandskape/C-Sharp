using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_4Lab
{
    interface ILogger
    {
        void Log(string message);
    }

    class FileLogger : ILogger
    {
        private readonly string logFilePath;

        public FileLogger(string logFilePath)
        {
            this.logFilePath = logFilePath;
        }

        public void Log(string message)
        {
            string logEntry = $"{DateTime.Now:dd.MM.yyyy HH:mm}, INFO: {message}";

            // Запись в журнал в файл
            using (StreamWriter writer = File.AppendText(logFilePath))
            {
                writer.WriteLine(logEntry);
            }
        }
    }

    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{DateTime.Now:dd.MM.yyyy HH:mm}, INFO: {message}");
        }
    }

    internal class Loger
    {
        private readonly ILogger logger;

        public Loger(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogInfo(string message)
        {
            logger.Log(message);
        }

        public void LogWarning(string message)
        {
            logger.Log($"WARNING: {message}");
        }

        public void LogError(string message)
        {
            logger.Log($"ERROR: {message}");
        }

    }
}
