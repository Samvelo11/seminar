using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jindra_s_world___final
{
    class Card
    {
        //nacteni vlastnosti karet, zde jsem pouzil chat gpt
        public string Suit { get; }
        public string Rank { get; }
        public int Value { get; }

        public Card(string suit, string rank, int value)
        {
            Suit = suit;
            Rank = rank;
            Value = value;
        }

        public override string ToString()
        {
            return $"{Rank}{Suit}"; // vrati nam karty jako text např. "10♠"
        }
    }
}
