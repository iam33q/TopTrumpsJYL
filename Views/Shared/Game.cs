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
        public Deck PlayDeck { get; set; } = Deck.StarterDeck; // Deck Selected for match
        public List<Player> Players {get;set;} = new List<Player>(); // Players added into the game
        
        public IDictionary<int,Card>? CurrentTurnCards; // Cards are dealt here every turn
        public Game(int NumberOfPlayers, string Name, List<Player> Players){
            this.Name = Name;
            this.Players = Players;
            this.PlayDeck = PlayDeck;
        }
        public static void SetTurns(List<Player> Players){
            int i =0;
            foreach(var player in Players){
                if(player.goingFirst){ // Making Player going first actually go first
                    player.turnNumber = i;
                    i++;
                }
            }
            foreach(var player in Players){
                if(!player.goingFirst){ // Placing the rest of the players in arbitrary order
                    player.turnNumber = i;
                    i++;
                }
            }
        }
        public static void StartTurn(Game game, int Turn){ //Deals the cards
            IDictionary<int,Card> CurrentTurnCards = new Dictionary<int,Card>();
            int n;
            SetTurns(game.Players);
            foreach(var player in game.Players){ 
                n = new Random().Next(0,game.PlayDeck.CardSet.Capacity);
                Card selectedCard = game.PlayDeck.CardSet[n];
                CurrentTurnCards.Add(player.turnNumber,selectedCard);
                game.PlayDeck.CardSet.Remove(selectedCard);
            };
        }
        public static void PlayTurn(List<Card> CurrentTurnCards, CardAttribute attr){
            
        }
        public static void EndTurn(){
            
        }
    }
}