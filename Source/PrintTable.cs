using BattleOfCardsAcesHigh.Source;
using System;
using System.Collections.Generic;
using System.IO.Compression;

namespace BattleOfCardsAcesHigh

{
    public class PrintTable
    {
        private int _tableHeight = 96;
        private int _tableWidth = 47;
        private List<List<string>> _printTable;

        public PrintTable()
        {
            this._printTable = new List<List<string>>();
            List<string> tableRow = new List<string>();
            string element = " ";

            for (int y = 0; y < _tableWidth; y++)
            {
                tableRow = new List<string>();

                for (int x = 0; x < _tableHeight; x++)
                {
                    tableRow.Add(element);
                }

                _printTable.Add(tableRow);

            }
        }

        public int GetTableHeight()
        {
            return _tableHeight;
        }

        public int GetTableWidth()
        {
            return _tableWidth;
        }

        public List<List<string>> GetPrintTable()
        {
            return _printTable;
        }

        public void PlaceTopCard(List<Card> playedCard)
        {
            int index = 0;
            for (int y = 2; y < 15; y++)
            {
                for (int x = 37; x < 59; x++)
                {
                    char characterString = playedCard[0].ToString()[index];
                    _printTable[y][x] = characterString.ToString();
                    index++;
                }
            }
        }

    }


}


