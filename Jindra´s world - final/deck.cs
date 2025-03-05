using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jindra_s_world___final
{
    class Deck
    {
        private List<Card> cards;
        private Random rng = new Random();

        public Deck()
        {
            Reset(); //obnoveni balicku
        }

        public void Reset() //zde jse, si nechal poradit od chat gpt
        {
            string[] suits = { "♥", "♦", "♣", "♠" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            cards = new List<Card>();
            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    int value = int.TryParse(rank, out int num) ? num : (rank == "A" ? 11 : 10);
                    cards.Add(new Card(suit, rank, value));
                }
            }
        }

        public void Shuffle() //promichani balicku
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                (cards[i], cards[j]) = (cards[j], cards[i]); 
            }
        }

        public Card DrawCard()
        {
            if (cards.Count == 0) Reset(); //reset balicku, pokud nam dojdou karty
            Card drawnCard = cards[0];
            cards.RemoveAt(0);
            return drawnCard;
        }

    }
}
