using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jindra_s_world___final
{

    class Game
    {
        

        private Player jindra;
        private Dealer dealer;
        private Deck deck;
        private Random rng = new Random();

        public Game()
        {
            jindra = new Player("Jindra", 500); //jindra ma na zacatku 500
            dealer = new Dealer(); 
            deck = new Deck(); 
        }

        public void Start()
        {
            //uvod do hry
            Console.WriteLine("Vitej ve hre Jindra´s");
            Console.WriteLine("Hra je o Jindrovi.");
            Console.WriteLine("Jindra je zadlužený vdovec a snazi se vyhrat dost penez na novy zivot.");
            Console.WriteLine("Pomoc Jindrovi vydelat hranim BlackJacku dostatecnou sumu na start noveho zivota!");


            while (jindra.Balance > 0) //herni smycka
            {
                Console.WriteLine($"Jindrův zůstatek: {jindra.Balance} Kč");
                Console.Write("Kolik chceš vsadit? (0 pro odchod z kasina): ");
                int bet;
                if (!int.TryParse(Console.ReadLine(), out bet) || bet < 0 || bet > jindra.Balance)
                {
                    Console.WriteLine("Neplatna sazka, zkus to znovu.");
                    continue;
                }

                if (bet == 0) //pokud buden sazka rovna 0, jindra opusti kasino
                {
                    Console.WriteLine("Jindra konci a zacina svuj zivot s " + jindra.Balance + " kc.");
                    return;
                }

                PlayRound(bet); //spusteni kola
            }

            Console.WriteLine("Jindra prohral vsechny penize a skoncil na ulici. Konec hry.");
        }

        private void PlayRound(int bet)
        {
            deck.Shuffle(); //zamichani karet
            List<Card> playerHand = new List<Card> { deck.DrawCard(), deck.DrawCard() }; //rozdani karet hraci
            List<Card> dealerHand = new List<Card> { deck.DrawCard(), deck.DrawCard() }; //rozdani karet dealerovi

            int playerScore = CalculateHandValue(playerHand); //vypocet hracovi ruky
            int dealerScore = CalculateHandValue(dealerHand); //dealerova ruka

            Console.WriteLine($"Jindra dostal: {playerHand[0]}, {playerHand[1]} (soucet: {playerScore})");
            Console.WriteLine($"Dealer ma: {dealerHand[0]}, ?");

            if (playerScore == 21) //hrac ma skore 21
            {
                Console.WriteLine("Blackjack! Jindra vyhral!");
                jindra.Balance += bet * 2;
                return;
            }

            while (playerScore < 21) //skore hrace pod 21
            {
                Console.WriteLine($"Tvuj aktualni soucet: {playerScore}");
                Console.Write("Chces dalsi kartu? (a/n): ");
                if (Console.ReadLine().ToLower() != "a") break;
                playerHand.Add(deck.DrawCard());
                playerScore = CalculateHandValue(playerHand);
                Console.WriteLine($"Jindra dostal: {playerHand[playerHand.Count - 1]} (soucet: {playerScore})");
            }

            if (playerScore > 21) //hrac ma skore nad 21
            {
                Console.WriteLine("Jindra pretahl! Prohral.");
                jindra.Balance -= bet;
                return;
            }

            while (dealerScore < 17) //pokud ma dealer pod 17 soucet karet
            {
                dealerHand.Add(deck.DrawCard());
                dealerScore = CalculateHandValue(dealerHand);
            }

            Console.WriteLine($"Dealer ma: {string.Join(", ", dealerHand)} (soucet: {dealerScore})");

            if (dealerScore > 21 || playerScore > dealerScore) //pokud dealer bude mit skore vice jak 21
            {
                Console.WriteLine("Jindra vyhral!");
                jindra.Balance += bet;
            }
            else
            {
                Console.WriteLine("Jindra prohral.");
                jindra.Balance -= bet;
            }
        }

        private int CalculateHandValue(List<Card> hand) //pocitani karet
        {
            int sum = 0;
            int aceCount = 0;
            foreach (var card in hand)
            {
                sum += card.Value;
                if (card.Rank == "A") aceCount++;
            }

            while (sum > 21 && aceCount > 0)
            {
                sum -= 10; //eso z 11 na 1
                aceCount--;
            }
            return sum;
        }
    
    }
}
