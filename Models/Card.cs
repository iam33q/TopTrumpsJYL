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
            Deck selectedDeck = new Deck("Placeholder",new List<Card>());
            bool cardPassed = false;
            newCard.Name = cardName;
            newCard.DeckTheme = cardTheme;
            newCard.Value = cardValue;

            foreach(var deck in Deck.ManyDecks){ // Parsing through each deck to check for valid deck theme
                if(deck.Theme == newCard.DeckTheme){
                    selectedDeck=deck;
                    cardPassed = true;
                }
            }
            if(cardPassed){ // Actually assigning the card to a deck according to its deck theme
                selectedDeck.CardSet.Add(newCard);
                selectedDeck.NumberOfCards++;
                // Alert user of invalid deck name
            } else {
                //Alert user of successful card assignment to deck
            }
        }
        public static List<Card> getStarterDeck()
        {
            return Deck.StarterDeck.CardSet;
        }
    }
}