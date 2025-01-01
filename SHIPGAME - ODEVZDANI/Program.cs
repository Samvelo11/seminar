using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIPGAME
{
    class Program
    {
        static char[,] playerBoard = new char[10, 10]; //herni pole hrace
        static char[,] computerBoard = new char[10, 10]; //herni pole pocitace
        static char[,] computerView = new char[10, 10]; //hracuv pohled na pole pocitace
        static Random random = new Random();


        static void ArrayBoard(char[,] board) //vytvoreni herniho pole
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    board[i, j] = '-';
                }
            }
        }

        static void ShowBoard(char[,] board) //zobrazeni herniho pole
        {
            Console.Write("  A B C D E F G H I J\n"); //sloupce
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1).ToString().PadLeft(2) + " "); //radky
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void PlaceShipsManually(char[,] board) //rucni umisteni lodi do pole
        {
            var ships = new Dictionary<string, int>
            {
                {"Letadlová loď", 5},
                {"Bitevní loď", 4},
                {"Křižník", 3},
                {"Ponorka", 3},
                {"Torpédoborec", 2}
            };

            foreach (var ship in ships) //umisteni kazde lodi
            {
                Console.WriteLine($"Umístěte {ship.Key} (velikost {ship.Value}):");
                while (true)
                {
                    Console.Write("Zadejte počáteční souřadnice (např. A1): ");
                    string start = Console.ReadLine().ToUpper(); //nacteni souradnic
                    Console.Write("Zadejte orientaci (H = horizontální, V = vertikální): ");
                    char orientation = Char.ToUpper(Console.ReadKey().KeyChar); //orientace lodi
                    Console.WriteLine();

                    if (PlaceShip(board, start, orientation, ship.Value))
                    {
                        break; //pokud lod umistena tak pokracujeme
                    }
                    Console.WriteLine("Neplatné umístění. Zkuste to znovu.");
                }
                ShowBoard(board);
            }
        }

        static void PlaceShipsRandomly(char[,] board) //pocitac rozhodi lode nahodne
        {
            var ships = new List<int> { 5, 4, 3, 3, 2 };

            foreach (var shipSize in ships)
            {
                while (true)
                {
                    int row = random.Next(10); //radek
                    int col = random.Next(10); //sloupec
                    char orientation = random.Next(2) == 0 ? 'H' : 'V'; //orientace

                    if (PlaceShip(board, $"{(char)('A' + col)}{row + 1}", orientation, shipSize))
                    {
                        break;
                    }
                }
            }
        }

        static bool PlaceShip(char[,] board, string start, char orientation, int size) //umisteni lodi do pole (zde jsem cerpal hodne z umele inteligence a ruznych webu)
        {
            if (start.Length < 2 || !char.IsLetter(start[0]) || !char.IsDigit(start[1]))
                return false;

            int col = start[0] - 'A';
            int row = int.Parse(start.Substring(1)) - 1;

            if (row < 0 || row >= 10 || col < 0 || col >= 10)
                return false;

            int dRow = orientation == 'V' ? 1 : 0;
            int dCol = orientation == 'H' ? 1 : 0;

            for (int i = 0; i < size; i++)
            {
                int newRow = row + i * dRow;
                int newCol = col + i * dCol;

                if (newRow < 0 || newRow >= 10 || newCol < 0 || newCol >= 10 || board[newRow, newCol] != '-')
                    return false;
            }

            for (int i = 0; i < size; i++)
            {
                board[row + i * dRow, col + i * dCol] = 'L';
            }

            return true;
        }

        static void PlayerTurn() //hraje hrac
        {
            while (true)
            {
                Console.Write("Zadejte souřadnice střelby (např. A1): ");
                string target = Console.ReadLine().ToUpper(); //souradnice strelby

                if (target.Length < 2 || !char.IsLetter(target[0]) || !char.IsDigit(target[1]))
                {
                    Console.WriteLine("Neplatné souřadnice. Zkuste to znovu.");
                    continue;
                }

                int col = target[0] - 'A';
                int row = int.Parse(target.Substring(1)) - 1;

                if (row < 0 || row >= 10 || col < 0 || col >= 10 || computerView[row, col] != '-')
                {
                    Console.WriteLine("Na tuto pozici již bylo stříleno. Zkuste to znovu.");
                    continue;
                }

                if (computerBoard[row, col] == 'L')
                {
                    Console.WriteLine("Zásah!");
                    computerView[row, col] = 'X';
                    computerBoard[row, col] = 'X';
                }
                else
                {
                    Console.WriteLine("Vedle.");
                    computerView[row, col] = 'O';
                }
                break;
            }
        }

        static void ComputerTurn() //hraje pocitac
        {
            while (true)
            {
                int row = random.Next(10);
                int col = random.Next(10);

                if (playerBoard[row, col] == 'X' || playerBoard[row, col] == 'O')
                {
                    continue;
                }

                Console.WriteLine($"Počítač střílí na {(char)('A' + col)}{row + 1}");

                if (playerBoard[row, col] == 'L')
                {
                    Console.WriteLine("Počítač zasáhl vaši loď!");
                    playerBoard[row, col] = 'X';
                }
                else
                {
                    Console.WriteLine("Počítač minul.");
                    playerBoard[row, col] = 'O';
                }
                break;
            }
        }

        static bool IsGameOver(char[,] board) //kontroluje zda je hra u konce
        {
            foreach (char cell in board)
            {
                if (cell == 'L')
                {
                    return false; //pokud zbyva jeste lod tak hra pokracuje
                }
            }
            return true; //pokud nezbyvaji lode hra konci
        }


        static void Main(string[] args)
        {
            ArrayBoard(playerBoard);
            ArrayBoard(computerBoard);
            ArrayBoard(computerView);

            Console.WriteLine("Rozmistete svoje lode:");
            PlaceShipsManually(playerBoard);

            Console.WriteLine("Pocitac rozmistuje svoje lode");
            PlaceShipsRandomly(computerBoard);

            Console.WriteLine("Hra zacina!");

            //cyklus hry
            while (true)
            {
                Console.WriteLine("Vase pole:");
                ArrayBoard(playerBoard);
                Console.WriteLine("Pohled na pole pocitace:");
                ArrayBoard(computerView);

                PlayerTurn(); //hraje hrac
                if (IsGameOver(computerBoard))
                {
                    Console.WriteLine("Gratuluju! Vyhral jsi.");
                    break;
                }

                ComputerTurn(); //hraje pocitac
                if (IsGameOver(playerBoard))
                {
                    Console.WriteLine("Prohráli jste. Počítač vás porazil.");
                    break;
                }
            }
        }
    }
}
