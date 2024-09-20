using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace kamen_nužky_papir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            /* for (int i = 0; i < 10; i++)
            {


                int a = rng.Next(100);
                if (a > 50)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Proměna byla menší než 50!");
                }
            }
            Console.ReadKey();
            */

            bool canContinue = true;
            while (canContinue)
            {
              
                int a = rng.Next(100);
                Console.WriteLine(a);

                string userImput = Console.ReadLine();
                if (userImput == "n" || userImput == "N" || userImput == "x")
                {
                    canContinue = false;
                    Console.WriteLine("Uživatel chce skončit.");
                }
            }
            string text;
            int yesOrNO = rng.Next(100);
            if (yesOrNO > 50)
            {
                text = "yes";
            }
            else
            {
                text = "no";
            }
            Console.WriteLine(text);
            Console.ReadKey();
        }
       
    }
}
