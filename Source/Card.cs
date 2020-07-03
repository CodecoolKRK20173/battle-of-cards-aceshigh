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
        private Player _playedBy;
        private string _chosenStat;

        public Card(int power, int speed, int intelligence, string cardName, string description)
        {
            this._power = power;
            this._speed = speed;
            this._intelligence = intelligence;
            this._description = description;
            this._playedBy = null;
            this._cardName = cardName;
            this._chosenStat = null;
   
        }

        public Player GetPlayedBy()
        {
            return _playedBy;
        }

        public void SetPlayedBy(Player player)
        {
            this._playedBy = player;
        }

        public int GetStatToCompare()
        {
            if (_chosenStat == "intelligence")
            {
                return _intelligence;
            }

            else if (_chosenStat == "power")
            {
                return _power;
            }

            else if (_chosenStat == "speed")
            {
                return _speed;
            }
            return 0;
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

        public void SetChosenStat(string chosenStat)
        {
            _chosenStat = chosenStat;
        }

        public string GetChosenStat()

        {
            return _chosenStat;
        }

        public int CompareTo(Card card)
        {

            if (this.GetStatToCompare() > card.GetStatToCompare())
            {
                return -1;
            }
            else if (this.GetStatToCompare() < card.GetStatToCompare())
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
            string cardName = "| " + _cardName.PadRight(cardWidth - _cardName.Length) + " |" + "\n";
            string cardDescription = "| " + _description.PadRight(_description.Length) + " |" + "\n";
            string cardPower = "| Power: " + _power.ToString().PadRight(cardWidth - (_power.ToString().Length + 7)) + " |" + "\n";
            string cardSpeed = "| Speed: " + _speed.ToString().PadRight(cardWidth - (_speed.ToString().Length + 7)) + " |" + "\n";
            string cardInt = "| Intelligence: " + _intelligence.ToString().PadRight(cardWidth - (_intelligence.ToString().Length + 14)) + " |" + "\n";
            string printCard = cardTopBottom + cardRow + cardName + cardDescription + cardRow + cardRow + cardRow + cardRow + cardPower + cardSpeed + cardInt + cardRow + cardTopBottom;

            return printCard;

        }

    }
}


