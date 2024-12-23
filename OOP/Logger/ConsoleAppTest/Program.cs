namespace ConsoleAppTest
{
    using System;
    using SOLIDLogger;
    using SOLIDLogger.Appenders;
    using SOLIDLogger.Interfaces;

    public class Program
    {
        static void Main()
        {
            // Introduce custom formatter
            IFormatter formatter = new CrazyFormatter();

            FileAppender appender = new FileAppender("file.txt", formatter);
            Logger logger = new Logger(appender);
            
            try
            {
                logger.Critical("a cannot be 5");
                logger.Critical("Out of memory");
                // CauseException();
                logger.Info("Unused local variable 'name'");
            }
            finally
            {
                appender.Close();
            }
        }

        static void CauseException()
        {
            throw new Exception();
        }
    }
}
