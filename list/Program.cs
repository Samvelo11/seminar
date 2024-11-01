using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    internal class Program
    {
        static void PrintList(List<string> list)
        {
           foreach (string name in list)
            {
                Console.WriteLine(name);
            } 
           Console.WriteLine();
        }
        static void Main(string[] args)
        {
            List<string> myStringList = new List<string>();
            myStringList.Add("Karel");
            myStringList.Add("Otakar");
            myStringList.Add("Lojza");
            myStringList.Add("Adelka");
            myStringList.Add("Andromeda");
            myStringList.Add("Sara");

            PrintList(myStringList);

            myStringList.Remove("Karel");

            PrintList(myStringList);

            myStringList.RemoveAt(2);

            PrintList(myStringList);

            if (myStringList.Exists(name => name.StartsWith("A")))
            {
                Console.WriteLine("List obsahuje jmeno na A");
            }
            else
            {
                Console.WriteLine("List nema jmeno na A");
            }

            Dictionary<string, string> favoriteFoods = new Dictionary<string, string>();
            favoriteFoods["Karel"] = "Buchticky se sodo";
            favoriteFoods["Otakar"] = "Tortila";
            favoriteFoods["Lojza"] = "mac and cheese";
            favoriteFoods["Adelka"] = "Sushi";
            favoriteFoods["Andromeda"] = "Smazeny kvetak";
            favoriteFoods["Sara"] = "Rizek s bramborem";

            foreach(KeyValuePair<string, string> studentAndFood in favoriteFoods)
            {
                string name = studentAndFood.Key;
                string food = studentAndFood.Value;
                Console.WriteLine("Oblibene jidlo studenta " + name + " je " + food);
            }

            if (favoriteFoods.ContainsKey("Martin"))
            {
                Console.WriteLine("Martin je v seznamu a ma fav jidlo");
            }
            else
            {
                Console.WriteLine("Martin neni v seznamu a zije z energie vesmiru");
            }

            Console.ReadKey();

        }
    }
}
