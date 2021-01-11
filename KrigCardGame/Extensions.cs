using System;
using System.Collections.Generic;
using System.Text;

namespace KrigCardGame
{
    public static class Extensions
    {
        public static void Enqueu(this Queue<Card> cards, Queue<Card> newCards)
        {
            foreach (var card in newCards)
            {
                cards.Enqueue(card);
            }
        }

    }
}
