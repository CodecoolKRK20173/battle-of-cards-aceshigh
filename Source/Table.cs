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
        private List<Player> _allPlayers;

        public Table()
        {
            Dealer janusz = new Dealer(_allPlayers.Count);
            janusz.DealCards(_allPlayers);
            _playedCards.Sort(janusz);
             
        }
    }
}
