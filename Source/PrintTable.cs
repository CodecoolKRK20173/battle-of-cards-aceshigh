using BattleOfCardsAcesHigh.Source;
using System.Collections.Generic;
using System.IO.Compression;

namespace BattleOfCardsAcesHigh

{
    public class PrintTable
    {
        private static int _tableHeight = 44;
        private static int _tableWidth = 65;
        private static List<List<List<Square>>> _printTable;
        private static List<List<Square>> _printRow;
        private static List<Square> _printSquare;


        public PrintTable()
        {
            _printTable = new List<List<List<Square>>>();

            for (int z = 0; z < _tableHeight; z++)
            _printRow = new List<List<Square>>();
            {
                for (int y = 0; y <_tableHeight; y++)
                {
                    _printSquare = new List<Square>();

                    for (int x = 0; x < _tableWidth; x++)
                    {
                        _printSquare.Add(new Square(y, x, false, false, false, false));
                    }
                    _printRow.Add(_printSquare);
                }
                _printTable.Add(_printRow);
            }

        }

        public void PlaceCards(Table newTable)
        {
            int numberOfPlayers = (newTable.GetAllPlayers()).Count;
   

            if (numberOfPlayers == 4)
            {
 

            }

            else if (numberOfPlayers == 3)
            {

            }

            else if (numberOfPlayers == 1)
            {

            }

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }


}


