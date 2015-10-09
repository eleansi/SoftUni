using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> phonebook = new Dictionary<string, List<string>>();
            string contactInfo = Console.ReadLine();
            string[] contacts;
            string contactName = String.Empty;
            string contactNumber = String.Empty;


            while (contactInfo != "search")
            {
                contacts = contactInfo.Split(new char[] {'-'}, StringSplitOptions.RemoveEmptyEntries);
                contactName = contacts[0];
                contactNumber = contacts[1];
                if (!phonebook.ContainsKey(contactName))
                {
                    phonebook[contactName] = new List<string>();
                }
                contactInfo = Console.ReadLine();
            }

            string searching = Console.ReadLine();
            while (!String.IsNullOrEmpty(searching))
            {
               if (phonebook.ContainsKey(searching))
                {
                    Console.WriteLine("{0} --> {1}", searching, String.Join("-", contactNumber));
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist", contactName);
                }
                searching = Console.ReadLine();
            }
        }
    }
}
