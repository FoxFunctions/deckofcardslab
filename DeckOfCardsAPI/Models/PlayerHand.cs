using System;
namespace DeckOfCardsAPI.Models
{
    public class PlayerHand : Card
    {
        public bool success { get; set; }
        public Card[] cards { get; set; }
        public string deck_id { get; set; }
        public int remaining { get; set; }
    }
}

