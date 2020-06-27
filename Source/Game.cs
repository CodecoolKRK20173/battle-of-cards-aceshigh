using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BattleOfCardsAcesHigh
{
    class Game
    {
        private LinkedList<Player> gamePlayers = new LinkedList<Player>();
        private LinkedListNode<Player> currentPlayer;

        public Game(int numberOfPlayers)
        {
            this.currentPlayer = gamePlayers.First;

            // Get list of Players' names

            for (int ctr = 0; ctr < numberOfPlayers; ctr++)
            {
                gamePlayers.AddLast(new Player())
            }

        }
        public bool GameEnd()
        {
            if (gamePlayers.)
            foreach (var player in gamePlayers)
            {
                if (!player.IsLoser())
                {
                    return false;
                }
            }
            return true;
        }
        public Player GetCurrentPlayer()
        {
            return currentPlayer.Value
        }
        public 
    }
}
