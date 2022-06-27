using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEEK7.Models
{
    public class Card
    {
        public string Name { get; set; } = "Sample Card";
        public string DeckTheme { get; set; } = "Sample Deck";
        public int Value { get; set; } = 50;
        public Card(string Name,string DeckTheme, int Value){
            this.Name = Name;
            this.DeckTheme = DeckTheme;
            this.Value = Value;
        }

        public static void Create(string cardName, string cardTheme, int cardValue)
        {
            var newCard = new Card(cardName, cardTheme, cardValue);
            newCard.Name = cardName;
            newCard.DeckTheme = cardTheme;
            newCard.Value = cardValue;
            switch(cardTheme){
                case "Deck Number 1": Deck.StarterDeck.CardSet.Add(newCard); break;
                case "Deck Number 2": Deck.StarterDeck2.CardSet.Add(newCard); break;
                case "Deck Number 3": Deck.StarterDeck3.CardSet.Add(newCard); break;
            }
        }
        public static List<Card> getStarterDeck()
        {
            return Deck.StarterDeck.CardSet;
        }
    }
}