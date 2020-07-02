using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh
{
    public abstract class Deck
    {
        protected List<Card> _deckOfCards;

        public Deck(List<Card> deck)
        {
            this._deckOfCards = deck;
        }
        public Card DrawTopCard()
        {
            return _deckOfCards[0];
        }

        public bool IsEmpty()
        {
            if (_deckOfCards.Count == 0)
            {
                return true;
            }
            return false;
        }

    }
}