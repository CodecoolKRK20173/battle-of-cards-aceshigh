using System;

namespace BattleOfCardsAcesHigh

{
    public class Square
    {
        private int _YCoordinates;
        private int _XCoordinates;
        private string _symbol;
        bool _faceDown;
        bool _cardCorner;
        bool _cardHorizontalEdge;
        bool _cardVerticalEdge;

        public Square(int yCoordinates, int xCoordinates)
        {
            this._YCoordinates = yCoordinates;
            this._XCoordinates = xCoordinates;
        }

        public int GetYCoordinates()
        {
            return _YCoordinates;
        }

        public int GetXCoordinates()
        {
            return _XCoordinates;
        }

        public bool GetFaceDown()
        {
            return _faceDown;
        }

        public bool GetCardCorner()
        {
            return _cardCorner;
        }

        public bool GetCardHEdge()
        {
            return _cardHorizontalEdge;
        }

        public bool GetCardVEdge()
        {
            return _cardHorizontalEdge;
        }
        public override string ToString()
        {
   
            if (this._faceDown == true)
            {
                if (this._cardCorner == true)
                {
                    _symbol = "+";
                }

                else if (this._cardHorizontalEdge == true)
                {
                    _symbol = "-";
                }

                else if (this._cardVerticalEdge == true)
                {
                    _symbol = "|";
                }

                else
                {
                    _symbol = "▒";
                }
            }

            else if (this._faceDown == false)
            {
                if (this._cardCorner == true)
                {
                    _symbol = "+";
                }

                else if (this._cardHorizontalEdge == true)
                {
                    _symbol = "-";
                }

                else if (this._cardVerticalEdge == true)
                {
                    _symbol = "|";
                }

                else
                {
                    _symbol = " ";
                }
            }
            return _symbol;
        }

    }
}


