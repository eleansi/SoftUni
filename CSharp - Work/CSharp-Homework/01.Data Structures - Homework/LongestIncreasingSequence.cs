using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LongestIncreasingSequence
{
    static void Main()
    {

        //int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
        //Dictionary<int, List<int>> sorted = new Dictionary<int, List<int>>();
        //sorted[0] = new List<int>();
        //sorted[0].Add(nums[0]);
        //for (int i = 1, index = 0; i < nums.Length; i++)
        //{
        //    if (nums[i] < nums[i - 1] || nums[i] == nums[i - 1])
        //    {
        //        index++;
        //    }
        //    if (!sorted.Keys.Contains(index))
        //    {
        //        sorted[index] = new List<int>();
        //    }
        //    sorted[index].Add(nums[i]);
        //}
        //foreach (var key in sorted.Keys)
        //{
        //    Console.WriteLine(string.Join(" ", sorted[key]));
        //}
        //var longest = sorted.OrderByDescending(a => a.Value.Count);
        //Console.WriteLine("Longest = {0}", string.Join(" ", longest));

        // На Longest ми дава следният Exception 
        //Longest = 
        //[2, System.Collections.Generic.List`1[System.Int32]]
        //[0, System.Collections.Generic.List`1[System.Int32]] 
        //[1, System.Collections.Generic.List`1[System.Int32]]
        // Moже ли някакъв Feedback тъй като не можах да намеря проблема. Благодаря предварително!


        // Solution with List instead of Dictionary
       
        
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            List<int> temp = new List<int>();
            List<int> longest = new List<int>();

            for (int i = 0, j = 1; i < numbers.Length; i++, j++)
            {

                temp.Add(numbers[i]);
                
                if ((j < numbers.Length) && (numbers[i] <= numbers[j]))
                {
                    continue;
                }
                else
                {
                    if (temp.Count > longest.Count)
                    {
                        longest.Clear();
                        longest.AddRange(temp);
                        Console.WriteLine(string.Join(" ", temp));
                        temp.Clear();
                    }
                    else
                    {
                        Console.WriteLine(string.Join(" ", temp));
                        temp.Clear();
                    }
                }
            }

            Console.WriteLine("Longest: " + string.Join(" ", longest));
     }
 }

