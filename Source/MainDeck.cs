using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh
{
    public class MainDeck : Deck
    {

        public MainDeck(List<Card> listOfCards)
        {
            this._deckOfCards = listOfCards;
        }

        public Card DrawTopCard()
        {
            return Card;
        }

        public List<Card> Shuffle()
        {
            return List<Card>;
        }

        public List<Card> SplitDeck (int numberOfPlayers)
        {
            return List<Card>;
        }
    }
}