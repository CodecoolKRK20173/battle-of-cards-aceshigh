using System;

namespace BattleOfCardsAcesHigh

{
    public class Square
    {
        private int _YCoordinates;
        private int _XCoordinates;
        private string _symbol;
        public static bool _faceDown;
        private bool _cardCorner;
        private bool _cardHorizontalEdge;
        private bool _cardVerticalEdge;

        public Square(int yCoordinates, int xCoordinates, bool cardCorner, bool cardHEdge, bool cardVEdge)
        {
            this._YCoordinates = yCoordinates;
            this._XCoordinates = xCoordinates;
            this._cardCorner = cardCorner;
            this._cardHorizontalEdge = cardHEdge;
            this._cardVerticalEdge = cardVEdge;
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
   
            if (_faceDown == true)
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

            else if (_faceDown == false)
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


