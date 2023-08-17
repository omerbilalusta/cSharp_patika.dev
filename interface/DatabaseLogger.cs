using System;

namespace arayuzler
{
    public class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            //throw new NotImplementedException();
            Console.WriteLine("Database'e yazar.");
        }
    }
}