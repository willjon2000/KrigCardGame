using System;
using System.Collections.Generic;
using System.Text;

namespace KrigCardGame
{
    public enum Suit
    {
        Clubs,
        Diamonds,
        Spades,
        Hearts
    }
    public class Card
    {
        public string CardName { get; set; }
        public Suit Suit { get; set; }
        public int CardValue { get; set; }


    }
    
}
