using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BattleOfCardsAcesHigh.Source
{
    class Dealer : IComparer<Card>
    {
        private Deck _mainDeck;
        private Deck _playerHand;
        private IDao _dao = new CsvDao();

        public Dealer(int numberOfPlayers)
        {
            this._mainDeck = CreateMainDeck();
            this._mainDeck.Shuffle();
            this._mainDeck.SplitCards(numberOfPlayers);
        }

        private Deck CreateMainDeck()
        {
            return _dao.CreateMainDeck();
        }

        public void DealCards(IEnumerable<Player> players)
        {
            foreach (Player player in players)
            {
                _playerHand = _mainDeck[0];
                _mainDeck.RemoveAt(0);
                player.AddCardsToHand(_playerHand);
            }

        }

        public int Compare([AllowNull] Card x, [AllowNull] Card y)
        {
            return x.CompareTo(y);
        }
    }
}
