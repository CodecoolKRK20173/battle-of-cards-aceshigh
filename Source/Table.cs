using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace BattleOfCardsAcesHigh.Source
{
    public class Table
    {
        private List<Card> _playedCards;
        private List<Card> _winnersCards;
        private List<Player> _allPlayers;
        private int _currentPLayerIndex;
        private Player _currentPlayer;
        private Dealer _januszDealer;
        private PrintTable _printTable = new PrintTable();


        public Table(List<Player> allPlayers)
        {
            this._allPlayers = allPlayers;
            this._januszDealer = new Dealer(_allPlayers.Count);
            _januszDealer.DealCards(_allPlayers);
            _currentPlayer = _allPlayers[_currentPLayerIndex];

        }


        public void SortPlayedCards(List<Card> playedCards)
        {

            playedCards.Sort(_januszDealer);

            this._playedCards = playedCards;

        }

        public bool IsONeTurnWinner()
        {
            if (_playedCards[0].CompareTo(_playedCards[1]) == 0)
            {
                return false;
            }

            return true;
        }

        public Player GetTurnWinner()
        {
            return _playedCards[0].GetPlayedBy();
        }

        public PrintTable GetPrintTable()
        {
            return _printTable;
        }

        public List<Player> GetAllTurnWinners()
        {
            var allWinners = new List<Player>();

            foreach (Card card in _playedCards)
            {
                if (card.CompareTo(_playedCards[0]) == 0)
                {
                    allWinners.Add(card.GetPlayedBy());
                }
            }
            return allWinners;
        }


        public void SetNextPlayer()
        {
            _currentPLayerIndex++;

            if (_currentPLayerIndex >= _allPlayers.Count)
            {
                _currentPLayerIndex = 0;
            }

            _currentPlayer = _allPlayers[_currentPLayerIndex];
        }

        public Player GetCurrentPlayer()
        {
            return _currentPlayer;
        }

        public List<Player> GetAllPlayers()
        {
            return _allPlayers;
        }

        public void PassCardsToWinner(Player winner)
        {
            winner.AddCardsToHand(_winnersCards);
        }

        public void RemoveLosers()
        {
            foreach (Player player in _allPlayers.Reverse<Player>())
            {
                player.CheckIfLoser();

                if (player.IsLoser())
                {
                    _allPlayers.Remove(player);
                }
            }
        }

        public void SetWinnerCards(List<Card> winnerCards)
        {
            this._winnersCards.AddRange(winnerCards);
        }

        public List<Card> GetWinnerCards()
        {
            return _winnersCards;
        }

        public void ResetWinnerCards()
        {
            this._winnersCards = new List<Card>();
        }

        public void PlayCards(string chosenStat)
        {
            List<Card> playedCards = new List<Card>();
            foreach (Player player in _allPlayers)
            {
                var playedCard = player.PlayCard();
                playedCard.SetChosenStat(chosenStat);
                playedCards.Add(playedCard);
            }

            this._playedCards = playedCards;
        }

        public void PlayCards(List<Player> turnPlayers, string chosenStat)
        {
            List<Card> playedCards = new List<Card>();
            foreach (Player player in turnPlayers)
            {
                var playedCard = player.PlayCard();
                playedCard.SetChosenStat(chosenStat);
                playedCards.Add(playedCard);
            }

            this._playedCards = playedCards;
        }

        public List<Card> GetPlayedCards()
        {
            return _playedCards;
        }



        public override string ToString()
        {
           
            int width = _printTable.GetTableWidth();
            int height = _printTable.GetTableHeight();
            List<List<string>> board = _printTable.GetPrintTable();

            {
                string printTable = "+================================================================================================+\n";

                for (int y = 0; y < width; y++)
                {
                    string printrow = "";

                    for (int x = 0; x < height; x++)
                    {
                        printrow += board[y][x];
                    }

                    printTable += "|" + printrow + "|" + "\n";
                }

                return printTable + "+================================================================================================+\n";
            }

        }
    }
}
