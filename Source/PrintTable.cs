using BattleOfCardsAcesHigh.Source;
using System.Collections.Generic;
using System.IO.Compression;

namespace BattleOfCardsAcesHigh

{
    public class PrintTable
    {
        private int _tableHeight = 65;
        private int _tableWidth = 47;
        private List<List<string>> _printTable;

        public PrintTable()
        {
            this._printTable = new List<List<string>>();
            List<string> tableRow = new List<string>();
            string element = "";

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

        public override string ToString()
        {
            string printTable = "+=================================================================+\n";

            for (int y = 0; y < _tableWidth; y++)
            {
                string printrow = "";

                for (int x = 0; x < _tableHeight; x++)
                {
                    printrow += _printTable[y][x] + " ";
                }

                printTable += "|" + printrow + "|" + "\n";
            }

            return printTable + "+=================================================================+\n";
        }
    }


}


