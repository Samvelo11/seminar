

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace ArrayPlayground
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové pole a naplň ho pěti libovolnými čísly.
            int[] myArray = { 10, 20, 30, 40, 50 };


            //TODO 2: Vypiš do konzole všechny prvky pole, zkus jak klasický, kde i využiješ jako index v poli, takeach.
            Console.WriteLine("Vypisovano for cyklem");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            Console.WriteLine("Vypisovano foreach cyklem");
            foreach (int number in myArray)
            {
                Console.WriteLine(number);
            }
            //TODO 3: Spočti sumu všech prvků v poli a vypiš ji uživateli.
            int sum = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sum += myArray[i];              // += - pricita dosavadni hodnotu + vetsi nasledujici
            }

            Console.WriteLine("Suma: " + sum);

            //TODO 4: Spočti průměr prvků v poli a vypiš ho do konzole.
            int average = sum / myArray.Length;

            Console.WriteLine("Prumer je: " + average);


            //TODO 5: Najdi maximum v poli a vypiš ho do konzole.
            int max = myArray.Max();
            Console.WriteLine("Maximum je: " + max);
            //TODO 6: Najdi minimum v poli a vypiš ho do konzole.
            int min = myArray.Min();
            Console.WriteLine("Minimum je: " + min);

            //TODO 7: Vyhledej v poli číslo, které zadá uživatel, a vypiš index nalezeného prvku do konzole.
            Console.WriteLine("Napis cislo, ktere chces najit:");
            int numberToFind = int.Parse(Console.ReadLine());
            // bool foundNumber = false;
            int foundIndex = -1;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] == numberToFind)
                {
                    //foundNumber = true;
                    foundIndex = i;
                    break;
                }
            }

            if (foundIndex == -1)
            {
                Console.WriteLine("Cislo v poli neni!");
            }
            else
            {
                Console.WriteLine("Index cisla " + numberToFind + " je " + foundIndex);
            }

            //TODO 8: Přepiš pole na úplně nové tak, že bude obsahovat 100 náhodně vygenerovaných čísel od 0 do 9.
            Random rng = new Random();
            int[] myArray2 = new int[100];

            for (int i = 0; i < myArray2.Length; i++)
            {
                myArray2[i] = rng.Next(0, 10);
            }
            Console.WriteLine(myArray2);
            //TODO 9: Spočítej kolikrát se každé číslo v poli vyskytuje a spočítané četnosti vypiš do konzole.
            int[] counts = new int[10];

            foreach (int number in myArray2)
            {
                counts[number]++;
            }
            
            for (int i = 0; i < counts.Length; i++)
            {
                //Console.WriteLine("Cetnost cislice " + i + " je " counts[i]);
            }

            //TODO 10: Vytvoř druhé pole, do kterého zkopíruješ prvky z prvního pole v opačném pořadí.
            int[] reversedArray = new int[10];

            for (int i = 0;i < reversedArray.Length; i++)
            {
                reversedArray[i] = myArray2[myArray2.Length - 1 - i];
                Console.Write(reversedArray[i] + " ");
            }

            //Zkus is dál hrát s polem dle své libosti. Můžeš třeba prohodit dva prvky, ukládat do pole prvky nějaké posloupnosti (a pak si je vyhledávat) nebo cokoliv dalšího tě napadne

            Console.ReadKey();
        }
    }
}
