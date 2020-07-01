using System;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh

{
    public class PrintCommentField
    {
        private List<Square> _fieldRow;
        private List<List<Square>> _fieldBoard;
        private static int _fieldHeight = 19;
        private static int _fieldWidth = 12;

        public PrintCommentField()
        {
            _fieldBoard = new List<List<Square>>();

            for (int y = 0; y < _fieldHeight; y++)
            {
                _fieldRow = new List<Square>();

                for (int x = 0; x < _fieldWidth; x++)
                {
                    if ((y == 0 || y == _fieldHeight - 1))
                    {
                        _fieldRow.Add(new Square(y, x, false, true, false, false));
                    }

                    else if (y > 0 || y < _fieldHeight - 1)
                    {
                        _fieldRow.Add(new Square(y, x, false, false, false, false));
                    }

                }
                _fieldBoard.Add(_fieldRow);
            }
        }

        public override string ToString()
        {
            string printField = "";

            for (int y = 0; y < _fieldHeight; y++)
            {
                string printRow = "";

                for (int x = 0; x < _fieldWidth; x++)
                {
                    printRow += _fieldBoard[y][x];
                }
                printField += printRow + "\n";
            }

            return printField;
        }

    }
}


