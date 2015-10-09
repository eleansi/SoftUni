using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MinMaxAvg
    {
        static void Main()
        {
            string input = Console.ReadLine();
            double[] numbers = input.Split().Select(double.Parse).ToArray();
            List<double> roundNum = new List<double>();
            List<double> zeroFractNum = new List<double>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 1 != 0)
                {
                    zeroFractNum.Add(numbers[i]);
                }
                else
                {
                    roundNum.Add(numbers[i]);
                }
            }

            Console.WriteLine("Zero Fractional Numbers");
            zeroFractNum.ForEach(a => Console.WriteLine(a + " "));
            Console.WriteLine("max = {0}", zeroFractNum.Max());
            Console.WriteLine("min = {0}", zeroFractNum.Min());
            Console.WriteLine("sum = {0}", zeroFractNum.Sum());
            Console.WriteLine("avg = {0}", zeroFractNum.Average());
            Console.WriteLine("Round Numbers");
            roundNum.ForEach(a => Console.WriteLine(a + " "));
            Console.WriteLine("max = {0}", roundNum.Max());
            Console.WriteLine("sum = {0}", roundNum.Sum());
            Console.WriteLine("min = {0}", roundNum.Min());
            Console.WriteLine("avg = {0}", roundNum.Average());
        }
    }

