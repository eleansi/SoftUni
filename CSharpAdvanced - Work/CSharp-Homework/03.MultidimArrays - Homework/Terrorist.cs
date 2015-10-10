using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.TerroristWin
{
    class Terrorist
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            StringBuilder inputTextAsStringBuilder = new StringBuilder(inputText);
            int startIndex = inputText.IndexOf('|');
            int endIndex = 0;
            int unicodeSum = 0;
            int destroyedArea = 0;
            while (startIndex != -1)
            {
                unicodeSum = 0;
                endIndex = inputText.IndexOf('|', startIndex + 1);
                if (endIndex <= startIndex)
                {
                    break;
                }
                for (int i = startIndex + 1; i <= endIndex - 1; i++)
                {
                    unicodeSum += inputText[i];
                    inputTextAsStringBuilder[i] = '.';
                }
                destroyedArea = unicodeSum % 10;

                for (int i = startIndex; i >= startIndex - destroyedArea && i >= 0; i--)
                {
                    inputTextAsStringBuilder[i] = '.';
                }
                for (int i = endIndex; i <= endIndex + destroyedArea && i < inputTextAsStringBuilder.Length; i++)
                {
                    inputTextAsStringBuilder[i] = '.';
                }

                startIndex = inputText.IndexOf('|', endIndex + 1);
            }
            Console.WriteLine(inputTextAsStringBuilder);
        }
    }
}
