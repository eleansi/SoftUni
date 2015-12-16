namespace SOLIDLogger.Appenders
{
    using System;
    using Interfaces;

    public abstract class Appender : IAppender
    {
        private IFormatter formatter;

        protected Appender(IFormatter formatter)
        {
            this.Formatter = formatter;
        }

        public IFormatter Formatter
        {
            get { return this.formatter; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(
                        "Formatter cannot be null");
                }

                this.formatter = value;
            }
        }

        public abstract void Append(string message, ReportLevel level, DateTime date);
    }
}
