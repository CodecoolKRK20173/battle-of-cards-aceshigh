using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace BattleOfCardsAcesHigh.Source
{
    class Dealer : IComparer<Card>
    {
        private MainDeck _mainDeck;
        private IDao _dao = new CsvDao();

        public Dealer()
        {
            this._mainDeck = CreateMainDeck();
            this._mainDeck.Shuffle();

        }

        private MainDeck CreateMainDeck()
        {
            return _dao.CreateMainDeck();
        }

        public void DealCards(IEnumerable<Player> allPlayers)
        {
            
            var splittedDeck = _mainDeck.SplitCards(allPlayers.Count());
            _mainDeck = null;

            foreach (Player player in allPlayers)
            {
                player.AddCardsToHand(splittedDeck[0]);
                splittedDeck.RemoveAt(0);
            }

        }

        public int Compare([AllowNull] Card x, [AllowNull] Card y)
        {
            return x.CompareTo(y);
        }
    }
}
