using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using WEEK7.Models;
using WEEK7.Views.Shared;

namespace WEEK7.Controllers
{
    public class HelloWorldController : Controller
    {
        bool decksLoaded = false;
        public IActionResult CardView()
        {   
            var OurDecks = Deck.ManyDecks;
            if(!decksLoaded){
                OurDecks.Add(Deck.StarterDeck);
                OurDecks.Add(Deck.StarterDeck2);
                OurDecks.Add(Deck.StarterDeck3);
                decksLoaded = true;
            }
            return View("CardView",OurDecks);
        }
        public IActionResult GamePage()
        {   
            var PlayerList = new List<Player>();
            var Game1 = new Game(0,"NewGame",PlayerList);
            
            return View("GamePage",Game1);
        }

        public IActionResult CreateCard(string cardName, string CardTheme, int cardValue){
            Card.Create(cardName,CardTheme,cardValue);
            return RedirectToAction("CardView");
        }
        public IActionResult HowToPlay(){
            return View();
        }
        
    }
}