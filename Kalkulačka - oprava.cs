using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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

            string continueNum = "ano";
            while (continueNum == "ano") //cyklus na opakovani programu,pokud uzivatel bude chtit
            {


                Console.WriteLine("Zadej hodnoty:");
                float firstNum;
                while (!float.TryParse(Console.ReadLine(), out firstNum)) //zadání vstupu cisel, hlida aby bylo zadané číslo
                    Console.WriteLine("Neplatna hodnota" + " zadej prvni cislo znovu:");

                float secondNum;
                while (!float.TryParse(Console.ReadLine(), out secondNum))
                    Console.WriteLine("Neplatna hodnota" + " zadej druhe cislo znovu:");

                Console.WriteLine("Zadej pocetní operaci: +, -, *, /"); //vstup pro pocetni operaci
                string operation;

                while (true)
                {
                  operation = Console.ReadLine();

                    if (operation == "+" || operation == "-" || operation == "*" || operation == "/") // hlida pokud zadam spatnou operaci
                    {
                        break; //ukonci smycku dokud neni operace spravna
                    }
                    else
                    {
                        Console.WriteLine("Zadej spravne pocetni operaci: +, -, *, /");
                    }
                }

                float answer = 0; //pocatecni hodnota

                        if (operation == "+") //pocetni operace
                        {
                            answer = firstNum + secondNum;
                        }
                        else if (operation == "-")
                        {
                            answer = firstNum - secondNum;
                        }
                        else if (operation == "*")
                        {
                            answer = firstNum * secondNum;
                        }
                        else if (operation == "/")
                        {
                            if (secondNum == 0) //nelze delit nulou
                            {
                                Console.WriteLine("Nelze dělit nulou!");
                            }
                            answer = firstNum / secondNum;

                        }
                        else
                        {
                            Console.WriteLine("Spatny znak, Zadej znovu:");
                            return;
                        }

                        Console.WriteLine("Vysledek je " + answer);

               
                Console.WriteLine("Pokud chcete pokracovat, zadejte [ano]");

                 continueNum = Console.ReadLine(); //pokud zvolime ano, program se zopakuje
                    

         

            }
            
        }
    }
}
