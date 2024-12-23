using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPExam20December
{
    using Core;
    using Core.Factories;
    using IO;
    using Models;

    class MainClass
    {
        static void Main(string[] args)
        {
            
            var blobFactory = new BlobFactory();
            var reader =  new ConsoleReader();
            var writer = new ConsoleWriter();
            var data = new BlobData();
            

            var engine = new Engine(blobFactory, data, reader, writer);
            engine.Run();
        }
    }
}
