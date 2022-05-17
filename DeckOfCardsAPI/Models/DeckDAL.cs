using System;
using System.Net;
using Newtonsoft.Json;
namespace DeckOfCardsAPI.Models
{
	
	public class DeckDAL
	{
		public DeckDAL()
		{
		}

		public Deck NewDeck()
        {
			string url = "https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";
			HttpWebRequest request = WebRequest.CreateHttp(url);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			StreamReader rd = new StreamReader(response.GetResponseStream());

			string JSON = rd.ReadToEnd();

			Deck d = JsonConvert.DeserializeObject<Deck>(JSON);
			return d;
		}

		public PlayerHand DrawACard(string deckId)
        {
			PlayerHand ph = new PlayerHand();
			string url = $"https://deckofcardsapi.com/api/deck/{deckId}/draw/?count=5";
			HttpWebRequest request = WebRequest.CreateHttp(url);
			HttpWebResponse response = (HttpWebResponse)request.GetResponse();

			StreamReader rd = new StreamReader(response.GetResponseStream());

			string JSON = rd.ReadToEnd();

			PlayerHand c = JsonConvert.DeserializeObject<PlayerHand>(JSON);

			return c;

		}
	}
}

