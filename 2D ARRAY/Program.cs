﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2024-2025.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        static void Print2DArray(int[,] arrayToPrint)
        {
            for (int i = 0; i < arrayToPrint.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToPrint.GetLength(1); j++)
                {
                    
                    Console.WriteLine(arrayToPrint[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Reset2DArray(int[,] arrayToReset) 
        {
            for (int i = 0; i < arrayToReset.GetLength(0); i++)
            {
                for (int j = 0; j < arrayToReset.GetLength(1); j++)
                {
                    arrayToReset[i, j] = i * 5 + j + 1;
                   
                }
                
            }
        }
        static void Main(string[] args)
        {
            //TODO 1: Vytvoř integerové 2D pole velikosti 5 x 5, naplň ho čísly od 1 do 25 a vypiš ho do konzole (5 řádků po 5 číslech).
            int[,] array = new int[5, 5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = i * 5 + j + 1;
                    Console.WriteLine(array[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Reset2DArray(array);
            Print2DArray(array);
            //TODO 2: Vypiš do konzole n-tý řádek pole, kde n určuje proměnná nRow.
            int nRow = 0;
            Console.WriteLine(nRow + ". radek");
            for (int i = 0; i < array.GetLength(1); i++)
            {
                Console.WriteLine(array[nRow, i]);
            }
            Console.WriteLine();
            //TODO 3: Vypiš do konzole n-tý sloupec pole, kde n určuje proměnná nColumn.
            int nColumn = 2;
            Console.WriteLine(nColumn + ". radek");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine(array[nColumn, i]);
            }
            Console.WriteLine();
            //TODO 4: Prohoď prvek na souřadnicích [xFirst, yFirst] s prvkem na souřadnicích [xSecond, ySecond] a vypiš celé pole do konzole po prohození.
            //Nápověda: Budeš potřebovat proměnnou navíc, do které si uložíš první z prvků před tím, než ho přepíšeš druhým, abys hodnotou prvního prvku potom mohl přepsat druhý
            Reset2DArray(array);
            int xFirst, yFirst, xSecond, ySecond;
            xFirst = yFirst = 0;
            xSecond = ySecond = 4;
            int temporary = array[xFirst, yFirst];
            array[xFirst, yFirst] = array[xSecond, ySecond];
            array[xSecond, ySecond] = temporary;
            Console.WriteLine("Prohozeni prvku na pozici [" + xFirst + ", " + yFirst + "] s prvkem na pozici [" + xSecond + ", " + ySecond + "]");
            Print2DArray(array);
            //TODO 5: Prohoď n-tý řádek v poli s m-tým řádkem (n je dáno proměnnou nRowSwap, m mRowSwap) a vypiš celé pole do konzole po prohození.
            int nRowSwap = 0;
            int mRowSwap = 1;
            int valueToSwap;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                valueToSwap = array[nRowSwap, i];
                array[nRowSwap, i] = array[mRowSwap, i];
                array[mRowSwap, i] = valueToSwap;
            }
            Print2DArray(array);

            //TODO 6: Prohoď n-tý sloupec v poli s m-tým sloupcem (n je dáno proměnnou nColSwap, m mColSwap) a vypiš celé pole do konzole po prohození.
            Reset2DArray(array);
            int nColSwap = 0;
            int mColSwap = 1;

            for (int i = 0; i < array.GetLength(1); i++)
            {
                valueToSwap = array[i, nColSwap];
                array[i, nColSwap] = array[i, mColSwap];
                array[i, mColSwap] = valueToSwap;
            }
           
            Print2DArray(array);
            //TODO 7: Otoč pořadí prvků na hlavní diagonále (z levého horního rohu do pravého dolního rohu) a vypiš celé pole do konzole po otočení.


            //TODO 8: Otoč pořadí prvků na vedlejší diagonále (z pravého horního rohu do levého dolního rohu) a vypiš celé pole do konzole po otočení.


            Console.ReadKey();
        }
    }
}
