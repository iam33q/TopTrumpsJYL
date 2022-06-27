using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WEEK7.Models
{
    public class Deck
    {
        public string Theme {get;set;} = "Theme 1";
        public List<Card> CardSet {get;set;} = new List<Card>();

        public Deck(string Theme, List<Card> CardSet){
            this.Theme = Theme;
            this.CardSet = CardSet;
        }
        public void RemoveCard(string cardName){
            foreach (var item in this.CardSet)
            {
                if(item.Name == cardName){
                    System.Console.WriteLine(item.Name+" Card was removed from the deck.");
                    this.CardSet.Remove(item);
                }
            }
        }
        public void EditCard(string cardName, string newCardName, int newCardValue){
            foreach (var item in this.CardSet)
            {
                if (item.Name == cardName) //Selecting Card according to its name
                {
                    item.Name = newCardName;
                    item.Value = newCardValue;
                }
            }
        }
        // Very Nice Way to set up some default decks
        public static Deck StarterDeck {get;set;} = new Deck("Deck Number 1",new List<Card>());
        public static Deck StarterDeck2 {get;set;} = new Deck("Deck Number 2",new List<Card>());
        public static Deck StarterDeck3 {get;set;} = new Deck("Deck Number 3",new List<Card>());
        public static List<Deck> ManyDecks {get;set;} = new List<Deck>();
    }
}