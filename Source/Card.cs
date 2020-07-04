using System;
using System.Collections.Generic;
using System.Linq;
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
            string printCard = "";
            int cardWidth = 19;
            string cardTopBottom = "+--------------------+";
            string cardRow = "|                    |";
            string cardSymbol = "|          *         |";
            string cardName = "| " + _cardName.PadRight(cardWidth-1) + " |";
            string cardSpeed = "| Speed: " + _speed.ToString().PadRight(cardWidth - (_speed.ToString().Length + 7)) + " |";
            string cardInt = "| Intelligence: " + _intelligence.ToString().PadRight(cardWidth - (_intelligence.ToString().Length + 14)) + " |";
 
            
            string cardPower = "";
            if (_power.ToString().Length == 2)
            {
                cardPower += "| Power: " + _power.ToString().PadRight(cardWidth - (_power.ToString().Length + 6)) + " |";
            }

            else if (_power.ToString().Length == 1)
            {
                cardPower += "| Power: " + _power.ToString().PadRight(cardWidth - (_power.ToString().Length + 7)) + " |";
            }

            string cardDescription = "";
            if (_description.Length >= cardWidth)
            {
                var splitDescription = _description.Split(" ");
                int splitCount = splitDescription.Count();
                string line1 = "";
                string line2 = "";
      
                for (int i = 0; i < splitCount; i++)
                {
                    if (i <= 1)
                    {
                        line1 += splitDescription[i] + " ";
                    }

                    else 
                    {
                        line2 += splitDescription[i] + " ";
                    }
                }
                cardDescription += "| " + line1.PadRight(cardWidth - 1) + " |" + "| " + line2.PadRight(cardWidth - 1) + " |";
                printCard += cardTopBottom + cardRow + cardName + cardRow + cardDescription + cardSymbol + cardRow + cardPower + cardSpeed + cardInt + cardRow + cardTopBottom;
            }
            
            else if (_description.Length < cardWidth)
            {
                cardDescription += "| " + _description.PadRight(cardWidth - 1) + " |";
                printCard += cardTopBottom + cardRow + cardName + cardRow + cardDescription + cardRow + cardSymbol + cardRow + cardPower + cardSpeed + cardInt + cardRow + cardTopBottom;
            }

            return printCard;

        }

    }
}


