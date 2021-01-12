using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KrigCardGame
{
    public class Player
    {
        public string PlayerName { get; set; }
        public Queue<Card> Deck { get; set; }

        public Player()
        {

        }

        public Player(String name)
        {
            PlayerName = name;
        }

        public Queue<Card> Deal(Queue<Card> cards)
        {
            Queue<Card> player1Cards = new Queue<Card>();
            Queue<Card> player2Cards = new Queue<Card>();

            int counter = 2;
            // runs the code until there is no more cards in the Queue
            while (cards.Any())
            {
                
                if (counter % 2 == 0)
                {
                    // adds an element to player2Cards and removes
                    // that card from the cards queue
                    player2Cards.Enqueue(cards.Dequeue());
                }
                else
                {
                    player1Cards.Enqueue(cards.Dequeue());
                }
                counter++;
            }

            Deck = player1Cards;
            return player2Cards;
        }
    }
}
