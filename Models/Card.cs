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
        public CardAttribute cardAttribute_1;
        public CardAttribute cardAttribute_2;
        public CardAttribute cardAttribute_3;
        public CardAttribute cardAttribute_4;
        public CardAttribute cardAttribute_5;

        public Card(string Name,string DeckTheme, int Value){
            this.Name = Name;
            this.DeckTheme = DeckTheme;
            this.Value = Value;
        }

        public Card(string Name,string DeckTheme, string attribute_1Name, string attribute_1Value,string attribute_2Name, string attribute_2Value, string attribute_3Name, string attribute_3Value,string attribute_4Name, string attribute_4Value,string attribute_5Name, string attribute_5Value)
        {
            this.Name = Name;
            this.DeckTheme = DeckTheme;
            this.cardAttribute_1 = new CardAttribute(attribute_1Name,attribute_1Value);
            this.cardAttribute_2 = new CardAttribute(attribute_2Name,attribute_2Value);
            this.cardAttribute_3 = new CardAttribute(attribute_3Name,attribute_3Value);
            this.cardAttribute_4 = new CardAttribute(attribute_4Name,attribute_4Value);
            this.cardAttribute_5 = new CardAttribute(attribute_5Name,attribute_5Value);
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