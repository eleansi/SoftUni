using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.OlimpycsAreComming
{
    class OlimpycsAreComming
    {
        static void Main(string[] args)
        {
            // First Way 
            //var data = new Dictionary<string, List<string>>();
            //string line = Console.ReadLine();

            //while (line != "report")
            //{
            //    string[] names = line.Split('|');
            //    string athlete = names[0];
            //    string country = names[1];

            //    athlete = Regex.Replace(athlete, @"\s{2,}", " ").Trim();
            //    country = Regex.Replace(country, @"\s{2,}", " ").Trim();

            //    if (!data.ContainsKey(country))
            //    {
            //        data.Add(country, new List<string>());
            //    }
            //    data[country].Add(athlete);

            //    line = Console.ReadLine();
            //}

            //var orderData = data.OrderByDescending(x => x.Value.Count);

            //foreach (var pair in orderData)
            //{
            //    Console.WriteLine("{0} ({1} participants): {2} wins", pair.Key, 
            //                                                          pair.Value.Distinct().Count(),
            //                                                          pair.Value.Count());
            //}




            var countries = new List<Country>();

            string line = Console.ReadLine();

            while (line != "report")
            {
                string[] names = line.Split('|');
                string athlete = names[0];
                string countryName = names[1];

                athlete = Regex.Replace(athlete, @"\s{2,}", " ").Trim();
                countryName = Regex.Replace(countryName, @"\s{2,}", " ").Trim();

                Country country = countries.FirstOrDefault(c => c.Name == countryName);

                if (country == null)
                {
                    country = new Country(countryName);
                    countries.Add(country);
                }

                country.AddRecord(athlete);

                line = Console.ReadLine();
            }

            var ordered = countries.OrderByDescending(c => c.Wins);
            foreach (var order in ordered)
            {
                Console.WriteLine("{0} ({1} participants): {2} wins", order.Name, order.CountOfParticipants,order.Wins);
            }
        }

        private class Country 
        {
            private HashSet<string> participants;
            public Country(string name) 
            {
                this.Name = name;
                this.participants = new HashSet<string>();
            }
            public string Name { get; private set; }
            public int Wins { get; private set; }
            public int CountOfParticipants
            {
                get
                {
                    return this.participants.Count();
                }
            }
            public void AddRecord(string athleteName) 
            {
                this.Wins++;
                this.participants.Add(athleteName);
            }
        }
    }
}
