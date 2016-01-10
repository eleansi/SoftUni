namespace OOPExam20December.IO
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Interfaces;

    public class ConsoleReader : IInputReader
    {
        /// <summary>
        /// Reading from the console or other resource.
        /// </summary>
        /// <returns></returns>
        public string ReadLine()
        {
            var input = Console.ReadLine();

            return input;
        }
    }
}
