using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh
{
    public class MainDeck : Deck

    {
        public MainDeck(List<Card> deck) : base(deck) { }

    
    public void Shuffle()
        {
            Random randomDeck = new Random();
            int numberOfCards = _deckOfCards.Count;

            for (int i = numberOfCards - 1; i > 1; i--)
            {
                int randomNext = randomDeck.Next(i + 1);

                Card Value = _deckOfCards[randomNext];
                _deckOfCards[randomNext] = _deckOfCards[i];
                _deckOfCards[i] = Value;
            }
        }

        public List<List<Card>> SplitCards(int numberOfPlayers)
        {
            int index = 0;
            List<List<Card>> listOfLists = new List<List<Card>>();
            

            foreach (Card card in _deckOfCards)
            {
                listOfLists[index].Add(card);
                index++;

                if (index > numberOfPlayers)
                {
                    index = 0;
                }
            }
            return listOfLists;
           
        }
    }
}