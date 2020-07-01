using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BattleOfCardsAcesHigh

{
    public struct Card : IComparable<Card>
    {
        private int _power;
        private int _speed;
        private int _intelligence;
        private string _cardName;
        private string _description;
        private int _statToCompare;
        private Player _playedBy;

z        public Card(int power, int speed, int intelligence, string cardName, string description)
        {
            this._power = power;
            this._speed = speed;
            this._intelligence = intelligence;
            this._description = description;
            this._playedBy = null;
            this._cardName = cardName;
            this._statToCompare = 0;
        }

        public Player GetPlayedBy()
        {
            return _playedBy;
        }

        public void SetStatToCompare(string chosenStat)
        {
            if (chosenStat == "intelligence")
            {
                this._statToCompare = _intelligence;
            }

            else if (chosenStat == "power")
            {
                this._statToCompare = _power;
            }

            else if (chosenStat == "speed")
            {
                this._statToCompare = _speed;
            }
        }

        public int GetInt()
        {
            return _intelligence;
        }

        public int GetSpeed()
        {
            return _speed;
        }

        public int GetPower()
        {
            return _power;
        }

        public string GetName()
        {
            return _cardName;
        }

        public string GetDescription()
        {
            return _description;
        }


        public int CompareTo(Card card)
        {

            if (this._statToCompare > card._statToCompare)
            {
                return -1;
            }
            else if (this._statToCompare < card._statToCompare)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }



        public override string ToString()
        {

            int cardWidth = 19;
            string cardTopBottom = "+--------------------+\n";
            string cardRow = "|                    |\n";
            string cardName = "| " + _cardName.PadRight(cardWidth - _cardName.Length) + "|" + "\n";
            string cardDescription = "| " + _description.PadRight(cardWidth - _description.Length) + "|" + "\n";
            string cardPower = "| Power: " + _description.PadRight(cardWidth - (_power.ToString().Length + 7)) + "|" + "\n";
            string cardSpeed = "| Speed: " + _description.PadRight(cardWidth - (_speed.ToString().Length + 7)) + "|" + "\n";
            string cardInt = "| Intelligence: " + _description.PadRight(cardWidth - (_intelligence.ToString().Length + 14)) + "|" + "\n";
            string printCard = cardTopBottom + cardRow + cardName + cardDescription + cardRow + cardRow + cardRow + cardRow + cardPower + cardSpeed + cardInt + cardRow + cardTopBottom;

            return printCard;

        }

    }
}


