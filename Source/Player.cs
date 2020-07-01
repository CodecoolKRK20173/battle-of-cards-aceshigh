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
        private PlayerHand playerHand;


        public Player(string name)
        {
            this.playerName = name;
            this.playerHand = new PlayerHand(new List<Card>());

        }
        public abstract string CallAttributeToFight(string attrName);
        public abstract string CallAttributeToFight(Card playedCard);
        public Card PlayCard()
        {
            var _playedCard = playerHand.DrawTopCard();
            playerHand.RemovePlayedCard();
            return _playedCard;
        }
        public void AddCardsToHand(List<Card> cardsForPlayer)
        {
            playerHand.AddCards(cardsForPlayer);
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
