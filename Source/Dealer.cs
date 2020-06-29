using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace BattleOfCardsAcesHigh.Source
{
    class Dealer : IComparer<Card>
    {
        private IEnumerable<Player> _allPlayers;
        private MainDeck _mainDeck;
        private PlayerHand _playerHand;
        private IDao _dao = new CsvDao();

        public Dealer(IEnumerable<Player> players)
        {
            this._mainDeck = CreateMainDeck();
            this._mainDeck.Shuffle();
            this._allPlayers = players;

        }

        private MainDeck CreateMainDeck()
        {
            return _dao.CreateMainDeck();
        }

        public void DealCards()
        {
            
            var splittedDeck = _mainDeck.SplitCards(_allPlayers.Count());
            _mainDeck = null;

            foreach (Player player in _allPlayers)
            {
                _playerHand = new PlayerHand(splittedDeck[0]);
                splittedDeck.RemoveAt(0);
                player.AddCardsToHand(_playerHand);
            }

        }

        public int Compare([AllowNull] Card x, [AllowNull] Card y)
        {
            return x.CompareTo(y);
        }
    }
}
