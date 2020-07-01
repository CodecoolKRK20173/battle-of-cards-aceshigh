using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAcesHigh
{
    interface IPlayer : IEquatable<Player>
    {
        Card PlayCard(); // Plays card form top of the player Hand
        string CallAttributeToFight(string attr);
        void AddCardsToHand(List<Card> deckForPLayer);
        string GetName();
        bool IsLoser();

    }
}
