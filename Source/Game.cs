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
        private CommentField _commentField = new CommentField();


        public Game(int numberOfPlayers)
        {
            List<Player> gamePlayers = new List<Player>();
            GameTitle();

            Console.WriteLine("Please provide the number of players(2-4)");
            string number = Console.ReadLine();
            while (number != "4" && number != "3" && number !="2")
                    {
                if (number == "4")
                {
                    numberOfPlayers = 4;
                }

                else if (number == "3")
                {
                    numberOfPlayers = 3;
                }
                else if (number == "2")
                {
                    numberOfPlayers = 2;
                }

                else
                {
                    Console.WriteLine("Please provide number from 2 to 4");
                    number = Console.ReadLine();
                }
            }

            for (int ctr = 0; ctr < numberOfPlayers; ctr++)
            {
                Console.WriteLine("Please provide your name adventurer: ");
                string userName = Console.ReadLine();
                gamePlayers.Add(new HumanPlayer(userName));
            }

            ShufflePlayers(gamePlayers);

            _table = new Table(gamePlayers);

        }

        public void GameTitle()
        {
            View.PrintTitle();
            Console.ReadKey();
            Console.Clear();
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

        public void AddCommentsToChooseAttribute()
        {
            var allComments = new List<string>
            {
            $"This is the next card of:",
            $"{GetCurrentPlayer().GetName()}",
            "Please choose the attribute",
            "to fight with:",
            "p - power",
            "s - speed",
            "i - intelligence",
            
            };

            _commentField.SetComment(allComments[0]);
            _commentField.SetComment(allComments[1]);
            _commentField.SetComment(allComments[2]);
            _commentField.SetComment(allComments[3]);
            _commentField.SetComment(allComments[4]);
            _commentField.SetComment(allComments[5]);
            _commentField.SetComment(allComments[6]);
        }

        public void AddCommentDraw(string statToCompare)
        {
            _commentField.SetComment("It was a DRAW!");
            _commentField.SetComment("Play-off!");
            _commentField.SetComment("You are still fighting with:");
            _commentField.SetComment(statToCompare);
        }

        public void AddCommentTurnWinner()
        {
            _commentField.SetComment($"{_table.GetTurnWinner().GetName()} won {_table.GetWinnerCards().Count} cards!");
        }

        public void AddCommentFinalWinner()
        {
            _commentField.SetComment($"{GetCurrentPlayer().GetName()} WON!");
        }

        public void AddCommentPlayTurn()
        {
            _commentField.SetComment($"Playing cards...");
        }


        public void Play()
        {

            var allPlayers = new List<Player>();
            allPlayers.AddRange(_table.GetAllPlayers());
            while (!GameEnd())
            {

                _commentField.ResetComments();
                AddCommentsToChooseAttribute();
                _table.GetPrintTable().ResetTablePrint(allPlayers);
                _table.GetPrintTable().PlaceCommentField(_commentField);
                _table.GetPrintTable().PeekCard(GetCurrentPlayer().PeekCard(), GetCurrentPlayer(), allPlayers);
                Console.Clear();
                Console.WriteLine(_table);
                string statToCompare = GetStatToCompare();
                _table.PlayCards(statToCompare);
                var playedCards = _table.GetPlayedCards();
                _table.GetPrintTable().ResetTablePrint(allPlayers);
                _commentField.ResetComments();
                AddCommentPlayTurn();
                _table.GetPrintTable().PlaceCommentField(_commentField);
                _table.GetPrintTable().PlaceCards(playedCards, allPlayers);
                Console.Clear();
                Console.WriteLine(_table);
                _table.ResetWinnerCards();
                _table.SetWinnerCards(playedCards);
                _table.SortPlayedCards(playedCards);

                Console.ReadKey();

                while (!_table.IsONeTurnWinner())
                {
                    _commentField.ResetComments();
                    AddCommentDraw(statToCompare);
                    _table.PlayCards(_table.GetAllTurnWinners(), statToCompare);
                    playedCards = _table.GetPlayedCards();
                    _table.GetPrintTable().ResetTablePrint(allPlayers);
                    _table.GetPrintTable().PlaceCommentField(_commentField);
                    _table.GetPrintTable().PlaceCards(playedCards, allPlayers);
                    Console.Clear();
                    Console.WriteLine(_table);
                    _table.SetWinnerCards(playedCards);
                    _table.SortPlayedCards(playedCards);

                    Console.ReadKey();
                }
                _table.PassCardsToWinner(_table.GetTurnWinner());
                _commentField.ResetComments();
                AddCommentTurnWinner();
                _table.GetPrintTable().ResetTablePrint(allPlayers);
                _table.GetPrintTable().PlaceCommentField(_commentField);
                Console.Clear();
                Console.WriteLine(_table);
                _table.RemoveLosers();
                _table.SetNextPlayer();

                Console.ReadKey();
            }
            _commentField.ResetComments();
            AddCommentFinalWinner();
            _table.GetPrintTable().ResetTablePrint(allPlayers);
            _table.GetPrintTable().PlaceCommentField(_commentField);
            Console.Clear();
            Console.WriteLine(_table);
        }
    }
}
