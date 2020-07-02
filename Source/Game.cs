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
    }
}
