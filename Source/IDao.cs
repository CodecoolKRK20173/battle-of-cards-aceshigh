using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAcesHigh.Source
{
    interface IDao
    {
        MainDeck CreateMainDeck(int numberOfPlayers);

    }
}
