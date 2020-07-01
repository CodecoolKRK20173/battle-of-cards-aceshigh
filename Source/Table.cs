using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BattleOfCardsAcesHigh.Source
{
 
    class Table
    {
        private List<Card> _playedCards;
        private List<Card> _winnersCards;
        private LinkedList<Player> _allPlayers;
        private Dealer _januszDealer;
        private static int _tableWidth = 65;
        private static int _tableHeight = 44;
        private static List<List<List<Square>>> _tableBoard;

        public Table(LinkedList<Player> allPlayers)
        {
            this._allPlayers = allPlayers;
            this._januszDealer = new Dealer(_allPlayers);
            _januszDealer.DealCards();
             
        }


        public void SortPlayedCards(List<Card> playedCards, string statToCompare)
        {
            foreach (Card card in playedCards)
            {
                card.SetStatToCompare(statToCompare);
            }

            playedCards.Sort(_januszDealer);

            this._playedCards = playedCards;

        }

        public bool IsONeWinner()
        {
            if (_playedCards[0].CompareTo(_playedCards[1]) == 0)
            {
                return false;
            }

            return true;
        }

        public Player GetWinner()
        {
            return _playedCards[0].GetPlayedBy();
        }

        public List<Player> GetAllWinners()
        {
            var allWinners = new List<Player>();

            foreach (Card card in _playedCards)
            {
                if (card.CompareTo(_playedCards[0]) == 0)
                {
                    allWinners.Add(card.GetPlayedBy());
                }
            }
            return allWinners;
        }



        public void PassCardsToWinner(Player winner)
        {
            winner.AddCardsToHand(_winnersCards);
        }
    }
}
