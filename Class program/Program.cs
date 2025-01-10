using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_program
{
    internal class Program
    {

        static void Duel(Player player, Enemy enemy)
        {
            while (!player.IsDead() && !enemy.IsDead())
            {
                //utok hrace
                enemy.Hurt(player.GetRandomizedDamage());
                if (!enemy.IsDead())
                {
                    //utok enemaka
                    player.Hurt(enemy.GetRandomizedDamage());
                }

                //vypis
                Console.WriteLine("Player health: " + player.GetHealth());
                Console.WriteLine("Enemy health: " + enemy.GetHealth());
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            Player player = new Player(100, 10, "Ignac");
            Enemy enemy = new Enemy(20, 2, 1);
           
            Duel(player, enemy);

            Enemy enemy2 = new Enemy(25, 5, 2);

            Duel(player, enemy2);

            Console.ReadKey();
        } 
    }
}
