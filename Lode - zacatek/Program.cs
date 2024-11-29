using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode___zacatek
{
    internal class Program
    {
        static void arrayPlayerMap(string[] args)
        {
            string[,] array = new string[10, 10];
            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = "-";
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            int[,] array = new int[10, 10];
            for (int i = 0; i < array.GetLength(0); i++) 
            {
                
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i * 10 + j + 1;
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("pridej lode na souradnice (letadlova lod, bitevni lod, kriznik, ponorka, torpedoborec");
            Console.WriteLine("p");

                arrayPlayerMap(args);

            Console.ReadKey();
        }
    }
}
