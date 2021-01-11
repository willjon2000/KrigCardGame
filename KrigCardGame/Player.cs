using System;
using System.Collections.Generic;
using System.Text;

namespace KrigCardGame
{
    public class Player
    {
        public string PlayerName { get; set; }
        public Queue<Card> Deck { get; set; }
    }
}
