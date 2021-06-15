using System;
namespace ConsoleApplication
{
    public class Myclass
    {
        public delegate void LogHandlerv(string message);
        public void process(LogHandlerv logHandler)
        {
            if (logHandler != null)
            {
                logHandler("begin");
            }
            if (logHandler != null)
            {
                logHandler("End");
            }
        }
        public class Mylogger
        {
            public void logger(string s)
            {
                Console.WriteLine(s);
            }
        }
        public class TestApplication
        {
            static void Logger(string s)
            {
                Console.WriteLine(s);
            }
            static void Main(string[] args)
            {
                Mylogger f1 = new Mylogger();
                Myclass myclass = new Myclass();
                Myclass.LogHandlerv myLogger = null;
                myLogger += new Myclass.LogHandlerv(Logger);
                myLogger += new Myclass.LogHandlerv(f1.logger);
                myclass.process(myLogger);
                return;
            }
        }
    }
}
