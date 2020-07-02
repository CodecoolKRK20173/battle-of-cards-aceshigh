using System;

namespace BattleOfCardsAcesHigh
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game(4);
            game.Play();
        }
    }
}
