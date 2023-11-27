using System;
using System.Collections;
using System.Collections.Generic;
namespace usingManyList
{
    class program
    {
        static void Main(string[] args)
        {
            List<string> langs = new List<string>();
            langs.Add("Java");
            langs.Add("Python");
            langs.Add("C");
            langs.Add("C#");
            langs.Add("C++");
            Console.WriteLine(langs.Contains("C#"));
            Console.WriteLine(langs[1]);
            Console.WriteLine(langs[2]);
            langs.Remove("C#");
            langs.Remove("C++");
            Console.WriteLine(langs.Contains("C#"));
            langs.Insert(3, "HashKell");
            langs.Sort();
            foreach (string lang in langs)
            {
                Console.WriteLine(lang);
            }
            Console.ReadLine();
        }
    }
}