namespace OOPExam20December.IO
{
    
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;
    public class ConsoleWriter : IOutputWriter
    {
        /// <summary>
        /// Writing to the console or other resource
        /// </summary>
        /// <param name="input"></param>
        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}
