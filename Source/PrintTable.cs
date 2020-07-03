using BattleOfCardsAcesHigh.Source;
using System.Collections.Generic;
using System.IO.Compression;

namespace BattleOfCardsAcesHigh

{
    public class PrintTable
    {
        private static int _tableHeight = 50;
        private static int _tableWidth = 65;


        public PrintTable()
        {
             
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


