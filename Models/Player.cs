using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEEK7.Models
{
    public class Player 
    {
        public string playerName { get; set; } = "Player 1";
        public List<Card> cards { get; set; }
        public bool goingFirst { get; set; }
        public int turnNumber {get; set; }
        
        private CardAttribute? selectedAttribute {get; set; }

        public Player(string playerName, List<Card> cards, bool goingFirst, int turnNumber, CardAttribute selectedAttribute){
            this.playerName = playerName;
            this.cards=cards;
            this.goingFirst=goingFirst;
            this.turnNumber=turnNumber;
            this.selectedAttribute=selectedAttribute;
        }
        public void chooseAttribute1(Card TurnCard)
        {
            this.selectedAttribute=TurnCard.cardAttribute_1;
        }
        public void chooseAttribute2(Card TurnCard)
        {
            this.selectedAttribute=TurnCard.cardAttribute_2;
        }
        public void chooseAttribute3(Card TurnCard)
        {
            this.selectedAttribute=TurnCard.cardAttribute_3;
        }
        public void chooseAttribute4(Card TurnCard)
        {
            this.selectedAttribute=TurnCard.cardAttribute_4;
        }
        public void chooseAttribute5(Card TurnCard)
        {
            this.selectedAttribute=TurnCard.cardAttribute_5;
        }
    }
}