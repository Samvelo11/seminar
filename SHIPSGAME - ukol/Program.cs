
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lode___zacatek
{
    internal class Program
    {

        static void arrayPlayerMap(string[] args)  // vytvoreni funkce arrayPlayerMap - mapa hrace
        {
            string[,] array = new string[10, 10];
            char[] columms = "ABCDEFGHIJ".ToCharArray(); //oznaceni radku pismeny
            Console.Write(" ");
            foreach (char columm in columms) //vypisovani pismen na radku{
            {
                Console.Write(columm +" ");
            }
            Console.WriteLine();



            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write((i + 1) + " "); 

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = "-";
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void arrayUserImput(string[] args)
        {
            string[] ships = { "Letadlova lod" , "Kriznik", "Ledoborec", "Torpedoborec"};
            string ship = Console.ReadLine();
            int pozice = Array.IndexOf(ships, ship);
         
            Console.ReadKey();
        }
           
        static void Main(string[] args)
        {

            Console.WriteLine("pridej lode na souradnice (letadlova lod, bitevni lod, kriznik, ponorka, torpedoborec)");
            Console.WriteLine();

            arrayPlayerMap(args);
            arrayUserImput(args);
            Console.ReadKey();
        }
    }
}




       


    

