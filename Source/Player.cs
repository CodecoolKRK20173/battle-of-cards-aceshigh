using BattleOfCardsAcesHigh;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BattleOfCardsAcesHigh
{
    public abstract class Player : IPlayer
    {
        private string playerName;
        private Deck playerHand;


        public Player(string name)
        {
            this.playerName = name;
            this.playerHand = new PlayerHand(new List<Card>());

        }
        public abstract string CallAttributeToFight(string attrName);
        public Card PlayCard()
        {
            return playerHand.DrawCard()
        }
        public void AddCardsToHand(Deck deckForPLayer)
        {
            playerHand.AddCards(deckForPLayer);
        }
        public string GetName()
        {
            return playerName;
        }
        public bool IsLoser()
        {
            if (playerHand.IsEmpty())
            {
                return true;
            }
            return false;
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
