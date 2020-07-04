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

        public void PlaceTopCard(Card playedCard)
        {
            int index = 0;
            for (int y = 2; y < 15; y++)
            {
                for (int x = 37; x < 59; x++)
                {
                    char characterString = playedCard.ToString()[index];
                    _printTable[y][x] = characterString.ToString();
                    index++;
                }
            }
        }

        public void PlaceLeftCard(Card playedCard)
        {
            int index = 0;
            for (int y = 17; y < 30; y++)
            {
                for (int x = 2; x < 24; x++)
                {
                    char characterString = playedCard.ToString()[index];
                    _printTable[y][x] = characterString.ToString();
                    index++;
                }
            }
        }
        public void PlaceBottomCard(Card playedCard)
        {
            int index = 0;
            for (int y = 32; y < 45; y++)
            {
                for (int x = 37; x < 59; x++)
                {
                    char characterString = playedCard.ToString()[index];
                    _printTable[y][x] = characterString.ToString();
                    index++;
                }
            }
        }

        public void PlaceRightCard(Card playedCard)
        {
            int index = 0;
            for (int y = 17; y < 30; y++)
            {
                for (int x = 72; x < 94; x++)
                {
                    char characterString = playedCard.ToString()[index];
                    _printTable[y][x] = characterString.ToString();
                    index++;
                }
            }
        }

        public void PlaceCards(List<Card> playedCards, List<Player> allPlayers)
        {
            foreach (Player player in allPlayers)
            {
                foreach (Card card in playedCards)
                {
                    if (card.GetPlayedBy() == player && allPlayers[0] == player)
                    {
                        PlaceTopCard(card);
                    }
                    else if (card.GetPlayedBy() == player && allPlayers[1] == player)
                    {
                        PlaceBottomCard(card);
                    }
                    else if (card.GetPlayedBy() == player && allPlayers[2] == player)
                    {
                        PlaceLeftCard(card);
                    }
                    else if (card.GetPlayedBy() == player && allPlayers[3] == player)
                    {
                        PlaceRightCard(card);
                    }
                }
            }
        }

        public void PeekCard(Card card, Player player, List<Player> allPlayers)
        {
            int playerIndex = allPlayers.IndexOf(player);

            if (playerIndex == 0)
            {
                PlaceTopCard(card);
            }
            else if (playerIndex == 1)
            {
                PlaceBottomCard(card);
            }
            else if (playerIndex == 2)
            {
                PlaceLeftCard(card);
            }
            else if (playerIndex == 3)
            {
                PlaceRightCard(card);
            }

        }

        public void ResetTablePrint()
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


    }


}


