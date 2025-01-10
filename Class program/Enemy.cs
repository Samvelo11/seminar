using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_program
{
    internal class Enemy
    {
        int healthBase;
        int health;
        int damageBase;
        int damage;
        int level;
        Random rng;

        public Enemy(int healthBase, int damageBase, int level)
        {
            this.healthBase = healthBase;
            health = this.healthBase * level;

            this.damageBase = damageBase;
            damage = this.damageBase * level;
            this.level = level;
            rng = new Random();

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
            return rng.Next(damage / 2, damage + 1);
        }

        public void Hurt(int amount)
        {
            health -= amount;
            Console.WriteLine("Enemy got hit " + amount + " damage");
            if (health <= 0) 
            {
                Console.WriteLine("Enemy is death");
            }
        }
        public bool IsDead() 
        {
            return health <= 0;
        }
    }
}
