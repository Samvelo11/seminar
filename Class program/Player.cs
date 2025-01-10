using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_program
{
    internal class Player
    {
        private int health;
        public int damage;
        public string name;
        private Random rng;
        public Player(int health, int damage, string name)
        {
            SetHealth(health);
            this.damage = damage;
            this.name = name;
            rng = new Random();
        }

        public void SetHealth(int value)
        {
            health = value;
            if (health < 0)
            {
                health = 0;
            }
        }
        public void Hurt(int amount)
        {
            health -= amount;
            Console.WriteLine("Player got hit " + amount + " damage");
            if (health <= 0)
            {
                Console.WriteLine("Player is death");
            }
        }
        public int GetHealth() //vraci nam health
        {
            return health;
        }
        public int GetDamage()
        {
            return damage;
        }
        public int GetRandomizedDamage()
        {
            float randomizedDamage = damage * rng.Next(5, 15) / 10f;
            return(int)randomizedDamage;
        }

        public bool IsDead() //dokud neumre 
        {
            return health <= 0;
        }
    }
}
