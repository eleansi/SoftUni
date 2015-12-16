namespace SOLIDLogger.Interfaces
{
    using System;

    public interface IAppender
    {
        IFormatter Formatter { get; set; }

        void Append(string message, ReportLevel level, DateTime date);
    }
}
