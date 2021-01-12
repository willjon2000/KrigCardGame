using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KrigCardGame
{
    public class Game
    {
        private Player Player1 { get; set; }
        private Player Player2 { get; set; }
        private int TurnCount { get; set; } // number of turns played

        public Game(string player1name, string player2name)
        {
            Player player1 = new Player(player1name);
            Player player2 = new Player(player2name);

            var Cards = DeckCreator.CreateCards(); // returns a shuffled deck

            var deck = player1.Deal(Cards); // returns player2's deck and player1 keeps his

            player2.Deck = deck;
        }




        public bool IsGameOver()
        {
            if (!Player1.Deck.Any())
            {
                Console.WriteLine(Player1.PlayerName + "is out of cards" 
                    + Player2.PlayerName + "WINS!");
                return true;
            }
            else if (!Player2.Deck.Any())
            {
                Console.WriteLine(Player2.PlayerName + "is out of cards"
                    + Player1.PlayerName + "WINS!");
                return true;
            }
            else if (TurnCount > 2000)
            {
                Console.WriteLine("Infinite game! lets call this whole thing off");
                return true;
            }
            return false;
        }
    }
}
