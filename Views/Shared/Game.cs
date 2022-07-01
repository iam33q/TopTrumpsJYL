using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEEK7.Models;

namespace WEEK7.Views.Shared
{
    public class Game
    {
        public string Name { get; set; } = "PublicMatch";
        public Deck PlayDeck { get; set; } = Deck.ManyDecks[0];
        public List<Player> Players {get;set;} = new List<Player>();
        
        public List<Card> PlayedCards { get; set; } = new List<Card>();
        private int[]? Turns;
        public IDictionary<int,Card>? EachCard;
        public Game(int NumberOfPlayers, string Name, List<Player> Players){
            this.Name = Name;
            this.Players = Players;
            this.PlayDeck = PlayDeck;
        }
        public static int[] SetTurns(List<Player> Players){
            int i =0;
            int[] arr;
            List<int> temp = new List<int>();
            foreach(var player in Players){
                player.turnNumber = i;
                temp.Add(i);
                i++;
            }
            return arr = temp.ToArray();
        }

        public static void StartTurn(Game game, int Turn){ 
            List<Card> CurrentTurn = new List<Card>();
            List<int> TurnTracker = new List<int>();
            IDictionary<int,Card> EachCard = new Dictionary<int,Card>();
            int n;
            foreach(var player in game.Players){ // Making Player going first actually go first
                if(player.goingFirst){
                    n = new Random().Next(0,game.PlayDeck.CardSet.Capacity);
                    Card selectedCard = game.PlayDeck.CardSet[n];
                    EachCard.Add(player.turnNumber,selectedCard);
                    game.PlayDeck.CardSet.Remove(selectedCard);
                }
            };
            foreach(var player in game.Players){ // Placing the rest of the players in order
                if(!player.goingFirst){
                    n = new Random().Next(0,game.PlayDeck.CardSet.Capacity);
                    Card selectedCard = game.PlayDeck.CardSet[n];
                    EachCard.Add(player.turnNumber,selectedCard);
                    game.PlayDeck.CardSet.Remove(selectedCard);                
                }
            };

        }
    }
}