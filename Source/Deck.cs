using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh
{
    public abstract class Deck
    {
        protected List<Card> _deckOfCards;

        protected Deck(List<Card> deck)
        {
            this._deckOfCards = deck;
        }
        public Card DrawTopCard()
        {
            return _deckOfCards[0];
        }
    }
}





}