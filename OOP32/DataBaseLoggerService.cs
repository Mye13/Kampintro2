using System;
using System.Collections.Generic;
using System.Text;

namespace OOP32
{
    class DataBaseLoggerService : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı.");
        }
    }
}
