using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WordCount
{
    class WordCount
    {
        static void Main(string[] args)
        {
            StreamReader wordsReader = new StreamReader("../../words.txt");
            StreamReader textReader = new StreamReader("../../text.txt");
            StreamWriter resultWriter = new StreamWriter("../../result.txt");

            using (wordsReader)
            {
                using (textReader)
                {
                    using (resultWriter)
                    {
                        List<string> words = new List<string>();
                        string line = wordsReader.ReadLine();
                        while (line != null)
                        {
                            words.Add(line);
                            line = wordsReader.ReadLine();
                        }

                        List<int> wordsCount = new List<int>();

                        List<string> text = new List<string>();
                        line = textReader.ReadLine();
                        while (line != null)
                        {
                            text.Add(line);
                            line = textReader.ReadLine();
                        }

                        for (int i = 0; i < words.Count; i++)
                        {
                            wordsCount.Add(0);
                            for (int j = 0; j < text.Count; j++)
                            {
                                if (text[j].ToLower().Contains(words[i].ToLower()))
                                {
                                    wordsCount[i]++;
                                }
                            }
                        }

                        Dictionary<string, int> dict = new Dictionary<string, int>();

                        for (int i = 0; i < words.Count; i++)
                        {
                            dict[words[i]] = wordsCount[i];
                        }

                        var ordered = dict.OrderByDescending(x => x.Value);

                        foreach (var item in ordered)
                        {
                            resultWriter.WriteLine("{0} - {1}", item.Key, item.Value);
                        }

                    }
                }
            }
        }
    }
}
