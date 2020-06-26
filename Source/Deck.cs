using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh
{
	public abstract class Deck
    {
        private List<Card> _deckOfCards;

        public abstract Card DrawTopCard();
        
    }
}