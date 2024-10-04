using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KNP___dodělání_úkolu_v_hodine
{
    internal class Program
    {
       /* static int LoadAndCheckInput()
        {   int userNumImput = -1;
            Console.WriteLine("Zadej jednu akci (kamen, nuzky, papir):");
            string userImput = Console.ReadLine();

            if (userImput == "kamen") //podmínky pro vstup hrace = if neco else if (if udelej to jinak, udelas if) (switch je jednodusi ale resi pouze hodnotu promenne)
            {
                userNumInput = 0;
                // gotCorrectInput = true;
            }
            else if (userImput == "nuzky")
            {
                userNumInput = 1;
                //  gotCorrectInput = true;
            }
            else if (userImput == "papir")
            {
                userNumInput = 2;
                // gotCorrectInput = true;
            }
            else
            {
                Console.Write("Neznami vstup, zadej znovu");
            }
       return numericImput;
        }*/
        static void Main(string[] args)
        {
            Random rng = new Random();

            int userScore = 0;
            int pcScore = 0;    

            int scoreToWin = 3;

            while (userScore < scoreToWin && pcScore < scoreToWin) //použijeme while, jelikož nemáme jistotu, kolikrát kdo vyhraje && = a zároveň || = nebo
            {
               // bool gotCorrectInput = false; //hlida nam ze pokud hrac zada jiny vstup nez zadany tak musi zadat dokud ho neda
                int userNumInput = -1;
                while (userNumInput == -1) // je zadana vic ez varianta ale jinak bych napsal gotCorrectImput
                { //diky hornímu cyklu mohu nahradit pouze userNumImput = LoadAndCheckImput();
                    Console.WriteLine("Zadej jednu akci (kamen, nuzky, papir):");
                    string userImput = Console.ReadLine();

                    if (userImput == "kamen") //podmínky pro vstup hrace = if neco else if (if udelej to jinak, udelas if) (switch je jednodusi ale resi pouze hodnotu promenne)
                    {
                        userNumInput = 0;
                       // gotCorrectInput = true;
                    }
                    else if (userImput == "nuzky")
                    {
                        userNumInput = 1;
                      //  gotCorrectInput = true;
                    }
                    else if (userImput == "papir")
                    {
                        userNumInput = 2;
                       // gotCorrectInput = true;
                    }
                    else
                    {
                        Console.Write("Neznami vstup, zadej znovu\n");
                    }
                }

                int pcImput = rng.Next(3);    //Next vrací nezáporné číslo (3) = 0 , 1 , 2

                if (pcImput == 0)
                {
                    Console.WriteLine("Pocitac dal kamen");
                }
                else if (pcImput == 1)
                {
                    Console.WriteLine("pocitac dal nuzky");
                }
                else 
                {
                    Console.WriteLine("Pocitac dal papir");
                }
                //Console.Writeline(userNumImput + " " + pcImput); vypise kdo dal jaky predmet ciselnou promennou

                //podmínky pro výhru, kdo kdy vyhral
                if (userNumInput == pcImput)  //remiza
                {
                    Console.WriteLine("Doslo k remize.");
                } //prohra ((userNumImput - 1) % 3 == pcImput)
                else if ((userNumInput == 1 && pcImput == 0) //nuzky proti kameni
                    || (userNumInput == 2 && pcImput == 1) //papir proti nuzkam
                    || (userNumInput == 0 && pcImput == 2)) //kamen proti papiru
                {
                    Console.WriteLine("Prohral si");
                    pcScore++;
                }
                else //vyhra
                {
                    Console.WriteLine("Vyhrál si!");
                    userScore++;
                }
                Console.WriteLine("Aktuální skore:\nHrac: {0}\nPocitac: {1}\n", userScore, pcScore); //zápis skore
                                 //("Aktualni skore:\nHrac: " + userScore + "\nPocitac: " + pcScore)

            }

            if (userScore == 3)
            {
                Console.WriteLine("Vyhral si celou hru!");
            }
            else
            {
                Console.WriteLine("Prohral si celou hru :(");
            }

            Console.ReadKey();
        }
    }
}
