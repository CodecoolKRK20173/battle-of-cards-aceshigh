using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh

{
    public class PrintCard
    {
        private List<Square> _cardRow;
        private List<List<Square>> _cardBoard;
        private static int _cardHeight = 19;
        private static int _cardWidth = 12;

        public PrintCard()
        {
            this._cardBoard = new List<List<Square>>();


           for (int x = 0; x < _cardHeight; x++)
           {
           this._cardRow = new List<Square>();
                for (int y = 0; y < _cardHeight; y++)
                {
                    if (Square._faceDown == true)
                    {
                        if ((y == 0 || y == _cardWidth - 1) && (x == 0 || x == _cardHeight - 1))
                        {
                            _cardRow.Add(new Square(y, x, true, false, false));
                        }

                        else if ((y > 0 || y < _cardWidth - 1) && (x == 0 || x == _cardHeight - 1))
                        {
                            _cardRow.Add(new Square(y, x, false, true, false));
                        }

                        else if ((y == 0 || y == _cardWidth - 1) && (x > 0 || x < _cardHeight - 1))
                        {
                            _cardRow.Add(new Square(y, x, false, false, true));
                        }

                        else if ((y > 0 || y < _cardWidth - 1) && (x > 0 || x < _cardHeight - 1))
                        {
                            _cardRow.Add(new Square(y, x, false, false, false));
                        }
                    }

                    else if (Square._faceDown == false)
                    {
                        if ((y == 0 || y == _cardWidth - 1) && (x == 0 || x == _cardHeight - 1))
                        {
                            _cardRow.Add(new Square(y, x, true, false, false));
                        }

                        else if ((y > 0 || y < _cardWidth - 1) && (x == 0 || x == _cardHeight - 1))
                        {
                            _cardRow.Add(new Square(y, x, false, true, false));
                        }

                        else if ((y == 0 || y == _cardWidth - 1) && (x > 0 || x < _cardHeight - 1))
                        {
                            _cardRow.Add(new Square(y, x, false, false, true));
                        }

                        else if ((y > 0 || y < _cardWidth - 1) && (x > 0 || x < _cardHeight - 1))
                        {
                            _cardRow.Add(new Square(y, x, false, false, false));
                        }
                    }
                }
                _cardBoard.Add(_cardRow);
           }

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}


