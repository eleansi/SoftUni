namespace ConsoleAppTest
{
    using System;
    using SOLIDLogger;
    using SOLIDLogger.Interfaces;

    public class CrazyFormatter : IFormatter
    {
        public string Format(string msg, ReportLevel level, DateTime date)
        {
            return string.Format("{0} <<{1}>> ??{2}??",
                msg, date, level);
        }
    }
}
