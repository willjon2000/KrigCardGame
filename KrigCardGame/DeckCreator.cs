using System;
using System.Collections.Generic;
using System.Text;

namespace KrigCardGame
{
    public static class DeckCreator
    {
        public static Queue<Card> CreateCards()
        {
            Queue<Card> cards = new Queue<Card>();
            for (int i = 2; i <= 14; i++)
            {
                foreach (Suit suit in Enum.GetValues(typeof(Suit)))
                {
                    cards.Enqueue(new Card()
                    {
                        Suit = suit,
                        CardValue = i,
                        CardName = DisplayCorrectName(i, suit)
                    });
                }
            }
            return Shuffle(cards);
        }

        private static Queue<Card> Shuffle(Queue<Card> cards)
        {
            throw new NotImplementedException();
        }

        private static string DisplayCorrectName(int i, Suit suit)
        {
            throw new NotImplementedException();
        }
    }
}
