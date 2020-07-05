using BattleOfCardsAcesHigh;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace BattleOfCardsAcesHigh
{
    public abstract class Player : IPlayer
    {
        private string playerName;
        private PlayerHand playerHand;
        private bool _isLoser;
        private string _playerLocationSymbol;

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
        public string GetPlayerName()
        {
            return playerName;
        }

        public PlayerHand GetPlayerHand()
        {
            return playerHand;
        }

        public string GetName()
        {
            return playerName;
        }

        public string GetSymbol()
        {
            return _playerLocationSymbol;
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

        public void SetPlayerSymbol(int index)
        {
            var allSymbols = new List<string> { "----->", "<------", "/\\_____", "*****\\/" };
            this._playerLocationSymbol = allSymbols[index];

        }

        public override string ToString()
        {

            string cardFaceDown = "";
            string cardTopBottom = "+--------------------+";
            string cardRow = "|                    |";
            string cardSymbol = "| " + this._playerLocationSymbol.PadRight(18) + " |";
            string name = "| Hand of:           |";
            string cardsLeft = "| Cards left:        |";
            string playerName = "| " + this.playerName.PadRight(18) + " |";
            string cardsCount = "| " + this.playerHand.Count().ToString().PadRight(18) + " |";

            return cardFaceDown += cardTopBottom + cardRow + cardRow + cardSymbol + cardRow + cardRow + name + playerName + cardRow + cardsLeft + cardsCount + cardRow + cardTopBottom;
        }
    }
}
