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
        private bool _isLoser;

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
            _playedCard.SetPlayedBy(this);
            playerHand.RemovePlayedCard();
            Console.WriteLine($"{playerName} has {playerHand.Count()} cards left.");
            return _playedCard;
        }

        public Card PeekCard()
        {
            return playerHand.DrawTopCard();
        }
        public void AddCardsToHand(List<Card> cardsForPlayer)
        {
            playerHand.AddCards(cardsForPlayer);
        }
        public string GetName()
        {
            return playerName;
        }
        public void CheckIfLoser()
        {
            if (playerHand.IsEmpty())
            {
                _isLoser = true;
            }
        }

        public bool IsLoser()
        {
            return _isLoser;
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
