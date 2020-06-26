using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BattleOfCardsAcesHigh.Source
{
 
    class Table : IComparer<Card>
    {
        private List<Card> _playedCards;
        private List<Player> _allPlayers;

        public Table()
        {
            Dealer janusz = new Dealer(_allPlayers.Count);
            janusz.DealCards(_allPlayers);
             
        }
        public int Compare([AllowNull] Card x, [AllowNull] Card y)
        {
            return x.CompareTo(y);
        }
    }
}
