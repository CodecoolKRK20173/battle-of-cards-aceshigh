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


        public Dealer(int numberOfPlayers)
        {
            this._mainDeck = CreateMainDeck(numberOfPlayers);
            this._mainDeck.Shuffle();
            Console.WriteLine(_mainDeck.Count());

        }

        private MainDeck CreateMainDeck(int numberOfPlayers)
        {
            return _dao.CreateMainDeck(numberOfPlayers);
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
