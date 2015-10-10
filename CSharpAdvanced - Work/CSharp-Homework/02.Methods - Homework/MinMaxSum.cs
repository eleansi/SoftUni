using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MinMaxSum
{
    static void Main()
    {
        dynamic[] decimalArr = { 2.3m, 5.6m, 4.2m, 0.22m, 0.88m, 1.22m, 2.12m, 1.45m, 5.55m };
        dynamic[] intArr = { 2, 3, 6, 8, 9923, 12457,918857, 546, 23981, 9};
        Console.WriteLine("The minimum value from decimal array is {0} and from integer array is {1}", Min(decimalArr), Min(intArr));
        Console.WriteLine("The maximum value from decimal array is {0} and from integer array is {1}", Max(decimalArr), Max(intArr));
        Console.WriteLine("The sum value from decimal array is {0} and from integer array is {1}", Sum(decimalArr), Sum(intArr));
        Console.WriteLine("The product value from decimal array is {0} and from integer array is {1}", Product(decimalArr), Product(intArr));
        Console.WriteLine("The average value from decimal array is {0} and from integer array is {1}", Average(decimalArr), Average(intArr));


    }
    static dynamic Max(dynamic[] array) 
    {
        dynamic maxValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (maxValue < array[i])
            {
                maxValue = array[i]; 
            }
        }
        return maxValue;
    }
    static dynamic Min(dynamic[] array) 
    {
        dynamic minValue = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (minValue > array[i])
            {
                minValue = array[i];
            }
               
        }
        return minValue;
    }
    static dynamic Sum(dynamic[] array) 
    {
        dynamic sum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            sum += array[i];
        }
        return sum;
    }
    static dynamic Average(dynamic[] array) 
    {
        dynamic average = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            average += array[i];
        }
        average = average / array.Length;
        return average;
    }
    static dynamic Product(dynamic[] array) 
    {
        dynamic product = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            product *= array[i];
        }
        return product;
    }
}

