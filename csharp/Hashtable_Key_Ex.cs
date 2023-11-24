using System;
using System.Collections;
namespace Hashtable_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", "Ayushi");
            ht.Add("002", "Om");
            ht.Add("003", "Khushi");
            if (ht.ContainsValue("Nishu"))
            {
                Console.WriteLine("This Name is Alredy in List");
            }
            else
            {
                ht.Add("004", "Nishu");
            }
            //Get A Collection Of the Key
            ICollection key= ht.Keys;
            foreach(String k in key)
            {
                Console.WriteLine(k+" " + ht[k]);
            }
            Console.ReadLine();
        }
    }
}