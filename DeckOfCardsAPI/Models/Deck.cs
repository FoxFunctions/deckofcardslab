using System;
namespace DeckOfCardsAPI.Models
{
	public class Deck
	{
        public string success { get; set; }
		public string deck_id { get; set; }
        public string remaining { get; set; }
		public string shuffled { get; set; }

        public Deck()
		{
		}
	}
}

