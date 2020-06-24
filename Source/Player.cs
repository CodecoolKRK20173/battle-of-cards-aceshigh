using System;
using System.Collections.Generic;
using System.Text;

namespace BattleOfCardsAcesHigh
{
    abstract class Player : IEquatable<Player>
    {
        private string playerName;
        private Deck playerHand;


        public Player(string name)
        {

        }

        public bool Equals(Player other)
        {
            if (other == null)
                return false;

            if (this.playerName == other.playerName)
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Player playerObj = obj as Player;
            if (playerObj == null)
                return false;
            else
                return Equals(playerObj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(playerName, playerHand);
        }
    }
}
