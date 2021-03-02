using System;

namespace Business.CCS
{
    public class DataFileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
