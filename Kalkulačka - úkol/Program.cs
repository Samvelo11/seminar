﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulačka___úkol
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
             * ZADANI
             * Vytvor program ktery bude fungovat jako kalkulacka. Kroky programu budou nasledujici:
             * 1) Nacte vstup pro prvni cislo od uzivatele (vyuzijte metodu Console.ReadLine() - https://learn.microsoft.com/en-us/dotnet/api/system.console.readline?view=netframework-4.8.
             * 2) Zkonvertuje vstup od uzivatele ze stringu do integeru - https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/types/how-to-convert-a-string-to-a-number.
             * 3) Nacte vstup pro druhe cislo od uzivatele a zkonvertuje ho do integeru. (zopakovani kroku 1 a 2 pro druhe cislo)
             * 4) Nacte vstup pro ciselnou operaci. Rozmysli si, jak operace nazves. Muze to byt "soucet", "rozdil" atd. nebo napr "+", "-", nebo jakkoliv jinak.
             * 5) Nadefinuj integerovou promennou result a prirad ji prozatimne hodnotu 0.
             * 6) Vytvor podminky (if statement), podle kterych urcis, co se bude s cisly dit podle zadane operace
             *    a proved danou operaci - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements.
             * 7) Vypis promennou result do konzole
             * 
             * Rozsireni programu pro rychliky / na doma (na poradi nezalezi):
             * 1) Vypis do konzole pred nactenim kazdeho uzivatelova vstupu co po nem chces (aby vedel, co ma zadat)
             * 2) a) Kontroluj, ze uzivatel do vstupu zadal, co mel (cisla, popr. ciselnou operaci). Pokud zadal neco jineho, napis mu, co ma priste zadat a program ukoncete.
             * 2) b) To same, co a) ale misto ukonceni programu opakovane cti vstup, dokud uzivatel nezada to, co ma
             *       - https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements#the-while-statement
             * 3) Umozni uzivateli zadavat i desetinna cisla, tedy prekopej kalkulacku tak, aby umela pracovat s floaty
             */

            Console.WriteLine("Zadej hodnoty:");
            string firstNumImput = Console.ReadLine(); //zadání vstupu cisel

            float firstNum;
            if (!float.TryParse(firstNumImput, out firstNum)) //TryParse ověruje hodnotu desetinnych cisel na tuto část jsem použil kod z chat gpt
            {
                Console.WriteLine("Zadal jsi neplatne cislo.");
                return;
            }

            string secondNumImput = Console.ReadLine(); //zadání vstupu druheho cisla
            float secondNum;
            if (!float.TryParse(secondNumImput, out secondNum)) //konvertování na float
            {
                Console.WriteLine("Zadal jsi neplatne cislo.");
                return;
            }

            Console.WriteLine("Zadej pocetní operaci: +, -, *, /"); //vstup pro pocetni operaci
            string operace = Console.ReadLine();

            float answer = 0;

            if (operace == "+")
            {
                answer = firstNum + secondNum;
            }
            else if (operace == "-")
            {
                answer = firstNum - secondNum;
            }
            else if (operace == "*")
            {
                answer = firstNum * secondNum;
            }
            else if (operace == "/")
            {
               if (secondNum == 0)
                {
                    Console.WriteLine("Nelze dělit nulou!");
                }
                answer = firstNum / secondNum;   
            }

            Console.WriteLine(answer);

            Console.ReadKey();
        }
    }
}
