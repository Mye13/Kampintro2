using System;
using System.Collections.Generic;
using System.Text;

namespace OOP32
{
    class SmsLoggerService : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Sms yollandı.");
        }
    }
}
