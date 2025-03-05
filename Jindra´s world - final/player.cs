using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jindra_s_world___final
{
    class Player
    {   

        public string Name { get; } //jmeno hrace
        public int Balance { get; set; } //zustatek hrace

        public Player(string name, int balance)
        {
            Name = name;
            Balance = balance;
        }

    }
}
