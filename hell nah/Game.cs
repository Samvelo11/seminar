using System;
internal class Game
{

	private Player jindra;
	private Dealer dealer;
	private Deck deck;
	private Random rng = new Random();

	public Game()
	{
		jindra = new Player("jindra", 500);  //jindra ma 500kc
		dealer = new Dealer();
		deck = new Deck();
	}

	public void Start()
	{
		Console.WriteLine("Vitejte v Kasinu!"); //pripsat si pribeh

		while (jindra.Balance > 0)
		{
			Console.WriteLine($"Jindruv zustatek je {jindra.Balance} Kc");
			Console.Write("kolik chces vsadit? (vsad 0 pro odchod z kasina): ")
			int bet;       //nase sazka
			if (!int.TryParse(Console.ReadLine(), out bet) || bet <= 0 || bet > jindra.Balance)  //funkce naseho sazeni, hlida nam zadani zpravneho vstupu
			{
				Console.WriteLine("Neplatna sazka, zkus to znovu:");
				continue;
			}
			PlayRound(bet);
		} 

		Console.WriteLine("Jidnra prohral vsechny penize co mel. Bohuzel se musel prestehovat na ulici, kde jeho zivot skoncil. " n / "Pomoz v pristim zivote Jindrovi vyhrat.");
    }
}
