using System;
using System.Collections.Generic;
using System.Linq;
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
            //shuffle the existing cards with the fisher yates metode
            List<Card> transformedCards = cards.ToList();
            Random rnd = new Random();

            for (int i = transformedCards.Count - 1; i > 0 ; --i)
            {
                // Step 2: pick a random number which has not been shuffled
                int rc = rnd.Next(i + 1);

                // Step 3: Swap the item
                // with the last "unselected" card in the collection
                Card temp = transformedCards[i];
                transformedCards[i] = transformedCards[rc];
                transformedCards[rc] = temp;
            }

            Queue<Card> shuffledCards = new Queue<Card>();
            foreach(var card in transformedCards)
            {
                shuffledCards.Enqueue(card);
            }
            return shuffledCards;
        }

        private static string DisplayCorrectName(int value, Suit suit)
        {
            string displayValue = "";
            if (value >= 2 && value <= 10)
            {
                displayValue = value.ToString();
            }
            else if(value == 11)
            {
                displayValue = "J";
            }
            else if(value == 12)
            {
                displayValue = "Q";
            }
            else if(value == 13)
            {
                displayValue = "K";
            }
            else if (value == 14)
            {
                displayValue = "A";
            }
            return displayValue + Enum.GetName(typeof(Suit), suit)[0];
        }
    }
}
