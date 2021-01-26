using System;

namespace OOP32
{
    class FileLoggerService : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı.");
        }
    }
}
