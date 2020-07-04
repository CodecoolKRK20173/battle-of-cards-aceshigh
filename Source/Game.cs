using BattleOfCardsAcesHigh.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleOfCardsAcesHigh
{
    class Game
    {
        private Table _table;
      

        public Game(int numberOfPlayers)
        {
            List<Player> gamePlayers = new List<Player>();

            for (int ctr = 0; ctr < numberOfPlayers; ctr++)
            {
                Console.WriteLine("Please provide your name adventurer: ");
                string userName = Console.ReadLine();
                gamePlayers.Add(new HumanPlayer(userName));
            }

            ShufflePlayers(gamePlayers);

            _table = new Table(gamePlayers);

        }
        public bool GameEnd()
        {
            if (_table.GetAllPlayers().Count > 1)
            {
                return false;
            }
            return true;
        }
        public Player GetCurrentPlayer()
        {
            return _table.GetCurrentPlayer();
        }

        public string GetStatToCompare()
        {
            string statToCompare = "";

            while (statToCompare != "i" && statToCompare != "s" && statToCompare != "p" && statToCompare != "intelligence" && statToCompare != "speed" && statToCompare != "power")
            {
                Console.WriteLine($"{GetCurrentPlayer().GetName()} please choose the attribute to fight:\ni - intelligence;\ns - speed;\np - power");
                statToCompare = Console.ReadLine().ToLower();
            }

            if (statToCompare == "i")
            {
                statToCompare = "intelligence";
            }
            else if (statToCompare == "s")
            {
                statToCompare = "speed";
            }
            else if (statToCompare == "p")
            {
                statToCompare = "power";
            }

            return statToCompare;
        }

        public void ShufflePlayers(List<Player> gamePlayers)
        {
            Random rng = new Random();
            int n = gamePlayers.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Player value = gamePlayers[k];
                gamePlayers[k] = gamePlayers[n];
                gamePlayers[n] = value;

            }
        }

        public void Play()
        {
            var allPlayers = _table.GetAllPlayers();
            while (!GameEnd())
            {

                Console.WriteLine($"\nThis is the next card of {GetCurrentPlayer().GetName()}:");
                _table.GetPrintTable().ResetTablePrint();
                _table.GetPrintTable().PeekCard(GetCurrentPlayer().PeekCard(), GetCurrentPlayer(), allPlayers);
                Console.WriteLine(_table);
                string statToCompare = GetStatToCompare();
                _table.PlayCards(statToCompare);
                var playedCards =_table.GetPlayedCards();
                _table.GetPrintTable().ResetTablePrint();
                _table.GetPrintTable().PlaceCards(playedCards, allPlayers);
                Console.WriteLine(_table);
                _table.ResetWinnerCards();
                _table.SetWinnerCards(playedCards);
                _table.SortPlayedCards(playedCards);
        
                while (!_table.IsONeTurnWinner())
                {
                    Console.WriteLine("It is a draw!");
                    _table.PlayCards(_table.GetAllTurnWinners(), statToCompare);
                    playedCards = _table.GetPlayedCards();
                    _table.GetPrintTable().ResetTablePrint();
                    _table.GetPrintTable().PlaceCards(playedCards, allPlayers);
                    Console.WriteLine(_table);
                    _table.SetWinnerCards(playedCards);
                    _table.SortPlayedCards(playedCards);
                    
                    Console.ReadKey();
                }
                _table.PassCardsToWinner(_table.GetTurnWinner());
                Console.WriteLine($"{_table.GetTurnWinner().GetName()} won {_table.GetWinnerCards().Count} cards!");
                _table.RemoveLosers();
                _table.SetNextPlayer();

            }

            Console.WriteLine($"{GetCurrentPlayer().GetName()} WON!");
        }
    }
}
