using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh
{
    public class PlayerHand : Deck

    {
        public PlayerHand(List<Card> deck) : base(deck) { }

        public void AddCards(List<Card> wonCards)
        {
            foreach (Card card in wonCards)
            {
                _deckOfCards.Add(card);
            }

        }

        public void RemovePlayedCard()
        {
            Card playedCard = DrawTopCard();
            this._deckOfCards.Remove(playedCard);
        }
    }
}