using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAcesHigh
{
    interface IPlayer : IEquatable<Player>
    {
        Card PlayCard();
        string CallAttributeToFight(string);
        void AddCardsToHand(Deck deckForPLayer);
        string GetName();
        bool IsLoser();

    }
}
