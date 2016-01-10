namespace OOPExam20December.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Factories;
    using Interfaces;
    using IO;
    using Models;

    public class Engine : IEngine
    {

        private readonly IBlobFactory blobFactory;
        private readonly IBlobData data;
        private readonly IInputReader reader;
        private readonly IOutputWriter writer;

        public Engine(
            IBlobFactory blobFactory,
            IBlobData data,
            IInputReader reader,
            IOutputWriter writer)
        {
            this.blobFactory = blobFactory;
            this.data = data;
            this.reader = reader;
            this.writer = writer;
            
        }


        public virtual void Run()
        {
            while (true)
            {
                string[] input = this.reader.ReadLine().Split();
                this.ExecuteCommand(input);
                

            }
        }

        private void ExecuteCommand(string[] input)
        {
            switch (input[0])
            {
                case "create":
                    if (input[4].Equals("Inflated"))
                    {
                        var inflatedHealthBonus = input[2] + 50;
                        var blob = this.blobFactory.CreateBLob(input[1], int.Parse(inflatedHealthBonus), int.Parse(input[3]), input[4], input[5]);
                        this.AddBolb(blob);
                    }
                    if (input[4].Equals("Aggressive"))
                    {
                        int aggresiveDamageBonus = int.Parse(input[3])*2;
                        var blob = this.blobFactory.CreateBLob(input[1], aggresiveDamageBonus, int.Parse(input[3]), input[4], input[5]);
                        this.AddBolb(blob);
                    }
                    break;
                case "attack":
                    break;
                case "status":
                    this.ExecuteStatusCommand();
                    break;
                case "pass":
                    break;
                case "drop":
                    Environment.Exit(0);
                    break;
            }
        }

        
                
            

        


        public void AddBolb(IBlob blob)
        {
            this.data.AddBlob(blob);
        }

        private void ExecuteStatusCommand()
        {
            StringBuilder output = new StringBuilder();
            
            foreach (var blob in this.data.Blobs)
            {
                output.Append("Blob ");
                output.Append(blob);
            }

            this.writer.WriteLine(output.ToString().Trim());
        }
    }
}
