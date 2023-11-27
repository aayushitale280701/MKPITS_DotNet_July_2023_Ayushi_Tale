using System;
using System.Collections;
using System.Collections.Generic;
namespace EXDictionaryCollection
{
    class Program
    {
        static void Main (string[] args)
        {
            Dictionary<string, String> domains = new Dictionary<string, String> ();
            domains.Add("De", "Germany");
            domains.Add("Sk", "Slovakia");
            domains.Add("Us", "United States");
            domains.Add("Ru", "Russia");
            domains.Add("Hu", "Hungary");
            domains.Add("Pl", "Poland");
            Console.WriteLine(domains ["Sk"]);
            Console.WriteLine(domains ["De"]);
            Console.WriteLine("Dictionary has {0} items: ", domains.Count);
            Console.WriteLine("Key of the Dictionary: ");

            List<string> keys= new List<string> (domains.Keys);
            foreach (string key in keys)
            {
                Console.WriteLine ("{0} ",key);
            }
            Console.WriteLine("Value of the dictionary ");

            List<String> vals=new List<String> (domains.Values);
            foreach (string val in vals)
            {
                Console.WriteLine("{0} ", val);
            }
            Console.WriteLine("Key and Values of the dictionary ");

            foreach (KeyValuePair<string, String> KeyValuePair in domains) 
            {
                Console.WriteLine("Key - {0}, value = {1} ",KeyValuePair.Key,KeyValuePair.Value );
            }
        }
    }
}