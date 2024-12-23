namespace Methods
{
    using System;

    public class MainProgram
    {
       public static void Main()
        {
            Console.WriteLine(Calculator.CalculateTriangleArea(3, 4, 5));
            
            Console.WriteLine(Formatter.ConvertingNumberToDigit(5));
            
            Console.WriteLine(Calculator.FindMax(5, -1, 3, 2, 14, 2, 3));

            Formatter.FormatNumber(1.3, "f");
            Formatter.FormatNumber(0.75, "%");
            Formatter.FormatNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(Calculator.CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

           Student peter = new Student
           {
               FirstName = "Peter",
               LastName = "Ivanov",
               OtherInfo = "From Sofia, born at 17.03.1992"
           };

           Student stella = new Student
           {
               FirstName = "Stella",
               LastName = "Markova",
               OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993"
           };

           Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThanOther(stella));
        }
    }
}
