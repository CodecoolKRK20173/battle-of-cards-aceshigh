using BattleOfCardsAcesHigh.Source;
using System.Collections.Generic;

namespace BattleOfCardsAcesHigh

{
    public class PrintTable
    {
        private static int _tableHeight = 44;
        private static int _tableWidth = 65;
        private static List<List<List<Square>>> _printTable;


        public PrintTable()
        {
            _printTable = new List<List<List<Square>>>();

        }

        public void PlaceCards(Table newTable)
        {
            int numberOfPlayers = (newTable.GetAllPlayers()).Count;

        }
        public override string ToString()
        {
            return base.ToString();
        }
    }


}


