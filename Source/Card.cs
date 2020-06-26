using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh

{
    public struct Card : IComparable<Card>
    {
        private int _power;
        private int _speed;
        private int _intelligence;
        private int _statToCompare;
        private string _cardName;
        private string _description;
        private string _playedBy;

        public Card(int power, int speed, int intelligence, string cardName, string description, string playedBy)
        {
            this._power = power;
            this._speed = speed;
            this._intelligence = intelligence;
            this._description = description;
            this._playedBy = playedBy;
            this._cardName = cardName;
                 
        }

        public void SetStatToCompare(string chosenStat)
        {
            this._statToCompare = this.chosenStat;
        }

        public int CompareTo(Card card1, Card card2)
        {

            if (card1._statToCompare > card2._statToCompare)
            {
                return 1;
            }
            else if (card1._statToCompare < card2._statToCompare)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }


        public override string ToString()
        {
            int cardHeight = 11;
            int cardWidth = 19;
            string cardTopBottom = "+--------------------+\n";
            string cardRow = "|                    |\n";
            string cardName = "| " + _cardName.PadRight(cardWidth - _cardName.Length) + "|" + "\n";
            string cardDescription = "| " + _description.PadRight(cardWidth - _description.Length) + "|" + "\n";
            string cardPower = "| Power: " + _description.PadRight(cardWidth - (_power.Length + 7)) + "|" + "\n";
            string cardSpeed = "| Speed: " + _description.PadRight(cardWidth - (_speed.Length + 7)) + "|" + "\n";
            string cardInt = "| Intelligence: " + _description.PadRight(cardWidth - (_intelligence.Length + 14)) + "|" + "\n";

            string printCard = cardTopBottom + cardRow + cardName + cardDescription + (4 * cardRow) + cardPower + cardSpeed + cardInt + cardRow + cardTopBottom;
            return printCard;

        }
        
    }
}


